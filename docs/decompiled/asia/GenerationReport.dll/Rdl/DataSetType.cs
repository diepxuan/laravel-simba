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
public class DataSetType
{
	private object[] itemsField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Fields", typeof(FieldsType))]
	[XmlElement("Query", typeof(QueryType))]
	[XmlAnyElement]
	[XmlElement("AccentSensitivity", typeof(DataSetTypeAccentSensitivity))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("WidthSensitivity", typeof(DataSetTypeWidthSensitivity))]
	[XmlElement("CaseSensitivity", typeof(DataSetTypeCaseSensitivity))]
	[XmlElement("Collation", typeof(string))]
	[XmlElement("KanatypeSensitivity", typeof(DataSetTypeKanatypeSensitivity))]
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

	[XmlAttribute(DataType = "normalizedString")]
	public string Name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
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
