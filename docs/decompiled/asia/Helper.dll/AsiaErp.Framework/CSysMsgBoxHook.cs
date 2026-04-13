using System;
using System.Resources;
using System.Runtime.InteropServices;

namespace AsiaErp.Framework;

public class CSysMsgBoxHook
{
	private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const long WH_CBT = 5L;

	private const long HCBT_ACTIVATE = 5L;

	private const int ID_BUT_OK = 1;

	private const int ID_BUT_CANCEL = 2;

	private const int ID_BUT_ABORT = 3;

	private const int ID_BUT_RETRY = 4;

	private const int ID_BUT_IGNORE = 5;

	private const int ID_BUT_YES = 6;

	private const int ID_BUT_NO = 7;

	private string BUT_OK;

	private string BUT_CANCLE;

	private string BUT_ABORT;

	private string BUT_RETRY;

	private string BUT_IGNORE;

	private string BUT_YES;

	private string BUT_NO;

	private IntPtr _hook;

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int UnhookWindowsHookEx(IntPtr idHook);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern bool SetDlgItemText(IntPtr hWnd, int nIDDlgItem, string lpString);

	public void HookDialog()
	{
		UnHookDialog();
		_hook = SetWindowsHookEx(5, DialogHookProc, IntPtr.Zero, AppDomain.GetCurrentThreadId());
	}

	public void UnHookDialog()
	{
		if (!_hook.Equals((object?)(nint)IntPtr.Zero))
		{
			UnhookWindowsHookEx(_hook);
		}
	}

	public CSysMsgBoxHook()
	{
		BUT_OK = "&Nhận";
		BUT_CANCLE = "&Hủy bỏ";
		BUT_ABORT = "&Hủy";
		BUT_RETRY = "&Thử lại";
		BUT_IGNORE = "&Bỏ qua";
		BUT_YES = "&Có";
		BUT_NO = "&Không";
		ResourceManager resourceManager = new ResourceManager(typeof(CSysMsgBoxHook));
		BUT_NO = resourceManager.GetString("CSysMsgBoxHook.BUT_NO");
		BUT_YES = resourceManager.GetString("CSysMsgBoxHook.BUT_YES");
		BUT_OK = resourceManager.GetString("CSysMsgBoxHook.BUT_OK");
		BUT_CANCLE = resourceManager.GetString("CSysMsgBoxHook.BUT_CANCLE");
		BUT_ABORT = resourceManager.GetString("CSysMsgBoxHook.BUT_ABORT");
		BUT_RETRY = resourceManager.GetString("CSysMsgBoxHook.BUT_RETRY");
		BUT_IGNORE = resourceManager.GetString("CSysMsgBoxHook.BUT_IGNORE");
	}

	private IntPtr DialogHookProc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		if (nCode < 0)
		{
			return CallNextHookEx(_hook, nCode, wParam, lParam);
		}
		if ((long)nCode == 5)
		{
			SetDlgItemText(wParam, 1, BUT_OK);
			SetDlgItemText(wParam, 2, BUT_CANCLE);
			SetDlgItemText(wParam, 3, BUT_ABORT);
			SetDlgItemText(wParam, 4, BUT_RETRY);
			SetDlgItemText(wParam, 5, BUT_IGNORE);
			SetDlgItemText(wParam, 6, BUT_YES);
			SetDlgItemText(wParam, 7, BUT_NO);
			UnhookWindowsHookEx(_hook);
		}
		return CallNextHookEx(_hook, nCode, wParam, lParam);
	}
}
