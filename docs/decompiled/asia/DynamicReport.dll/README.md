# Báo cáo Phân tích DLL: DynamicReport.dll

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
| Assembly Name | DynamicReport |
| Assembly Title | Bảng kê đơn đặt hàng |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5b533d97-568d-41be-b375-36ef4aabce81 |
| ComVisible | false |

---

## Cấu trúc File

```
DynamicReport.dll/
├── DynamicReport.csproj              # Project file
├── app.ico                           # Application icon
├── Properties/
│   └── AssemblyInfo.cs               # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmDynamicReport.cs           # Main dynamic report form
├── AsiaErp.DataAccess/
│   ├── DynamicReportDAO.cs           # Dynamic report DAO interface
│   └── MsSqlDynamicReportDAO.cs      # MS SQL implementation
└── My/
    ├── MyApplication.cs              # Application settings
    ├── MySettings.cs                 # Settings
    ├── MySettingsProperty.cs         # Settings property
    ├── MyComputer.cs                 # Computer info
    ├── MyProject.cs                  # Project info
    └── InternalXmlHelper.cs          # XML helper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Core | .NET Core extensions |
| System.Xml.Linq | LINQ to XML |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmDynamicReport` | `frmReport` | Form báo cáo động, tự động tạo controls từ stored procedure |
| `DynamicReportDAO` | `DAO` | Interface cho dynamic report data access |
| `MsSqlDynamicReportDAO` | - | Implementation MS SQL cho DynamicReportDAO |

---

## Các chuỗi Text đáng chú ý

### Control Width Constants

| Constant | Giá trị | Ý nghĩa |
|----------|---------|---------|
| `W_TEXT` | 330 | Chiều rộng text box |
| `W_LOOK` | 90 | Chiều rộng lookup control |
| `W_DROP` | 90 | Chiều rộng dropdown |
| `W_CHECK` | 90 | Chiều rộng checkbox |
| `W_DATETIME` | 67 | Chiều rộng datetime picker |
| `W_RADIO` | 396 | Chiều rộng radio button group |

### Layout Constants

| Constant | Giá trị | Ý nghĩa |
|----------|---------|---------|
| `H_ALING_TEXT` | 10 | Khoảng cách text alignment |
| `H_ALING_GROUP` | 25 | Khoảng cách group alignment |
| `LBL_X` | 24 | Vị trí X của label |
| `CONTROL_X` | 110 | Vị trí X của control |
| `LBL_NAME_X` | 202 | Vị trí X của label name |

---

## Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `spName` | Tên stored procedure |
| `f_arrParRequired` | Mảng các control bắt buộc |
| `f_arrParControls` | Mảng các control tham số |
| `f_arrLabelControls` | Mảng các label control |
| `f_arrAllControlFilterCustom` | Mảng các control filter tùy chỉnh |
| `f_blnIsLoading` | Flag đang loading |
| `f_Y_Value` | Giá trị Y cho layout |

---

## Mục đích sử dụng

**DynamicReport.dll là module tạo báo cáo động** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Tạo Controls Động
- Tự động tạo các input controls dựa trên tham số của stored procedure
- Hỗ trợ các loại control: TextBox, Lookup, DropDown, CheckBox, DateTimePicker, RadioButton
- Layout tự động theo chiều dọc

#### 2. Validation
- Kiểm tra các trường bắt buộc (required fields)
- Validate kiểu dữ liệu
- Hiển thị thông báo lỗi

#### 3. Data Binding
- Kết nối với stored procedure SQL Server
- Lấy thông tin tham số từ SQL Server metadata
- Binding dữ liệu vào controls

#### 4. Filter Custom
- Hỗ trợ filter tùy chỉnh
- Lưu trữ cấu hình filter
- Áp dụng filter khi chạy báo cáo

### Đặc điểm kỹ thuật

- Sử dụng reflection để lấy thông tin stored procedure
- Tạo controls động dựa trên SqlParameterCollection
- Hỗ trợ nhiều kiểu dữ liệu SQL
- Layout tự động với khoảng cách cố định

---

## Kết luận

Đây là module báo cáo động cho phép tạo form nhập liệu tự động dựa trên stored procedure, giúp giảm thiểu việc viết code thủ công cho các báo cáo có tham số đầu vào.

---

*Ngày phân tích: 2026-03-29*
