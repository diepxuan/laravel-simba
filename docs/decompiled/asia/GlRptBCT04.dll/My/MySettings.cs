using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static My.MySettings defaultInstance = (My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new My.MySettings());

	public static My.MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Khai báo danh sách tài khoản không chính xác")]
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
