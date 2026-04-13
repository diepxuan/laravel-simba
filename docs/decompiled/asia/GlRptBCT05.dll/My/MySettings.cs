using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static My.MySettings defaultInstance = (My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new My.MySettings());

	public static My.MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("Khai báo danh sách tài khoản không chính xác")]
	[DebuggerNonUserCode]
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
