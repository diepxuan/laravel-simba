# Phân tích DLL: ARRptBK02.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBK02.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBK02 |
| **Kế thừa** | frmReport |
| **Chức năng** | Bảng kê công nợ theo hạn (Aging Report Listing) |

## 2. Forms

### 2.1 frmARRptBK02 (Report Form)

**Mô tả:** Form bảng kê công nợ theo hạn

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtNgay_Ss | AsMaskedTextBox | Ngày so sánh |
| txtHan_ky1 | AsTextNumeric | Hạn kỳ 1 |
| txtHan_ky2 | AsTextNumeric | Hạn kỳ 2 |
| txtHan_ky3 | AsTextNumeric | Hạn kỳ 3 |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_NhKh | AsTextBox | Mã nhóm KH |
| txtMaTT | AsTextBox | Mã điều khoản TT |
| cboChi_xem | ComboBox | Chỉ xem (Chưa tất toán/Tất toán/Tất cả) |
| ChkSap_xep | AsCheckBox | Sắp xếp theo khách hàng |

**Chức năng:**
- Liệt kê hóa đơn theo hạn thanh toán
- Phân loại công nợ theo độ tuổi
- Lọc theo trạng thái tất toán

## 3. Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| so_ct | Số hóa đơn |
| ngay_ct | Ngày hóa đơn |
| han_tt | Hạn thanh toán |
| so_ngay_qua_han | Số ngày quá hạn |
| gia_tri_hd | Giá trị hóa đơn |
| da_tt | Đã thanh toán |
| con_phai_tt | Còn phải thanh toán |

## 4. Business Logic

### Tính hạn kỳ
```csharp
txtHan_ky1.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss1;
txtHan_ky2.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss2;
txtHan_ky3.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss3;
```

### Phân loại tất toán
- `cboChi_xem` có 3 giá trị:
  - 0: Chưa tất toán
  - 1: Tất toán
  - 2: Tất cả

### Sắp xếp
- `ChkSap_xep`: Sắp xếp theo khách hàng

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBK02 | Lấy dữ liệu bảng kê công nợ theo hạn |

## 6. Dependencies

- `AsiaErp.Framework`
- `Microsoft.VisualBasic`
- `System.Data`

## 7. Ghi chú

- Báo cáo chi tiết theo hóa đơn
- Phân loại theo độ tuổi công nợ
- Hỗ trợ theo dõi công nợ quá hạn
