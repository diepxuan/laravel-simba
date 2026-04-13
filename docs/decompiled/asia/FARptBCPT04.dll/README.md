# Báo cáo Phân tích DLL: FARptBCPT04.dll

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
| Assembly Name | FARptBCPT04 |
| Assembly Title | Bảng phân bổ khấu hao theo nhóm tài sản |
| Assembly Company | ASIA |
| Assembly Product | FARptBCPT04 |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | f54910e1-4ffe-4070-b048-6f8255a84940 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCPT04.dll/
├── FARptBCPT04.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmFARptBCPT04.cs        # Main report form
└── AsiaERP.UserInterface.My/
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
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCPT04` | `frmReport` | Form báo cáo phân bổ khấu hao theo nhóm tài sản |

---

## Controls và UI

### Form chính (frmFARptBCPT04)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng (MA_BPSD) |
| lblMa_bpsd | Label | Nhãn "Mã BPSD" |
| lblTen_bpsd | Label | Tên bộ phận sử dụng |
| txtMa_phi | AsTextBox | Mã phí (MA_PHI) |
| lblMa_phi | Label | Nhãn "Mã phí" |
| lblTen_phi | Label | Tên phí |
| txtma_spct | AsTextBox | Mã sản phẩm chi tiết (MA_SPCT) |
| lblMa_spct | Label | Nhãn "Mã SPCT" |
| lblTen_spct | Label | Tên sản phẩm chi tiết |

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

#### LoadData()
- Gọi stored procedure lấy dữ liệu báo cáo
- Tham số: CompanyID, Ngay1, Ngay2, Ma_bpsd, Ma_phi, Ma_spct
- Gán dữ liệu cho DataGridView và báo cáo

#### GetFilterTitle()
- Tạo chuỗi mô tả điều kiện lọc đã chọn
- Hiển thị trên báo cáo

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `khau_hao` | Khấu hao tài sản |
| `pb_khau_hao` | Phân bổ khấu hao |

---

## Mục đích sử dụng

**FARptBCPT04.dll là module báo cáo "Bảng phân bổ khấu hao theo nhóm tài sản"** trong hệ thống ERP của ASIA.

### Chức năng chính

#### 1. Báo cáo phân bổ khấu hao
- Phân bổ chi phí khấu hao tài sản cố định theo nhóm
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
- Tích hợp Crystal Reports qua `ViewCrystalBySource`
- Hỗ trợ localization qua resource files

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP ASIA, phục vụ cho việc lập báo cáo phân bổ khấu hao tài sản cố định theo các nhóm phân loại khác nhau (bộ phận, phí, sản phẩm).

---

*Ngày phân tích: 2026-03-29*
