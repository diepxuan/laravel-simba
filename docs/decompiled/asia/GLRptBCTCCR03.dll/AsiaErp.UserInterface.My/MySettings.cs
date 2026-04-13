using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Danh sách tài khoản không chính xác")]
	public string MSG_DS_TK
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["MSG_DS_TK"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["MSG_DS_TK"] = value;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
