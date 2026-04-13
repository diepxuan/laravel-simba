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
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
public class ChartType
{
	private object[] itemsField;

	private ItemsChoiceType27[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Label", typeof(string))]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CategoryAxis", typeof(CategoryAxisType))]
	[XmlElement("CategoryGroupings", typeof(CategoryGroupingsType))]
	[XmlElement("ChartData", typeof(ChartDataType))]
	[XmlElement("ChartElementOutput", typeof(ChartTypeChartElementOutput))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(ChartTypeDataElementOutput))]
	[XmlElement("DataSetName", typeof(string))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("Height", typeof(string))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("Legend", typeof(LegendType))]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("NoRows", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("Palette", typeof(ChartTypePalette))]
	[XmlElement("PlotArea", typeof(PlotAreaType))]
	[XmlElement("PointWidth", typeof(uint))]
	[XmlElement("SeriesGroupings", typeof(SeriesGroupingsType))]
	[XmlElement("KeepTogether", typeof(bool))]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlElement("ThreeDProperties", typeof(ThreeDPropertiesType))]
	[XmlElement("Title", typeof(TitleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
	[XmlElement("Subtype", typeof(ChartTypeSubtype))]
	[XmlElement("Type", typeof(ChartTypeType))]
	[XmlElement("ValueAxis", typeof(ValueAxisType))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
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
	public ItemsChoiceType27[] ItemsElementName
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
