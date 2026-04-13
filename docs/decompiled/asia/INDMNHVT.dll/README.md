# Báo cáo Phân tích DLL: INDMNHVT.dll

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
| Assembly Name | INDMNHVT |
| Assembly Title | Danh mục nhóm vật tư |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
INDMNHVT.dll/
├── INDMNHVT.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMNHVT.cs           # Main form class (danh mục view)
    └── frmINDMNHVTEdit.cs       # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMNHVT` | `frmDMView` | Form xem danh mục nhóm vật tư (cây phân cấp) |
| `frmINDMNHVTEdit` | `frmDMEdit` | Form nhập liệu/chỉnh sửa nhóm vật tư |

---

## Chi tiết Form frmINDMNHVTEdit

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtMa_NhVt | Ma_NhVt | Mã nhóm vật tư |
| txtTen_NhVt | Ten_NhVt | Tên nhóm vật tư |
| txtNhom_Me | Nhom_Me | Nhóm mẹ (phân cấp) |
| txtCap | cap | Cấp độ trong phân cấp |
| chkCong_Sl | Cong_Sl | Cộng số lượng |
| chkKsd | Ksd | Không sử dụng |

### Tài khoản kế toán mặc định

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtTk_Vt | Tk_Vt | TK vật tư mặc định |
| txtTk_Dt | Tk_Dt | TK doanh thu mặc định |
| txtTk_DtNb | Tk_DtNb | TK DT nội bộ mặc định |
| txtTk_Gv | Tk_Gv | TK giá vốn mặc định |
| txtTk_Tl | Tk_Tl | TK trả lại mặc định |
| txtTk_Ck | Tk_Ck | TK chiết khấu mặc định |

---

## Chi tiết Form frmINDMNHVT

### Tính năng phân cấp

| Thuộc tính | Mô tả |
|------------|-------|
| `rowAdd` | DataRow lưu trữ dòng vừa thêm |
| `nhom_me` | Mã nhóm mẹ hiện tại |

### Phương thức quan trọng

| Method | Mô tả |
|--------|-------|
| `InitOtherAfterLoadData()` | Khởi tạo giá trị mặc định cho TK từ INConfiguration |
| `AddNew()` | Thêm mới nhóm, cập nhật gridview |
| `Edit()` | Chỉnh sửa nhóm |
| `Delete()` | Xóa nhóm (kiểm tra có con không) |
| `UpdateGridview()` | Cập nhật hiển thị cây phân cấp |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã nhóm" - Mã nhóm vật tư
- "Tên nhóm" - Tên nhóm vật tư
- "Nhóm mẹ" - Nhóm cấp trên (phân cấp)
- "Cấp" - Cấp độ trong cây phân cấp
- "Cộng số lượng" - Tùy chọn cộng số lượng

### Tài khoản kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `Tk_Vt` | Tài khoản vật tư |
| `Tk_Dt` | Tài khoản doanh thu |
| `Tk_DtNb` | Tài khoản DT nội bộ |
| `Tk_Gv` | Tài khoản giá vốn |
| `Tk_Tl` | Tài khoản trả lại |
| `Tk_Ck` | Tài khoản chiết khấu |

---

## Mục đích sử dụng

**INDMNHVT.dll là module quản lý danh mục nhóm vật tư** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý phân cấp nhóm vật tư
- Cấu trúc cây phân cấp nhiều cấp
- Nhóm mẹ - nhóm con
- Tự động tính cấp độ (cap)

#### 2. Tài khoản kế toán mặc định
- Thiết lập TK mặc định cho cả nhóm
- Kế thừa khi tạo vật tư mới
- Tích hợp với INConfiguration

#### 3. Tính năng bổ sung
- Cộng số lượng (tổng hợp)
- Kiểm tra trước khi xóa (không cho xóa nếu có nhóm con)
- Định dạng hiển thị cây (bold cho nhóm có con)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Lookup tự động cho nhóm mẹ
- Validation dữ liệu đầu vào
- Xử lý cây phân cấp (tree-like structure)
- Tích hợp INConfiguration cho giá trị mặc định

### Xử lý sự kiện

| Sự kiện | Mô tả |
|---------|-------|
| `txtNhom_Me_AfterCodeValidating` | Cập nhật cấp độ khi chọn nhóm mẹ |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục nhóm vật tư theo cấu trúc phân cấp - chức năng quan trọng trong module Inventory (IN).

---

*Ngày phân tích: 2026-03-29*
