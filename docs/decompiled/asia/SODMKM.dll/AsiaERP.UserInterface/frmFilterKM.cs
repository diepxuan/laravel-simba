using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmFilterKM : frmDMFilter
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtTenmau")]
	private TextBox _txtTenmau;

	[AccessedThroughProperty("txtMa_km")]
	private AsTextBox _txtMa_km;

	[AccessedThroughProperty("lblTen_km")]
	private Label _lblTen_km;

	[AccessedThroughProperty("txtNgay1")]
	private AsMaskedTextBox _txtNgay1;

	[AccessedThroughProperty("lblTo")]
	private Label _lblTo;

	[AccessedThroughProperty("lblFrom")]
	private Label _lblFrom;

	[AccessedThroughProperty("txtNgay2")]
	private AsMaskedTextBox _txtNgay2;

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

	internal virtual TextBox txtTenmau
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTenmau;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTenmau = value;
		}
	}

	internal virtual AsTextBox txtMa_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_km = value;
		}
	}

	internal virtual Label lblTen_km
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTen_km;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTen_km = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay1 = value;
		}
	}

	internal virtual Label lblTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTo = value;
		}
	}

	internal virtual Label lblFrom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFrom = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay2 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFilterKM()
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		Label1 = new Label();
		txtTenmau = new TextBox();
		Label2 = new Label();
		txtNgay1 = new AsMaskedTextBox();
		txtNgay2 = new AsMaskedTextBox();
		lblFrom = new Label();
		lblTo = new Label();
		txtMa_km = new AsTextBox();
		lblTen_km = new Label();
		((Control)gbLine).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		Button obj = cmdCancel;
		Point location = new Point(93, 126);
		((Control)obj).Location = location;
		Button obj2 = cmdOk;
		location = new Point(12, 126);
		((Control)obj2).Location = location;
		((Control)gbLine).Controls.Add((Control)(object)txtMa_km);
		((Control)gbLine).Controls.Add((Control)(object)lblTen_km);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay1);
		((Control)gbLine).Controls.Add((Control)(object)lblTo);
		((Control)gbLine).Controls.Add((Control)(object)lblFrom);
		((Control)gbLine).Controls.Add((Control)(object)txtNgay2);
		((Control)gbLine).Controls.Add((Control)(object)Label1);
		((Control)gbLine).Controls.Add((Control)(object)Label2);
		((Control)gbLine).Controls.Add((Control)(object)txtTenmau);
		GroupBox obj3 = gbLine;
		Size size = new Size(433, 116);
		((Control)obj3).Size = size;
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtTenmau, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)Label1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay2, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblFrom, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTo, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtNgay1, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)chkKsd, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)lblTen_km, 0);
		((Control)gbLine).Controls.SetChildIndex((Control)(object)txtMa_km, 0);
		Label1.AutoSize = true;
		Label label = Label1;
		location = new Point(6, 27);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(49, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 100;
		Label1.Text = "Tên mẫu";
		TextBox obj4 = txtTenmau;
		location = new Point(71, 24);
		((Control)obj4).Location = location;
		((Control)txtTenmau).Name = "txtTenmau";
		TextBox obj5 = txtTenmau;
		size = new Size(345, 20);
		((Control)obj5).Size = size;
		((Control)txtTenmau).TabIndex = 101;
		txtTenmau.Text = "DANH MỤC KHUYẾN MẠI";
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(6, 53);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(59, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 100;
		Label2.Text = "Tên CTKM";
		txtNgay1.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay1).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay1;
		location = new Point(71, 76);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay1).Mask = "##/##/####";
		((Control)txtNgay1).Name = "txtNgay1";
		((MaskedTextBox)txtNgay1).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay1;
		size = new Size(85, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay1).TabIndex = 102;
		((MaskedTextBox)txtNgay1).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay1;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtNgay2.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay2).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox4 = txtNgay2;
		location = new Point(177, 76);
		((Control)asMaskedTextBox4).Location = location;
		((MaskedTextBox)txtNgay2).Mask = "##/##/####";
		((Control)txtNgay2).Name = "txtNgay2";
		((MaskedTextBox)txtNgay2).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox5 = txtNgay2;
		size = new Size(81, 20);
		((Control)asMaskedTextBox5).Size = size;
		((Control)txtNgay2).TabIndex = 103;
		((MaskedTextBox)txtNgay2).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox6 = txtNgay2;
		dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox6.Value = dateTime;
		lblFrom.AutoSize = true;
		Label obj6 = lblFrom;
		location = new Point(9, 81);
		((Control)obj6).Location = location;
		((Control)lblFrom).Name = "lblFrom";
		Label obj7 = lblFrom;
		size = new Size(32, 13);
		((Control)obj7).Size = size;
		((Control)lblFrom).TabIndex = 104;
		lblFrom.Text = "Ngày";
		lblTo.AutoSize = true;
		Label obj8 = lblTo;
		location = new Point(161, 80);
		((Control)obj8).Location = location;
		((Control)lblTo).Name = "lblTo";
		Label obj9 = lblTo;
		size = new Size(10, 13);
		((Control)obj9).Size = size;
		((Control)lblTo).TabIndex = 105;
		lblTo.Text = "-";
		txtMa_km.AutoLookup = true;
		txtMa_km.AutoValid = true;
		((TextBoxBase)txtMa_km).BackColor = SystemColors.Info;
		((TextBox)txtMa_km).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox = txtMa_km;
		location = new Point(71, 50);
		((Control)asTextBox).Location = location;
		txtMa_km.LookupCodeName = "MA_KM";
		((Control)txtMa_km).Name = "txtMa_km";
		txtMa_km.NameControl = lblTen_km;
		AsTextBox asTextBox2 = txtMa_km;
		size = new Size(85, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_km).TabIndex = 106;
		txtMa_km.UseAutoCompleteSource = true;
		Label obj10 = lblTen_km;
		location = new Point(161, 53);
		((Control)obj10).Location = location;
		((Control)lblTen_km).Name = "lblTen_km";
		Label obj11 = lblTen_km;
		size = new Size(255, 13);
		((Control)obj11).Size = size;
		((Control)lblTen_km).TabIndex = 107;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(457, 161);
		((Form)this).ClientSize = size;
		((Control)this).Name = "frmFilterKM";
		((Form)this).Text = "DANH MUC KHUYEN MAI";
		((Control)gbLine).ResumeLayout(false);
		((Control)gbLine).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
