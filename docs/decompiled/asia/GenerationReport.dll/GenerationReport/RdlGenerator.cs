using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Rdl;

namespace GenerationReport;

internal class RdlGenerator
{
	private DataGridView dgView;

	public ReportConfig RdlConfig { get; set; }

	public DataGridView DGView
	{
		get
		{
			return dgView;
		}
		set
		{
			dgView = value;
		}
	}

	public float HeightPageHeader { get; set; }

	public float WidthReport { get; set; }

	public string Title { get; set; }

	public string CompanyName { get; set; }

	public string ParentCompanyName { get; set; }

	public string SubTitle { get; set; }

	public string FilterTitle { get; set; }

	public string SubFilterTitle { get; set; }

	public RdlGenerator()
	{
		WidthReport = 13f;
	}

	private Report CreateReport()
	{
		Report report = new Report();
		WidthReport = 8.27f - RdlConfig.left - RdlConfig.right;
		report.Items = new object[10]
		{
			CreateDataSources(),
			CreatePageHeader(),
			CreateBody(),
			CreatePageFooter(),
			CreateDataSets(),
			WidthReport + "in",
			RdlConfig.top + "in",
			RdlConfig.left + "in",
			RdlConfig.right + "in",
			RdlConfig.botom + "in"
		};
		report.ItemsElementName = new ItemsChoiceType37[10]
		{
			ItemsChoiceType37.DataSources,
			ItemsChoiceType37.PageHeader,
			ItemsChoiceType37.Body,
			ItemsChoiceType37.PageFooter,
			ItemsChoiceType37.DataSets,
			ItemsChoiceType37.Width,
			ItemsChoiceType37.TopMargin,
			ItemsChoiceType37.LeftMargin,
			ItemsChoiceType37.RightMargin,
			ItemsChoiceType37.BottomMargin
		};
		return report;
	}

	private DataSourcesType CreateDataSources()
	{
		DataSourcesType dataSourcesType = new DataSourcesType();
		dataSourcesType.DataSource = new DataSourceType[1] { CreateDataSource() };
		return dataSourcesType;
	}

	private DataSourceType CreateDataSource()
	{
		DataSourceType dataSourceType = new DataSourceType();
		dataSourceType.Name = "DummyDataSource";
		dataSourceType.Items = new object[1] { CreateConnectionProperties() };
		return dataSourceType;
	}

	private ConnectionPropertiesType CreateConnectionProperties()
	{
		ConnectionPropertiesType connectionPropertiesType = new ConnectionPropertiesType();
		connectionPropertiesType.Items = new object[2] { "", "SQL" };
		connectionPropertiesType.ItemsElementName = new ItemsChoiceType[2]
		{
			ItemsChoiceType.ConnectString,
			ItemsChoiceType.DataProvider
		};
		return connectionPropertiesType;
	}

	private PageHeaderFooterType CreatePageHeader()
	{
		HeightPageHeader = 0f;
		PageHeaderFooterType pageHeaderFooterType = new PageHeaderFooterType();
		pageHeaderFooterType.Items = new object[3]
		{
			CreateHeaderReportItems(),
			(double)HeightPageHeader * 1.5 + "in",
			true
		};
		pageHeaderFooterType.ItemsElementName = new ItemsChoiceType34[3]
		{
			ItemsChoiceType34.ReportItems,
			ItemsChoiceType34.Height,
			ItemsChoiceType34.PrintOnFirstPage
		};
		return pageHeaderFooterType;
	}

