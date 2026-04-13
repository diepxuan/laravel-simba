using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[GeneratedCode("xsd", "2.0.50727.42")]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
public enum ItemsChoiceType37
{
	[XmlEnum("##any:")]
	Item,
	Author,
	AutoRefresh,
	Body,
	BottomMargin,
	Classes,
	Code,
	CodeModules,
	CustomProperties,
	DataElementName,
	DataElementStyle,
	DataSchema,
	DataSets,
	DataSources,
	DataTransform,
	Description,
	EmbeddedImages,
	InteractiveHeight,
	InteractiveWidth,
	Language,
	LeftMargin,
	PageFooter,
	PageHeader,
	PageHeight,
	PageWidth,
	ReportParameters,
	RightMargin,
	TopMargin,
	Width
}
