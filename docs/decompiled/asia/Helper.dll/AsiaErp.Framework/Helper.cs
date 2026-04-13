using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AsiaErp.Framework.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace AsiaErp.Framework;

[StandardModule]
[HideModuleName]
public sealed class Helper
{
	public enum ErrorType : short
	{
		Error = 1,
		Warning = 2,
		Info = 4
	}

	public enum HashEncodeType
	{
		NoEncode,
		Base64,
		Hex
	}

	public class Sender
	{
		private RSAParameters rsaPubParams;

		private RSAParameters rsaPrivateParams;

		public RSAParameters PublicParameters => rsaPubParams;

		public Sender()
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rsaPrivateParams = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true);
			rsaPubParams = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
		}

		public byte[] HashAndSign(byte[] encrypted)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			SHA1Managed sHA1Managed = new SHA1Managed();
			rSACryptoServiceProvider.ImportParameters(rsaPrivateParams);
			byte[] rgbHash = sHA1Managed.ComputeHash(encrypted);
			return rSACryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA1"));
		}

		public byte[] EncryptData(RSAParameters rsaParams, byte[] toEncrypt)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(rsaParams);
			return rSACryptoServiceProvider.Encrypt(toEncrypt, fOAEP: false);
		}
	}

	public class Receiver
	{
		private RSAParameters rsaPubParams;

		private RSAParameters rsaPrivateParams;

		public RSAParameters PublicParameters => rsaPubParams;

		public Receiver()
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rsaPrivateParams = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true);
			rsaPubParams = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
		}

		public bool VerifyHash(RSAParameters rsaParams, byte[] signedData, byte[] signature)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			SHA1Managed sHA1Managed = new SHA1Managed();
			rSACryptoServiceProvider.ImportParameters(rsaParams);
			byte[] rgbHash = sHA1Managed.ComputeHash(signedData);
			return rSACryptoServiceProvider.VerifyHash(rgbHash, CryptoConfig.MapNameToOID("SHA1"), signature);
		}

		public string DecryptData(byte[] encrypted)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(rsaPrivateParams);
			byte[] bytes = rSACryptoServiceProvider.Decrypt(encrypted, fOAEP: false);
			return uTF8Encoding.GetString(bytes);
		}
	}

	public class Hash
	{
		public enum Provider
		{
			SHA1,
			SHA256,
			SHA384,
			SHA512,
			MD5,
			CRC32
		}

		private class CRC32 : HashAlgorithm
		{
			private int result;

			private int[] crcLookup;

			public override byte[] Hash
			{
				get
				{
					byte[] bytes = BitConverter.GetBytes(~result);
					Array.Reverse((Array)bytes);
					return bytes;
				}
			}

			public CRC32()
			{
				result = -1;
				crcLookup = new int[256]
				{
					0, 1996959894, -301047508, -1727442502, 124634137, 1886057615, -379345611, -1637575261, 249268274, 2044508324,
					-522852066, -1747789432, 162941995, 2125561021, -407360249, -1866523247, 498536548, 1789927666, -205950648, -2067906082,
					450548861, 1843258603, -187386543, -2083289657, 325883990, 1684777152, -43845254, -1973040660, 335633487, 1661365465,
					-99664541, -1928851979, 997073096, 1281953886, -715111964, -1570279054, 1006888145, 1258607687, -770865667, -1526024853,
					901097722, 1119000684, -608450090, -1396901568, 853044451, 1172266101, -589951537, -1412350631, 651767980, 1373503546,
					-925412992, -1076862698, 565507253, 1454621731, -809855591, -1195530993, 671266974, 1594198024, -972236366, -1324619484,
					795835527, 1483230225, -1050600021, -1234817731, 1994146192, 31158534, -1731059524, -271249366, 1907459465, 112637215,
					-1614814043, -390540237, 2013776290, 251722036, -1777751922, -519137256, 2137656763, 141376813, -1855689577, -429695999,
					1802195444, 476864866, -2056965928, -228458418, 1812370925, 453092731, -2113342271, -183516073, 1706088902, 314042704,
					-1950435094, -54949764, 1658658271, 366619977, -1932296973, -69972891, 1303535960, 984961486, -1547960204, -725929758,
					1256170817, 1037604311, -1529756563, -740887301, 1131014506, 879679996, -1385723834, -631195440, 1141124467, 855842277,
					-1442165665, -586318647, 1342533948, 654459306, -1106571248, -921952122, 1466479909, 544179635, -1184443383, -832445281,
					1591671054, 702138776, -1328506846, -942167884, 1504918807, 783551873, -1212326853, -1061524307, -306674912, -1698712650,
					62317068, 1957810842, -355121351, -1647151185, 81470997, 1943803523, -480048366, -1805370492, 225274430, 2053790376,
					-468791541, -1828061283, 167816743, 2097651377, -267414716, -2029476910, 503444072, 1762050814, -144550051, -2140837941,
					426522225, 1852507879, -19653770, -1982649376, 282753626, 1742555852, -105259153, -1900089351, 397917763, 1622183637,
					-690576408, -1580100738, 953729732, 1340076626, -776247311, -1497606297, 1068828381, 1219638859, -670225446, -1358292148,
					906185462, 1090812512, -547295293, -1469587627, 829329135, 1181335161, -882789492, -1134132454, 628085408, 1382605366,
					-871598187, -1156888829, 570562233, 1426400815, -977650754, -1296233688, 733239954, 1555261956, -1026031705, -1244606671,
					752459403, 1541320221, -1687895376, -328994266, 1969922972, 40735498, -1677130071, -351390145, 1913087877, 83908371,
					-1782625662, -491226604, 2075208622, 213261112, -1831694693, -438977011, 2094854071, 198958881, -2032938284, -237706686,
					1759359992, 534414190, -2118248755, -155638181, 1873836001, 414664567, -2012718362, -15766928, 1711684554, 285281116,
					-1889165569, -127750551, 1634467795, 376229701, -1609899400, -686959890, 1308918612, 956543938, -1486412191, -799009033,
					1231636301, 1047427035, -1362007478, -640263460, 1088359270, 936918000, -1447252397, -558129467, 1202900863, 817233897,
					-1111625188, -893730166, 1404277552, 615818150, -1160759803, -841546093, 1423857449, 601450431, -1285129682, -1000256840,
					1567103746, 711928724, -1274298825, -1022587231, 1510334235, 755167117
				};
			}

			protected override void HashCore(byte[] array, int ibStart, int cbSize)
			{
				int num = checked(cbSize - 1);
				int num2 = ibStart;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						int num5 = (result & 0xFF) ^ array[num2];
						result = ((result & -256) / 256) & 0xFFFFFF;
						result ^= crcLookup[num5];
						num2 = checked(num2 + 1);
						continue;
					}
					break;
				}
			}

			protected override byte[] HashFinal()
			{
				byte[] bytes = BitConverter.GetBytes(~result);
				Array.Reverse((Array)bytes);
				return bytes;
			}

			public override void Initialize()
			{
				result = -1;
			}
		}

		private HashAlgorithm _Hash;

		private CryptographyData _HashValue;

		public CryptographyData Value => _HashValue;

		private Hash()
		{
			_HashValue = new CryptographyData();
		}

		public Hash(Provider p)
		{
			_HashValue = new CryptographyData();
			switch ((int)p)
			{
			case 5:
				_Hash = new CRC32();
				break;
			case 4:
				_Hash = new MD5CryptoServiceProvider();
				break;
			case 0:
				_Hash = new SHA1Managed();
				break;
			case 1:
				_Hash = new SHA256Managed();
				break;
			case 2:
				_Hash = new SHA384Managed();
				break;
			case 3:
				_Hash = new SHA512Managed();
				break;
			}
		}

		public CryptographyData Calculate(ref Stream s)
		{
			_HashValue.Bytes = _Hash.ComputeHash(s);
			return _HashValue;
		}

		public CryptographyData Calculate(CryptographyData d)
		{
			return CalculatePrivate(d.Bytes);
		}

		public CryptographyData Calculate(CryptographyData d, CryptographyData salt)
		{
			byte[] array = new byte[checked(d.Bytes.Length + salt.Bytes.Length - 1 + 1)];
			salt.Bytes.CopyTo(array, 0);
			d.Bytes.CopyTo(array, salt.Bytes.Length);
			return CalculatePrivate(array);
		}

		private CryptographyData CalculatePrivate(byte[] b)
		{
			_HashValue.Bytes = _Hash.ComputeHash(b);
			return _HashValue;
		}
	}

	public class Symmetric
	{
		public enum Provider
		{
			DES,
			RC2,
			Rijndael,
			TripleDES
		}

		private const string _DefaultIntializationVector = "%1Az=-@qT";

		private const int _BufferSize = 2048;

		private CryptographyData _data;

		private CryptographyData _key;

		private CryptographyData _iv;

		private SymmetricAlgorithm _crypto;

		private byte[] _EncryptedBytes;

		private bool _UseDefaultInitializationVector;

		public int KeySizeBytes
		{
			get
			{
				return _crypto.KeySize / 8;
			}
			set
			{
				_crypto.KeySize = checked(value * 8);
				_key.MaxBytes = value;
			}
		}

		public int KeySizeBits
		{
			get
			{
				return _crypto.KeySize;
			}
			set
			{
				_crypto.KeySize = value;
				_key.MaxBits = value;
			}
		}

		public CryptographyData Key
		{
			get
			{
				return _key;
			}
			set
			{
				_key = value;
				_key.MaxBytes = _crypto.LegalKeySizes[0].MaxSize / 8;
				_key.MinBytes = _crypto.LegalKeySizes[0].MinSize / 8;
				_key.StepBytes = _crypto.LegalKeySizes[0].SkipSize / 8;
			}
		}

		public CryptographyData IntializationVector
		{
			get
			{
				return _iv;
			}
			set
			{
				_iv = value;
				_iv.MaxBytes = _crypto.BlockSize / 8;
				_iv.MinBytes = _crypto.BlockSize / 8;
			}
		}

		private Symmetric()
		{
		}

		public Symmetric(Provider provider, bool useDefaultInitializationVector = true)
		{
			switch ((int)provider)
			{
			case 0:
				_crypto = new DESCryptoServiceProvider();
				break;
			case 1:
				_crypto = new RC2CryptoServiceProvider();
				break;
			case 2:
				_crypto = new RijndaelManaged();
				break;
			case 3:
				_crypto = new TripleDESCryptoServiceProvider();
				break;
			}
			Key = RandomKey();
			if (useDefaultInitializationVector)
			{
				IntializationVector = new CryptographyData("%1Az=-@qT");
			}
			else
			{
				IntializationVector = RandomInitializationVector();
			}
		}

		public CryptographyData RandomInitializationVector()
		{
			_crypto.GenerateIV();
			return new CryptographyData(_crypto.IV);
		}

		public CryptographyData RandomKey()
		{
			_crypto.GenerateKey();
			return new CryptographyData(_crypto.Key);
		}

		private void ValidateKeyAndIv(bool isEncrypting)
		{
			if (_key.IsEmpty)
			{
				if (!isEncrypting)
				{
					throw new CryptographicException("No key was provided for the decryption operation!");
				}
				_key = RandomKey();
			}
			if (_iv.IsEmpty)
			{
				if (!isEncrypting)
				{
					throw new CryptographicException("No initialization vector was provided for the decryption operation!");
				}
				_iv = RandomInitializationVector();
			}
			_crypto.Key = _key.Bytes;
			_crypto.IV = _iv.Bytes;
		}

		public CryptographyData Encrypt(CryptographyData d, CryptographyData key)
		{
			Key = key;
			return Encrypt(d);
		}

		public CryptographyData Encrypt(CryptographyData d)
		{
			MemoryStream memoryStream = new MemoryStream();
			ValidateKeyAndIv(isEncrypting: true);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, _crypto.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(d.Bytes, 0, d.Bytes.Length);
			cryptoStream.Close();
			memoryStream.Close();
			return new CryptographyData(memoryStream.ToArray());
		}

		public CryptographyData Encrypt(Stream s, CryptographyData key, CryptographyData iv)
		{
			IntializationVector = iv;
			Key = key;
			return Encrypt(s);
		}

		public CryptographyData Encrypt(Stream s, CryptographyData key)
		{
			Key = key;
			return Encrypt(s);
		}

		public CryptographyData Encrypt(Stream s)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] buffer = new byte[2049];
			ValidateKeyAndIv(isEncrypting: true);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, _crypto.CreateEncryptor(), CryptoStreamMode.Write);
			for (int num = s.Read(buffer, 0, 2048); num > 0; num = s.Read(buffer, 0, 2048))
			{
				cryptoStream.Write(buffer, 0, num);
			}
			cryptoStream.Close();
			memoryStream.Close();
			return new CryptographyData(memoryStream.ToArray());
		}

		public CryptographyData Decrypt(CryptographyData encryptedData, CryptographyData key)
		{
			Key = key;
			return Decrypt(encryptedData);
		}

		public CryptographyData Decrypt(Stream encryptedStream, CryptographyData key)
		{
			Key = key;
			return Decrypt(encryptedStream);
		}

		public CryptographyData Decrypt(Stream encryptedStream)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] buffer = new byte[2049];
			ValidateKeyAndIv(isEncrypting: false);
			CryptoStream cryptoStream = new CryptoStream(encryptedStream, _crypto.CreateDecryptor(), CryptoStreamMode.Read);
			for (int num = cryptoStream.Read(buffer, 0, 2048); num > 0; num = cryptoStream.Read(buffer, 0, 2048))
			{
				memoryStream.Write(buffer, 0, num);
			}
			cryptoStream.Close();
			memoryStream.Close();
			return new CryptographyData(memoryStream.ToArray());
		}

		public CryptographyData Decrypt(CryptographyData encryptedData)
		{
			checked
			{
				CryptographyData result;
				try
				{
					MemoryStream stream = new MemoryStream(encryptedData.Bytes, 0, encryptedData.Bytes.Length);
					byte[] array = new byte[encryptedData.Bytes.Length - 1 + 1];
					ValidateKeyAndIv(isEncrypting: false);
					CryptoStream cryptoStream = new CryptoStream(stream, _crypto.CreateDecryptor(), CryptoStreamMode.Read);
					try
					{
						cryptoStream.Read(array, 0, encryptedData.Bytes.Length - 1);
					}
					catch (CryptographicException ex)
					{
						ProjectData.SetProjectError((Exception)ex);
						CryptographicException inner = ex;
						throw new CryptographicException("Unable to decrypt data. The provided key may be invalid.", inner);
					}
					finally
					{
						cryptoStream.Close();
					}
					result = new CryptographyData(array);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					result = null;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}
	}

	public class Asymmetric
	{
		public class PublicKey
		{
			public string Modulus;

			public string Exponent;

			public PublicKey()
			{
			}

			public PublicKey(string KeyXml)
			{
				LoadFromXml(KeyXml);
			}

			public void LoadFromConfig()
			{
				Modulus = Utils.GetConfigString("PublicKey.Modulus");
				Exponent = Utils.GetConfigString("PublicKey.Exponent");
			}

			public string ToConfigSection()
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder;
				stringBuilder2.Append(Utils.WriteConfigKey("PublicKey.Modulus", Modulus));
				stringBuilder2.Append(Utils.WriteConfigKey("PublicKey.Exponent", Exponent));
				stringBuilder2 = null;
				return stringBuilder.ToString();
			}

			public void ExportToConfigFile(string filePath)
			{
				StreamWriter streamWriter = new StreamWriter(filePath, append: false);
				streamWriter.Write(ToConfigSection());
				streamWriter.Close();
			}

			public void LoadFromXml(string keyXml)
			{
				Modulus = Utils.GetXmlElement(keyXml, "Modulus");
				Exponent = Utils.GetXmlElement(keyXml, "Exponent");
			}

			public RSAParameters ToParameters()
			{
				return new RSAParameters
				{
					Modulus = Convert.FromBase64String(Modulus),
					Exponent = Convert.FromBase64String(Exponent)
				};
			}

			public string ToXml()
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder;
				stringBuilder2.Append(Utils.WriteXmlNode("RSAKeyValue"));
				stringBuilder2.Append(Utils.WriteXmlElement("Modulus", Modulus));
				stringBuilder2.Append(Utils.WriteXmlElement("Exponent", Exponent));
				stringBuilder2.Append(Utils.WriteXmlNode("RSAKeyValue", isClosing: true));
				stringBuilder2 = null;
				return stringBuilder.ToString();
			}

			public void ExportToXmlFile(string filePath)
			{
				StreamWriter streamWriter = new StreamWriter(filePath, append: false);
				streamWriter.Write(ToXml());
				streamWriter.Close();
			}
		}

		public class PrivateKey
		{
			public string Modulus;

			public string Exponent;

			public string PrimeP;

			public string PrimeQ;

			public string PrimeExponentP;

			public string PrimeExponentQ;

			public string Coefficient;

			public string PrivateExponent;

			public PrivateKey()
			{
			}

			public PrivateKey(string keyXml)
			{
				LoadFromXml(keyXml);
			}

			public void LoadFromConfig()
			{
				Modulus = Utils.GetConfigString("PublicKey.Modulus");
				Exponent = Utils.GetConfigString("PublicKey.Exponent");
				PrimeP = Utils.GetConfigString("PrivateKey.P");
				PrimeQ = Utils.GetConfigString("PrivateKey.Q");
				PrimeExponentP = Utils.GetConfigString("PrivateKey.DP");
				PrimeExponentQ = Utils.GetConfigString("PrivateKey.DQ");
				Coefficient = Utils.GetConfigString("PrivateKey.InverseQ");
				PrivateExponent = Utils.GetConfigString("PrivateKey.D");
			}

			public RSAParameters ToParameters()
			{
				return new RSAParameters
				{
					Modulus = Convert.FromBase64String(Modulus),
					Exponent = Convert.FromBase64String(Exponent),
					P = Convert.FromBase64String(PrimeP),
					Q = Convert.FromBase64String(PrimeQ),
					DP = Convert.FromBase64String(PrimeExponentP),
					DQ = Convert.FromBase64String(PrimeExponentQ),
					InverseQ = Convert.FromBase64String(Coefficient),
					D = Convert.FromBase64String(PrivateExponent)
				};
			}

			public string ToConfigSection()
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder;
				stringBuilder2.Append(Utils.WriteConfigKey("PublicKey.Modulus", Modulus));
				stringBuilder2.Append(Utils.WriteConfigKey("PublicKey.Exponent", Exponent));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.P", PrimeP));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.Q", PrimeQ));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.DP", PrimeExponentP));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.DQ", PrimeExponentQ));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.InverseQ", Coefficient));
				stringBuilder2.Append(Utils.WriteConfigKey("PrivateKey.D", PrivateExponent));
				stringBuilder2 = null;
				return stringBuilder.ToString();
			}

			public void ExportToConfigFile(string strFilePath)
			{
				StreamWriter streamWriter = new StreamWriter(strFilePath, append: false);
				streamWriter.Write(ToConfigSection());
				streamWriter.Close();
			}

			public void LoadFromXml(string keyXml)
			{
				Modulus = Utils.GetXmlElement(keyXml, "Modulus");
				Exponent = Utils.GetXmlElement(keyXml, "Exponent");
				PrimeP = Utils.GetXmlElement(keyXml, "P");
				PrimeQ = Utils.GetXmlElement(keyXml, "Q");
				PrimeExponentP = Utils.GetXmlElement(keyXml, "DP");
				PrimeExponentQ = Utils.GetXmlElement(keyXml, "DQ");
				Coefficient = Utils.GetXmlElement(keyXml, "InverseQ");
				PrivateExponent = Utils.GetXmlElement(keyXml, "D");
			}

			public string ToXml()
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder;
				stringBuilder2.Append(Utils.WriteXmlNode("RSAKeyValue"));
				stringBuilder2.Append(Utils.WriteXmlElement("Modulus", Modulus));
				stringBuilder2.Append(Utils.WriteXmlElement("Exponent", Exponent));
				stringBuilder2.Append(Utils.WriteXmlElement("P", PrimeP));
				stringBuilder2.Append(Utils.WriteXmlElement("Q", PrimeQ));
				stringBuilder2.Append(Utils.WriteXmlElement("DP", PrimeExponentP));
				stringBuilder2.Append(Utils.WriteXmlElement("DQ", PrimeExponentQ));
				stringBuilder2.Append(Utils.WriteXmlElement("InverseQ", Coefficient));
				stringBuilder2.Append(Utils.WriteXmlElement("D", PrivateExponent));
				stringBuilder2.Append(Utils.WriteXmlNode("RSAKeyValue", isClosing: true));
				stringBuilder2 = null;
				return stringBuilder.ToString();
			}

			public void ExportToXmlFile(string filePath)
			{
				StreamWriter streamWriter = new StreamWriter(filePath, append: false);
				streamWriter.Write(ToXml());
				streamWriter.Close();
			}
		}

		private RSACryptoServiceProvider _rsa;

		private string _KeyContainerName;

		private bool _UseMachineKeystore;

		private int _KeySize;

		private const string _ElementParent = "RSAKeyValue";

		private const string _ElementModulus = "Modulus";

		private const string _ElementExponent = "Exponent";

		private const string _ElementPrimeP = "P";

		private const string _ElementPrimeQ = "Q";

		private const string _ElementPrimeExponentP = "DP";

		private const string _ElementPrimeExponentQ = "DQ";

		private const string _ElementCoefficient = "InverseQ";

		private const string _ElementPrivateExponent = "D";

		private const string _KeyModulus = "PublicKey.Modulus";

		private const string _KeyExponent = "PublicKey.Exponent";

		private const string _KeyPrimeP = "PrivateKey.P";

		private const string _KeyPrimeQ = "PrivateKey.Q";

		private const string _KeyPrimeExponentP = "PrivateKey.DP";

		private const string _KeyPrimeExponentQ = "PrivateKey.DQ";

		private const string _KeyCoefficient = "PrivateKey.InverseQ";

		private const string _KeyPrivateExponent = "PrivateKey.D";

		public string KeyContainerName
		{
			get
			{
				return _KeyContainerName;
			}
			set
			{
				_KeyContainerName = value;
			}
		}

		public int KeySizeBits => _rsa.KeySize;

		public int KeySizeMaxBits => _rsa.LegalKeySizes[0].MaxSize;

		public int KeySizeMinBits => _rsa.LegalKeySizes[0].MinSize;

		public int KeySizeStepBits => _rsa.LegalKeySizes[0].SkipSize;

		public PublicKey DefaultPublicKey
		{
			get
			{
				PublicKey publicKey = new PublicKey();
				publicKey.LoadFromConfig();
				return publicKey;
			}
		}

		public PrivateKey DefaultPrivateKey
		{
			get
			{
				PrivateKey privateKey = new PrivateKey();
				privateKey.LoadFromConfig();
				return privateKey;
			}
		}

		public Asymmetric()
		{
			_KeyContainerName = "Encryption.AsymmetricEncryption.DefaultContainerName";
			_UseMachineKeystore = true;
			_KeySize = 1024;
			_rsa = GetRSAProvider();
		}

		public Asymmetric(int keySize)
		{
			_KeyContainerName = "Encryption.AsymmetricEncryption.DefaultContainerName";
			_UseMachineKeystore = true;
			_KeySize = 1024;
			_KeySize = keySize;
			_rsa = GetRSAProvider();
		}

		public void GenerateNewKeyset(ref PublicKey publicKey, ref PrivateKey privateKey)
		{
			string publicKeyXML = null;
			string privateKeyXML = null;
			GenerateNewKeyset(ref publicKeyXML, ref privateKeyXML);
			publicKey = new PublicKey(publicKeyXML);
			privateKey = new PrivateKey(privateKeyXML);
		}

		public void GenerateNewKeyset(ref string publicKeyXML, ref string privateKeyXML)
		{
			RSA rSA = RSA.Create();
			publicKeyXML = rSA.ToXmlString(includePrivateParameters: false);
			privateKeyXML = rSA.ToXmlString(includePrivateParameters: true);
		}

		public CryptographyData Encrypt(CryptographyData d)
		{
			PublicKey defaultPublicKey = DefaultPublicKey;
			return Encrypt(d, defaultPublicKey);
		}

		public CryptographyData Encrypt(CryptographyData d, PublicKey publicKey)
		{
			_rsa.ImportParameters(publicKey.ToParameters());
			return EncryptPrivate(d);
		}

		public CryptographyData Encrypt(CryptographyData d, string publicKeyXML)
		{
			LoadKeyXml(publicKeyXML, isPrivate: false);
			return EncryptPrivate(d);
		}

		private CryptographyData EncryptPrivate(CryptographyData d)
		{
			try
			{
				return new CryptographyData(_rsa.Encrypt(d.Bytes, fOAEP: false));
			}
			catch (CryptographicException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				CryptographicException ex2 = ex;
				if (ex2.Message.ToLower().IndexOf("bad length") > -1)
				{
					throw new CryptographicException("Your data is too large; RSA encryption is designed to encrypt relatively small amounts of data. The exact byte limit depends on the key size. To encrypt more data, use symmetric encryption and then encrypt that symmetric key with asymmetric RSA encryption.", ex2);
				}
				throw;
			}
		}

		public CryptographyData Decrypt(CryptographyData encryptedData)
		{
			PrivateKey privateKey = new PrivateKey();
			privateKey.LoadFromConfig();
			return Decrypt(encryptedData, privateKey);
		}

		public CryptographyData Decrypt(CryptographyData encryptedData, PrivateKey PrivateKey)
		{
			_rsa.ImportParameters(PrivateKey.ToParameters());
			return DecryptPrivate(encryptedData);
		}

		public CryptographyData Decrypt(CryptographyData encryptedData, string PrivateKeyXML)
		{
			LoadKeyXml(PrivateKeyXML, isPrivate: true);
			return DecryptPrivate(encryptedData);
		}

		private void LoadKeyXml(string keyXml, bool isPrivate)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0018: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				_rsa.FromXmlString(keyXml);
			}
			catch (XmlSyntaxException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				XmlSyntaxException ex2 = ex;
				string arg = ((!isPrivate) ? "public" : "private");
				throw new XmlSyntaxException($"The provided {arg} encryption key XML does not appear to be valid.", (Exception)(object)ex2);
			}
		}

		private CryptographyData DecryptPrivate(CryptographyData encryptedData)
		{
			return new CryptographyData(_rsa.Decrypt(encryptedData.Bytes, fOAEP: false));
		}

		private RSACryptoServiceProvider GetRSAProvider()
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = null;
			CspParameters cspParameters = null;
			try
			{
				cspParameters = new CspParameters();
				cspParameters.KeyContainerName = _KeyContainerName;
				rSACryptoServiceProvider = new RSACryptoServiceProvider(_KeySize, cspParameters);
				rSACryptoServiceProvider.PersistKeyInCsp = false;
				RSACryptoServiceProvider.UseMachineKeyStore = true;
				return rSACryptoServiceProvider;
			}
			catch (CryptographicException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				CryptographicException ex2 = ex;
				if (ex2.Message.ToLower().IndexOf("csp for this implementation could not be acquired") > -1)
				{
					throw new Exception("Unable to obtain Cryptographic Service Provider. Either the permissions are incorrect on the 'C:\\Documents and Settings\\All Users\\Application Data\\Microsoft\\Crypto\\RSA\\MachineKeys' folder, or the current security context '" + WindowsIdentity.GetCurrent().Name + "' does not have access to this folder.", ex2);
				}
				throw;
			}
			finally
			{
				if (rSACryptoServiceProvider != null)
				{
					rSACryptoServiceProvider = null;
				}
				if (cspParameters != null)
				{
					cspParameters = null;
				}
			}
		}
	}

	public class CryptographyData
	{
		private byte[] _b;

		private int _MaxBytes;

		private int _MinBytes;

		private int _StepBytes;

		public static Encoding DefaultEncoding = Encoding.GetEncoding("Windows-1252");

		public Encoding Encoding;

		public bool IsEmpty
		{
			get
			{
				if (_b == null)
				{
					return true;
				}
				if (_b.Length == 0)
				{
					return true;
				}
				return false;
			}
		}

		public int StepBytes
		{
			get
			{
				return _StepBytes;
			}
			set
			{
				_StepBytes = value;
			}
		}

		public int StepBits
		{
			get
			{
				return checked(_StepBytes * 8);
			}
			set
			{
				_StepBytes = value / 8;
			}
		}

		public int MinBytes
		{
			get
			{
				return _MinBytes;
			}
			set
			{
				_MinBytes = value;
			}
		}

		public int MinBits
		{
			get
			{
				return checked(_MinBytes * 8);
			}
			set
			{
				_MinBytes = value / 8;
			}
		}

		public int MaxBytes
		{
			get
			{
				return _MaxBytes;
			}
			set
			{
				_MaxBytes = value;
			}
		}

		public int MaxBits
		{
			get
			{
				return checked(_MaxBytes * 8);
			}
			set
			{
				_MaxBytes = value / 8;
			}
		}

		public byte[] Bytes
		{
			get
			{
				checked
				{
					if (_MaxBytes > 0 && _b.Length > _MaxBytes)
					{
						byte[] array = new byte[_MaxBytes - 1 + 1];
						Array.Copy(_b, array, array.Length);
						_b = array;
					}
					if (_MinBytes > 0 && _b.Length < _MinBytes)
					{
						byte[] array2 = new byte[_MinBytes - 1 + 1];
						Array.Copy(_b, array2, _b.Length);
						_b = array2;
					}
					return _b;
				}
			}
			set
			{
				_b = value;
			}
		}

		public string Text
		{
			get
			{
				if (_b == null)
				{
					return "";
				}
				int num = Array.IndexOf(_b, (byte)0);
				if (num >= 0)
				{
					return Encoding.GetString(_b, 0, num);
				}
				return Encoding.GetString(_b);
			}
			set
			{
				_b = Encoding.GetBytes(value);
			}
		}

		public string Hex
		{
			get
			{
				return Utils.ToHex(_b);
			}
			set
			{
				_b = Utils.FromHex(value);
			}
		}

		public string Base64
		{
			get
			{
				return Utils.ToBase64(_b);
			}
			set
			{
				_b = Utils.FromBase64(value);
			}
		}

		public CryptographyData()
		{
			_MaxBytes = 0;
			_MinBytes = 0;
			_StepBytes = 0;
			Encoding = DefaultEncoding;
		}

		public CryptographyData(byte[] b)
		{
			_MaxBytes = 0;
			_MinBytes = 0;
			_StepBytes = 0;
			Encoding = DefaultEncoding;
			_b = b;
		}

		public CryptographyData(string s)
		{
			_MaxBytes = 0;
			_MinBytes = 0;
			_StepBytes = 0;
			Encoding = DefaultEncoding;
			Text = s;
		}

		public CryptographyData(string s, Encoding encoding)
		{
			_MaxBytes = 0;
			_MinBytes = 0;
			_StepBytes = 0;
			Encoding = DefaultEncoding;
			Encoding = encoding;
			Text = s;
		}

		public new string ToString()
		{
			return Text;
		}

		public string ToBase64()
		{
			return Base64;
		}

		public string ToHex()
		{
			return Hex;
		}
	}

	public class Utils
	{
		[DebuggerNonUserCode]
		public Utils()
		{
		}

		public static string ToHex(byte[] ba)
		{
			if (ba == null || ba.Length == 0)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in ba)
			{
				stringBuilder.Append($"{b:X2}");
			}
			return stringBuilder.ToString();
		}

		public static byte[] FromHex(string hexEncoded)
		{
			if (hexEncoded == null || hexEncoded.Length == 0)
			{
				return null;
			}
			checked
			{
				try
				{
					int num = Convert.ToInt32((double)hexEncoded.Length / 2.0);
					byte[] array = new byte[num - 1 + 1];
					int num2 = num - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						array[num3] = Convert.ToByte(hexEncoded.Substring(num3 * 2, 2), 16);
						num3++;
					}
					return array;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception innerException = ex;
					throw new FormatException("The provided string does not appear to be Hex encoded:" + Environment.NewLine + hexEncoded + Environment.NewLine, innerException);
				}
			}
		}

		public static byte[] FromBase64(string base64Encoded)
		{
			if (base64Encoded == null || base64Encoded.Length == 0)
			{
				return null;
			}
			try
			{
				return Convert.FromBase64String(base64Encoded);
			}
			catch (FormatException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				FormatException innerException = ex;
				throw new FormatException("The provided string does not appear to be Base64 encoded:" + Environment.NewLine + base64Encoded + Environment.NewLine, innerException);
			}
		}

		public static string ToBase64(byte[] b)
		{
			if (b == null || b.Length == 0)
			{
				return "";
			}
			return Convert.ToBase64String(b);
		}

		internal static string GetXmlElement(string xml, string element)
		{
			Match match = Regex.Match(xml, "<" + element + ">(?<Element>[^>]*)</" + element + ">", RegexOptions.IgnoreCase);
			if (match == null)
			{
				throw new Exception("Could not find <" + element + "></" + element + "> in provided Public Key XML.");
			}
			return match.Groups["Element"].ToString();
		}

		internal static string GetConfigString(string key, bool isRequired = true)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			string text = ConfigurationManager.AppSettings[key];
			if (Operators.CompareString(text, (string)null, false) == 0)
			{
				if (isRequired)
				{
					throw new ConfigurationErrorsException("key <" + key + "> is missing from .config file");
				}
				return "";
			}
			return text;
		}

		internal static string WriteConfigKey(string key, string value)
		{
			string format = "<add key=\"{0}\" value=\"{1}\" />" + Environment.NewLine;
			return string.Format(format, key, value);
		}

		internal static string WriteXmlElement(string element, string value)
		{
			string format = "<{0}>{1}</{0}>" + Environment.NewLine;
			return string.Format(format, element, value);
		}

		internal static string WriteXmlNode(string element, bool isClosing = false)
		{
			string format = ((!isClosing) ? ("<{0}>" + Environment.NewLine) : ("</{0}>" + Environment.NewLine));
			return string.Format(format, element);
		}
	}

	private static Hashtable _oMessage;

	private static Hashtable getMessageInfor()
	{
		return _oMessage;
	}

	public static void LoadMessage()
	{
		string text = "mess";
		if (Operators.CompareString(SystemInformations.CurrentCultureName, "vi-VN", false) != 0)
		{
			text = text.Trim() + "." + SystemInformations.CurrentCultureName.Trim();
		}
		text = SystemInformations.XMLPath + text.Trim() + ".xml";
		DataSet dataSet = new DataSet();
		try
		{
			if (_oMessage != null)
			{
				_oMessage.Clear();
			}
			dataSet.ReadXml(text);
			if (dataSet.Tables.Count > 0)
			{
				_oMessage = CBO.FillHashTable(dataSet.Tables[0].CreateDataReader(), typeof(AsiaMessage), "Id");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
		finally
		{
			dataSet.Dispose();
		}
	}

	public static object DefaulValueOfType(SqlDbType aType)
	{
		switch ((int)aType)
		{
		case 0:
		case 2:
		case 5:
		case 6:
		case 8:
		case 9:
		case 13:
		case 16:
		case 17:
		case 20:
			return 0;
		case 4:
		case 15:
		case 19:
		case 31:
		case 32:
		case 33:
			return new DateTime(599266080000000000L);
		default:
			return string.Empty;
		}
	}

	public static bool isSQLNumType(SqlDbType aType)
	{
		if ((aType == SqlDbType.BigInt || aType == SqlDbType.Bit || aType == SqlDbType.Decimal || aType == SqlDbType.Float || aType == SqlDbType.Int || aType == SqlDbType.Money || aType == SqlDbType.Real || aType == SqlDbType.SmallInt || aType == SqlDbType.SmallMoney || aType == SqlDbType.TinyInt) ? true : false)
		{
			return true;
		}
		return false;
	}

	public static string Repl_Str(string str)
	{
		if (Operators.CompareString(str, "", false) == 0)
		{
			return str;
		}
		str = Strings.Replace(str, "'", "''", 1, -1, (CompareMethod)0);
		return str;
	}

	public static string Str_Quote(string str)
	{
		if (Operators.CompareString(str, "", false) == 0)
		{
			return str;
		}
		str = Strings.Replace(str, "'", "''", 1, -1, (CompareMethod)0);
		return str;
	}

	public static object Repl_Null(object obj, bool isNum)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
		{
			if (isNum)
			{
				return 0;
			}
			return "";
		}
		return obj;
	}

	public static string Date_Convert(string sDate, bool blnUpdate = false)
	{
		if (Operators.CompareString(sDate, "", false) == 0)
		{
			return "";
		}
		checked
		{
			string text = sDate.Substring(sDate.IndexOf("/") + 1, sDate.LastIndexOf("/") - sDate.IndexOf("/") - 1);
			string text2 = sDate.Substring(0, sDate.IndexOf("/"));
			string text3 = sDate.Substring(sDate.LastIndexOf("/") + 1);
			sDate = text + "/" + text2 + "/" + text3;
			if (blnUpdate)
			{
				sDate = "to_date('" + sDate + "','MM/dd/yyyy HH:MI:SS AM')";
			}
			return sDate;
		}
	}

	public static string FormatNumber(string Number)
	{
		if (!Versioned.IsNumeric((object)Number))
		{
			return Number;
		}
		Number = Conversions.ToString(Math.Round(Conversions.ToDecimal(Number)));
		bool flag = false;
		if (Operators.CompareString(Strings.Left(Number, 1), "-", false) == 0)
		{
			flag = true;
		}
		Number = Number.Replace(",", "");
		Number = Number.Replace("-", "");
		int num = 0;
		string text = "";
		int num2 = 0;
		int num3 = Number.Length;
		checked
		{
			while (true)
			{
				int num4 = num3;
				int num5 = 1;
				if (num4 < num5)
				{
					break;
				}
				num++;
				if (unchecked(num % 3) == 0)
				{
					text = "," + Number.Substring(num3 - 1, 3) + text;
					num2 += 3;
				}
				num3 += -1;
			}
			text = ((Number.Length - num2 == 0) ? text.Substring(1) : (Number.Substring(0, Number.Length - num2) + text));
			if (flag)
			{
				text = "-" + text;
			}
			return text;
		}
	}

	public static string UnFormatNumber(string Number)
	{
		string numberGroupSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator;
		Number = Strings.Replace(Number, numberGroupSeparator, "", 1, -1, (CompareMethod)0);
		return Number;
	}

	internal static void TextLogEvent(string message, EventLogEntryType type, string machine = ".")
	{
		string text = SystemInformations.RootPath + "\\Logs\\";
		string text2 = "Log.txt";
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
		if ((File.Exists(text + text2) && new FileInfo(text + text2).Length > 4194304) ? true : false)
		{
			string[] files = Directory.GetFiles(text, "Log*", SearchOption.TopDirectoryOnly);
			Array.Sort(files);
			Array.Reverse((Array)files);
			Action<string> action = RenNameOldLogFile;
			Array.ForEach(files, action);
		}
		string text3 = string.Empty;
		try
		{
			text3 = File.ReadAllText(text + text2);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		using StreamWriter streamWriter = new StreamWriter(text + text2, append: false);
		streamWriter.WriteLine(message);
		streamWriter.WriteLine();
		streamWriter.WriteLine("==============================================================");
		streamWriter.WriteLine();
		if (Operators.CompareString(text3, string.Empty, false) != 0)
		{
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine();
		}
	}

	internal static void TextLogEvent(Exception ex, EventLogEntryType type, string machine = ".")
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		string text = "[" + DateAndTime.Now.ToString() + "] [" + machine + "] [";
		text = (type - 1) switch
		{
			0 => text + "EXCEPTION", 
			1 => text + "WARNING", 
			3 => text + "INFO", 
			_ => text + "UNKNOWN", 
		} + "]: ";
		text = text + ex.GetType().Name + "\r\n";
		text += ex.Message;
		text += ex.StackTrace;
		TextLogEvent(text, type, machine);
	}

	private static void RenNameOldLogFile(string sFileFullName)
	{
		string text = SystemInformations.RootPath + "\\Logs\\";
		string text2 = "Log";
		checked
		{
			string text3 = sFileFullName.Split(new char[1] { '\\' })[sFileFullName.Split(new char[1] { '\\' }).Length - 1];
			text3 = text3.Replace(".txt", "");
			try
			{
				int num = 0;
				try
				{
					num = Conversions.ToInteger(text3.Substring(3));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					num = 0;
					ProjectData.ClearProjectError();
				}
				string text4 = text2 + (num + 1).ToString().Trim();
				((ServerComputer)MyProject.Computer).FileSystem.RenameFile(text + text3 + ".txt", text4 + ".txt");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				throw ex4;
			}
		}
	}

	internal static void LogEvent(string message, EventLogEntryType type, string machine = ".")
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = "Simba Accounting";
		if (text == null)
		{
			text = "AsiaSoft";
		}
		try
		{
			if (!EventLog.SourceExists(text))
			{
				EventLog.CreateEventSource(text, "Application");
			}
			EventLog val = new EventLog();
			val.Source = text;
			val.MachineName = machine;
			val.WriteEntry(message, type);
		}
		finally
		{
		}
	}

	internal static void LogEvent(Exception ex, EventLogEntryType type = (EventLogEntryType)1, string machine = ".")
	{
		try
		{
			string text = "EXCEPTION: " + ex.GetType().Name + "\r\n";
			text += ex.Message;
			text += ex.StackTrace;
			LogEvent(text, (EventLogEntryType)1, machine);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	public static void ProcessError(Exception ex, ErrorType type = ErrorType.Error)
	{
		string text = "WIN";
		try
		{
			text = Conversions.ToString(Repl_Null(ConfigurationManager.AppSettings["LOGTYPE"], isNum: true));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			text = "WIN";
			ProjectData.ClearProjectError();
		}
		string text2 = text;
		if (Operators.CompareString(text2, "WIN", false) == 0)
		{
			LogEvent(ex, (EventLogEntryType)type);
		}
		else if (Operators.CompareString(text2, "FILE", false) == 0)
		{
			TextLogEvent(ex, (EventLogEntryType)type);
		}
		else
		{
			TextLogEvent(ex, (EventLogEntryType)type);
		}
	}

	public static void ProcessError(string message, ErrorType type = ErrorType.Error)
	{
		Exception ex = new Exception(message);
		ProcessError(ex, type);
	}

	public static string GetMessContent(int aMessID)
	{
		AsiaMessage asiaMessage = (AsiaMessage)getMessageInfor()[aMessID];
		if (asiaMessage == null)
		{
			string text = "Lỗi không xác định! Mã lỗi: " + aMessID.ToString("### ### ###").Trim();
		}
		return asiaMessage.Description;
	}

	public static AsiaMessage GetMess(int aMessID)
	{
		if (getMessageInfor() == null)
		{
			return new AsiaMessage(-1, (MessageBoxIcon)64, "Message have not been loaded, may be an error occurred in startup program!");
		}
		AsiaMessage asiaMessage = (AsiaMessage)getMessageInfor()[aMessID];
		if (asiaMessage == null)
		{
			asiaMessage = new AsiaMessage(aMessID, (MessageBoxIcon)48, "Undefined message, ID: " + aMessID.ToString("### ### ###").Trim());
		}
		return asiaMessage;
	}

	public static string ComputeHash(string plain, Hash.Provider hashType, HashEncodeType encodeType)
	{
		byte[] bytes = new ASCIIEncoding().GetBytes(plain);
		HashAlgorithm hashAlgorithm = null;
		if (plain.Length == 0)
		{
			return "";
		}
		switch ((int)hashType)
		{
		case 4:
			hashAlgorithm = new MD5CryptoServiceProvider();
			break;
		case 0:
			hashAlgorithm = new SHA1CryptoServiceProvider();
			break;
		case 1:
			hashAlgorithm = new SHA256Managed();
			break;
		case 2:
			hashAlgorithm = new SHA384Managed();
			break;
		case 3:
			hashAlgorithm = new SHA512Managed();
			break;
		}
		byte[] array = ((hashAlgorithm != null) ? hashAlgorithm.ComputeHash(bytes) : bytes);
		string text = "";
		switch ((int)encodeType)
		{
		case 0:
			text = BitConverter.ToString(array);
			break;
		case 2:
			checked
			{
				int num = array.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						text += Conversion.Hex(array[num2]);
						num2++;
						continue;
					}
					break;
				}
				break;
			}
		default:
			text = BitConverter.ToString(array);
			break;
		}
		return text;
	}

	public static string Encrypted(string s, int key)
	{
		if (key == 100)
		{
			return ComputeHash(s, Hash.Provider.MD5, HashEncodeType.NoEncode);
		}
		if (Operators.CompareString(s, "", false) == 0)
		{
			return s;
		}
		if (key >= 128)
		{
			Exception ex = new Exception("Invalid key. Key is less than 128");
			throw ex;
		}
		byte[] bytes = new UnicodeEncoding().GetBytes(s);
		checked
		{
			int num = bytes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (bytes[num2] + key > 255)
				{
					Exception ex2 = new Exception("Invalid encrypted source string");
					throw ex2;
				}
				bytes[num2] = (byte)(bytes[num2] + key);
				num2++;
			}
			return BitConverter.ToString(bytes);
		}
	}

	public static string Decrypted(string s, int key)
	{
		if (key == 100)
		{
			return "";
		}
		if (Operators.CompareString(s, "", false) == 0)
		{
			return s;
		}
		if (key >= 128)
		{
			Exception ex = new Exception("Invalid key. Key is less than 128");
			throw ex;
		}
		byte[] array = null;
		string[] array2 = s.Split(new char[1] { '-' });
		checked
		{
			int num = array2.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[num2 + 1]);
				array[num2] = (byte)Math.Round(Conversion.Val("&H" + array2[num2]));
				num2++;
			}
			int num5 = array.Length - 1;
			num2 = 0;
			while (true)
			{
				int num6 = num2;
				int num4 = num5;
				if (num6 > num4)
				{
					break;
				}
				array[num2] = (byte)(array[num2] - key);
				num2++;
			}
			string text = "";
			int num7 = array.Length - 1;
			num2 = 0;
			while (true)
			{
				int num8 = num2;
				int num4 = num7;
				if (num8 > num4)
				{
					break;
				}
				text += Conversions.ToString(BitConverter.ToChar(array, num2));
				num2 += 2;
			}
			return text;
		}
	}
}
