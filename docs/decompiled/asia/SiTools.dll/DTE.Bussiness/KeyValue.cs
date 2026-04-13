using System;
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DTE.Bussiness;

public class KeyValue
{
	public string MENU_TYPE;

	public int X_COLUMN2;

	public int MODULE_PANEL_MAX_WIDTH;

	public Color MODULE_MENU_BACK_COLOR;

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

	[DebuggerNonUserCode]
	public KeyValue()
	{
	}

	public void KeyValue(XmlNode node)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		foreach (XmlNode childNode in node.ChildNodes)
		{
			XmlNode val = childNode;
			if ((!((Enum)val.NodeType).Equals((object)(XmlNodeType)8) && (object)val.Attributes["key"] != DBNull.Value) ? true : false)
			{
				switch (val.Attributes["key"].Value)
				{
				case "MENU_TYPE":
					MENU_TYPE = Conversions.ToString(Interaction.IIf(val.Attributes["value"].Value.Equals("1"), (object)"Tree", (object)"Docking Menu"));
					break;
				case "X_COLUMN2":
					X_COLUMN2 = int.Parse(val.Attributes["value"].Value);
					break;
				case "MODULE_PANEL_MAX_WIDTH":
					MODULE_PANEL_MAX_WIDTH = int.Parse(val.Attributes["value"].Value);
					break;
				case "MODULE_MENU_BACK_COLOR":
					MODULE_MENU_BACK_COLOR = ConvertToColor(val.Attributes["value"].Value);
					break;
				case "MODULE_MENU_FORE_COLOR":
					MODULE_MENU_FORE_COLOR = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "MODULE_MENU_SELECTED_FORE_COLOR":
					MODULE_MENU_SELECTED_FORE_COLOR = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "CURRENT_MODULE_LABEL_FORE_COLOR":
					CURRENT_MODULE_LABEL_FORE_COLOR = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "SUB_MENU_FORE_COLOR":
					SUB_MENU_FORE_COLOR = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "DETAIL_MENU_FORE_COLOR":
					DETAIL_MENU_FORE_COLOR = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "MODULE_MENU_FONT":
					MODULE_MENU_FONT = ConvertToFont(val.Attributes["value"].Value);
					break;
				case "SUB_MENU_FONT":
					SUB_MENU_FONT = ConvertToFont(val.Attributes["value"].Value);
					break;
				case "DETAIL_MENU_FONT":
					DETAIL_MENU_FONT = ConvertToFont(val.Attributes["value"].Value);
					break;
				case "ClientSettingsProvider.ServiceUri":
					ServiceUri = val.Attributes["value"].Value;
					break;
				case "CT_BakgroundColorName":
					CT_BakgroundColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "CT_AlternatingBackColorName":
					CT_AlternatingBackColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "DM_BakgroundColorName":
					DM_BakgroundColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "DM_AlternatingBackColorName":
					DM_AlternatingBackColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "BC_BakgroundColorName":
					BC_BakgroundColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "BC_AlternatingBackColorName":
					BC_AlternatingBackColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "AsTextBox_BakgroundColorName":
					AsTextBox_BakgroundColorName = ColorTranslator.FromHtml(val.Attributes["value"].Value);
					break;
				case "EscapeCharacters":
					EscapeCharacters = val.Attributes["value"].Value;
					break;
				case "Field2CarryInReport":
					Field2CarryInReport = val.Attributes["value"].Value;
					break;
				}
			}
		}
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
