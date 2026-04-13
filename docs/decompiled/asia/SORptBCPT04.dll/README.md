# SORptBCPT04.dll - Báo cáo phân tích bán hàng 04

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptBCPT04.dll |
| **Chức năng** | Báo cáo phân tích bán hàng 04 |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptBCPT04 |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo doanh số theo bộ phận/nhân viên bán hàng. Cung cấp phân tích chi tiết doanh số bán hàng theo các tiêu chí như bộ phận, nhân viên kinh doanh, khách hàng, vật tư.

## Cấu trúc Form

### frmSORptBCPT04

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_NhKh | AsTextBox | Nhóm khách hàng |
| txtMa_Plkh1 | AsTextBox | Phân loại khách hàng 1 |
| txtMa_Plkh2 | AsTextBox | Phân loại khách hàng 2 |
| txtMa_Plkh3 | AsTextBox | Phân loại khách hàng 3 |
| txtMa_hd | AsTextBox | Mã hợp đồng |
| txtMa_nhhd | AsTextBox | Nhóm hợp đồng |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_nhvt | AsTextBox | Nhóm vật tư |
| txtMa_plvt1 | AsTextBox | Phân loại vật tư 1 |
| txtMa_plvt2 | AsTextBox | Phân loại vật tư 2 |
| txtMa_plvt3 | AsTextBox | Phân loại vật tư 3 |
| txtMa_kho | AsTextBox | Mã kho |
| txtMa_Bp | AsTextBox | Mã bộ phận |
| txtMa_Nvkd | AsTextBox | Mã nhân viên kinh doanh |
| txtMA_HTTT | AsTextBox | Hình thức thanh toán |
| txtMA_DKTT | AsTextBox | Điều khoản thanh toán |
| txtMa_vitri | AsTextBox | Mã vị trí |
| txtMaLo | AsTextBox | Mã lô |
| txtMa_spct | AsTextBox | Mã sản phẩm chi tiết |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| ChkTra_lai | AsCheckBox | Trừ hàng bán trả lại |
| ChkTra_ck | AsCheckBox | Hàng chiết khấu |
| ChkKhuyen_mai | AsCheckBox | Hàng trả khuyến mãi |
| ChkHang_ban | AsCheckBox | Hàng bán |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo Crystal |

## Business Logic

### Phương thức LoadData()

Xây dựng danh sách tham số và gọi stored procedure:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(txtNgay1.Value);
arrayList.Add(txtNgay2.Value);
arrayList.Add(txtMa_Kh.Text);
arrayList.Add(txtMa_NhKh.Text);
arrayList.Add(txtMa_vt.Text);
arrayList.Add(txtMa_nhvt.Text);
arrayList.Add(txtMa_kho.Text);
arrayList.Add(txtMa_Bp.Text);
arrayList.Add(txtMa_Nvkd.Text);
arrayList.Add(txtMa_hd.Text);
arrayList.Add(txtMa_nhhd.Text);
arrayList.Add(txtMa_plvt1.Text);
arrayList.Add(txtMa_plvt2.Text);
arrayList.Add(txtMa_plvt3.Text);
arrayList.Add(ChkKhuyen_mai.Checked);
arrayList.Add(ChkTra_ck.Checked);
arrayList.Add(ChkHang_ban.Checked);
arrayList.Add(ChkTra_lai.Checked);
arrayList.Add(txtMa_Nt.Text);
arrayList.Add(txtMa_Plkh1.Text);
arrayList.Add(txtMa_Plkh2.Text);
arrayList.Add(txtMa_Plkh3.Text);
arrayList.Add(txtMA_HTTT.Text);
arrayList.Add(txtMA_DKTT.Text);
arrayList.Add(txtMa_vitri.Text);
arrayList.Add(txtMaLo.Text);
arrayList.Add(cboMau_bc.SelectedValue.ToString());
```

### Drill-down

Hỗ trợ drill-down khi nhấn F4 trên dòng có mã vật tư:
- Drill-down menu: SORptF5BCPT04
- Truyền tham số chi tiết theo dòng được chọn

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
-