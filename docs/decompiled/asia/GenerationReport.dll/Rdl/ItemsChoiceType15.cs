using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
public enum ItemsChoiceType15
{
	[XmlEnum("##any:")]
	Item,
	Action,
	Bookmark,
	CustomProperties,
	DataElementName,
	DataElementOutput,
	Height,
	Label,
	Left,
	LinkToChild,
	MIMEType,
	RepeatWith,
	Sizing,
	Source,
	Style,
	ToolTip,
	Top,
	Value,
	Visibility,
	Width,
	ZIndex
}
