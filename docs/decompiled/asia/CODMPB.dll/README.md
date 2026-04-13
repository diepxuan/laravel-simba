# Báo cáo Phân tích DLL: CODMPB.dll

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
| Assembly Name | CODMPB |
| Assembly Title | Danh mục bút toán phân bổ tự động |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 58067e3b-3fe0-4913-958d-dcb2d8cbe42f |
| ComVisible | false |

---

## Cấu trúc File

```
CODMPB.dll/
├── CODMPB.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MyComputer.cs
│   ├── MyApplication.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaERP.DataAccess/
│   └── (DAO classes)
└── AsiaERP.UserInterface/
    └── frmCODMPB.cs           # Main form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Data | Data access |
| System.Core | Core .NET functionality |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaERP.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCODMPB` | `frmDMComplexView` | Form danh mục bút toán phân bổ tự động |
| `Resources` | - | Resource manager |

---

## Chi tiết Forms

### frmCODMPB (Main Form)
- **Kế thừa**: `frmDMComplexView`
- **Chức năng**: Quản lý danh mục bút toán phân bổ tự động
- **Controls chính**:
  - `SplitContainer1`: Container chia đôi màn hình
  - `dgvCTPB`: DataGridView chi tiết phân bổ
  - `colTK`: Cột tài khoản (DataGridViewTextBoxColumn)
  - `colTenTk`: Cột tên tài khoản (DataGridViewTextBoxColumn)
  - `bsDanhMucCT`: BindingSource cho chi tiết
- **DataTable**:
  - `f_oTblPbCt`: DataTable chứa chi tiết phân bổ

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Danh mục bút toán phân bổ tự động" - Tên chức năng
- "TK", "Tên TK" - Thông tin tài khoản

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản kế toán |
| `ten_tk` | Tên tài khoản |
| `pb` | Phân bổ |

---

## Mục đích sử dụng

**CODMPB.dll là module quản lý "Danh mục bút toán phân bổ tự động"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Khai báo bút toán phân bổ
- Định nghĩa các bút toán phân bổ chi phí tự động
- Thiết lập tài khoản nguồn và đích cho phân bổ
- Cấu hình tiêu chí phân bổ (theo SPCT, bộ phận, TK đối ứng)

#### 2. Tích hợp với module phân bổ
- Cung cấp dữ liệu cho module COPB (Phân bổ)
- Hỗ trợ tính toán phân bổ chi phí gián tiếp
- Quản lý công thức phân bổ

### Đặc điểm kỹ thuật

- Sử dụng SplitContainer để hiển thị master-detail
- DataBinding với BindingSource
- Kế thừa từ frmDMComplexView

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc quản lý danh mục bút toán phân bổ tự động - cơ sở cho việc phân bổ chi phí gián tiếp trong kế toán giá thành.

---

*Ngày phân tích: 2026-03-29*
