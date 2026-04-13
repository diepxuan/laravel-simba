using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class ReportItemsType
{
	private object[] itemsField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Matrix", typeof(MatrixType))]
	[XmlElement("Image", typeof(ImageType))]
	[XmlElement("Rectangle", typeof(RectangleType))]
	[XmlElement("Subreport", typeof(SubreportType))]
	[XmlElement("CustomReportItem", typeof(CustomReportItemType))]
	[XmlElement("Textbox", typeof(TextboxType))]
	[XmlElement("Line", typeof(LineType))]
	[XmlElement("List", typeof(ListType))]
	[XmlElement("Table", typeof(TableType))]
	[XmlAnyElement]
	[XmlElement("Chart", typeof(ChartType))]
	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
		}
	}

	[XmlAnyAttribute]
	public XmlAttribute[] AnyAttr
	{
		get
		{
			return anyAttrField;
		}
		set
		{
			anyAttrField = value;
		}
	}
}
