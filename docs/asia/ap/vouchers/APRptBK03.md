# Phân tích DLL: APRptBK03.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | APRptBK03.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmAPRptBK03 |
| **Kế thừa** | frmReport |
| **Chức năng** | Bảng kê chứng từ thanh toán |

## 2. Forms

### 2.1 frmAPRptBK03 (Report Form)

**Mô tả:** Form báo cáo bảng kê chứng từ thanh toán

**Controls - Phần lọc:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Kh | AsTextBox | MA_KH | Mã khách hàng/NCC |
| txtMa_NhKh | AsTextBox | DMNHKH | Nhóm khách hàng |
| txtMa_plkh1 | AsTextBox | DMPLKH | Phân loại KH 1 |
| txtMa_plkh2 | AsTextBox | DMPLKH | Phân loại KH 2 |
| txtMa_plkh3 | AsTextBox | DMPLKH | Phân loại KH 3 |
| cboGiao_dich | ComboBox | - | Loại giao dịch |
| txtSo_Ct1 | TextBox | - | Chứng từ từ số |
| txtSo_Ct2 | TextBox | - | Chứng từ đến số |
| ChkSap_xep | CheckBox | - | Sắp xếp theo KH |
| cboChi_xem | ComboBox | - | Chỉ xem (trạng thái) |

**Giá trị ComboBox cboGiao_dich:**

| Giá trị | Mô tả |
|---------|-------|
| 0 | Tất cả |
| 1 | Hóa đơn |
| 2 | Đơn hàng |

**Giá trị ComboBox cboChi_xem:**

| Giá trị | Mô tả |
|---------|-------|
| 0 | Tất toán |
| 1 | Chưa tất toán |
| 2 | Tất cả |

**Tiêu đề UI:**

- "Bảng kê phiếu chi thanh toán tiền hàng" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng"
- "Nhóm KH" (Nhóm khách hàng)
- "P.Loại KH1", "P.Loại KH2", "P.Loại KH3"
- "Giao dịch" - Loại giao dịch (Hóa đơn/Đơn hàng)
- "Chứng từ số", "đến số"
- "Sắp xếp" - Tùy chọn sắp xếp
- "Chỉ xem" - Lọc trạng thái

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPRptBK03 | Bảng kê chứng từ thanh toán |

## 4. Báo cáo

### 4.1 Thông tin báo cáo

| Thuộc tính | Giá trị |
|------------|---------|
| **Tiêu đề** | Bảng kê phiếu chi thanh toán tiền hàng |
| **Loại** | Bảng kê chi tiết |
| **Công cụ** | Crystal Reports |

### 4.2 Cột báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng/NCC |
| ten_kh | Tên khách hàng |
| so_ct | Số chứng từ thanh toán |
| ngay_ct | Ngày chứng từ |
| dien_giai | Diễn giải |
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| t_tien | Tổng tiền |
| t_tien_nt | Tổng tiền ngoại tệ |
| da_tat_toan | Đã tất toán |
| con_lai | Còn lại |

## 5. Lọc dữ liệu

### 5.1 Các tiêu chí lọc

- **Khách hàng/NCC:** Lọc theo mã KH, nhóm KH
- **Phân loại:** Lọc theo 3 cấp phân loại KH
- **Giao dịch:** Lọc theo loại giao dịch (hóa đơn/đơn hàng)
- **Số chứng từ:** Lọc theo khoảng số CT
- **Trạng thái:** Lọc theo trạng thái tất toán

### 5.2 Xử lý lọc

```csharp
// Xử lý sự kiện GotFocus cho combobox
private void cboGiao_dich_GotFocus(object sender, EventArgs e)
{
    // Load danh sách giao dịch từ DmMagd
    LoadGiaoDichList("par1");
}

// Xử lý thay đổi lựa chọn
private void cboChi_xem_SelectedIndexChanged(object sender, EventArgs e)
{
    // Cập nhật trạng thái lọc
    UpdateFilterStatus();
}
```

## 6. Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |

## 7. Tables liên quan

| Table | Mô tả |
|-------|-------|
| CA1CT | Chứng từ chi tiền |
| DMKH | Danh mục khách hàng/NCC |
| DMNHKH | Danh mục nhóm KH |
| DMPLKH | Danh mục phân loại KH |
| DMNT | Danh mục ngoại tệ |
| DmMagd | Danh mục giao dịch |
