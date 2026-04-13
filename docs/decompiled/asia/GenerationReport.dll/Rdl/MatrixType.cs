using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("xsd", "2.0.50727.42")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class MatrixType
{
	private object[] itemsField;

	private ItemsChoiceType19[] itemsElementNameField;

	private string nameField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("Width", typeof(string), DataType = "normalizedString")]
	[XmlElement("ZIndex", typeof(uint))]
	[XmlChoiceIdentifier("ItemsElementName")]
	[XmlElement("GroupsBeforeRowHeaders", typeof(uint))]
	[XmlElement("Height", typeof(string))]
	[XmlElement("Visibility", typeof(VisibilityType))]
	[XmlAnyElement]
	[XmlElement("Action", typeof(ActionType))]
	[XmlElement("Bookmark", typeof(string))]
	[XmlElement("CellDataElementName", typeof(string))]
	[XmlElement("CellDataElementOutput", typeof(MatrixTypeCellDataElementOutput))]
	[XmlElement("ColumnGroupings", typeof(ColumnGroupingsType))]
	[XmlElement("Corner", typeof(CornerType))]
	[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
	[XmlElement("DataElementName", typeof(string))]
	[XmlElement("DataElementOutput", typeof(MatrixTypeDataElementOutput))]
	[XmlElement("DataSetName", typeof(string))]
	[XmlElement("Filters", typeof(FiltersType))]
	[XmlElement("KeepTogether", typeof(bool))]
	[XmlElement("Label", typeof(string))]
	[XmlElement("LayoutDirection", typeof(MatrixTypeLayoutDirection))]
	[XmlElement("Left", typeof(string), DataType = "normalizedString")]
	[XmlElement("LinkToChild", typeof(string))]
	[XmlElement("MatrixColumns", typeof(MatrixColumnsType))]
	[XmlElement("MatrixRows", typeof(MatrixRowsType))]
	[XmlElement("NoRows", typeof(string))]
	[XmlElement("PageBreakAtEnd", typeof(bool))]
	[XmlElement("PageBreakAtStart", typeof(bool))]
	[XmlElement("RepeatWith", typeof(string))]
	[XmlElement("RowGroupings", typeof(RowGroupingsType))]
	[XmlElement("Style", typeof(StyleType))]
	[XmlElement("ToolTip", typeof(string))]
	[XmlElement("Top", typeof(string), DataType = "normalizedString")]
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
	public ItemsChoiceType19[] ItemsElementName
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
