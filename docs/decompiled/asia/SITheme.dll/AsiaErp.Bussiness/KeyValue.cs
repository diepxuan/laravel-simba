using System;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Bussiness;

public class KeyValue
{
	public string MENU_TYPE;

	public int X_COLUMN2;

	public int MODULE_PANEL_MAX_WIDTH;

	public Color MODULE_MENU_BACK_COLOR;

	public Color LEFT_MENU_BACK_COLOR;

	public Color MODULE_MENU_FORE_COLOR;

	public Color MODULE_MENU_SELECTED_FORE_COLOR;

	public Color CURRENT_MODULE_LABEL_FORE_COLOR;

	public Color SUB_MENU_FORE_COLOR;

	public Color DETAIL_MENU_FORE_COLOR;

	public Font MODULE_MENU_FONT;

	public Font SUB_MENU_FONT;

	public Font DETAIL_MENU_FONT;

	public string ServiceUri;

	public Color CT_BakgroundColorName;

	public Color CT_AlternatingBackColorName;

	public Color DM_BakgroundColorName;

	public Color DM_AlternatingBackColorName;

	public Color BC_BakgroundColorName;

	public Color BC_AlternatingBackColorName;

	public Color AsTextBox_BakgroundColorName;

	public string EscapeCharacters;

	public string Field2CarryInReport;

	public Hashtable hstThemeConfig;

	public KeyValue(Hashtable _hstThemeConfig)
	{
		hstThemeConfig = new Hashtable();
		hstThemeConfig = _hstThemeConfig;
		MENU_TYPE = Conversions.ToString(Interaction.IIf(hstThemeConfig["MENU_TYPE"].Equals("1"), (object)"Tree", (object)"Docking Menu"));
		X_COLUMN2 = int.Parse(Conversions.ToString(hstThemeConfig["X_COLUMN2"]));
		MODULE_PANEL_MAX_WIDTH = int.Parse(Conversions.ToString(hstThemeConfig["MODULE_PANEL_MAX_WIDTH"]));
		MODULE_MENU_BACK_COLOR = ConvertToColor(Conversions.ToString(hstThemeConfig["MODULE_MENU_BACK_COLOR"]));
		LEFT_MENU_BACK_COLOR = ConvertToColor(Conversions.ToString(hstThemeConfig["LEFT_MENU_BACK_COLOR"]));
		MODULE_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["MODULE_MENU_FORE_COLOR"]));
		MODULE_MENU_SELECTED_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["MODULE_MENU_SELECTED_FORE_COLOR"]));
		CURRENT_MODULE_LABEL_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CURRENT_MODULE_LABEL_FORE_COLOR"]));
		SUB_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["SUB_MENU_FORE_COLOR"]));
		DETAIL_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DETAIL_MENU_FORE_COLOR"]));
		MODULE_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["MODULE_MENU_FONT"]));
		SUB_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["SUB_MENU_FONT"]));
		DETAIL_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["DETAIL_MENU_FONT"]));
		CT_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CT_BakgroundColorName"]));
		CT_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CT_AlternatingBackColorName"]));
		DM_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DM_BakgroundColorName"]));
		DM_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DM_AlternatingBackColorName"]));
		BC_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["BC_BakgroundColorName"]));
		BC_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["BC_AlternatingBackColorName"]));
		AsTextBox_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["AsTextBox_BakgroundColorName"]));
	}

	public void KeyValue()
	{
		MENU_TYPE = Conversions.ToString(Interaction.IIf(hstThemeConfig["MENU_TYPE"].Equals("1"), (object)"Tree", (object)"Docking Menu"));
		X_COLUMN2 = int.Parse(Conversions.ToString(hstThemeConfig["X_COLUMN2"]));
		MODULE_PANEL_MAX_WIDTH = int.Parse(Conversions.ToString(hstThemeConfig["MODULE_PANEL_MAX_WIDTH"]));
		MODULE_MENU_BACK_COLOR = ConvertToColor(Conversions.ToString(hstThemeConfig["MODULE_MENU_BACK_COLOR"]));
		LEFT_MENU_BACK_COLOR = ConvertToColor(Conversions.ToString(hstThemeConfig["LEFT_MENU_BACK_COLOR"]));
		MODULE_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["MODULE_MENU_FORE_COLOR"]));
		MODULE_MENU_SELECTED_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["MODULE_MENU_SELECTED_FORE_COLOR"]));
		CURRENT_MODULE_LABEL_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CURRENT_MODULE_LABEL_FORE_COLOR"]));
		SUB_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["SUB_MENU_FORE_COLOR"]));
		DETAIL_MENU_FORE_COLOR = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DETAIL_MENU_FORE_COLOR"]));
		MODULE_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["MODULE_MENU_FONT"]));
		SUB_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["SUB_MENU_FONT"]));
		DETAIL_MENU_FONT = ConvertToFont(Conversions.ToString(hstThemeConfig["DETAIL_MENU_FONT"]));
		CT_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CT_BakgroundColorName"]));
		CT_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["CT_AlternatingBackColorName"]));
		DM_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DM_BakgroundColorName"]));
		DM_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["DM_AlternatingBackColorName"]));
		BC_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["BC_BakgroundColorName"]));
		BC_AlternatingBackColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["BC_AlternatingBackColorName"]));
		AsTextBox_BakgroundColorName = ColorTranslator.FromHtml(Conversions.ToString(hstThemeConfig["AsTextBox_BakgroundColorName"]));
	}

	private Font ConvertToFont(string fontString)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		char[] separator = new char[1] { ',' };
		string[] array = fontString.Split(separator);
		FontStyle val = default(FontStyle);
		switch (array[2])
		{
		case "0":
			val = (FontStyle)0;
			break;
		case "1":
			val = (FontStyle)1;
			break;
		case "2":
			val = (FontStyle)2;
			break;
		case "3":
			val = (FontStyle)3;
			break;
		case "4":
			val = (FontStyle)4;
			break;
		case "8":
			val = (FontStyle)8;
			break;
		case "12":
			val = (FontStyle)12;
			break;
		}
		return new Font(array[0], float.Parse(array[1]), val);
	}

	private Color ConvertToColor(string colorString)
	{
		Color result;
		try
		{
			result = ColorTranslator.FromHtml(colorString);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			char[] separator = new char[6] { 'r', 'g', 'b', '(', ',', ')' };
			string[] array = colorString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			result = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
