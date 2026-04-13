using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static My.MySettings defaultInstance = (My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new My.MySettings());

	public static My.MySettings Default => defaultInstance;

	[DefaultSettingValue("Chưa có thông tin danh mục lý do tăng giảm")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string LDTG
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["LDTG"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["LDTG"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Chưa có thông tin danh mục sản phẩm công trình")]
	[DebuggerNonUserCode]
	public string SPCT
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["SPCT"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["SPCT"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Chưa có thông tin danh mục bộ phận sử dụng")]
	[DebuggerNonUserCode]
	public string BPSD
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["BPSD"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["BPSD"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Chưa có thông tin danh mục nguồn vốn")]
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

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Ngày tăng, ngày bắt đầu khấu hao, ngày ghi nhận giá trị còn lại phải tăng dần theo thứ tự")]
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

	[DefaultSettingValue("Phải khai báo một nguyên giá")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
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
