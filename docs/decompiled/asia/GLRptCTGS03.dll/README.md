# Báo cáo Phân tích DLL: GLRptCTGS03.dll

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
| Assembly Name | GLRptCTGS03 |
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
GLRptCTGS03.dll/
├── GLRptCTGS03.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptCTGS03.cs        # Main form class
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
| `frmGLRptCTGS03` | `frmReport` | Form báo cáo chứng từ ghi sổ 03 - theo tài khoản |

---

## Controls chính

| Control | Type | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Nhập tài khoản cần báo cáo |
| `lblTk` | Label | Nhãn "Tài khoản" |
| `lblTen_tk` | Label | Hiển thị tên tài khoản (lookup) |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Khoảng ngày báo cáo |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Chọn loại tiền (VND/Ngoại tệ) |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `LoadData()` | Lấy dữ liệu báo cáo với tham số: CompanyID, TK, ngày từ/đến, mã ngoại tệ |
| `InitOtherComponents()` | Khởi tạo components, select vào cboKyBc |
| `CreateDrilldownArgument()` | Tạo tham số drilldown khi F7 - chi tiết theo lô và TK |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tài khoản" - Lọc theo tài khoản kế toán
- "Kỳ báo cáo", "Từ ngày", "Đến ngày" - Lọc theo thời gian
- "Mẫu báo cáo", "Ngoại tệ" - Tùy chọn hiển thị

### Tham số báo cáo

| Tham số | Ý nghĩa |
|---------|---------|
| `CompanyID` | Mã công ty |
| `txtTk` | Tài khoản cần báo cáo (bắt buộc) |
| `txtNgay1`, `txtNgay2` | Khoảng ngày báo cáo |
| `txtMa_Nt` | Mã ngoại tệ |

### Drilldown (F7)

- Drilldown theo lô và tài khoản
- Truyền tham số: `ngay_lo`, `so_lo`, `tk`, `tk_du`
- Filter condition: `so_lo - dien_giai`

### Validation

- Tài khoản là bắt buộc - nếu để trống sẽ báo lỗi 50002
- AutoLookup: tìm kiếm tài khoản từ danh mục TK

---

## Mục đích sử dụng

**GLRptCTGS03.dll là module báo cáo "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc và hiển thị báo cáo theo TK
- Lọc theo tài khoản kế toán cụ thể (bắt buộc)
- Lọc theo khoảng ngày báo cáo
- Hỗ trợ đa ngoại tệ (VND hoặc ngoại tệ)
- Chọn mẫu báo cáo in

#### 2. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- In báo cáo qua Crystal Report
- Xuất Excel

#### 3. Drilldown (F7)
- Nhấn F7 để xem chi tiết chứng từ theo lô
- Truyền tham số: ngày lô, số lô, tài khoản, tài khoản đối ứng
- Filter condition hiển thị: số lô + diễn giải

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng DataBinding với DataTable
- txtTk có AutoLookup=true, LookupCodeName="TK"
- lblTen_tk là NameControl hiển thị tên TK khi lookup
- Validate: tài khoản không được để trống

### Mã báo cáo

**CTGS03** - Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem, lọc và in báo cáo bảng kê hóa đơn, chứng từ hàng hóa dịch vụ mua vào theo từng tài khoản kế toán cụ thể.

---

*Ngày phân tích: 2026-03-29*
