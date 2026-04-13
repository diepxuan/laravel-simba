# Phân tích DLL: ARRptBK03.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBK03.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBK03 |
| **Kế thừa** | frmReport |
| **Chức năng** | Bảng kê chứng từ thanh toán (Payment Documents Listing) |

## 2. Forms

### 2.1 frmARRptBK03 (Report Form)

**Mô tả:** Form bảng kê chứng từ thanh toán

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_NhKh | AsTextBox | Mã nhóm KH |
| txtMa_plkh1/2/3 | AsTextBox | Phân loại KH |
| txtSo_Ct1/txtSo_Ct2 | TextBox | Số chứng từ từ/đến |
| cboGiao_dich | ComboBox | Loại giao dịch |
| cboChi_xem | ComboBox | Loại tất toán |
| ChkSap_xep | AsCheckBox | Sắp xếp theo khách hàng |

**Chức năng:**
- Liệt kê phiếu thu thanh toán
- Lọc theo loại giao dịch
- Theo dõi trạng thái tất toán

## 3. Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ngay_ct | Ngày chứng từ |
| so_ct | Số chứng từ |
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| ma_gd | Mã giao dịch |
| ten_gd | Tên giao dịch |
| tien | Số tiền thanh toán |
| da_tat_toan | Đã tất toán |
| con_lai | Còn lại |

## 4. Business Logic

### Loại giao dịch
- Lấy từ danh mục giao dịch theo par1 của menu
- Hiển thị mô tả giao dịch

### Tất toán
- `cboChi_xem` có 3 giá trị:
  - Chưa tất toán
  - Tất toán
  - Tất cả

### Sắp xếp
- Có thể sắp xếp theo khách hàng

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBK03 | Lấy dữ liệu bảng kê chứng từ thanh toán |

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Data`

## 7. Ghi chú

- Theo dõi các khoản thanh toán từ khách hàng
- Phân loại theo loại giao dịch
- Kiểm tra trạng thái tất toán
