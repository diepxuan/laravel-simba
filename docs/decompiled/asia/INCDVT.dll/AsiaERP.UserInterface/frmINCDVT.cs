using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmINCDVT : frmOBView
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btn_SDTK")]
	private Button _btn_SDTK;

	private bool check;

	private string strMa_vt;

	private string strMa_kho;

	private string strMa_vitri;

	private string strMa_Tkvt;

	public string STR_TKVT;

	internal virtual Button btn_SDTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_SDTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btn_SDTK_Click;
			if (_btn_SDTK != null)
			{
				((Control)_btn_SDTK).Click -= eventHandler;
			}
			_btn_SDTK = value;
			if (_btn_SDTK != null)
			{
				((Control)_btn_SDTK).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public frmINCDVT(string MenuID)
		: base(MenuID)
	{
		((Form)this).Shown += frmINCDVT_Shown;
		__ENCAddToList(this);
		check = false;
		strMa_vt = "";
		strMa_kho = "";
		strMa_vitri = "";
		strMa_Tkvt = "";
		STR_TKVT = "";
		InitializeComponent();
		AsDataGridView asDataGridView = dgvDM;
		Size size = checked(new Size(((Control)cmdClose).Right - 10, ((Control)cmdClose).Top - 15));
		((Control)asDataGridView).Size = size;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		btn_SDTK = new Button();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = cmdChgCode;
		Point location = new Point(375, 434);
		((Control)obj).Location = location;
		TextBox obj2 = txtValue;
		location = new Point(140, 435);
		((Control)obj2).Location = location;
		((Control)txtValue).Visible = false;
		Button obj3 = cmdDel;
		location = new Point(610, 396);
		((Control)obj3).Location = location;
		ComboBox obj4 = cboFilter;
		location = new Point(57, 435);
		((Control)obj4).Location = location;
		((Control)cboFilter).Visible = false;
		Button obj5 = cmdEdit;
		location = new Point(540, 396);
		((Control)obj5).Location = location;
		Button obj6 = cmdSearch;
		location = new Point(234, 434);
		((Control)obj6).Location = location;
		((Control)cmdSearch).Visible = false;
		Button obj7 = cmdAdd;
		location = new Point(470, 396);
		((Control)obj7).Location = location;
		Label obj8 = lblTen;
		location = new Point(6, 437);
		((Control)obj8).Location = location;
		((Control)lblTen).Visible = false;
		Button obj9 = cmdPrint;
		location = new Point(611, 500);
		((Control)obj9).Location = location;
		((Control)cmdPrint).Visible = false;
		Button obj10 = cmdClose;
		location = new Point(680, 396);
		((Control)obj10).Location = location;
		((Control)btn_SDTK).Anchor = (AnchorStyles)10;
		Button obj11 = btn_SDTK;
		location = new Point(380, 396);
		((Control)obj11).Location = location;
		((Control)btn_SDTK).Name = "btn_SDTK";
		Button obj12 = btn_SDTK;
		Size size = new Size(84, 23);
		((Control)obj12).Size = size;
		((Control)btn_SDTK).TabIndex = 40;
		((ButtonBase)btn_SDTK).Text = "Chuyển SDTK";
		((ButtonBase)btn_SDTK).UseVisualStyleBackColor = true;
		((Control)this).Controls.Add((Control)(object)btn_SDTK);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(754, 429);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmINCDVT";
		((Control)this).Controls.SetChildIndex((Control)(object)btn_SDTK, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdClose, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdPrint, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)lblTen, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdAdd, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdSearch, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdEdit, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cboFilter, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdDel, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)txtValue, 0);
		((Control)this).Controls.SetChildIndex((Control)(object)cmdChgCode, 0);
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool Login()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		frmINCDVTFilter frmINCDVTFilter2 = new frmINCDVTFilter();
		frmINCDVTFilter2.txtYear.Value = SystemInformations.FinancialYear;
		((Form)frmINCDVTFilter2).Text = MyMenuInfo.bar.Trim();
		((Form)frmINCDVTFilter2).ShowDialog((IWin32Window)(object)this);
		DialogResult dialogResult = ((Form)frmINCDVTFilter2).DialogResult;
		if ((int)dialogResult == 1)
		{
			strMa_vt = ((TextBox)frmINCDVTFilter2.txtMa_vt).Text.Trim();
			strMa_kho = ((TextBox)frmINCDVTFilter2.txtMa_kho).Text.Trim();
			strMa_vitri = "";
			strMa_Tkvt = ((TextBox)frmINCDVTFilter2.txtMa_tkvt).Text.Trim();
			check = true;
			return check;
		}
		check = false;
		return true;
	}

	protected override void GetData(params object[] @params)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(CompanyInformations.CompanyID);
		arrayList.Add(SystemInformations.FinancialYear);
		arrayList.Add(strMa_vt);
		arrayList.Add(strMa_kho);
		arrayList.Add(strMa_vitri);
		arrayList.Add(strMa_Tkvt);
		base.SourceTable = MyController.GetData(arrayList.ToArray());
	}

	protected override void Edit()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (bsDanhMuc.Current != null)
		{
			string pCodeValue = Conversions.ToString(((DataRowView)bsDanhMuc.Current).Row["ma_vt"]);
			DataRow pDrw = default(DataRow);
			if (Commons.ValidMa(ref pDrw, "MA_VT", pCodeValue, "", "gia_ton") && Operators.ConditionalCompareObjectEqual(pDrw["gia_ton"], (object)"2", false))
			{
				CMessageBox.Show(50211);
			}
			else
			{
				base.Edit();
			}
		}
	}

	protected override void Delete()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (bsDanhMuc.Current != null)
		{
			string pCodeValue = Conversions.ToString(((DataRowView)bsDanhMuc.Current).Row["ma_vt"]);
			DataRow pDrw = default(DataRow);
			if (Commons.ValidMa(ref pDrw, "MA_VT", pCodeValue, "", "gia_ton") && Operators.ConditionalCompareObjectEqual(pDrw["gia_ton"], (object)"2", false))
			{
				CMessageBox.Show(50211);
			}
			else
			{
				base.Delete();
			}
		}
	}

	private void btn_SDTK_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			INCDVTDAO iNCDVTDAO = (INCDVTDAO)DAOFactory.CreateDAOInstance("INCDVTDAO", "INCDVT");
			num = iNCDVTDAO.ImportCdvtToCdTk(CompanyInformations.CompanyID, SystemInformations.FinancialYear);
			CMessageBox.Show(50015);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void frmINCDVT_Shown(object sender, EventArgs e)
	{
		if (!check)
		{
			((Form)this).Close();
		}
	}
}
