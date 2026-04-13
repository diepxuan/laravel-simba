# Báo cáo Phân tích DLL: FAPostCC2GL.dll

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
| Assembly Name | FAPostCC2GL |
| Assembly Title | Phân bổ công cụ dụng cụ |
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
FAPostCC2GL.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFAPostCC2GL.cs            # Form post công cụ sang GL
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
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAPostCC2GL` | `frmCalc` | Form post phân bổ công cụ sang GL |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phân bổ công cụ dụng cụ" - Tiêu đề form
- "Tháng" - Chọn kỳ phân bổ
- "Năm" - Hiển thị năm tài chính

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `thang` | Tháng phân bổ |
| `par1` | Tham số loại (từ MyMenuInfo) |

---

## Mục đích sử dụng

**FAPostCC2GL.dll là module Post phân bổ công cụ dụng cụ sang General Ledger (GL)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Post phân bổ công cụ sang GL
- Chọn tháng cần post (qua cboKyBc)
- Hiển thị năm tài chính (readonly)
- Thực hiện post phân bổ cho các công cụ đến kỳ

#### 2. Tham số tính toán
- `CompanyInformations.CompanyID` - Mã công ty
- `txtNam.Text` - Năm tài chính
- `cboKyBc.Text` - Tháng phân bổ
- `MyMenuInfo.par1` - Tham số loại

#### 3. Validation
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ (`ngay_ks`)
- Không cho post cho kỳ đã khóa sổ

#### 4. Thực thi
- Thực thi qua `MyController.Execute()` với tham số mảng
- Hiển thị thông báo thành công/thất bại
- Đóng form sau khi thực hiện

### Đặc điểm kỹ thuật

- Kế thừa `frmCalc` - form tính toán chuẩn
- Sử dụng `AsComboBox` cho chọn kỳ báo cáo
- Sử dụng `AsTextNumeric` cho hiển thị năm (readonly)
- Khởi tạo kỳ báo cáo qua `InitKyBaoCao()`
- Lưu tháng đã chọn vào biến public `thang1`

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc post phân bổ công cụ dụng cụ sang sổ cái (GL) - tương tự như post khấu hao tài sản nhưng áp dụng cho công cụ.

---

*Ngày phân tích: 2026-03-29*
