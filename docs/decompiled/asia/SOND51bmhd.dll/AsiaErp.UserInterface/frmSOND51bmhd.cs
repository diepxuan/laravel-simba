using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using AsiaErp.DataAccess;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace AsiaErp.UserInterface;

[DesignerGenerated]
public class frmSOND51bmhd : frmAsiaRoot
{
	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtMa_BM")]
	private TextBox _txtMa_BM;

	[AccessedThroughProperty("chkHien")]
	private CheckBox _chkHien;

	[AccessedThroughProperty("ChkSu_dung")]
	private CheckBox _ChkSu_dung;

	[AccessedThroughProperty("btnLuu")]
	private Button _btnLuu;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("btnKiemtra")]
	private Button _btnKiemtra;

	[AccessedThroughProperty("txtMa_KT")]
	private AsTextBox _txtMa_KT;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtMST")]
	private AsTextBox _txtMST;

	[AccessedThroughProperty("txtSo_seri")]
	private AsTextBox _txtSo_seri;

	[AccessedThroughProperty("txtNgay_HD")]
	private AsMaskedTextBox _txtNgay_HD;

	[AccessedThroughProperty("txtSo_HD")]
	private AsTextBox _txtSo_HD;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("btnMa_hoa")]
	private Button _btnMa_hoa;

	[AccessedThroughProperty("txtMa_hoa")]
	private AsTextBox _txtMa_hoa;

	[AccessedThroughProperty("epNotice")]
	private ErrorProvider _epNotice;

	private bool isFirst;

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

	internal virtual TextBox txtMa_BM
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_BM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_BM = value;
		}
	}

	internal virtual CheckBox chkHien
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkHien;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkHien_Click;
			if (_chkHien != null)
			{
				((Control)_chkHien).Click -= eventHandler;
			}
			_chkHien = value;
			if (_chkHien != null)
			{
				((Control)_chkHien).Click += eventHandler;
			}
		}
	}

	internal virtual CheckBox ChkSu_dung
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChkSu_dung;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChkSu_dung_Click;
			if (_ChkSu_dung != null)
			{
				((Control)_ChkSu_dung).Click -= eventHandler;
			}
			_ChkSu_dung = value;
			if (_ChkSu_dung != null)
			{
				((Control)_ChkSu_dung).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnLuu
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLuu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnLuu_Click;
			if (_btnLuu != null)
			{
				((Control)_btnLuu).Click -= eventHandler;
			}
			_btnLuu = value;
			if (_btnLuu != null)
			{
				((Control)_btnLuu).Click += eventHandler;
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button btnKiemtra
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnKiemtra;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnKiemtra_Click;
			if (_btnKiemtra != null)
			{
				((Control)_btnKiemtra).Click -= eventHandler;
			}
			_btnKiemtra = value;
			if (_btnKiemtra != null)
			{
				((Control)_btnKiemtra).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtMa_KT
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_KT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_KT = value;
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

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
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

	internal virtual AsTextBox txtMST
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMST = value;
		}
	}

	internal virtual AsTextBox txtSo_seri
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_seri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_seri = value;
		}
	}

	internal virtual AsMaskedTextBox txtNgay_HD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNgay_HD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNgay_HD = value;
		}
	}

	internal virtual AsTextBox txtSo_HD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSo_HD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSo_HD = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Button btnMa_hoa
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnMa_hoa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnMa_hoa_Click;
			if (_btnMa_hoa != null)
			{
				((Control)_btnMa_hoa).Click -= eventHandler;
			}
			_btnMa_hoa = value;
			if (_btnMa_hoa != null)
			{
				((Control)_btnMa_hoa).Click += eventHandler;
			}
		}
	}

	internal virtual AsTextBox txtMa_hoa
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMa_hoa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMa_hoa = value;
		}
	}

	internal virtual ErrorProvider epNotice
	{
		[DebuggerNonUserCode]
		get
		{
			return _epNotice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_epNotice = value;
		}
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

	protected frmSOND51bmhd(string menuid)
		: base(menuid)
	{
		((Form)this).Load += frmSOND51bmhd_Load;
		InitializeComponent();
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected O, but got Unknown
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected O, but got Unknown
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Expected O, but got Unknown
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected O, but got Unknown
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSOND51bmhd));
		Label2 = new Label();
		txtMa_BM = new TextBox();
		chkHien = new CheckBox();
		ChkSu_dung = new CheckBox();
		btnLuu = new Button();
		GroupBox1 = new GroupBox();
		TextBox2 = new TextBox();
		btnKiemtra = new Button();
		txtMa_KT = new AsTextBox();
		Label3 = new Label();
		GroupBox3 = new GroupBox();
		txtMST = new AsTextBox();
		txtSo_seri = new AsTextBox();
		txtNgay_HD = new AsMaskedTextBox();
		txtSo_HD = new AsTextBox();
		TextBox3 = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		txtMa_hoa = new AsTextBox();
		btnMa_hoa = new Button();
		epNotice = new ErrorProvider(components);
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((ISupportInitialize)epNotice).BeginInit();
		((Control)this).SuspendLayout();
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label2;
		Point location = new Point(13, 26);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		Size size = new Size(77, 13);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 1;
		Label2.Text = "Mã số bảo mật";
		((Control)txtMa_BM).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox obj = txtMa_BM;
		location = new Point(106, 22);
		((Control)obj).Location = location;
		((Control)txtMa_BM).Name = "txtMa_BM";
		txtMa_BM.PasswordChar = '*';
		TextBox obj2 = txtMa_BM;
		size = new Size(100, 20);
		((Control)obj2).Size = size;
		((Control)txtMa_BM).TabIndex = 0;
		((ButtonBase)chkHien).AutoSize = true;
		((Control)chkHien).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		CheckBox obj3 = chkHien;
		location = new Point(106, 48);
		((Control)obj3).Location = location;
		((Control)chkHien).Name = "chkHien";
		CheckBox obj4 = chkHien;
		size = new Size(134, 17);
		((Control)obj4).Size = size;
		((Control)chkHien).TabIndex = 1;
		((ButtonBase)chkHien).Text = "Hiển thị mã số bảo mật";
		((ButtonBase)chkHien).UseVisualStyleBackColor = true;
		((ButtonBase)ChkSu_dung).AutoSize = true;
		ChkSu_dung.Checked = true;
		ChkSu_dung.CheckState = (CheckState)1;
		((Control)ChkSu_dung).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		CheckBox chkSu_dung = ChkSu_dung;
		location = new Point(106, 71);
		((Control)chkSu_dung).Location = location;
		((Control)ChkSu_dung).Name = "ChkSu_dung";
		CheckBox chkSu_dung2 = ChkSu_dung;
		size = new Size(138, 17);
		((Control)chkSu_dung2).Size = size;
		((Control)ChkSu_dung).TabIndex = 2;
		((ButtonBase)ChkSu_dung).Text = "Sử dụng mã số bảo mật";
		((ButtonBase)ChkSu_dung).UseVisualStyleBackColor = true;
		((Control)btnLuu).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button obj5 = btnLuu;
		location = new Point(106, 94);
		((Control)obj5).Location = location;
		((Control)btnLuu).Name = "btnLuu";
		Button obj6 = btnLuu;
		size = new Size(66, 23);
		((Control)obj6).Size = size;
		((Control)btnLuu).TabIndex = 3;
		((ButtonBase)btnLuu).Text = "&Lưu";
		((ButtonBase)btnLuu).UseVisualStyleBackColor = true;
		((Control)GroupBox1).Controls.Add((Control)(object)TextBox2);
		((Control)GroupBox1).Controls.Add((Control)(object)ChkSu_dung);
		((Control)GroupBox1).Controls.Add((Control)(object)btnLuu);
		((Control)GroupBox1).Controls.Add((Control)(object)Label2);
		((Control)GroupBox1).Controls.Add((Control)(object)txtMa_BM);
		((Control)GroupBox1).Controls.Add((Control)(object)chkHien);
		((Control)GroupBox1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)GroupBox1).ForeColor = Color.Black;
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 12);
		((Control)groupBox).Location = location;
		((Control)GroupBox1).Name = "GroupBox1";
		GroupBox groupBox2 = GroupBox1;
		size = new Size(532, 130);
		((Control)groupBox2).Size = size;
		((Control)GroupBox1).TabIndex = 6;
		GroupBox1.TabStop = false;
		GroupBox1.Text = "Thiết lập mã số bảo mật";
		((Control)TextBox2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)TextBox2).ForeColor = Color.Black;
		TextBox textBox = TextBox2;
		location = new Point(250, 19);
		((Control)textBox).Location = location;
		TextBox2.Multiline = true;
		((Control)TextBox2).Name = "TextBox2";
		((TextBoxBase)TextBox2).ReadOnly = true;
		TextBox textBox2 = TextBox2;
		size = new Size(268, 98);
		((Control)textBox2).Size = size;
		((Control)TextBox2).TabIndex = 6;
		((Control)TextBox2).TabStop = false;
		TextBox2.Text = componentResourceManager.GetString("TextBox2.Text");
		((Control)btnKiemtra).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button obj7 = btnKiemtra;
		location = new Point(444, 108);
		((Control)obj7).Location = location;
		((Control)btnKiemtra).Name = "btnKiemtra";
		Button obj8 = btnKiemtra;
		size = new Size(75, 23);
		((Control)obj8).Size = size;
		((Control)btnKiemtra).TabIndex = 9;
		((ButtonBase)btnKiemtra).Text = "&Kiểm Tra";
		((ButtonBase)btnKiemtra).UseVisualStyleBackColor = true;
		txtMa_KT.AutoLookup = false;
		txtMa_KT.AutoValid = false;
		((TextBoxBase)txtMa_KT).BackColor = SystemColors.Window;
		((TextBox)txtMa_KT).CharacterCasing = (CharacterCasing)1;
		((Control)txtMa_KT).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextBox asTextBox = txtMa_KT;
		location = new Point(105, 109);
		((Control)asTextBox).Location = location;
		txtMa_KT.LookupCodeName = "";
		((Control)txtMa_KT).Name = "txtMa_KT";
		txtMa_KT.NameControl = null;
		AsTextBox asTextBox2 = txtMa_KT;
		size = new Size(332, 20);
		((Control)asTextBox2).Size = size;
		((Control)txtMa_KT).TabIndex = 8;
		txtMa_KT.UseAutoCompleteSource = true;
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label3 = Label3;
		location = new Point(13, 113);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(76, 13);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 0;
		Label3.Text = "Mã số kiểm tra";
		((Control)GroupBox3).Controls.Add((Control)(object)btnKiemtra);
		((Control)GroupBox3).Controls.Add((Control)(object)txtMST);
		((Control)GroupBox3).Controls.Add((Control)(object)txtMa_KT);
		((Control)GroupBox3).Controls.Add((Control)(object)Label3);
		((Control)GroupBox3).Controls.Add((Control)(object)txtSo_seri);
		((Control)GroupBox3).Controls.Add((Control)(object)txtNgay_HD);
		((Control)GroupBox3).Controls.Add((Control)(object)txtSo_HD);
		((Control)GroupBox3).Controls.Add((Control)(object)TextBox3);
		((Control)GroupBox3).Controls.Add((Control)(object)Label7);
		((Control)GroupBox3).Controls.Add((Control)(object)Label6);
		((Control)GroupBox3).Controls.Add((Control)(object)Label5);
		((Control)GroupBox3).Controls.Add((Control)(object)Label4);
		((Control)GroupBox3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)GroupBox3).ForeColor = Color.Black;
		GroupBox groupBox3 = GroupBox3;
		location = new Point(12, 148);
		((Control)groupBox3).Location = location;
		((Control)GroupBox3).Name = "GroupBox3";
		GroupBox groupBox4 = GroupBox3;
		size = new Size(532, 139);
		((Control)groupBox4).Size = size;
		((Control)GroupBox3).TabIndex = 8;
		GroupBox3.TabStop = false;
		GroupBox3.Text = "Thông tin của hoá đơn cần kiểm tra";
		txtMST.AutoLookup = false;
		txtMST.AutoValid = false;
		((TextBoxBase)txtMST).BackColor = SystemColors.Window;
		((TextBox)txtMST).CharacterCasing = (CharacterCasing)1;
		((Control)txtMST).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextBox asTextBox3 = txtMST;
		location = new Point(105, 85);
		((Control)asTextBox3).Location = location;
		txtMST.LookupCodeName = "";
		((Control)txtMST).Name = "txtMST";
		txtMST.NameControl = null;
		AsTextBox asTextBox4 = txtMST;
		size = new Size(100, 20);
		((Control)asTextBox4).Size = size;
		((Control)txtMST).TabIndex = 7;
		txtMST.UseAutoCompleteSource = true;
		txtSo_seri.AutoLookup = false;
		txtSo_seri.AutoValid = false;
		((TextBoxBase)txtSo_seri).BackColor = SystemColors.Window;
		((TextBox)txtSo_seri).CharacterCasing = (CharacterCasing)1;
		((Control)txtSo_seri).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextBox asTextBox5 = txtSo_seri;
		location = new Point(105, 63);
		((Control)asTextBox5).Location = location;
		txtSo_seri.LookupCodeName = "";
		((Control)txtSo_seri).Name = "txtSo_seri";
		txtSo_seri.NameControl = null;
		AsTextBox asTextBox6 = txtSo_seri;
		size = new Size(100, 20);
		((Control)asTextBox6).Size = size;
		((Control)txtSo_seri).TabIndex = 6;
		txtSo_seri.UseAutoCompleteSource = true;
		((Control)txtNgay_HD).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		txtNgay_HD.Format = "@Ddd/MM/yyyy";
		((MaskedTextBox)txtNgay_HD).InsertKeyMode = (InsertKeyMode)2;
		AsMaskedTextBox asMaskedTextBox = txtNgay_HD;
		location = new Point(105, 41);
		((Control)asMaskedTextBox).Location = location;
		((MaskedTextBox)txtNgay_HD).Mask = "##/##/####";
		((Control)txtNgay_HD).Name = "txtNgay_HD";
		((MaskedTextBox)txtNgay_HD).PromptChar = ' ';
		AsMaskedTextBox asMaskedTextBox2 = txtNgay_HD;
		size = new Size(100, 20);
		((Control)asMaskedTextBox2).Size = size;
		((Control)txtNgay_HD).TabIndex = 5;
		((MaskedTextBox)txtNgay_HD).ValidatingType = typeof(DateTime);
		AsMaskedTextBox asMaskedTextBox3 = txtNgay_HD;
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		asMaskedTextBox3.Value = dateTime;
		txtSo_HD.AutoLookup = false;
		txtSo_HD.AutoValid = false;
		((TextBoxBase)txtSo_HD).BackColor = SystemColors.Window;
		((TextBox)txtSo_HD).CharacterCasing = (CharacterCasing)1;
		((Control)txtSo_HD).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		AsTextBox asTextBox7 = txtSo_HD;
		location = new Point(105, 19);
		((Control)asTextBox7).Location = location;
		txtSo_HD.LookupCodeName = "";
		((Control)txtSo_HD).Name = "txtSo_HD";
		txtSo_HD.NameControl = null;
		AsTextBox asTextBox8 = txtSo_HD;
		size = new Size(100, 20);
		((Control)asTextBox8).Size = size;
		((Control)txtSo_HD).TabIndex = 4;
		txtSo_HD.UseAutoCompleteSource = true;
		((Control)TextBox3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox textBox3 = TextBox3;
		location = new Point(216, 19);
		((Control)textBox3).Location = location;
		TextBox3.Multiline = true;
		((Control)TextBox3).Name = "TextBox3";
		((TextBoxBase)TextBox3).ReadOnly = true;
		TextBox textBox4 = TextBox3;
		size = new Size(303, 86);
		((Control)textBox4).Size = size;
		((Control)TextBox3).TabIndex = 7;
		((Control)TextBox3).TabStop = false;
		TextBox3.Text = "Nhập đầy đủ các thông tin mà bạn có trên tờ hoá đơn và tiến hành kiểm tra để biết đấy có phải là tờ hoá đơn mà doanh nghiệp bạn in hay không.";
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label5 = Label7;
		location = new Point(13, 88);
		((Control)label5).Location = location;
		((Control)Label7).Name = "Label7";
		Label label6 = Label7;
		size = new Size(48, 13);
		((Control)label6).Size = size;
		((Control)Label7).TabIndex = 3;
		Label7.Text = "MST KH";
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label7 = Label6;
		location = new Point(13, 66);
		((Control)label7).Location = location;
		((Control)Label6).Name = "Label6";
		Label label8 = Label6;
		size = new Size(61, 13);
		((Control)label8).Size = size;
		((Control)Label6).TabIndex = 2;
		Label6.Text = "Ký hiệu HĐ";
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label9 = Label5;
		location = new Point(13, 44);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(51, 13);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 1;
		Label5.Text = "Ngày HĐ";
		Label4.AutoSize = true;
		((Control)Label4).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label11 = Label4;
		location = new Point(13, 22);
		((Control)label11).Location = location;
		((Control)Label4).Name = "Label4";
		Label label12 = Label4;
		size = new Size(39, 13);
		((Control)label12).Size = size;
		((Control)Label4).TabIndex = 0;
		Label4.Text = "Số HĐ";
		txtMa_hoa.AutoLookup = false;
		txtMa_hoa.AutoValid = false;
		((TextBoxBase)txtMa_hoa).BackColor = SystemColors.Window;
		((TextBox)txtMa_hoa).CharacterCasing = (CharacterCasing)1;
		AsTextBox asTextBox9 = txtMa_hoa;
		location = new Point(117, 293);
		((Control)asTextBox9).Location = location;
		txtMa_hoa.LookupCodeName = "";
		((Control)txtMa_hoa).Name = "txtMa_hoa";
		txtMa_hoa.NameControl = null;
		AsTextBox asTextBox10 = txtMa_hoa;
		size = new Size(332, 20);
		((Control)asTextBox10).Size = size;
		((Control)txtMa_hoa).TabIndex = 11;
		txtMa_hoa.UseAutoCompleteSource = true;
		((Control)btnMa_hoa).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Button obj9 = btnMa_hoa;
		location = new Point(456, 290);
		((Control)obj9).Location = location;
		((Control)btnMa_hoa).Name = "btnMa_hoa";
		Button obj10 = btnMa_hoa;
		size = new Size(75, 23);
		((Control)obj10).Size = size;
		((Control)btnMa_hoa).TabIndex = 10;
		((ButtonBase)btnMa_hoa).Text = "&Mã Hoá";
		((ButtonBase)btnMa_hoa).UseVisualStyleBackColor = true;
		epNotice.ContainerControl = (ContainerControl)(object)this;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(554, 324);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtMa_hoa);
		((Control)this).Controls.Add((Control)(object)btnMa_hoa);
		((Control)this).Controls.Add((Control)(object)GroupBox3);
		((Control)this).Controls.Add((Control)(object)GroupBox1);
		((Control)this).ForeColor = Color.Black;
		((Control)this).Name = "frmSOND51bmhd";
		((Form)this).Text = "Bảo mật hoá đơn tự in";
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((ISupportInitialize)epNotice).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27)
		{
			((Form)this).Close();
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void frmSOND51bmhd_Load(object sender, EventArgs e)
	{
		SOND51bmhdDAO sOND51bmhdDAO = (SOND51bmhdDAO)DAOFactory.CreateDAOInstance("SOND51bmhdDAO", "SOND51bmhd");
		DataTable data = sOND51bmhdDAO.GetData();
		sOND51bmhdDAO.Destroy();
		if (data.Rows.Count == 0)
		{
			isFirst = true;
			return;
		}
		isFirst = false;
		string text = Decrypt(data.Rows[0]["gia_tri"].ToString(), "asiasoft");
		txtMa_BM.Text = text;
	}

	private void chkHien_Click(object sender, EventArgs e)
	{
		if (chkHien.Checked)
		{
			txtMa_BM.PasswordChar = '\0';
		}
		else
		{
			txtMa_BM.PasswordChar = '*';
		}
	}

	private void ChkSu_dung_Click(object sender, EventArgs e)
	{
		if (ChkSu_dung.Checked)
		{
			((Control)txtMa_BM).Enabled = true;
		}
		else
		{
			((Control)txtMa_BM).Enabled = false;
		}
	}

	private void btnLuu_Click(object sender, EventArgs e)
	{
		if (txtMa_BM.Text.Length <= 6)
		{
			epNotice.SetError((Control)(object)txtMa_BM, Helper.GetMess(50166).Description);
			((Control)txtMa_BM).Select();
			return;
		}
		string gia_tri = Encrypt(txtMa_BM.Text, "asiasoft");
		if (isFirst)
		{
			SOND51bmhdDAO sOND51bmhdDAO = (SOND51bmhdDAO)DAOFactory.CreateDAOInstance("SOND51bmhdDAO", "SOND51bmhd");
			int num = sOND51bmhdDAO.Update(gia_tri, ChkSu_dung.Checked, isFirst);
			sOND51bmhdDAO.Destroy();
			isFirst = false;
		}
		else
		{
			frmConfirm frmConfirm2 = new frmConfirm();
			frmConfirm2.Show();
			frmConfirm2.Gia_tri = gia_tri;
			frmConfirm2.Su_dung = ChkSu_dung.Checked;
		}
	}

	private void btnKiemtra_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(ValidData(test: true)))
		{
			string text = ((!ChkSu_dung.Checked) ? GetMD5Hash(Encrypt(((TextBox)txtSo_HD).Text + ((MaskedTextBox)txtNgay_HD).Text + ((TextBox)txtSo_seri).Text + ((TextBox)txtMST).Text, "asiasoft")).ToUpper() : GetMD5Hash(Encrypt(((TextBox)txtSo_HD).Text + ((MaskedTextBox)txtNgay_HD).Text + ((TextBox)txtSo_seri).Text + ((TextBox)txtMST).Text, txtMa_BM.Text)).ToUpper());
			if (text.CompareTo(((TextBox)txtMa_KT).Text) == 0)
			{
				CMessageBox.Show("Hoa\u0301 đơn do công ty pha\u0301t ha\u0300nh!");
			}
			else
			{
				CMessageBox.Show("Hoa\u0301 đơn không pha\u0309i do công ty pha\u0301t ha\u0300nh!");
			}
		}
	}

	private void btnMa_hoa_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(ValidData()))
		{
			string stringToEncrypt = ((TextBox)txtSo_HD).Text + ((MaskedTextBox)txtNgay_HD).Text + ((TextBox)txtSo_seri).Text + ((TextBox)txtMST).Text;
			if (ChkSu_dung.Checked)
			{
				((TextBox)txtMa_hoa).Text = GetMD5Hash(Encrypt(stringToEncrypt, txtMa_BM.Text));
			}
			else
			{
				((TextBox)txtMa_hoa).Text = GetMD5Hash(Encrypt(stringToEncrypt, "asiasoft"));
			}
		}
	}

	protected object ValidData(bool test = false)
	{
		if (Operators.CompareString(txtMa_BM.Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMa_BM, Helper.GetMess(50002).Description);
			((Control)txtMa_BM).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtMa_BM, "");
		if (Operators.CompareString(((TextBox)txtSo_HD).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_HD, Helper.GetMess(50002).Description);
			((Control)txtSo_HD).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtSo_HD, "");
		if (Operators.CompareString(((MaskedTextBox)txtNgay_HD).Text.Replace("\\", "").Trim(), "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtNgay_HD, Helper.GetMess(50002).Description);
			((Control)txtNgay_HD).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtNgay_HD, "");
		if (Operators.CompareString(((TextBox)txtSo_seri).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtSo_seri, Helper.GetMess(50002).Description);
			((Control)txtSo_seri).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtSo_seri, "");
		if (Operators.CompareString(((TextBox)txtMST).Text, "", false) == 0)
		{
			epNotice.SetError((Control)(object)txtMST, Helper.GetMess(50002).Description);
			((Control)txtMST).Select();
			return false;
		}
		epNotice.SetError((Control)(object)txtMST, "");
		if (test)
		{
			if (Operators.CompareString(((TextBox)txtMa_KT).Text, "", false) == 0)
			{
				epNotice.SetError((Control)(object)txtMa_KT, Helper.GetMess(50002).Description);
				((Control)txtMa_KT).Select();
				return false;
			}
			epNotice.SetError((Control)(object)txtMa_KT, "");
		}
		return true;
	}

	protected string Encrypt(string stringToEncrypt, string key)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(key);
		byte[] bytes2 = uTF8Encoding.GetBytes(stringToEncrypt);
		int num = 0;
		checked
		{
			int num2 = bytes2.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				bytes2[i] = unchecked((byte)(bytes2[i] ^ bytes[num]));
				num++;
				if (num == bytes.Length)
				{
					num = 0;
				}
			}
			return ByteToHex(bytes2);
		}
	}

	protected string Decrypt(string encryptedString, string key)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(key);
		byte[] array = HexToByte(encryptedString);
		int num = 0;
		checked
		{
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ bytes[num]));
				num++;
				if (num == bytes.Length)
				{
					num = 0;
				}
			}
			return uTF8Encoding.GetString(array);
		}
	}

	protected string GetMD5Hash(string strToHash)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = "";
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	protected string ByteToHex(byte[] value)
	{
		string text = BitConverter.ToString(value);
		return text.Replace("-", "");
	}

	protected byte[] HexToByte(string value)
	{
		int length = value.Length;
		checked
		{
			byte[] array = new byte[unchecked(length / 2) - 1 + 1];
			int num = length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				array[unchecked(i / 2)] = Convert.ToByte(value.Substring(i, 2), 16);
			}
			return array;
		}
	}
}
