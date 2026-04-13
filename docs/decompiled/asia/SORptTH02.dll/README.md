# SORptTH02.dll - Báo cáo tổng hợp bán hàng 02

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptTH02.dll |
| **Chức năng** | Tổng hợp bán hàng theo kỳ |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptTH02 |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo tổng hợp bán hàng theo kỳ (tháng/quý/năm). Cung cấp cái nhìn tổng quan về doanh số bán hàng qua các kỳ.

## Cấu trúc Form

### frmSORptTH02

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo (ẩn) |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu (ẩn) |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc (ẩn) |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboLoai | ComboBox | Loại xem (Tháng/Quý/Năm) |
| cboLoai_CT | ComboBox | Loại chứng từ |
| txtTu_Thang | AsTextNumeric | Từ tháng |
| txtSo_Ky | AsTextNumeric | Số kỳ |
| txtNam | AsTextNumeric | Năm |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo |

#### Các hằng số

```csharp
private const string THANG = "THANG";
private const string QUY = "QUY";
private const string NAM = "NAM";
```

#### Các giá trị cboLoai

- "Theo tháng"
- "Theo Quý"
- "Theo Năm"

## Business Logic

### cboLoai_SelectedIndexChanged()

Xử lý khi thay đổi loại xem:

```csharp
private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
{
    string text = cboLoai.SelectedItem.ToString();
    if (text.Equals("Theo tháng"))
    {
        lblTu_Thang.Text = "Từ tháng";
        lblSo_Ky.Text = "Số tháng";
        txtTu_Thang.MaxLength = 2;
        txtSo_Ky.MaxLength = 2;
    }
    else if (text.Equals("Theo Quý"))
    {
        lblTu_Thang.Text = "Từ quý";
        lblSo_Ky.Text = "Số quý";
        txtTu_Thang.MaxLength = 1;
        txtSo_Ky.MaxLength = 2;
    }
    else if (text.Equals("Theo Năm"))
    {
        lblTu_Thang.Text = "Năm";
        lblSo_Ky.Text = "Số năm";
        txtTu_Thang.MaxLength = 4;
        txtSo_Ky.MaxLength = 2;
    }
}
```

### LoadData()

Xây dựng tham số cho stored procedure:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(cboLoai_CT.SelectedValue);
arrayList.Add(txtNam.Value);
arrayList.Add(txtTu_Thang.Value);
arrayList.Add(txtSo_Ky.Value);
arrayList.Add(cboLoai.SelectedItem.ToString());
arrayList.Add(txtMa_Nt.Text);
```

### GetFilterTitle()

Xây dựng chuỗi tiêu đề lọc từ các điều kiện đã chọn.

### InitOtherComponents()

Khởi tạo dữ liệu cho cboLoai_CT:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(MyMenuInfo.moduleid);
arrayList.Add("0");
arrayList.Add(SystemInformations.CurrentCultureName);
ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(
    Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray()));
arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
cboLoai_CT.DataSource = arrayList2;
cboLoai_CT.DisplayMember = "TEN_CT";
cboLoai_CT.ValueMember = "MA_CT";
```

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
- CrystalDecisions.Windows.Forms
- System.Data
- Microsoft.VisualBasic

## Ghi chú

- Báo cáo theo kỳ, không dùng ngày trực tiếp
- Sử dụng AsTextNumeric cho các trường số liệu
- Hỗ trợ xem theo tháng, quý, năm linh hoạt
- Có thể chọn số kỳ hiển thị
- Sử dụng Crystal Reports để hiển thị
