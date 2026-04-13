# Báo cáo Phân tích DLL: Framework.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# / VB.NET |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| Số dòng code | ~81,600 dòng |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | Framework |
| Assembly Title | Framework |
| Assembly Company | Asia |
| Assembly Product | Base |
| Assembly Copyright | Copyright © Asia 2014 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | bed3e715-2cfa-4282-bf24-cd6c38eb64dd |
| ComVisible | false |

---

## Cấu trúc File

```
Framework.dll/
├── Framework.decompiled.cs    # File decompiled chính (~81,600 dòng)
└── README.md                  # Tài liệu này
```

---

## Namespaces

| Namespace | Mục đích |
|-----------|----------|
| `AsiaErp.Framework` | Core framework classes, UI controls, forms, controllers |
| `AsiaErp.DataAccess` | Data Access Objects (DAO), database abstraction layer |
| `My` | VB.NET My namespace (Application, Computer, User, Settings) |
| `My.Resources` | Resource manager cho localization |

---

## Kiến trúc tổng quan

Framework.dll là **core framework** của hệ thống ERP Asia Enterprise, cung cấp:

1. **Base Classes** cho tất cả forms trong hệ thống
2. **Custom UI Controls** (As* prefix) mở rộng Windows Forms
3. **Data Access Layer** (DAO pattern) hỗ trợ SQL Server và Oracle
4. **Controller Pattern** cho business logic
5. **Multi-language support** (localization)

---

## Core Components

