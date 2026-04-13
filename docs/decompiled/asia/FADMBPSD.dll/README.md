# Báo cáo Phân tích DLL: FADMBPSD.dll

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
| Assembly Name | FADMBPSD |
| Assembly Title | Danh mục bộ phận sử dụng |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 4c4bdcd5-4a95-4799-88dd-22c0e8b5acca |
| ComVisible | false |

---

## Cấu trúc File

```
FADMBPSD.dll/
├── FADMBPSD.csproj                     # Project file
├── app.ico                             # Application icon
├── Properties/
│   └── AssemblyInfo.cs                 # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFADMBPSD.cs                  # Main view form
│   └── frmFADMBPSDEdit.cs              # Edit form
├── AsiaErp.UserInterface.My/
│   ├── MyComputer.cs                   # Computer info
│   ├── MyApplication.cs                # Application info
│   ├── MyProject.cs                    # Project info
│   ├── MySettings.cs                   # Settings manager
│   ├── MySettingsProperty.cs           # Settings property
│   └── InternalXmlHelper.cs            # XML helper
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs                    # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADMBPSD` | `frmDMView` | Form danh sách bộ phận sử dụng |
| `frmFADMBPSDEdit` | `frmDMEdit` | Form thêm/sửa bộ phận sử dụng |
| `Resources` | - | Resource manager |

---

## UI Controls - frmFADMBPSD (View)

| Control | Type | Mục đích |
|---------|------|----------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách |
| `cmdAdd` | Button | Thêm mới |
| `cmdEdit` | Button | Sửa |
| `cmdDel` | Button | Xóa |
| `cmdChgCode` | Button | Đổi mã |
| `cmdSearch` | Button | Tìm kiếm |
| `cmdPrint` | Button | In |
| `cmdClose` | Button | Đóng |
| `cboFilter` | ComboBox | Lọc dữ liệu |
| `txtValue` | TextBox | Giá trị tìm kiếm |
| `lblTen` | Label | Nhãn "Tên" |

---

## UI Controls - frmFADMBPSDEdit (Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_Bp` | TextBox | Mã bộ phận |
| `txtTen_Bp` | TextBox | Tên bộ phận |
| `lblMa_Bp` | Label | Nhãn "Mã bộ phận" |
| `lblTen_Bp` | Label | Nhãn "Tên bộ phận" |
| `chkKsd` | AsCheckBox | Checkbox "Không sử dụng" |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |
| `gbLine` | GroupBox | Container |

---

## Business Logic

### Data Binding

| Control | Field | Type |
|---------|-------|------|
| txtMa_Bp | ma_bpsd | String |
| txtTen_Bp | ten_bpsd | String |
| chkKsd | ksd | Boolean (checked) |

### Validation

- `ChkEmtyTextBox(txtMa_Bp)`: Kiểm tra mã bộ phận không được rỗng
- `ChkEmtyTextBox(txtTen_Bp)`: Kiểm tra tên bộ phận không được rỗng

### Xử lý chính

#### frmFADMBPSD (View)
1. Hiển thị danh sách bộ phận sử dụng trong DataGridView
2. Cho phép thêm, sửa, xóa, đổi mã, tìm kiếm, in
3. Tự động điều chỉnh kích thước grid theo form

#### frmFADMBPSDEdit (Edit)
1. `InitBeforeGetData()`: Thiết lập MaxLength cho mã theo `MyDictInfo.code_length`
2. `DataBinding()`: Bind controls với DataSource
3. `DisableFields()`: Vô hiệu hóa trường mã khi sửa
4. `ValidData()`: Validate dữ liệu trước khi lưu
5. `InsertToDB()`: Thêm mới vào database

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã bộ phận" - Mã định danh bộ phận
- "Tên bộ phận" - Tên mô tả bộ phận
- "Tên" - Nhãn tìm kiếm

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ten_bpsd` | Tên bộ phận sử dụng |
| `ksd` | Không sử dụng (trạng thái) |

---

## Mục đích sử dụng

**FADMBPSD.dll là module quản lý danh mục bộ phận sử dụng** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý danh mục bộ phận sử dụng
- Xem danh sách bộ phận sử dụng
- Thêm mới bộ phận sử dụng
- Sửa thông tin bộ phận sử dụng
- Xóa bộ phận sử dụng
- Đổi mã bộ phận sử dụng
- Tìm kiếm bộ phận sử dụng
- In danh sách bộ phận sử dụng

#### 2. Thông tin quản lý
- Mã bộ phận: Định danh duy nhất
- Tên bộ phận: Mô tả bộ phận
- Trạng thái sử dụng: Kích hoạt/Không sử dụng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` - forms danh mục chuẩn của Asia ERP
- Sử dụng DataBinding để đồng bộ dữ liệu
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework

### Luồng dữ liệu

```
frmFADMBPSD (View) → Chọn thao tác → frmFADMBPSDEdit (Edit) → Validate → Save → Refresh
```

---

## Kết luận

Đây là module danh mục cơ bản phục vụ cho việc quản lý bộ phận sử dụng tài sản trong hệ thống kế toán tài sản cố định. Module cung cấp đầy đủ chức năng CRUD và tích hợp với các module khác trong hệ thống ERP.

---

*Ngày phân tích: 2026-03-29*
