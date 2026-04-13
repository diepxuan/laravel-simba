# CODMPB - Danh mục bút toán phân bổ tự động

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CODMPB.dll |
| Assembly Title | Danh mục bút toán phân bổ tự động |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Danh mục bút toán phân bổ tự động** trong hệ thống ERP Asia Enterprise. Đây là module khai báo các bút toán phân bổ chi phí tự động.

## Chức năng chính

1. **Khai báo bút toán phân bổ**
   - Định nghĩa các bút toán phân bổ chi phí tự động
   - Thiết lập tài khoản nguồn và đích cho phân bổ
   - Cấu hình tiêu chí phân bổ (theo SPCT, bộ phận, TK đối ứng)

2. **Tích hợp với module phân bổ**
   - Cung cấp dữ liệu cho module COPB (Phân bổ)
   - Hỗ trợ tính toán phân bổ chi phí gián tiếp
   - Quản lý công thức phân bổ

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| tk | Tài khoản kế toán |
| ten_tk | Tên tài khoản |

## Forms

- `frmCODMPB`: Form danh mục bút toán phân bổ (kế thừa frmDMComplexView)

## UI Components

- `SplitContainer1`: Container chia đôi màn hình
- `dgvCTPB`: DataGridView chi tiết phân bổ
- `colTK`: Cột tài khoản
- `colTenTk`: Cột tên tài khoản

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
- System.Xml.Linq
- System.Core
