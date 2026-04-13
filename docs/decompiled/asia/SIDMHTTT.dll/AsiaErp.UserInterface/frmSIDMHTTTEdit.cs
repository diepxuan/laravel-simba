using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIDMHTTTEdit : frmDMComplexEdit
{
	private IContainer components;

	[AccessedThroughProperty("txtTK")]
	private AsTextBox _txtTK;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("txtTen_nx")]
	private TextBox _txtTen_nx;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtMa_nx")]
	private TextBox _txtMa_nx;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTen_tk")]
	private Label _lblTen_tk;

	internal virtual AsTextBox txtTK
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTK = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox txtTen_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTen_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTen_nx = value;
		}
	}

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

	internal virtual TextBox txtMa_nx
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_nx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_nx = value;
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

	internal virtual Label lblTen_tk
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_tk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_tk = value;
		}
	}

	[DebuggerNonUserCode]
	public frmSIDMHTTTEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Label1 = new Label();
		txtMa_nx = new TextBox();
		txtTen_nx = new TextBox();
		Label2 = new Label();
		Label3 = new Label();
		txtTK = new AsTextBox();
		lblTen_tk = new Label();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		AsCheckBox asCheckBox = chkKsd;
		Point location = new Point(84, 100);
		((Control)asCheckBox).Location = location;
		((Control)chkKsd).TabIndex = 3;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		location = new Point(93, 138);
		((Control)obj).Location = location;
		((Control)cmdCancel).TabIndex = 2;
		Button obj2 = cmdSave;
		location = new Point(12, 138);
		((Control)obj2).Location = location;
		((Control)cmdSave).TabIndex = 1;
		((Control)gbLine).Controls.Add((Control)(object)lblTen_tk);
		((Control)gbLine).Controls.Add((Control)(object)txtTK);
		((Control)gbLine).Controls.Add((Control)(object)Label3);
		((Control)gbLine).Controls.Add((Control)(object)txtTen_nx);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtMa_nx);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		GroupBox obj3 = gbLine;
		Size size = new Size(463, 126);
		((Control)obj3).Size = size;
		((Control)gbLine).TabIndex = 0;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_nx, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTen_nx, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label3, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTK, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_tk, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 25);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(72, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Mã nhập xuất";
		txtMa_nx.CharacterCasing = (CharacterCasing)1;
		TextBox obj4 = txtMa_nx;
		location = new Point(84, 22);
		((Control)obj4).Location = location;
		((TextBoxBase)txtMa_nx).MaxLength = 20;
		((Control)txtMa_nx).Name = "txtMa_nx";
		TextBox obj5 = txtMa_nx;
		size = new Size(100, 20);
		((Control)obj5).Size = size;
		((Control)txtMa_nx).TabIndex = 0;
		TextBox obj6 = txtTen_nx;
		location = new Point(84, 48);
		((Control)obj6).Location = location;
		((TextBoxBase)txtTen_nx).MaxLength = 50;
		((Control)txtTen_nx).Name = "txtTen_nx";
		TextBox obj7 = txtTen_nx;
		size = new Size(363, 20);
		((Control)obj7).Size = size;
		((Control)txtTen_nx).TabIndex = 1;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(6, 51);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(76, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 102;
		Label2.Text = "Tên nhập xuất";
		Label3.AutoSize = true;
		Label label5 = Label3;
		location = new Point(6, 77);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(55, 13);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 104;
		Label3.Text = "Tài khoản";
		txtTK.AutoLookup = true;
		txtTK.AutoValid = true;
		((TextBoxBase)txtTK).BackColor = SystemColors.Info;
		((TextBox)txtTK).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtTK;
		location = new Point(84, 74);
		((Control)asTextBox).Location = location;
		txtTK.LookupCodeName = "TK";
		txtTK.LookupWhereCondition = "chi_tiet=1";
		((TextBoxBase)txtTK).MaxLength = 20;
		((Control)txtTK).Name = "txtTK";
		txtTK.NameControl = lblTen_tk;
		AsTextBox asTextBox2 = txtTK;
		size = new Size(100, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtTK).TabIndex = 2;
		Label obj8 = lblTen_tk;
		location = new Point(190, 77);
		((Control)obj8).Location = location;
		((Control)lblTen_tk).Name = "lblTen_tk";
		Label obj9 = lblTen_tk;
		size = new Size(257, 13);
		((Control)obj9).Size = size;
		((Control)lblTen_tk).TabIndex = 106;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(487, 173);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmSIDMHTTTEdit";
		((Form)this).Text = "frmSIDMHTTTEdit";
		((ISupportInitialize)epNotice).EndInit();
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void InitBeforeGetData()
	{
		base.InitBeforeGetData();
		((TextBoxBase)txtMa_nx).MaxLength = base.MyDictComplexInfo.code_length;
		((Control)txtMa_nx).Select();
	}

	protected override void DisableFields()
	{
		base.DisableFields();
		((Control)txtMa_nx).Enabled = false;
		((Control)txtTen_nx).Select();
	}

	protected override void DataBinding()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		base.DataBinding();
		Control ojb = (Control)(object)txtMa_nx;
		CreateDataBinding(ref ojb, "Ma_HTTT");
		txtMa_nx = (TextBox)ojb;
		ojb = (Control)(object)txtTen_nx;
		CreateDataBinding(ref ojb, "Ten_HTTT");
		txtTen_nx = (TextBox)ojb;
		ojb = (Control)(object)txtTK;
		CreateDataBinding(ref ojb, "TK");
		txtTK = (AsTextBox)(object)ojb;
		ojb = (Control)(object)chkKsd;
		CreateDataBinding(ref ojb, "Ksd", "Checked");
		chkKsd = (AsCheckBox)(object)ojb;
	}

	protected override bool ValidData()
	{
		if (!ChkEmtyTextBox(txtMa_nx) || !ChkEmtyTextBox(txtTen_nx) || !ChkEmtyTextBox((TextBox)(object)txtTK) || !base.ValidData())
		{
			return false;
		}
		return true;
	}

	protected override bool SetToRow()
	{
		RowToEdit["moduleid"] = MyMenuInfo.par1;
		return base.SetToRow();
	}

	protected override bool InsertToDB()
	{
		bool flag = base.InsertToDB();
		if (!flag)
		{
			((Control)txtMa_nx).Select();
		}
		return flag;
	}
}
