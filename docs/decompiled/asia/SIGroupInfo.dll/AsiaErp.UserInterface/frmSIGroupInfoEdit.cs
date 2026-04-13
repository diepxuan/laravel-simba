using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSIGroupInfoEdit : frmAsiaRoot
{
	public enum FORMSTATUS
	{
		VIEW_MODE,
		EDIT_MODE,
		ADD_MODE
	}

	private IContainer components;

	[AccessedThroughProperty("txtMa_Bp")]
	private TextBox _txtMa_Bp;

	[AccessedThroughProperty("lblMa_Bp")]
	private Label _lblMa_Bp;

	[AccessedThroughProperty("txtTen_Bp")]
	private TextBox _txtTen_Bp;

	[AccessedThroughProperty("lblTen_Bp")]
	private Label _lblTen_Bp;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdSave")]
	private Button _cmdSave;

	[AccessedThroughProperty("gbGroupInfo")]
	private GroupBox _gbGroupInfo;

	[AccessedThroughProperty("txtFullName")]
	private TextBox _txtFullName;

	[AccessedThroughProperty("txtGroupName")]
	private TextBox _txtGroupName;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("chkKSD")]
	private AsCheckBox _chkKSD;

	[AccessedThroughProperty("chkGrand")]
	private AsCheckBox _chkGrand;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	[AccessedThroughProperty("bsDanhMuc")]
	private BindingSource _bsDanhMuc;

	internal int f_intBindingPosition;

	private DataRow f_oDrwEdit;

	private bool f_blnOk;

	private bool f_blnIsEditMode;

	private iSiGroupInfo dao;

	internal virtual TextBox txtMa_Bp
	{
		get
		{
			return _txtMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtMa_Bp = value;
		}
	}

	internal virtual Label lblMa_Bp
	{
		get
		{
			return _lblMa_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblMa_Bp = value;
		}
	}

	internal virtual TextBox txtTen_Bp
	{
		get
		{
			return _txtTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTen_Bp = value;
		}
	}

	internal virtual Label lblTen_Bp
	{
		get
		{
			return _lblTen_Bp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTen_Bp = value;
		}
	}

	protected virtual Button cmdCancel
	{
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	protected virtual Button cmdSave
	{
		get
		{
			return _cmdSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = cmdSave_Click;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click -= eventHandler;
			}
			_cmdSave = value;
			if (_cmdSave != null)
			{
				((Control)_cmdSave).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox gbGroupInfo
	{
		get
		{
			return _gbGroupInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gbGroupInfo = value;
		}
	}

	internal virtual TextBox txtFullName
	{
		get
		{
			return _txtFullName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFullName = value;
		}
	}

	internal virtual TextBox txtGroupName
	{
		get
		{
			return _txtGroupName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtGroupName = value;
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

	internal virtual AsCheckBox chkKSD
	{
		get
		{
			return _chkKSD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkKSD = value;
		}
	}

	internal virtual AsCheckBox chkGrand
	{
		get
		{
			return _chkGrand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkGrand = value;
		}
	}

	protected virtual ErrorProvider epNotice
	{
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_epNotice = value;
		}
	}

	internal virtual BindingSource bsDanhMuc
	{
		get
		{
			return _bsDanhMuc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bsDanhMuc = value;
		}
	}

	[Browsable(false)]
	public bool EditMode
	{
		get
		{
			return f_blnIsEditMode;
		}
		set
		{
			f_blnIsEditMode = value;
		}
	}

	[Browsable(false)]
	public bool Success => f_blnOk;

	[Browsable(false)]
	public DataRow RowToEdit
	{
		get
		{
			return f_oDrwEdit;
		}
		set
		{
			f_oDrwEdit = value;
		}
	}

	public frmSIGroupInfoEdit()
	{
		((Form)this).Load += frmDM_Edit_Load;
		f_intBindingPosition = 0;
		f_blnOk = false;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSIGroupInfoEdit));
		txtMa_Bp = new TextBox();
		lblMa_Bp = new Label();
		txtTen_Bp = new TextBox();
		lblTen_Bp = new Label();
		cmdCancel = new Button();
		cmdSave = new Button();
		gbGroupInfo = new GroupBox();
		chkKSD = new AsCheckBox();
		chkGrand = new AsCheckBox();
		txtFullName = new TextBox();
		txtGroupName = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		epNotice = new ErrorProvider(components);
		bsDanhMuc = new BindingSource(components);
		((Control)gbGroupInfo).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((ISupportInitialize)bsDanhMuc).BeginInit();
		((Control)this).SuspendLayout();
		TextBox obj = txtMa_Bp;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)txtMa_Bp).Name = "txtMa_Bp";
		TextBox obj2 = txtMa_Bp;
		Size size = new Size(100, 20);
		((Control)obj2).Size = size;
		((Control)txtMa_Bp).TabIndex = 0;
		Label obj3 = lblMa_Bp;
		location = new Point(0, 0);
		((Control)obj3).Location = location;
		((Control)lblMa_Bp).Name = "lblMa_Bp";
		Label obj4 = lblMa_Bp;
		size = new Size(100, 23);
		((Control)obj4).Size = size;
		((Control)lblMa_Bp).TabIndex = 0;
		TextBox obj5 = txtTen_Bp;
		location = new Point(0, 0);
		((Control)obj5).Location = location;
		((Control)txtTen_Bp).Name = "txtTen_Bp";
		TextBox obj6 = txtTen_Bp;
		size = new Size(100, 20);
		((Control)obj6).Size = size;
		((Control)txtTen_Bp).TabIndex = 0;
		Label obj7 = lblTen_Bp;
		location = new Point(0, 0);
		((Control)obj7).Location = location;
		((Control)lblTen_Bp).Name = "lblTen_Bp";
		Label obj8 = lblTen_Bp;
		size = new Size(100, 23);
		((Control)obj8).Size = size;
		((Control)lblTen_Bp).TabIndex = 0;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).FlatAppearance.BorderSize = 3;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj9 = cmdCancel;
		location = new Point(93, 133);
		((Control)obj9).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj10 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)cmdCancel).TabIndex = 4;
		((ButtonBase)cmdCancel).Text = "&Huỷ bỏ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdSave).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdSave).Image = (Image)componentResourceManager.GetObject("cmdSave.Image");
		((ButtonBase)cmdSave).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdSave).ImeMode = (ImeMode)0;
		Button obj11 = cmdSave;
		location = new Point(12, 133);
		((Control)obj11).Location = location;
		((Control)cmdSave).Name = "cmdSave";
		Button obj12 = cmdSave;
		size = new Size(75, 23);
		((Control)obj12).Size = size;
		((Control)cmdSave).TabIndex = 3;
		((ButtonBase)cmdSave).Text = "&Lưu";
		((ButtonBase)cmdSave).TextAlign = (ContentAlignment)64;
		((Control)gbGroupInfo).Anchor = (AnchorStyles)15;
		((Control)gbGroupInfo).Controls.Add((Control)(object)chkKSD);
		((Control)gbGroupInfo).Controls.Add((Control)(object)chkGrand);
		((Control)gbGroupInfo).Controls.Add((Control)(object)txtFullName);
		((Control)gbGroupInfo).Controls.Add((Control)(object)txtGroupName);
		((Control)gbGroupInfo).Controls.Add((Control)(object)Label2);
		((Control)gbGroupInfo).Controls.Add((Control)(object)Label1);
		GroupBox obj13 = gbGroupInfo;
		location = new Point(12, 12);
		((Control)obj13).Location = location;
		((Control)gbGroupInfo).Name = "gbGroupInfo";
		GroupBox obj14 = gbGroupInfo;
		size = new Size(456, 115);
		((Control)obj14).Size = size;
		((Control)gbGroupInfo).TabIndex = 5;
		gbGroupInfo.TabStop = false;
		chkKSD.Checked = false;
		((ButtonBase)chkKSD).ImeMode = (ImeMode)0;
		AsCheckBox asCheckBox = chkKSD;
		location = new Point(81, 86);
		((Control)asCheckBox).Location = location;
		((Control)chkKSD).Name = "chkKSD";
		AsCheckBox asCheckBox2 = chkKSD;
		size = new Size(148, 24);
		((Control)asCheckBox2).Size = size;
		((Control)chkKSD).TabIndex = 14;
		((ButtonBase)chkKSD).Text = "Không sử dụng";
		chkKSD.TextValue = "0";
		chkGrand.Checked = false;
		((ButtonBase)chkGrand).ImeMode = (ImeMode)0;
		AsCheckBox asCheckBox3 = chkGrand;
		location = new Point(81, 65);
		((Control)asCheckBox3).Location = location;
		((Control)chkGrand).Name = "chkGrand";
		AsCheckBox asCheckBox4 = chkGrand;
		size = new Size(138, 24);
		((Control)asCheckBox4).Size = size;
		((Control)chkGrand).TabIndex = 13;
		((ButtonBase)chkGrand).Text = "Phân lại quyền";
		chkGrand.TextValue = "0";
		((Control)chkGrand).Visible = false;
		TextBox obj15 = txtFullName;
		location = new Point(81, 39);
		((Control)obj15).Location = location;
		((Control)txtFullName).Name = "txtFullName";
		TextBox obj16 = txtFullName;
		size = new Size(369, 20);
		((Control)obj16).Size = size;
		((Control)txtFullName).TabIndex = 12;
		txtGroupName.CharacterCasing = (CharacterCasing)1;
		TextBox obj17 = txtGroupName;
		location = new Point(81, 13);
		((Control)obj17).Location = location;
		((TextBoxBase)txtGroupName).MaxLength = 20;
		((Control)txtGroupName).Name = "txtGroupName";
		TextBox obj18 = txtGroupName;
		size = new Size(173, 20);
		((Control)obj18).Size = size;
		((Control)txtGroupName).TabIndex = 11;
		Label2.AutoSize = true;
		Label label = Label2;
		location = new Point(6, 42);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(63, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Tên đầy đủ";
		Label1.AutoSize = true;
		Label label3 = Label1;
		location = new Point(6, 16);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(55, 13);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 9;
		Label1.Text = "Tên nhóm";
		epNotice.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(480, 168);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)gbGroupInfo);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdSave);
		((Control)this).Name = "frmSIGroupInfoEdit";
		((Control)gbGroupInfo).ResumeLayout(false);
		((Control)gbGroupInfo).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((ISupportInitialize)bsDanhMuc).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdSave_Click(object sender, EventArgs e)
	{
		SetToRow();
		epNotice.Clear();
		if (!ValidData())
		{
			return;
		}
		if (f_blnIsEditMode)
		{
			if (UpdateDB())
			{
				f_blnOk = true;
				((Form)this).Close();
			}
		}
		else if (InsertToDB())
		{
			f_blnOk = true;
			((Form)this).Close();
		}
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		quit();
	}

	private void frmDM_Edit_Load(object sender, EventArgs e)
	{
		if (!((Component)(object)this).DesignMode)
		{
			CoreDataBinding();
			DataBinding();
			if (f_blnIsEditMode)
			{
				DisableFields();
				((Control)txtFullName).Select();
			}
			else
			{
				((Control)txtGroupName).Select();
			}
		}
	}

	protected virtual void DataBinding()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		Control ojb = (Control)(object)txtGroupName;
		CreateDataBinding(ref ojb, "GroupName");
		txtGroupName = (TextBox)ojb;
		ojb = (Control)(object)txtFullName;
		CreateDataBinding(ref ojb, "fullname");
		txtFullName = (TextBox)ojb;
		ojb = (Control)(object)chkGrand;
		CreateDataBinding(ref ojb, "grand", "Checked");
		chkGrand = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkKSD;
		CreateDataBinding(ref ojb, "ksd", "Checked");
		chkKSD = (AsCheckBox)(object)ojb;
	}

	private void CoreDataBinding()
	{
		bsDanhMuc.DataSource = f_oDrwEdit.Table.DefaultView;
		((Control)this).DataBindings.Add("Tag", (object)bsDanhMuc, "GroupName");
		bsDanhMuc.CurrencyManager.Position = f_intBindingPosition;
	}

	protected virtual bool SetToRow()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		foreach (Binding item in (BaseCollection)((ContainerControl)this).BindingContext[(object)bsDanhMuc].Bindings)
		{
			Binding val = item;
			val.WriteValue();
		}
		return true;
	}

	protected virtual bool InsertToDB()
	{
		dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
		int num = dao.InsertGroupInfo(Conversions.ToString(f_oDrwEdit["GroupName"]), Conversions.ToString(f_oDrwEdit["FullName"]), Conversions.ToBoolean(f_oDrwEdit["KSD"]), Conversions.ToBoolean(Helper.Repl_Null(RuntimeHelpers.GetObjectValue(f_oDrwEdit["Grand"]), isNum: true)));
		dao.Destroy();
		return num != 0;
	}

	protected virtual bool UpdateDB()
	{
		dao = (iSiGroupInfo)DAOFactory.CreateDAOInstance("SiGroupInfoDao", "SIGroupInfo", a_blnIsSysDB: true);
		int num = dao.UpdateGroupInfo(Conversions.ToString(f_oDrwEdit["GroupName"]), Conversions.ToString(f_oDrwEdit["FullName"]), Conversions.ToBoolean(f_oDrwEdit["KSD"]), Conversions.ToBoolean(f_oDrwEdit["Grand"]));
		dao.Destroy();
		return num != 0;
	}

	protected virtual void DisableFields()
	{
		((Control)txtGroupName).Enabled = false;
	}

	protected virtual void quit()
	{
		((Form)this).Close();
	}

	protected void SetControlError(Control errControl, string errMessage, bool additive = true)
	{
		if (!additive)
		{
			epNotice.Clear();
		}
		epNotice.SetError(errControl, errMessage);
		errControl.Focus();
		errControl.Select();
	}

	protected virtual bool ValidData()
	{
		if (Operators.CompareString(txtGroupName.Text.Trim(), "", false) == 0)
		{
			SetControlError((Control)(object)txtGroupName, Helper.GetMessContent(50002));
			return false;
		}
		return true;
	}

	protected void CreateDataBinding(ref Control ojb, string dbFieldName, string propertyName = "Text")
	{
		try
		{
			if (f_oDrwEdit != null && f_oDrwEdit.Table != null && f_oDrwEdit.Table.Columns.Contains(dbFieldName))
			{
				ojb.DataBindings.Add(propertyName, (object)bsDanhMuc, dbFieldName);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Helper.ProcessError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	protected override bool ProcessKeyPreview(ref Message m)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		Keys val = (Keys)(((Message)(ref m)).WParam.ToInt32() & 0xFFFF);
		if (((Message)(ref m)).Msg == 256 && (int)val == 27)
		{
			quit();
			return false;
		}
		return base.ProcessKeyPreview(ref m);
	}
}
