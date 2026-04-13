namespace AsiaERP.UserInterface;

public class VoucherInfoDatasource
{
	public string ma_ct { get; set; }

	public string ten_ct { get; set; }

	public VoucherInfoDatasource(string ma, string ten)
	{
		ma_ct = ma;
		ten_ct = ten;
	}

	public VoucherInfoDatasource()
	{
	}
}
