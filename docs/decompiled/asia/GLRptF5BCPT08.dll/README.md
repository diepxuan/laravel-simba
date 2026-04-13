# Báo cáo Phân tích DLL: GLRptF5BCPT08.dll

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
| Assembly Name | GLRptF5BCPT08 |
| Assembly Title | GLRptF5BCPT08 |
| Assembly Company | Asia |
| Assembly Product | GLRptF5BCPT08 |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 555e1310-3ce6-4277-ba6a-2a9dff935e02 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptF5BCPT08.dll/
├── GLRptF5BCPT08.csproj       # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptF5BCPT08.cs    # Main form class
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
| `frmGLRptF5BCPT08` | `frmDrilldownReport` | Form báo cáo F5 phân tích 08 - drilldown report |

---

## Constructors

| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCPT08()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCPT08(ReportInformation, string, AsDictionary, bool, string, string, string, object, params object[])` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo components, select vào dgvBC |
| `CreateDrilldownArgument()` | Xử lý drilldown với 3 chế độ modifier keys |

---

## Logic Drilldown (F7)

### Modifier Keys = 0 (F7 thường)

| Điều kiện | Hành động |
|-----------|-----------|
| `cach_tinh` rỗng VÀ `tk` rỗng | Hủy drilldown |
| `cach_tinh` KHÔNG rỗng | Drilldown theo công thức tính:<br>- sDrilldownMenuId = drilldown_menuid<br>- Lọc các ma_so trong cach_tinh (replace +,- bằng ',')<br>- Filter: "ma_so = cach_tinh" |
| `tk` KHÔNG rỗng | Drilldown theo tài khoản:<br>- sDrilldownMenuId = drilldown_menuid1<br>- Tham số: CompanyID, tk, ngay_ct1, ngay_ct2, ma_nt<br>- Filter: tk |

### Modifier Keys = Ctrl (131072)

| Điều kiện | Hành động |
|-----------|-----------|
| `tk` rỗng | Hủy drilldown |
| `tk` KHÔNG rỗng | Drilldown theo tk/tk_du:<br>- Tham số: CompanyID, tk, tk_du, ngay_ct1, ngay_ct2, ma_nt<br>- Filter: "tk/tk_du" |

### Modifier Keys = Shift (65536)

| Điều kiện | Hành động |
|-----------|-----------|
| `tk` rỗng HOẶC `cong_no` != "1" | Hủy drilldown |
| `tk` KHÔNG rỗng VÀ `cong_no` = "1" | Drilldown công nợ:<br>- Tham số: CompanyID, tk, ngay_ct1, ngay_ct2<br>- Filter: tk |

---

## Các trường dữ liệu quan trọng

| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Công thức tính (chứa các ma_so cách nhau bởi +,-) |
| `tk` | Tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `ma_so` | Mã số |
| `cong_no` | Cờ công nợ (1 = có công nợ) |
| `ngay_ct1`, `ngay_ct2` | Khoảng ngày chứng từ |
| `ma_nt` | Mã ngoại tệ |

---

## Mục đích sử dụng

**GLRptF5BCPT08.dll là module báo cáo F5 "Bảng kê phân tích 08"** - một báo cáo drilldown trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo drilldown
- Kế thừa từ `frmDrilldownReport` - form drilldown chuẩn của Asia ERP
- Nhận dữ liệu từ báo cáo mẹ (motherReportInfo)
- Hỗ trợ drilldown chi tiết với 3 chế độ phím tắt

#### 2. Drilldown theo công thức tính
- Khi cell có `cach_tinh` chứa công thức (ví dụ: "111+112-113")
- Lọc các dòng có ma_so trong công thức
- Hiển thị chi tiết các thành phần của chỉ tiêu

#### 3. Drilldown theo tài khoản
- Khi cell có `tk` chứa tài khoản
- Xem chi tiết phát sinh của tài khoản đó
- Truyền khoảng ngày và ngoại tệ từ báo cáo mẹ

#### 4. Drilldown công nợ (Shift+F7)
- Khi cell có `tk` và `cong_no` = "1"
- Xem chi tiết công nợ của tài khoản

#### 5. Drilldown tk/tk_du (Ctrl+F7)
- Xem chi tiết theo cặp tài khoản/tài khoản đối ứng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` thay vì `frmReport`
- Sử dụng __ENCList cho list weak reference (VB compatibility)
- Không có UI controls riêng - sử dụng dgvBC từ form mẹ
- Parameters4DrillDown chứa các tham số từ báo cáo mẹ
- Hỗ trợ 3 loại drilldown menuid: drilldown_menuid, drilldown_menuid1

### Mã báo cáo

**F5BCPT08** - Báo cáo F5 phân tích 08 (bảng kê phân tích theo công thức tính)

---

## Kết luận

Đây là một module Windows Forms drilldown của hệ thống ERP Asia Enterprise, phục vụ cho việc xem chi tiết các thành phần của chỉ tiêu phân tích. Báo cáo hỗ trợ drilldown theo công thức tính, theo tài khoản, và theo công nợ với 3 chế độ phím tắt khác nhau (F7, Ctrl+F7, Shift+F7).

---

*Ngày phân tích: 2026-03-29*
