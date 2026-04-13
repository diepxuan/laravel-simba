using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmCreateCompany : frmCalc
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtNewCompany")]
	private TextBox _txtNewCompany;

	[AccessedThroughProperty("cmbListCompany")]
	private ComboBox _cmbListCompany;

	internal DataTable f_dt;

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox txtNewCompany
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNewCompany;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNewCompany = value;
		}
	}

	internal virtual ComboBox cmbListCompany
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbListCompany;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbListCompany = value;
		}
	}

	[DebuggerNonUserCode]
	public frmCreateCompany()
	{
		__ENCAddToList(this);
		InitializeComponent();
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
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Label2 = new Label();
		Label1 = new Label();
		txtNewCompany = new TextBox();
		cmbListCompany = new ComboBox();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbInput).SuspendLayout();
		((Control)this).SuspendLayout();
		Button obj = cmdCancel;
		Point location = new Point(93, 91);
		((Control)obj).Location = location;
		((Control)gbInput).Controls.Add((Control)(object)Label2);
		((Control)gbInput).Controls.Add((Control)(object)Label1);
		((Control)gbInput).Controls.Add((Control)(object)txtNewCompany);
		((Control)gbInput).Controls.Add((Control)(object)cmbListCompany);
		GroupBox obj2 = gbInput;
		Size size = new Size(394, 76);
		((Control)obj2).Size = size;
		Button obj3 = cmdOK;
		location = new Point(12, 91);
		((Control)obj3).Location = location;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(21, 43);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(58, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 8;
		Label2.Text = "Mã cty mới";
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(21, 16);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(62, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 7;
		Label1.Text = "Mã cty mẫu";
		TextBox obj4 = txtNewCompany;
		location = new Point(96, 40);
		((Control)obj4).Location = location;
		((Control)txtNewCompany).Name = "txtNewCompany";
		TextBox obj5 = txtNewCompany;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtNewCompany).TabIndex = 5;
		cmbListCompany.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)cmbListCompany).FormattingEnabled = true;
		ComboBox obj6 = cmbListCompany;
		location = new Point(96, 13);
		((Control)obj6).Location = location;
		((Control)cmbListCompany).Name = "cmbListCompany";
		ComboBox obj7 = cmbListCompany;
		size = new Size(292, 21);
		((Control)obj7).Size = size;
		((Control)cmbListCompany).TabIndex = 4;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(416, 123);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmCreateCompany";
		((Form)this).Text = "Them moi cong cty";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbInput).ResumeLayout(false);
		((Control)gbInput).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override bool Execute()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ISiToolsDao siToolsDao = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools", a_blnIsSysDB: true);
			int num = siToolsDao.CreateNewCompanySys(Conversions.ToString(((ListControl)cmbListCompany).SelectedValue), txtNewCompany.Text);
			siToolsDao.Destroy();
			if (num == 0)
			{
				ISiToolsDao siToolsDao2 = (ISiToolsDao)DAOFactory.CreateDAOInstance("ISiToolsDao", "SiTools");
				int num2 = siToolsDao2.CreateNewCompanyData(Conversions.ToString(((ListControl)cmbListCompany).SelectedValue), txtNewCompany.Text);
				siToolsDao2.Destroy();
			}
			CMessageBox.Show(50015);
			((Component)(object)this).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2.ToString());
			CMessageBox.Show(99999);
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	protected override bool ValidData()
	{
		if (txtNewCompany.Text.Trim().Length <= 0)
		{
			((Control)txtNewCompany).Select();
			epNotice.SetError((Control)(object)txtNewCompany, "Chưa nhập mã cty mới");
			return false;
		}
		string filterExpression = "ma_cty = '" + txtNewCompany.Text + "'";
		if (f_dt.Select(filterExpression).Any())
		{
			epNotice.SetError((Control)(object)txtNewCompany, "Mã công ty đã có");
			return false;
		}
		return base.ValidData();
	}
}
