# Báo cáo Phân tích DLL: SITheme.dll

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
| Assembly Name | SITheme |
| Assembly Title | SITHEME |
| Assembly Company | chinhvd |
| Assembly Product | SITHEME |
| Assembly Copyright | Copyright © chinhvd 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 3c5eeaf1-e955-4f59-a62a-0eee29cc5c33 |
| ComVisible | false |

---

## Cấu trúc File

```
SITheme.dll/
├── SITheme.csproj               # Project file
├── app.ico                      # Application icon
├── Resources.resx               # Resource file
├── OpenListBoxColors.cs         # Form chọn màu popup
├── frmSIThemeInputName.cs       # Form nhập tên theme mới
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.Bussiness/
│   └── KeyValue.cs              # Class lưu trữ cấu hình theme
├── AsiaErp.Framework/
│   └── AsListBoxColors.cs       # Custom ListBox hiển thị màu
├── AsiaErp.UserInterface/
│   └── frmSITheme.cs            # Form cấu hình theme chính
└── My/
    ├── MyApplication.cs         # VB MyApplication wrapper
    ├── MyComputer.cs            # VB MyComputer wrapper
    ├── MyProject.cs             # VB MyProject wrapper
    ├── MySettings.cs            # Application settings
    ├── MySettingsProperty.cs    # Settings property wrapper
    └── InternalXmlHelper.cs     # XML helper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Configuration | Configuration management |
| System.Xml | XML processing |
| System.Data | Data access |
| Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Bussiness`
- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `System.Configuration`
- `System.Xml`, `System.Data`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSITheme` | `frmAsiaRoot` | Form cấu hình theme chính |
| `frmSIThemeInputName` | `frmAsiaRoot` | Form nhập tên theme mới |
| `OpenListBoxColors` | `Form` | Popup chọn màu |
| `AsListBoxColors` | `ListBox` | Custom ListBox hiển thị màu |
| `KeyValue` | - | Class lưu trữ và xử lý cấu hình theme |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Thiết lập thuộc tính menu" - Tên form chính
- "Danh sách theme" - Dropdown chọn theme
- "Thuộc tính" - GroupBox cấu hình
- "Click vào ô để thay đổi giá trị" - Hướng dẫn sử dụng

### Kiểu Menu

| Giá trị | Ý nghĩa |
|---------|---------|
| Tree | Menu dạng cây thư mục |
| Docking Menu | Menu dạng panel đa năng |

### Các thuộc tính màu sắc

| Thuộc tính | Ý nghĩa |
|------------|---------|
| Màu nền phân hệ | MODULE_MENU_BACK_COLOR |
| Màu nền bảng phân hệ | LEFT_MENU_BACK_COLOR |
| Màu chữ phân hệ | MODULE_MENU_FORE_COLOR |
| Màu chữ phân hệ đang chọn | MODULE_MENU_SELECTED_FORE_COLOR |
| Màu tên phân hệ hiện thời | CURRENT_MODULE_LABEL_FORE_COLOR |
| Màu chữ phân hệ con | SUB_MENU_FORE_COLOR |
| Màu chữ chức năng | DETAIL_MENU_FORE_COLOR |
| Màu nền chứng từ | CT_BakgroundColorName |
| Màu dòng xen kẽ chứng từ | CT_AlternatingBackColorName |
| Màu nền danh mục | DM_BakgroundColorName |
| Màu dòng xen kẽ danh mục | DM_AlternatingBackColorName |
| Màu nền báo cáo | BC_BakgroundColorName |
| Màu dòng xen kẽ báo cáo | BC_AlternatingBackColorName |
| Màu nền texbox có F5 | AsTextBox_BakgroundColorName |

### Kiểu chữ (Font)

| Thuộc tính | Ý nghĩa |
|------------|---------|
| Kiểu chữ phân hệ | MODULE_MENU_FONT |
| Kiểu chữ phân hệ con | SUB_MENU_FONT |
| Kiểu chữ chức năng | DETAIL_MENU_FONT |

### Thuộc tính kích thước

| Thuộc tính | Ý nghĩa |
|------------|---------|
| Độ rộng bảng phân hệ | MODULE_PANEL_MAX_WIDTH |
| Độ rộng cột | X_COLUMN2 |

---

## Mục đích sử dụng

**SITheme.dll là module cấu hình giao diện người dùng (UI Theme)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý Theme
- Hiển thị danh sách các theme có sẵn
- Thêm theme mới (sao chép từ theme Default)
- Xóa theme
- Áp dụng theme cho hệ thống

#### 2. Cấu hình màu sắc
- Màu nền và màu chữ cho menu
- Màu nền cho các loại form (Chứng từ, Danh mục, Báo cáo)
- Màu dòng xen kẽ (Alternating row color)
- Màu cho các control đặc biệt

#### 3. Cấu hình font chữ
- Font cho menu phân hệ
- Font cho menu phân hệ con
- Font cho menu chức năng chi tiết

#### 4. Cấu hình kiểu menu
- Tree: Menu dạng cây truyền thống
- Docking Menu: Menu dạng panel hiện đại

#### 5. Cấu hình kích thước
- Độ rộng panel menu
- Độ rộng cột trong grid

### Đặc điểm kỹ thuật

#### Lưu trữ cấu hình
- File XML: `Theme.xml` trong thư mục `SystemInformations.XMLPath`
- Structure: DataSet với mỗi theme là một DataTable
- Default theme: Luôn có sẵn và không thể xóa

#### Class KeyValue
```csharp
public class KeyValue
{
    public string MENU_TYPE;                    // Tree hoặc Docking Menu
    public int X_COLUMN2;                       // Độ rộng cột
    public int MODULE_PANEL_MAX_WIDTH;          // Độ rộng panel
    public Color MODULE_MENU_BACK_COLOR;        // Màu nền menu
    public Color MODULE_MENU_FORE_COLOR;        // Màu chữ menu
    public Font MODULE_MENU_FONT;               // Font menu
    public Color CT_BakgroundColorName;         // Màu nền chứng từ
    public Color CT_AlternatingBackColorName;   // Màu dòng xen kẽ CT
    // ... và nhiều thuộc tính khác
}
```

#### Custom Controls

**AsListBoxColors** (kế thừa ListBox):
- Hiển thị danh sách màu với preview
- Hỗ trợ Known Colors của .NET
- DrawMode = OwnerDrawFixed
- ColorBarWidth: Độ rộng thanh màu preview

**OpenListBoxColors** (kế thừa Form):
- Popup form để chọn màu
- Hiển thị AsListBoxColors
- Trả về SelectedColor
- Hỗ trợ DoubleClick và Enter để chọn

#### Xử lý màu sắc
- Lưu trữ: Tên màu (KnownColor) hoặc mã HTML (#RRGGBB)
- Chuyển đổi: `ColorTranslator.FromHtml()`
- Hiển thị: TextBox với BackColor = màu được chọn

#### Xử lý Font
- Format lưu trữ: "FontName,Size,Style"
- Ví dụ: "Microsoft Sans Serif,8.25,0"
- Style: 0=Regular, 1=Bold, 2=Italic, 3=BoldItalic, 4=Underline, 8=Strikeout

### Cấu trúc Theme.xml

```xml
<NewDataSet>
  <Default>
    <MENU_TYPE>1</MENU_TYPE>
    <X_COLUMN2>200</X_COLUMN2>
    <MODULE_PANEL_MAX_WIDTH>250</MODULE_PANEL_MAX_WIDTH>
    <MODULE_MENU_BACK_COLOR>Control</MODULE_MENU_BACK_COLOR>
    <MODULE_MENU_FORE_COLOR>Black</MODULE_MENU_FORE_COLOR>
    <CT_BakgroundColorName>#FFFFFF</CT_BakgroundColorName>
    <CT_AlternatingBackColorName>#FFF8DC</CT_AlternatingBackColorName>
    <!-- ... các thuộc tính khác -->
  </Default>
  <CustomTheme1>
    <!-- ... -->
  </CustomTheme1>
</NewDataSet>
```

### Các nút chức năng

| Nút | Chức năng |
|-----|-----------|
| Mới | Tạo theme mới từ Default |
| Xóa | Xóa theme đang chọn |
| Mặc định | Khôi phục về theme Default |
| Lưu | Lưu cấu hình vào file XML |
| Áp dụng | Áp dụng theme cho hệ thống |
| Thoát | Đóng form |

### Phím tắt

| Phím | Chức năng |
|------|-----------|
| ESC | Đóng form |
| Ctrl+R | Restart ứng dụng (qua context menu) |

---

## Kết luận

Đây là module cấu hình giao diện nâng cao của hệ thống ERP Asia Enterprise, cho phép người dùng tùy chỉnh màu sắc, font chữ và kiểu menu theo sở thích. Module này sử dụng file XML để lưu trữ cấu hình và hỗ trợ nhiều theme khác nhau, giúp tăng trải nghiệm người dùng và khả năng cá nhân hóa giao diện.

---

*Ngày phân tích: 2026-03-29*