	private ReportItemsType CreateHeaderReportItems()
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		TextBoxRdlGenerator textBoxRdlGenerator = new TextBoxRdlGenerator();
		TextBoxRdlGenerator textBoxRdlGenerator2 = new TextBoxRdlGenerator();
		TextBoxRdlGenerator textBoxRdlGenerator3 = new TextBoxRdlGenerator();
		TextBoxRdlGenerator textBoxRdlGenerator4 = new TextBoxRdlGenerator();
		TextBoxRdlGenerator textBoxRdlGenerator5 = new TextBoxRdlGenerator();
		TextBoxRdlGenerator textBoxRdlGenerator6 = new TextBoxRdlGenerator();
		textBoxRdlGenerator3.Width = WidthReport;
		textBoxRdlGenerator3.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator3.Name = "txtParentCompanyName";
		textBoxRdlGenerator3.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + ParentCompanyName + "\")";
		textBoxRdlGenerator3.IsBold = "Bold";
		textBoxRdlGenerator3._Font = RdlConfig.fontParent;
		textBoxRdlGenerator3.TextAlign = HorizontalText.Left;
		textBoxRdlGenerator3.Height = (float)textBoxRdlGenerator3._Font.Height / 100f;
		HeightPageHeader += textBoxRdlGenerator3.Height;
		textBoxRdlGenerator2.Width = WidthReport;
		textBoxRdlGenerator2.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator2.Name = "txtCompanyName";
		textBoxRdlGenerator2.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + CompanyName + "\")";
		textBoxRdlGenerator2.IsBold = "Bold";
		textBoxRdlGenerator2.TextAlign = HorizontalText.Left;
		textBoxRdlGenerator2.Height = (float)textBoxRdlGenerator2._Font.Height / 100f;
		HeightPageHeader += textBoxRdlGenerator2.Height;
		textBoxRdlGenerator2._Font = RdlConfig.fontCompanyName;
		textBoxRdlGenerator2.Location = new PointF(0f, textBoxRdlGenerator3.Height);
		textBoxRdlGenerator.Width = WidthReport;
		textBoxRdlGenerator.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + Title + "\")";
		textBoxRdlGenerator.Name = "txtTitle";
		textBoxRdlGenerator.IsBold = "Bold";
		textBoxRdlGenerator._Font = RdlConfig.fontTitle;
		textBoxRdlGenerator.TextAlign = HorizontalText.Left;
		textBoxRdlGenerator.Height = (float)textBoxRdlGenerator._Font.Height / 100f + 0.1f;
		HeightPageHeader += textBoxRdlGenerator.Height;
		textBoxRdlGenerator.Location = new PointF(0f, textBoxRdlGenerator3.Height + textBoxRdlGenerator2.Height);
		textBoxRdlGenerator4.Width = WidthReport;
		textBoxRdlGenerator4.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator4.Name = "txtSubTitle";
		textBoxRdlGenerator4.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + SubTitle + "\")";
		textBoxRdlGenerator4.IsBold = "Bold";
		textBoxRdlGenerator4._Font = RdlConfig.fontTaikhoan;
		textBoxRdlGenerator4.TextAlign = HorizontalText.Left;
		textBoxRdlGenerator4.Height = (float)textBoxRdlGenerator4._Font.Height / 100f;
		HeightPageHeader += textBoxRdlGenerator4.Height;
		textBoxRdlGenerator4.Location = new PointF(0f, textBoxRdlGenerator3.Height + textBoxRdlGenerator2.Height + textBoxRdlGenerator.Height);
		textBoxRdlGenerator5.Width = WidthReport;
		textBoxRdlGenerator5.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator5.Name = "txtFilterTitle";
		textBoxRdlGenerator5.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + FilterTitle + "\")";
		textBoxRdlGenerator5.IsBold = "Bold";
		textBoxRdlGenerator5._Font = RdlConfig.fontTaikhoan;
		textBoxRdlGenerator5.TextAlign = HorizontalText.Left;
		if (FilterTitle.ToString().Trim() != "")
		{
			textBoxRdlGenerator5.Height = (float)textBoxRdlGenerator5._Font.Height / 100f;
		}
		else
		{
			textBoxRdlGenerator5.Height = 0f;
			textBoxRdlGenerator5.Width = 0f;
		}
		HeightPageHeader += textBoxRdlGenerator5.Height;
		textBoxRdlGenerator5.Location = new PointF(0f, textBoxRdlGenerator4.Height + textBoxRdlGenerator3.Height + textBoxRdlGenerator2.Height + textBoxRdlGenerator.Height);
		textBoxRdlGenerator6.Width = WidthReport;
		textBoxRdlGenerator6.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator6.Name = "txtSubFilterTitle";
		textBoxRdlGenerator6.Text = "=iif((Globals!PageNumber) > 1, \"\", \"" + SubFilterTitle + "\")";
		textBoxRdlGenerator6.IsBold = "Bold";
		textBoxRdlGenerator6._Font = RdlConfig.fontTaikhoan;
		textBoxRdlGenerator6.TextAlign = HorizontalText.Left;
		if (SubFilterTitle.ToString().Trim() != "")
		{
			textBoxRdlGenerator6.Height = (float)textBoxRdlGenerator6._Font.Height / 100f;
		}
		else
		{
			textBoxRdlGenerator6.Height = 0f;
			textBoxRdlGenerator6.Width = 0f;
		}
		HeightPageHeader += textBoxRdlGenerator6.Height;
		textBoxRdlGenerator6.Location = new PointF(0f, textBoxRdlGenerator5.Height + textBoxRdlGenerator4.Height + textBoxRdlGenerator3.Height + textBoxRdlGenerator2.Height + textBoxRdlGenerator.Height);
		reportItemsType.Items = new object[6]
		{
			textBoxRdlGenerator3.CreateTableCellTextbox(),
			textBoxRdlGenerator2.CreateTableCellTextbox(),
			textBoxRdlGenerator.CreateTableCellTextbox(),
			textBoxRdlGenerator4.CreateTableCellTextbox(),
			textBoxRdlGenerator5.CreateTableCellTextbox(),
			textBoxRdlGenerator6.CreateTableCellTextbox()
		};
		return reportItemsType;
	}

	private BodyType CreateBody()
	{
		BodyType bodyType = new BodyType();
		bodyType.Items = new object[2]
		{
			CreateReportItems(),
			"1in"
		};
		bodyType.ItemsElementName = new ItemsChoiceType30[2]
		{
			ItemsChoiceType30.ReportItems,
			ItemsChoiceType30.Height
		};
		return bodyType;
	}

	private ReportItemsType CreateReportItems()
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		TableRdlGenerator tableRdlGenerator = new TableRdlGenerator(HeightPageHeader);
		tableRdlGenerator.DGView = DGView;
		tableRdlGenerator.RdlConfig = RdlConfig;
		reportItemsType.Items = new object[1] { tableRdlGenerator.CreateTable() };
		return reportItemsType;
	}

	private PageHeaderFooterType CreatePageFooter()
	{
		PageHeaderFooterType pageHeaderFooterType = new PageHeaderFooterType();
		pageHeaderFooterType.Items = new object[4]
		{
			CreateFooterReportItems(),
			"0.5in",
			true,
			true
		};
		pageHeaderFooterType.ItemsElementName = new ItemsChoiceType34[4]
		{
			ItemsChoiceType34.ReportItems,
			ItemsChoiceType34.Height,
			ItemsChoiceType34.PrintOnFirstPage,
			ItemsChoiceType34.PrintOnLastPage
		};
		return pageHeaderFooterType;
	}

	private ReportItemsType CreateFooterReportItems()
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		TextBoxRdlGenerator textBoxRdlGenerator = new TextBoxRdlGenerator();
		textBoxRdlGenerator.Width = WidthReport;
		textBoxRdlGenerator.BorderStyle = EBorderStyle.None;
		textBoxRdlGenerator.Name = "txtTrang";
		textBoxRdlGenerator.Text = "= \"Trang \"&Globals!PageNumber  & \"/\"& Globals!TotalPages";
		textBoxRdlGenerator.IsBold = "Bold";
		textBoxRdlGenerator._Font = RdlConfig.fontTrang;
		textBoxRdlGenerator.TextAlign = HorizontalText.Left;
		textBoxRdlGenerator.Height = (float)textBoxRdlGenerator._Font.Height / 100f;
		textBoxRdlGenerator.Location = new PointF(0f, textBoxRdlGenerator.Height);
		reportItemsType.Items = new object[1] { textBoxRdlGenerator.CreateTableCellTextbox() };
		return reportItemsType;
	}

	private DataSetsType CreateDataSets()
	{
		DataSetsType dataSetsType = new DataSetsType();
		dataSetsType.DataSet = new DataSetType[1] { CreateDataSet() };
		return dataSetsType;
	}

	private DataSetType CreateDataSet()
	{
		DataSetType dataSetType = new DataSetType();
		dataSetType.Name = "MyData";
		dataSetType.Items = new object[2]
		{
			CreateQuery(),
			CreateFields()
		};
		return dataSetType;
	}

	private QueryType CreateQuery()
	{
		QueryType queryType = new QueryType();
		queryType.Items = new object[2] { "DummyDataSource", "" };
		queryType.ItemsElementName = new ItemsChoiceType2[2]
		{
			ItemsChoiceType2.DataSourceName,
			ItemsChoiceType2.CommandText
		};
		return queryType;
	}

	private FieldsType CreateFields()
	{
		FieldsType fieldsType = new FieldsType();
		fieldsType.Field = new FieldType[((BaseCollection)DGView.Columns).Count];
		for (int i = 0; i < ((BaseCollection)DGView.Columns).Count; i++)
		{
			fieldsType.Field[i] = CreateField(DGView.Columns[i].DataPropertyName);
		}
		return fieldsType;
	}

	private FieldType CreateField(string fieldName)
	{
		FieldType fieldType = new FieldType();
		fieldType.Name = fieldName;
		fieldType.Items = new object[1] { fieldName };
		fieldType.ItemsElementName = new ItemsChoiceType1[1] { ItemsChoiceType1.DataField };
		return fieldType;
	}

	public void WriteXml(Stream stream)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		XmlSerializer val = new XmlSerializer(typeof(Report));
		val.Serialize(stream, (object)CreateReport());
	}
}
