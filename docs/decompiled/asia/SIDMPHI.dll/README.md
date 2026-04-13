# Báo cáo Phân tích DLL: SIDMPHI.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SIDMPHI |
| Assembly Title | Danh mục phí |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
SIDMPHI.dll/
├── SIDMPHI.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSIDMPHI.cs            # Main form class - Danh mục phí
    └── frmSIDMPHIEdit.cs        # Form chỉnh sửa phí
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Drawing | Graphics |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMPHI` | `frmDMView` | Form xem danh mục phí |
| `frmSIDMPHIEdit` | `frmDMEdit` | Form chỉnh sửa thông tin phí |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã phí" (`ma_phi`)
- "Tên phí" (`ten_phi`)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_phi` | Mã phí |
| `ten_phi` | Tên phí |
| `ksd` | Không sử dụng |

---

## Mục đích sử dụng

**SIDMPHI.dll là module quản lý Danh mục phí** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục phí
- Khai báo mã phí (`ma_phi`)
- Khai báo tên phí (`ten_phi`)
- Phân loại các loại phí trong hệ thống

#### 2. Trạng thái sử dụng
- Cho phép đánh dấu phí không còn sử dụng (`ksd`)
- Kiểm soát hiển thị trong các form liên quan

#### 3. Tích hợp với chứng từ
- Sử dụng trong các module chứng từ để phân bổ phí
- Cấu hình sử dụng trong SIDMCT.dll (`chkUse_ma_phi`)

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView`/`frmDMEdit` cơ bản
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục phí - sử dụng trong việc phân bổ và theo dõi các loại phí trong các nghiệp vụ kế toán.

---

*Ngày phân tích: 2026-03-29*
