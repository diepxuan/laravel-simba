using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static My.MySettings defaultInstance = (My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new My.MySettings());

	public static My.MySettings Default => defaultInstance;

	[DefaultSettingValue("Chưa khai báo danh mục nguồn vốn")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string NG_VON
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["NG_VON"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["NG_VON"] = value;
		}
	}

	[DefaultSettingValue("Ngày tăng, ngày bắt đầu khấu hao, ngày ghi nhận giá trị còn lại phải tăng dần theo thứ tự")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string NGAY_TG_BDKH_GTCL
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["NGAY_TG_BDKH_GTCL"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["NGAY_TG_BDKH_GTCL"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Chưa có nguyên giá nào để tính khấu hao")]
	public string NHAP_1NG
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["NHAP_1NG"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["NHAP_1NG"] = value;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
