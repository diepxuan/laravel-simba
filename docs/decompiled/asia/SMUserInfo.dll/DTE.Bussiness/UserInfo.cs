using System;
using System.Runtime.CompilerServices;

namespace DTE.Bussiness;

[Serializable]
public class UserInfo
{
	private string _username;

	private string _fullname;

	private string _password;

	private object _isadmin;

	private object _notactive;

	private object _grand;

	private string _accesscompanies;

	private string _cuser;

	private string _luser;

	private DateTime _cdate;

	private DateTime _ldate;

	public string username
	{
		get
		{
			return _username;
		}
		set
		{
			_username = value;
		}
	}

	public string fullname
	{
		get
		{
			return _fullname;
		}
		set
		{
			_fullname = value;
		}
	}

	public string password
	{
		get
		{
			return _password;
		}
		set
		{
			_password = value;
		}
	}

	public object isadmin
	{
		get
		{
			return _isadmin;
		}
		set
		{
			_isadmin = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object notactive
	{
		get
		{
			return _notactive;
		}
		set
		{
			_notactive = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object grand
	{
		get
		{
			return _grand;
		}
		set
		{
			_grand = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string accesscompanies
	{
		get
		{
			return _accesscompanies;
		}
		set
		{
			_accesscompanies = value;
		}
	}

	public string cuser
	{
		get
		{
			return _cuser;
		}
		set
		{
			_cuser = value;
		}
	}

	public string luser
	{
		get
		{
			return _luser;
		}
		set
		{
			_luser = value;
		}
	}

	public DateTime cdate
	{
		get
		{
			return _cdate;
		}
		set
		{
			_cdate = value;
		}
	}

	public DateTime ldate
	{
		get
		{
			return _ldate;
		}
		set
		{
			_ldate = value;
		}
	}
}
