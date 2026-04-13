using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaLicenseCommon;

public class Serializer
{
	[DebuggerNonUserCode]
	public Serializer()
	{
	}

	private static XmlSerializer getSerializer<T>()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return new XmlSerializer(typeof(T));
	}

	public static void Save<T>(T o, string fileName)
	{
		using FileStream stream = File.Open(fileName, FileMode.Create);
		Save(o, stream);
	}

	private static void Save<T>(T o, Stream stream)
	{
		getSerializer<T>().Serialize(stream, (object)o);
	}

	public static object Save<T>(T o)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Save(o, memoryStream);
		return memoryStream.GetBuffer();
	}

	public static object Save<T>(T o, Encoding encoding)
	{
		return encoding.GetString((byte[])Save(o));
	}

	public static object Load<T>(Stream stream)
	{
		return (T)getSerializer<T>().Deserialize(stream);
	}

	public static T Load<T>(FileInfo file)
	{
		using FileStream stream = file.Open(FileMode.Open);
		return Conversions.ToGenericParameter<T>(RuntimeHelpers.GetObjectValue(Load<T>(stream)));
	}

	public static T Load<T>(byte[] data)
	{
		using MemoryStream stream = new MemoryStream(data);
		return Conversions.ToGenericParameter<T>(RuntimeHelpers.GetObjectValue(Load<T>(stream)));
	}

	public static T Load<T>(string data)
	{
		return Load<T>(Encoding.ASCII.GetBytes(data));
	}
}
