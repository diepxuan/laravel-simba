using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace GenerationReport;

public class ReportConfig
{
	public float top;

	public float botom;

	public float left;

	public float right;

	public int format;

	public Font fontParent;

	public Font fontCompanyName;

	public Font fontTitle;

	public Font fontTaikhoan;

	public Font fontHeaderTable;

	public Font fontTableCell;

	public Font fontTrang;

	public ReportConfig()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		XmlDocument val = new XmlDocument();
		val.Load(Application.StartupPath + "\\DynamicReport.config");
		XmlNode val2 = val.DocumentElement.GetElementsByTagName("appSettings").Item(0);
		foreach (XmlNode childNode in val2.ChildNodes)
		{
			XmlNode val3 = childNode;
			switch (((XmlNode)val3.Attributes["key"]).Value)
			{
			case "TopMargin":
				top = float.Parse(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "BottomMargin":
				botom = float.Parse(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "LeftMargin":
				left = float.Parse(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "RightMargin":
				right = float.Parse(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FormatMoney":
				format = int.Parse(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontParent":
				fontParent = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontCompanyName":
				fontCompanyName = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontTitle":
				fontTitle = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontTaikhoan":
				fontTaikhoan = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontHeaderTable":
				fontHeaderTable = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontTableCell":
				fontTableCell = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			case "FontTrang":
				fontTrang = ConvertToFont(((XmlNode)val3.Attributes["value"]).Value);
				break;
			}
		}
	}

	private Font ConvertToFont(string fontString)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		char[] separator = new char[1] { ',' };
		string[] array = fontString.Split(separator);
		FontStyle val = (FontStyle)0;
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
		}
		return new Font(array[0], float.Parse(array[1]), val);
	}

	private Color ConvertToColor(string colorString)
	{
		try
		{
			return ColorTranslator.FromHtml(colorString);
		}
		catch
		{
			char[] separator = new char[6] { 'r', 'g', 'b', '(', ',', ')' };
			string[] array = colorString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			return Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
	}
}
