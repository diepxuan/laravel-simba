using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IsNullable = false)]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class Report
{
	private object[] itemsField;

	private ItemsChoiceType37[] itemsElementNameField;

	private XmlAttribute[] anyAttrField;

	[XmlAnyElement]
	[XmlElement("DataTransform", typeof(string))]
	[XmlElement("Description", typeof(string))]
	[XmlElement("EmbeddedImages", typeof(EmbeddedImagesType))]
	[XmlElement("InteractiveHeight", typeof(string), DataType = "normalizedString")]
	[XmlElement("InteractiveWidth", typeof(string), DataType = "normalizedString")]
	[XmlElement("Language", typeof(string))]
	[XmlElement("LeftMargin", typeof(string), DataType = "normalizedString")]
	[XmlElement("PageFooter", typeof(PageHeaderFooterType))]
	[XmlElement("PageHeader", typeof(PageHeaderFooterType))]
	[XmlElement("PageHeight", typeof(string), DataType = "normalizedString")]
	[XmlElement("PageWidth", typeof(string), DataType = "normalizedString")]
	[XmlElement("ReportParameters", typeof(ReportParametersType))]
	[XmlElement("RightMargin", typeof(string), DataType = "normalizedString")]
	[XmlElement("TopMargin", typeof(string), DataType = "normalizedString")]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("DataSchema", typeof(string))]
	[XmlElement("Classes", typeof(ClassesType))]
	[XmlElement("DataSources", typeof(DataSourcesType))]
	[XmlElement("AutoRefresh", typeof(uint))]
	[XmlElement("Body", typeof(BodyType))]
	[XmlElement("BottomMargin", typeof(string), DataType = "normalizedString")]
	[XmlElement("Code", typeof(string))]
	[XmlElement("CodeModules", typeof(CodeModulesType))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("Author", typeof(string))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementStyle", typeof(ReportDataElementStyle))]
	[XmlElement("DataSets", typeof(DataSetsType))]
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
	public ItemsChoiceType37[] ItemsElementName
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
