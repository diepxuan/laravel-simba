using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Framework;

public class Null
{
	public static short NullShort => -1;

	public static int NullInteger => -1;

	public static float NullSingle => float.MinValue;

	public static double NullDouble => double.MinValue;

	public static decimal NullDecimal => decimal.MinValue;

	public static DateTime NullDate => DateTime.MinValue;

	public static string NullString => "";

	public static bool NullBoolean => false;

	public static Guid NullGuid => Guid.Empty;

	[DebuggerNonUserCode]
	public Null()
	{
	}

	public static object SetNull(object objValue, object objField)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(objValue)))
		{
			if (objField is short)
			{
				return NullShort;
			}
			if (objField is int)
			{
				return NullInteger;
			}
			if (objField is float)
			{
				return NullSingle;
			}
			if (objField is double)
			{
				return NullDouble;
			}
			if (objField is decimal)
			{
				return NullDecimal;
			}
			if (objField is DateTime)
			{
				return NullDate;
			}
			if (objField is string)
			{
				return NullString;
			}
			if (objField is bool)
			{
				return NullBoolean;
			}
			if (objField is Guid)
			{
				return NullGuid;
			}
			return null;
		}
		return RuntimeHelpers.GetObjectValue(objValue);
	}

	public static object SetNull(PropertyInfo objPropertyInfo)
	{
		string text = objPropertyInfo.PropertyType.ToString();
		switch (text)
		{
		case "System.Int16":
			return NullShort;
		default:
			if (0 == 0)
			{
				switch (text)
				{
				case "System.Single":
					return NullSingle;
				case "System.Double":
					return NullDouble;
				case "System.Decimal":
					return NullDecimal;
				case "System.DateTime":
					return NullDate;
				default:
					if (0 == 0)
					{
						if (Operators.CompareString(text, "System.Boolean", false) == 0)
						{
							return NullBoolean;
						}
						if (Operators.CompareString(text, "System.Guid", false) == 0)
						{
							return NullGuid;
						}
						Type propertyType = objPropertyInfo.PropertyType;
						if (((object)propertyType != null) & (Operators.CompareString(propertyType.GetType().ToString(), "System.RuntimeType", false) != 0))
						{
							if (propertyType.BaseType.Equals(typeof(Enum)))
							{
								Array values = Enum.GetValues(propertyType);
								Array.Sort(values);
								return RuntimeHelpers.GetObjectValue(Enum.ToObject(propertyType, RuntimeHelpers.GetObjectValue(values.GetValue(0))));
							}
							return null;
						}
						return null;
					}
					goto case "System.String";
				case "System.String":
				case "System.Char":
					return NullString;
				}
			}
			goto case "System.Int32";
		case "System.Int32":
		case "System.Int64":
			return NullInteger;
		}
	}

	public static object GetNull(object objField, object objDBNull)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(objField);
		if (objField == null)
		{
			objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
		}
		else if (objField is short)
		{
			if (Convert.ToInt16(RuntimeHelpers.GetObjectValue(objField)) == NullShort)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is int)
		{
			if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(objField)) == NullInteger)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is float)
		{
			if (Convert.ToSingle(RuntimeHelpers.GetObjectValue(objField)) == NullSingle)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is double)
		{
			if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(objField)) == NullDouble)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is decimal)
		{
			if (decimal.Compare(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(objField)), NullDecimal) == 0)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is DateTime)
		{
			if (DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(objField)).Date, NullDate.Date) == 0)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is string)
		{
			if (objField == null)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
			else if (Operators.CompareString(objField.ToString(), NullString, false) == 0)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is bool)
		{
			if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(objField)) == NullBoolean)
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		else if (objField is Guid)
		{
			Guid guid = default(Guid);
			if (((objField != null) ? ((Guid)objField) : guid).Equals(NullGuid))
			{
				objectValue = RuntimeHelpers.GetObjectValue(objDBNull);
			}
		}
		return objectValue;
	}

	public static bool IsNull(object objField)
	{
		if (objField != null)
		{
			if (objField is int)
			{
				return objField.Equals(NullInteger);
			}
			if (objField is float)
			{
				return objField.Equals(NullSingle);
			}
			if (objField is double)
			{
				return objField.Equals(NullDouble);
			}
			if (objField is decimal)
			{
				return objField.Equals(NullDecimal);
			}
			if (objField is DateTime)
			{
				return Conversions.ToDate(objField).Date.Equals(NullDate.Date);
			}
			if (objField is string)
			{
				return objField.Equals(NullString);
			}
			if (objField is bool)
			{
				return objField.Equals(NullBoolean);
			}
			if (objField is Guid)
			{
				return objField.Equals(NullGuid);
			}
			return false;
		}
		return true;
	}
}
