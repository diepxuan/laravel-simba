# Báo cáo Phân tích DLL: GLDMCTGS.dll

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
| Assembly Name | GLDMCTGS |
| Assembly Title | GLDMCTGS |
| Assembly Company | - |
| Assembly Product | GLDMCTGS |
| Assembly Copyright | Copyright © 2013 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 35b6e3ad-f6c4-4b51-a0a9-70286c509bf8 |
| ComVisible | false |

---

## Cấu trúc File

```
GLDMCTGS.dll/
├── GLDMCTGS.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLDMCTGS.cs           # Main form - Danh mục CTGS
│   └── frmGLDMCTGSEdit.cs       # Edit form - Nhập liệu CTGS
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs         # VB My.Application
│   ├── MyComputer.cs            # VB My.Computer
│   ├── MyProject.cs             # VB My.Project
│   ├── MySettings.cs            # Settings
│   └── MySettingsProperty.cs    # Settings property
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLDMCTGS` | `frmDMView` | Form xem danh mục chứng từ ghi sổ |
| `frmGLDMCTGSEdit` | - | Form nhập liệu chứng từ ghi sổ |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục chứng từ ghi sổ" - Tên chức năng chính

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ct` | Mã chứng từ |
| `ten_ct` | Tên chứng từ |
| `tk` | Tài khoản |
| `so_hieu` | Số hiệu |

---

## Mục đích sử dụng

**GLDMCTGS.dll là module Danh mục chứng từ ghi sổ (CTGS)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Quản lý danh mục chứng từ ghi sổ
- Xem danh sách các loại chứng từ ghi sổ
- Thêm, sửa, xóa chứng từ ghi sổ
- Quản lý thông tin: Mã CT, Tên CT, TK, Số hiệu

#### 2. Cấu hình chứng từ
- Thiết lập mã chứng từ
- Gán tài khoản mặc định
- Cấu hình số hiệu chứng từ

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` - Form danh mục chuẩn
- Ẩn chức năng in ấn và đổi mã
- Sử dụng layout chuẩn của framework

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục chứng từ ghi sổ.

---

*Ngày phân tích: 2026-03-29*
