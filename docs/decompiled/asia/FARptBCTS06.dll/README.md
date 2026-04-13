# Báo cáo Phân tích DLL: FARptBCTS06.dll

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
| Assembly Name | FARptBCTS06 |
| Assembly Title | Báo cáo tăng giảm tài sản cố định |
| Assembly Company | |
| Assembly Product | FARptBCTS06 |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 1b385fb5-7166-44a3-8b8a-49da6a5f5575 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCTS06.dll/
├── FARptBCTS06.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCTS06.cs        # Main report form
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs            # Settings manager
    ├── MyApplication.cs         # Application context
    ├── MyComputer.cs            # Computer info
    ├── MyProject.cs             # Project context
    ├── MySettingsProperty.cs    # Settings properties
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS06` | `frmReport` | Form báo cáo tăng giảm tài sản cố định |

---

## Controls và UI

### Form chính (frmFARptBCTS06)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_Bp | AsTextBox | Mã bộ phận (MA_BPSD) |
| lblMa_Bp | Label | Nhãn "Mã BPSD" |
| lblTen_Bp | Label | Tên bộ phận |
| txtMa_Phi | AsTextBox | Mã phí (MA_PHI) |
| lblMa_Phi | Label | Nhãn "Mã phí" |
| lblTen_Phi | Label | Tên phí |
| txtMa_Spct | AsTextBox | Mã sản phẩm chi tiết (MA_SPCT) |
| lblMa_Spct | Label | Nhãn "Mã SPCT" |
| lblTen_Spct | Label | Tên sản phẩm chi tiết |

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

#### Constructor
- Nhận tham số Menuid
- Khởi tạo form báo cáo

#### InitOtherComponents()
- Khởi tạo các giá trị mặc định

#### LoadData()
- Gọi stored procedure lấy dữ liệu báo cáo
- Tham số: CompanyID, Ngay1, Ngay2, Ma_Bp, Ma_Phi, Ma_Spct
- Gán dữ liệu cho DataGridView và báo cáo
- Gọi `ViewCrystalBySource()` để hiển thị Crystal Report
- Thiết lập formula field `strFilterTitle`

#### GetFilterTitle()
- Tạo chuỗi mô tả điều kiện lọc đã chọn
- Hiển thị trên báo cáo

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `tang_giam` | Tăng giảm tài sản |
| `tscd` | Tài sản cố định |

---

## Mục đích sử dụng

**FARptBCTS06.dll là module báo cáo "Tăng giảm tài sản cố định"** trong hệ thống ERP của ASIA.

### Chức năng chính

#### 1. Báo cáo tăng giảm TSCĐ
- Theo dõi các khoản tăng và giảm tài sản cố định
- Lọc theo bộ phận, mã phí, sản phẩm chi tiết
- Hỗ trợ kỳ báo cáo tùy chọn

#### 2. Điều kiện lọc
- Kỳ báo cáo (tháng/năm)
- Khoảng thời gian (từ ngày - đến ngày)
- Mã bộ phận (BP)
- Mã phí
- Mã sản phẩm chi tiết (SPCT)

#### 3. Xuất báo cáo
- Xem trước trên form
- Hiển thị Crystal Report
- Xuất Excel
- In báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các mã danh mục
- Gọi `ViewCrystalBySource()` để render báo cáo
- Tích hợp Crystal Reports

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP ASIA, phục vụ cho việc lập báo cáo tăng giảm tài sản cố định theo các tiêu chí phân loại khác nhau. Đây là báo cáo quan trọng trong quản lý tài sản cố định của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
