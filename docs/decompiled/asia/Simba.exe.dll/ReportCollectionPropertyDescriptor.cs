using System;
using System.ComponentModel;

public class ReportCollectionPropertyDescriptor : PropertyDescriptor
{
	private ReportCollection collection;

	private int index;

	public override Type ComponentType => collection.GetType();

	public override bool IsReadOnly => false;

	public override Type PropertyType => collection[index].GetType();

	public override string Name => "#" + index;

	public override string Description => string.Empty;

	public override string DisplayName => collection[index].ten_mau;

	public override AttributeCollection Attributes => new AttributeCollection((Attribute[]?)null);

	public ReportCollectionPropertyDescriptor(ReportCollection collection, int idx)
		: base(idx.ToString(), null)
	{
		this.collection = null;
		index = -1;
		this.collection = collection;
		index = idx;
	}

	public override bool CanResetValue(object component)
	{
		return true;
	}

	public override object GetValue(object component)
	{
		return collection[index];
	}

	public override void ResetValue(object component)
	{
	}

	public override void SetValue(object component, object value)
	{
	}

	public override bool ShouldSerializeValue(object component)
	{
		return true;
	}
}
