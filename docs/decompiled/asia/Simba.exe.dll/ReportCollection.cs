using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using AsiaErp.Framework;

[Serializable]
public class ReportCollection : List<ReportInformation>, ICustomTypeDescriptor
{
	[DebuggerNonUserCode]
	public ReportCollection()
	{
	}

	public AttributeCollection GetAttributes()
	{
		return TypeDescriptor.GetAttributes(this, noCustomTypeDesc: true);
	}

	AttributeCollection ICustomTypeDescriptor.GetAttributes()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAttributes
		return this.GetAttributes();
	}

	public string GetClassName()
	{
		return TypeDescriptor.GetClassName(this, noCustomTypeDesc: true);
	}

	string ICustomTypeDescriptor.GetClassName()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetClassName
		return this.GetClassName();
	}

	public string GetComponentName()
	{
		return TypeDescriptor.GetComponentName(this, noCustomTypeDesc: true);
	}

	string ICustomTypeDescriptor.GetComponentName()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetComponentName
		return this.GetComponentName();
	}

	public TypeConverter GetConverter()
	{
		return TypeDescriptor.GetConverter(this, noCustomTypeDesc: true);
	}

	TypeConverter ICustomTypeDescriptor.GetConverter()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetConverter
		return this.GetConverter();
	}

	public EventDescriptor GetDefaultEvent()
	{
		return TypeDescriptor.GetDefaultEvent(this, noCustomTypeDesc: true);
	}

	EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDefaultEvent
		return this.GetDefaultEvent();
	}

	public PropertyDescriptor GetDefaultProperty()
	{
		return TypeDescriptor.GetDefaultProperty(this, noCustomTypeDesc: true);
	}

	PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDefaultProperty
		return this.GetDefaultProperty();
	}

	public object GetEditor(Type editorBaseType)
	{
		return TypeDescriptor.GetEditor(this, editorBaseType, noCustomTypeDesc: true);
	}

	object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEditor
		return this.GetEditor(editorBaseType);
	}

	public EventDescriptorCollection GetEvents()
	{
		return TypeDescriptor.GetEvents(this, noCustomTypeDesc: true);
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEvents
		return this.GetEvents();
	}

	public EventDescriptorCollection GetEvents(Attribute[] attributes)
	{
		return TypeDescriptor.GetEvents(this, attributes, noCustomTypeDesc: true);
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEvents
		return this.GetEvents(attributes);
	}

	public PropertyDescriptorCollection GetProperties()
	{
		PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(null);
		int num = Count - 1;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 > num4)
			{
				break;
			}
			ReportCollectionPropertyDescriptor value = new ReportCollectionPropertyDescriptor(this, num2);
			propertyDescriptorCollection.Add(value);
			num2++;
		}
		return propertyDescriptorCollection;
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetProperties
		return this.GetProperties();
	}

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	{
		return GetProperties();
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetProperties
		return this.GetProperties(attributes);
	}

	public object GetPropertyOwner(PropertyDescriptor pd)
	{
		return this;
	}

	object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetPropertyOwner
		return this.GetPropertyOwner(pd);
	}
}
