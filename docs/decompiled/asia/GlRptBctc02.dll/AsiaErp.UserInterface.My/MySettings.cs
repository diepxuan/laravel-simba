using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("Lập tại ngày")]
	[DebuggerNonUserCode]
	public string strLapTaiNgay
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["strLapTaiNgay"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["strLapTaiNgay"] = value;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