### 1. Base Form Classes (Kế thừa)

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAsiaRoot` | `DockContent` | Base form cho tất cả forms trong hệ thống |
| `frmVoucher` | `frmAsiaRoot` | Base form cho chứng từ (nhập, sửa, xem, tìm kiếm, in) |
| `frmDMEdit` | `frmAsiaRoot` | Form chỉnh sửa danh mục |
| `frmDMView` | `frmAsiaRoot` | Form xem danh mục (grid view) |
| `frmReport` | `frmAsiaRoot` | Form báo cáo với Crystal Reports |
| `frmCalc` | `frmAsiaRoot` | Form tính toán |
| `frmLookup` / `frmLookupMulti` | `frmAsiaRoot` | Form lookup dữ liệu |

### 2. Custom UI Controls (As* Prefix)

| Control | Kế thừa | Mục đích |
|---------|---------|----------|
| `AsTextBox` | `TextBox` | TextBox với validation, auto-complete |
| `AsTextBoxMulti` | `TextBox` | TextBox đa dòng |
| `AsTextNumeric` | `TextBox` | TextBox nhập số, định dạng tiền tệ |
| `AsMaskedTextBox` | `MaskedTextBox` | TextBox với mask (ngày tháng, số) |
| `AsComboBox` | `ComboBox` | ComboBox mở rộng |
| `AsComboBoxNT` | `ComboBox` | ComboBox ngoại tệ |
| `AsComboBoxTT` | `ComboBox` | ComboBox thanh toán |
| `AsDataGridView` | `DataGridView` | DataGridView với tính năng mở rộng |
| `AsInputDGV` | `DataGridView` | DataGridView nhập liệu |
| `AsCheckBox` | `CheckBox` | CheckBox tùy chỉnh |
| `AsTabControl` | `TabControl` | TabControl tùy chỉnh |
| `AsListView` | `ListView` | ListView mở rộng |
| `AsCodeTextBox` | `UserControl` | TextBox nhập mã với lookup button |

### 3. DataGridView Custom Columns

| Class | Mục đích |
|-------|----------|
| `DataGridViewAsTextBoxColumn` | Cột TextBox tùy chỉnh |
| `DataGridViewAsTextNumericColumn` | Cột nhập số |
| `DataGridViewAsMaskedTextBoxColumn` | Cột với mask |
| `DataGridViewAsTextBoxCell` / `DataGridViewAsTextNumericCell` | Cell types |

### 4. Tax Controls (Thuế)

| Control | Mục đích |
|---------|----------|
| `ctlTaIn` | Control thuế đầu vào (VAT input) - hóa đơn mua vào |
| `ctlTaOut` | Control thuế đầu ra (VAT output) - hóa đơn bán ra |

Các control này quản lý:
- Số hóa đơn, seri, ngày hóa đơn
- Mã khách hàng, tên, địa chỉ, mã số thuế
- Mã vật tư, số lượng, giá, tiền hàng
- Thuế suất, tiền thuế, tổng tiền
- Tài khoản thuế, tài khoản dư

### 5. Data Access Layer (DAO)

#### Interfaces

| Interface | Mục đích |
|-----------|----------|
| `DAO` | Base interface cho tất cả DAO |
| `BaseCalcDAO` | DAO cho tính toán |
| `BaseDictionaryDAO` | DAO cho danh mục |
| `BaseDictionaryComplexDAO` | DAO cho danh mục phức tạp |
| `BaseVoucherDAO` | DAO cho chứng từ |
| `BaseReportDAO` | DAO cho báo cáo |
| `BaseOpeningBlanceDAO` | DAO cho số dư đầu kỳ |
| `CommonDAO` | DAO chung |

#### Implementations (MsSql)

| Class | Implements |
|-------|------------|
| `MsSqlDAO` | `DAO` - Base implementation |
| `MsSqlBaseCalcDAO` | `BaseCalcDAO` |
| `MsSqlBaseDictionaryDAO` | `BaseDictionaryDAO` |
| `MsSqlBaseDictionaryComplexDAO` | `BaseDictionaryComplexDAO` |
| `MsSqlBaseVoucherDAO` | `BaseVoucherDAO` |
| `MsSqlBaseReportDAO` | `BaseReportDAO` |
| `MsSqlBaseOpeningBlanceDAO` | `BaseOpeningBlanceDAO` |
| `MsSqlCommonDAO` | `CommonDAO` |

### 6. Controllers

| Controller | Mục đích |
|------------|----------|
| `RootController` | Base controller |
| `DictionaryController` | Controller danh mục |
| `DictionaryComplexController` | Controller danh mục phức tạp |
| `VoucherController` | Controller chứng từ |
| `ReportController` | Controller báo cáo |
| `CalcController` | Controller tính toán |
| `OpeningBlanceController` | Controller số dư đầu kỳ |
| `ControllerFactory` | Factory tạo controllers |

### 7. Configuration & Information Classes

| Class | Mục đích |
|-------|----------|
| `Environment` | Quản lý toàn bộ cấu hình runtime (menu, lookup, report, config) |
| `ClientConfiguration` | Cấu hình client (theme, colors, multi-language) |
| `DatabaseConfigurations` | Cấu hình database connection |
| `CompanyInformations` | Thông tin công ty |
| `VoucherInformation` | Thông tin chứng từ |
| `DictionaryInformation` | Thông tin danh mục |
| `ReportInformation` | Thông tin báo cáo |
| `LookupInformation` | Thông tin lookup |
| `MenuInformation` | Thông tin menu |
| `Cacheable` | Caching mechanism |

### 8. Commons Utilities

| Class | Mục đích |
|-------|----------|
| `Commons` | Utility class tĩnh với các hàm dùng chung |

**Enums trong Commons:**
- `NumericSpecialType`: Quantity, FCAmount, ACAmount, FCPrice, ACPrice
- `NumericType`: INTEGER, DOUBLE, DECIMAL
- `ApplicationMode`: VIEW_MODE, ADD_MODE, EDIT_MODE
- `QueryReturnType`: NONE_QUERY, SCALAR, DATATABLE, DATASET, DATAREADER
- `PrintOption`: Cancel, Print, Preview

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data.SqlClient | SQL Server database access |
| System.Data.OracleClient | Oracle database access |
| CrystalDecisions.* | Crystal Reports integration |
| Microsoft.Office.Interop.Excel | Excel export |
| System.Windows.Forms.DataVisualization | Chart controls |
| AsiaErp.Framework.Docking | Docking windows |

---

## Chức năng chính

### 1. Form Management
- Base form với docking support
- Multi-language support (translatable controls)
- Theme và color configuration
- Help integration

### 2. Data Access
- Abstract DAO pattern hỗ trợ SQL Server và Oracle
- Transaction support
- Parameterized queries
- Connection pooling

### 3. UI Controls
- Extended Windows Forms controls với validation
- Auto-complete cho lookup fields
- Numeric formatting theo cấu hình
- Masked input cho dates

### 4. Tax Management
- VAT input/output controls
- Hóa đơn GTGT management
- Multi-currency support

### 5. Reporting
- Crystal Reports integration
- Export to Excel
- Print preview

### 6. Configuration Management
- Runtime configuration caching
- Multi-language resources
- Company-specific settings

---

## Mục đích sử dụng

**Framework.dll là nền tảng cốt lõi** của hệ thống ERP Asia Enterprise. Tất cả các module chứng từ (như CAVchCA4.dll) đều:

1. Kế thừa từ `frmVoucher` (có trong Framework)
2. Sử dụng `As*` controls để nhập liệu
3. Gọi `DAOFactory` để tạo data access objects
4. Dùng `ControllerFactory` cho business logic
5. Tích hợp `ctlTaIn`/`ctlTaOut` cho quản lý thuế

---

## Kết luận

Đây là **core framework** của hệ thống ERP Asia Enterprise, cung cấp toàn bộ infrastructure cho việc phát triển các module nghiệp vụ. Framework.dll định nghĩa patterns, base classes, và utilities được sử dụng xuyên suốt toàn bộ hệ thống.

---

*Ngày phân tích: 2026-03-29*