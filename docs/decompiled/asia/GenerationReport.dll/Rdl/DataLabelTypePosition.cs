using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[XmlType(AnonymousType = true)]
[GeneratedCode("xsd", "2.0.50727.42")]
public enum DataLabelTypePosition
{
	Auto,
	Top,
	TopLeft,
	TopRight,
	Left,
	Center,
	Right,
	BottomLeft,
	Bottom,
	BottomRight
}
