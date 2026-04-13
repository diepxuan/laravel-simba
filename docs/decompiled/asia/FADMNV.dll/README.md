# Báo cáo Phân tích DLL: FADMNV.dll

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
| Assembly Name | FADMNV |
| Assembly Title | Danh mục nguồn vốn |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp 9.1 |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | cbe2bd86-4f28-4248-aa92-0577557c3ec0 |
| ComVisible | false |

---

## Cấu trúc File

```
FADMNV.dll/
├── FADMNV.csproj                       # Project file
├── app.ico                             # Application icon
├── Properties/
│   └── AssemblyInfo.cs                 # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFADMNV.cs                    # Main view form
│   └── frmFADMNVEdit.cs                # Edit form
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
| `frmFADMNV` | `frmDMView` | Form danh sách nguồn vốn |
| `frmFADMNVEdit` | `frmDMEdit` | Form thêm/sửa nguồn vốn |
| `Resources` | - | Resource manager |

---

## UI Controls - frmFADMNV (View)

| Control | Type | Mục đích | Visible |
|---------|------|----------|---------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách | Yes |
| `cmdAdd` | Button | Thêm mới | **No** |
| `cmdEdit` | Button | Sửa | Yes |
| `cmdDel` | Button | Xóa | **No** |
| `cmdChgCode` | Button | Đổi mã | **No** |
| `cmdSearch` | Button | Tìm kiếm | Yes |
| `cmdPrint` | Button | In | Yes |
| `cmdClose` | Button | Đóng | Yes |
| `cboFilter` | ComboBox | Lọc dữ liệu | Yes |
| `txtValue` | TextBox | Giá trị tìm kiếm | Yes |
| `lblTen` | Label | Nhãn "Tên" | Yes |

---

## UI Controls - frmFADMNVEdit (Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_nv` | TextBox | Mã nguồn vốn |
| `txtTen_nv` | TextBox | Tên nguồn vốn |
| `lblMA_NV` | Label | Nhãn "Mã nguồn vốn" |
| `lblTen_nv` | Label | Nhãn "Tên nguồn vốn" |
| `chkKsd` | AsCheckBox | Checkbox "Không sử dụng" |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |
| `gbLine` | GroupBox | Container |

---

## Business Logic

### Data Binding

| Control | Field | Type |
|---------|-------|------|
| txtMa_nv | ma_nv | String |
| txtTen_nv | ten_nv | String |
| chkKsd | ksd | Boolean (checked) |

### Validation

- `ChkEmtyTextBox(txtMa_nv)`: Kiểm tra mã nguồn vốn không được rỗng
- `ChkEmtyTextBox(txtTen_nv)`: Kiểm tra tên nguồn vốn không được rỗng

### Xử lý chính

#### frmFADMNV (View)
1. Hiển thị danh sách nguồn vốn trong DataGridView
2. **Hạn chế chức năng**: Ẩn các nút Add, Delete, ChangeCode
3. Chỉ cho phép Edit, Search, Print
4. Tự động điều chỉnh kích thước grid theo form

#### frmFADMNVEdit (Edit)
1. `InitBeforeGetData()`: Thiết lập MaxLength cho mã theo `MyDictInfo.code_length`
2. `DataBinding()`: Bind controls với DataSource
3. `DisableFields()`: Vô hiệu hóa trường mã khi sửa (Enabled = false)
4. `ValidData()`: Validate dữ liệu trước khi lưu
5. `InsertToDB()`: Thêm mới vào database

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã nguồn vốn" - Mã định danh nguồn vốn
- "Tên nguồn vốn" - Tên mô tả nguồn vốn
- "Tên" - Nhãn tìm kiếm

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nv` | Mã nguồn vốn |
| `ten_nv` | Tên nguồn vốn |
| `ksd` | Không sử dụng (trạng thái) |

---

## Mục đích sử dụng

**FADMNV.dll là module quản lý danh mục nguồn vốn** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý danh mục nguồn vốn
- Xem danh sách nguồn vốn
- **Sửa** thông tin nguồn vốn (chức năng chính)
- Tìm kiếm nguồn vốn
- In danh sách nguồn vốn

#### 2. Hạn chế chức năng
Module này có đặc điểm **hạn chế các thao tác thêm/xóa/đổi mã**:
- `cmdAdd.Visible = false` - Không cho phép thêm mới
- `cmdDel.Visible = false` - Không cho phép xóa
- `cmdChgCode.Visible = false` - Không cho phép đổi mã

Điều này cho thấy danh mục nguồn vốn là danh mục **hệ thống** hoặc **cố định**, chỉ cho phép chỉnh sửa thông tin mô tả.

#### 3. Thông tin quản lý
- Mã nguồn vốn: Định danh duy nhất (không đổi)
- Tên nguồn vốn: Mô tả nguồn vốn (có thể sửa)
- Trạng thái sử dụng: Kích hoạt/Không sử dụng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` - forms danh mục chuẩn của Asia ERP
- Sử dụng DataBinding để đồng bộ dữ liệu
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework
- Form View có kích thước: 768x429
- Form Edit có kích thước: 395x141

### Luồng dữ liệu

```
frmFADMNV (View - hạn chế) → Chọn Edit → frmFADMNVEdit → Validate → Save → Refresh
```

---

## Kết luận

Đây là module danh mục đặc biệt phục vụ cho việc quản lý nguồn vốn trong hệ thống kế toán tài sản cố định. Khác với các danh mục thông thường, module này **hạn chế các thao tác thêm/xóa/đổi mã**, chỉ cho phép chỉnh sửa thông tin. Điều này phản ánh tính chất quan trọng và ổn định của danh mục nguồn vốn trong hệ thống kế toán.

---

*Ngày phân tích: 2026-03-29*
