# Báo cáo Phân tích DLL: GLDMKC.dll

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
| Assembly Name | GLDMKC |
| Assembly Title | Khai báo các bút toán kết chuyển tự động |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |
| Assembly Trademark | AsiaSoft |

---

## Cấu trúc File

```
GLDMKC.dll/
├── GLDMKC.csproj                # Project file
├── app.ico                      # Application icon
├── GLDMKC.dll.licenses          # License file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLDMKC.cs             # Main form - Danh mục KC
│   └── frmGLDMKCEdit.cs         # Edit form - Nhập liệu KC
└── Properties/
    └── AssemblyInfo.cs          # Assembly metadata
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLDMKC` | `frmDMComplexView` | Form xem danh mục kết chuyển |
| `frmGLDMKCEdit` | - | Form nhập liệu kết chuyển |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Khai báo các bút toán kết chuyển tự động" - Tên chức năng chính

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `stt` | Số thứ tự |
| `ma_cty` | Mã công ty |
| `par1` | Tham số 1 (loại kết chuyển) |

---

## Mục đích sử dụng

**GLDMKC.dll là module Khai báo các bút toán kết chuyển tự động** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Quản lý danh mục kết chuyển
- Xem danh sách các bút toán kết chuyển tự động
- Thêm, sửa, xóa bút toán kết chuyển
- Sắp xếp theo số thứ tự

#### 2. Cấu hình kết chuyển
- Thiết lập các bút toán kết chuyển cuối kỳ
- Cấu hình tài khoản nguồn và đích
- Thiết lập điều kiện kết chuyển

#### 3. Tham số hóa
- Nhận tham số `par1` để phân loại kết chuyển
- Lọc dữ liệu theo công ty và loại kết chuyển

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` - Form danh mục phức tạp
- Tự động tính số thứ tự lớn nhất (`SttMax`)
- Ẩn chức năng đổi mã
- Sử dụng tham số `par1` để linh hoạt loại kết chuyển

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo và quản lý các bút toán kết chuyển tự động.

---

*Ngày phân tích: 2026-03-29*
