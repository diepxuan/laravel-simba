using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
[GeneratedCode("xsd", "2.0.50727.42")]
public enum ItemsChoiceType16
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
	MergeTransactions,
	NoRows,
	Parameters,
	RepeatWith,
	ReportName,
	Style,
	ToolTip,
	Top,
	Visibility,
	Width,
	ZIndex
}
