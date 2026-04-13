using System.Diagnostics;
using System.Windows.Forms;

namespace AsiaErp.Framework;

public class CMessageBox
{
	[DebuggerNonUserCode]
	public CMessageBox()
	{
	}

	public static DialogResult ShowWithFormat(int MessID, params object[] oPArr)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		string text = string.Format(mess.Description, oPArr);
		return Show(null, text, SystemInformations.ProductFullName, (MessageBoxButtons)0, (MessageBoxIcon)mess.Icon, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static DialogResult ShowWithFormat(int MessID, MessageBoxButtons buttons, params object[] oPArr)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		return Show(null, string.Format(mess.Description, oPArr), SystemInformations.ProductFullName, buttons, (MessageBoxIcon)mess.Icon, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static DialogResult Show(int MessID)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		return Show(null, mess.Description, SystemInformations.ProductFullName, (MessageBoxButtons)0, (MessageBoxIcon)mess.Icon, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static DialogResult Show(int MessID, string caption)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		return Show(null, mess.Description, caption, (MessageBoxButtons)0, (MessageBoxIcon)mess.Icon, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static DialogResult Show(int MessID, string caption, MessageBoxButtons buttons)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		return Show(null, mess.Description, caption, buttons, (MessageBoxIcon)mess.Icon, (MessageBoxDefaultButton)0, (MessageBoxOptions)0);
	}

	public static DialogResult Show(int MessID, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		AsiaMessage mess = Helper.GetMess(MessID);
		return Show(null, mess.Description, caption, buttons, (MessageBoxIcon)mess.Icon, defaultButton, (MessageBoxOptions)0);
	}

	public static DialogResult Show(string text)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Show(text, string.Empty);
	}

	public static DialogResult Show(string text, string caption)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Show(text, caption, (MessageBoxButtons)0);
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return Show(text, caption, buttons, (MessageBoxIcon)0);
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return Show(text, caption, buttons, icon, (MessageBoxDefaultButton)0);
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Show(text, caption, buttons, icon, defaultButton, (MessageBoxOptions)0);
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Show(null, text, caption, buttons, icon, defaultButton, options);
	}

	public static DialogResult Show(IWin32Window owner, string text)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Show(null, text, string.Empty);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return Show(owner, text, caption, (MessageBoxButtons)0);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return Show(owner, text, caption, buttons, (MessageBoxIcon)0);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return Show(owner, text, caption, buttons, icon, (MessageBoxDefaultButton)0);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return Show(owner, text, caption, buttons, icon, defaultButton, (MessageBoxOptions)0);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		CSysMsgBoxHook cSysMsgBoxHook = new CSysMsgBoxHook();
		cSysMsgBoxHook.HookDialog();
		DialogResult result = MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options);
		cSysMsgBoxHook.UnHookDialog();
		cSysMsgBoxHook = null;
		return result;
	}
}
