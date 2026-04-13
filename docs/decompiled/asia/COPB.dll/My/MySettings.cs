using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static My.MySettings defaultInstance = (My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new My.MySettings());

	public static My.MySettings Default => defaultInstance;

	[DefaultSettingValue("SplitButton1")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string asdasd
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["asdasd"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["asdasd"] = value;
		}
	}
}
