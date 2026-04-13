# GLBudget - Ngân sách

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLBudget.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý ngân sách (Budget) |

## Chức năng chính

### 1. Quản lý dự toán ngân sách
- Thiết lập ngân sách theo tài khoản, bộ phận, phí, SPCT
- Hỗ trợ tài khoản đối ứng
- Phân biệt phát sinh nợ/có

### 2. Nhập liệu ngân sách
- Nhập giá trị dự toán cho từng tháng (12 tháng)
- Copy số liệu từ năm trước làm mẫu
- Điều chỉnh tự động theo nhiều phương pháp

### 3. Các phương pháp điều chỉnh
- Giá trị cố định (thêm/thay thế)
- Phân chia đều
- Lũy kế theo phần trăm/giá trị
- Sao chép từ số liệu mẫu
- Tăng trưởng theo % so với năm trước
- Phân chia theo trọng số

## Cột DataGridView (Chi tiết ngân sách)

| Cột | Ý nghĩa |
|-----|---------|
| Tháng | Tháng trong năm (1-12) |
| Dự Toán | Giá trị dự toán |
| Số liệu mẫu | Dữ liệu thực tế năm trước |

## Phương pháp điều chỉnh ngân sách

| Phương pháp | Mô tả |
|-------------|-------|
| Giá trị cố định | Nhập giá trị cố định |
| Phân chia giá trị | Chia đều cho 12 tháng |
| Lũy kế theo % | Tăng lũy kế theo tỷ lệ % |
| Lũy kế theo giá trị | Tăng lũy kế theo giá trị |
| Sao nguyên số liệu mẫu | Copy từ năm trước |
| Tăng theo % giá trị mẫu | Tăng % so với năm trước |
| Tăng theo số lượng giá trị mẫu | Tăng số lượng |
| Phân chia theo trọng số | Phân chia theo tỷ trọng |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ttps_no_co` | Phát sinh nợ/có |
| `t1` - `t12` | Giá trị các tháng |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLBudget` | `frmDMView` | Form xem danh mục ngân sách |
| `frmGLBudgetEdit` | `frmDMEdit` | Form nhập liệu ngân sách |

## Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGLGetBudget` | Lấy dữ liệu ngân sách |
| `asGLGetSample0Budget` | Lấy số liệu mẫu |
| `asGLGetSample1Budget` | Lấy số liệu mẫu chi tiết |
| `asGetSttRec` | Lấy số thứ tự ghi sổ |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLBudget |
| Assembly Title | GLBudget |
| Assembly Company | - |
| Assembly Product | GLBudget |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| GUID | 647143f1-e23f-4563-bde9-c2b8d144325c |

---

*Ngày cập nhật: 2026-03-29*
