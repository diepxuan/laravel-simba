# Báo cáo Phân tích DLL: GLRptCTGS01.dll

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
| Assembly Name | GLRptCTGS01 |
| Assembly Title | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptCTGS01.dll/
├── GLRptCTGS01.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptCTGS01.cs        # Main report form
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
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptCTGS01` | `frmReport` | Form báo cáo Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào |

---

## Controls và Events chính

### frmGLRptCTGS01

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Ngày bắt đầu/kết thúc |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Tùy chọn tiền tệ |
| `cmdOk` | Button | Xem báo cáo |
| `cmdModifyReport` | Button | Sửa mẫu báo cáo |
| `cmdCancel` | Button | Hủy |
| `cmdExcel` | Button | Xuất Excel |

---

## Phương thức chính

### InitOtherComponents()
- Focus vào control `cboKyBc` khi khởi tạo

### LoadData()
- Kiểm tra `cboMau_bc.SelectedIndex` phải khác -1
- Load dữ liệu báo cáo với các tham số:
  - CompanyID
  - Ngày bắt đầu (txtNgay1)
  - Ngày kết thúc (txtNgay2)
  - Mã ngoại tệ (txtMa_Nt)

### CreateDrilldownArgument()
- Xử lý drill-down với phím F5
- Tham số drill-down:
  - CompanyID
  - Ngày lô (ngay_lo)
  - Số lô (so_lo)
  - Ngày CT1, Ngày CT2 (từ filter)
- Filter condition title: `so_lo + " - " + dien_giai`

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào" - Tên báo cáo
- "Kỳ báo cáo" - Chọn kỳ
- "Mẫu báo cáo" - Chọn mẫu
- "Tiêu đề" - Nhập tiêu đề
- "Mã ngoại tệ" - Chọn ngoại tệ

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ngay_lo` | Ngày lô chứng từ |
| `so_lo` | Số lô chứng từ |
| `dien_giai` | Diễn giải |

---

## Mục đích sử dụng

**GLRptCTGS01.dll là module báo cáo "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Bảng kê hóa đơn mua vào
- Liệt kê các hóa đơn, chứng từ mua hàng hóa/dịch vụ
- Phục vụ cho việc kê khai thuế GTGT đầu vào
- Theo dõi chứng từ mua vào theo kỳ

#### 2. Quản lý lô chứng từ
- Drill-down theo số lô và ngày lô
- Xem chi tiết các chứng từ trong lô

#### 3. Báo cáo thuế
- Hỗ trợ kê khai thuế GTGT
- Bảng kê phục vụ cho quyết toán thuế

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Form đơn giản, ít filter
- Hỗ trợ drill-down theo lô chứng từ
- Hỗ trợ đa tiền tệ

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào - một báo cáo phục vụ cho việc kê khai thuế GTGT và quản lý chứng từ mua vào.

---

*Ngày phân tích: 2026-03-29*
