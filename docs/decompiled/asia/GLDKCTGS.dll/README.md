# Báo cáo Phân tích DLL: GLDKCTGS.dll

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
| Assembly Name | GLDKCTGS |
| Assembly Title | GLDKCTGS |
| Assembly Company | - |
| Assembly Product | GLDKCTGS |
| Assembly Copyright | Copyright © 2013 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 35b6e3ad-f6c4-4b51-a0a9-70286c509bf8 |
| ComVisible | false |

---

## Cấu trúc File

```
GLDKCTGS.dll/
├── GLDKCTGS.csproj              # Project file
├── app.ico                      # Application icon
├── Resources.resx               # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── GLDKCTGSDAO.cs           # Interface DAO
│   └── MsSqlGLDKCTGSDAO.cs      # SQL Server DAO implementation
├── AsiaErp.UserInterface/
│   └── frmGLDKCTGS.cs           # Main form - Đăng ký CTGS
├── My/
│   ├── MyApplication.cs         # VB My.Application
│   ├── MyComputer.cs            # VB My.Computer
│   ├── MyProject.cs             # VB My.Project
│   ├── MySettings.cs            # Settings
│   ├── MySettingsProperty.cs    # Settings property
│   └── InternalXmlHelper.cs     # XML Helper
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Data Access Layer |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLDKCTGS` | `frmAsiaRoot` | Form đăng ký chứng từ ghi sổ |
| `GLDKCTGSDAO` | Interface | Interface DAO |
| `MsSqlGLDKCTGSDAO` | `MsSqlDAO` | Triển khai SQL Server DAO |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Kỳ báo cáo" - Chọn kỳ đăng ký
- "Từ ngày", "Đến ngày" - Khoảng thời gian
- "Chọn" - Checkbox chọn chứng từ
- "Thực hiện" - Button thực hiện đăng ký
- "Thoát" - Button thoát

### Cột DataGridView (Danh sách chứng từ)

| Cột | Ý nghĩa |
|-----|---------|
| Chọn | Checkbox chọn chứng từ |
| Mã CT | Mã chứng từ |
| TK | Tài khoản |
| Tên CTGS | Tên chứng từ ghi sổ |
| Số hiệu | Số hiệu chứng từ |
| Ngày | Ngày chứng từ |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ct` | Mã chứng từ |
| `tk` | Tài khoản |
| `ten_ctgs` | Tên chứng từ ghi sổ |
| `so_hieu` | Số hiệu |
| `ngay` | Ngày chứng từ |
| `ky_bc` | Kỳ báo cáo |

---

## Mục đích sử dụng

**GLDKCTGS.dll là module Đăng ký chứng từ ghi sổ (Chứng từ ghi sổ - CTGS)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Đăng ký chứng từ ghi sổ
- Liệt kê các loại chứng từ cần đăng ký
- Chọn kỳ báo cáo (tháng/quý/năm)
- Chọn khoảng thời gian (từ ngày - đến ngày)
- Chọn chứng từ để đăng ký

#### 2. Quản lý danh sách chứng từ
- Hiển thị danh sách chứng từ theo kỳ
- Chọn/tích chọn từng chứng từ hoặc tất cả
- Hiển thị thông tin: Mã CT, TK, Tên CTGS, Số hiệu, Ngày

#### 3. Thực hiện đăng ký
- Xử lý đăng ký các chứng từ đã chọn
- Cập nhật trạng thái đăng ký vào hệ thống

### Đặc điểm kỹ thuật

- Sử dụng DataGridView với checkbox chọn
- Hỗ trợ chọn kỳ báo cáo động
- Validation ngày tháng hợp lệ
- Tích hợp với DAO pattern

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc đăng ký chứng từ ghi sổ theo kỳ báo cáo.

---

*Ngày phân tích: 2026-03-29*
