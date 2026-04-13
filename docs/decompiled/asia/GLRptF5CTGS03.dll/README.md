# Báo cáo Phân tích DLL: GLRptF5CTGS03.dll

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
| Assembly Name | GLRptF5CTGS03 |
| Assembly Title | GLRptF5CTGS01 |
| Assembly Company | |
| Assembly Product | GLRptF5CTGS01 |
| Assembly Copyright | Copyright © 2013 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9c28789e-bd74-46c6-b0d2-4bdd18e3ca5b |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptF5CTGS03.dll/
├── GLRptF5CTGS03.csproj        # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptF5CTGS03.cs   # Main form class (Drilldown Report)
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs              # VB.NET compatibility
    ├── MyApplication.cs          # Application settings
    ├── MySettings.cs            # Settings manager
    ├── MySettingsProperty.cs      # Settings property
    └── MyComputer.cs            # Computer info
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Diagnostics`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptF5CTGS03` | `frmDrilldownReport` | Form báo cáo F5 CTGS03 |

---

## Chi tiết Form: frmGLRptF5CTGS03

### Thuộc tính Form

| Thuộc tính | Giá trị |
|-------------|---------|
| AutoScaleMode | Font (1) |
| Text | frmGLRptF5CTGS02 (có vẻ là typo, nên là CTGS03) |
| Base Class | frmDrilldownReport |

### Constructors

| Constructor | Tham số | Mục đích |
|-------------|-----------|----------|
| `frmGLRptF5CTGS03()` | none | Default constructor |
| `frmGLRptF5CTGS03(...)` | ReportInformation, drilldownMenuId, AsDictionary, bool, string, string, string, object, params object[] | Constructor với thông tin báo cáo |

### Methods

| Method | Mục đích |
|--------|------------|
| `InitOtherComponents()` | Khởi tạo thêm components, focus vào dgvBC |

---

## Mục đích sử dụng

**GLRptF5CTGS03.dll là module báo cáo F5 CTGS03** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Báo cáo CTGS03 (Chứng từ ghi sổ)
- Hiển thị báo cáo chứng từ ghi sổ theo mẫu CTGS03
- Form đơn giản, kế thừa từ frmDrilldownReport

#### 2. Hiển thị dữ liệu
- Sử dụng DataGridView (`dgvBC`) để hiển thị dữ liệu báo cáo
- Auto focus vào grid khi khởi tạo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - form báo cáo có khả năng drilldown
- Form đơn giản, không override phương thức CreateDrilldownArgument
- Sử dụng AutoScaleMode = Font cho scaling tự động
- Tích hợp với Asia ERP Framework
- Lưu ý: Text form có vẻ là typo (ghi CTGS02 thay vì CTGS03)

### CTGS (Chứng từ Ghi Sổ)

CTGS là viết tắt của "Chứng từ Ghi Sổ" - một loại chứng từ kế toán quan trọng trong hệ thống kế toán Việt Nam, dùng để ghi nhận các nghiệp vụ kinh tế phát sinh vào sổ kế toán. CTGS03 là mẫu chứng từ ghi sổ số 03.

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị báo cáo chứng từ ghi sổ CTGS03. Module này đơn giản, chủ yếu dùng để hiển thị dữ liệu với khả năng drilldown cơ bản từ base class.

---

*Ngày phân tích: 2026-03-29*
