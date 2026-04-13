# SORptBK02.dll - Bảng kê chứng từ bán hàng 02

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptBK02.dll |
| **Chức năng** | Bảng kê hóa đơn nhóm theo chỉ tiêu |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptBK02 |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL bảng kê hóa đơn nhóm theo chỉ tiêu. Cho phép nhóm và lọc dữ liệu hóa đơn bán hàng theo nhiều tiêu chí khác nhau.

## Cấu trúc Form

### frmSORptBK02

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboNhom_theo | AsComboBox | Nhóm theo chỉ tiêu |
| txtSo_ct1 | TextBox | Chứng từ số từ |
| txtSo_ct2 | TextBox | Chứng từ số đến |
| cboLoaiPhieu | AsComboBox | Loại phiếu |
| cboTrang_Thai | AsComboBox | Trạng thái |
| txtMa_kh | AsTextBox | Mã khách hàng |
| txtMa_nhkh | AsTextBox | Nhóm khách hàng |
| txtMa_plkh1 | AsTextBox | Phân loại khách hàng 1 |
| txtMa_plkh2 | AsTextBox | Phân loại khách hàng 2 |
| txtMa_plkh3 | AsTextBox | Phân loại khách hàng 3 |
| txtMa_hd | AsTextBox | Mã hợp đồng |
| txtMa_nhhd | AsTextBox | Nhóm hợp đồng |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_nhvt | AsTextBox | Nhóm vật tư |
| txtMa_plvt1 | AsTextBox | Phân loại vật tư 1 |
| txtMa_plvt2 | AsTextBox | Phân loại vật tư 2 |
| txtMa_plvt3 | AsTextBox | Phân loại vật tư 3 |
| txtMa_kho | AsTextBox | Mã kho |
| txtMa_bp | AsTextBox | Mã bộ phận |
| txtMa_nvkd | AsTextBox | Mã nhân viên kinh doanh |
| txtMA_HTTT | AsTextBox | Hình thức thanh toán |
| txtMA_DKTT | AsTextBox | Điều khoản thanh toán |
| txtMa_vitri | AsTextBox | Mã vị trí |
| txtMa_Lo | AsTextBox | Mã lô |
| txtMa_spct | AsTextBox | Mã sản phẩm chi tiết |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |

## Business Logic

### Phương thức LoadData()

Xây dựng danh sách tham số và gọi stored procedure:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(txtNgay1.Value);
arrayList.Add(txtNgay2.Value);
arrayList.Add(cboLoaiPhieu.SelectedValue);
arrayList.Add(cboNhom_theo.SelectedValue);
arrayList.Add(txtMa_kh.Text);
arrayList.Add(txtMa_nhkh.Text);
arrayList.Add(txtMa_vt.Text);
arrayList.Add(txtMa_nhvt.Text);
arrayList.Add(txtMa_kho.Text);
arrayList.Add(txtMa_vitri.Text);
arrayList.Add(txtMa_Lo.Text);
arrayList.Add(txtMA_HTTT.Text);
arrayList.Add(txtMA_DKTT.Text);
arrayList.Add(txtMa_bp.Text);
arrayList.Add(txtMa_nvkd.Text);
arrayList.Add(txtMa_spct.Text);
arrayList.Add(txtMa_hd.Text);
arrayList.Add(txtMa_nhhd.Text);
arrayList.Add(txtMa_Nt.Text);
arrayList.Add(txtSo_ct1.Text);
arrayList.Add(txtSo_ct2.Text);
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

- Tập trung vào việc nhóm hóa đơn theo các chỉ tiêu khác nhau
- Hỗ trợ lọc theo số chứng từ từ/đến
- Cho phép chọn trạng thái và loại phiếu
