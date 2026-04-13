# Báo cáo Phân tích DLL: GLRptTMBCTC.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | Báo cáo tồn kho cuối kỳ |
| Assembly Title | Báo cáo tồn kho cuối kỳ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptTMBCTC.dll/
├── GLRptTMBCTC.csproj         # Project file
├── app.ico                    # Application icon
├── frmDialog.cs               # Form dialog xác nhận
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── COPBDAO.cs             # Data access object interface
│   └── MsSqlCOPBDAO.cs        # SQL Server implementation
├── AsiaErp.UserInterface/
│   ├── frmGLRptTMBCTC.cs      # Main form class
│   └── frmDMChiTieu.cs        # Form danh mục chỉ tiêu
├── My/
│   ├── InternalXmlHelper.cs
│   ├── MySettings.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettingsProperty.cs
│   └── MyApplication.cs
└── My.Resources/
    └── Resources.cs           # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System, System.Data, System.Drawing, System.Windows.Forms | .NET Framework cơ bản |
| Microsoft.VisualBasic | Visual Basic runtime support |
| AsiaErp.Framework | Framework chung của Asia ERP |
| AsiaErp.DataAccess | Data access layer |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptTMBCTC` | `frmReport` | Form báo cáo tài chính TMB (Tồn Material Balance) |
| `frmDMChiTieu` | `Form` | Form khai báo chỉ tiêu báo cáo |
| `frmDialog` | `Form` | Form dialog xác nhận tính lại |
| `COPBDAO` | Interface | Data access object cho báo cáo COPB |
| `MsSqlCOPBDAO` | COPBDAO | Implementation cho SQL Server |

---

## Controls chính

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1` | AsMaskedTextBox | Ngày bắt đầu |
| `txtNgay2` | AsMaskedTextBox | Ngày kết thúc |
| `cboFilter` | ComboBox | Filter trên grid |
| `btnTinh_lai` | Button | Tính lại số liệu |
| `cmdDMCT` | Button | Khai báo chỉ tiêu |
| `cmdLuu` | Button | Lưu số liệu vào database |
| `txtGhi_chu` | TextBox | Ghi chú cho báo cáo |
| `splMain` | SplitContainer | Split container cho grid và ghi chú |
| `dgvBC` | AsDataGridView | Grid hiển thị báo cáo |

---

## Methods và Business Logic

### Methods chính

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo datasource, grid |
| `LoadData()` | Load dữ liệu báo cáo |
| `FormatGridView()` | Format grid, load ghi chú |
| `ViewCrystalByConnection()` | Xem báo cáo Crystal |
| `cboMauBC_SelectedIndexChanged()` | Event khi đổi mẫu báo cáo |
| `cmdDMCT_Click()` | Mở form khai báo chỉ tiêu |
| `cmdLuu_Click()` | Lưu số liệu vào database |
| `btnTinh_lai_Click()` | Tính lại số liệu báo cáo |

### Logic xử lý

#### LoadData()
```csharp
- Tạo ArrayList với parameters: CompanyID, Qd_cdkt, Ngay1, Ngay2
- Gọi stored procedure để lấy dữ liệu
- Hỗ trợ 2 chế độ: Crystal Report hoặc Grid
- Xử lý exception và hiển thị lỗi
```

#### cmdLuu_Click()
```csharp
- Kiểm tra điều kiện lưu (có datasource, tab Grid, sTabName != "X")
- Xác nhận trước khi lưu
- Xóa dữ liệu cũ (Delete_BCTCTM)
- Duyệt từng row trong grid và Insert_BCTCTM
- Xử lý exception
```

#### btnTinh_lai_Click()
```csharp
- Mở frmDialog để chọn chế độ tính
- Action 0: Tính lại tất cả mẫu báo cáo
- Action 1: Tính lại mẫu hiện tại
- Action 2: Hủy
- Gọi Cal_BCTCTM() để tính toán
- Hiển thị cursor chờ trong quá trình tính
```

---

## Các chuỗi Text đáng chú ý

### Button labels

| Text | Ý nghĩa |
|------|---------|
| "Khai báo &CT" | Mở form khai báo chỉ tiêu |
| "&Lưu số liệu" | Lưu số liệu vào database |
| "Tính &Lại" | Tính lại số liệu báo cáo |

### Labels

| Text | Ý nghĩa |
|------|---------|
| "Báo cáo" | Label cho cboMau_bc |
| "Kỳ BC" | Label cho cboKyBc |

---

## Mục đích sử dụng

**GLRptTMBCTC.dll là module "Báo cáo tài chính TMB (Tồn Material Balance)"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tồn kho cuối kỳ
- Hiển thị số liệu tồn kho theo kỳ báo cáo
- Hỗ trợ nhiều mẫu báo cáo khác nhau
- Có thể xem trên grid hoặc Crystal Report

#### 2. Tính toán số liệu
- Tính lại số liệu báo cáo (btnTinh_lai)
- Hỗ trợ tính 1 mẫu hoặc tất cả mẫu
- Sử dụng stored procedure Cal_BCTCTM

#### 3. Lưu số liệu
- Lưu số liệu đã tính vào database (cmdLuu)
- Sử dụng COPBDAO.Insert_BCTCTM
- Có xác nhận trước khi lưu

#### 4. Khai báo chỉ tiêu
- Mở form frmDMChiTieu để khai báo chỉ tiêu
- Áp dụng cho mẫu báo cáo hiện tại

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn
- Sử dụng SplitContainer để chia grid và phần ghi chú
- Hỗ trợ 2 chế độ hiển thị: Grid và Crystal Report
- Data access qua DAO pattern (COPBDAO)
- Background processing với cursor chờ
- Xử lý exception chi tiết

---

## Database Operations

### Methods trong COPBDAO

| Method | Mục đích |
|--------|----------|
| `Delete_BCTCTM()` | Xóa dữ liệu báo cáo cũ |
| `Insert_BCTCTM()` | Insert dữ liệu báo cáo mới |
| `Cal_BCTCTM()` | Tính toán số liệu báo cáo |

---

## Kết luận

Đây là một module báo cáo tài chính quan trọng trong hệ thống ERP Asia Enterprise, phục vụ cho việc xem, tính toán và lưu trữ số liệu tồn kho cuối kỳ theo các mẫu báo cáo được cấu hình sẵn.

---

*Ngày phân tích: 2026-03-29*
