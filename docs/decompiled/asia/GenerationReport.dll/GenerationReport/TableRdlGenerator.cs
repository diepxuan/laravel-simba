using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rdl;

namespace GenerationReport;

internal class TableRdlGenerator
{
	private List<string> m_fields;

	private bool isBold;

	public Color BorderColor { get; set; }

	public Color RowColor1 { get; set; }

	public Color RowColor2 { get; set; }

	public float BorderWidth { get; set; }

	public EBorderStyle BorderStyle { get; set; }

	public PointF Localtion { get; set; }

	public DataGridView DGView { get; set; }

	public ReportConfig RdlConfig { get; set; }

	private int CellPadding { get; set; }

	public List<string> Fields
	{
		get
		{
			return m_fields;
		}
		set
		{
			m_fields = value;
		}
	}

	public TableRdlGenerator(float location)
	{
		BorderColor = Color.Black;
		BorderWidth = 0.5f;
		BorderStyle = EBorderStyle.Solid;
		CellPadding = 4;
		RowColor1 = Color.FromName("AliceBlue");
		RowColor2 = Color.FromName("White");
	}

	public TableType CreateTable()
	{
		TableType tableType = new TableType();
		tableType.Name = "Table1";
		tableType.Items = new object[5]
		{
			CreateTableColumns(),
			CreateHeader(),
			CreateDetails(),
			Localtion.X + "in",
			Localtion.Y + "in"
		};
		tableType.ItemsElementName = new ItemsChoiceType21[5]
		{
			ItemsChoiceType21.TableColumns,
			ItemsChoiceType21.Header,
			ItemsChoiceType21.Details,
			ItemsChoiceType21.Left,
			ItemsChoiceType21.Top
		};
		return tableType;
	}

	private HeaderType CreateHeader()
	{
		HeaderType headerType = new HeaderType();
		headerType.Items = new object[2]
		{
			CreateHeaderTableRows(),
			true
		};
		headerType.ItemsElementName = new ItemsChoiceType20[2]
		{
			ItemsChoiceType20.TableRows,
			ItemsChoiceType20.RepeatOnNewPage
		};
		return headerType;
	}

	private TableRowsType CreateHeaderTableRows()
	{
		TableRowsType tableRowsType = new TableRowsType();
		tableRowsType.TableRow = new TableRowType[1] { CreateHeaderTableRow() };
		return tableRowsType;
	}

	private TableRowType CreateHeaderTableRow()
	{
		TableRowType tableRowType = new TableRowType();
		tableRowType.Items = new object[2]
		{
			CreateHeaderTableCells(),
			"0.25in"
		};
		return tableRowType;
	}

	private TableCellsType CreateHeaderTableCells()
	{
		TableCellsType tableCellsType = new TableCellsType();
		tableCellsType.TableCell = new TableCellType[((BaseCollection)DGView.Columns).Count];
		for (int i = 0; i < ((BaseCollection)DGView.Columns).Count; i++)
		{
			tableCellsType.TableCell[i] = CreateHeaderTableCell(DGView.Columns[i].DataPropertyName, DGView.Columns[i].HeaderText);
		}
		return tableCellsType;
	}

	private TableCellType CreateHeaderTableCell(string fieldName, string fieldText)
	{
		TableCellType tableCellType = new TableCellType();
		tableCellType.Items = new object[1] { CreateHeaderTableCellReportItems(fieldName, fieldText) };
		return tableCellType;
	}

