# Báo cáo Phân tích DLL: INDMNHVAT.dll

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
| Assembly Name | Danh mục nhóm hàng VAT |
| Assembly Title | Danh mục nhóm hàng VAT |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
INDMNHVAT.dll/
├── INDMNHVAT.csproj           # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmINDMNHVAT.cs        # Form danh sách (view)
│   └── frmINDMNHVATEdit.cs    # Form nhập liệu/sửa
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs           # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System, System.Drawing, System.Windows.Forms | .NET Framework cơ bản |
| Microsoft.VisualBasic | Visual Basic runtime support |
| AsiaErp.Framework | Framework chung của Asia ERP |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMNHVAT` | `frmDMView` | Form xem danh sách nhóm VAT |
| `frmINDMNHVATEdit` | `frmDMEdit` | Form nhập liệu/sửa nhóm VAT |
| `Resources` | - | Resource manager cho localization |

---

## Controls chính (frmINDMNHVAT)

| Control | Loại | Mục đích |
|---------|------|----------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách |
| `cboFilter` | ComboBox | Filter nhanh |
| `txtValue` | TextBox | Giá trị filter |
| `lblTen` | Label | Label tên (ẩn) |
| `cmdAdd` | Button | Thêm mới |
| `cmdEdit` | Button | Sửa |
| `cmdDel` | Button | Xóa |
| `cmdSearch` | Button | Tìm kiếm |
| `cmdChgCode` | Button | Đổi mã |
| `cmdPrint` | Button | In |
| `cmdClose` | Button | Đóng |

---

## Controls chính (frmINDMNHVATEdit)

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblMa_NhVat` | Label | Label mã nhóm VAT |
| `txtMa_NhVat` | TextBox | Nhập mã nhóm VAT |
| `lblTen_NhVat` | Label | Label tên nhóm VAT |
| `txtTen_NhVat` | TextBox | Nhập tên nhóm VAT |
| `chkKsd` | AsCheckBox | Khóa sử dụng |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

---

## Methods và Business Logic

### frmINDMNHVAT

| Method | Mục đích |
|--------|----------|
| Constructor(menuid) | Khởi tạo form với menu ID |

### frmINDMNHVATEdit

| Method | Mục đích |
|--------|----------|
| `InitBeforeGetData()` | Init trước khi load data |
| `DisableFields()` | Disable fields khi xem |
| `DataBinding()` | Binding data controls |
| `ValidData()` | Validate dữ liệu nhập |
| `InsertToDB()` | Insert vào database |

---

## Logic xử lý

### InitBeforeGetData()
```csharp
- Set MaxLength cho txtMa_NhVat = code_length từ dictionary
- Focus vào txtMa_NhVat
```

### DisableFields()
```csharp
- Disable txtMa_NhVat (không cho sửa mã)
- Focus vào txtTen_NhVat
- Gọi base.DisableFields()
```

### DataBinding()
```csharp
- Binding txtMa_NhVat với field "Ma_NhVat"
- Binding txtTen_NhVat với field "Ten_NhVat"
- Binding chkKsd với field "Ksd" (property "Checked")
```

### ValidData()
```csharp
- Kiểm tra txtMa_NhVat không rỗng
- Kiểm tra txtTen_NhVat không rỗng
- Gọi base.ValidData()
- Trả về true nếu tất cả hợp lệ
```

### InsertToDB()
```csharp
- Gọi base.InsertToDB()
- Nếu thất bại: Focus vào txtMa_NhVat
- Trả về kết quả
```

---

## Các chuỗi Text đáng chú ý

### Labels

| Text | Ý nghĩa |
|------|---------|
| "Mã nhóm VAT" | Label cho mã nhóm |
| "Tên nhóm VAT" | Label cho tên nhóm |

### Form titles

| Text | Ý nghĩa |
|------|---------|
| "Danh mục nhóm hàng VAT" | Title form danh sách |
| "frmINDMNHVATEdit" | Title form nhập liệu |

---

## Mục đích sử dụng

**INDMNHVAT.dll là module "Danh mục nhóm hàng VAT"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục nhóm VAT
- Xem danh sách các nhóm hàng VAT
- Thêm mới, sửa, xóa nhóm VAT
- Tìm kiếm và filter danh sách

#### 2. Thông tin nhóm VAT
- **Mã nhóm VAT**: Mã định danh duy nhất
- **Tên nhóm VAT**: Mô tả nhóm hàng
- **Khóa sử dụng (Ksd)**: Flag để vô hiệu hóa nhóm không dùng

#### 3. Operations chuẩn
- **Add**: Thêm nhóm VAT mới
- **Edit**: Sửa thông tin nhóm (không được sửa mã)
- **Delete**: Xóa nhóm VAT
- **Search**: Tìm kiếm theo mã/tên
- **Change Code**: Đổi mã nhóm
- **Print**: In danh sách

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView`/`frmDMEdit` - form danh mục chuẩn
- Form đơn giản với 2 fields chính (Mã, Tên)
- Auto-increment hoặc manual code tùy cấu hình
- Support "Khóa sử dụng" để vô hiệu hóa record
- DataBinding tự động với DataRow
- Validation cơ bản: không để trống mã và tên

---

## Database Schema

### Bảng nhóm VAT (INDMNHVAT)

| Field | Kiểu | Mô tả |
|-------|------|-------|
| Ma_NhVat | varchar | Mã nhóm VAT (PK) |
| Ten_NhVat | nvarchar | Tên nhóm VAT |
| Ksd | bit | Khóa sử dụng (0/1) |

---

## Quy trình sử dụng

### Thêm mới
1. Click "Thêm" hoặc nhấn Insert
2. Nhập mã nhóm VAT
3. Nhập tên nhóm VAT
4. Tick "Khóa sử dụng" nếu cần
5. Click "Lưu" hoặc nhấn F8

### Sửa
1. Chọn record cần sửa
2. Click "Sửa" hoặc nhấn F2
3. Sửa tên nhóm (không sửa được mã)
4. Click "Lưu" hoặc nhấn F8

### Xóa
1. Chọn record cần xóa
2. Click "Xóa" hoặc nhấn Delete
3. Xác nhận xóa

---

## Kết luận

Đây là một module danh mục cơ bản trong hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục nhóm hàng VAT - thông tin quan trọng cho việc tính thuế và báo cáo thuế GTGT.

---

*Ngày phân tích: 2026-03-29*
