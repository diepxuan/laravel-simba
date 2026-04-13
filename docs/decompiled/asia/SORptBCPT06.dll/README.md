# SORptBCPT06.dll - Báo cáo phân tích bán hàng 06

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptBCPT06.dll |
| **Chức năng** | Báo cáo phân tích bán hàng 06 (2 chỉ tiêu) |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptBCPT06 |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo bán hàng 2 chỉ tiêu. Cho phép nhóm và chi tiết hóa dữ liệu theo 2 chiều khác nhau (ví dụ: nhóm theo khách hàng, chi tiết theo vật tư).

## Cấu trúc Form

### frmSORptBCPT06

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboNhom_Theo | AsComboBox | Nhóm theo (KH, BP, HD, HTTT, NVKD, VT) |
| cboChi_Tiet_Theo | AsComboBox | Chi tiết theo (VT, KH, BP, HD, HTTT, NVKD) |
| txtMa_kh | AsTextBox | Mã khách hàng |
| txtMa_Nhkh | AsTextBox | Nhóm khách hàng |
| txtMa_Plkh1 | AsTextBox | Phân loại khách hàng 1 |
| txtMa_Plkh2 | AsTextBox | Phân loại khách hàng 2 |
| txtMa_Plkh3 | AsTextBox | Phân loại khách hàng 3 |
| txtMa_hd | AsTextBox | Mã hợp đồng |
| txtMa_nhhd | AsTextBox | Nhóm hợp đồng |
| txtMa_HTTT | AsTextBox | Hình thức thanh toán |
| txtMa_kho | AsTextBox | Mã kho |
| txtMa_bp | AsTextBox | Mã bộ phận |
| txtMa_nvkd | AsTextBox | Mã nhân viên kinh doanh |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_nhvt | AsTextBox | Nhóm vật tư |
| txtMa_Plvt1 | AsTextBox | Phân loại vật tư 1 |
| txtMa_Plvt2 | AsTextBox | Phân loại vật tư 2 |
| txtMa_plvt3 | AsTextBox | Phân loại vật tư 3 |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| ChkTra_lai | AsCheckBox | Trừ hàng bán trả lại |
| ChkTra_ck | AsCheckBox | Hàng chiết khấu |
| ChkKhuyen_mai | AsCheckBox | Hàng trả khuyến mãi |
| ChkHang_ban | AsCheckBox | Hàng bán |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |

#### Các giá trị ComboBox

**cboNhom_Theo:**
- Khách hàng (Ma_KH)
- Bộ phận (MA_BP)
- Hợp đồng (Ma_HD)
- Hình thức thanh toán (Ma_HTTT)
- Nhân viên kinh doanh (MA_NVKD)
- Vật tư (MA_VT)

**cboChi_Tiet_Theo:**
- Vật tư (Ma_VT)
- Khách hàng (Ma_KH)
- Bộ phận (MA_BP)
- Hợp đồng (MA_HD)
- HTTT (MA_HTTT)
- NVKD (MA_NVKD)

## Business Logic

### InitOtherComponents()

Khởi tạo dữ liệu cho các ComboBox nhóm và chi tiết:

```csharp
Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("Ma_VT", "Vật tư");
dictionary.Add("Ma_KH", "Khách hàng");
dictionary.Add("MA_BP", "Bộ phận");
dictionary.Add("MA_HD", "Hợp đồng");
dictionary.Add("MA_HTTT", "Hình thức thanh toán");
dictionary.Add("MA_NVKD", "Nhân viên kinh doanh");
```

### LoadData()

Xây dựng tham số với các giá trị nhóm và chi tiết:

```csharp
arrayList.Add(cboNhom_Theo.SelectedValue);
arrayList.Add(cboChi_Tiet_Theo.SelectedValue);
```

### Drill-down (CreateDrilldownArgument)

Xử lý drill-down phức tạp theo 2 chiều:
- Kiểm tra keycode F4
- Xác định giá trị nhóm (ma_group) và chi tiết (ma_detail)
- Truyền tham số tương ứng với lựa chọn nhóm/chi tiết

Logic xử lý:
```csharp
if (Nhom_Theo == "MA_KH") 
    arrayList.Add(dataRowView["ma_group"]);
else if (Chi_Tiet_Theo == "MA_KH")
    arrayList.Add(dataRowView["ma_detail"]);
else
    arrayList.Add(txtMa_kh.Text);
```

### convertoToInt()

Chuyển đổi boolean sang int (0/1) cho tham số stored procedure.

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
- System.Data
- Microsoft.VisualBasic

## Ghi chú

- Báo cáo 2 chiều độc đáo, cho phép phân tích theo nhiều góc độ
- ToolTip hiển thị khi text dài hơn width của ComboBox
- Event handlers: cboNhom_Theo_SelectedIndexChanged, cboChi_Tiet_Theo_GotFocus
