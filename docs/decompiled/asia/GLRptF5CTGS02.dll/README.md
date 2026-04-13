# Báo cáo Phân tích DLL: GLRptF5CTGS02.dll

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
| Assembly Name | GLRptF5CTGS02 |
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
GLRptF5CTGS02.dll/
├── GLRptF5CTGS02.csproj        # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptF5CTGS02.cs   # Main form class (Drilldown Report)
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
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Data`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptF5CTGS02` | `frmDrilldownReport` | Form báo cáo F5 CTGS02 với chức năng drilldown |

---

## Chi tiết Form: frmGLRptF5CTGS02

### Thuộc tính Form

| Thuộc tính | Giá trị |
|-------------|---------|
| AutoScaleMode | Font (1) |
| Text | frmGLRptF5CTGS02 |
| Base Class | frmDrilldownReport |

### Private Fields

| Field | Kiểu | Mục đích |
|-------|--------|----------|
| `dNgay1` | DateTime | Ngày bắt đầu |
| `dNgay2` | DateTime | Ngày kết thúc |

### Constructors

| Constructor | Tham số | Mục đích |
|-------------|-----------|----------|
| `frmGLRptF5CTGS02()` | none | Default constructor |
| `frmGLRptF5CTGS02(...)` | ReportInformation, drilldownMenuId, AsDictionary, bool, string, string, string, object, params object[] | Constructor với thông tin báo cáo và ngày từ args[2], args[3] |

### Drilldown Logic

Form hỗ trợ drilldown báo cáo với điều kiện:

1. **Phím F5 (KeyCode = 116)**: Kích hoạt drilldown
2. **Không có Modifier Keys**: Chỉ drilldown khi không nhấn thêm phím modifier

### Các trường dữ liệu xử lý

| Trường | Ý nghĩa |
|----------|-----------|
| `ngay_lo` | Ngày lô |
| `so_lo` | Số lô |
| `tk` | Tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `dien_giai` | Diễn giải |

### Drilldown Parameters

```
Args[0]: CompanyID
Args[1]: dNgay1 (Ngày bắt đầu)
Args[2]: dNgay2 (Ngày kết thúc)
Args[3]: ngay_lo (Ngày lô)
Args[4]: so_lo (Số lô)
Args[5]: tk (Tài khoản)
Args[6]: tk_du (Tài khoản đối ứng)
```

Filter title: `so_lo - dien_giai`

---

## Mục đích sử dụng

**GLRptF5CTGS02.dll là module báo cáo F5 CTGS02** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Báo cáo CTGS02 (Chứng từ ghi sổ)
- Hiển thị báo cáo chứng từ ghi sổ theo mẫu CTGS02
- Hỗ trợ drilldown chi tiết khi nhấn F5

#### 2. Drilldown theo lô chứng từ
- **F5**: Drilldown xem chi tiết chứng từ theo lô
- Thông tin drilldown bao gồm: ngày lô, số lô, tài khoản, tài khoản đối ứng

#### 3. Xử lý dữ liệu
- Sử dụng DataRowView để truy cập dữ liệu
- Sử dụng `NewLateBinding.LateGet` cho dynamic data access
- Lưu trữ ngày báo cáo trong private fields

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - form báo cáo có khả năng drilldown
- Sử dụng DataGridView (`dgvBC`) để hiển thị dữ liệu
- Tích hợp với Asia ERP Framework
- Kiểm tra modifier keys (chỉ drilldown khi không có modifier)

### CTGS (Chứng từ Ghi Sổ)

CTGS là viết tắt của "Chứng từ Ghi Sổ" - một loại chứng từ kế toán quan trọng trong hệ thống kế toán Việt Nam. CTGS02 là mẫu chứng từ ghi sổ số 02, thường dùng cho việc tổng hợp và theo dõi các lô chứng từ.

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị và drilldown báo cáo chứng từ ghi sổ CTGS02. Module này hỗ trợ drilldown theo lô chứng từ với thông tin chi tiết về ngày lô, số lô và các tài khoản liên quan.

---

*Ngày phân tích: 2026-03-29*
