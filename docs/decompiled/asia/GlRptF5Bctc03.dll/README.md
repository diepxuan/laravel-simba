# Báo cáo Phân tích DLL: GlRptF5Bctc03.dll

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
| Assembly Name | GlRptF5Bctc03 |
| Assembly Title | GLRptF5CTGS01 |
| Assembly Company | Asia |
| Assembly Product | GLRptF5CTGS01 |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 555e1310-3ce6-4277-ba6a-2a9dff935e02 |
| ComVisible | false |

---

## Cấu trúc File

```
GlRptF5Bctc03.dll/
├── GlRptF5Bctc03.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGlRptF5Bctc03.cs      # Main form class (Drilldown Report)
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptF5Bctc03` | `frmDrilldownReport` | Form báo cáo drilldown cho BCTC - Cân đối phát sinh |
| `Resources` | - | Resource manager cho localization |

---

## Phân tích frmGlRptF5Bctc03

### Kế thừa
- Kế thừa từ `frmDrilldownReport` - Form báo cáo có khả năng drilldown

### Constructor

```csharp
public frmGlRptF5Bctc03(
    ReportInformation motherReportInfo, 
    string drilldownMenuId, 
    AsDictionary formularFields, 
    bool isNT, 
    string nhan_in, 
    string filter4Tilte, 
    string formatedColList, 
    object datasource, 
    params object[] arg
)
```

### Thuộc tính và Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `epNotice` | ErrorProvider | Hiển thị thông báo lỗi |
| `AsTabControl` | TabControl | Tab container |
| `dgvBC` | DataGridView | Grid hiển thị dữ liệu báo cáo |

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `KeyDown` | `frmGlRptF5Bctc03_KeyDown` | Xử lý phím tắt (F5) |

### Phương thức chính

#### CreateDrilldownArgument
Tạo tham số cho chức năng drilldown khi người dùng nhấn F5 trên một dòng dữ liệu.

**Logic xử lý:**

1. **Kiểm tra phím**: Chỉ xử lý khi nhấn F5 (KeyCode = 116)
2. **Lấy dòng hiện tại**: Từ DataGridView `dgvBC`
3. **Kiểm tra điều kiện drilldown**:
   - Nếu `cach_tinh`, `tk_no`, `tk_co` đều rỗng → Cancel drilldown
   
4. **Drilldown theo cách tính** (ưu tiên):
   - Nếu `cach_tinh` không rỗng
   - Drilldown vào menu `drilldown_menuid`
   - Filter theo các mã số trong `cach_tinh` (phân tách bởi `+` hoặc `-`)
   - Hiển thị chi tiết công thức tính
   
5. **Drilldown theo tài khoản**:
   - Nếu `tk_no` hoặc `tk_co` không rỗng
   - Drilldown vào menu `drilldown_menuid1`
   - Truyền tham số: CompanyID, tk_no, tk_co, null, ngay_ct1, ngay_ct2

### Các trường dữ liệu xử lý

| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Cách tính/Chỉ tiêu (công thức tính toán) |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `ngay_ct1` | Ngày bắt đầu |
| `ngay_ct2` | Ngày kết thúc |

---

## Mục đích sử dụng

**GlRptF5Bctc03.dll là module báo cáo drilldown** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo BCTC - Cân đối phát sinh
- Hiển thị báo cáo tài chính dạng cân đối phát sinh
- Hỗ trợ xem chi tiết các chỉ tiêu báo cáo

#### 2. Drilldown đa cấp
- **Drilldown theo công thức**: Khi một chỉ tiêu được tính từ nhiều chỉ tiêu khác, có thể xem chi tiết các chỉ tiêu thành phần
- **Drilldown theo tài khoản**: Xem chi tiết phát sinh của tài khoản nợ/có trong khoảng thời gian

#### 3. Tích hợp với hệ thống báo cáo
- Kế thừa từ `frmDrilldownReport` - framework báo cáo chuẩn của Asia ERP
- Sử dụng `ReportInformation` và `ReportDrillDownInfo` để quản lý luồng drilldown

### Đặc điểm kỹ thuật

- **Kích thước form**: 792 x 512 pixels
- **Font mặc định**: 6f x 13f (AutoScaleDimensions)
- **Key handling**: Phím F5 để drilldown
- **Data binding**: Sử dụng DataView từ DataGridView

### Mã báo cáo

**F5BCTC03** - Báo cáo tài chính, cân đối phát sinh (theo quy định BCTC)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và drilldown báo cáo tài chính dạng cân đối phát sinh. Module cho phép người dùng xem chi tiết các chỉ tiêu báo cáo thông qua cơ chế drilldown linh hoạt theo công thức hoặc theo tài khoản kế toán.

---

*Ngày phân tích: 2026-03-29*
