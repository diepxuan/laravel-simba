# Báo cáo Phân tích DLL: FARptBCPT05.dll

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
| Assembly Name | FARptBCPT05 |
| Assembly Title | FARptBCPT05 |
| Assembly Company | |
| Assembly Product | FARptBCPT05 |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | d4bf8430-39e2-4c36-9248-8ca7f0672880 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCPT05.dll/
├── FARptBCPT05.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCPT05.cs        # Main report form
├── AsiaErp.UserInterface.My/
│   ├── MySettings.cs            # Settings manager
│   ├── MyApplication.cs         # Application context
│   ├── MyComputer.cs            # Computer info
│   ├── MyProject.cs             # Project context
│   ├── MySettingsProperty.cs    # Settings properties
│   └── InternalXmlHelper.cs     # XML helper
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
| `frmFARptBCPT05` | `frmReport` | Form báo cáo phân tích tài sản 05 |

---

## Controls và UI

### Form chính (frmFARptBCPT05)

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
| cboTheo_nhom | ComboBox | Chọn nhóm hiển thị (ẩn) |
| lblTheo_nhom | Label | Nhãn "Theo nhóm" (ẩn) |

### Tùy chọn nhóm (cboTheo_nhom)

| Giá trị | Ý nghĩa |
|---------|---------|
| BP sử dụng | Nhóm theo bộ phận sử dụng |
| Mã phí | Nhóm theo mã phí |
| Mã SPCT | Nhóm theo sản phẩm chi tiết |

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
- Set cboTheo_nhom.SelectedIndex = 0

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
| `theo_nhom` | Nhóm dữ liệu báo cáo |

---

## Mục đích sử dụng

**FARptBCPT05.dll là module báo cáo phân tích tài sản 05** trong hệ thống ERP của ASIA.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản
- Phân tích tài sản cố định theo nhiều chiều
- Lọc theo bộ phận sử dụng, mã phí, sản phẩm chi tiết
- Hỗ trợ nhóm dữ liệu (BP sử dụng, Mã phí, Mã SPCT)
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
- Có combo box chọn nhóm (hiện đang ẩn)
- Xử lý dữ liệu đầu vào với Trim()
- Tích hợp Crystal Reports

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP ASIA, phục vụ cho việc lập báo cáo phân tích tài sản cố định theo các tiêu chí phân loại khác nhau, với khả năng nhóm dữ liệu linh hoạt.

---

*Ngày phân tích: 2026-03-29*
