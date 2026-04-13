# Phân tích DLL: ARDMNHKH.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARDMNHKH.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARDMNHKH, frmARDMNHKHEdit |
| **Kế thừa** | frmDmView, frmDmEdit |
| **Chức năng** | Danh mục nhóm khách hàng (Accounts Receivable Customer Group) |

## 2. Forms

### 2.1 frmARDMNHKH (View Form)

**Mô tả:** Form xem danh mục nhóm khách hàng

**Chức năng:**
- Hiển thị danh sách nhóm khách hàng
- Tìm kiếm nhóm
- Phân trang

### 2.2 frmARDMNHKHEdit (Edit Form)

**Mô tả:** Form thêm/sửa nhóm khách hàng

**Chức năng:**
- Nhập mã và tên nhóm khách hàng
- Mô tả nhóm

## 3. Cấu trúc dữ liệu nhóm khách hàng

| Trường | Mô tả |
|--------|-------|
| ma_nhkh | Mã nhóm khách hàng (khóa chính) |
| ten_nhkh | Tên nhóm khách hàng |
| ghi_chu | Ghi chú |
| ksd | Khóa sử dụng |

## 4. Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| dgvDM | DataGridView | Lưới hiển thị danh mục |
| txtMa_NhKh | AsTextBox | Mã nhóm khách hàng |
| txtTen_NhKh | TextBox | Tên nhóm khách hàng |
| txtGhi_Chu | TextBox | Ghi chú |
| chkKsd | AsCheckBox | Khóa sử dụng |

## 5. Business Logic

### Validate
- Mã nhóm không được trống
- Mã nhóm không được trùng
- Tên nhóm bắt buộc nhập

### Lookup
- Được sử dụng trong form khách hàng (ARDMKH) để chọn nhóm

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`

## 7. Ghi chú

- Danh mục đơn giản, chỉ có mã và tên
- Được sử dụng để phân loại khách hàng trong các báo cáo công nợ
