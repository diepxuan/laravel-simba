# Phân tích DLL: APRptBK02.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | APRptBK02.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmAPRptBK02 |
| **Kế thừa** | frmReport |
| **Chức năng** | Bảng kê công nợ phải trả theo hạn thanh toán |

## 2. Forms

### 2.1 frmAPRptBK02 (Report Form)

**Mô tả:** Form báo cáo bảng kê công nợ theo hạn thanh toán

**Controls - Phần lọc:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtNgay_Ss | DateTimePicker | - | Ngày so sánh |
| txtHan_ky1 | TextNumeric | - | Hạn kỳ 1 (ngày) |
| txtHan_ky2 | TextNumeric | - | Hạn kỳ 2 (ngày) |
| txtHan_ky3 | TextNumeric | - | Hạn kỳ 3 (ngày) |
| txtMa_Kh | AsTextBox | MA_KH | Mã nhà cung cấp |
| txtMa_NhKh | AsTextBox | DMNHKH | Nhóm nhà cung cấp |
| ChkSap_xep | CheckBox | - | Sắp xếp theo NCC |
| cboChi_xem | ComboBox | - | Chỉ xem (trạng thái) |

**Giá trị ComboBox cboChi_xem:**

| Giá trị | Mô tả |
|---------|-------|
| 0 | Các hóa đơn chưa tất toán |
| 1 | Các hóa đơn đã tất toán |
| 2 | Tất cả các hóa đơn |

**Tiêu đề UI:**

- "Bảng kê hóa đơn theo hạn thanh toán" - Tên chức năng chính
- "Ngày so sánh" - Ngày để so sánh hạn thanh toán
- "Hạn kỳ 1", "Hạn kỳ 2", "Hạn kỳ 3" - Các mốc hạn thanh toán
- "Mã NCC" (Nhà cung cấp)
- "Nhóm NCC"
- "Sắp xếp" - Tùy chọn sắp xếp theo nhà cung cấp
- "Chỉ xem" - Lọc trạng thái hóa đơn

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPRptBK02 | Bảng kê công nợ theo hạn thanh toán |

## 4. Báo cáo

### 4.1 Thông tin báo cáo

| Thuộc tính | Giá trị |
|------------|---------|
| **Tiêu đề** | Bảng kê hóa đơn theo hạn thanh toán |
| **Loại** | Aging Report |
| **Công cụ** | Crystal Reports |

### 4.2 Phân loại công nợ

| Nhóm | Mô tả | Công thức |
|------|-------|-----------|
| Chưa đến hạn | Hóa đơn chưa đến hạn TT | Ngày đến hạn > Ngày so sánh |
| Hạn kỳ 1 | Quá hạn trong kỳ 1 | 0 < Số ngày quá hạn ≤ Hạn kỳ 1 |
| Hạn kỳ 2 | Quá hạn trong kỳ 2 | Hạn kỳ 1 < Số ngày ≤ Hạn kỳ 2 |
| Hạn kỳ 3 | Quá hạn trong kỳ 3 | Hạn kỳ 2 < Số ngày ≤ Hạn kỳ 3 |
| Quá hạn | Quá hạn kỳ 3 | Số ngày > Hạn kỳ 3 |

### 4.3 Cột báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã nhà cung cấp |
| ten_kh | Tên nhà cung cấp |
| so_ct | Số hóa đơn |
| ngay_ct | Ngày hóa đơn |
| ngay_han_tt | Ngày hạn thanh toán |
| so_ngay_qh | Số ngày quá hạn |
| t_tt | Tổng thanh toán |
| da_tt | Đã thanh toán |
| con_no | Còn nợ |
| chua_den_han | Công nợ chưa đến hạn |
| han_ky_1 | Công nợ hạn kỳ 1 |
| han_ky_2 | Công nợ hạn kỳ 2 |
| han_ky_3 | Công nợ hạn kỳ 3 |
| qua_han | Công nợ quá hạn |

## 5. Business Logic

### 5.1 Aging Calculation

```csharp
// Tính số ngày quá hạn
private int TinhSoNgayQuaHan(DateTime ngayHanTT, DateTime ngaySoSanh)
{
    return (ngaySoSanh - ngayHanTT).Days;
}

// Phân loại công nợ theo hạn kỳ
private string PhanLoaiCongNo(int soNgayQuaHan, int hanKy1, int hanKy2, int hanKy3)
{
    if (soNgayQuaHan <= 0)
        return "ChuaDenHan";
    else if (soNgayQuaHan <= hanKy1)
        return "HanKy1";
    else if (soNgayQuaHan <= hanKy2)
        return "HanKy2";
    else if (soNgayQuaHan <= hanKy3)
        return "HanKy3";
    else
        return "QuaHan";
}
```

### 5.2 Cấu hình hạn kỳ

- Hạn kỳ 1, 2, 3 được cấu hình trong SOConfiguration
- Giá trị mặc định: han_tt_ss1, han_tt_ss2, han_tt_ss3
- Validation: Hạn kỳ phải >= 0

## 6. Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |

## 7. Tables liên quan

| Table | Mô tả |
|-------|-------|
| MACT | Chứng từ mua hàng |
| DMKH | Danh mục nhà cung cấp |
| DMNHKH | Danh mục nhóm NCC |
| DMNT | Danh mục ngoại tệ |
