# Báo cáo Phân tích DLL: CoCalcCost.dll

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
| Assembly Name | CoCalcCost |
| Assembly Title | CoCalcCost |
| Assembly Company | Asia |
| Assembly Product | CoCalcCost |
| Assembly Copyright | Copyright © Asia 2011 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | dd7585f2-adc7-4e59-9b0f-0caea88b302c |
| ComVisible | false |

---

## Cấu trúc File

```
CoCalcCost.dll/
├── CoCalcCost.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmCoCalcCost.cs           # Main form - Tính giá thành
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs               # VB.NET My project support
│   ├── MyComputer.cs              # VB.NET My computer support
│   ├── MySettings.cs              # Settings manager
│   ├── MySettingsProperty.cs      # Settings property
│   ├── MyApplication.cs           # Application support
│   └── InternalXmlHelper.cs       # XML helper
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs               # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../projects/SimbaSql/native-apps/ASIA/Framework.dll) |
| CrystalDecisions.Windows.Forms | Crystal Report viewer |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |
| System.Data | Data access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoCalcCost` | `frmReport2DGV` | Form tính giá thành với 2 DataGridView |

---

## Controls và UI Components

### Controls chính (frmCoCalcCost)

| Control | Loại | Mục đích |
|---------|------|----------|
| dgvBCPh | AsDataGridView | DataGridView báo cáo phần header (master) |
| dgvBCCt | AsDataGridView | DataGridView báo cáo phần chi tiết |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo/tính toán |
| txtTK | AsTextBox | Tài khoản dở dang |
| lblTK | Label | Label hiển thị tên tài khoản |
| btnUpdate | Button | Nút "Cập nhật GT" - Cập nhật giá thành |
| btnDelUpdate | Button | Nút "Xóa cập nhật" - Xóa cập nhật giá thành |
| crvReportViewer | CrystalReportViewer | Crystal Report viewer |
| cmdOk | Button | Nút OK để thực hiện |
| cmdCancel | Button | Nút Cancel để hủy |
| cmdExcel | Button | Nút xuất Excel |

---

## Business Logic và Events

### Methods chính

| Phương thức | Mô tả |
|-------------|-------|
| `LoadData()` | Tải dữ liệu báo cáo từ stored procedure |
| `ValidData()` | Kiểm tra dữ liệu hợp lệ trước khi thực hiện |
| `btnUpdate_Click()` | Xử lý cập nhật giá thành |
| `btnDelUpdate_Click()` | Xử lý xóa cập nhật giá thành |
| `dgv_CurrentCellChanged()` | Xử lý khi thay đổi dòng trong DataGridView master |
| `frmCOGDBGT_Load()` | Xử lý khi form load |

### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| Form.Load | frmCOGDBGT_Load | Khởi tạo form, thiết lập kỳ báo cáo |
| btnUpdate.Click | btnUpdate_Click | Thực hiện cập nhật giá thành |
| btnDelUpdate.Click | btnDelUpdate_Click | Thực hiện xóa cập nhật giá thành |
| dgvBCPh.CurrentCellChanged | dgv_CurrentCellChanged | Lọc chi tiết theo dòng master |

### Stored Procedures

| SP Name | Mục đích |
|---------|----------|
| `MyMenuInfo.par2` | Stored procedure cập nhật giá thành |
| `MyMenuInfo.par3` | Stored procedure xóa cập nhật giá thành |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Kỳ tính toán" - Label kỳ báo cáo
- "TK dở dang" - Label tài khoản dở dang
- "Cập nhật GT" - Nút cập nhật giá thành
- "Xóa cập nhật" - Nút xóa cập nhật

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `TK` | Tài khoản |
| `Kỳ tính toán` | Kỳ báo cáo/kỳ tính giá thành |
| `ngay_ks` | Ngày khóa sổ |
| `ma_spct` | Mã sản phẩm chi tiết |

---

## Mục đích sử dụng

**CoCalcCost.dll là module tính giá thành** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Tính giá thành sản phẩm
- Tính toán giá thành cho các sản phẩm chi tiết (SPCT)
- Dựa trên tài khoản dở dang (TK dở dang)
- Theo kỳ tính toán (tháng/quý/năm)

#### 2. Cập nhật giá thành
- Nút "Cập nhật GT" để thực hiện tính toán và cập nhật giá thành
- Gọi stored procedure để thực hiện tính toán trên server
- Kiểm tra ngày khóa sổ trước khi thực hiện

#### 3. Xóa cập nhật giá thành
- Nút "Xóa cập nhật" để xóa kết quả tính giá thành đã thực hiện
- Cho phép tính toán lại khi có sai sót

#### 4. Báo cáo 2 cấp (Master-Detail)
- DataGridView phần header (dgvBCPh): Danh sách sản phẩm chi tiết
- DataGridView phần chi tiết (dgvBCCt): Chi tiết giá thành của SPCT được chọn
- Tích hợp Crystal Report để in ấn báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport2DGV` - form báo cáo với 2 DataGridView
- Sử dụng SplitContainer (`scGrid`) để chia màn hình master-detail
- Tích hợp Crystal Report Viewer để xem và in báo cáo
- Kiểm tra ngày khóa sổ (`ngay_ks`) trước mọi thao tác
- Tham số `par1` từ menu: Mã tài khoản dở dang mặc định

### Validation

- Kiểm tra ngày kết thúc phải sau ngày khóa sổ
- Kiểm tra bắt buộc nhập tài khoản dở dang

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tính toán và quản lý giá thành sản phẩm - một chức năng quan trọng trong kế toán quản trị và quản lý sản xuất của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
