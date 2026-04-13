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

	[DefaultSettingValue("Khai báo danh sách tài khoản không chính xác")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
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
