# Báo cáo Phân tích DLL: GlRptF5Bctc04.dll

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
| Assembly Name | GlRptF5Bctc04 |
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
GlRptF5Bctc04.dll/
├── GlRptF5Bctc04.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGlRptF5Bctc04.cs      # Main report form class
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs             # VB.NET compatibility
│   ├── MyApplication.cs         # Application context
│   ├── MySettings.cs            # Settings manager
│   ├── MySettingsProperty.cs    # Settings properties
│   └── MyComputer.cs            # Computer info
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
- `System`, `System.Data`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptF5Bctc04` | `frmDrilldownReport` | Form báo cáo drilldown cho BCTC - F5 |

---

## Phân tích Business Logic

### Class `frmGlRptF5Bctc04`

#### Constructor
- `frmGlRptF5Bctc04(ReportInformation, string, AsDictionary, bool, string, string, string, object, params object[])` - Constructor đầy đủ với drilldown support
- `frmGlRptF5Bctc04()` - Constructor mặc định

#### Phương thức chính

| Phương thức | Mục đích |
|-------------|----------|
| `InitOtherComponents()` | Khởi tạo components, focus vào DataGridView báo cáo |
| `CreateDrilldownArgument()` | Xử lý logic drilldown khi người dùng nhấn F5 |

#### Drilldown Logic (F5)

Khi người dùng nhấn **F5** trên báo cáo:

1. **Kiểm tra dữ liệu hàng hiện tại**:
   - `cach_tinh` - Cách tính/mã số công thức
   - `tk_no` - Tài khoản nợ
   - `tk_co` - Tài khoản có

2. **Các trường hợp drilldown**:

   **TH1: Có `cach_tinh`**
   - Drilldown theo menu `drilldown_menuid`
   - Lọc dữ liệu theo các mã số trong công thức (phân tách bởi `+` hoặc `-`)
   - Hiển thị title: `ma_so = cach_tinh`

   **TH2: Có `tk_no` hoặc `tk_co`**
   - Drilldown theo menu `drilldown_menuid1`
   - Truyền tham số:
     - CompanyID
     - tk_no
     - tk_co
     - null
     - ngay_ct1 (từ ngày)
     - ngay_ct2 (đến ngày)
   - Hiển thị title: `chi_tieu`

#### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `cach_tinh` | Cách tính/công thức tính chỉ tiêu BCTC |
| `ma_so` | Mã số chỉ tiêu trên báo cáo tài chính |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `ngay_ct1` | Từ ngày chứng từ |
| `ngay_ct2` | Đến ngày chứng từ |

---

## Mục đích sử dụng

**GlRptF5Bctc04.dll là module báo cáo drilldown cho Báo cáo Tài chính (BCTC)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Drilldown từ Báo cáo Tài chính
- Cho phép người dùng nhấn **F5** để xem chi tiết từ chỉ tiêu tổng hợp
- Drilldown theo công thức tính: phân tích thành phần chỉ tiêu
- Drilldown theo tài khoản: xem chi tiết phát sinh TK nợ/TK có

#### 2. Phân tích chỉ tiêu BCTC
- Phân tích công thức tính (vd: "111+112-113")
- Lọc và hiển thị các chỉ tiêu thành phần
- Tính toán lại giá trị theo công thức

#### 3. Xem chi tiết chứng từ
- Drilldown đến danh sách chứng từ chi tiết
- Lọc theo khoảng thời gian (ngay_ct1 → ngay_ct2)
- Lọc theo tài khoản nợ/có cụ thể

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - base form cho báo cáo drilldown
- Sử dụng `DataGridView` (`dgvBC`) để hiển thị dữ liệu
- Xử lý phím tắt F5 để kích hoạt drilldown
- Hỗ trợ multi-level drilldown (drilldown_menuid, drilldown_menuid1)
- Sử dụng `Helper.Repl_Null` để xử lý null values

### Mã báo cáo

**F5** - Báo cáo Tài chính (BCTC) - một báo cáo quan trọng trong kế toán doanh nghiệp Việt Nam, bao gồm:
- Bảng Cân đối kế toán
- Báo cáo Kết quả hoạt động kinh doanh
- Báo cáo Lưu chuyển tiền tệ
- Thuyết minh Báo cáo Tài chính

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc drilldown (đào sâu) từ các chỉ tiêu tổng hợp trên Báo cáo Tài chính xuống chi tiết chứng từ hoặc phân tích thành phần công thức tính. Đây là chức năng quan trọng giúp người dùng tra cứu và kiểm tra dữ liệu nguồn của các chỉ tiêu báo cáo.

---

*Ngày phân tích: 2026-03-29*
