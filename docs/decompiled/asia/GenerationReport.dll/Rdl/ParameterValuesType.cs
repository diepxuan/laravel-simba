using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
public class ParameterValuesType
{
	private ParameterValueType[] parameterValueField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("ParameterValue")]
	public ParameterValueType[] ParameterValue
	{
		get
		{
			return parameterValueField;
		}
		set
		{
			parameterValueField = value;
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
