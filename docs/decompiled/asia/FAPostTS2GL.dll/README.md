# Báo cáo Phân tích DLL: FAPostTS2GL.dll

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
| Assembly Name | FAPostTS2GL |
| Assembly Title | Phân bổ tài sản cố định |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
FAPostTS2GL.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmFAPostTS2GL.cs            # Main form - Post tài sản sang GL
    └── frmFAPostTS2GLFilter.cs      # Filter form - Chọn kỳ post
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| AsiaErp.Framework | ERP Framework Core |
| AsiaErp.DataAccess | ERP Framework DataAccess |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.DataAccess`
- `System`, `System.Collections`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAPostTS2GL` | `frmDMView` | Form post khấu hao tài sản sang GL |
| `frmFAPostTS2GLFilter` | `frmDMFilter` | Form chọn kỳ post |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phân bổ tài sản cố định" - Tiêu đề form
- "&Phân bổ" - Button thực hiện post
- "Tháng" - Chọn tháng post
- "Năm" - Hiển thị năm tài chính

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `thang` | Tháng post |
| `tk_cp` | Tài khoản chi phí |
| `tk_kh` | Tài khoản khấu hao |
| `khau_hao` | Giá trị khấu hao |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |

---

## Mục đích sử dụng

**FAPostTS2GL.dll là module Post khấu hao tài sản cố định sang General Ledger (GL)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Chọn kỳ post (Filter)
- Form `frmFAPostTS2GLFilter` hiển thị trước
- Chọn tháng cần post (qua cboKyBc)
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ
- Lưu tháng đã chọn vào biến public

#### 2. Xem danh sách khấu hao
- Hiển thị danh sách các tài sản cần post khấu hao
- GridView hiển thị: TK chi phí, TK khấu hao, giá trị khấu hao, mã phí, mã SPCT
- Dữ liệu lấy từ `MyController.GetData()`

#### 3. Post sang GL
- Button "Phân bổ" thực hiện post
- Xóa dữ liệu post cũ qua stored procedure `asFADelPostGlCt`
- Insert dữ liệu mới qua stored procedure `asFAPost2GlCt`
- Tham số: mã công ty, par1 (loại), năm, tháng

#### 4. Chi tiết post
```csharp
// Xóa dữ liệu cũ
asFADelPostGlCt(ma_cty, par1, nam, thang)

// Insert dữ liệu mới cho mỗi dòng
asFAPost2GlCt(ma_cty, par1, ngay, tk_cp, tk_kh, khau_hao, ma_phi, ma_spct, user_name)
```

### Đặc điểm kỹ thuật

- Kế thừa `frmDMView` - form xem danh mục chuẩn
- Sử dụng `frmDMFilter` để chọn kỳ
- Thực thi stored procedure qua `Commons.ExecuteStoredProcedure()`
- Cursor đổi sang WaitCursor khi đang xử lý
- Tự động đóng form nếu không chọn kỳ (check=false)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc post khấu hao tài sản cố định sang sổ cái (GL) sau khi đã tính khấu hao.

---

*Ngày phân tích: 2026-03-29*
