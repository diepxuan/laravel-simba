using System.Windows.Forms;
using Rdl;

namespace GenerationReport;

internal class Utility
{
	public static void GetAlignContent(DataGridViewContentAlignment Align, ref string h, ref string v)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		string text = ((object)Align).ToString();
		if (text == "NotSet")
		{
			v = "Middle";
			h = "Center";
			return;
		}
		num = text.Length - 1;
		while (num > 0 && !char.IsUpper(text[num]))
		{
			num--;
		}
		v = text.Substring(0, num);
		h = text.Substring(num, text.Length - v.Length);
	}

	public static BorderColorStyleWidthType CreateBorderColorStyleWidthType(string Value)
	{
		BorderColorStyleWidthType borderColorStyleWidthType = new BorderColorStyleWidthType();
		borderColorStyleWidthType.Items = new object[1] { Value };
		borderColorStyleWidthType.ItemsElementName = new ItemsChoiceType3[1] { ItemsChoiceType3.Default };
		return borderColorStyleWidthType;
	}
}
