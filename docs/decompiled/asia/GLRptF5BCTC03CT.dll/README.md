# Báo cáo Phân tích DLL: GLRptF5BCTC03CT.dll

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
| Assembly Name | GLRptF5BCTC03CT |
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
GLRptF5BCTC03CT.dll/
├── GLRptF5BCTC03CT.csproj     # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptF5BCTC03CT.cs  # Main form class
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
| `frmGLRptF5BCTC03CT` | `frmDrilldownReport` | Form báo cáo F5 BCTC03 chi tiết - drilldown report |

---

## Constructors

| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCTC03CT()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCTC03CT(ReportInformation, string, AsDictionary, bool, string, string, string, object, params object[])` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo components, select vào dgvBC |
| `CreateDrilldownArgument()` | Xử lý drilldown với 3 chế độ: cach_tinh, tk_no/tk_co |

---

## Logic Drilldown (F7)

### Modifier Keys = 0 (F7 thường)

| Điều kiện | Hành động |
|-----------|-----------|
| `cach_tinh`, `tk_no`, `tk_co` đều rỗng | Hủy drilldown |
| `cach_tinh` KHÔNG rỗng | Drilldown theo công thức tính:<br>- sDrilldownMenuId = drilldown_menuid<br>- Lọc các ma_so trong cach_tinh (replace +,- bằng ',')<br>- Filter: "ma_so = cach_tinh" |
| `tk_no` HOẶC `tk_co` KHÔNG rỗng | Drilldown theo tk_no/tk_co:<br>- sDrilldownMenuId = drilldown_menuid1<br>- Tham số: CompanyID, tk_no, tk_co, null, ngay_ct1, ngay_ct2<br>- Filter: chi_tieu (tên chỉ tiêu) |

### Modifier Keys khác (Ctrl, Shift, Alt)

| Điều kiện | Hành động |
|-----------|-----------|
| Bất kỳ | Hủy drilldown |

---

## Các trường dữ liệu quan trọng

| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Công thức tính (chứa các ma_so cách nhau bởi +,-) |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `ma_so` | Mã số |
| `ngay_ct1`, `ngay_ct2` | Khoảng ngày chứng từ |

---

## Xử lý ngoại lệ

```csharp
try
{
    dataRowView = new DataView((DataTable)((DataGridView)base.dgvBC).DataSource)[...]
}
catch (Exception ex)
{
    base.CancelDrilldown = true;
    result = null;
    ProjectData.ClearProjectError();
}
```

- Try-catch khi lấy DataRowView từ DataSource
- Nếu có lỗi: hủy drilldown, clear error

---

## Mục đích sử dụng

**GLRptF5BCTC03CT.dll là module báo cáo F5 "BCTC03 chi tiết"** - một báo cáo drilldown trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo drilldown chi tiết BCTC03
- Kế thừa từ `frmDrilldownReport` - form drilldown chuẩn của Asia ERP
- Nhận dữ liệu từ báo cáo mẹ (BCTC03 - Báo cáo kết quả hoạt động kinh doanh)
- Drilldown chi tiết theo chỉ tiêu

#### 2. Drilldown theo công thức tính (F7)
- Khi cell có `cach_tinh` chứa công thức (ví dụ: "41+42-43")
- Lọc các dòng có ma_so trong công thức
- Hiển thị chi tiết các thành phần của chỉ tiêu
- Filter: "ma_so = cach_tinh"

#### 3. Drilldown theo tk_no/tk_co (F7)
- Khi cell có `tk_no` hoặc `tk_co` chứa tài khoản
- Xem chi tiết phát sinh theo cặp TK nợ/TK có
- Truyền tham số:
  - CompanyID
  - tk_no = tài khoản nợ
  - tk_co = tài khoản có
  - ngay_ct1, ngay_ct2 = khoảng ngày từ báo cáo mẹ
- Filter: chi_tieu (tên chỉ tiêu báo cáo)

#### 4. Filter condition
- Khi drilldown theo cach_tinh: "ma_so = cach_tinh"
- Khi drilldown theo tk_no/tk_co: tên chỉ tiêu (chi_tieu)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` thay vì `frmReport`
- Sử dụng __ENCList cho list weak reference (VB compatibility)
- Không có UI controls riêng - sử dụng dgvBC từ form mẹ
- Chỉ hỗ trợ F7 thường, không hỗ trợ Ctrl+F7 hay Shift+F7
- Có try-catch khi lấy DataRowView để tránh crash
- tk_no và tk_co dùng để lọc theo bút toán (nợ/có)

### Mã báo cáo

**F5BCTC03CT** - Báo cáo F5 BCTC03 chi tiết (drilldown từ Báo cáo kết quả hoạt động kinh doanh)

---

## Kết luận

Đây là một module Windows Forms drilldown của hệ thống ERP Asia Enterprise, phục vụ cho việc xem chi tiết các thành phần của chỉ tiêu trong báo cáo BCTC03 (Báo cáo kết quả hoạt động kinh doanh). Báo cáo hỗ trợ drilldown theo công thức tính và theo cặp tài khoản nợ/có để xem chi tiết các giao dịch cấu thành nên chỉ tiêu.

---

*Ngày phân tích: 2026-03-29*
