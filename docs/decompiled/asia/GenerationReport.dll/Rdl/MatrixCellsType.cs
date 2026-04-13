using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DebuggerStepThrough]
public class MatrixCellsType
{
	private MatrixCellType[] matrixCellField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("MatrixCell")]
	public MatrixCellType[] MatrixCell
	{
		get
		{
			return matrixCellField;
		}
		set
		{
			matrixCellField = value;
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
