# Báo cáo Phân tích DLL: GLNB.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLNB |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLNB.dll/
├── GLNB.csproj                  # Project file
├── GLNB.dll.licenses            # License file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLNB.cs               # Main view form
    └── frmGLNBEdit.cs           # Edit form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLNB` | `frmDMView` | Form xem danh mục nghiệp vụ |
| `frmGLNBEdit` | `frmDMEdit` | Form chỉnh sửa nghiệp vụ |

---

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

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số chứng từ" - Nhãn số chứng từ
- "Ngày chứng từ" - Nhãn ngày chứng từ
- "Tài khoản" - Nhãn tài khoản
- "Ngoại tệ" - Nhãn ngoại tệ
- "Phát sinh nợ NT" - Nhãn PS nợ ngoại tệ
- "Phát sinh nợ" - Nhãn PS nợ
- "Phát sinh có NT" - Nhãn PS có ngoại tệ
- "Phát sinh có" - Nhãn PS có
- "Diễn giải" - Nhãn diễn giải

### Thuật ngữ kế toán

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

---

## Mục đích sử dụng

**GLNB.dll là module quản lý nghiệp vụ (ghi sổ nhanh/bút toán)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chứng từ nghiệp vụ
- Xem danh sách các chứng từ nghiệp vụ
- Thêm mới chứng từ
- Chỉnh sửa chứng từ hiện có
- Xóa chứng từ

#### 2. Nhập liệu chứng từ
- Số chứng từ (tự động sinh STT_REC)
- Ngày chứng từ
- Tài khoản (chỉ cho phép TK chi tiết)
- Ngoại tệ và tỷ giá
- Phát sinh nợ/có (VNĐ và ngoại tệ)
- Diễn giải

#### 3. Xử lý đa tiền tệ
- Chọn ngoại tệ từ danh mục
- Tự động lấy tỷ giá theo ngày
- Tự động tính PS nợ/có VNĐ từ ngoại tệ
- Vô hiệu hóa nhập ngoại tệ khi chọn VND

#### 4. Validation
- Kiểm tra ngày chứng từ hợp lệ
- Kiểm tra số chứng từ không rỗng
- Kiểm tra tài khoản không rỗng
- Kiểm tra chênh lệch điều chỉnh giá
- Kiểm tra PS nợ hoặc PS có (không cho phép cả hai cùng lúc)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` - form danh mục chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- Sử dụng `AsComboBoxNT` cho ngoại tệ
- Sử dụng `AsTextNumeric` cho số tiền và tỷ giá
- DataBinding với BindingSource
- Tích hợp license file (GLNB.dll.licenses)

### Business Logic

#### Tính toán ngoại tệ
```csharp
// Tự động tính PS VNĐ từ ngoại tệ
ps_no = ps_no_nt * ty_gia
ps_co = ps_co_nt * ty_gia
```

#### Kiểm tra phát sinh
- Nếu có PS nợ > 0 thì PS có phải = 0
- Nếu có PS có > 0 thì PS nợ phải = 0
- Không cho phép cả nợ và có cùng lúc

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý các nghiệp vụ kế toán (ghi sổ nhanh/bút toán) với hỗ trợ đa tiền tệ và validation chặt chẽ.

---

*Ngày phân tích: 2026-03-29*
