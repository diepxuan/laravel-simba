# SORptTH01.dll - Báo cáo tổng hợp bán hàng 01

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptTH01.dll |
| **Chức năng** | Tổng hợp bán hàng |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptTH01 |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo tổng hợp bán hàng. Cung cấp tổng quan về doanh số bán hàng với nhiều tiêu chí lọc đa dạng.

## Cấu trúc Form

### frmSORptTH01

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboLoaiPhieu | AsComboBox | Loại phiếu |
| cboTrang_Thai | AsComboBox | Trạng thái |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_NhKh | AsTextBox | Nhóm khách hàng |
| txtMa_plkh1 | AsTextBox | Phân loại khách hàng 1 |
| txtMa_plkh2 | AsTextBox | Phân loại khách hàng 2 |
| txtMa_plkh3 | AsTextBox | Phân loại khách hàng 3 |
| txtMa_hd | AsTextBox | Mã hợp đồng |
| txtMa_nhhd | AsTextBox | Nhóm hợp đồng |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_nhvt | AsTextBox | Nhóm vật tư |
| txtMa_kho | AsTextBox | Mã kho |
| txtMa_bp | AsTextBox | Mã bộ phận |
| txtMa_nvkd | AsTextBox | Mã nhân viên kinh doanh |
| txtMA_HTTT | AsTextBox | Hình thức thanh toán |
| txtMA_DKTT | AsTextBox | Điều khoản thanh toán |
| txtMa_vitri | AsTextBox | Mã vị trí |
| txtMaLo | AsTextBox | Mã lô |
| txtMa_spct | AsTextBox | Mã sản phẩm chi tiết |
| txtMa_plvt1 | AsTextBox | Phân loại vật tư 1 |
| txtMa_plvt2 | AsTextBox | Phân loại vật tư 2 |
| txtMa_plvt3 | AsTextBox | Phân loại vật tư 3 |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| ChkTra_lai | AsCheckBox | Trừ hàng bán trả lại |
| ChkTra_ck | AsCheckBox | Hàng chiết khấu |
| ChkKhuyen_mai | AsCheckBox | Hàng trả khuyến mãi |
| ChkHang_ban | AsCheckBox | Hàng bán |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |

#### Các Label hiển thị tên

- lblTen_Kh, lblTen_NhKh, lblTen_plkh1, lblTen_plkh2, lblTen_plkh3
- lblTen_Hd, lblTen_nhhd, lblTen_vt, lblTen_nhvt
- lblTen_kho, lblTen_bp, lblTen_nvkd
- lblTenHTTT, lblTen_TT
- lblTen_lo, lblTen_spct
- lblTen_vitri, lblTen_Tk

## Business Logic

### cboMau_bc_SelectedIndexChanged()

Xử lý khi thay đổi mẫu báo cáo:

```csharp
private void cboMau_bc_SelectedIndexChanged(object sender, EventArgs e)
{
    // Xử lý thay đổi mẫu báo cáo
}
```

### LoadData()

Xây dựng danh sách tham số và gọi stored procedure:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(txtNgay1.Value);
arrayList.Add(txtNgay2.Value);
arrayList.Add(cboLoaiPhieu.SelectedValue);
arrayList.Add(cboTrang_Thai.SelectedValue);
arrayList.Add(txtMa_Kh.Text);
arrayList.Add(txtMa_NhKh.Text);
arrayList.Add(txtMa_vt.Text);
arrayList.Add(txtMa_nhvt.Text);
arrayList.Add(txtMa_kho.Text);
arrayList.Add(txtMa_bp.Text);
arrayList.Add(txtMa_nvkd.Text);
arrayList.Add(txtMa_hd.Text);
arrayList.Add(txtMa_nhhd.Text);
arrayList.Add(txtMA_HTTT.Text);
arrayList.Add(txtMA_DKTT.Text);
arrayList.Add(txtMa_vitri.Text);
arrayList.Add(txtMaLo.Text);
arrayList.Add(txtMa_spct.Text);
arrayList.Add(txtMa_Nt.Text);
arrayList.Add(ChkKhuyen_mai.Checked);
arrayList.Add(ChkTra_ck.Checked);
arrayList.Add(ChkHang_ban.Checked);
arrayList.Add(ChkTra_lai.Checked);
arrayList.Add(txtMa_plkh1.Text);
arrayList.Add(txtMa_plkh2.Text);
arrayList.Add(txtMa_plkh3.Text);
arrayList.Add(txtMa_plvt1.Text);
arrayList.Add(txtMa_plvt2.Text);
arrayList.Add(txtMa_plvt3.Text);
```

### GetFilterTitle()

Xây dựng chuỗi tiêu đề lọc từ các điều kiện đã chọn.

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
- System.Data
- Microsoft.VisualBasic

## Ghi chú

- Báo cáo tổng hợp với đầy đủ các tiêu chí lọc
- Hỗ trợ lọc theo loại phiếu và trạng thái
- Có thể lọc theo 3 cấp phân loại khách hàng và vật tư
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Có thể xuất Excel
