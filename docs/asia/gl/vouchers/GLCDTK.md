# GLCDTK - Số dư đầu kỳ các tài khoản

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLCDTK.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Nhập và quản lý số dư đầu kỳ các tài khoản kế toán |

## Chức năng chính

### 1. Nhập số dư đầu kỳ tài khoản
- Nhập số dư đầu kỳ cho các tài khoản kế toán
- Phân biệt số dư đầu kỳ và đầu năm
- Hỗ trợ số dư ngoại tệ

### 2. Quản lý số dư
- Xem danh sách số dư theo tài khoản
- Nhập số dư nợ/có cho từng tài khoản
- Quản lý số dư ngoại tệ

### 3. Tính tổng số dư
- Tính tổng dư nợ/dư có
- Tính tổng dư nợ NT/dư có NT
- Stored Procedure: `asGLCalSumCdTk`

### 4. Kiểm soát kỳ
- Chọn tháng nhập số dư
- Kiểm tra khóa sổ (ngày khóa)
- Cảnh báo nếu nhập trước kỳ khóa

## Cấu trúc dữ liệu

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| tk | Tài khoản |
| ten_tk | Tên tài khoản |
| du_no00 | Dư nợ đầu năm |
| du_co00 | Dư có đầu năm |
| du_no_nt00 | Dư nợ NT đầu năm |
| du_co_nt00 | Dư có NT đầu năm |
| du_no | Dư nợ đầu kỳ |
| du_co | Dư có đầu kỳ |
| du_no_nt | Dư nợ NT đầu kỳ |
| du_co_nt | Dư có NT đầu kỳ |
| tk_cn | Tài khoản công nợ |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản |
| `ten_tk` | Tên tài khoản |
| `du_no` | Dư nợ |
| `du_co` | Dư có |
| `du_no_nt` | Dư nợ ngoại tệ |
| `du_co_nt` | Dư có ngoại tệ |
| `du_no00` | Dư nợ đầu năm |
| `du_co00` | Dư có đầu năm |
| `tk_cn` | Tài khoản công nợ |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLCDTK` | `frmOBView` | Form xem số dư đầu kỳ tài khoản |
| `frmGLCDTKEdit` | `frmOBEdit` | Form nhập số dư đầu kỳ |
| `frmGLCDTKFilter` | - | Form chọn kỳ nhập số dư |
| `frmGLCDTKFilterTk` | - | Form lọc tài khoản |
| `frmGLSdDkTk` | - | Form tính tổng số dư |

## Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGLCalSumCdTk` | Tính tổng số dư công nợ tài khoản |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework
- `AsiaERP.UserInterface` - UI Framework

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLCDTK |
| Assembly Title | Số dư đầu kỳ các tài khoản |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| GUID | 8a7d23a8-8e3c-49d8-b94f-f3b9d5c5d6ae |

---

*Ngày cập nhật: 2026-03-29*
