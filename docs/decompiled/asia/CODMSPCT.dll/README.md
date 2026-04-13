# Báo cáo Phân tích DLL: CODMSPCT.dll

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
| Assembly Name | CODMSPCT |
| Assembly Title | Danh mục công trình |
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
CODMSPCT.dll/
├── CODMSPCT.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmCODMSPCT.cs          # Main form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCODMSPCT` | `frmDMView` | Form danh mục sản phẩm công trình |

---

## Chi tiết Forms

### frmCODMSPCT (Main Form)
- **Kế thừa**: `frmDMView`
- **Chức năng**: Quản lý danh mục sản phẩm công trình
- **Đặc điểm**:
  - Kế thừa từ form danh mục chuẩn
  - Hỗ trợ chế độ xem chỉ đọc (par1 = "1")
  - Xử lý phím tắt (F4, F3, F8) cho menu 16.90.02

### GetData Override
```csharp
protected override void GetData(params object[] @params)
{
    base.GetData(@params);
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add("");
    arrayList.Add("0");
    arrayList.Add(base.MyMenuInfo.par1);
    base.SourceTable = base.MyController.GetData(arrayList.ToArray());
    if (Operators.CompareString(base.MyMenuInfo.par1, "1", false) == 0)
    {
        // Chế độ chỉ xem - ẩn các nút thao tác
        ((Component)(object)cmdAdd).Dispose();
        ((Component)(object)cmdEdit).Dispose();
        ((Component)(object)cmdDel).Dispose();
        ((Component)(object)cmdChgCode).Dispose();
        ((Form)this).Text = base.MyMenuInfo.bar;
    }
}
```

### ProcessCmdKey Override
```csharp
protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
    // Xử lý F4, F3, F8 cho menu 16.90.02
    if (((int)keyData == 115 || (int)keyData == 114 || (int)keyData == 119) 
        && Operators.CompareString(base.MyMenuInfo.menuid, "16.90.02", false) == 0)
    {
        // Logic xử lý phím tắt
    }
}
```

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Danh mục công trình" - Tên chức năng

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| SPCT | Sản phẩm công trình |
| `par1` | Tham số 1 ("1" = chế độ chỉ xem) |
| `menuid` | Mã menu (16.90.02) |

---

## Mục đích sử dụng

**CODMSPCT.dll là module quản lý "Danh mục sản phẩm công trình"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý sản phẩm công trình
- Khai báo danh mục các sản phẩm/công trình
- Phân loại theo nhóm (liên kết CODMNHSPCT)
- Quản lý thông tin cơ bản của sản phẩm

#### 2. Chế độ xem linh hoạt
- Chế độ quản lý đầy đủ (thêm/sửa/xóa)
- Chế độ chỉ xem (par1 = "1") - dùng cho báo cáo/lookup
- Hỗ trợ phím tắt cho tra cứu nhanh

#### 3. Tích hợp module giá thành
- Cung cấp dữ liệu cho tính giá thành
- Liên kết với định mức BOM (CODMBOM)
- Hỗ trợ phân bổ chi phí theo SPCT

### Đặc điểm kỹ thuật

- Form kế thừa từ frmDMView
- Hỗ trợ chế độ chỉ xem qua tham số
- Xử lý phím tắt (F3, F4, F8)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục sản phẩm công trình - đối tượng tính giá thành chính trong module kế toán giá thành.

---

*Ngày phân tích: 2026-03-29*
