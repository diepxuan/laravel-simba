using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
[GeneratedCode("xsd", "2.0.50727.42")]
public enum ItemsChoiceType29
{
	[XmlEnum("##any:")]
	Item,
	AltReportItem,
	Bookmark,
	CustomData,
	CustomProperties,
	DataElementName,
	DataElementOutput,
	Height,
	Label,
	Left,
	RepeatWith,
	Style,
	Top,
	Type,
	Visibility,
	Width,
	ZIndex
}
