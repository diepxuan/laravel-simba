# GLPost2GLKC - Kết chuyển tự động

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLPost2GLKC.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Kết chuyển tự động cuối kỳ |

## Chức năng chính

### 1. Quản lý bút toán kết chuyển
- Xem danh sách các bút toán kết chuyển được định nghĩa
- Mỗi bút toán bao gồm: TK nợ, TK có, loại kết chuyển
- Chọn kỳ kết chuyển (tự động cập nhật ngày)

### 2. Thực hiện kết chuyển
- Chọn một hoặc nhiều bút toán để thực hiện
- Tự động tạo chứng từ kết chuyển cuối kỳ
- Hỗ trợ kết chuyển theo nhiều chiều phân tích:
  - Theo hợp đồng
  - Theo bộ phận
  - Theo SPCT (Sản phẩm chi tiết)
  - Theo phí

### 3. Xóa kết chuyển
- Chọn bút toán đã kết chuyển để xóa
- Kiểm tra khóa sổ trước khi xóa
- Cập nhật trạng thái sau khi xóa

## UI Controls

### Input Controls
| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | AsComboBox | Chọn kỳ kết chuyển |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu (dd/MM/yyyy) |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc (dd/MM/yyyy) |
| chkSelectAll | AsCheckBox | Chọn/bỏ chọn tất cả |

### DataGridView Columns (dgvDmKC)
| Cột | Ý nghĩa |
|-----|---------|
| colSelect | Chọn để thực hiện |
| colTT_BT | Số thứ tự bút toán |
| colTenBT | Tên bút toán |
| colTkNo | Tài khoản nợ |
| colLoaiKC | Loại kết chuyển |
| colTkCo | Tài khoản có (đối ứng) |
| colSoCT | Số chứng từ |
| colTheoHD | Theo hợp đồng |
| colTheoBp | Theo bộ phận |
| colTheoSPCT | Theo SPCT |
| colTheoPhi | Theo phí |

### Buttons
| Button | Text | Chức năng | Phím tắt |
|--------|------|-------------|----------|
| cmdKc | Kết chuyển | Thực hiện kết chuyển | F4 |
| cmdDelKc | Xóa KC | Xóa kết chuyển | F8 |
| cmdCancel | Quay ra | Đóng form | ESC |

## Business Logic

### IGLPost2GLKCDAO Interface

| Method | Parameters | Return | Mô tả |
|--------|-----------|--------|---------|
| GetDmKC | moduleid | DataTable | Lấy danh mục kết chuyển |
| CreateKc | oDrw, pMa_ct, dtmNgay1, dtmNgay2 | int | Tạo kết chuyển |
| DelKc | oDrw, pMa_ct, dtmNgay1, dtmNgay2 | int | Xóa kết chuyển |

## Stored Procedures

| Tên | Mục đích |
|-----|----------|
| asGLGetDMKC4KC | Lấy danh mục kết chuyển theo module |
| asGLCrtKC | Tạo kết chuyển mới |
| asGLDelKC | Xóa kết chuyển |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| KC | Kết chuyển |
| BT | Bút toán |
| TK | Tài khoản |
| TK nợ | Tài khoản bên nợ |
| TK có/đư | Tài khoản đối ứng (bên có) |
| HD | Hợp đồng |
| BP | Bộ phận |
| SPCT | Sản phẩm chi tiết |
| Phi | Phí |

## Loại kết chuyển

| Loại | Mô tả |
|------|---------|
| colLoaiKC | Loại kết chuyển (text) |
| colTheoHD | Có kết chuyển theo hợp đồng |
| colTheoBp | Có kết chuyển theo bộ phận |
| colTheoSPCT | Có kết chuyển theo SPCT |
| colTheoPhi | Có kết chuyển theo phí |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLPost2GLKC` | `frmAsiaRoot` | Form kết chuyển tự động |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `System.Data` - Data access
- `System.Core` - LINQ support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLPost2GLKC |
| Assembly Title | Kết chuyển tự động |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| GUID | fbcae1bc-4a96-467b-9a6e-b6a74302b9a1 |

---

*Ngày cập nhật: 2026-03-29*
