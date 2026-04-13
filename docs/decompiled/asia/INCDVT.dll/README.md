# Báo cáo Phân tích DLL: INCDVT.dll

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
| Assembly Name | Nhập số tồn kho đầu kỳ |
| Assembly Title | Nhập số tồn kho đầu kỳ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ced0d8d3-a55f-4181-92b2-8f5f36d765fa |
| ComVisible | false |

---

## Cấu trúc File

```
INCDVT.dll/
├── INCDVT.csproj              # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── INCDVTDAO.cs           # Data access object interface
│   └── MsSqlINCDVTDAO.cs      # SQL Server implementation
├── AsiaERP.UserInterface/
│   ├── frmINCDVT.cs           # Main form class (view)
│   ├── frmINCDVTEdit.cs       # Form nhập liệu/sửa
│   └── frmINCDVTFilter.cs     # Form filter
├── My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── InternalXmlHelper.cs
│   ├── MyComputer.cs
│   └── MySettingsProperty.cs
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
| AsiaERP.DataAccess | Data access layer |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINCDVT` | `frmOBView` | Form xem danh sách tồn kho đầu kỳ |
| `frmINCDVTEdit` | `frmOBEdit` | Form nhập liệu/sửa tồn kho đầu kỳ |
| `frmINCDVTFilter` | `frmOBFilter` | Form filter điều kiện |
| `INCDVTDAO` | Interface | Data access object interface |
| `MsSqlINCDVTDAO` | INCDVTDAO | Implementation cho SQL Server |

---

## Controls chính (frmINCDVT)

| Control | Loại | Mục đích |
|---------|------|----------|
| `btn_SDTK` | Button | Chuyển số dư đầu kỳ vật tư sang tài khoản |
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách |
| `cboFilter` | ComboBox | Filter nhanh |
| `txtValue` | TextBox | Giá trị filter |
| `cmdAdd` | Button | Thêm mới |
| `cmdEdit` | Button | Sửa |
| `cmdDel` | Button | Xóa |
| `cmdClose` | Button | Đóng |

---

## Controls chính (frmINCDVTEdit)

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblYear` | Label | Label năm |
| `txtYear` | AsTextNumeric | Năm tài chính (readonly) |
| `lblMa_vt` | Label | Label mã vật tư |
| `txtMa_vt` | AsTextBox | Nhập mã vật tư (lookup) |
| `lblTen_vt` | Label | Hiển thị tên vật tư |
| `lblMa_Tkvt` | Label | Label TK vật tư |
| `txtTk_vt` | AsTextBox | Nhập TK vật tư (lookup) |
| `lblTen_tkvt` | Label | Hiển thị tên TK |
| `lblMa_kho` | Label | Label mã kho |
| `txtMa_kho` | AsTextBox | Nhập mã kho (lookup) |
| `lblTen_kho` | Label | Hiển thị tên kho |
| `lblMa_lo` | Label | Label mã lô |
| `txtMa_lo` | AsTextBox | Nhập mã lô (lookup) |
| `lblTen_lo` | Label | Hiển thị tên lô |
| `lblMa_nt` | Label | Label mã ngoại tệ |
| `cboMa_Nt` | AsComboBoxNT | Chọn ngoại tệ |
| `lblSo_luong` | Label | Label số lượng |
| `txtSo_luong` | AsTextNumeric | Nhập số lượng |
| `lblTien_nt` | Label | Label tiền NT |
| `txtTien_nt` | AsTextNumeric | Nhập tiền ngoại tệ |
| `lblTien` | Label | Label tiền VND |
| `txtTien_vnd` | AsTextNumeric | Nhập tiền VND |
| `chkKsd` | AsCheckBox | Khóa sử dụng |

---

## Controls chính (frmINCDVTFilter)

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblYear` | Label | Label năm |
| `txtYear` | AsTextNumeric | Năm tài chính (readonly) |
| `lblMa_kho` | Label | Label mã kho |
| `txtMa_kho` | AsTextBox | Lọc theo mã kho |
| `lblTen_kho` | Label | Hiển thị tên kho |
| `Label1` | Label | Label mã vật tư |
| `txtMa_vt` | AsTextBox | Lọc theo mã vật tư |
| `lblTen_vt` | Label | Hiển thị tên vật tư |
| `lblMa_tkvt` | Label | Label TK vật tư |
| `txtMa_tkvt` | AsTextBox | Lọc theo TK vật tư |
| `lblTen_tkvt` | Label | Hiển thị tên TK |

---

## Methods và Business Logic

### frmINCDVT

| Method | Mục đích |
|--------|----------|
| `Login()` | Mở form filter, lấy parameters |
| `GetData()` | Load dữ liệu từ database |
| `Edit()` | Mở form sửa (kiểm tra gia_ton) |
| `Delete()` | Xóa record (kiểm tra gia_ton) |
| `btn_SDTK_Click()` | Chuyển số dư sang tài khoản |
| `frmINCDVT_Shown()` | Close form nếu không login |

