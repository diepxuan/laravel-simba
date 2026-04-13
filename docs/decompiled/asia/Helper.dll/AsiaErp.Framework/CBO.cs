using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.Framework;

public class CBO
{
	[DebuggerNonUserCode]
	public CBO()
	{
	}

	public static ArrayList GetPropertyInfo(Type objType)
	{
		ArrayList arrayList = null;
		if (arrayList == null)
		{
			arrayList = new ArrayList();
			PropertyInfo[] properties = objType.GetProperties();
			foreach (PropertyInfo value in properties)
			{
				arrayList.Add(value);
			}
		}
		return arrayList;
	}

	private static int[] GetOrdinals(ArrayList objProperties, IDataReader dr)
	{
		checked
		{
			int[] array = new int[objProperties.Count + 1];
			if (dr != null)
			{
				int num = objProperties.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					array[num2] = -1;
					try
					{
						array[num2] = dr.GetOrdinal(((PropertyInfo)objProperties[num2]).Name);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					num2++;
				}
			}
			return array;
		}
	}

	private static object CreateObject(Type objType, IDataReader dr, ArrayList objProperties, int[] arrOrdinals)
	{
		Type type = null;
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(objType));
		checked
		{
			int num = objProperties.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo = (PropertyInfo)objProperties[num2];
				if (propertyInfo.CanWrite)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo));
					if (arrOrdinals[num2] != -1)
					{
						if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
						{
							propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), null);
						}
						else
						{
							try
							{
								propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), null);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								try
								{
									type = propertyInfo.PropertyType;
									if (type.BaseType.Equals(typeof(Enum)))
									{
										if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))), null);
										}
										else
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])))), null);
										}
									}
									else
									{
										propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				num2++;
			}
			return objectValue;
		}
	}

	public static object FillObject(IDataReader dr, Type objType)
	{
		return FillObject(dr, objType, ManageDataReader: true);
	}

	public static object FillObject(IDataReader dr, Type objType, bool ManageDataReader)
	{
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		bool flag;
		if (ManageDataReader)
		{
			flag = false;
			if (dr.Read())
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		object result = ((!flag) ? null : RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals)));
		if (ManageDataReader)
		{
			dr?.Close();
		}
		return result;
	}

	public static List<object> FillList(IDataReader dr, Type objType)
	{
		List<object> list = new List<object>();
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			list.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return list;
	}

	public static ArrayList FillCollection(IDataReader dr, Type objType)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			arrayList.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return arrayList;
	}

	public static IList FillCollection(IDataReader dr, Type objType, ref IList objToFill)
	{
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			objToFill.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return objToFill;
	}

	public static object InitializeObject(object objObject, Type objType)
	{
		ArrayList propertyInfo = GetPropertyInfo(objType);
		checked
		{
			int num = propertyInfo.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo2 = (PropertyInfo)propertyInfo[num2];
				if (propertyInfo2.CanWrite)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo2));
					propertyInfo2.SetValue(RuntimeHelpers.GetObjectValue(objObject), RuntimeHelpers.GetObjectValue(objectValue), null);
				}
				num2++;
			}
			return objObject;
		}
	}

	public static XmlDocument Serialize(object objObject)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		XmlSerializer val = new XmlSerializer(objObject.GetType());
		StringBuilder sb = new StringBuilder();
		TextWriter textWriter = new StringWriter(sb);
		val.Serialize(textWriter, RuntimeHelpers.GetObjectValue(objObject));
		StringReader reader = new StringReader(textWriter.ToString());
		DataSet dataSet = new DataSet();
		dataSet.ReadXml((TextReader?)reader);
		XmlDocument val2 = new XmlDocument();
		val2.LoadXml(dataSet.GetXml());
		return val2;
	}

	private static object CreateObject(Type objType, DataTableReader dr, ArrayList objProperties, int[] arrOrdinals)
	{
		Type type = null;
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(objType));
		checked
		{
			int num = objProperties.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo = (PropertyInfo)objProperties[num2];
				if (propertyInfo.CanWrite)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo));
					if (arrOrdinals[num2] != -1)
					{
						if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
						{
							propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), null);
						}
						else
						{
							try
							{
								propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), null);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								try
								{
									type = propertyInfo.PropertyType;
									if (type.BaseType.Equals(typeof(Enum)))
									{
										if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))), null);
										}
										else
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])))), null);
										}
									}
									else
									{
										propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				num2++;
			}
			return objectValue;
		}
	}

	public static ArrayList FillCollection(DataTableReader dr, Type objType)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			arrayList.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return arrayList;
	}

	public static IList FillCollection(DataTableReader dr, Type objType, ref IList objToFill)
	{
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			objToFill.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return objToFill;
	}

	public static Hashtable FillHashTable(IDataReader dr, Type objType, string propertyKeyName)
	{
		Hashtable hashtable = new Hashtable();
		object obj = null;
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		PropertyInfo property = objType.GetProperty(propertyKeyName);
		bool flag = (object)property != null;
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			if (flag)
			{
				obj = RuntimeHelpers.GetObjectValue(property.GetValue(RuntimeHelpers.GetObjectValue(objectValue), null));
			}
			hashtable.Add(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return hashtable;
	}

	public static Hashtable FillHashTable(DataTableReader dr, Type objType, string propertyKeyName)
	{
		Hashtable hashtable = new Hashtable();
		object obj = null;
		ArrayList propertyInfo = GetPropertyInfo(objType);
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		PropertyInfo property = objType.GetProperty(propertyKeyName);
		bool flag = (object)property != null;
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(objType, dr, propertyInfo, ordinals));
			if (flag)
			{
				obj = RuntimeHelpers.GetObjectValue(property.GetValue(RuntimeHelpers.GetObjectValue(objectValue), null));
			}
			hashtable.Add(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return hashtable;
	}

	private static int[] GetValue(ArrayList objProperties, IDataReader dr)
	{
		checked
		{
			int[] array = new int[objProperties.Count + 1];
			if (dr != null)
			{
				int num = objProperties.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					array[num2] = -1;
					try
					{
						array[num2] = dr.GetOrdinal(((PropertyInfo)objProperties[num2]).Name);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					num2++;
				}
			}
			return array;
		}
	}
}
public class CBO<T>
{
	public static Type MyType => typeof(T);

