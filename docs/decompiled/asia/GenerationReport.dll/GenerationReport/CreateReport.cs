using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using AsiaErp.Framework;

namespace GenerationReport;

public class CreateReport
{
	private DataGridView dGView;

	private DataGridView dGViewTemp;

	private ReportConfig RdlConfig;

	private DataTable tableSource;

	public string Title { get; set; }

	public string CompanyName { get; set; }

	public string ParentCompanyName { get; set; }

	public string FormatDateTime { get; set; }

	public string FormatNumber { get; set; }

	public string SubTitle { get; set; }

	public string FilterTitle { get; set; }

	public string SubFilterTitle { get; set; }

	public string Parent { get; set; }

	public string Ngay1 { get; set; }

	public string Ngay2 { get; set; }

	public DataGridView DGView
	{
		get
		{
			return dGView;
		}
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			dGView = value;
			dGViewTemp = new DataGridView();
			((Control)dGView).Parent.Controls.Add((Control)(object)dGViewTemp);
			((Control)dGViewTemp).Visible = true;
			DataTable dataTable = ((DataTable)dGView.DataSource).Copy();
			dGViewTemp.AutoGenerateColumns = false;
			dGViewTemp.DataSource = dataTable;
			for (int i = 0; i < ((BaseCollection)dGView.Columns).Count; i++)
			{
				dGViewTemp.Columns.Add((DataGridViewColumn)((DataGridViewBand)dGView.Columns[i]).Clone());
			}
			tableSource = new DataTable();
			for (int j = 0; j < ((BaseCollection)dGViewTemp.Columns).Count; j++)
			{
				dGViewTemp.Columns[j].DataPropertyName = dGViewTemp.Columns[j].DataPropertyName.Replace(" ", "_").Replace("/", "_");
				dataTable.Columns[j].ColumnName = dataTable.Columns[j].ColumnName.Replace(" ", "_").Replace("/", "_");
				DataColumn column = new DataColumn(dGViewTemp.Columns[j].DataPropertyName, typeof(string));
				tableSource.Columns.Add(column);
			}
			for (int k = 0; k < dGViewTemp.Rows.Count; k++)
			{
				DataRow dataRow = tableSource.NewRow();
				for (int l = 0; l < ((BaseCollection)dGViewTemp.Columns).Count; l++)
				{
					object value2 = dGViewTemp[l, k].Value;
					if (value2 == null)
					{
						value2 = "";
					}
					else if (IsNumberic(value2.ToString()))
					{
						if ((object)typeof(decimal) == value2.GetType())
						{
							dataRow[l] = FormatMoney(value2.ToString());
						}
						else
						{
							dataRow[l] = value2;
						}
					}
					else if (IsDateTime(value2.ToString()))
					{
						value2 = string.Format(FormatDateTime, value2).Split(new char[1] { ' ' })[0];
						dataRow[l] = value2;
						dGViewTemp.Columns[l].ValueType = typeof(DateTime);
					}
					else
					{
						dataRow[l] = value2;
					}
				}
				TableSource.Rows.Add(dataRow);
			}
		}
	}

	public DataTable TableSource => tableSource;

	public CreateReport()
	{
		FormatDateTime = "{0:dd/MM/yyyy}";
		RdlConfig = new ReportConfig();
		Title = "";
		CompanyName = "";
		ParentCompanyName = "";
		SubTitle = "";
		FilterTitle = "";
		SubFilterTitle = "";
	}

	public MemoryStream Create()
	{
		new List<string>();
		new MemoryStream()?.Dispose();
		return GenerateRdl();
	}

	private MemoryStream GenerateRdl()
	{
		MemoryStream memoryStream = new MemoryStream();
		RdlGenerator rdlGenerator = new RdlGenerator();
		rdlGenerator.DGView = dGViewTemp;
		rdlGenerator.RdlConfig = RdlConfig;
		rdlGenerator.SubTitle = SubTitle;
		rdlGenerator.FilterTitle = FilterTitle;
		rdlGenerator.SubFilterTitle = SubFilterTitle;
		rdlGenerator.Title = Title;
		rdlGenerator.CompanyName = CompanyName;
		rdlGenerator.ParentCompanyName = ParentCompanyName;
		rdlGenerator.WriteXml(memoryStream);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	private bool IsNumberic(string Number)
	{
		try
		{
			decimal.Parse(Number);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private bool IsDateTime(string StrDate)
	{
		try
		{
			DateTime.Parse(StrDate);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private string FormatMoney(string Str)
	{
		decimal num = decimal.Parse(Str);
		if (num == 0m)
		{
			return "";
		}
		return RdlConfig.format switch
		{
			0 => num.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().Amount_Input_Format), 
			1 => num.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().FCPrice_Input_Format), 
			2 => num.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().FCAmount_Input_Format), 
			3 => num.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().Price_Input_Format), 
			4 => num.ToString(AsiaErp.Framework.Environment.GetSIConfiguration().Qty_Input_Format), 
			_ => num.ToString(), 
		};
	}
}
