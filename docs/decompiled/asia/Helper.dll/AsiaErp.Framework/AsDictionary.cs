using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Framework;

public class AsDictionary : DictionaryBase
{
	public object this[object key]
	{
		get
		{
			return Dictionary[RuntimeHelpers.GetObjectValue(key)];
		}
		set
		{
			Dictionary[RuntimeHelpers.GetObjectValue(key)] = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public ICollection Keys => Dictionary.Keys;

	public ICollection Values => Dictionary.Values;

	[DebuggerNonUserCode]
	public AsDictionary()
	{
	}

	public void Add(object key, object value)
	{
		Dictionary.Add(RuntimeHelpers.GetObjectValue(key), RuntimeHelpers.GetObjectValue(value));
	}

	public void Add(DictionaryEntry oDic)
	{
		Dictionary.Add(RuntimeHelpers.GetObjectValue(oDic.Key), RuntimeHelpers.GetObjectValue(oDic.Value));
	}

	public bool Contains(object key)
	{
		return Dictionary.Contains(RuntimeHelpers.GetObjectValue(key));
	}

	public void Remove(object key)
	{
		Dictionary.Remove(RuntimeHelpers.GetObjectValue(key));
	}

	public void Adds(Collection colects, string keyMem)
	{
		foreach (object colect in colects)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(colect);
			Dictionary.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { keyMem }, (string[])null)), RuntimeHelpers.GetObjectValue(objectValue));
		}
	}
}