	[DebuggerNonUserCode]
	public CBO()
	{
	}

	public static ArrayList GetPropertyInfo()
	{
		ArrayList arrayList = null;
		if (arrayList == null)
		{
			arrayList = new ArrayList();
			PropertyInfo[] properties = MyType.GetProperties();
			foreach (PropertyInfo value in properties)
			{
				arrayList.Add(value);
			}
		}
		return arrayList;
	}

	private static int[] GetOrdinals(ArrayList objProperties, IDataReader dr)
	{
		checked
		{
			int[] array = new int[objProperties.Count + 1];
			if (dr != null)
			{
				int num = objProperties.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					array[num2] = -1;
					try
					{
						array[num2] = dr.GetOrdinal(((PropertyInfo)objProperties[num2]).Name);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					num2++;
				}
			}
			return array;
		}
	}

	private static object CreateObject(IDataReader dr, ArrayList objProperties, int[] arrOrdinals)
	{
		Type type = null;
		T val = Conversions.ToGenericParameter<T>(RuntimeHelpers.GetObjectValue(Activator.CreateInstance(MyType)));
		checked
		{
			int num = objProperties.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo = (PropertyInfo)objProperties[num2];
				if (propertyInfo.CanWrite)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo));
					if (arrOrdinals[num2] != -1)
					{
						if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
						{
							propertyInfo.SetValue(val, RuntimeHelpers.GetObjectValue(objectValue), null);
						}
						else
						{
							try
							{
								propertyInfo.SetValue(val, RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), null);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								try
								{
									type = propertyInfo.PropertyType;
									if (type.BaseType.Equals(typeof(Enum)))
									{
										if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
										{
											((PropertyInfo)objProperties[num2]).SetValue(val, RuntimeHelpers.GetObjectValue(Enum.ToObject(type, Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))), null);
										}
										else
										{
											((PropertyInfo)objProperties[num2]).SetValue(val, RuntimeHelpers.GetObjectValue(Enum.ToObject(type, RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])))), null);
										}
									}
									else
									{
										propertyInfo.SetValue(val, RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									propertyInfo.SetValue(val, RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				num2++;
			}
			return val;
		}
	}

	public static object FillObject(IDataReader dr)
	{
		return FillObject(dr, ManageDataReader: true);
	}

	public static object FillObject(IDataReader dr, bool ManageDataReader)
	{
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		bool flag;
		if (ManageDataReader)
		{
			flag = false;
			if (dr.Read())
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		object result = ((!flag) ? null : RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals)));
		if (ManageDataReader)
		{
			dr?.Close();
		}
		return result;
	}

	public static ArrayList FillCollection(IDataReader dr)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			arrayList.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return arrayList;
	}

	public static IList FillCollection(IDataReader dr, ref IList objToFill)
	{
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			objToFill.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return objToFill;
	}

	public static object InitializeObject(object objObject)
	{
		ArrayList propertyInfo = GetPropertyInfo();
		checked
		{
			int num = propertyInfo.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo2 = (PropertyInfo)propertyInfo[num2];
				if (propertyInfo2.CanWrite)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo2));
					propertyInfo2.SetValue(RuntimeHelpers.GetObjectValue(objObject), RuntimeHelpers.GetObjectValue(objectValue), null);
				}
				num2++;
			}
			return objObject;
		}
	}

	public static XmlDocument Serialize(object objObject)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		XmlSerializer val = new XmlSerializer(objObject.GetType());
		StringBuilder sb = new StringBuilder();
		TextWriter textWriter = new StringWriter(sb);
		val.Serialize(textWriter, RuntimeHelpers.GetObjectValue(objObject));
		StringReader reader = new StringReader(textWriter.ToString());
		DataSet dataSet = new DataSet();
		dataSet.ReadXml((TextReader?)reader);
		XmlDocument val2 = new XmlDocument();
		val2.LoadXml(dataSet.GetXml());
		return val2;
	}

	private static object CreateObject(DataTableReader dr, ArrayList objProperties, int[] arrOrdinals)
	{
		Type type = null;
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(MyType));
		checked
		{
			int num = objProperties.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				PropertyInfo propertyInfo = (PropertyInfo)objProperties[num2];
				if (propertyInfo.CanWrite)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(Null.SetNull(propertyInfo));
					if (arrOrdinals[num2] != -1)
					{
						if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
						{
							propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), null);
						}
						else
						{
							try
							{
								propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), null);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								try
								{
									type = propertyInfo.PropertyType;
									if (type.BaseType.Equals(typeof(Enum)))
									{
										if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2]))))), null);
										}
										else
										{
											((PropertyInfo)objProperties[num2]).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Enum.ToObject(type, RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])))), null);
										}
									}
									else
									{
										propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									}
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(dr.GetValue(arrOrdinals[num2])), type)), null);
									ProjectData.ClearProjectError();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				num2++;
			}
			return objectValue;
		}
	}

	public static ArrayList FillCollection(DataTableReader dr)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			arrayList.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return arrayList;
	}

	public static IList FillCollection(DataTableReader dr, ref IList objToFill)
	{
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			objToFill.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return objToFill;
	}

	public static List<T> FillList(IDataReader dr)
	{
		List<T> list = new List<T>();
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			list.Add(Conversions.ToGenericParameter<T>(RuntimeHelpers.GetObjectValue(objectValue)));
		}
		dr?.Close();
		return list;
	}

	public static Hashtable FillHashTable(IDataReader dr, string propertyKeyName)
	{
		Hashtable hashtable = new Hashtable();
		object obj = null;
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		PropertyInfo property = MyType.GetProperty(propertyKeyName);
		bool flag = (object)property != null;
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			if (flag)
			{
				obj = RuntimeHelpers.GetObjectValue(property.GetValue(RuntimeHelpers.GetObjectValue(objectValue), null));
			}
			hashtable.Add(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return hashtable;
	}

	public static Hashtable FillHashTable(DataTableReader dr, string propertyKeyName)
	{
		Hashtable hashtable = new Hashtable();
		object obj = null;
		ArrayList propertyInfo = GetPropertyInfo();
		int[] ordinals = GetOrdinals(propertyInfo, dr);
		PropertyInfo property = MyType.GetProperty(propertyKeyName);
		bool flag = (object)property != null;
		while (dr.Read())
		{
			object objectValue = RuntimeHelpers.GetObjectValue(CreateObject(dr, propertyInfo, ordinals));
			if (flag)
			{
				obj = RuntimeHelpers.GetObjectValue(property.GetValue(RuntimeHelpers.GetObjectValue(objectValue), null));
			}
			hashtable.Add(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
		}
		dr?.Close();
		return hashtable;
	}

	private static int[] GetValue(ArrayList objProperties, IDataReader dr)
	{
		checked
		{
			int[] array = new int[objProperties.Count + 1];
			if (dr != null)
			{
				int num = objProperties.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					array[num2] = -1;
					try
					{
						array[num2] = dr.GetOrdinal(((PropertyInfo)objProperties[num2]).Name);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					num2++;
				}
			}
			return array;
		}
	}
}
