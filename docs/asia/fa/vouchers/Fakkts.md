# Fakkts - Kiểm kê tài sản cố định

## Mô tả

Module kiểm kê tài sản cố định (Fixed Asset Inventory) - hỗ trợ nhập liệu trực tiếp hoặc import từ Excel.

## Chức năng

### 1. Quản lý Kiểm kê Tài sản
- Nhập liệu kiểm kê tài sản cố định
- Hiển thị danh sách tài sản kiểm kê
- Quản lý thông tin: mã tài sản, số lượng, ngày kiểm kê

### 2. Import từ Excel
- Import dữ liệu kiểm kê từ file Excel
- Sử dụng `Microsoft.Office.Interop.Excel`
- OpenFileDialog để chọn file

### 3. Data Management
- Sử dụng `System.Data.DataTable` làm nguồn dữ liệu
- Binding với DataGridView
- Cập nhật dữ liệu real-time

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFakkts` | `frmAsiaRoot` | Form kiểm kê tài sản cố định |

## DataGridView Columns

| Column | Loại | Mục đích |
|--------|------|----------|
| `dgvcFA_CODE` | `DataGridViewTextBoxColumn` | Mã tài sản |
| `dgvcQuanlity` | `DataGridViewAsTextNumericColumn` | Số lượng |
| `dgvcDate` | `DataGridViewAsMaskedTextBoxColumn` | Ngày kiểm kê |

## Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `Panel1` | `Panel` | Container chính |
| `dgvKK` | `AsDataGridView` | DataGridView hiển thị danh sách kiểm kê |
| `btnImportExcel` | `Button` | Nút import từ Excel |
| `oFDialog` | `OpenFileDialog` | Dialog chọn file Excel |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `FA_CODE` | Mã tài sản cố định (Fixed Asset Code) |
| `Quanlity` | Số lượng |
| `dgvKK` | DataGridView Kiểm kê |
| `KK` | Kiểm kê |
| `Fakkts` | Fixed Asset Kiểm kê Tài sản |

## Dependencies

- `AsiaErp.Framework`
- `Microsoft.Office.Interop.Excel`
- `System.Data`
- `System.Windows.Forms`
- `System.Xml.Linq`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
