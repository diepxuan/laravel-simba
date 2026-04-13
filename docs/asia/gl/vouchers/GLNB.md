# GLNB - Nghiệp vụ (Ghi sổ nhanh/Bút toán)

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLNB.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý nghiệp vụ (ghi sổ nhanh/bút toán) |

## Chức năng chính

### 1. Quản lý chứng từ nghiệp vụ
- Xem danh sách các chứng từ nghiệp vụ
- Thêm mới chứng từ
- Chỉnh sửa chứng từ hiện có
- Xóa chứng từ

### 2. Nhập liệu chứng từ
- Số chứng từ (tự động sinh STT_REC)
- Ngày chứng từ
- Tài khoản (chỉ cho phép TK chi tiết)
- Ngoại tệ và tỷ giá
- Phát sinh nợ/có (VNĐ và ngoại tệ)
- Diễn giải

### 3. Xử lý đa tiền tệ
- Chọn ngoại tệ từ danh mục
- Tự động lấy tỷ giá theo ngày
- Tự động tính PS nợ/có VNĐ từ ngoại tệ
- Vô hiệu hóa nhập ngoại tệ khi chọn VND

### 4. Validation
- Kiểm tra ngày chứng từ hợp lệ
- Kiểm tra số chứng từ không rỗng
- Kiểm tra tài khoản không rỗng
- Kiểm tra chênh lệch điều chỉnh giá
- Kiểm tra PS nợ hoặc PS có (không cho phép cả hai cùng lúc)

## Các control trên form Edit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtSo_ct | TextBox | Số chứng từ |
| txtNgay_ct | AsMaskedTextBox | Ngày chứng từ (định dạng dd/MM/yyyy) |
| txtTK | AsTextBox | Tài khoản (lookup TK, chi_tiet=1) |
| lblTen_tk | Label | Tên tài khoản |
| cboNgoai_te | AsComboBoxNT | Ngoại tệ |
| txtty_gia | AsTextNumeric | Tỷ giá |
| txtPs_no_nt | AsTextNumeric | Phát sinh nợ ngoại tệ |
| txtPs_no | AsTextNumeric | Phát sinh nợ |
| txtPs_co_nt | AsTextNumeric | Phát sinh có ngoại tệ |
| txtPs_co | AsTextNumeric | Phát sinh có |
| txtdien_giai | TextBox | Diễn giải (multiline) |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |
| `tk` | Tài khoản |
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `ps_no` | Phát sinh nợ |
| `ps_co_nt` | Phát sinh có ngoại tệ |
| `ps_co` | Phát sinh có |
| `dien_giai` | Diễn giải |
| `ma_ct` | Mã chứng từ |
| `stt_rec` | Số thứ tự bản ghi |

## Business Logic

### Tính toán ngoại tệ
```csharp
// Tự động tính PS VNĐ từ ngoại tệ
ps_no = ps_no_nt * ty_gia
ps_co = ps_co_nt * ty_gia
```

### Kiểm tra phát sinh
- Nếu có PS nợ > 0 thì PS có phải = 0
- Nếu có PS có > 0 thì PS nợ phải = 0
- Không cho phép cả nợ và có cùng lúc

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLNB` | `frmDMView` | Form xem danh mục nghiệp vụ |
| `frmGLNBEdit` | `frmDMEdit` | Form chỉnh sửa nghiệp vụ |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `System.Data` - Data access
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLNB |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

*Ngày cập nhật: 2026-03-29*
