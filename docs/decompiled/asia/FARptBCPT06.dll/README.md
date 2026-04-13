# Báo cáo Phân tích DLL: FARptBCPT06.dll

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
| Assembly Name | FARptBCPT06 |
| Assembly Title | FARptBCPT06 |
| Assembly Company | |
| Assembly Product | FARptBCPT06 |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 914867cf-6811-40b9-b778-7c6a723300c9 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCPT06.dll/
├── FARptBCPT06.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCPT06.cs        # Main report form
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs            # Settings manager
    ├── MyApplication.cs         # Application context
    ├── MyComputer.cs            # Computer info
    ├── MyProject.cs             # Project context
    ├── MySettingsProperty.cs    # Settings properties
    └── InternalXmlHelper.cs     # XML helper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Core | .NET Core extensions |
| System.Xml.Linq | LINQ to XML |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCPT06` | `frmReport` | Form báo cáo phân tích tài sản 06 |

---

## Controls và UI

### Form chính (frmFARptBCPT06)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_BPSD | AsTextBox | Mã bộ phận sử dụng (MA_BPSD) |
| lblMa_BPSD | Label | Nhãn "Mã BPSD" |
| lblTen_BPSD | Label | Tên bộ phận sử dụng |
| txtMa_Phi | AsTextBox | Mã phí (MA_PHI) |
| lblMa_Phi | Label | Nhãn "Mã phí" |
| lblTen_Phi | Label | Tên phí |
| txtMa_SPCT | AsTextBox | Mã sản phẩm chi tiết (MA_SPCT) |
| lblMa_SPCT | Label | Nhãn "Mã SPCT" |
| lblTen_SPCT | Label | Tên sản phẩm chi tiết |

### Controls kế thừa từ frmReport

| Control | Mục đích |
|---------|----------|
| cboKyBc | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | Từ ngày - Đến ngày |
| cboMau_bc | Chọn mẫu báo cáo |
| txtTieu_De | Tiêu đề báo cáo |
| cmdOk | Nút xem báo cáo |
| cmdCancel | Nút hủy |
| cmdExcel | Nút xuất Excel |
| cmdModifyReport | Nút sửa mẫu báo cáo |

---

## Business Logic

### Phương thức chính

#### InitOtherComponents()
- Khởi tạo giá trị mặc định
- Focus vào cboKyBc

#### LoadData()
- Gọi stored procedure lấy dữ liệu báo cáo
- Tham số: CompanyID, Ngay1, Ngay2, Ma_BPSD, Ma_Phi, Ma_SPCT
- Sử dụng Trim() để xử lý dữ liệu đầu vào
- Gán dữ liệu cho DataGridView và báo cáo
- Thiết lập formula field `strSubTitle1`

#### GetFilterTitle()
- Tạo chuỗi mô tả điều kiện lọc đã chọn
- Sử dụng Trim() để làm sạch dữ liệu
- Hiển thị trên báo cáo

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |

---

## Mục đích sử dụng

**FARptBCPT06.dll là module báo cáo phân tích tài sản 06** trong hệ thống ERP của ASIA.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản
- Phân tích tài sản cố định theo nhiều chiều
- Lọc theo bộ phận sử dụng, mã phí, sản phẩm chi tiết
- Hỗ trợ kỳ báo cáo tùy chọn

#### 2. Điều kiện lọc
- Kỳ báo cáo (tháng/năm)
- Khoảng thời gian (từ ngày - đến ngày)
- Mã bộ phận sử dụng (BPSD)
- Mã phí
- Mã sản phẩm chi tiết (SPCT)

#### 3. Xuất báo cáo
- Xem trước trên form
- Xuất Excel
- In báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các mã danh mục
- Xử lý dữ liệu đầu vào với Trim() để loại bỏ khoảng trắng
- Tích hợp Crystal Reports

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP ASIA, phục vụ cho việc lập báo cáo phân tích tài sản cố định theo các tiêu chí phân loại khác nhau.

---

*Ngày phân tích: 2026-03-29*
