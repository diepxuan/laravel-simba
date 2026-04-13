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
public sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Hàng tháng")]
	public string HangThang
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["HangThang"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["HangThang"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Hàng quý")]
	public string HangQuy
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["HangQuy"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["HangQuy"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Hàng năm")]
	[UserScopedSetting]
	public string HangNam
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["HangNam"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["HangNam"] = value;
		}
	}

	[DefaultSettingValue("Thanh toán 1 lần cuối kỳ")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string CuoiKy
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["CuoiKy"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["CuoiKy"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Ngày thanh toán phải sau ngày ký")]
	[DebuggerNonUserCode]
	public string NgayTT_NgayKy
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this)["NgayTT_NgayKy"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["NgayTT_NgayKy"] = value;
		}
	}
}
