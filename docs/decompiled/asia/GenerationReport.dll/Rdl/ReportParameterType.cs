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
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
[DesignerCategory("code")]
public class ReportParameterType
{
	private object[] itemsField;

	private ItemsChoiceType33[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Nullable", typeof(bool))]
	[XmlElement("AllowBlank", typeof(bool))]
	[XmlElement("DataType", typeof(ReportParameterTypeDataType))]
	[XmlElement("MultiValue", typeof(bool))]
	[XmlElement("DefaultValue", typeof(DefaultValueType))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlAnyElement]
	[XmlElement("Hidden", typeof(bool))]
	[XmlElement("Prompt", typeof(string))]
	[XmlElement("UsedInQuery", typeof(ReportParameterTypeUsedInQuery))]
	[XmlElement("ValidValues", typeof(ValidValuesType))]
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

	[XmlIgnore]
	[XmlElement("ItemsElementName")]
	public ItemsChoiceType33[] ItemsElementName
	{
		get
		{
			return itemsElementNameField;
		}
		set
		{
			itemsElementNameField = value;
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
