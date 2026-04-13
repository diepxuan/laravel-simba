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

	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=.;Initial Catalog=Ae113Data;Integrated Security=True")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DebuggerNonUserCode]
	public string Ae113DataConnectionString => Conversions.ToString(((ApplicationSettingsBase)this)["Ae113DataConnectionString"]);

	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=\"192.168.0.2 ,6868\";Initial Catalog=Ae113Data;User ID=ae11;Password=aeMuoiMot@1")]
	public string Ae113DataConnectionString1 => Conversions.ToString(((ApplicationSettingsBase)this)["Ae113DataConnectionString1"]);

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
