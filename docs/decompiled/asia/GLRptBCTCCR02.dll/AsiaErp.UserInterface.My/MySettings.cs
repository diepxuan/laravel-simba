using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Lập tại ngày")]
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
