# Báo cáo Phân tích DLL: POTAIN.dll

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
| Assembly Name | POTAIN |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| ComVisible | false |

---

## Cấu trúc File

```
POTAIN.dll/
├── POTAIN.csproj                # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmPOTaIn.cs             # Main form class - Danh mục thuế đầu vào
    └── frmPOTAINEdit.cs         # Edit form class
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
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPOTaIn` | `frmDMComplexView` | Form danh mục quản lý thuế đầu vào (Thuế GTGT mua vào) |
| `frmPOTAINEdit` | - | Form chỉnh sửa thông tin thuế đầu vào |

---

## Mục đích sử dụng

**POTAIN.dll là module quản lý "Thuế đầu vào"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Danh mục thuế đầu vào (TAIN - Thuế GTGT mua vào)
- Quản lý danh sách các khai báo thuế đầu vào
- Theo dõi thuế GTGT của các chứng từ mua hàng
- Phân loại thuế đầu vào theo chứng từ

#### 2. Quản lý dữ liệu
- Mã chứng từ: `ma_ct` mặc định là "TAI"
- Số thứ tự bản ghi: `stt_rec0`
- Validate chỉ cho phép sửa/xóa các bản ghi có `ma_ct = "TAI"`

#### 3. Tính năng form
- Ẩn các control tìm kiếm (txtValue, cboFilter, lblTen, cmdSearch)
- Ẩn chức năng đổi mã (cmdChgCode)
- Sắp xếp lại vị trí các nút chức năng
- Thông báo lỗi khi cố gắng sửa/xóa bản ghi không phải loại TAI

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` - form danh mục phức tạp
- Sử dụng DataTable với DefaultView để quản lý dữ liệu
- Validate dữ liệu trước khi sửa/xóa
- Mã lỗi 50139: Không cho phép sửa
- Mã lỗi 50140: Không cho phép xóa

### Mã chứng từ

**TAI** (Thuế đầu vào / Thu