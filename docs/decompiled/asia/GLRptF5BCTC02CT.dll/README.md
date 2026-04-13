# Báo cáo Phân tích DLL: GLRptF5BCTC02CT.dll

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
| Assembly Name | GLRptF5BCTC02CT |
| Assembly Title | GLRptF5CTGS01 |
| Assembly Company | Asia |
| Assembly Product | GLRptF5CTGS01 |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 555e1310-3ce6-4277-ba6a-2a9dff935e02 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptF5BCTC02CT.dll/
├── GLRptF5BCTC02CT.csproj     # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptF5BCTC02CT.cs  # Main form class
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs       # MyApplication class
│   ├── MyComputer.cs          # MyComputer class
│   ├── MyProject.cs           # MyProject class
│   ├── MySettings.cs          # MySettings class
│   └── MySettingsProperty.cs  # MySettingsProperty class
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs           # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| Framework | Asia ERP Framework (AsiaErp.Framework) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `System`, `System.Data`, `System.Collections`, `System.Collections.Generic`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptF5BCTC02CT` | `frmDrilldownReport` | Form báo cáo F5 BCTC02 chi tiết - drilldown report |

---

## Constructors

| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCTC02CT()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCTC02CT(ReportInformation, string, AsDictionary, bool, string, string, string, object, params object[])` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo components, select vào dgvBC |
| `CreateDrilldownArgument()` | Xử lý drilldown theo tk_du |

---

## Logic Drilldown (F7)

### Modifier Keys = 0 (F7 thường)

| Điều kiện | Hành động |
|-----------|-----------|
| `tk_du` rỗng | Hủy drilldown |
| `tk_du` KHÔNG rỗng | Drilldown theo tài khoản đối ứng:<br>- Tham số: CompanyID, "" (tk_no rỗng), tk_du, ngay_dau_nam, ngay_ct2<br>- Filter: tk_du<br>- ngay_dau_nam = ngày 01/01 của năm báo cáo |

### Modifier Keys khác (Ctrl, Shift, Alt)

| Điều kiện | Hành động |
|-----------|-----------|
| Bất kỳ | Hủy drilldown |

---

## Các trường dữ liệu quan trọng

| Trường | Ý nghĩa |
|--------|---------|
| `tk_du` | Tài khoản đối ứng |
| `ngay_ct2` | Ngày đến của báo cáo |
| `ngay_dau_nam` | Ngày 01/01 của năm báo cáo (tự động tính) |

---

## Mục đích sử dụng

**GLRptF5BCTC02CT.dll là module báo cáo F5 "BCTC02 chi tiết"** - một báo cáo drilldown trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo drilldown chi tiết BCTC02
- Kế thừa từ `frmDrilldownReport` - form drilldown chuẩn của Asia ERP
- Nhận dữ liệu từ báo cáo mẹ (BCTC02 - Bảng cân đối kế toán)
- Drilldown chi tiết theo tài khoản đối ứng

#### 2. Drilldown theo tk_du (F7)
- Khi cell có `tk_du` chứa tài khoản đối ứng
- Xem chi tiết phát sinh của tài khoản đó từ đầu năm đến ngày báo cáo
- Truyền tham số:
  - CompanyID
  - tk_no = "" (rỗng)
  - tk_du = tài khoản đối ứng của cell
  - ngay_ct1 = 01/01/năm báo cáo
  - ngay_ct2 = ngày báo cáo
  - ma_nt = "" (rỗng)

#### 3. Filter condition
- Filter hiển thị: tk_du (tài khoản đối ứng)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` thay vì `frmReport`
- Sử dụng __ENCList cho list weak reference (VB compatibility)
- Không có UI controls riêng - sử dụng dgvBC từ form mẹ
- Tự động tính ngày đầu năm từ ngay_ct2: `new DateTime(dateTime.Year, 1, 1)`
- Chỉ hỗ trợ F7 thường, không hỗ trợ Ctrl+F7 hay Shift+F7
- tk_no luôn rỗng khi drilldown

### Mã báo cáo

**F5BCTC02CT** - Báo cáo F5 BCTC02 chi tiết (drilldown từ Bảng cân đối kế toán)

---

## Kết luận

Đây là một module Windows Forms drilldown của hệ thống ERP Asia Enterprise, phục vụ cho việc xem chi tiết các phát sinh của tài khoản đối ứng từ đầu năm đến ngày báo cáo. Báo cáo được mở khi người dùng nhấn F7 từ báo cáo mẹ BCTC02 (Bảng cân đối kế toán) để xem chi tiết các giao dịch cấu thành nên số dư của tài khoản.

---

*Ngày phân tích: 2026-03-29*
