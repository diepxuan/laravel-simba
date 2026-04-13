using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AsiaErp.Framework;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class FrmT3ModuleOptions : frmAsiaRoot
{
	[CompilerGenerated]
	internal class _Closure_0024__11
	{
		public ModuleInformation _0024VB_0024Local_mTemp;

		[DebuggerNonUserCode]
		public _Closure_0024__11(_Closure_0024__11 other)
		{
			if (other != null)
			{
				_0024VB_0024Local_mTemp = other._0024VB_0024Local_mTemp;
			}
		}

		[DebuggerNonUserCode]
		public _Closure_0024__11()
		{
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("chkModules")]
	private CheckedListBox _chkModules;

	private List<ModuleInformation> _modules;

	internal List<ModuleInformation> _config;

	internal virtual Button btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnOk_Click;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click -= eventHandler;
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).Click += eventHandler;
			}
		}
	}

	internal virtual Button btnCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnCancel_Click;
			if (_btnCancel != null)
			{
				((Control)_btnCancel).Click -= eventHandler;
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
				((Control)_btnCancel).Click += eventHandler;
			}
		}
	}

	internal virtual CheckedListBox chkModules
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkModules;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ItemCheckEventHandler val = new ItemCheckEventHandler(chkModules_ItemCheck);
			if (_chkModules != null)
			{
				_chkModules.ItemCheck -= val;
			}
			_chkModules = value;
			if (_chkModules != null)
			{
				_chkModules.ItemCheck += val;
			}
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		btnOk = new Button();
		btnCancel = new Button();
		chkModules = new CheckedListBox();
		((Control)this).SuspendLayout();
		Button obj = btnOk;
		Point location = new Point(3, 239);
		((Control)obj).Location = location;
		((Control)btnOk).Name = "btnOk";
		Button obj2 = btnOk;
		Size size = new Size(75, 23);
		((Control)obj2).Size = size;
		((Control)btnOk).TabIndex = 1;
		((ButtonBase)btnOk).Text = "&Nhận";
		((ButtonBase)btnOk).UseVisualStyleBackColor = true;
		btnCancel.DialogResult = (DialogResult)2;
		Button obj3 = btnCancel;
		location = new Point(84, 239);
		((Control)obj3).Location = location;
		((Control)btnCancel).Name = "btnCancel";
		Button obj4 = btnCancel;
		size = new Size(75, 23);
		((Control)obj4).Size = size;
		((Control)btnCancel).TabIndex = 2;
		((ButtonBase)btnCancel).Text = "&Hủy";
		((ButtonBase)btnCancel).UseVisualStyleBackColor = true;
		((ListControl)chkModules).FormattingEnabled = true;
		CheckedListBox obj5 = chkModules;
		location = new Point(3, 3);
		((Control)obj5).Location = location;
		((Control)chkModules).Name = "chkModules";
		CheckedListBox obj6 = chkModules;
		size = new Size(449, 229);
		((Control)obj6).Size = size;
		((Control)chkModules).TabIndex = 0;
		((Form)this).AcceptButton = (IButtonControl)(object)btnCancel;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)btnCancel;
		size = new Size(457, 268);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkModules);
		((Control)this).Controls.Add((Control)(object)btnCancel);
		((Control)this).Controls.Add((Control)(object)btnOk);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FrmT3ModuleOptions";
		((Form)this).Text = "Select modules";
		((Control)this).ResumeLayout(false);
	}

	public FrmT3ModuleOptions(IOrderedEnumerable<MenuInformation> _menus)
	{
		__ENCAddToList(this);
		_modules = new List<ModuleInformation>();
		InitializeComponent();
		int num = _menus.Count() - 1;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 > num4)
			{
				break;
			}
			_modules.Add(new ModuleInformation
			{
				Bar = _menus.ElementAtOrDefault(num2).bar,
				MenuID = _menus.ElementAtOrDefault(num2).menuid,
				Checked = true
			});
			num2++;
		}
		_config = ModuleInformation.ReadModuleConfig();
		if (_config != null)
		{
			using List<ModuleInformation>.Enumerator enumerator = _config.GetEnumerator();
			_Closure_0024__11 closure_0024__ = default(_Closure_0024__11);
			while (enumerator.MoveNext())
			{
				closure_0024__ = new _Closure_0024__11(closure_0024__);
				ModuleInformation moduleInformation = (closure_0024__._0024VB_0024Local_mTemp = enumerator.Current);
				ModuleInformation moduleInformation2 = _modules.Where(closure_0024__._Lambda_0024__179).SingleOrDefault();
				if (moduleInformation2 != null)
				{
					moduleInformation2.Checked = moduleInformation.Checked;
				}
			}
		}
		foreach (ModuleInformation module in _modules)
		{
			chkModules.Items.Add((object)module.Bar, module.Checked);
		}
		_config = _modules;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		SaveSettings();
		((Form)this).DialogResult = (DialogResult)1;
	}

	private void SaveSettings()
	{
		ModuleInformation.SaveModuleConfig(_modules);
	}

	private void chkModules_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		_modules[e.Index].Checked = (int)e.NewValue > 0;
	}
}
