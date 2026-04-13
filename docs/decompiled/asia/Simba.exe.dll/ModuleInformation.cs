using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[Serializable]
public class ModuleInformation
{
	private static string file_path = Application.StartupPath + "\\ModulesCfg." + SystemInformations.UserName;

	public string MenuID
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public string Bar
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public bool Checked
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public int Stt
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	[DebuggerNonUserCode]
	public ModuleInformation()
	{
	}

	public static void SaveModuleConfig(List<ModuleInformation> obj)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using Stream serializationStream = File.Open(file_path, FileMode.Create);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(serializationStream, obj);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CMessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static List<ModuleInformation> ReadModuleConfig()
	{
		List<ModuleInformation> result;
		try
		{
			using Stream serializationStream = File.Open(file_path, FileMode.Open);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			result = (List<ModuleInformation>)binaryFormatter.Deserialize(serializationStream);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
