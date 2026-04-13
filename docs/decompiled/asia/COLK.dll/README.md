# Báo cáo Phân tích DLL: COLK.dll

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
| Assembly Name | COLK |
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
COLK.dll/
├── COLK.csproj                # Project file
├── app.ico                      # Application icon
├── COLK.dll.licenses          # License file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmCoLk.cs             # Main form - Liên kết
    ├── frmCoLkEdit.cs         # Form chỉnh sửa
    └── frmCOLKFilter.cs        # Form lọc dữ liệu
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoLk` | `frmDMComplexView` | Form danh mục liên kết |
| `frmCoLkEdit` | - | Form chỉnh sửa liên kết |
| `frmCOLKFilter` | - | Form lọc dữ liệu |

---

## Chi tiết Forms

### frmCoLk (Main Form)
- **Kế thừa**: `frmDMComplexView`
- **Chức năng**: Quản lý danh mục liên kết
- **Đặc điểm**:
  - Ẩn các controls không cần thiết
  - `cmdChgCode`: Ẩn
  - `txtValue`: Ẩn
  - `cboFilter`: Ẩn
  - `cmdSearch`: Ẩn
  - `lblTen`: Ẩn
  - `cmdPrint`: Ẩn
  - Điều chỉnh vị trí các nút Add/Del/Edit

### GetData Override
```csharp
protected override void GetData(params object[] @params)
{
    base.GetData(CompanyInformations.CompanyID, 
                 SystemInformations.FinancialYear, 
                 0, "", "", "");
}
```

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Khai báo các bút toán kết chuyển tự động" - Tên chức năng
- "Liên kết" - Tên module

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `lk` | Liên kết |
| `nam` | Năm tài chính |

---

## So sánh với CODD1.dll

| Đặc điểm | COLK.dll | CODD1.dll |
|-----------|----------|-----------|
| Assembly Title | Khai báo các bút toán kết chuyển tự động | Khai báo các bút toán kết chuyển tự động |
| Chức năng | Liên kết | Định mức chi tiết |
| GUID | Giống nhau | Giống nhau |
| GetData | 6 tham số | 4 tham số |

### Phân tích
- Cùng Assembly Title nhưng chức năng khác nhau
- COLK.dll quản lý liên kết (mapping/linking)
- CODD1.dll quản lý định mức chi tiết
- Có thể là 2 module khác nhau trong cùng chức năng kết chuyển

---

## Mục đích sử dụng

**COLK.dll là module quản lý "Liên kết"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Khai báo liên kết dữ liệu
- Thiết lập các liên kết giữa các danh mục
- Cấu hình mapping cho bút toán kết chuyển
- Quản lý quan hệ giữa các đối tượng kế toán

#### 2. Tích hợp kết chuyển
- Hỗ trợ bút toán kết chuyển tự động
- Liên kết dữ liệu giữa các module
- Cung cấp dữ liệu cho quá trình kết chuyển cuối kỳ

### Đặc điểm kỹ thuật

- Form đơn giản với nhiều controls ẩn
- Kế thừa từ frmDMComplexView
- Filter theo công ty và năm tài chính

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo các liên kết dữ liệu - hỗ trợ cho quá trình bút toán kết chuyển tự động trong kế toán.

---

*Ngày phân tích: 2026-03-29*
