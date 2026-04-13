using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
public class TableCellsType
{
	private TableCellType[] tableCellField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("TableCell")]
	public TableCellType[] TableCell
	{
		get
		{
			return tableCellField;
		}
		set
		{
			tableCellField = value;
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
