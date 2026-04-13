# Báo cáo Phân tích DLL: COGDBGT.dll

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
| Assembly Name | COGDBGT |
| Assembly Title | Sổ cái |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
COGDBGT.dll/
├── COGDBGT.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmCOGDBGT.cs          # Main form - Giá định biên giá thành
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
- `System`, `System.Collections`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCOGDBGT` | `frmReport` | Form báo cáo Giá định biên giá thành |

---

## Chi tiết Forms

### frmCOGDBGT (Report Form)
- **Kế thừa**: `frmReport`
- **Chức năng**: Báo cáo Giá định biên giá thành
- **Controls chính**:
  - `txtTk`: Mã tài khoản (AsTextBox)
  - `lblTen_Tk`: Tên tài khoản (Label)
  - `lblTk`: Nhãn "Tài khoản" (Label)
  - `Label1`: Nhãn phụ (Label)
  - `txtNam`: Năm báo cáo (AsTextNumeric)
  - `txtThang1`: Tháng bắt đầu (AsTextNumeric)
  - `txtThang2`: Tháng kết thúc (AsTextNumeric)
- **Thuộc tính**:
  - `Ten_tk`: Biến lưu tên tài khoản

### InitializeComponent
```csharp
private void InitializeComponent()
{
    // Controls: txtTk, lblTen_Tk, lblTk, Label1
    // txtThang1, txtThang2, txtNam
    // TabControl với tabFilter
}
```

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Sổ cái" - Tên chức năng chung
- "Giá định biên giá thành" - Tên báo cáo cụ thể
- "Tài khoản", "Tên tài khoản"
- "Tháng", "Năm"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản kế toán |
| `nam` | Năm báo cáo |
| `thang1` | Tháng bắt đầu |
| `thang2` | Tháng kết thúc |
| GDBGT | Giá định biên giá thành |

---

## Mục đích sử dụng

**COGDBGT.dll là module báo cáo "Giá định biên giá thành"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Giá định biên giá thành
- Theo dõi giá định biên theo tài khoản chi phí
- Phân tích biến động giá thành theo thời gian
- Đối chiếu giá định biên với giá thực tế

#### 2. Tham số báo cáo
- Chọn tài khoản chi phí cần phân tích
- Lọc theo khoảng thời gian (tháng/năm)
- Xuất báo cáo theo định dạng chuẩn

#### 3.