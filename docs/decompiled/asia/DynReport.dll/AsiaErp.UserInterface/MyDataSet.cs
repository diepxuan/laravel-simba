using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[Serializable]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlRoot("MyDataSet")]
public class MyDataSet : DataSet
{
	public delegate void MyDataTableRowChangeEventHandler(object sender, MyDataTableRowChangeEvent e);

	[Serializable]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class MyDataTableDataTable : TypedTableBase<MyDataTableRow>
	{
		private DataColumn columnDataColumn1;

		private DataColumn columnDataColumn2;

		private DataColumn columnDataColumn3;

		private DataColumn columnDataColumn4;

		private DataColumn columnDataColumn5;

		private DataColumn columnDataColumn6;

		private DataColumn columnDataColumn7;

		private DataColumn columnDataColumn8;

		private DataColumn columnDataColumn9;

		private DataColumn columnDataColumn10;

		private DataColumn columnDataColumn11;

		private DataColumn columnDataColumn12;

		private DataColumn columnDataColumn13;

		private DataColumn columnDataColumn14;

		private DataColumn columnDataColumn15;

		private DataColumn columnDataColumn16;

		private DataColumn columnDataColumn17;

		private DataColumn columnDataColumn18;

		private DataColumn columnDataColumn19;

		private DataColumn columnDataColumn20;

		private DataColumn columnDataColumn21;

		private DataColumn columnDataColumn22;

		private DataColumn columnDataColumn23;

		private DataColumn columnDataColumn24;

		private DataColumn columnDataColumn25;

		private DataColumn columnDataColumn26;

		private DataColumn columnDataColumn27;

		private DataColumn columnDataColumn28;

		private DataColumn columnDataColumn29;

		private DataColumn columnDataColumn30;

		[DebuggerNonUserCode]
		public DataColumn DataColumn1Column => columnDataColumn1;

		[DebuggerNonUserCode]
		public DataColumn DataColumn2Column => columnDataColumn2;

		[DebuggerNonUserCode]
		public DataColumn DataColumn3Column => columnDataColumn3;

		[DebuggerNonUserCode]
		public DataColumn DataColumn4Column => columnDataColumn4;

		[DebuggerNonUserCode]
		public DataColumn DataColumn5Column => columnDataColumn5;

		[DebuggerNonUserCode]
		public DataColumn DataColumn6Column => columnDataColumn6;

		[DebuggerNonUserCode]
		public DataColumn DataColumn7Column => columnDataColumn7;

		[DebuggerNonUserCode]
		public DataColumn DataColumn8Column => columnDataColumn8;

		[DebuggerNonUserCode]
		public DataColumn DataColumn9Column => columnDataColumn9;

		[DebuggerNonUserCode]
		public DataColumn DataColumn10Column => columnDataColumn10;

		[DebuggerNonUserCode]
		public DataColumn DataColumn11Column => columnDataColumn11;

		[DebuggerNonUserCode]
		public DataColumn DataColumn12Column => columnDataColumn12;

		[DebuggerNonUserCode]
		public DataColumn DataColumn13Column => columnDataColumn13;

		[DebuggerNonUserCode]
		public DataColumn DataColumn14Column => columnDataColumn14;

		[DebuggerNonUserCode]
		public DataColumn DataColumn15Column => columnDataColumn15;

		[DebuggerNonUserCode]
		public DataColumn DataColumn16Column => columnDataColumn16;

		[DebuggerNonUserCode]
		public DataColumn DataColumn17Column => columnDataColumn17;

		[DebuggerNonUserCode]
		public DataColumn DataColumn18Column => columnDataColumn18;

		[DebuggerNonUserCode]
		public DataColumn DataColumn19Column => columnDataColumn19;

		[DebuggerNonUserCode]
		public DataColumn DataColumn20Column => columnDataColumn20;

		[DebuggerNonUserCode]
		public DataColumn DataColumn21Column => columnDataColumn21;

		[DebuggerNonUserCode]
		public DataColumn DataColumn22Column => columnDataColumn22;

		[DebuggerNonUserCode]
		public DataColumn DataColumn23Column => columnDataColumn23;

		[DebuggerNonUserCode]
		public DataColumn DataColumn24Column => columnDataColumn24;

		[DebuggerNonUserCode]
		public DataColumn DataColumn25Column => columnDataColumn25;

		[DebuggerNonUserCode]
		public DataColumn DataColumn26Column => columnDataColumn26;

		[DebuggerNonUserCode]
		public DataColumn DataColumn27Column => columnDataColumn27;

		[DebuggerNonUserCode]
		public DataColumn DataColumn28Column => columnDataColumn28;

		[DebuggerNonUserCode]
		public DataColumn DataColumn29Column => columnDataColumn29;

		[DebuggerNonUserCode]
		public DataColumn DataColumn30Column => columnDataColumn30;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		public MyDataTableRow this[int index] => (MyDataTableRow)Rows[index];

		[method: DebuggerNonUserCode]
		public event MyDataTableRowChangeEventHandler MyDataTableRowChanging;

		[method: DebuggerNonUserCode]
		public event MyDataTableRowChangeEventHandler MyDataTableRowChanged;

		[method: DebuggerNonUserCode]
		public event MyDataTableRowChangeEventHandler MyDataTableRowDeleting;

		[method: DebuggerNonUserCode]
		public event MyDataTableRowChangeEventHandler MyDataTableRowDeleted;

		[DebuggerNonUserCode]
		public MyDataTableDataTable()
		{
			TableName = "MyDataTable";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		internal MyDataTableDataTable(DataTable table)
		{
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		protected MyDataTableDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		public void AddMyDataTableRow(MyDataTableRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		public MyDataTableRow AddMyDataTableRow(string DataColumn1, string DataColumn2, string DataColumn3, string DataColumn4, string DataColumn5, string DataColumn6, string DataColumn7, string DataColumn8, string DataColumn9, string DataColumn10, string DataColumn11, string DataColumn12, string DataColumn13, string DataColumn14, string DataColumn15, string DataColumn16, string DataColumn17, string DataColumn18, string DataColumn19, string DataColumn20, string DataColumn21, string DataColumn22, string DataColumn23, string DataColumn24, string DataColumn25, string DataColumn26, string DataColumn27, string DataColumn28, string DataColumn29, string DataColumn30)
		{
			MyDataTableRow myDataTableRow = (MyDataTableRow)NewRow();
			object[] itemArray = new object[30]
			{
				DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8, DataColumn9, DataColumn10,
				DataColumn11, DataColumn12, DataColumn13, DataColumn14, DataColumn15, DataColumn16, DataColumn17, DataColumn18, DataColumn19, DataColumn20,
				DataColumn21, DataColumn22, DataColumn23, DataColumn24, DataColumn25, DataColumn26, DataColumn27, DataColumn28, DataColumn29, DataColumn30
			};
			myDataTableRow.ItemArray = itemArray;
			Rows.Add(myDataTableRow);
			return myDataTableRow;
		}

		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			MyDataTableDataTable myDataTableDataTable = (MyDataTableDataTable)base.Clone();
			myDataTableDataTable.InitVars();
			return myDataTableDataTable;
		}

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new MyDataTableDataTable();
		}

		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnDataColumn1 = base.Columns["DataColumn1"];
			columnDataColumn2 = base.Columns["DataColumn2"];
			columnDataColumn3 = base.Columns["DataColumn3"];
			columnDataColumn4 = base.Columns["DataColumn4"];
			columnDataColumn5 = base.Columns["DataColumn5"];
			columnDataColumn6 = base.Columns["DataColumn6"];
			columnDataColumn7 = base.Columns["DataColumn7"];
			columnDataColumn8 = base.Columns["DataColumn8"];
			columnDataColumn9 = base.Columns["DataColumn9"];
			columnDataColumn10 = base.Columns["DataColumn10"];
			columnDataColumn11 = base.Columns["DataColumn11"];
			columnDataColumn12 = base.Columns["DataColumn12"];
			columnDataColumn13 = base.Columns["DataColumn13"];
			columnDataColumn14 = base.Columns["DataColumn14"];
			columnDataColumn15 = base.Columns["DataColumn15"];
			columnDataColumn16 = base.Columns["DataColumn16"];
			columnDataColumn17 = base.Columns["DataColumn17"];
			columnDataColumn18 = base.Columns["DataColumn18"];
			columnDataColumn19 = base.Columns["DataColumn19"];
			columnDataColumn20 = base.Columns["DataColumn20"];
			columnDataColumn21 = base.Columns["DataColumn21"];
			columnDataColumn22 = base.Columns["DataColumn22"];
			columnDataColumn23 = base.Columns["DataColumn23"];
			columnDataColumn24 = base.Columns["DataColumn24"];
			columnDataColumn25 = base.Columns["DataColumn25"];
			columnDataColumn26 = base.Columns["DataColumn26"];
			columnDataColumn27 = base.Columns["DataColumn27"];
			columnDataColumn28 = base.Columns["DataColumn28"];
			columnDataColumn29 = base.Columns["DataColumn29"];
			columnDataColumn30 = base.Columns["DataColumn30"];
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnDataColumn1 = new DataColumn("DataColumn1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn1);
			columnDataColumn2 = new DataColumn("DataColumn2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn2);
			columnDataColumn3 = new DataColumn("DataColumn3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn3);
			columnDataColumn4 = new DataColumn("DataColumn4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn4);
			columnDataColumn5 = new DataColumn("DataColumn5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn5);
			columnDataColumn6 = new DataColumn("DataColumn6", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn6);
			columnDataColumn7 = new DataColumn("DataColumn7", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn7);
			columnDataColumn8 = new DataColumn("DataColumn8", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn8);
			columnDataColumn9 = new DataColumn("DataColumn9", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn9);
			columnDataColumn10 = new DataColumn("DataColumn10", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn10);
			columnDataColumn11 = new DataColumn("DataColumn11", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn11);
			columnDataColumn12 = new DataColumn("DataColumn12", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn12);
			columnDataColumn13 = new DataColumn("DataColumn13", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn13);
			columnDataColumn14 = new DataColumn("DataColumn14", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn14);
			columnDataColumn15 = new DataColumn("DataColumn15", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn15);
			columnDataColumn16 = new DataColumn("DataColumn16", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn16);
			columnDataColumn17 = new DataColumn("DataColumn17", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn17);
			columnDataColumn18 = new DataColumn("DataColumn18", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn18);
			columnDataColumn19 = new DataColumn("DataColumn19", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn19);
			columnDataColumn20 = new DataColumn("DataColumn20", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn20);
			columnDataColumn21 = new DataColumn("DataColumn21", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn21);
			columnDataColumn22 = new DataColumn("DataColumn22", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn22);
			columnDataColumn23 = new DataColumn("DataColumn23", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn23);
			columnDataColumn24 = new DataColumn("DataColumn24", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn24);
			columnDataColumn25 = new DataColumn("DataColumn25", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn25);
			columnDataColumn26 = new DataColumn("DataColumn26", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn26);
			columnDataColumn27 = new DataColumn("DataColumn27", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn27);
			columnDataColumn28 = new DataColumn("DataColumn28", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn28);
			columnDataColumn29 = new DataColumn("DataColumn29", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn29);
			columnDataColumn30 = new DataColumn("DataColumn30", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDataColumn30);
		}

		[DebuggerNonUserCode]
		public MyDataTableRow NewMyDataTableRow()
		{
			return (MyDataTableRow)NewRow();
		}

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new MyDataTableRow(builder);
		}

		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(MyDataTableRow);
		}

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (MyDataTableRowChanged != null)
			{
				MyDataTableRowChanged?.Invoke(this, new MyDataTableRowChangeEvent((MyDataTableRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (MyDataTableRowChanging != null)
			{
				MyDataTableRowChanging?.Invoke(this, new MyDataTableRowChangeEvent((MyDataTableRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (MyDataTableRowDeleted != null)
			{
				MyDataTableRowDeleted?.Invoke(this, new MyDataTableRowChangeEvent((MyDataTableRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (MyDataTableRowDeleting != null)
			{
				MyDataTableRowDeleting?.Invoke(this, new MyDataTableRowChangeEvent((MyDataTableRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		public void RemoveMyDataTableRow(MyDataTableRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			XmlSchemaComplexType val = new XmlSchemaComplexType();
			XmlSchemaSequence val2 = new XmlSchemaSequence();
			MyDataSet myDataSet = new MyDataSet();
			XmlSchemaAny val3 = new XmlSchemaAny();
			val3.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			((XmlSchemaParticle)val3).MinOccurs = minOccurs;
			((XmlSchemaParticle)val3).MaxOccurs = decimal.MaxValue;
			val3.ProcessContents = (XmlSchemaContentProcessing)2;
			val2.Items.Add((XmlSchemaObject)(object)val3);
			XmlSchemaAny val4 = new XmlSchemaAny();
			val4.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			((XmlSchemaParticle)val4).MinOccurs = minOccurs;
			val4.ProcessContents = (XmlSchemaContentProcessing)2;
			val2.Items.Add((XmlSchemaObject)(object)val4);
			XmlSchemaAttribute val5 = new XmlSchemaAttribute();
			val5.Name = "namespace";
			val5.FixedValue = myDataSet.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "MyDataTableDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = myDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema val7 = null;
					schemaSerializable.Write((Stream)memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						val7 = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						val7.Write((Stream)memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return val;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return val;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class MyDataTableRow : DataRow
	{
		private MyDataTableDataTable tableMyDataTable;

		[DebuggerNonUserCode]
		public string DataColumn1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn1' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn2' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn3' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn4
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn4' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn5
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn5' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn6
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn6' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn7
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn7' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn8
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn8' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn9
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn9' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn10
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn10' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn11
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn11' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn12
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn12' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn13
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn13Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn13' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn13Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn14
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn14Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn14' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn14Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn15
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn15Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn15' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn15Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn16
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn16Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn16' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn16Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn17
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn17Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn17' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn17Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn18
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn18Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn18' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn18Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn19
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn19Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn19' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn19Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn20
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn20Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn20' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn20Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn21
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn21Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn21' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn21Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn22
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn22Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn22' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn22Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn23
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn23Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn23' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn23Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn24
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn24Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn24' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn24Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn25
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn25Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn25' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn25Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn26
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn26Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn26' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn26Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn27
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn27Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn27' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn27Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn28
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn28Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn28' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn28Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn29
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn29Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn29' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn29Column] = value;
			}
		}

		[DebuggerNonUserCode]
		public string DataColumn30
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableMyDataTable.DataColumn30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DataColumn30' in table 'MyDataTable' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableMyDataTable.DataColumn30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		internal MyDataTableRow(DataRowBuilder rb)
			: base(rb)
		{
			tableMyDataTable = (MyDataTableDataTable)Table;
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn1Null()
		{
			return IsNull(tableMyDataTable.DataColumn1Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn1Null()
		{
			this[tableMyDataTable.DataColumn1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn2Null()
		{
			return IsNull(tableMyDataTable.DataColumn2Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn2Null()
		{
			this[tableMyDataTable.DataColumn2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn3Null()
		{
			return IsNull(tableMyDataTable.DataColumn3Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn3Null()
		{
			this[tableMyDataTable.DataColumn3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn4Null()
		{
			return IsNull(tableMyDataTable.DataColumn4Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn4Null()
		{
			this[tableMyDataTable.DataColumn4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn5Null()
		{
			return IsNull(tableMyDataTable.DataColumn5Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn5Null()
		{
			this[tableMyDataTable.DataColumn5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn6Null()
		{
			return IsNull(tableMyDataTable.DataColumn6Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn6Null()
		{
			this[tableMyDataTable.DataColumn6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn7Null()
		{
			return IsNull(tableMyDataTable.DataColumn7Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn7Null()
		{
			this[tableMyDataTable.DataColumn7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn8Null()
		{
			return IsNull(tableMyDataTable.DataColumn8Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn8Null()
		{
			this[tableMyDataTable.DataColumn8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn9Null()
		{
			return IsNull(tableMyDataTable.DataColumn9Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn9Null()
		{
			this[tableMyDataTable.DataColumn9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn10Null()
		{
			return IsNull(tableMyDataTable.DataColumn10Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn10Null()
		{
			this[tableMyDataTable.DataColumn10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn11Null()
		{
			return IsNull(tableMyDataTable.DataColumn11Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn11Null()
		{
			this[tableMyDataTable.DataColumn11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn12Null()
		{
			return IsNull(tableMyDataTable.DataColumn12Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn12Null()
		{
			this[tableMyDataTable.DataColumn12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn13Null()
		{
			return IsNull(tableMyDataTable.DataColumn13Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn13Null()
		{
			this[tableMyDataTable.DataColumn13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn14Null()
		{
			return IsNull(tableMyDataTable.DataColumn14Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn14Null()
		{
			this[tableMyDataTable.DataColumn14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn15Null()
		{
			return IsNull(tableMyDataTable.DataColumn15Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn15Null()
		{
			this[tableMyDataTable.DataColumn15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn16Null()
		{
			return IsNull(tableMyDataTable.DataColumn16Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn16Null()
		{
			this[tableMyDataTable.DataColumn16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn17Null()
		{
			return IsNull(tableMyDataTable.DataColumn17Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn17Null()
		{
			this[tableMyDataTable.DataColumn17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn18Null()
		{
			return IsNull(tableMyDataTable.DataColumn18Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn18Null()
		{
			this[tableMyDataTable.DataColumn18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn19Null()
		{
			return IsNull(tableMyDataTable.DataColumn19Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn19Null()
		{
			this[tableMyDataTable.DataColumn19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn20Null()
		{
			return IsNull(tableMyDataTable.DataColumn20Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn20Null()
		{
			this[tableMyDataTable.DataColumn20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn21Null()
		{
			return IsNull(tableMyDataTable.DataColumn21Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn21Null()
		{
			this[tableMyDataTable.DataColumn21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn22Null()
		{
			return IsNull(tableMyDataTable.DataColumn22Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn22Null()
		{
			this[tableMyDataTable.DataColumn22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn23Null()
		{
			return IsNull(tableMyDataTable.DataColumn23Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn23Null()
		{
			this[tableMyDataTable.DataColumn23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn24Null()
		{
			return IsNull(tableMyDataTable.DataColumn24Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn24Null()
		{
			this[tableMyDataTable.DataColumn24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn25Null()
		{
			return IsNull(tableMyDataTable.DataColumn25Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn25Null()
		{
			this[tableMyDataTable.DataColumn25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn26Null()
		{
			return IsNull(tableMyDataTable.DataColumn26Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn26Null()
		{
			this[tableMyDataTable.DataColumn26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn27Null()
		{
			return IsNull(tableMyDataTable.DataColumn27Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn27Null()
		{
			this[tableMyDataTable.DataColumn27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn28Null()
		{
			return IsNull(tableMyDataTable.DataColumn28Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn28Null()
		{
			this[tableMyDataTable.DataColumn28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn29Null()
		{
			return IsNull(tableMyDataTable.DataColumn29Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn29Null()
		{
			this[tableMyDataTable.DataColumn29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		public bool IsDataColumn30Null()
		{
			return IsNull(tableMyDataTable.DataColumn30Column);
		}

		[DebuggerNonUserCode]
		public void SetDataColumn30Null()
		{
			this[tableMyDataTable.DataColumn30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class MyDataTableRowChangeEvent : EventArgs
	{
		private MyDataTableRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		public MyDataTableRow Row => eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		public MyDataTableRowChangeEvent(MyDataTableRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private MyDataTableDataTable tableMyDataTable;

	private SchemaSerializationMode _schemaSerializationMode;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public MyDataTableDataTable MyDataTable => tableMyDataTable;

	[Browsable(true)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	public MyDataSet()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	protected MyDataSet(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema((XmlReader?)new XmlTextReader((TextReader)new StringReader(s)));
			if (dataSet.Tables["MyDataTable"] != null)
			{
				base.Tables.Add(new MyDataTableDataTable(dataSet.Tables["MyDataTable"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema((XmlReader?)new XmlTextReader((TextReader)new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		MyDataSet myDataSet = (MyDataSet)base.Clone();
		myDataSet.InitVars();
		myDataSet.SchemaSerializationMode = SchemaSerializationMode;
		return myDataSet;
	}

	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["MyDataTable"] != null)
			{
				base.Tables.Add(new MyDataTableDataTable(dataSet.Tables["MyDataTable"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema((XmlWriter?)new XmlTextWriter((Stream)memoryStream, (Encoding)null));
		memoryStream.Position = 0L;
		return XmlSchema.Read((XmlReader)new XmlTextReader((Stream)memoryStream), (ValidationEventHandler)null);
	}

	[DebuggerNonUserCode]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableMyDataTable = (MyDataTableDataTable)base.Tables["MyDataTable"];
		if (initTable && tableMyDataTable != null)
		{
			tableMyDataTable.InitVars();
		}
	}

	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "MyDataSet";
		Prefix = "";
		Namespace = "http://tempuri.org/MyDataSet.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableMyDataTable = new MyDataTableDataTable();
		base.Tables.Add(tableMyDataTable);
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeMyDataTable()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		MyDataSet myDataSet = new MyDataSet();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = myDataSet.Namespace;
		val2.Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = myDataSet.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema val4 = null;
				schemaSerializable.Write((Stream)memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					val4 = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					val4.Write((Stream)memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return val;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return val;
	}
}
