# Báo cáo Phân tích DLL: CODD1.dll

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
| Assembly Name | CODD1 |
| Assembly Title | Khai báo các bút toán kết chuyển tự động |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | asiasoft Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
CODD1.dll/
├── CODD1.csproj              # Project file
├── app.ico                      # Application icon
├── CODD1.dll.licenses         # License file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmCoDD1.cs            # Main form - Danh mục định mức chi tiết
    ├── frmCoDD1Edit.cs        # Form chỉnh sửa
    └── frmCoDD1Filter.cs      # Form lọc dữ liệu
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoDD1` | `frmDMComplexView` | Form danh mục chính quản lý định mức chi tiết |
| `frmCoDD1Edit` | `frmDMComplexEdit` | Form nhập liệu chỉnh sửa định mức |
| `frmCoDD1Filter` | `frmDMComplexFilter` | Form lọc dữ liệu theo năm/tháng |

---

## Chi tiết Forms

### frmCoDD1 (Main Form)
- **Kế thừa**: `frmDMComplexView`
- **Chức năng**: Quản lý danh mục định mức chi tiết
- **Đặc điểm**:
  - Ẩn các nút `cmdChgCode`, `cmdPrint`
  - Điều chỉnh vị trí các nút Add/Edit/Del
  - Lọc dữ liệu theo năm tài chính và tháng
  - Kiểm tra ngày khóa sổ trước khi hiển thị

### frmCoDD1Edit (Edit Form)
- **Kế thừa**: `frmDMComplexEdit`
- **Controls chính**:
  - `txtMa_Spct`: Mã sản phẩm chi tiết (AutoLookup, AutoValid)
  - `txtTK`: Tài khoản
  - `txtSo_luong`: Số lượng (AsTextNumeric)
  - `txtTien`: Giá trị/Định mức (AsTextNumeric)
  - `lblTen_vt`, `lblTen_tk`: Label hiển thị tên

### frmCoDD1Filter (Filter Form)
- **Kế thừa**: `frmDMComplexFilter`
- **Controls**:
  - `txtNam`: Năm tài chính (AsTextNumeric)
  - `txtThang`: Tháng (AsTextNumeric, Mask="##")
- **Validation**: Kiểm tra tháng hợp lệ (1-12)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Khai báo các bút toán kết chuyển tự động" - Tên chức năng
- "Mã SPCT", "Tên vật tư" - Thông tin sản phẩm
- "TK", "Tên tài khoản" - Thông tin tài khoản kế toán
- "Số lượng", "Giá trị" - Thông tin định mức

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_spct` | Mã sản phẩm chi tiết |
| `tk` | Tài khoản kế toán |
| `so_luong` | Số lượng định mức |
| `tien` | Giá trị/Chi phí định mức |
| `nam` | Năm tài chính |
| `thang` | Tháng áp dụng |

---

## Mục đích sử dụng

**CODD1.dll là module quản lý "Định mức chi tiết"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý định mức chi tiết
- Khai báo định mức chi phí theo sản phẩm chi tiết (SPCT)
- Gán tài khoản kế toán cho từng định mức
- Quản lý số lượng và giá trị định mức

#### 2. Phân loại theo thời gian
- Lọc dữ liệu theo năm tài chính
- Lọc theo tháng (1-12)
- Kiểm tra tính hợp lệ của dữ liệu với ngày khóa sổ

#### 3. Tích hợp với module khác
- Liên kết với danh mục sản phẩm chi tiết (MA_SPCT)
- Liên kết với hệ thống tài khoản kế toán
- Hỗ trợ AutoLookup cho mã SPCT và TK

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Validation dữ liệu đầu vào (mã SPCT, TK, số lượng)
- Hỗ trợ chức năng SD (Sử dụng/Không sử dụng)
- Tích hợp với Framework chung của Asia ERP

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo và quản lý định mức chi tiết - một phần quan trọng trong công tác tính giá thành và quản lý chi phí sản xuất.

---

*Ngày phân tích: 2026-03-29*
