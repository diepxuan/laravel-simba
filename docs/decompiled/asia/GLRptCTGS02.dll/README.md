# Báo cáo Phân tích DLL: GLRptCTGS02.dll

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
| Assembly Name | GLRptCTGS02 |
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
GLRptCTGS02.dll/
├── GLRptCTGS02.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptCTGS02.cs        # Main form class
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptCTGS02` | `frmReport` | Form báo cáo chứng từ ghi sổ 02 |

---

## Controls chính

| Control | Type | Mục đích |
|---------|------|----------|
| `txtTu_so` | AsTextBox | Nhập số chứng từ từ |
| `txtDen_so` | AsTextBox | Nhập số chứng từ đến |
| `lblTu_so` | Label | Nhãn "Chứng từ từ số" |
| `lblDen_so` | Label | Nhãn "đến số" |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Khoảng ngày báo cáo |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Chọn loại tiền (VND/Ngoại tệ) |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `LoadData()` | Lấy dữ liệu báo cáo từ server với các tham số: CompanyID, ngày từ/đến, số từ/đến, mã ngoại tệ |
| `FormatGridView()` | Định dạng DataGridView, set readonly cho các cột |
| `dgvBC_CellEnter()` | Xử lý sự kiện khi enter vào cell, cho phép edit cột "tag" |
| `CreateDrilldownArgument()` | Tạo tham số drilldown khi F7 - chi tiết theo lô |
| `LoadDataToCrystal()` | Load dữ liệu vào Crystal Report |
| `ViewCrystalBySource()` | Xem báo cáo Crystal với dữ liệu đã chọn |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Chứng từ từ số", "đến số" - Lọc theo khoảng số chứng từ
- "Kỳ báo cáo", "Từ ngày", "Đến ngày" - Lọc theo thời gian
- "Mẫu báo cáo", "Ngoại tệ" - Tùy chọn hiển thị

### Tham số báo cáo

| Tham số | Ý nghĩa |
|---------|---------|
| `CompanyID` | Mã công ty |
| `txtNgay1`, `txtNgay2` | Khoảng ngày báo cáo |
| `txtTu_so`, `txtDen_so` | Khoảng số chứng từ |
| `txtMa_Nt` | Mã ngoại tệ |
| `TAG=1` | Lọc các dòng được đánh dấu để in |

### Drilldown (F7)

- Drilldown theo lô: truyền `ngay_lo`, `so_lo`
- Filter condition: `so_lo - dien_giai`

---

## Mục đích sử dụng

**GLRptCTGS02.dll là module báo cáo "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc và hiển thị báo cáo
- Lọc theo khoảng ngày báo cáo
- Lọc theo khoảng số chứng từ (từ số - đến số)
- Hỗ trợ đa ngoại tệ (VND hoặc ngoại tệ)
- Chọn mẫu báo cáo in

#### 2. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- Cho phép đánh dấu (TAG=1) các dòng cần in
- In báo cáo qua Crystal Report
- Xuất Excel

#### 3. Drilldown (F7)
- Nhấn F7 để xem chi tiết theo lô
- Truyền tham số: ngày lô, số lô
- Filter condition hiển thị: số lô + diễn giải

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng DataBinding với DataTable
- Hỗ trợ Crystal Report để in ấn
- Validate: phải chọn mẫu báo cáo trước khi load dữ liệu
- Cột "tag" cho phép người dùng đánh dấu các dòng cần in

### Mã báo cáo

**CTGS02** - Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào (theo Thông tư 39/2014/TT-BTC)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem, lọc và in báo cáo bảng kê hóa đơn, chứng từ hàng hóa dịch vụ mua vào - một báo cáo quan trọng trong kế toán thuế GTGT.

---

*Ngày phân tích: 2026-03-29*