	private ReportItemsType CreateHeaderTableCellReportItems(string fieldName, string fieldText)
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		TextBoxRdlGenerator textBoxRdlGenerator = new TextBoxRdlGenerator();
		textBoxRdlGenerator.BgColor = "AliceBlue";
		textBoxRdlGenerator.Name = fieldName + "_header";
		textBoxRdlGenerator.Text = fieldText;
		textBoxRdlGenerator.BorderStyle = EBorderStyle.Solid;
		textBoxRdlGenerator.IsBold = "Bold";
		textBoxRdlGenerator._Font = RdlConfig.fontHeaderTable;
		reportItemsType.Items = new object[1] { textBoxRdlGenerator.CreateTableCellTextbox() };
		return reportItemsType;
	}

	private DetailsType CreateDetails()
	{
		DetailsType detailsType = new DetailsType();
		detailsType.Items = new object[1] { CreateTableRows() };
		return detailsType;
	}

	private TableRowsType CreateTableRows()
	{
		TableRowsType tableRowsType = new TableRowsType();
		tableRowsType.TableRow = new TableRowType[1] { CreateTableRow() };
		return tableRowsType;
	}

	private TableRowType CreateTableRow()
	{
		TableRowType tableRowType = new TableRowType();
		tableRowType.Items = new object[2]
		{
			CreateTableCells(),
			"0.3in"
		};
		return tableRowType;
	}

	private TableCellsType CreateTableCells()
	{
		TableCellsType tableCellsType = new TableCellsType();
		tableCellsType.TableCell = new TableCellType[((BaseCollection)DGView.Columns).Count];
		for (int i = 0; i < ((BaseCollection)DGView.Columns).Count; i++)
		{
			tableCellsType.TableCell[i] = CreateTableCell(DGView.Columns[i].DataPropertyName, i);
		}
		return tableCellsType;
	}

	private TableCellType CreateTableCell(string fieldName, int ColIndex)
	{
		TableCellType tableCellType = new TableCellType();
		tableCellType.Items = new object[1] { CreateTableCellReportItems(fieldName, ColIndex) };
		return tableCellType;
	}

	private ReportItemsType CreateTableCellReportItems(string fieldName, int ColIndex)
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		TextBoxRdlGenerator textBoxRdlGenerator = new TextBoxRdlGenerator();
		textBoxRdlGenerator.Text = "=Fields!" + fieldName + ".Value";
		textBoxRdlGenerator.Name = fieldName;
		textBoxRdlGenerator._Font = RdlConfig.fontTableCell;
		if (isBold)
		{
			textBoxRdlGenerator.IsBold = "=iif(Fields!bold.Value, \"Bold\", \"Normal\")";
		}
		if ((object)DGView.Columns[ColIndex].ValueType == typeof(decimal))
		{
			textBoxRdlGenerator.TextAlign = HorizontalText.Right;
		}
		else if ((object)DGView.Columns[ColIndex].ValueType == typeof(DateTime))
		{
			textBoxRdlGenerator.TextAlign = HorizontalText.Center;
		}
		else
		{
			textBoxRdlGenerator.TextAlign = HorizontalText.Left;
		}
		reportItemsType.Items = new object[1] { textBoxRdlGenerator.CreateTableCellTextbox() };
		return reportItemsType;
	}

	private TableColumnsType CreateTableColumns()
	{
		TableColumnsType tableColumnsType = new TableColumnsType();
		tableColumnsType.TableColumn = new TableColumnType[((BaseCollection)DGView.Columns).Count];
		for (int i = 0; i < ((BaseCollection)DGView.Columns).Count; i++)
		{
			if (((DataGridViewBand)DGView.Columns[i]).Visible)
			{
				tableColumnsType.TableColumn[i] = CreateTableColumn((float)DGView.Columns[i].Width / 80f);
				continue;
			}
			tableColumnsType.TableColumn[i] = CreateTableColumn(0f);
			if (DGView.Columns[i].DataPropertyName.ToUpper() == "BOLD")
			{
				isBold = true;
			}
		}
		return tableColumnsType;
	}

	private TableColumnType CreateTableColumn(float WidthCol)
	{
		TableColumnType tableColumnType = new TableColumnType();
		tableColumnType.Items = new object[1] { WidthCol + "in" };
		return tableColumnType;
	}
}
