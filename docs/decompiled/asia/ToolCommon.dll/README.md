# Báo cáo Phân tích DLL: ToolCommon.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Class Library) |
| Ngôn ngữ | C# / VB.NET Hybrid |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | ToolCommon |
| Assembly Title | ToolCommons |
| Assembly Company | Asiasoft |
| Assembly Product | ToolCommons |
| Assembly Copyright | Copyright © Asiasoft 2013 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | a01b91d3-613c-4fb4-8324-0b978d5c846e |
| ComVisible | false |

---

## Cấu trúc File

```
ToolCommon.dll/
├── ToolCommon.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.ToolCommon/
│   └── TCommon.cs                 # Main utility module
├── AsiaErp.ToolCommon.My/
│   ├── MyApplication.cs           # VB Application wrapper
│   ├── MyComputer.cs              # VB Computer wrapper
│   ├── MyProject.cs               # VB My namespace provider
│   ├── MySettings.cs              # Application settings
│   ├── MySettingsProperty.cs      # Settings property accessor
│   └── InternalXmlHelper.cs       # XML helper utilities
└── AsiaErp.ToolCommon.My.Resources/
    └── Resources.cs               # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access (ADO.NET) |
| System.Xml.Linq | LINQ to XML |
| System.Core | LINQ and extension methods |
| System.Configuration | Configuration file access |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Data.SqlClient`
- `System.Configuration`, `System.IO`
- `System.Xml.Linq`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

### Namespace: AsiaErp.ToolCommon

| Class | Loại | Mục đích |
|-------|------|----------|
| `TCommon` | `StandardModule` | Module tiện ích chính cung cấp các hàm kết nối và truy vấn database |

### Namespace: AsiaErp.ToolCommon.My

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `MyApplication` | `ApplicationBase` | Wrapper cho VB My.Application |
| `MyComputer` | `Computer` | Wrapper cho VB My.Computer |
| `MyProject` | - | Cung cấp các instance thread-safe cho My namespace |
| `MySettings` | `ApplicationSettingsBase` | Quản lý application settings |
| `MySettingsProperty` | - | Property accessor cho My.Settings |
| `InternalXmlHelper` | - | Helper xử lý XML namespace (compiler-generated) |
| `MyWebServices` | - | Wrapper cho SOAP web services |
| `ThreadSafeObjectProvider<T>` | - | Provider pattern cho thread-safe object creation |

### Namespace: AsiaErp.ToolCommon.My.Resources

| Class | Mục đích |
|-------|----------|
| `Resources` | Resource manager strongly-typed |

---

## Chi tiết TCommon Module

### Session Management

Sử dụng `Hashtable` để lưu trữ session-level data:

| Key | Mô tả |
|-----|-------|
| `SqlServerName` | Tên server SQL |
| `DaoType` | Loại data access (WIN/MsSql/Oracle) |
| `AuthenticationType` | Kiểu xác thực (SQL/Windows) |
| `SqlUserName` | Username SQL |
| `SqlPassword` | Password SQL (đã mã hóa) |
| `SqlSysDBName` | Tên database hệ thống |
| `SqlDataDBName` | Tên database dữ liệu |
| `sDataCnnString` | Connection string data database |
| `sSysCnnString` | Connection string system database |

### Các hàm chính

| Hàm | Mô tả |
|-----|-------|
| `LoadDefautConnect()` | Đọc cấu hình từ `Startup.exe.config`, giải mã và lưu vào session |
| `GetConnection()` | Trả về connection string dựa trên authentication type |
| `CreateConnection(bool isSys)` | Tạo và mở `SqlConnection`, hỗ trợ cả data và system DB |
| `CheckConnection()` | Kiểm tra kết nối, tự động reload config nếu fail |
| `TestConnection(string)` | Test connection với string cụ thể (hỗ trợ MsSql/Oracle) |
| `TGetDataTable(bool, string, params object[])` | Gọi stored procedure, trả về `DataTable` |
| `TGetDataTableByQuerry(bool, string, params object[])` | Thực thi SQL query trực tiếp, trả về `DataTable` |

### Đặc điểm kỹ thuật

- **CommandTimeout**: 9000 giây (2.5 giờ) cho các query dài
- **Parameter Derivation**: Tự động derive parameters từ stored procedure
- **Encryption**: Sử dụng `Helper.Decrypted()` với key 125-127 để giải mã config
- **Connection Pooling**: Tự động dispose connection sau khi sử dụng
- **Error Handling**: Try-catch với `ProjectData.SetProjectError()` pattern của VB

---

## Chuỗi và giá trị đáng chú ý

### File cấu hình
- `Startup.exe.config` - File config mặc định

### Thông báo lỗi
- `"Không thể kết nối đến server!"` - Lỗi kết nối SQL

### Connection String Patterns

**SQL Authentication:**
```
Server={0};Uid={1};Pwd={2};Database={3};Integrated Security=no
```

**Windows Authentication:**
```
Server={0};Database={1};Integrated Security=Yes
```

---

## Mục đích sử dụng

**ToolCommon.dll là module tiện ích cơ sở** cung cấp các hàm kết nối database và truy vấn dữ liệu cho hệ thống ERP của Asiasoft.

### Chức năng chính

#### 1. Quản lý kết nối Database
- Đọc cấu hình từ file `Startup.exe.config`
- Hỗ trợ SQL Server Authentication và Windows Authentication
- Giải mã thông tin nhạy cảm (password) sử dụng Helper.dll
- Tạo và quản lý connection strings cho cả data và system database

#### 2. Data Access Layer
- Gọi stored procedures với parameter binding tự động
- Thực thi SQL queries trực tiếp
- Trả về `DataTable` cho UI binding
- Timeout dài (9000s) hỗ trợ báo cáo phức tạp

#### 3. Session Management
- Hashtable-based session storage
- Thread-safe access pattern
- Lưu trữ thông tin kết nối toàn cục

#### 4. VB.NET Compatibility
- Cung cấp My namespace cho tương thích VB
- Compiler-generated helpers cho XML
- Resource manager strongly-typed

### Đặc điểm kỹ thuật

- **Hybrid C#/VB**: Code C# với VB runtime patterns
- **Legacy Pattern**: Sử dụng `ProjectData.SetProjectError()` của VB
- **Oracle Support**: Có code stub cho Oracle (throw NotSupportedException)
- **Helper Integration**: Phụ thuộc Helper.dll cho giải mã

---

## Kết luận

Đây là một module class library cơ sở trong hệ thống ERP Asia Enterprise, cung cấp các hàm tiện ích cho kết nối SQL Server và truy vấn dữ liệu. Được thiết kế để sử dụng như một dependency chung cho các module khác trong hệ thống.

---

*Ngày phân tích: 2026-03-29*
