using System.Drawing;
using Rdl;

namespace GenerationReport;

internal class TextBoxRdlGenerator
{
	public int CellPadding { get; set; }

	public Color BorderColor { get; set; }

	public float BorderWidth { get; set; }

	public EBorderStyle BorderStyle { get; set; }

	public float Width { get; set; }

	public float Height { get; set; }

	public HorizontalText TextAlign { get; set; }

	public VerticalText VText { get; set; }

	public Font _Font { get; set; }

	public Color ForceColor { get; set; }

	public string Text { get; set; }

	public string IsBold { get; set; }

	public string Name { get; set; }

	public PointF Location { get; set; }

	public string BgColor { get; set; }

	public string TextColor { get; set; }

	public TextBoxRdlGenerator()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		CellPadding = 3;
		BorderColor = Color.Black;
		BorderWidth = 0.5f;
		BorderStyle = EBorderStyle.Solid;
		Width = 0.5f;
		Height = 0.5f;
		TextAlign = HorizontalText.Left;
		_Font = new Font(FontFamily.GenericMonospace, 10f);
		ForceColor = Color.Black;
		Text = "";
		IsBold = "Normal";
		Name = "TextBox1";
		TextAlign = HorizontalText.Center;
		VText = VerticalText.Middle;
		Location = new PointF(0f, 0f);
		BgColor = "White";
		TextColor = "Black";
	}

	public TextboxType CreateTableCellTextbox()
	{
		TextboxType textboxType = new TextboxType();
		textboxType.Name = Name;
		textboxType.Items = new object[8]
		{
			Text,
			CreateTableCellTextboxStyle(),
			Height + "in",
			Width + "in",
			Location.Y + "in",
			Location.X + "in",
			true,
			true
		};
		textboxType.ItemsElementName = new ItemsChoiceType14[8]
		{
			ItemsChoiceType14.Value,
			ItemsChoiceType14.Style,
			ItemsChoiceType14.Height,
			ItemsChoiceType14.Width,
			ItemsChoiceType14.Top,
			ItemsChoiceType14.Left,
			ItemsChoiceType14.CanGrow,
			ItemsChoiceType14.CanShrink
		};
		return textboxType;
	}

	private StyleType CreateTableCellTextboxStyle()
	{
		StyleType styleType = new StyleType();
		styleType.Items = new object[14]
		{
			TextColor,
			BgColor,
			IsBold,
			_Font.Size + "pt",
			_Font.Name,
			Utility.CreateBorderColorStyleWidthType(BorderColor.Name),
			Utility.CreateBorderColorStyleWidthType(BorderStyle.ToString()),
			Utility.CreateBorderColorStyleWidthType(BorderWidth + "pt"),
			TextAlign.ToString(),
			VText.ToString(),
			CellPadding + "pt",
			CellPadding + "pt",
			CellPadding + "pt",
			CellPadding + "pt"
		};
		styleType.ItemsElementName = new ItemsChoiceType5[14]
		{
			ItemsChoiceType5.Color,
			ItemsChoiceType5.BackgroundColor,
			ItemsChoiceType5.FontWeight,
			ItemsChoiceType5.FontSize,
			ItemsChoiceType5.FontFamily,
			ItemsChoiceType5.BorderColor,
			ItemsChoiceType5.BorderStyle,
			ItemsChoiceType5.BorderWidth,
			ItemsChoiceType5.TextAlign,
			ItemsChoiceType5.VerticalAlign,
			ItemsChoiceType5.PaddingLeft,
			ItemsChoiceType5.PaddingTop,
			ItemsChoiceType5.PaddingRight,
			ItemsChoiceType5.PaddingBottom
		};
		return styleType;
	}
}
