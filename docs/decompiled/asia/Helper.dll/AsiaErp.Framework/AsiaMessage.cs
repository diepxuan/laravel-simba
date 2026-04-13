using System.Windows.Forms;

namespace AsiaErp.Framework;

public class AsiaMessage
{
	private int _mess_id;

	private MessageBoxIcon _mess_icon;

	private string _mess_description;

	public int Id
	{
		get
		{
			return _mess_id;
		}
		set
		{
			_mess_id = value;
		}
	}

	public int Icon
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected I4, but got Unknown
			return (int)_mess_icon;
		}
		set
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_mess_icon = (MessageBoxIcon)value;
		}
	}

	public string Description
	{
		get
		{
			return _mess_description;
		}
		set
		{
			_mess_description = value;
		}
	}

	public AsiaMessage()
	{
	}

	public AsiaMessage(int _id, MessageBoxIcon _icon, string _descrpt)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_mess_id = _id;
		_mess_icon = _icon;
		_mess_description = _descrpt;
	}
}
