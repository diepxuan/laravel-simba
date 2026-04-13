using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using AsiaErp.Framework;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

public class DynCrystalReport : ReportClass
{
	public override string ResourceName
	{
		get
		{
			return "DynCrystalReport.rpt";
		}
		set
		{
		}
	}

	public override bool NewGenerator
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public override string FullResourceName
	{
		get
		{
			return "AsiaErp.UserInterface.DynCrystalReport.rpt";
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section ReportHeaderA => ((ReportDocument)this).ReportDefinition.Sections[0];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section ReportHeaderb => ((ReportDocument)this).ReportDefinition.Sections[1];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section PageHeader => ((ReportDocument)this).ReportDefinition.Sections[2];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Details => ((ReportDocument)this).ReportDefinition.Sections[3];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section ReportFooterA => ((ReportDocument)this).ReportDefinition.Sections[4];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section ReportFooterB => ((ReportDocument)this).ReportDefinition.Sections[5];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Page => ((ReportDocument)this).ReportDefinition.Sections[6];

	public DataTable Process(AsDataGridView dgv)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		DataTable dataTable = ((DataTable)((DataGridView)dgv).DataSource).Copy();
		int num = 0;
		foreach (DataGridViewColumn item in (BaseCollection)((DataGridView)dgv).Columns)
		{
			DataGridViewColumn val = item;
			if (val.Visible)
			{
				TextObject val2 = (TextObject)((ReportDocument)this).ReportDefinition.ReportObjects["lblCol" + Conversions.ToString(num)];
				FieldObject val3 = (FieldObject)((ReportDocument)this).ReportDefinition.ReportObjects["txtCol" + Conversions.ToString(num)];
				dataTable.Columns[val.DataPropertyName].ColumnName = ((ReportObject)val3).Name;
				val2.Text = val.HeaderText;
				((ReportObject)val2).Width = val.Width;
				((ReportObject)val3).Width = val.Width;
				num = checked(num + 1);
			}
		}
		return dataTable;
	}
}
