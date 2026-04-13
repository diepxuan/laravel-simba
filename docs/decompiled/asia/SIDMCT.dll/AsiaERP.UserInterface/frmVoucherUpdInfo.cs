using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaERP.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;
using My.Resources;

namespace AsiaERP.UserInterface;

[DesignerGenerated]
public class frmVoucherUpdInfo : frmAsiaRoot
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("AsTabControl1")]
	private AsTabControl _AsTabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtCT_table_name")]
	private TextBox _txtCT_table_name;

	[AccessedThroughProperty("lblCT_table_name")]
	private Label _lblCT_table_name;

	[AccessedThroughProperty("txtPH_table_name")]
	private TextBox _txtPH_table_name;

	[AccessedThroughProperty("lblPH_table_name")]
	private Label _lblPH_table_name;

	[AccessedThroughProperty("txtVoucher_code")]
	private TextBox _txtVoucher_code;

	[AccessedThroughProperty("txtCP_table_name")]
	private TextBox _txtCP_table_name;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtPrint_class_name")]
	private TextBox _txtPrint_class_name;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("txtView_class_name")]
	private TextBox _txtView_class_name;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtSearch_class_name")]
	private TextBox _txtSearch_class_name;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtPH_Extra_Edit_Control_List")]
	private TextBox _txtPH_Extra_Edit_Control_List;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("chkHas_taout")]
	private AsCheckBox _chkHas_taout;

	[AccessedThroughProperty("chkHas_tain")]
	private AsCheckBox _chkHas_tain;

	[AccessedThroughProperty("chkHas_cp")]
	private AsCheckBox _chkHas_cp;

	[AccessedThroughProperty("chkCopy_vaora")]
	private AsCheckBox _chkCopy_vaora;

	[AccessedThroughProperty("chkCopy_enabled")]
	private AsCheckBox _chkCopy_enabled;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtDescription")]
	private TextBox _txtDescription;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtPar0")]
	private TextBox _txtPar0;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("txtPar9")]
	private TextBox _txtPar9;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("txtPar8")]
	private TextBox _txtPar8;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("txtPar7")]
	private TextBox _txtPar7;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("txtPar6")]
	private TextBox _txtPar6;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("txtPar5")]
	private TextBox _txtPar5;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("txtPar4")]
	private TextBox _txtPar4;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("txtPar3")]
	private TextBox _txtPar3;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("txtPar2")]
	private TextBox _txtPar2;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("txtPar1")]
	private TextBox _txtPar1;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("dgvPH_Carry_out")]
	private AsInputDGV _dgvPH_Carry_out;

	[AccessedThroughProperty("dgvCT_Carry_out")]
	private AsInputDGV _dgvCT_Carry_out;

	[AccessedThroughProperty("dgvPH_Print_out")]
	private AsInputDGV _dgvPH_Print_out;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("txtMenuid")]
	private MaskedTextBox _txtMenuid;

	[AccessedThroughProperty("txtRow_per_page")]
	private AsTextNumeric _txtRow_per_page;

	[AccessedThroughProperty("bsVoucherInfo")]
	private BindingSource _bsVoucherInfo;

	[AccessedThroughProperty("cboMa_nt_default")]
	private AsComboBoxNT _cboMa_nt_default;

	[AccessedThroughProperty("cboNxt")]
	private ComboBox _cboNxt;

	[AccessedThroughProperty("cmdOutAll")]
	private Button _cmdOutAll;

	[AccessedThroughProperty("cmdInAll")]
	private Button _cmdInAll;

	[AccessedThroughProperty("cmdOut")]
	private Button _cmdOut;

	[AccessedThroughProperty("cmdIn")]
	private Button _cmdIn;

	[AccessedThroughProperty("dgvPH_Carry_in")]
	private AsInputDGV _dgvPH_Carry_in;

	[AccessedThroughProperty("cmdCTC_OutAll")]
	private Button _cmdCTC_OutAll;

	[AccessedThroughProperty("cmdCTC_InAll")]
	private Button _cmdCTC_InAll;

	[AccessedThroughProperty("cmdCTC_out")]
	private Button _cmdCTC_out;

	[AccessedThroughProperty("cmdCTC_in")]
	private Button _cmdCTC_in;

	[AccessedThroughProperty("dgvCT_Carry_in")]
	private AsInputDGV _dgvCT_Carry_in;

	[AccessedThroughProperty("cmdPHP_OutAll")]
	private Button _cmdPHP_OutAll;

	[AccessedThroughProperty("cmdPHP_InAll")]
	private Button _cmdPHP_InAll;

	[AccessedThroughProperty("cmdPHP_out")]
	private Button _cmdPHP_out;

	[AccessedThroughProperty("cmdPHP_In")]
	private Button _cmdPHP_In;

	[AccessedThroughProperty("dgvPH_Print_in")]
	private AsInputDGV _dgvPH_Print_in;

	[AccessedThroughProperty("dgvcPHC_Field_out")]
	private DataGridViewTextBoxColumn _dgvcPHC_Field_out;

	[AccessedThroughProperty("dgvcPHC_Field_out_Desc")]
	private DataGridViewTextBoxColumn _dgvcPHC_Field_out_Desc;

	[AccessedThroughProperty("dgvcCTC_Field_out")]
	private DataGridViewTextBoxColumn _dgvcCTC_Field_out;

	[AccessedThroughProperty("dgvcCTC_Field_out_Desc")]
	private DataGridViewTextBoxColumn _dgvcCTC_Field_out_Desc;

	[AccessedThroughProperty("dgvcCTC_Field_in")]
	private DataGridViewTextBoxColumn _dgvcCTC_Field_in;

	[AccessedThroughProperty("dgvcCTC_Field_in_Desc")]
	private DataGridViewTextBoxColumn _dgvcCTC_Field_in_Desc;

	[AccessedThroughProperty("dgvcPHC_Field_in")]
	private DataGridViewTextBoxColumn _dgvcPHC_Field_in;

	[AccessedThroughProperty("dgvcPHC_Field_in_Desc")]
	private DataGridViewTextBoxColumn _dgvcPHC_Field_in_Desc;

	[AccessedThroughProperty("dgvcPHP_Field_in")]
	private DataGridViewTextBoxColumn _dgvcPHP_Field_in;

	[AccessedThroughProperty("dgvcPHP_Field_in_Desc")]
	private DataGridViewTextBoxColumn _dgvcPHP_Field_in_Desc;

	[AccessedThroughProperty("dgvcPHP_Field_out")]
	private DataGridViewTextBoxColumn _dgvcPHP_Field_out;

	[AccessedThroughProperty("dgvcPHP_Field_out_Desc")]
	private DataGridViewTextBoxColumn _dgvcPHP_Field_out_Desc;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	private string f_sMa_ct;

	private DataRow f_oDrwEdit;

	private bool f_blnOk;

	public VoucherInformation f_oVoucherInfo;

	public DataTable f_oTblPH;

	public DataTable f_oTblCT;

	private DataTable f_oTblPH_Carry_out;

	private DataTable f_oTblPH_Carry_in;

	private DataTable f_oTblCT_Carry_out;

	private DataTable f_oTblCT_Carry_in;

	private DataTable f_oTblPH_Print_out;

	private DataTable f_oTblPH_Print_in;

	private Hashtable f_hstPH_Field_Desc;

	private Hashtable f_hstCT_Field_Desc;

	internal virtual AsTabControl AsTabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsTabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AsTabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
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

	internal virtual TextBox txtCT_table_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCT_table_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCT_table_name = value;
		}
	}

	internal virtual Label lblCT_table_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCT_table_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCT_table_name = value;
		}
	}

	internal virtual TextBox txtPH_table_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPH_table_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPH_table_name = value;
		}
	}

	internal virtual Label lblPH_table_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPH_table_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPH_table_name = value;
		}
	}

	internal virtual TextBox txtVoucher_code
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVoucher_code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVoucher_code = value;
		}
	}

	internal virtual TextBox txtCP_table_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCP_table_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCP_table_name = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual TextBox txtPrint_class_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPrint_class_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPrint_class_name = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual TextBox txtView_class_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtView_class_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtView_class_name = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual TextBox txtSearch_class_name
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSearch_class_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSearch_class_name = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual TextBox txtPH_Extra_Edit_Control_List
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPH_Extra_Edit_Control_List;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPH_Extra_Edit_Control_List = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual AsCheckBox chkHas_taout
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkHas_taout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkHas_taout = value;
		}
	}

	internal virtual AsCheckBox chkHas_tain
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkHas_tain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkHas_tain = value;
		}
	}

	internal virtual AsCheckBox chkHas_cp
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkHas_cp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkHas_cp = value;
		}
	}

	internal virtual AsCheckBox chkCopy_vaora
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCopy_vaora;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCopy_vaora = value;
		}
	}

	internal virtual AsCheckBox chkCopy_enabled
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCopy_enabled;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCopy_enabled = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual TextBox txtDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDescription = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual TextBox txtPar0
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar0 = value;
		}
	}

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual TextBox txtPar9
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar9 = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual TextBox txtPar8
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar8 = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual TextBox txtPar7
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar7 = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual TextBox txtPar6
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar6 = value;
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual TextBox txtPar5
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar5 = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual TextBox txtPar4
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar4 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual TextBox txtPar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar3 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual TextBox txtPar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar2 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual TextBox txtPar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPar1 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
		}
	}

	internal virtual AsInputDGV dgvPH_Carry_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvPH_Carry_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvPH_Carry_out = value;
		}
	}

	internal virtual AsInputDGV dgvCT_Carry_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCT_Carry_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvCT_Carry_out = value;
		}
	}

	internal virtual AsInputDGV dgvPH_Print_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvPH_Print_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvPH_Print_out = value;
		}
	}

	protected virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdCancel = value;
		}
	}

	protected virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOK_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual MaskedTextBox txtMenuid
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMenuid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMenuid = value;
		}
	}

	internal virtual AsTextNumeric txtRow_per_page
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRow_per_page;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtRow_per_page = value;
		}
	}

	protected internal virtual BindingSource bsVoucherInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _bsVoucherInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bsVoucherInfo = value;
		}
	}

	internal virtual AsComboBoxNT cboMa_nt_default
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboMa_nt_default;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboMa_nt_default = value;
		}
	}

	internal virtual ComboBox cboNxt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cboNxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cboNxt = value;
		}
	}

	internal virtual Button cmdOutAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOutAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOutAll_Click;
			if (_cmdOutAll != null)
			{
				((Control)_cmdOutAll).Click -= eventHandler;
			}
			_cmdOutAll = value;
			if (_cmdOutAll != null)
			{
				((Control)_cmdOutAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdInAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdInAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdInAll_Click;
			if (_cmdInAll != null)
			{
				((Control)_cmdInAll).Click -= eventHandler;
			}
			_cmdInAll = value;
			if (_cmdInAll != null)
			{
				((Control)_cmdInAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOut_Click;
			if (_cmdOut != null)
			{
				((Control)_cmdOut).Click -= eventHandler;
			}
			_cmdOut = value;
			if (_cmdOut != null)
			{
				((Control)_cmdOut).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdIn
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdIn_Click;
			if (_cmdIn != null)
			{
				((Control)_cmdIn).Click -= eventHandler;
			}
			_cmdIn = value;
			if (_cmdIn != null)
			{
				((Control)_cmdIn).Click += eventHandler;
			}
		}
	}

	internal virtual AsInputDGV dgvPH_Carry_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvPH_Carry_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvPH_Carry_in = value;
		}
	}

	internal virtual Button cmdCTC_OutAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCTC_OutAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCTC_OutAll_Click;
			if (_cmdCTC_OutAll != null)
			{
				((Control)_cmdCTC_OutAll).Click -= eventHandler;
			}
			_cmdCTC_OutAll = value;
			if (_cmdCTC_OutAll != null)
			{
				((Control)_cmdCTC_OutAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCTC_InAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCTC_InAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCTC_InAll_Click;
			if (_cmdCTC_InAll != null)
			{
				((Control)_cmdCTC_InAll).Click -= eventHandler;
			}
			_cmdCTC_InAll = value;
			if (_cmdCTC_InAll != null)
			{
				((Control)_cmdCTC_InAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCTC_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCTC_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCTC_out_Click;
			if (_cmdCTC_out != null)
			{
				((Control)_cmdCTC_out).Click -= eventHandler;
			}
			_cmdCTC_out = value;
			if (_cmdCTC_out != null)
			{
				((Control)_cmdCTC_out).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdCTC_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCTC_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCTC_in_Click;
			if (_cmdCTC_in != null)
			{
				((Control)_cmdCTC_in).Click -= eventHandler;
			}
			_cmdCTC_in = value;
			if (_cmdCTC_in != null)
			{
				((Control)_cmdCTC_in).Click += eventHandler;
			}
		}
	}

	internal virtual AsInputDGV dgvCT_Carry_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCT_Carry_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvCT_Carry_in = value;
		}
	}

	internal virtual Button cmdPHP_OutAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPHP_OutAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPHP_OutAll_Click;
			if (_cmdPHP_OutAll != null)
			{
				((Control)_cmdPHP_OutAll).Click -= eventHandler;
			}
			_cmdPHP_OutAll = value;
			if (_cmdPHP_OutAll != null)
			{
				((Control)_cmdPHP_OutAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdPHP_InAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPHP_InAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPHP_InAll_Click;
			if (_cmdPHP_InAll != null)
			{
				((Control)_cmdPHP_InAll).Click -= eventHandler;
			}
			_cmdPHP_InAll = value;
			if (_cmdPHP_InAll != null)
			{
				((Control)_cmdPHP_InAll).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdPHP_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPHP_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPHP_out_Click;
			if (_cmdPHP_out != null)
			{
				((Control)_cmdPHP_out).Click -= eventHandler;
			}
			_cmdPHP_out = value;
			if (_cmdPHP_out != null)
			{
				((Control)_cmdPHP_out).Click += eventHandler;
			}
		}
	}

	internal virtual Button cmdPHP_In
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPHP_In;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPHP_In_Click;
			if (_cmdPHP_In != null)
			{
				((Control)_cmdPHP_In).Click -= eventHandler;
			}
			_cmdPHP_In = value;
			if (_cmdPHP_In != null)
			{
				((Control)_cmdPHP_In).Click += eventHandler;
			}
		}
	}

	internal virtual AsInputDGV dgvPH_Print_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvPH_Print_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvPH_Print_in = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHC_Field_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHC_Field_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHC_Field_out = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHC_Field_out_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHC_Field_out_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHC_Field_out_Desc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcCTC_Field_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCTC_Field_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCTC_Field_out = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcCTC_Field_out_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCTC_Field_out_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCTC_Field_out_Desc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcCTC_Field_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCTC_Field_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCTC_Field_in = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcCTC_Field_in_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcCTC_Field_in_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcCTC_Field_in_Desc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHC_Field_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHC_Field_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHC_Field_in = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHC_Field_in_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHC_Field_in_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHC_Field_in_Desc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHP_Field_in
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHP_Field_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHP_Field_in = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHP_Field_in_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHP_Field_in_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHP_Field_in_Desc = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHP_Field_out
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHP_Field_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHP_Field_out = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dgvcPHP_Field_out_Desc
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvcPHP_Field_out_Desc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvcPHP_Field_out_Desc = value;
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

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30 = value;
		}
	}

	internal virtual Label Label31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label31 = value;
		}
	}

	internal virtual Label Label32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label32 = value;
		}
	}

	public bool Success => f_blnOk;

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

	public VoucherInformation MyVoucherInfo
	{
		get
		{
			if (f_oVoucherInfo == null)
			{
				f_oVoucherInfo = AsiaErp.Framework.Environment.GetVoucherInformation(Ma_ct);
			}
			return f_oVoucherInfo;
		}
	}

	protected virtual VoucherController MyController
	{
		get
		{
			if (((Component)(object)this).DesignMode)
			{
				return null;
			}
			return ControllerFactory.GetVoucherControllerByInformation(MyVoucherInfo);
		}
	}

	public string Ma_ct
	{
		get
		{
			return f_sMa_ct;
		}
		set
		{
			f_sMa_ct = value;
		}
	}

	public frmVoucherUpdInfo()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Control)this).KeyDown += new KeyEventHandler(frmVoucherUpdInfo_KeyDown);
		((Form)this).Load += frmVoucherUpdInfo_Load;
		__ENCAddToList(this);
		f_sMa_ct = "";
		f_blnOk = false;
		f_hstPH_Field_Desc = new Hashtable();
		f_hstCT_Field_Desc = new Hashtable();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected O, but got Unknown
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected O, but got Unknown
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected O, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		//IL_2809: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aaa: Expected O, but got Unknown
		//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b57: Expected O, but got Unknown
		//IL_2bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c05: Expected O, but got Unknown
		//IL_2da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daf: Expected O, but got Unknown
		//IL_2e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5c: Expected O, but got Unknown
		//IL_2efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f06: Expected O, but got Unknown
		//IL_312c: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c1: Expected O, but got Unknown
		//IL_3464: Unknown result type (might be due to invalid IL or missing references)
		//IL_346e: Expected O, but got Unknown
		//IL_3512: Unknown result type (might be due to invalid IL or missing references)
		//IL_351c: Expected O, but got Unknown
		//IL_36af: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b9: Expected O, but got Unknown
		//IL_375c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3766: Expected O, but got Unknown
		//IL_3806: Unknown result type (might be due to invalid IL or missing references)
		//IL_3810: Expected O, but got Unknown
		//IL_3a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc8: Expected O, but got Unknown
		//IL_3d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6d: Expected O, but got Unknown
		//IL_3e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e13: Expected O, but got Unknown
		//IL_3f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9b: Expected O, but got Unknown
		//IL_4039: Unknown result type (might be due to invalid IL or missing references)
		//IL_4043: Expected O, but got Unknown
		//IL_40e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ed: Expected O, but got Unknown
		//IL_424e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4258: Expected O, but got Unknown
		//IL_43b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c3: Expected O, but got Unknown
		//IL_444d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4457: Expected O, but got Unknown
		//IL_44e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ef: Expected O, but got Unknown
		//IL_457a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4584: Expected O, but got Unknown
		//IL_4613: Unknown result type (might be due to invalid IL or missing references)
		//IL_461d: Expected O, but got Unknown
		//IL_46a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b2: Expected O, but got Unknown
		//IL_479b: Unknown result type (might be due to invalid IL or missing references)
		//IL_47a5: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		DataGridViewCellStyle val13 = new DataGridViewCellStyle();
		DataGridViewCellStyle val14 = new DataGridViewCellStyle();
		DataGridViewCellStyle val15 = new DataGridViewCellStyle();
		DataGridViewCellStyle val16 = new DataGridViewCellStyle();
		DataGridViewCellStyle val17 = new DataGridViewCellStyle();
		DataGridViewCellStyle val18 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVoucherUpdInfo));
		AsTabControl1 = new AsTabControl();
		TabPage1 = new TabPage();
		cboNxt = new ComboBox();
		cboMa_nt_default = new AsComboBoxNT();
		txtRow_per_page = new AsTextNumeric();
		txtMenuid = new MaskedTextBox();
		Label29 = new Label();
		Label28 = new Label();
		Label27 = new Label();
		Label26 = new Label();
		Label25 = new Label();
		txtPar0 = new TextBox();
		Label24 = new Label();
		txtPar9 = new TextBox();
		Label23 = new Label();
		txtPar8 = new TextBox();
		Label22 = new Label();
		txtPar7 = new TextBox();
		Label21 = new Label();
		txtPar6 = new TextBox();
		Label20 = new Label();
		txtPar5 = new TextBox();
		Label19 = new Label();
		txtPar4 = new TextBox();
		Label18 = new Label();
		txtPar3 = new TextBox();
		Label17 = new Label();
		txtPar2 = new TextBox();
		Label16 = new Label();
		txtPar1 = new TextBox();
		Label15 = new Label();
		txtDescription = new TextBox();
		Label14 = new Label();
		Label13 = new Label();
		chkCopy_vaora = new AsCheckBox();
		chkCopy_enabled = new AsCheckBox();
		chkHas_taout = new AsCheckBox();
		chkHas_tain = new AsCheckBox();
		chkHas_cp = new AsCheckBox();
		Label11 = new Label();
		Label10 = new Label();
		txtPrint_class_name = new TextBox();
		Label9 = new Label();
		txtView_class_name = new TextBox();
		Label8 = new Label();
		txtSearch_class_name = new TextBox();
		Label7 = new Label();
		txtPH_Extra_Edit_Control_List = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		txtCP_table_name = new TextBox();
		Label4 = new Label();
		txtCT_table_name = new TextBox();
		lblCT_table_name = new Label();
		txtPH_table_name = new TextBox();
		lblPH_table_name = new Label();
		txtVoucher_code = new TextBox();
		Label1 = new Label();
		TabPage2 = new TabPage();
		cmdOutAll = new Button();
		cmdInAll = new Button();
		cmdOut = new Button();
		cmdIn = new Button();
		dgvPH_Carry_in = new AsInputDGV();
		dgvcPHC_Field_in = new DataGridViewTextBoxColumn();
		dgvcPHC_Field_in_Desc = new DataGridViewTextBoxColumn();
		dgvPH_Carry_out = new AsInputDGV();
		dgvcPHC_Field_out = new DataGridViewTextBoxColumn();
		dgvcPHC_Field_out_Desc = new DataGridViewTextBoxColumn();
		TabPage3 = new TabPage();
		cmdCTC_OutAll = new Button();
		cmdCTC_InAll = new Button();
		cmdCTC_out = new Button();
		cmdCTC_in = new Button();
		dgvCT_Carry_in = new AsInputDGV();
		dgvcCTC_Field_in = new DataGridViewTextBoxColumn();
		dgvcCTC_Field_in_Desc = new DataGridViewTextBoxColumn();
		dgvCT_Carry_out = new AsInputDGV();
		dgvcCTC_Field_out = new DataGridViewTextBoxColumn();
		dgvcCTC_Field_out_Desc = new DataGridViewTextBoxColumn();
		TabPage4 = new TabPage();
		cmdPHP_OutAll = new Button();
		cmdPHP_InAll = new Button();
		cmdPHP_out = new Button();
		cmdPHP_In = new Button();
		dgvPH_Print_in = new AsInputDGV();
		dgvcPHP_Field_in = new DataGridViewTextBoxColumn();
		dgvcPHP_Field_in_Desc = new DataGridViewTextBoxColumn();
		dgvPH_Print_out = new AsInputDGV();
		dgvcPHP_Field_out = new DataGridViewTextBoxColumn();
		dgvcPHP_Field_out_Desc = new DataGridViewTextBoxColumn();
		cmdCancel = new Button();
		cmdOK = new Button();
		bsVoucherInfo = new BindingSource(components);
		Label2 = new Label();
		Label3 = new Label();
		Label12 = new Label();
		Label30 = new Label();
		Label31 = new Label();
		Label32 = new Label();
		((Control)AsTabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)dgvPH_Carry_in).BeginInit();
		((ISupportInitialize)dgvPH_Carry_out).BeginInit();
		((Control)TabPage3).SuspendLayout();
		((ISupportInitialize)dgvCT_Carry_in).BeginInit();
		((ISupportInitialize)dgvCT_Carry_out).BeginInit();
		((Control)TabPage4).SuspendLayout();
		((ISupportInitialize)dgvPH_Print_in).BeginInit();
		((ISupportInitialize)dgvPH_Print_out).BeginInit();
		((ISupportInitialize)bsVoucherInfo).BeginInit();
		((Control)this).SuspendLayout();
		((Control)AsTabControl1).Anchor = (AnchorStyles)15;
		((Control)AsTabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)AsTabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)AsTabControl1).Controls.Add((Control)(object)TabPage3);
		((Control)AsTabControl1).Controls.Add((Control)(object)TabPage4);
		((TabControl)AsTabControl1).DrawMode = (TabDrawMode)1;
		AsTabControl asTabControl = AsTabControl1;
		Point location = new Point(12, 12);
		((Control)asTabControl).Location = location;
		((Control)AsTabControl1).Name = "AsTabControl1";
		((TabControl)AsTabControl1).SelectedIndex = 0;
		AsTabControl asTabControl2 = AsTabControl1;
		Size size = new Size(799, 506);
		((Control)asTabControl2).Size = size;
		((Control)AsTabControl1).TabIndex = 0;
		((Control)TabPage1).Controls.Add((Control)(object)cboNxt);
		((Control)TabPage1).Controls.Add((Control)(object)cboMa_nt_default);
		((Control)TabPage1).Controls.Add((Control)(object)txtRow_per_page);
		((Control)TabPage1).Controls.Add((Control)(object)txtMenuid);
		((Control)TabPage1).Controls.Add((Control)(object)Label29);
		((Control)TabPage1).Controls.Add((Control)(object)Label28);
		((Control)TabPage1).Controls.Add((Control)(object)Label27);
		((Control)TabPage1).Controls.Add((Control)(object)Label26);
		((Control)TabPage1).Controls.Add((Control)(object)Label25);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar0);
		((Control)TabPage1).Controls.Add((Control)(object)Label24);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar9);
		((Control)TabPage1).Controls.Add((Control)(object)Label23);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar8);
		((Control)TabPage1).Controls.Add((Control)(object)Label22);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar7);
		((Control)TabPage1).Controls.Add((Control)(object)Label21);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar6);
		((Control)TabPage1).Controls.Add((Control)(object)Label20);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar5);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar4);
		((Control)TabPage1).Controls.Add((Control)(object)Label18);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar3);
		((Control)TabPage1).Controls.Add((Control)(object)Label17);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar2);
		((Control)TabPage1).Controls.Add((Control)(object)Label16);
		((Control)TabPage1).Controls.Add((Control)(object)txtPar1);
		((Control)TabPage1).Controls.Add((Control)(object)Label15);
		((Control)TabPage1).Controls.Add((Control)(object)txtDescription);
		((Control)TabPage1).Controls.Add((Control)(object)Label14);
		((Control)TabPage1).Controls.Add((Control)(object)Label13);
		((Control)TabPage1).Controls.Add((Control)(object)chkCopy_vaora);
		((Control)TabPage1).Controls.Add((Control)(object)chkCopy_enabled);
		((Control)TabPage1).Controls.Add((Control)(object)chkHas_taout);
		((Control)TabPage1).Controls.Add((Control)(object)chkHas_tain);
		((Control)TabPage1).Controls.Add((Control)(object)chkHas_cp);
		((Control)TabPage1).Controls.Add((Control)(object)Label11);
		((Control)TabPage1).Controls.Add((Control)(object)Label10);
		((Control)TabPage1).Controls.Add((Control)(object)txtPrint_class_name);
		((Control)TabPage1).Controls.Add((Control)(object)Label9);
		((Control)TabPage1).Controls.Add((Control)(object)txtView_class_name);
		((Control)TabPage1).Controls.Add((Control)(object)Label8);
		((Control)TabPage1).Controls.Add((Control)(object)txtSearch_class_name);
		((Control)TabPage1).Controls.Add((Control)(object)Label7);
		((Control)TabPage1).Controls.Add((Control)(object)txtPH_Extra_Edit_Control_List);
		((Control)TabPage1).Controls.Add((Control)(object)Label6);
		((Control)TabPage1).Controls.Add((Control)(object)Label5);
		((Control)TabPage1).Controls.Add((Control)(object)txtCP_table_name);
		((Control)TabPage1).Controls.Add((Control)(object)Label4);
		((Control)TabPage1).Controls.Add((Control)(object)txtCT_table_name);
		((Control)TabPage1).Controls.Add((Control)(object)lblCT_table_name);
		((Control)TabPage1).Controls.Add((Control)(object)txtPH_table_name);
		((Control)TabPage1).Controls.Add((Control)(object)lblPH_table_name);
		((Control)TabPage1).Controls.Add((Control)(object)txtVoucher_code);
		((Control)TabPage1).Controls.Add((Control)(object)Label1);
		TabPage tabPage = TabPage1;
		location = new Point(4, 25);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).Padding = padding;
		TabPage tabPage3 = TabPage1;
		size = new Size(791, 477);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "Thông tin chung";
		TabPage1.UseVisualStyleBackColor = true;
		cboNxt.DropDownStyle = (ComboBoxStyle)2;
		((Control)cboNxt).Enabled = false;
		((ListControl)cboNxt).FormattingEnabled = true;
		ComboBox obj = cboNxt;
		location = new Point(163, 238);
		((Control)obj).Location = location;
		((Control)cboNxt).Name = "cboNxt";
		ComboBox obj2 = cboNxt;
		size = new Size(121, 21);
		((Control)obj2).Size = size;
		((Control)cboNxt).TabIndex = 7;
		((ComboBox)cboMa_nt_default).DropDownStyle = (ComboBoxStyle)2;
		((Control)cboMa_nt_default).Enabled = false;
		((ListControl)cboMa_nt_default).FormattingEnabled = true;
		AsComboBoxNT asComboBoxNT = cboMa_nt_default;
		location = new Point(163, 211);
		((Control)asComboBoxNT).Location = location;
		cboMa_nt_default.MA_NT = "";
		((Control)cboMa_nt_default).Name = "cboMa_nt_default";
		AsComboBoxNT asComboBoxNT2 = cboMa_nt_default;
		size = new Size(47, 21);
		((Control)asComboBoxNT2).Size = size;
		((Control)cboMa_nt_default).TabIndex = 6;
		txtRow_per_page.DecimalSymbol = ".";
		txtRow_per_page.HotKey = (Keys)13;
		AsTextNumeric asTextNumeric = txtRow_per_page;
		location = new Point(164, 387);
		((Control)asTextNumeric).Location = location;
		txtRow_per_page.Mask = "### ### ### ###";
		((Control)txtRow_per_page).Name = "txtRow_per_page";
		AsTextNumeric asTextNumeric2 = txtRow_per_page;
		size = new Size(47, 20);
		((Control)asTextNumeric2).Size = size;
		txtRow_per_page.SpecialType = Commons.NumericSpecialType.Other;
		((Control)txtRow_per_page).TabIndex = 13;
		((TextBox)txtRow_per_page).Text = "0";
		((TextBox)txtRow_per_page).TextAlign = (HorizontalAlignment)1;
		txtRow_per_page.Type = Commons.NumericType.ORTHER_;
		txtRow_per_page.Value = 0;
		((Control)txtMenuid).Enabled = false;
		txtMenuid.InsertKeyMode = (InsertKeyMode)2;
		MaskedTextBox obj3 = txtMenuid;
		location = new Point(163, 82);
		((Control)obj3).Location = location;
		txtMenuid.Mask = "##.##.##";
		((Control)txtMenuid).Name = "txtMenuid";
		txtMenuid.PromptChar = ' ';
		MaskedTextBox obj4 = txtMenuid;
		size = new Size(100, 20);
		((Control)obj4).Size = size;
		((Control)txtMenuid).TabIndex = 1;
		Label29.AutoSize = true;
		((Control)Label29).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		Label label = Label29;
		location = new Point(13, 361);
		((Control)label).Location = location;
		((Control)Label29).Name = "Label29";
		Label label2 = Label29;
		size = new Size(89, 17);
		((Control)label2).Size = size;
		((Control)Label29).TabIndex = 58;
		Label29.Text = "In chứng từ";
		Label28.AutoSize = true;
		((Control)Label28).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		Label label3 = Label28;
		location = new Point(457, 27);
		((Control)label3).Location = location;
		((Control)Label28).Name = "Label28";
		Label label4 = Label28;
		size = new Size(171, 17);
		((Control)label4).Size = size;
		((Control)Label28).TabIndex = 57;
		Label28.Text = "Bảng dữ liệu liên quan";
		Label27.AutoSize = true;
		((Control)Label27).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		Label label5 = Label27;
		location = new Point(13, 27);
		((Control)label5).Location = location;
		((Control)Label27).Name = "Label27";
		Label label6 = Label27;
		size = new Size(126, 17);
		((Control)label6).Size = size;
		((Control)Label27).TabIndex = 56;
		Label27.Text = "Thông tin chung";
		Label26.AutoSize = true;
		Label label7 = Label26;
		location = new Point(473, 112);
		((Control)label7).Location = location;
		((Control)Label26).Name = "Label26";
		Label label8 = Label26;
		size = new Size(103, 13);
		((Control)label8).Size = size;
		((Control)Label26).TabIndex = 55;
		Label26.Text = "Có chi phí kèm theo";
		Label25.AutoSize = true;
		((Control)Label25).Font = new Font("Microsoft Sans Serif", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		Label label9 = Label25;
		location = new Point(457, 163);
		((Control)label9).Location = location;
		((Control)Label25).Name = "Label25";
		Label label10 = Label25;
		size = new Size(134, 17);
		((Control)label10).Size = size;
		((Control)Label25).TabIndex = 54;
		Label25.Text = "Tham số mở rộng";
		((Control)txtPar0).Enabled = false;
		TextBox obj5 = txtPar0;
		location = new Point(542, 186);
		((Control)obj5).Location = location;
		((Control)txtPar0).Name = "txtPar0";
		TextBox obj6 = txtPar0;
		size = new Size(231, 20);
		((Control)obj6).Size = size;
		((Control)txtPar0).TabIndex = 19;
		Label24.AutoSize = true;
		Label label11 = Label24;
		location = new Point(473, 189);
		((Control)label11).Location = location;
		((Control)Label24).Name = "Label24";
		Label label12 = Label24;
		size = new Size(63, 13);
		((Control)label12).Size = size;
		((Control)Label24).TabIndex = 52;
		Label24.Text = "Tham số 00";
		((Control)txtPar9).Enabled = false;
		TextBox obj7 = txtPar9;
		location = new Point(542, 420);
		((Control)obj7).Location = location;
		((Control)txtPar9).Name = "txtPar9";
		TextBox obj8 = txtPar9;
		size = new Size(231, 20);
		((Control)obj8).Size = size;
		((Control)txtPar9).TabIndex = 28;
		Label23.AutoSize = true;
		Label label13 = Label23;
		location = new Point(473, 423);
		((Control)label13).Location = location;
		((Control)Label23).Name = "Label23";
		Label label14 = Label23;
		size = new Size(63, 13);
		((Control)label14).Size = size;
		((Control)Label23).TabIndex = 50;
		Label23.Text = "Tham số 09";
		((Control)txtPar8).Enabled = false;
		TextBox obj9 = txtPar8;
		location = new Point(542, 394);
		((Control)obj9).Location = location;
		((Control)txtPar8).Name = "txtPar8";
		TextBox obj10 = txtPar8;
		size = new Size(231, 20);
		((Control)obj10).Size = size;
		((Control)txtPar8).TabIndex = 27;
		Label22.AutoSize = true;
		Label label15 = Label22;
		location = new Point(473, 397);
		((Control)label15).Location = location;
		((Control)Label22).Name = "Label22";
		Label label16 = Label22;
		size = new Size(63, 13);
		((Control)label16).Size = size;
		((Control)Label22).TabIndex = 48;
		Label22.Text = "Tham số 08";
		((Control)txtPar7).Enabled = false;
		TextBox obj11 = txtPar7;
		location = new Point(542, 368);
		((Control)obj11).Location = location;
		((Control)txtPar7).Name = "txtPar7";
		TextBox obj12 = txtPar7;
		size = new Size(231, 20);
		((Control)obj12).Size = size;
		((Control)txtPar7).TabIndex = 26;
		Label21.AutoSize = true;
		Label label17 = Label21;
		location = new Point(473, 371);
		((Control)label17).Location = location;
		((Control)Label21).Name = "Label21";
		Label label18 = Label21;
		size = new Size(63, 13);
		((Control)label18).Size = size;
		((Control)Label21).TabIndex = 46;
		Label21.Text = "Tham số 07";
		((Control)txtPar6).Enabled = false;
		TextBox obj13 = txtPar6;
		location = new Point(542, 342);
		((Control)obj13).Location = location;
		((Control)txtPar6).Name = "txtPar6";
		TextBox obj14 = txtPar6;
		size = new Size(231, 20);
		((Control)obj14).Size = size;
		((Control)txtPar6).TabIndex = 25;
		Label20.AutoSize = true;
		Label label19 = Label20;
		location = new Point(473, 345);
		((Control)label19).Location = location;
		((Control)Label20).Name = "Label20";
		Label label20 = Label20;
		size = new Size(63, 13);
		((Control)label20).Size = size;
		((Control)Label20).TabIndex = 44;
		Label20.Text = "Tham số 06";
		((Control)txtPar5).Enabled = false;
		TextBox obj15 = txtPar5;
		location = new Point(542, 316);
		((Control)obj15).Location = location;
		((Control)txtPar5).Name = "txtPar5";
		TextBox obj16 = txtPar5;
		size = new Size(231, 20);
		((Control)obj16).Size = size;
		((Control)txtPar5).TabIndex = 24;
		Label19.AutoSize = true;
		Label label21 = Label19;
		location = new Point(473, 319);
		((Control)label21).Location = location;
		((Control)Label19).Name = "Label19";
		Label label22 = Label19;
		size = new Size(63, 13);
		((Control)label22).Size = size;
		((Control)Label19).TabIndex = 42;
		Label19.Text = "Tham số 05";
		((Control)txtPar4).Enabled = false;
		TextBox obj17 = txtPar4;
		location = new Point(542, 290);
		((Control)obj17).Location = location;
		((Control)txtPar4).Name = "txtPar4";
		TextBox obj18 = txtPar4;
		size = new Size(231, 20);
		((Control)obj18).Size = size;
		((Control)txtPar4).TabIndex = 23;
		Label18.AutoSize = true;
		Label label23 = Label18;
		location = new Point(473, 293);
		((Control)label23).Location = location;
		((Control)Label18).Name = "Label18";
		Label label24 = Label18;
		size = new Size(63, 13);
		((Control)label24).Size = size;
		((Control)Label18).TabIndex = 40;
		Label18.Text = "Tham số 04";
		((Control)txtPar3).Enabled = false;
		TextBox obj19 = txtPar3;
		location = new Point(542, 264);
		((Control)obj19).Location = location;
		((Control)txtPar3).Name = "txtPar3";
		TextBox obj20 = txtPar3;
		size = new Size(231, 20);
		((Control)obj20).Size = size;
		((Control)txtPar3).TabIndex = 22;
		Label17.AutoSize = true;
		Label label25 = Label17;
		location = new Point(473, 267);
		((Control)label25).Location = location;
		((Control)Label17).Name = "Label17";
		Label label26 = Label17;
		size = new Size(63, 13);
		((Control)label26).Size = size;
		((Control)Label17).TabIndex = 38;
		Label17.Text = "Tham số 03";
		((Control)txtPar2).Enabled = false;
		TextBox obj21 = txtPar2;
		location = new Point(542, 238);
		((Control)obj21).Location = location;
		((Control)txtPar2).Name = "txtPar2";
		TextBox obj22 = txtPar2;
		size = new Size(231, 20);
		((Control)obj22).Size = size;
		((Control)txtPar2).TabIndex = 21;
		Label16.AutoSize = true;
		Label label27 = Label16;
		location = new Point(473, 241);
		((Control)label27).Location = location;
		((Control)Label16).Name = "Label16";
		Label label28 = Label16;
		size = new Size(63, 13);
		((Control)label28).Size = size;
		((Control)Label16).TabIndex = 36;
		Label16.Text = "Tham số 02";
		((Control)txtPar1).Enabled = false;
		TextBox obj23 = txtPar1;
		location = new Point(542, 212);
		((Control)obj23).Location = location;
		((Control)txtPar1).Name = "txtPar1";
		TextBox obj24 = txtPar1;
		size = new Size(231, 20);
		((Control)obj24).Size = size;
		((Control)txtPar1).TabIndex = 20;
		Label15.AutoSize = true;
		Label label29 = Label15;
		location = new Point(473, 215);
		((Control)label29).Location = location;
		((Control)Label15).Name = "Label15";
		Label label30 = Label15;
		size = new Size(63, 13);
		((Control)label30).Size = size;
		((Control)Label15).TabIndex = 34;
		Label15.Text = "Tham số 01";
		TextBox obj25 = txtDescription;
		location = new Point(163, 264);
		((Control)obj25).Location = location;
		((Control)txtDescription).Name = "txtDescription";
		TextBox obj26 = txtDescription;
		size = new Size(270, 20);
		((Control)obj26).Size = size;
		((Control)txtDescription).TabIndex = 8;
		Label14.AutoSize = true;
		Label label31 = Label14;
		location = new Point(35, 267);
		((Control)label31).Location = location;
		((Control)Label14).Name = "Label14";
		Label label32 = Label14;
		size = new Size(34, 13);
		((Control)label32).Size = size;
		((Control)Label14).TabIndex = 32;
		Label14.Text = "Mô tả";
		Label13.AutoSize = true;
		Label label33 = Label13;
		location = new Point(35, 241);
		((Control)label33).Location = location;
		((Control)Label13).Name = "Label13";
		Label label34 = Label13;
		size = new Size(72, 13);
		((Control)label34).Size = size;
		((Control)Label13).TabIndex = 30;
		Label13.Text = "Loại chứng từ";
		((ButtonBase)chkCopy_vaora).AutoSize = true;
		chkCopy_vaora.Checked = false;
		((Control)chkCopy_vaora).Enabled = false;
		AsCheckBox asCheckBox = chkCopy_vaora;
		location = new Point(290, 315);
		((Control)asCheckBox).Location = location;
		((Control)chkCopy_vaora).Name = "chkCopy_vaora";
		AsCheckBox asCheckBox2 = chkCopy_vaora;
		size = new Size(131, 17);
		((Control)asCheckBox2).Size = size;
		((Control)chkCopy_vaora).TabIndex = 12;
		((ButtonBase)chkCopy_vaora).Text = "Cho phép copy vào ra";
		chkCopy_vaora.TextValue = "0";
		((ButtonBase)chkCopy_vaora).UseVisualStyleBackColor = true;
		((ButtonBase)chkCopy_enabled).AutoSize = true;
		chkCopy_enabled.Checked = false;
		((Control)chkCopy_enabled).Enabled = false;
		AsCheckBox asCheckBox3 = chkCopy_enabled;
		location = new Point(290, 292);
		((Control)asCheckBox3).Location = location;
		((Control)chkCopy_enabled).Name = "chkCopy_enabled";
		AsCheckBox asCheckBox4 = chkCopy_enabled;
		size = new Size(143, 17);
		((Control)asCheckBox4).Size = size;
		((Control)chkCopy_enabled).TabIndex = 11;
		((ButtonBase)chkCopy_enabled).Text = "Cho phép copy chứng từ";
		chkCopy_enabled.TextValue = "0";
		((ButtonBase)chkCopy_enabled).UseVisualStyleBackColor = true;
		((ButtonBase)chkHas_taout).AutoSize = true;
		chkHas_taout.Checked = false;
		((Control)chkHas_taout).Enabled = false;
		AsCheckBox asCheckBox5 = chkHas_taout;
		location = new Point(38, 315);
		((Control)asCheckBox5).Location = location;
		((Control)chkHas_taout).Name = "chkHas_taout";
		AsCheckBox asCheckBox6 = chkHas_taout;
		size = new Size(135, 17);
		((Control)asCheckBox6).Size = size;
		((Control)chkHas_taout).TabIndex = 10;
		((ButtonBase)chkHas_taout).Text = "Có kê khai thuế đầu ra";
		chkHas_taout.TextValue = "0";
		((ButtonBase)chkHas_taout).UseVisualStyleBackColor = true;
		((ButtonBase)chkHas_tain).AutoSize = true;
		chkHas_tain.Checked = false;
		((Control)chkHas_tain).Enabled = false;
		AsCheckBox asCheckBox7 = chkHas_tain;
		location = new Point(38, 292);
		((Control)asCheckBox7).Location = location;
		((Control)chkHas_tain).Name = "chkHas_tain";
		AsCheckBox asCheckBox8 = chkHas_tain;
		size = new Size(144, 17);
		((Control)asCheckBox8).Size = size;
		((Control)chkHas_tain).TabIndex = 9;
		((ButtonBase)chkHas_tain).Text = "Có kê khai thuế đầu vào";
		chkHas_tain.TextValue = "0";
		((ButtonBase)chkHas_tain).UseVisualStyleBackColor = true;
		((ButtonBase)chkHas_cp).AutoSize = true;
		chkHas_cp.Checked = false;
		((Control)chkHas_cp).Enabled = false;
		AsCheckBox asCheckBox9 = chkHas_cp;
		location = new Point(601, 111);
		((Control)asCheckBox9).Location = location;
		((Control)chkHas_cp).Name = "chkHas_cp";
		AsCheckBox asCheckBox10 = chkHas_cp;
		size = new Size(15, 14);
		((Control)asCheckBox10).Size = size;
		((Control)chkHas_cp).TabIndex = 17;
		chkHas_cp.TextValue = "0";
		((ButtonBase)chkHas_cp).UseVisualStyleBackColor = true;
		Label11.AutoSize = true;
		Label label35 = Label11;
		location = new Point(31, 390);
		((Control)label35).Location = location;
		((Control)Label11).Name = "Label11";
		Label label36 = Label11;
		size = new Size(102, 13);
		((Control)label36).Size = size;
		((Control)Label11).TabIndex = 13;
		Label11.Text = "Số dòng / 1 trang in";
		Label10.AutoSize = true;
		Label label37 = Label10;
		location = new Point(35, 215);
		((Control)label37).Location = location;
		((Control)Label10).Name = "Label10";
		Label label38 = Label10;
		size = new Size(123, 13);
		((Control)label38).Size = size;
		((Control)Label10).TabIndex = 18;
		Label10.Text = "Mã đồng tiền ngầm định";
		((Control)txtPrint_class_name).Enabled = false;
		TextBox obj27 = txtPrint_class_name;
		location = new Point(163, 186);
		((Control)obj27).Location = location;
		((Control)txtPrint_class_name).Name = "txtPrint_class_name";
		TextBox obj28 = txtPrint_class_name;
		size = new Size(270, 20);
		((Control)obj28).Size = size;
		((Control)txtPrint_class_name).TabIndex = 5;
		Label9.AutoSize = true;
		Label label39 = Label9;
		location = new Point(35, 189);
		((Control)label39).Location = location;
		((Control)Label9).Name = "Label9";
		Label label40 = Label9;
		size = new Size(107, 13);
		((Control)label40).Size = size;
		((Control)Label9).TabIndex = 16;
		Label9.Text = "Tên class Form in CT";
		((Control)txtView_class_name).Enabled = false;
		TextBox obj29 = txtView_class_name;
		location = new Point(163, 160);
		((Control)obj29).Location = location;
		((Control)txtView_class_name).Name = "txtView_class_name";
		TextBox obj30 = txtView_class_name;
		size = new Size(270, 20);
		((Control)obj30).Size = size;
		((Control)txtView_class_name).TabIndex = 4;
		Label8.AutoSize = true;
		Label label41 = Label8;
		location = new Point(35, 163);
		((Control)label41).Location = location;
		((Control)Label8).Name = "Label8";
		Label label42 = Label8;
		size = new Size(122, 13);
		((Control)label42).Size = size;
		((Control)Label8).TabIndex = 14;
		Label8.Text = "Tên class Form View CT";
		((Control)txtSearch_class_name).Enabled = false;
		TextBox obj31 = txtSearch_class_name;
		location = new Point(164, 134);
		((Control)obj31).Location = location;
		((Control)txtSearch_class_name).Name = "txtSearch_class_name";
		TextBox obj32 = txtSearch_class_name;
		size = new Size(269, 20);
		((Control)obj32).Size = size;
		((Control)txtSearch_class_name).TabIndex = 3;
		Label7.AutoSize = true;
		Label label43 = Label7;
		location = new Point(35, 137);
		((Control)label43).Location = location;
		((Control)Label7).Name = "Label7";
		Label label44 = Label7;
		size = new Size(112, 13);
		((Control)label44).Size = size;
		((Control)Label7).TabIndex = 12;
		Label7.Text = "Tên class Form tìm CT";
		((Control)txtPH_Extra_Edit_Control_List).Enabled = false;
		TextBox obj33 = txtPH_Extra_Edit_Control_List;
		location = new Point(163, 108);
		((Control)obj33).Location = location;
		((Control)txtPH_Extra_Edit_Control_List).Name = "txtPH_Extra_Edit_Control_List";
		TextBox obj34 = txtPH_Extra_Edit_Control_List;
		size = new Size(100, 20);
		((Control)obj34).Size = size;
		((Control)txtPH_Extra_Edit_Control_List).TabIndex = 2;
		Label6.AutoSize = true;
		Label label45 = Label6;
		location = new Point(35, 111);
		((Control)label45).Location = location;
		((Control)Label6).Name = "Label6";
		Label label46 = Label6;
		size = new Size(110, 13);
		((Control)label46).Size = size;
		((Control)Label6).TabIndex = 10;
		Label6.Text = "DS control dùng thêm";
		Label5.AutoSize = true;
		Label label47 = Label5;
		location = new Point(35, 85);
		((Control)label47).Location = location;
		((Control)Label5).Name = "Label5";
		Label label48 = Label5;
		size = new Size(48, 13);
		((Control)label48).Size = size;
		((Control)Label5).TabIndex = 8;
		Label5.Text = "Menu ID";
		((Control)txtCP_table_name).Enabled = false;
		TextBox obj35 = txtCP_table_name;
		location = new Point(601, 134);
		((Control)obj35).Location = location;
		((Control)txtCP_table_name).Name = "txtCP_table_name";
		TextBox obj36 = txtCP_table_name;
		size = new Size(100, 20);
		((Control)obj36).Size = size;
		((Control)txtCP_table_name).TabIndex = 18;
		Label4.AutoSize = true;
		Label label49 = Label4;
		location = new Point(473, 137);
		((Control)label49).Location = location;
		((Control)Label4).Name = "Label4";
		Label label50 = Label4;
		size = new Size(121, 13);
		((Control)label50).Size = size;
		((Control)Label4).TabIndex = 6;
		Label4.Text = "Tên bảng lưu dữ liệu CP";
		((Control)txtCT_table_name).Enabled = false;
		TextBox obj37 = txtCT_table_name;
		location = new Point(601, 82);
		((Control)obj37).Location = location;
		((Control)txtCT_table_name).Name = "txtCT_table_name";
		TextBox obj38 = txtCT_table_name;
		size = new Size(100, 20);
		((Control)obj38).Size = size;
		((Control)txtCT_table_name).TabIndex = 16;
		lblCT_table_name.AutoSize = true;
		Label obj39 = lblCT_table_name;
		location = new Point(473, 85);
		((Control)obj39).Location = location;
		((Control)lblCT_table_name).Name = "lblCT_table_name";
		Label obj40 = lblCT_table_name;
		size = new Size(121, 13);
		((Control)obj40).Size = size;
		((Control)lblCT_table_name).TabIndex = 4;
		lblCT_table_name.Text = "Tên bảng lưu dữ liệu CT";
		((Control)txtPH_table_name).Enabled = false;
		TextBox obj41 = txtPH_table_name;
		location = new Point(601, 56);
		((Control)obj41).Location = location;
		((Control)txtPH_table_name).Name = "txtPH_table_name";
		TextBox obj42 = txtPH_table_name;
		size = new Size(100, 20);
		((Control)obj42).Size = size;
		((Control)txtPH_table_name).TabIndex = 15;
		lblPH_table_name.AutoSize = true;
		Label obj43 = lblPH_table_name;
		location = new Point(473, 59);
		((Control)obj43).Location = location;
		((Control)lblPH_table_name).Name = "lblPH_table_name";
		Label obj44 = lblPH_table_name;
		size = new Size(122, 13);
		((Control)obj44).Size = size;
		((Control)lblPH_table_name).TabIndex = 2;
		lblPH_table_name.Text = "Tên bảng lưu dữ liệu PH";
		((Control)txtVoucher_code).Enabled = false;
		TextBox obj45 = txtVoucher_code;
		location = new Point(163, 56);
		((Control)obj45).Location = location;
		((Control)txtVoucher_code).Name = "txtVoucher_code";
		TextBox obj46 = txtVoucher_code;
		size = new Size(46, 20);
		((Control)obj46).Size = size;
		((Control)txtVoucher_code).TabIndex = 0;
		Label1.AutoSize = true;
		Label label51 = Label1;
		location = new Point(35, 59);
		((Control)label51).Location = location;
		((Control)Label1).Name = "Label1";
		Label label52 = Label1;
		size = new Size(67, 13);
		((Control)label52).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Mã chứng từ";
		((Control)TabPage2).Controls.Add((Control)(object)Label3);
		((Control)TabPage2).Controls.Add((Control)(object)Label2);
		((Control)TabPage2).Controls.Add((Control)(object)cmdOutAll);
		((Control)TabPage2).Controls.Add((Control)(object)cmdInAll);
		((Control)TabPage2).Controls.Add((Control)(object)cmdOut);
		((Control)TabPage2).Controls.Add((Control)(object)cmdIn);
		((Control)TabPage2).Controls.Add((Control)(object)dgvPH_Carry_in);
		((Control)TabPage2).Controls.Add((Control)(object)dgvPH_Carry_out);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 25);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).Padding = padding;
		TabPage tabPage6 = TabPage2;
		size = new Size(791, 477);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Các trường thông tin chung Carry";
		TabPage2.UseVisualStyleBackColor = true;
		Button obj47 = cmdOutAll;
		location = new Point(372, 261);
		((Control)obj47).Location = location;
		((Control)cmdOutAll).Name = "cmdOutAll";
		Button obj48 = cmdOutAll;
		size = new Size(48, 23);
		((Control)obj48).Size = size;
		((Control)cmdOutAll).TabIndex = 5;
		((ButtonBase)cmdOutAll).Text = "<<";
		((ButtonBase)cmdOutAll).UseVisualStyleBackColor = true;
		Button obj49 = cmdInAll;
		location = new Point(372, 174);
		((Control)obj49).Location = location;
		((Control)cmdInAll).Name = "cmdInAll";
		Button obj50 = cmdInAll;
		size = new Size(48, 23);
		((Control)obj50).Size = size;
		((Control)cmdInAll).TabIndex = 4;
		((ButtonBase)cmdInAll).Text = ">>";
		((ButtonBase)cmdInAll).UseVisualStyleBackColor = true;
		Button obj51 = cmdOut;
		location = new Point(372, 232);
		((Control)obj51).Location = location;
		((Control)cmdOut).Name = "cmdOut";
		Button obj52 = cmdOut;
		size = new Size(48, 23);
		((Control)obj52).Size = size;
		((Control)cmdOut).TabIndex = 3;
		((ButtonBase)cmdOut).Text = "<";
		((ButtonBase)cmdOut).UseVisualStyleBackColor = true;
		Button obj53 = cmdIn;
		location = new Point(372, 203);
		((Control)obj53).Location = location;
		((Control)cmdIn).Name = "cmdIn";
		Button obj54 = cmdIn;
		size = new Size(48, 23);
		((Control)obj54).Size = size;
		((Control)cmdIn).TabIndex = 2;
		((ButtonBase)cmdIn).Text = ">";
		((ButtonBase)cmdIn).UseVisualStyleBackColor = true;
		((DataGridView)dgvPH_Carry_in).AllowUserToAddRows = false;
		((DataGridView)dgvPH_Carry_in).AllowUserToDeleteRows = false;
		((Control)dgvPH_Carry_in).Anchor = (AnchorStyles)11;
		((DataGridView)dgvPH_Carry_in).BackgroundColor = Color.White;
		((DataGridView)dgvPH_Carry_in).BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Carry_in).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)dgvPH_Carry_in).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvPH_Carry_in).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcPHC_Field_in,
			(DataGridViewColumn)dgvcPHC_Field_in_Desc
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvPH_Carry_in).DefaultCellStyle = val2;
		((DataGridView)dgvPH_Carry_in).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV = dgvPH_Carry_in;
		location = new Point(426, 32);
		((Control)asInputDGV).Location = location;
		((Control)dgvPH_Carry_in).Name = "dgvPH_Carry_in";
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Carry_in).RowHeadersDefaultCellStyle = val3;
		((DataGridView)dgvPH_Carry_in).RowTemplate.Height = 20;
		AsInputDGV asInputDGV2 = dgvPH_Carry_in;
		size = new Size(362, 442);
		((Control)asInputDGV2).Size = size;
		((Control)dgvPH_Carry_in).TabIndex = 1;
		((DataGridViewColumn)dgvcPHC_Field_in).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHC_Field_in).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcPHC_Field_in).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcPHC_Field_in).Name = "dgvcPHC_Field_in";
		((DataGridViewColumn)dgvcPHC_Field_in).ReadOnly = true;
		((DataGridViewColumn)dgvcPHC_Field_in).Width = 84;
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).Name = "dgvcPHC_Field_in_Desc";
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcPHC_Field_in_Desc).Width = 73;
		((DataGridView)dgvPH_Carry_out).AllowUserToAddRows = false;
		((DataGridView)dgvPH_Carry_out).AllowUserToDeleteRows = false;
		((Control)dgvPH_Carry_out).Anchor = (AnchorStyles)7;
		((DataGridView)dgvPH_Carry_out).BackgroundColor = Color.White;
		((DataGridView)dgvPH_Carry_out).BorderStyle = (BorderStyle)2;
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Carry_out).ColumnHeadersDefaultCellStyle = val4;
		((DataGridView)dgvPH_Carry_out).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvPH_Carry_out).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcPHC_Field_out,
			(DataGridViewColumn)dgvcPHC_Field_out_Desc
		});
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Window;
		val5.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = SystemColors.ControlText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvPH_Carry_out).DefaultCellStyle = val5;
		((DataGridView)dgvPH_Carry_out).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV3 = dgvPH_Carry_out;
		location = new Point(3, 32);
		((Control)asInputDGV3).Location = location;
		((Control)dgvPH_Carry_out).Name = "dgvPH_Carry_out";
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.BackColor = SystemColors.Control;
		val6.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.ForeColor = SystemColors.WindowText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Carry_out).RowHeadersDefaultCellStyle = val6;
		((DataGridView)dgvPH_Carry_out).RowTemplate.Height = 20;
		AsInputDGV asInputDGV4 = dgvPH_Carry_out;
		size = new Size(362, 442);
		((Control)asInputDGV4).Size = size;
		((Control)dgvPH_Carry_out).TabIndex = 0;
		((DataGridViewColumn)dgvcPHC_Field_out).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHC_Field_out).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcPHC_Field_out).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcPHC_Field_out).Name = "dgvcPHC_Field_out";
		((DataGridViewColumn)dgvcPHC_Field_out).ReadOnly = true;
		((DataGridViewColumn)dgvcPHC_Field_out).Width = 84;
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).Name = "dgvcPHC_Field_out_Desc";
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcPHC_Field_out_Desc).Width = 73;
		((Control)TabPage3).Controls.Add((Control)(object)Label30);
		((Control)TabPage3).Controls.Add((Control)(object)Label12);
		((Control)TabPage3).Controls.Add((Control)(object)cmdCTC_OutAll);
		((Control)TabPage3).Controls.Add((Control)(object)cmdCTC_InAll);
		((Control)TabPage3).Controls.Add((Control)(object)cmdCTC_out);
		((Control)TabPage3).Controls.Add((Control)(object)cmdCTC_in);
		((Control)TabPage3).Controls.Add((Control)(object)dgvCT_Carry_in);
		((Control)TabPage3).Controls.Add((Control)(object)dgvCT_Carry_out);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 25);
		tabPage7.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).Padding = padding;
		TabPage tabPage9 = TabPage3;
		size = new Size(791, 477);
		((Control)tabPage9).Size = size;
		TabPage3.TabIndex = 2;
		TabPage3.Text = "Các trường chi tiết Carry";
		TabPage3.UseVisualStyleBackColor = true;
		Button obj55 = cmdCTC_OutAll;
		location = new Point(372, 261);
		((Control)obj55).Location = location;
		((Control)cmdCTC_OutAll).Name = "cmdCTC_OutAll";
		Button obj56 = cmdCTC_OutAll;
		size = new Size(48, 23);
		((Control)obj56).Size = size;
		((Control)cmdCTC_OutAll).TabIndex = 10;
		((ButtonBase)cmdCTC_OutAll).Text = "<<";
		((ButtonBase)cmdCTC_OutAll).UseVisualStyleBackColor = true;
		Button obj57 = cmdCTC_InAll;
		location = new Point(372, 174);
		((Control)obj57).Location = location;
		((Control)cmdCTC_InAll).Name = "cmdCTC_InAll";
		Button obj58 = cmdCTC_InAll;
		size = new Size(48, 23);
		((Control)obj58).Size = size;
		((Control)cmdCTC_InAll).TabIndex = 9;
		((ButtonBase)cmdCTC_InAll).Text = ">>";
		((ButtonBase)cmdCTC_InAll).UseVisualStyleBackColor = true;
		Button obj59 = cmdCTC_out;
		location = new Point(372, 232);
		((Control)obj59).Location = location;
		((Control)cmdCTC_out).Name = "cmdCTC_out";
		Button obj60 = cmdCTC_out;
		size = new Size(48, 23);
		((Control)obj60).Size = size;
		((Control)cmdCTC_out).TabIndex = 8;
		((ButtonBase)cmdCTC_out).Text = "<";
		((ButtonBase)cmdCTC_out).UseVisualStyleBackColor = true;
		Button obj61 = cmdCTC_in;
		location = new Point(372, 203);
		((Control)obj61).Location = location;
		((Control)cmdCTC_in).Name = "cmdCTC_in";
		Button obj62 = cmdCTC_in;
		size = new Size(48, 23);
		((Control)obj62).Size = size;
		((Control)cmdCTC_in).TabIndex = 7;
		((ButtonBase)cmdCTC_in).Text = ">";
		((ButtonBase)cmdCTC_in).UseVisualStyleBackColor = true;
		((DataGridView)dgvCT_Carry_in).AllowUserToAddRows = false;
		((DataGridView)dgvCT_Carry_in).AllowUserToDeleteRows = false;
		((DataGridView)dgvCT_Carry_in).BackgroundColor = Color.White;
		((DataGridView)dgvCT_Carry_in).BorderStyle = (BorderStyle)2;
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Control;
		val7.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = SystemColors.WindowText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCT_Carry_in).ColumnHeadersDefaultCellStyle = val7;
		((DataGridView)dgvCT_Carry_in).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCT_Carry_in).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcCTC_Field_in,
			(DataGridViewColumn)dgvcCTC_Field_in_Desc
		});
		val8.Alignment = (DataGridViewContentAlignment)16;
		val8.BackColor = SystemColors.Window;
		val8.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = SystemColors.ControlText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvCT_Carry_in).DefaultCellStyle = val8;
		((DataGridView)dgvCT_Carry_in).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV5 = dgvCT_Carry_in;
		location = new Point(426, 32);
		((Control)asInputDGV5).Location = location;
		((Control)dgvCT_Carry_in).Name = "dgvCT_Carry_in";
		val9.Alignment = (DataGridViewContentAlignment)32;
		val9.BackColor = SystemColors.Control;
		val9.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val9.ForeColor = SystemColors.WindowText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCT_Carry_in).RowHeadersDefaultCellStyle = val9;
		((DataGridView)dgvCT_Carry_in).RowTemplate.Height = 20;
		AsInputDGV asInputDGV6 = dgvCT_Carry_in;
		size = new Size(362, 442);
		((Control)asInputDGV6).Size = size;
		((Control)dgvCT_Carry_in).TabIndex = 6;
		((DataGridViewColumn)dgvcCTC_Field_in).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcCTC_Field_in).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcCTC_Field_in).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcCTC_Field_in).Name = "dgvcCTC_Field_in";
		((DataGridViewColumn)dgvcCTC_Field_in).ReadOnly = true;
		((DataGridViewColumn)dgvcCTC_Field_in).Width = 84;
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).Name = "dgvcCTC_Field_in_Desc";
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcCTC_Field_in_Desc).Width = 73;
		((DataGridView)dgvCT_Carry_out).AllowUserToAddRows = false;
		((DataGridView)dgvCT_Carry_out).AllowUserToDeleteRows = false;
		((DataGridView)dgvCT_Carry_out).BackgroundColor = Color.White;
		((DataGridView)dgvCT_Carry_out).BorderStyle = (BorderStyle)2;
		val10.Alignment = (DataGridViewContentAlignment)16;
		val10.BackColor = SystemColors.Control;
		val10.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.ForeColor = SystemColors.WindowText;
		val10.SelectionBackColor = SystemColors.Highlight;
		val10.SelectionForeColor = SystemColors.HighlightText;
		val10.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCT_Carry_out).ColumnHeadersDefaultCellStyle = val10;
		((DataGridView)dgvCT_Carry_out).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvCT_Carry_out).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcCTC_Field_out,
			(DataGridViewColumn)dgvcCTC_Field_out_Desc
		});
		val11.Alignment = (DataGridViewContentAlignment)16;
		val11.BackColor = SystemColors.Window;
		val11.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val11.ForeColor = SystemColors.ControlText;
		val11.SelectionBackColor = SystemColors.Highlight;
		val11.SelectionForeColor = SystemColors.HighlightText;
		val11.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvCT_Carry_out).DefaultCellStyle = val11;
		((DataGridView)dgvCT_Carry_out).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV7 = dgvCT_Carry_out;
		location = new Point(3, 32);
		((Control)asInputDGV7).Location = location;
		((Control)dgvCT_Carry_out).Name = "dgvCT_Carry_out";
		val12.Alignment = (DataGridViewContentAlignment)32;
		val12.BackColor = SystemColors.Control;
		val12.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val12.ForeColor = SystemColors.WindowText;
		val12.SelectionBackColor = SystemColors.Highlight;
		val12.SelectionForeColor = SystemColors.HighlightText;
		val12.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvCT_Carry_out).RowHeadersDefaultCellStyle = val12;
		((DataGridView)dgvCT_Carry_out).RowTemplate.Height = 20;
		AsInputDGV asInputDGV8 = dgvCT_Carry_out;
		size = new Size(362, 442);
		((Control)asInputDGV8).Size = size;
		((Control)dgvCT_Carry_out).TabIndex = 1;
		((DataGridViewColumn)dgvcCTC_Field_out).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcCTC_Field_out).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcCTC_Field_out).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcCTC_Field_out).Name = "dgvcCTC_Field_out";
		((DataGridViewColumn)dgvcCTC_Field_out).ReadOnly = true;
		((DataGridViewColumn)dgvcCTC_Field_out).Width = 84;
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).Name = "dgvcCTC_Field_out_Desc";
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcCTC_Field_out_Desc).Width = 73;
		((Control)TabPage4).Controls.Add((Control)(object)Label32);
		((Control)TabPage4).Controls.Add((Control)(object)Label31);
		((Control)TabPage4).Controls.Add((Control)(object)cmdPHP_OutAll);
		((Control)TabPage4).Controls.Add((Control)(object)cmdPHP_InAll);
		((Control)TabPage4).Controls.Add((Control)(object)cmdPHP_out);
		((Control)TabPage4).Controls.Add((Control)(object)cmdPHP_In);
		((Control)TabPage4).Controls.Add((Control)(object)dgvPH_Print_in);
		((Control)TabPage4).Controls.Add((Control)(object)dgvPH_Print_out);
		TabPage tabPage10 = TabPage4;
		location = new Point(4, 25);
		tabPage10.Location = location;
		((Control)TabPage4).Name = "TabPage4";
		TabPage tabPage11 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).Padding = padding;
		TabPage tabPage12 = TabPage4;
		size = new Size(791, 477);
		((Control)tabPage12).Size = size;
		TabPage4.TabIndex = 3;
		TabPage4.Text = "In các trường thông tin chung ";
		TabPage4.UseVisualStyleBackColor = true;
		Button obj63 = cmdPHP_OutAll;
		location = new Point(372, 261);
		((Control)obj63).Location = location;
		((Control)cmdPHP_OutAll).Name = "cmdPHP_OutAll";
		Button obj64 = cmdPHP_OutAll;
		size = new Size(48, 23);
		((Control)obj64).Size = size;
		((Control)cmdPHP_OutAll).TabIndex = 10;
		((ButtonBase)cmdPHP_OutAll).Text = "<<";
		((ButtonBase)cmdPHP_OutAll).UseVisualStyleBackColor = true;
		Button obj65 = cmdPHP_InAll;
		location = new Point(372, 174);
		((Control)obj65).Location = location;
		((Control)cmdPHP_InAll).Name = "cmdPHP_InAll";
		Button obj66 = cmdPHP_InAll;
		size = new Size(48, 23);
		((Control)obj66).Size = size;
		((Control)cmdPHP_InAll).TabIndex = 9;
		((ButtonBase)cmdPHP_InAll).Text = ">>";
		((ButtonBase)cmdPHP_InAll).UseVisualStyleBackColor = true;
		Button obj67 = cmdPHP_out;
		location = new Point(372, 232);
		((Control)obj67).Location = location;
		((Control)cmdPHP_out).Name = "cmdPHP_out";
		Button obj68 = cmdPHP_out;
		size = new Size(48, 23);
		((Control)obj68).Size = size;
		((Control)cmdPHP_out).TabIndex = 8;
		((ButtonBase)cmdPHP_out).Text = "<";
		((ButtonBase)cmdPHP_out).UseVisualStyleBackColor = true;
		Button obj69 = cmdPHP_In;
		location = new Point(372, 203);
		((Control)obj69).Location = location;
		((Control)cmdPHP_In).Name = "cmdPHP_In";
		Button obj70 = cmdPHP_In;
		size = new Size(48, 23);
		((Control)obj70).Size = size;
		((Control)cmdPHP_In).TabIndex = 7;
		((ButtonBase)cmdPHP_In).Text = ">";
		((ButtonBase)cmdPHP_In).UseVisualStyleBackColor = true;
		((DataGridView)dgvPH_Print_in).AllowUserToAddRows = false;
		((DataGridView)dgvPH_Print_in).AllowUserToDeleteRows = false;
		((DataGridView)dgvPH_Print_in).BackgroundColor = Color.White;
		((DataGridView)dgvPH_Print_in).BorderStyle = (BorderStyle)2;
		val13.Alignment = (DataGridViewContentAlignment)16;
		val13.BackColor = SystemColors.Control;
		val13.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val13.ForeColor = SystemColors.WindowText;
		val13.SelectionBackColor = SystemColors.Highlight;
		val13.SelectionForeColor = SystemColors.HighlightText;
		val13.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Print_in).ColumnHeadersDefaultCellStyle = val13;
		((DataGridView)dgvPH_Print_in).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvPH_Print_in).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcPHP_Field_in,
			(DataGridViewColumn)dgvcPHP_Field_in_Desc
		});
		val14.Alignment = (DataGridViewContentAlignment)16;
		val14.BackColor = SystemColors.Window;
		val14.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val14.ForeColor = SystemColors.ControlText;
		val14.SelectionBackColor = SystemColors.Highlight;
		val14.SelectionForeColor = SystemColors.HighlightText;
		val14.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvPH_Print_in).DefaultCellStyle = val14;
		((DataGridView)dgvPH_Print_in).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV9 = dgvPH_Print_in;
		location = new Point(426, 32);
		((Control)asInputDGV9).Location = location;
		((Control)dgvPH_Print_in).Name = "dgvPH_Print_in";
		val15.Alignment = (DataGridViewContentAlignment)32;
		val15.BackColor = SystemColors.Control;
		val15.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val15.ForeColor = SystemColors.WindowText;
		val15.SelectionBackColor = SystemColors.Highlight;
		val15.SelectionForeColor = SystemColors.HighlightText;
		val15.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Print_in).RowHeadersDefaultCellStyle = val15;
		((DataGridView)dgvPH_Print_in).RowTemplate.Height = 20;
		AsInputDGV asInputDGV10 = dgvPH_Print_in;
		size = new Size(362, 442);
		((Control)asInputDGV10).Size = size;
		((Control)dgvPH_Print_in).TabIndex = 6;
		((DataGridViewColumn)dgvcPHP_Field_in).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHP_Field_in).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcPHP_Field_in).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcPHP_Field_in).Name = "dgvcPHP_Field_in";
		((DataGridViewColumn)dgvcPHP_Field_in).Width = 84;
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).Name = "dgvcPHP_Field_in_Desc";
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcPHP_Field_in_Desc).Width = 73;
		((DataGridView)dgvPH_Print_out).AllowUserToAddRows = false;
		((DataGridView)dgvPH_Print_out).AllowUserToDeleteRows = false;
		((DataGridView)dgvPH_Print_out).BackgroundColor = Color.White;
		((DataGridView)dgvPH_Print_out).BorderStyle = (BorderStyle)2;
		val16.Alignment = (DataGridViewContentAlignment)16;
		val16.BackColor = SystemColors.Control;
		val16.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val16.ForeColor = SystemColors.WindowText;
		val16.SelectionBackColor = SystemColors.Highlight;
		val16.SelectionForeColor = SystemColors.HighlightText;
		val16.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Print_out).ColumnHeadersDefaultCellStyle = val16;
		((DataGridView)dgvPH_Print_out).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)dgvPH_Print_out).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)dgvcPHP_Field_out,
			(DataGridViewColumn)dgvcPHP_Field_out_Desc
		});
		val17.Alignment = (DataGridViewContentAlignment)16;
		val17.BackColor = SystemColors.Window;
		val17.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val17.ForeColor = SystemColors.ControlText;
		val17.SelectionBackColor = SystemColors.Highlight;
		val17.SelectionForeColor = SystemColors.HighlightText;
		val17.WrapMode = (DataGridViewTriState)2;
		((DataGridView)dgvPH_Print_out).DefaultCellStyle = val17;
		((DataGridView)dgvPH_Print_out).GridColor = SystemColors.Control;
		AsInputDGV asInputDGV11 = dgvPH_Print_out;
		location = new Point(3, 32);
		((Control)asInputDGV11).Location = location;
		((Control)dgvPH_Print_out).Name = "dgvPH_Print_out";
		val18.Alignment = (DataGridViewContentAlignment)32;
		val18.BackColor = SystemColors.Control;
		val18.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val18.ForeColor = SystemColors.WindowText;
		val18.SelectionBackColor = SystemColors.Highlight;
		val18.SelectionForeColor = SystemColors.HighlightText;
		val18.WrapMode = (DataGridViewTriState)1;
		((DataGridView)dgvPH_Print_out).RowHeadersDefaultCellStyle = val18;
		((DataGridView)dgvPH_Print_out).RowTemplate.Height = 20;
		AsInputDGV asInputDGV12 = dgvPH_Print_out;
		size = new Size(362, 442);
		((Control)asInputDGV12).Size = size;
		((Control)dgvPH_Print_out).TabIndex = 1;
		((DataGridViewColumn)dgvcPHP_Field_out).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHP_Field_out).DataPropertyName = "data_field";
		((DataGridViewColumn)dgvcPHP_Field_out).HeaderText = "Tên trường";
		((DataGridViewColumn)dgvcPHP_Field_out).Name = "dgvcPHP_Field_out";
		((DataGridViewColumn)dgvcPHP_Field_out).ReadOnly = true;
		((DataGridViewColumn)dgvcPHP_Field_out).Width = 84;
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).AutoSizeMode = (DataGridViewAutoSizeColumnMode)6;
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).DataPropertyName = "field_desc";
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).HeaderText = "Diễn giải";
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).Name = "dgvcPHP_Field_out_Desc";
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).ReadOnly = true;
		((DataGridViewColumn)dgvcPHP_Field_out_Desc).Width = 73;
		((Control)cmdCancel).Anchor = (AnchorStyles)6;
		cmdCancel.DialogResult = (DialogResult)2;
		((ButtonBase)cmdCancel).Image = (Image)componentResourceManager.GetObject("cmdCancel.Image");
		((ButtonBase)cmdCancel).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdCancel).ImeMode = (ImeMode)0;
		Button obj71 = cmdCancel;
		location = new Point(93, 520);
		((Control)obj71).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		Button obj72 = cmdCancel;
		size = new Size(75, 23);
		((Control)obj72).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "&Huỷ";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)64;
		((Control)cmdOK).Anchor = (AnchorStyles)6;
		((ButtonBase)cmdOK).Image = (Image)(object)Resources.save;
		((ButtonBase)cmdOK).ImageAlign = (ContentAlignment)16;
		((ButtonBase)cmdOK).ImeMode = (ImeMode)0;
		Button obj73 = cmdOK;
		location = new Point(12, 520);
		((Control)obj73).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		Button obj74 = cmdOK;
		size = new Size(75, 23);
		((Control)obj74).Size = size;
		((Control)cmdOK).TabIndex = 1;
		((ButtonBase)cmdOK).Text = "&Nhận";
		((ButtonBase)cmdOK).TextAlign = (ContentAlignment)64;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label53 = Label2;
		location = new Point(6, 11);
		((Control)label53).Location = location;
		((Control)Label2).Name = "Label2";
		Label label54 = Label2;
		size = new Size(167, 16);
		((Control)label54).Size = size;
		((Control)Label2).TabIndex = 6;
		Label2.Text = "Các trường không carry";
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label55 = Label3;
		location = new Point(423, 11);
		((Control)label55).Location = location;
		((Control)Label3).Name = "Label3";
		Label label56 = Label3;
		size = new Size(159, 16);
		((Control)label56).Size = size;
		((Control)Label3).TabIndex = 7;
		Label3.Text = "Các trường được carry";
		Label12.AutoSize = true;
		((Control)Label12).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label57 = Label12;
		location = new Point(6, 11);
		((Control)label57).Location = location;
		((Control)Label12).Name = "Label12";
		Label label58 = Label12;
		size = new Size(167, 16);
		((Control)label58).Size = size;
		((Control)Label12).TabIndex = 11;
		Label12.Text = "Các trường không carry";
		Label30.AutoSize = true;
		((Control)Label30).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label59 = Label30;
		location = new Point(423, 11);
		((Control)label59).Location = location;
		((Control)Label30).Name = "Label30";
		Label label60 = Label30;
		size = new Size(159, 16);
		((Control)label60).Size = size;
		((Control)Label30).TabIndex = 12;
		Label30.Text = "Các trường được carry";
		Label31.AutoSize = true;
		((Control)Label31).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label61 = Label31;
		location = new Point(6, 11);
		((Control)label61).Location = location;
		((Control)Label31).Name = "Label31";
		Label label62 = Label31;
		size = new Size(144, 16);
		((Control)label62).Size = size;
		((Control)Label31).TabIndex = 11;
		Label31.Text = "Các trường không in";
		Label32.AutoSize = true;
		((Control)Label32).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)163);
		Label label63 = Label32;
		location = new Point(423, 11);
		((Control)label63).Location = location;
		((Control)Label32).Name = "Label32";
		Label label64 = Label32;
		size = new Size(136, 16);
		((Control)label64).Size = size;
		((Control)Label32).TabIndex = 12;
		Label32.Text = "Các trường được in";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		size = new Size(823, 547);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)AsTabControl1);
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)163);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmVoucherUpdInfo";
		((Form)this).Text = "Khai báo chứng từ";
		((Control)AsTabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((ISupportInitialize)dgvPH_Carry_in).EndInit();
		((ISupportInitialize)dgvPH_Carry_out).EndInit();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((ISupportInitialize)dgvCT_Carry_in).EndInit();
		((ISupportInitialize)dgvCT_Carry_out).EndInit();
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage4).PerformLayout();
		((ISupportInitialize)dgvPH_Print_in).EndInit();
		((ISupportInitialize)dgvPH_Print_out).EndInit();
		((ISupportInitialize)bsVoucherInfo).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmVoucherUpdInfo_Load(object sender, EventArgs e)
	{
		InitBeforeLoadData();
		if (MyVoucherInfo != null)
		{
			DataTable dataTable = new DataTable();
			FieldInfo[] fields = MyVoucherInfo.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			FieldInfo[] array = fields;
			foreach (FieldInfo fieldInfo in array)
			{
				dataTable.Columns.Add(fieldInfo.Name.Substring(1), fieldInfo.FieldType);
			}
			DataRow dataRow = dataTable.NewRow();
			FieldInfo[] array2 = fields;
			foreach (FieldInfo fieldInfo2 in array2)
			{
				dataRow[fieldInfo2.Name.Substring(1)] = RuntimeHelpers.GetObjectValue(fieldInfo2.GetValue(MyVoucherInfo));
			}
			dataTable.Rows.Add(dataRow);
			f_oDrwEdit = dataRow;
			CoreDataBinding();
			DataBinding();
			((DataGridView)dgvPH_Carry_in).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvPH_Carry_in).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			((DataGridView)dgvPH_Carry_out).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvPH_Carry_out).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			((DataGridView)dgvCT_Carry_in).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvCT_Carry_in).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			((DataGridView)dgvCT_Carry_out).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvCT_Carry_out).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			((DataGridView)dgvPH_Print_in).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvPH_Print_in).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			((DataGridView)dgvPH_Print_out).DefaultCellStyle.BackColor = ClientConfiguration.DM_BakgroundColor;
			((DataGridView)dgvPH_Print_out).AlternatingRowsDefaultCellStyle.BackColor = ClientConfiguration.DM_AlternatingBackColor;
			Get_Field_Desc();
			GetDataPH_Carry();
			GetDataPH_Print();
			GetDataCT_Carry();
			RefreshButton();
		}
	}

	private void frmVoucherUpdInfo_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		GetFieldToUpdate();
		if (UpdateToDB())
		{
			((Component)(object)this).Dispose();
		}
	}

	private void cmdIn_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvPH_Carry_out).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblPH_Carry_in.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHC_Field_out).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHC_Field_out_Desc).Name].Value);
			f_oTblPH_Carry_in.Rows.Add(dataRow);
			((DataGridView)dgvPH_Carry_out).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdOut_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvPH_Carry_in).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblPH_Carry_out.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHC_Field_in).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHC_Field_in_Desc).Name].Value);
			f_oTblPH_Carry_out.Rows.Add(dataRow);
			((DataGridView)dgvPH_Carry_in).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdInAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblPH_Carry_out.Rows)
		{
			f_oTblPH_Carry_in.ImportRow(row);
		}
		f_oTblPH_Carry_out.Clear();
		RefreshButton();
	}

	private void cmdOutAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblPH_Carry_in.Rows)
		{
			f_oTblPH_Carry_out.ImportRow(row);
		}
		f_oTblPH_Carry_in.Clear();
		RefreshButton();
	}

	private void cmdCTC_InAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblCT_Carry_out.Rows)
		{
			f_oTblCT_Carry_in.ImportRow(row);
		}
		f_oTblCT_Carry_out.Clear();
		RefreshButton();
	}

	private void cmdCTC_in_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvCT_Carry_out).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblCT_Carry_in.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcCTC_Field_out).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcCTC_Field_out_Desc).Name].Value);
			f_oTblCT_Carry_in.Rows.Add(dataRow);
			((DataGridView)dgvCT_Carry_out).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdCTC_out_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvCT_Carry_in).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblCT_Carry_out.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcCTC_Field_in).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcCTC_Field_in_Desc).Name].Value);
			f_oTblCT_Carry_out.Rows.Add(dataRow);
			((DataGridView)dgvCT_Carry_in).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdCTC_OutAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblCT_Carry_in.Rows)
		{
			f_oTblCT_Carry_out.ImportRow(row);
		}
		f_oTblCT_Carry_in.Clear();
		RefreshButton();
	}

	private void cmdPHP_InAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblPH_Print_out.Rows)
		{
			f_oTblPH_Print_in.ImportRow(row);
		}
		f_oTblPH_Print_out.Clear();
		RefreshButton();
	}

	private void cmdPHP_In_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvPH_Print_out).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblPH_Print_in.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHP_Field_out).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHP_Field_out_Desc).Name].Value);
			f_oTblPH_Print_in.Rows.Add(dataRow);
			((DataGridView)dgvPH_Print_out).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdPHP_out_Click(object sender, EventArgs e)
	{
		DataGridViewRow currentRow = ((DataGridView)dgvPH_Print_in).CurrentRow;
		if (currentRow != null)
		{
			DataRow dataRow = f_oTblPH_Print_out.NewRow();
			dataRow["data_field"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHP_Field_in).Name].Value);
			dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(currentRow.Cells[((DataGridViewColumn)dgvcPHP_Field_in_Desc).Name].Value);
			f_oTblPH_Print_out.Rows.Add(dataRow);
			((DataGridView)dgvPH_Print_in).Rows.Remove(currentRow);
			RefreshButton();
		}
	}

	private void cmdPHP_OutAll_Click(object sender, EventArgs e)
	{
		foreach (DataRow row in f_oTblPH_Print_in.Rows)
		{
			f_oTblPH_Print_out.ImportRow(row);
		}
		f_oTblPH_Print_in.Clear();
		RefreshButton();
	}

	private void InitBeforeLoadData()
	{
		LoadComboNXT();
	}

	private void CoreDataBinding()
	{
		bsVoucherInfo.DataSource = f_oDrwEdit.Table.DefaultView;
	}

	protected void CreateDataBinding(ref Control ojb, string dbFieldName, string propertyName = "Text")
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		try
		{
			if ((f_oDrwEdit != null && f_oDrwEdit.Table != null && f_oDrwEdit.Table.Columns.Contains(dbFieldName)) ? true : false)
			{
				Binding val = new Binding(propertyName, (object)bsVoucherInfo, dbFieldName);
				val.DataSourceUpdateMode = (DataSourceUpdateMode)0;
				val.ControlUpdateMode = (ControlUpdateMode)0;
				ojb.DataBindings.Add(val);
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

	protected void DataBinding()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		Control ojb = (Control)(object)txtVoucher_code;
		CreateDataBinding(ref ojb, "voucher_code");
		txtVoucher_code = (TextBox)ojb;
		ojb = (Control)(object)txtMenuid;
		CreateDataBinding(ref ojb, "menuid");
		txtMenuid = (MaskedTextBox)ojb;
		ojb = (Control)(object)txtPH_Extra_Edit_Control_List;
		CreateDataBinding(ref ojb, "ph_extra_edit_control_list");
		txtPH_Extra_Edit_Control_List = (TextBox)ojb;
		ojb = (Control)(object)txtSearch_class_name;
		CreateDataBinding(ref ojb, "search_class_name");
		txtSearch_class_name = (TextBox)ojb;
		ojb = (Control)(object)txtView_class_name;
		CreateDataBinding(ref ojb, "view_class_name");
		txtView_class_name = (TextBox)ojb;
		ojb = (Control)(object)txtPrint_class_name;
		CreateDataBinding(ref ojb, "print_class_name");
		txtPrint_class_name = (TextBox)ojb;
		ojb = (Control)(object)cboMa_nt_default;
		CreateDataBinding(ref ojb, "ma_nt_default", "MA_NT");
		cboMa_nt_default = (AsComboBoxNT)(object)ojb;
		ojb = (Control)(object)cboNxt;
		CreateDataBinding(ref ojb, "nxt", "SelectedValue");
		cboNxt = (ComboBox)ojb;
		ojb = (Control)(object)txtDescription;
		CreateDataBinding(ref ojb, "Description");
		txtDescription = (TextBox)ojb;
		ojb = (Control)(object)chkHas_tain;
		CreateDataBinding(ref ojb, "has_tain", "Checked");
		chkHas_tain = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkHas_taout;
		CreateDataBinding(ref ojb, "has_taout", "Checked");
		chkHas_taout = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkCopy_enabled;
		CreateDataBinding(ref ojb, "copy_enable", "Checked");
		chkCopy_enabled = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)chkCopy_vaora;
		CreateDataBinding(ref ojb, "copy_vaora", "Checked");
		chkCopy_vaora = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtRow_per_page;
		CreateDataBinding(ref ojb, "row_per_page", "Value");
		txtRow_per_page = (AsTextNumeric)(object)ojb;
		ojb = (Control)(object)txtPH_table_name;
		CreateDataBinding(ref ojb, "PH_table_name");
		txtPH_table_name = (TextBox)ojb;
		ojb = (Control)(object)txtCT_table_name;
		CreateDataBinding(ref ojb, "CT_table_name");
		txtCT_table_name = (TextBox)ojb;
		ojb = (Control)(object)txtCP_table_name;
		CreateDataBinding(ref ojb, "CP_table_name");
		txtCP_table_name = (TextBox)ojb;
		ojb = (Control)(object)chkHas_cp;
		CreateDataBinding(ref ojb, "has_cp", "Checked");
		chkHas_cp = (AsCheckBox)(object)ojb;
		ojb = (Control)(object)txtPar0;
		CreateDataBinding(ref ojb, "par0");
		txtPar0 = (TextBox)ojb;
		ojb = (Control)(object)txtPar1;
		CreateDataBinding(ref ojb, "par1");
		txtPar1 = (TextBox)ojb;
		ojb = (Control)(object)txtPar2;
		CreateDataBinding(ref ojb, "par2");
		txtPar2 = (TextBox)ojb;
		ojb = (Control)(object)txtPar3;
		CreateDataBinding(ref ojb, "par3");
		txtPar3 = (TextBox)ojb;
		ojb = (Control)(object)txtPar4;
		CreateDataBinding(ref ojb, "par4");
		txtPar4 = (TextBox)ojb;
		ojb = (Control)(object)txtPar5;
		CreateDataBinding(ref ojb, "par5");
		txtPar5 = (TextBox)ojb;
		ojb = (Control)(object)txtPar6;
		CreateDataBinding(ref ojb, "par6");
		txtPar6 = (TextBox)ojb;
		ojb = (Control)(object)txtPar7;
		CreateDataBinding(ref ojb, "par7");
		txtPar7 = (TextBox)ojb;
		ojb = (Control)(object)txtPar8;
		CreateDataBinding(ref ojb, "par8");
		txtPar8 = (TextBox)ojb;
		ojb = (Control)(object)txtPar9;
		CreateDataBinding(ref ojb, "par9");
		txtPar9 = (TextBox)ojb;
	}

	private bool UpdateToDB()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		VOUCHERDAO vOUCHERDAO = (VOUCHERDAO)DAOFactory.CreateDAOInstance("VOUCHERDAO", "SIDMCT", a_blnIsSysDB: true);
		int num = vOUCHERDAO.UpdateToDB(f_oDrwEdit);
		if (num == 0)
		{
			CMessageBox.Show(50015);
			return true;
		}
		CMessageBox.Show(num);
		return false;
	}

	protected void LoadComboNXT()
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		Hashtable hashtable = new Hashtable();
		hashtable.Add("", "");
		hashtable.Add("1", "Nhập");
		hashtable.Add("2", "Xuất");
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("nxt", typeof(string));
		dataTable.Columns.Add("ten_nxt", typeof(string));
		DataRow dataRow = dataTable.NewRow();
		dataRow["nxt"] = "";
		dataRow["ten_nxt"] = "";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["nxt"] = "1";
		dataRow["ten_nxt"] = "Nhập";
		dataTable.Rows.Add(dataRow);
		dataRow = dataTable.NewRow();
		dataRow["nxt"] = "2";
		dataRow["ten_nxt"] = "Xuất";
		dataTable.Rows.Add(dataRow);
		BindingSource val = new BindingSource();
		val.DataSource = dataTable;
		cboNxt.DataSource = val;
		((ListControl)cboNxt).ValueMember = "nxt";
		((ListControl)cboNxt).DisplayMember = "ten_nxt";
	}

	protected void GetDataPH_Carry()
	{
		List<string> list = new List<string>();
		f_oTblPH = MyController.GetDataPH(CompanyInformations.CompanyID, "", MyVoucherInfo.voucher_code).Clone();
		string ph_carry_field_list = MyVoucherInfo.ph_carry_field_list;
		string[] array = ph_carry_field_list.Split(new char[1] { ',' });
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (f_oTblPH.Columns.Contains(array[num2]))
				{
					list.Add(array[num2].ToUpper());
				}
				num2++;
			}
			f_oTblPH_Carry_out = new DataTable("PH_Carry_out");
			f_oTblPH_Carry_out.Columns.Add("data_field", typeof(string));
			f_oTblPH_Carry_out.Columns.Add("field_desc", typeof(string));
			f_oTblPH_Carry_in = new DataTable("PH_Carry_in");
			f_oTblPH_Carry_in.Columns.Add("data_field", typeof(string));
			f_oTblPH_Carry_in.Columns.Add("field_desc", typeof(string));
			DataColumn[] primaryKey = new DataColumn[1] { f_oTblPH_Carry_out.Columns["Field_Name"] };
			DataColumn[] primaryKey2 = new DataColumn[1] { f_oTblPH_Carry_in.Columns["Field_Name"] };
			f_oTblPH_Carry_out.PrimaryKey = primaryKey;
			f_oTblPH_Carry_in.PrimaryKey = primaryKey2;
			foreach (DataColumn column in f_oTblPH.Columns)
			{
				if (list.Contains(column.ColumnName.ToUpper()))
				{
					DataRow dataRow = f_oTblPH_Carry_in.NewRow();
					dataRow["data_field"] = column.ColumnName;
					if (f_hstPH_Field_Desc.Contains(column.ColumnName))
					{
						dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstPH_Field_Desc[column.ColumnName]);
					}
					f_oTblPH_Carry_in.Rows.Add(dataRow);
				}
				else
				{
					DataRow dataRow2 = f_oTblPH_Carry_out.NewRow();
					dataRow2["data_field"] = column.ColumnName;
					if (f_hstPH_Field_Desc.Contains(column.ColumnName))
					{
						dataRow2["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstPH_Field_Desc[column.ColumnName]);
					}
					f_oTblPH_Carry_out.Rows.Add(dataRow2);
				}
			}
			((DataGridView)dgvPH_Carry_out).DataSource = f_oTblPH_Carry_out;
			((DataGridView)dgvPH_Carry_in).DataSource = f_oTblPH_Carry_in;
		}
	}

	protected void GetDataPH_Print()
	{
		List<string> list = new List<string>();
		f_oTblPH = MyController.GetDataPH(CompanyInformations.CompanyID, "", MyVoucherInfo.voucher_code).Clone();
		string ph_print_field_list = MyVoucherInfo.ph_print_field_list;
		string[] array = ph_print_field_list.Split(new char[1] { ',' });
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (f_oTblPH.Columns.Contains(array[num2]))
				{
					list.Add(array[num2].ToUpper());
				}
				num2++;
			}
			f_oTblPH_Print_out = new DataTable("PH_Carry_out");
			f_oTblPH_Print_out.Columns.Add("data_field", typeof(string));
			f_oTblPH_Print_out.Columns.Add("field_desc", typeof(string));
			f_oTblPH_Print_in = new DataTable("PH_Carry_in");
			f_oTblPH_Print_in.Columns.Add("data_field", typeof(string));
			f_oTblPH_Print_in.Columns.Add("field_desc", typeof(string));
			DataColumn[] primaryKey = new DataColumn[1] { f_oTblPH_Print_out.Columns["Field_Name"] };
			DataColumn[] primaryKey2 = new DataColumn[1] { f_oTblPH_Print_in.Columns["Field_Name"] };
			f_oTblPH_Print_out.PrimaryKey = primaryKey;
			f_oTblPH_Print_in.PrimaryKey = primaryKey2;
			foreach (DataColumn column in f_oTblPH.Columns)
			{
				if (list.Contains(column.ColumnName.ToUpper()))
				{
					DataRow dataRow = f_oTblPH_Print_in.NewRow();
					dataRow["data_field"] = column.ColumnName;
					if (f_hstPH_Field_Desc.Contains(column.ColumnName))
					{
						dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstPH_Field_Desc[column.ColumnName]);
					}
					f_oTblPH_Print_in.Rows.Add(dataRow);
				}
				else
				{
					DataRow dataRow2 = f_oTblPH_Print_out.NewRow();
					dataRow2["data_field"] = column.ColumnName;
					if (f_hstPH_Field_Desc.Contains(column.ColumnName))
					{
						dataRow2["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstPH_Field_Desc[column.ColumnName]);
					}
					f_oTblPH_Print_out.Rows.Add(dataRow2);
				}
			}
			((DataGridView)dgvPH_Print_out).DataSource = f_oTblPH_Print_out;
			((DataGridView)dgvPH_Print_in).DataSource = f_oTblPH_Print_in;
		}
	}

	protected void GetDataCT_Carry()
	{
		List<string> list = new List<string>();
		f_oTblCT = MyController.GetDataCT(CompanyInformations.CompanyID, "").Clone();
		string ct_carry_field_list = MyVoucherInfo.ct_carry_field_list;
		string[] array = ct_carry_field_list.Split(new char[1] { ',' });
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (f_oTblCT.Columns.Contains(array[num2]))
				{
					list.Add(array[num2].ToUpper());
				}
				num2++;
			}
			f_oTblCT_Carry_out = new DataTable("CT_Carry_out");
			f_oTblCT_Carry_out.Columns.Add("data_field", typeof(string));
			f_oTblCT_Carry_out.Columns.Add("field_desc", typeof(string));
			f_oTblCT_Carry_in = new DataTable("CT_Carry_in");
			f_oTblCT_Carry_in.Columns.Add("data_field", typeof(string));
			f_oTblCT_Carry_in.Columns.Add("field_desc", typeof(string));
			DataColumn[] primaryKey = new DataColumn[1] { f_oTblCT_Carry_out.Columns["Field_Name"] };
			DataColumn[] primaryKey2 = new DataColumn[1] { f_oTblCT_Carry_in.Columns["Field_Name"] };
			f_oTblCT_Carry_out.PrimaryKey = primaryKey;
			f_oTblCT_Carry_in.PrimaryKey = primaryKey2;
			foreach (DataColumn column in f_oTblCT.Columns)
			{
				if (list.Contains(column.ColumnName.ToUpper()))
				{
					DataRow dataRow = f_oTblCT_Carry_in.NewRow();
					dataRow["data_field"] = column.ColumnName;
					if (f_hstPH_Field_Desc.Contains(column.ColumnName))
					{
						dataRow["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstPH_Field_Desc[column.ColumnName]);
					}
					f_oTblCT_Carry_in.Rows.Add(dataRow);
				}
				else
				{
					DataRow dataRow2 = f_oTblCT_Carry_out.NewRow();
					dataRow2["data_field"] = column.ColumnName;
					if (f_hstCT_Field_Desc.Contains(column.ColumnName))
					{
						dataRow2["field_desc"] = RuntimeHelpers.GetObjectValue(f_hstCT_Field_Desc[column.ColumnName]);
					}
					f_oTblCT_Carry_out.Rows.Add(dataRow2);
				}
			}
			((DataGridView)dgvCT_Carry_out).DataSource = f_oTblCT_Carry_out;
			((DataGridView)dgvCT_Carry_in).DataSource = f_oTblCT_Carry_in;
		}
	}

	protected void RefreshButton()
	{
		if (f_oTblPH_Carry_in.Rows.Count == 0)
		{
			((Control)cmdOut).Enabled = false;
			((Control)cmdOutAll).Enabled = false;
		}
		else
		{
			((Control)cmdOut).Enabled = true;
			((Control)cmdOutAll).Enabled = true;
		}
		if (f_oTblPH_Carry_out.Rows.Count == 0)
		{
			((Control)cmdIn).Enabled = false;
			((Control)cmdInAll).Enabled = false;
		}
		else
		{
			((Control)cmdIn).Enabled = true;
			((Control)cmdInAll).Enabled = true;
		}
		if (f_oTblCT_Carry_in.Rows.Count == 0)
		{
			((Control)cmdCTC_out).Enabled = false;
			((Control)cmdCTC_OutAll).Enabled = false;
		}
		else
		{
			((Control)cmdCTC_out).Enabled = true;
			((Control)cmdCTC_OutAll).Enabled = true;
		}
		if (f_oTblCT_Carry_out.Rows.Count == 0)
		{
			((Control)cmdCTC_in).Enabled = false;
			((Control)cmdCTC_InAll).Enabled = false;
		}
		else
		{
			((Control)cmdCTC_in).Enabled = true;
			((Control)cmdCTC_InAll).Enabled = true;
		}
		if (f_oTblPH_Print_in.Rows.Count == 0)
		{
			((Control)cmdPHP_out).Enabled = false;
			((Control)cmdPHP_OutAll).Enabled = false;
		}
		else
		{
			((Control)cmdPHP_out).Enabled = true;
			((Control)cmdPHP_OutAll).Enabled = true;
		}
		if (f_oTblPH_Print_out.Rows.Count == 0)
		{
			((Control)cmdPHP_In).Enabled = false;
			((Control)cmdPHP_InAll).Enabled = false;
		}
		else
		{
			((Control)cmdPHP_In).Enabled = true;
			((Control)cmdPHP_InAll).Enabled = true;
		}
	}

	private void GetFieldToUpdate()
	{
		string text = "";
		foreach (DataRow row in f_oTblPH_Carry_in.Rows)
		{
			text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(row["data_field"], (object)",")));
		}
		checked
		{
			if (text.EndsWith(","))
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (f_oDrwEdit.Table.Columns.Contains("ph_carry_field_list"))
			{
				f_oDrwEdit["ph_carry_field_list"] = text;
			}
			text = "";
			foreach (DataRow row2 in f_oTblCT_Carry_in.Rows)
			{
				text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(row2["data_field"], (object)",")));
			}
			if (text.EndsWith(","))
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (f_oDrwEdit.Table.Columns.Contains("ct_carry_field_list"))
			{
				f_oDrwEdit["ct_carry_field_list"] = text;
			}
			text = "";
			foreach (DataRow row3 in f_oTblPH_Print_in.Rows)
			{
				text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(row3["data_field"], (object)",")));
			}
			if (text.EndsWith(","))
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (f_oDrwEdit.Table.Columns.Contains("ph_print_field_list"))
			{
				f_oDrwEdit["ph_print_field_list"] = text;
			}
		}
	}

	private void Get_Field_Desc()
	{
		VOUCHERDAO vOUCHERDAO = (VOUCHERDAO)DAOFactory.CreateDAOInstance("VOUCHERDAO", "SIDMCT");
		DataTable fieldDescription = vOUCHERDAO.GetFieldDescription(MyVoucherInfo.ph_table_name);
		foreach (DataRow row in fieldDescription.Rows)
		{
			f_hstPH_Field_Desc.Add(RuntimeHelpers.GetObjectValue(row["name"]), RuntimeHelpers.GetObjectValue(row["description"]));
		}
		fieldDescription = vOUCHERDAO.GetFieldDescription(MyVoucherInfo.ct_table_name);
		foreach (DataRow row2 in fieldDescription.Rows)
		{
			f_hstCT_Field_Desc.Add(RuntimeHelpers.GetObjectValue(row2["name"]), RuntimeHelpers.GetObjectValue(row2["description"]));
		}
		vOUCHERDAO.Destroy();
	}
}
