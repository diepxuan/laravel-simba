using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class MatrixRowsType
{
	private MatrixRowType[] matrixRowField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("MatrixRow")]
	public MatrixRowType[] MatrixRow
	{
		get
		{
			return matrixRowField;
		}
		set
		{
			matrixRowField = value;
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
