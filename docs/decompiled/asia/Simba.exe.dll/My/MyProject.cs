using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public dcBottomMenu m_dcBottomMenu;

		public dcCenterMenu m_dcCenterMenu;

		public dcModuleMenu m_dcModuleMenu;

		public dcReportMenu m_dcReportMenu;

		public frmChonDmdvcs m_frmChonDmdvcs;

		public frmDmdvcsEdit m_frmDmdvcsEdit;

		public frmLeftMenuModul m_frmLeftMenuModul;

		public frmLogin m_frmLogin;

		public frmProductAuthentication m_frmProductAuthentication;

		public frmRegister m_frmRegister;

		public frmRightMenu m_frmRightMenu;

		public FrmSimbaMenu m_FrmSimbaMenu;

		public frmSimbaStartup m_frmSimbaStartup;

		public frmSmVideo m_frmSmVideo;

		public frmT1TreeMenu m_frmT1TreeMenu;

		public frmT2DetailMenu m_frmT2DetailMenu;

		public frmT2ModuleMenu m_frmT2ModuleMenu;

		public frmT2Startup m_frmT2Startup;

		public frmT3DetailMenu m_frmT3DetailMenu;

		public frmT3ModuleMenu m_frmT3ModuleMenu;

		public FrmT3Startup m_FrmT3Startup;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public dcBottomMenu dcBottomMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_dcBottomMenu = Create__Instance__(m_dcBottomMenu);
				return m_dcBottomMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_dcBottomMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_dcBottomMenu);
				}
			}
		}

		public dcCenterMenu dcCenterMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_dcCenterMenu = Create__Instance__(m_dcCenterMenu);
				return m_dcCenterMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_dcCenterMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_dcCenterMenu);
				}
			}
		}

		public dcModuleMenu dcModuleMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_dcModuleMenu = Create__Instance__(m_dcModuleMenu);
				return m_dcModuleMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_dcModuleMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_dcModuleMenu);
				}
			}
		}

		public dcReportMenu dcReportMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_dcReportMenu = Create__Instance__(m_dcReportMenu);
				return m_dcReportMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_dcReportMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_dcReportMenu);
				}
			}
		}

		public frmChonDmdvcs frmChonDmdvcs
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmChonDmdvcs = Create__Instance__(m_frmChonDmdvcs);
				return m_frmChonDmdvcs;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmChonDmdvcs)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmChonDmdvcs);
				}
			}
		}

		public frmDmdvcsEdit frmDmdvcsEdit
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmDmdvcsEdit = Create__Instance__(m_frmDmdvcsEdit);
				return m_frmDmdvcsEdit;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmDmdvcsEdit)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmDmdvcsEdit);
				}
			}
		}

		public frmLeftMenuModul frmLeftMenuModul
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmLeftMenuModul = Create__Instance__(m_frmLeftMenuModul);
				return m_frmLeftMenuModul;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmLeftMenuModul)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmLeftMenuModul);
				}
			}
		}

		public frmLogin frmLogin
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmLogin = Create__Instance__(m_frmLogin);
				return m_frmLogin;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmLogin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmLogin);
				}
			}
		}

		public frmProductAuthentication frmProductAuthentication
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmProductAuthentication = Create__Instance__(m_frmProductAuthentication);
				return m_frmProductAuthentication;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmProductAuthentication)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmProductAuthentication);
				}
			}
		}

		public frmRegister frmRegister
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmRegister = Create__Instance__(m_frmRegister);
				return m_frmRegister;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmRegister)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmRegister);
				}
			}
		}

		public frmRightMenu frmRightMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmRightMenu = Create__Instance__(m_frmRightMenu);
				return m_frmRightMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmRightMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmRightMenu);
				}
			}
		}

		public FrmSimbaMenu FrmSimbaMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmSimbaMenu = Create__Instance__(m_FrmSimbaMenu);
				return m_FrmSimbaMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmSimbaMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmSimbaMenu);
				}
			}
		}

		public frmSimbaStartup frmSimbaStartup
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmSimbaStartup = Create__Instance__(m_frmSimbaStartup);
				return m_frmSimbaStartup;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmSimbaStartup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmSimbaStartup);
				}
			}
		}

		public frmSmVideo frmSmVideo
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmSmVideo = Create__Instance__(m_frmSmVideo);
				return m_frmSmVideo;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmSmVideo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmSmVideo);
				}
			}
		}

		public frmT1TreeMenu frmT1TreeMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT1TreeMenu = Create__Instance__(m_frmT1TreeMenu);
				return m_frmT1TreeMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT1TreeMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT1TreeMenu);
				}
			}
		}

		public frmT2DetailMenu frmT2DetailMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT2DetailMenu = Create__Instance__(m_frmT2DetailMenu);
				return m_frmT2DetailMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT2DetailMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT2DetailMenu);
				}
			}
		}

		public frmT2ModuleMenu frmT2ModuleMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT2ModuleMenu = Create__Instance__(m_frmT2ModuleMenu);
				return m_frmT2ModuleMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT2ModuleMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT2ModuleMenu);
				}
			}
		}

		public frmT2Startup frmT2Startup
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT2Startup = Create__Instance__(m_frmT2Startup);
				return m_frmT2Startup;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT2Startup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT2Startup);
				}
			}
		}

		public frmT3DetailMenu frmT3DetailMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT3DetailMenu = Create__Instance__(m_frmT3DetailMenu);
				return m_frmT3DetailMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT3DetailMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT3DetailMenu);
				}
			}
		}

		public frmT3ModuleMenu frmT3ModuleMenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmT3ModuleMenu = Create__Instance__(m_frmT3ModuleMenu);
				return m_frmT3ModuleMenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmT3ModuleMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmT3ModuleMenu);
				}
			}
		}

		public FrmT3Startup FrmT3Startup
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmT3Startup = Create__Instance__(m_FrmT3Startup);
				return m_FrmT3Startup;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmT3Startup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmT3Startup);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (((Control)Instance).IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance/*cast due to .constrained prefix*/).Dispose();
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<My.MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<My.MyComputer>();

	private static readonly ThreadSafeObjectProvider<My.MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<My.MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static My.MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static My.MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
