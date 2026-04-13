# Phân tích DLL: ARDMPLKH.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARDMPLKH.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARDMPLKH, frmARDMPLKHEdit |
| **Kế thừa** | frmDmView, frmDmEdit |
| **Chức năng** | Danh mục phân loại khách hàng (Accounts Receivable Customer Classification) |

## 2. Forms

### 2.1 frmARDMPLKH (View Form)

**Mô tả:** Form xem danh mục phân loại khách hàng

**Chức năng:**
- Hiển thị danh sách phân loại
- Lọc theo loại phân loại (1, 2, 3)

### 2.2 frmARDMPLKHEdit (Edit Form)

**Mô tả:** Form thêm/sửa phân loại khách hàng

**Chức năng:**
- Nhập mã, tên phân loại
- Chọn loại phân loại (1, 2, 3)

## 3. Cấu trúc dữ liệu phân loại khách hàng

| Trường | Mô tả |
|--------|-------|
| ma_plkh | Mã phân loại khách hàng |
| ten_plkh | Tên phân loại |
| loai | Loại phân loại (1, 2, 3) |
| ghi_chu | Ghi chú |
| ksd | Khóa sử dụng |

## 4. Phân loại theo cấp độ

| Loại | Ý nghĩa | Ví dụ |
|------|---------|-------|
| 1 | Phân loại chính | Ngành nghề, lĩnh vực kinh doanh |
| 2 | Phân loại phụ | Khu vực địa lý, thị trường |
| 3 | Phân loại bổ sung | Mức độ quan trọng, đánh giá |

## 5. Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_PlKh | AsTextBox | Mã phân loại KH |
| txtTen_PlKh | TextBox | Tên phân loại |
| cboLoai | ComboBox | Loại phân loại (1, 2, 3) |
| txtGhi_Chu | TextBox | Ghi chú |
| chkKsd | AsCheckBox | Khóa sử dụng |

## 6. Business Logic

### Validate
- Mã phân loại không được trống
- Mã phân loại không được trùng trong cùng loại
- Loại phân loại phải là 1, 2 hoặc 3

### Lookup
- Được sử dụng trong form khách hàng (ARDMKH) để chọn phân loại
- Lookup condition: `loai=1`, `loai=2`, `loai=3` tương ứng

## 7. Dependencies

- `AsiaErp