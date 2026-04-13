using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmLoc : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtMa_NHVT")]
	private AsTextBox _txtMa_NHVT;

	[AccessedThroughProperty("txtMa_KH")]
	private AsTextBox _txtMa_KH;

	[AccessedThroughProperty("txtMA_NHKH")]
	private AsTextBox _txtMA_NHKH;

	[AccessedThroughProperty("txtMA_VT")]
	private AsTextBox _txtMA_VT;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("btnNhan")]
	private Button _btnNhan;

	[AccessedThroughProperty("btnHuy")]
	private Button _btnHuy;

	[AccessedThroughProperty("lblTenMaKH")]
	private Label _lblTenMaKH;

	[AccessedThroughProperty("lblTenNhomKH")]
	private Label _lblTenNhomKH;

	[AccessedThroughProperty("lblTenMaVT")]
	private Label _lblTenMaVT;

	[AccessedThroughProperty("lblTenNVT")]
	private Label _lblTenNVT;

	internal DataTable f_oTblDM;

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual AsTextBox txtMa_NHVT
	{
		get
		{
			return _txtMa_NHVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_NHVT = value;
		}
	}

	internal virtual AsTextBox txtMa_KH
	{
		get
		{
			return _txtMa_KH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_KH = value;
		}
	}

	internal virtual AsTextBox txtMA_NHKH
	{
		get
		{
			return _txtMA_NHKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMA_NHKH = value;
		}
	}

	internal virtual AsTextBox txtMA_VT
	{
		get
		{
			return _txtMA_VT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMA_VT = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button btnNhan
	{
		get
		{
			return _btnNhan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnNhan_Click;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click -= eventHandler;
			}
			_btnNhan = value;
			if (_btnNhan != null)
			{
				((Control)_btnNhan).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnHuy
	{
		get
		{
			return _btnHuy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnHuy_Click;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click -= eventHandler;
			}
			_btnHuy = value;
			if (_btnHuy != null)
			{
				((Control)_btnHuy).Click += eventHandler;
			}
		}
	}

	internal virtual Label lblTenMaKH
	{
		get
		{
			return _lblTenMaKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTenMaKH = value;
		}
	}

	internal virtual Label lblTenNhomKH
	{
		get
		{
			return _lblTenNhomKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTenNhomKH = value;
		}
	}

	internal virtual Label lblTenMaVT
	{
		get
		{
			return _lblTenMaVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTenMaVT = value;
		}
	}

	internal virtual Label lblTenNVT
	{
		get
		{
			return _lblTenNVT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTenNVT = value;
		}
	}

	public frmLoc()
	{
		f_oTblDM = new DataTable();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		txtMa_NHVT = new AsTextBox();
		lblTenNVT = new Label();
		txtMa_KH = new AsTextBox();
		lblTenMaKH = new Label();
		txtMA_NHKH = new AsTextBox();
		lblTenNhomKH = new Label();
		txtMA_VT = new AsTextBox();
		lblTenMaVT = new Label();
		GroupBox1 = new GroupBox();
		btnNhan = new Button();
		btnHuy = new Button();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		Label label = Label1;
		Point location = new Point(14, 41);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(70, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Mã Nhóm VT";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(14, 93);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(71, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1;
		Label2.Text = "Mã Nhóm KH";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(14, 15);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 2;
		Label3.Text = "Mã VT";
		Label4.AutoSize = true;
		Label label7 = Label4;
		location = new Point(14, 67);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(40, 13);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 3;
		Label4.Text = "Mã KH";
		txtMa_NHVT.AutoLookup = true;
		txtMa_NHVT.AutoValid = true;
		((TextBoxBase)txtMa_NHVT).BackColor = SystemColors.Info;
		((TextBox)txtMa_NHVT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_NHVT;
		location = new Point(92, 37);
		((Control)asTextBox).Location = location;
		txtMa_NHVT.LookupCodeName = "MA_NHVT";
		((Control)txtMa_NHVT).Name = "txtMa_NHVT";
		txtMa_NHVT.NameControl = lblTenNVT;
		AsTextBox asTextBox2 = txtMa_NHVT;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_NHVT).TabIndex = 1;
		Label obj = lblTenNVT;
		location = new Point(203, 41);
		((Control)obj).Location = location;
		((Control)lblTenNVT).Name = "lblTenNVT";
		Label obj2 = lblTenNVT;
		size = new Size(182, 13);
		((Control)obj2).Size = size;
		((Control)lblTenNVT).TabIndex = 14;
		txtMa_KH.AutoLookup = true;
		txtMa_KH.AutoValid = true;
		((TextBoxBase)txtMa_KH).BackColor = SystemColors.Info;
		((TextBox)txtMa_KH).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox3 = txtMa_KH;
		location = new Point(92, 63);
		((Control)asTextBox3).Location = location;
		txtMa_KH.LookupCodeName = "MA_KH";
		((Control)txtMa_KH).Name = "txtMa_KH";
		txtMa_KH.NameControl = lblTenMaKH;
		AsTextBox asTextBox4 = txtMa_KH;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMa_KH).TabIndex = 2;
		Label obj3 = lblTenMaKH;
		location = new Point(203, 67);
		((Control)obj3).Location = location;
		((Control)lblTenMaKH).Name = "lblTenMaKH";
		Label obj4 = lblTenMaKH;
		size = new Size(182, 13);
		((Control)obj4).Size = size;
		((Control)lblTenMaKH).TabIndex = 11;
		txtMA_NHKH.AutoLookup = true;
		txtMA_NHKH.AutoValid = true;
		((TextBoxBase)txtMA_NHKH).BackColor = SystemColors.Info;
		((TextBox)txtMA_NHKH).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox5 = txtMA_NHKH;
		location = new Point(92, 89);
		((Control)asTextBox5).Location = location;
		txtMA_NHKH.LookupCodeName = "MA_NHKH";
		((Control)txtMA_NHKH).Name = "txtMA_NHKH";
		txtMA_NHKH.NameControl = lblTenNhomKH;
		AsTextBox asTextBox6 = txtMA_NHKH;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtMA_NHKH).TabIndex = 3;
		Label obj5 = lblTenNhomKH;
		location = new Point(203, 93);
		((Control)obj5).Location = location;
		((Control)lblTenNhomKH).Name = "lblTenNhomKH";
		Label obj6 = lblTenNhomKH;
		size = new Size(182, 13);
		((Control)obj6).Size = size;
		((Control)lblTenNhomKH).TabIndex = 12;
		txtMA_VT.AutoLookup = true;
		txtMA_VT.AutoValid = true;
		((TextBoxBase)txtMA_VT).BackColor = SystemColors.Info;
		((TextBox)txtMA_VT).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox7 = txtMA_VT;
		location = new Point(92, 11);
		((Control)asTextBox7).Location = location;
		txtMA_VT.LookupCodeName = "MA_VT";
		((Control)txtMA_VT).Name = "txtMA_VT";
		txtMA_VT.NameControl = lblTenMaVT;
		AsTextBox asTextBox8 = txtMA_VT;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtMA_VT).TabIndex = 0;
		Label obj7 = lblTenMaVT;
		location = new Point(203, 15);
		((Control)obj7).Location = location;
		((Control)lblTenMaVT).Name = "lblTenMaVT";
		Label obj8 = lblTenMaVT;
		size = new Size(182, 13);
		((Control)obj8).Size = size;
		((Control)lblTenMaVT).TabIndex = 13;
		((Control)GroupBox1).Anchor = (AnchorStyles)14;
		GroupBox groupBox = GroupBox1;
		location = new Point(-1, 126);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(396, 3);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 8;
		GroupBox1.TabStop = false;
		((Control)btnNhan).Anchor = (AnchorStyles)6;
		Button obj9 = btnNhan;
		location = new Point(14, 135);
		((Control)obj9).Location = location;
		((Control)btnNhan).Name = "btnNhan";
		Button obj10 = btnNhan;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btnNhan).TabIndex = 4;
		((ButtonBase)btnNhan).Text = "&Nhận";
		((ButtonBase)btnNhan).UseVisualStyleBackColor = true;
		((Control)btnHuy).Anchor = (AnchorStyles)6;
		btnHuy.DialogResult = (DialogResult)2;
		Button obj11 = btnHuy;
		location = new Point(96, 135);
		((Control)obj11).Location = location;
		((Control)btnHuy).Name = "btnHuy";
		Button obj12 = btnHuy;
		size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)btnHuy).TabIndex = 5;
		((ButtonBase)btnHuy).Text = "&Hủy";
		((ButtonBase)btnHuy).UseVisualStyleBackColor = true;
		((Form)this).AcceptButton = (IButtonControl)(object)btnNhan;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((Form)this).CancelButton = (IButtonControl)(object)btnHuy;
		size = new Size(397, 169);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)lblTenNVT);
		((Control)this).Controls.Add((Control)(object)lblTenMaVT);
		((Control)this).Controls.Add((Control)(object)lblTenNhomKH);
		((Control)this).Controls.Add((Control)(object)lblTenMaKH);
		((Control)this).Controls.Add((Control)(object)btnHuy);
		((Control)this).Controls.Add((Control)(object)btnNhan);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).Controls.Add((Control)(object)txtMA_VT);
		((Control)this).Controls.Add((Control)(object)txtMA_NHKH);
		((Control)this).Controls.Add((Control)(object)txtMa_KH);
		((Control)this).Controls.Add((Control)(object)txtMa_NHVT);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Name = "frmLoc";
		((Form)this).Text = "Lọc";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnNhan_Click(object sender, EventArgs e)
	{
		SODMCKDAO sODMCKDAO = (SODMCKDAO)DAOFactory.CreateDAOInstance("SODMCKDAO", "SODMCK");
		f_oTblDM.Clear();
		f_oTblDM = sODMCKDAO.GetSODMCK(CompanyInformations.CompanyID, ((TextBox)txtMA_VT).Text, ((TextBox)txtMa_NHVT).Text, ((TextBox)txtMa_KH).Text, ((TextBox)txtMA_NHKH).Text);
		sODMCKDAO.Destroy();
		((Form)this).Close();
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