### frmINCDVTEdit

| Method | Mục đích |
|--------|----------|
| `ValidData()` | Validate dữ liệu nhập |
| `InitAfterGetData()` | Init sau khi load data |
| `DisableFields()` | Disable fields khi xem |
| `DataBinding()` | Binding data controls |
| `SetToRow()` | Set data vào row |
| `txtMa_vt_AfterCodeValidating()` | Auto-fill TK_VT khi chọn VT |
| `MaskTextBoxAll()` | Format mask cho numeric controls |

### frmINCDVTFilter

| Method | Mục đích |
|--------|----------|
| `ValidData()` | Validate ngày kỳ báo cáo |

---

## Logic xử lý quan trọng

### Login()
```csharp
- Mở frmINCDVTFilter
- Lấy Ma_vt, Ma_kho, Ma_tkvt từ filter
- Set check = true nếu OK
```

### btn_SDTK_Click()
```csharp
- Tạo INCDVTDAO instance
- Gọi ImportCdvtToCdTk(CompanyID, FinancialYear)
- Hiển thị message thành công
- Xử lý exception
```

### Edit()/Delete()
```csharp
- Kiểm tra gia_ton của vật tư
- Nếu gia_ton = "2" (tính giá NTXT): Không cho sửa/xóa
- Hiển thị message 50211
- Nếu không: Gọi base.Edit()/Delete()
```

### txtMa_vt_AfterCodeValidating()
```csharp
- Khi chọn vật tư, auto-fill TK_VT
- Lấy TK_VT từ validated row
- Set vào txtTk_vt
```

---

## Các chuỗi Text đáng chú ý

### Labels

| Text | Ý nghĩa |
|------|---------|
| "Năm" | Label năm tài chính |
| "Mã vật tư" | Label mã vật tư |
| "TK vật tư" | Label tài khoản vật tư |
| "Mã kho" | Label mã kho |
| "Mã lô" | Label mã lô |
| "Mã NT" | Label mã ngoại tệ |
| "Số lượng" | Label số lượng |
| "Tiền NT" | Label tiền ngoại tệ |
| "Tiền VND" | Label tiền VND |

### Messages

| Code | Ý nghĩa |
|------|---------|
| 50015 | Thực hiện thành công |
| 50211 | Không được sửa/xóa (gia_ton=2) |

---

## Mục đích sử dụng

**INCDVT.dll là module "Nhập số tồn kho đầu kỳ vật tư"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý tồn kho đầu kỳ
- Xem danh sách tồn kho đầu kỳ
- Thêm mới, sửa, xóa số liệu tồn kho
- Filter theo kho, vật tư, tài khoản

#### 2. Nhập liệu tồn kho
- Mã vật tư (bắt buộc)
- Tài khoản vật tư (bắt buộc)
- Mã kho (bắt buộc)
- Mã lô (tùy chọn)
- Ngoại tệ (tùy chọn)
- Số lượng (bắt buộc)
- Tiền ngoại tệ (tùy chọn)
- Tiền VND (bắt buộc)

#### 3. Chuyển số dư sang tài khoản
- Button "Chuyển SDTK" để chuyển tồn kho vật tư sang tài khoản
- Sử dụng INCDVTDAO.ImportCdvtToCdTk()
- Áp dụng cho toàn bộ công ty/năm

#### 4. Validation đặc biệt
- Không cho sửa/xóa vật tư có gia_ton = "2" (tính giá NTXT)
- Tránh làm sai lệch số liệu tính giá

### Đặc điểm kỹ thuật

- Kế thừa từ frmOBView/frmOBEdit/frmOBFilter
- Sử dụng DAO pattern cho data access
- AutoLookup cho các trường mã
- DataBinding với DataRow
- Mask formatting cho numeric fields
- BackgroundWorker có thể được sử dụng

---

## Database Fields

### Bảng tồn kho đầu kỳ (INCDVT)

| Field | Kiểu | Mô tả |
|-------|------|-------|
| nam | int | Năm tài chính |
| ma_vt | varchar | Mã vật tư |
| tk_vt | varchar | Tài khoản vật tư |
| ma_kho | varchar | Mã kho |
| ma_lo | varchar | Mã lô |
| ma_nt | varchar | Mã ngoại tệ |
| so_luong | decimal | Số lượng |
| tien_nt | decimal | Tiền ngoại tệ |
| tien | decimal | Tiền VND |

---

## Kết luận

Đây là một module quan trọng trong phân hệ kho của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập và quản lý số liệu tồn kho đầu kỳ - dữ liệu nền tảng cho các tính toán tồn kho trong năm tài chính.

---

*Ngày phân tích: 2026-03-29*
