# Báo cáo Phân tích DLL: FARptBCTS05.dll

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
| Assembly Name | FARptBCTS05 |
| Assembly Title | FARptBCTS05 |
| Assembly Company | |
| Assembly Product | FARptBCTS05 |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | bf67aebe-3e82-4b5a-84cf-1f0bd3ab781b |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCTS05.dll/
├── FARptBCTS05.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCTS05.cs        # Main report form
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
| `frmFARptBCTS05` | `frmReport` | Form báo cáo biến động tài sản 05 |

---

## Controls và UI

### Form chính (frmFARptBCTS05)

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
- Thiết lập formula field `strFiltertitle`

#### GetFilterTitle()
- Tạo chuỗi mô tả điều kiện lọc đã chọn
- Hiển thị cả mã và tên (format: "Mã: [code - name]")
- Sử dụng Trim() để làm sạch dữ liệu

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `bien_dong` | Biến động tài sản |

---

## Mục đích sử dụng

**FARptBCTS05.dll là module báo cáo biến động tài sản 05** trong hệ thống ERP của ASIA.

### Chức năng chính

#### 1. Báo cáo biến động tài sản
- Theo dõi các biến động của tài sản cố định
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
- Hiển thị filter title với format đầy đủ mã và tên
- Tích hợp Crystal Reports

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP ASIA, phục vụ cho việc lập báo cáo biến động tài sản cố định theo các tiêu chí phân loại khác nhau.

---

*Ngày phân tích: 2026-03-29*
