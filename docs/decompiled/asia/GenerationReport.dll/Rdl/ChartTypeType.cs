using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "2.0.50727.42")]
public enum ChartTypeType
{
	Column,
	Bar,
	Line,
	Pie,
	Scatter,
	Bubble,
	Area,
	Doughnut,
	Stock
}
