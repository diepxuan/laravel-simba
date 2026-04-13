using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("xsd", "2.0.50727.42")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
public class EmbeddedImagesType
{
	private EmbeddedImageType[] embeddedImageField;

	private XmlAttribute[] anyAttrField;

	[XmlElement("EmbeddedImage")]
	public EmbeddedImageType[] EmbeddedImage
	{
		get
		{
			return embeddedImageField;
		}
		set
		{
			embeddedImageField = value;
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
