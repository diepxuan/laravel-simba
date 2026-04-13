using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;

namespace AsiaLicenseCommon;

[Serializable]
public class LicenseTerms
{
	public const int DEFAULT_TRIAL_PERIOD = 90;

	public string CustomerName
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public DateTime CreatedDate
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string BranchID
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public DateTime StartDate
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public DateTime EndDate
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string CreatedComputer
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public bool TrialMode
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public int TRIAL_PERIOD => 90;

	public int UsedDay
	{
		get
		{
			if (DateTime.Compare(DateAndTime.Today, StartDate) < 0)
			{
				return TRIAL_PERIOD;
			}
			return checked((int)DateAndTime.DateDiff((DateInterval)4, StartDate, DateAndTime.Today, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
		}
	}

	public int RemainindDay
	{
		get
		{
			if (DateTime.Compare(DateAndTime.Today, StartDate) < 0 || DateTime.Compare(DateAndTime.Today, EndDate) > 0)
			{
				return 0;
			}
			return checked((int)DateAndTime.DateDiff((DateInterval)4, DateAndTime.Today, EndDate, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
		}
	}

	[DebuggerNonUserCode]
	public LicenseTerms()
	{
	}

	public byte[] GetLicenseData()
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(memoryStream, this);
		return memoryStream.GetBuffer();
	}

	public static LicenseTerms FromString(string licenseTerm)
	{
		using MemoryStream serializationStream = new MemoryStream(Convert.FromBase64String(licenseTerm));
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		return (LicenseTerms)binaryFormatter.Deserialize(serializationStream);
	}
}
