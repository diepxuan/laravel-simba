# Báo cáo Phân tích DLL: CODMNHSPCT.dll

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
| Assembly Name | CODMNHSPCT |
| Assembly Title | Danh mục nhóm sản phẩm công trình |
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
CODMNHSPCT.dll/
├── CODMNHSPCT.csproj          # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmCODMNHSPCT.cs       # Main form - Danh mục nhóm SPCT
    └── frmCODMNHSPCTEdit.cs   # Form chỉnh sửa
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
- `System`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCODMNHSPCT` | `frmDMView` | Form danh mục nhóm sản phẩm công trình |
| `frmCODMNHSPCTEdit` | - | Form chỉnh sửa nhóm SPCT |

---

## Chi tiết Forms

### frmCODMNHSPCT (Main Form)
- **Kế thừa**: `frmDMView`
- **Chức năng**: Quản lý danh mục nhóm sản phẩm công trình
- **Đặc điểm**:
  - Kế thừa từ form danh mục chuẩn
  - Tự động khởi tạo cấp mặc định = 1

### frmCODMNHSPCTEdit (Edit Form)
- **Chức năng**: Form nhập liệu chỉnh sửa nhóm SPCT

---

## Business Logic

### InitOtherAfterLoadData
```csharp
protected override void InitOtherAfterLoadData()
{
    base.InitOtherAfterLoadData();
    INConfiguration iNConfiguration = AsiaErp.Framework.Environment.GetINConfiguration();
    base.SourceTable.Columns["cap"].DefaultValue = 1;
}
```

### AddNew Override
```csharp
protected override void AddNew()
{
    base.AddNew();
    bsDanhMuc.Sort = "stt_nhom";
}
```

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Danh mục nhóm sản phẩm công trình" - Tên chức năng

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `cap` | Cấp độ nhóm |
| `stt_nhom` | Số thứ tự nhóm |
| SPCT | Sản phẩm công trình |

---

## Mục đích sử dụng

**CODMNHSPCT.dll là module quản lý "Danh mục nhóm sản phẩm công trình"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Phân loại sản phẩm công trình
- Tạo các nhóm phân loại cho sản phẩm công trình
- Quản lý cấp độ phân nhóm (cấp 1, cấp 2...)
- Sắp xếp theo số thứ tự nhóm

#### 2. Tích hợp với module khác
- Liên kết với danh mục sản phẩm chi tiết (CODMSPCT)
- Hỗ trợ phân loại trong báo cáo giá thành
- Phục vụ cho việc tổng hợp chi phí theo nhóm

### Đặc điểm kỹ thuật

- Form đơn giản kế thừa từ frmDMView
- Auto-initialization cho cột "cap"
- Sort theo "stt_nhom" khi thêm mới

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục nhóm sản phẩm công trình - cơ sở cho việc phân loại và tổng hợp chi phí trong module giá thành.

---

*Ngày phân tích: 2026-03-29*
