# Báo cáo Phân tích DLL: Helper.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Class Library) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | Helper |
| Assembly Title | Utility |
| Assembly Company | Asia |
| Assembly Product | Utility |
| Assembly Copyright | Copyright © Asia 2009 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ee6faf41-a7a4-4e44-99ea-ef07850c0609 |
| ComVisible | false |

---

## Cấu trúc File

```
Helper.dll/
├── Helper.csproj              # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.Framework/
│   ├── Helper.cs              # Main helper class (cryptography, utilities)
│   ├── CBO.cs                 # Custom Business Object (data mapping)
│   ├── CMessageBox.cs         # Custom MessageBox wrapper
│   ├── CSysMsgBoxHook.cs      # Windows API hook for MessageBox
│   ├── Null.cs                # Null value handling
│   ├── AsDictionary.cs        # Custom dictionary implementation
│   ├── AsiaMessage.cs         # Message entity class
│   └── SystemInformations.cs  # System configuration/info
└── AsiaErp.Framework.My/
    ├── MyApplication.cs       # VB My.Application wrapper
    ├── MyComputer.cs          # VB My.Computer wrapper
    ├── MyProject.cs           # VB My.Project wrapper
    ├── MySettings.cs          # VB My.Settings wrapper
    └── MySettingsProperty.cs  # VB Settings property wrapper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Xml | XML processing |
| System.Configuration | Configuration management |
| System.Core | LINQ và core extensions |

---

## Namespaces và Classes

### 1. AsiaErp.Framework

#### Helper (sealed class)
Module tiện ích chính cung cấp các chức năng:

| Enum/Class | Mục đích |
|------------|----------|
| `ErrorType` | Error, Warning, Info |
| `HashEncodeType` | NoEncode, Base64, Hex |
| `Sender` | RSA encryption/signing (gửi dữ liệu mã hóa) |
| `Receiver` | RSA decryption/verification (nhận dữ liệu mã hóa) |
| `Hash` | Hash algorithms (SHA1, SHA256, SHA384, SHA512, MD5, CRC32) |
| `Symmetric` | Symmetric encryption (DES, RC2, Rijndael, TripleDES) |
| `Asymmetric` | Asymmetric encryption (RSA) |
| `CryptographyData` | Wrapper cho dữ liệu mã hóa |
| `Utils` | Helper methods (Hex, Base64, XML, Config) |

**Các hàm tiện ích chính:**

| Hàm | Mục đích |
|-----|----------|
| `LoadMessage()` | Load message từ XML file theo culture |
| `DefaulValueOfType()` | Giá trị mặc định theo SqlDbType |
| `isSQLNumType()` | Kiểm tra kiểu số SQL |
| `Repl_Str()` / `Str_Quote()` | Escape SQL string (thay ' thành '') |
| `Repl_Null()` | Xử lý DBNull |
| `Date_Convert()` | Chuyển đổi định dạng ngày tháng |
| `FormatNumber()` / `UnFormatNumber()` | Format/unformat số tiền |
| `TextLogEvent()` / `LogEvent()` | Ghi log (file hoặc Windows Event) |
| `ProcessError()` | Xử lý và ghi log lỗi |
| `GetMess()` / `GetMessContent()` | Lấy message theo ID |
| `ComputeHash()` | Tính hash (MD5, SHA...) |
| `Encrypted()` / `Decrypted()` | Mã hóa/giải mã đơn giản |

#### CBO (Custom Business Object)
Class hỗ trợ mapping dữ liệu từ DataReader sang Object.

| Method | Mục đích |
|--------|----------|
| `FillObject()` | Map 1 record sang object |
| `FillList()` | Map nhiều records sang List<object> |
| `FillCollection()` | Map nhiều records sang ArrayList |
| `FillHashTable()` | Map records sang Hashtable với key chỉ định |
| `InitializeObject()` | Khởi tạo object với giá trị null |
| `Serialize()` | Serialize object sang XML |

#### CBO<T> (Generic version)
Phiên bản generic của CBO cho type-safe mapping.

#### CMessageBox
Wrapper cho MessageBox với localization.

| Method | Mục đích |
|--------|----------|
| `Show()` | Hiển thị message box (nhiều overload) |
| `ShowWithFormat()` | Hiển thị với format string |

Tích hợp với `CSysMsgBoxHook` để thay đổi text nút (OK, Cancel...) sang tiếng Việt.

#### CSysMsgBoxHook
Windows API hook để customize MessageBox buttons.

| Button ID | Text tiếng Việt |
|-----------|-----------------|
| OK | "Nhận" |
| Cancel | "Hủy bỏ" |
| Abort | "Hủy" |
| Retry | "Thử lại" |
| Ignore | "Bỏ qua" |
| Yes | "Có" |
| No | "Không" |

Sử dụng Windows Hook (WH_CBT) và API `SetDlgItemText`.

#### Null
Xử lý giá trị null/DBNull.

| Property | Giá trị null mặc định |
|----------|----------------------|
| `NullShort` | -1 |
| `NullInteger` | -1 |
| `NullSingle` | float.MinValue |
| `NullDouble` | double.MinValue |
| `NullDecimal` | decimal.MinValue |
| `NullDate` | DateTime.MinValue |
| `NullString` | "" |
| `NullBoolean` | false |
| `NullGuid` | Guid.Empty |

| Method | Mục đích |
|--------|----------|
| `SetNull()` | Gán giá trị null theo type |
| `GetNull()` | Chuyển giá trị null thành DBNull |
| `IsNull()` | Kiểm tra giá trị có phải null |

#### AsDictionary
Custom Dictionary kế thừa DictionaryBase.

| Method | Mục đích |
|--------|----------|
| `Add()` | Thêm key-value |
| `Contains()` | Kiểm tra key tồn tại |
| `Remove()` | Xóa theo key |
| `Adds()` | Thêm từ Collection |

#### AsiaMessage
Entity class cho message system.

| Property | Kiểu | Mô tả |
|----------|------|-------|
| `Id` | int | Mã message |
| `Icon` | int | MessageBoxIcon (cast) |
| `Description` | string | Nội dung message |

#### SystemInformations
Lưu trữ thông tin hệ thống và cấu hình.

| Property | Mô tả |
|----------|-------|
| `ProductName` | "Simba Accounting" hoặc "Asia Standard" |
| `ProductVersion` | "14.2" |
| `ProductCreateDate` | "28/03/2015" |
| `RootPath` | Đường dẫn gốc ứng dụng |
| `XMLPath` | Đường dẫn thư mục XML |
| `ReportPath` | Đường dẫn báo cáo |
| `UserName` | Tên đăng nhập |
| `FullName` | Họ tên đầy đủ |
| `FinancialYear` | Năm tài chính |
| `IsAdmin` | Quyền admin |
| `CurrentCultureName` | Ngôn ngữ hiện tại (mặc định "vi-VN") |
| `ASSB` | Flag Asia Standard/Simba Accounting |

### 2. AsiaErp.Framework.My

Namespace chứa các wrapper cho Visual Basic "My" objects:

| Class | Mục đích |
|-------|----------|
| `MyApplication` | Wrapper cho My.Application |
| `MyComputer` | Wrapper cho My.Computer |
| `MyProject` | Wrapper cho My.Project |
| `MySettings` | Wrapper cho My.Settings |
| `MySettingsProperty` | Property accessor cho Settings |

---

## Mục đích sử dụng

**Helper.dll là thư viện tiện ích lõi (core utility library)** của hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Mã hóa và Bảo mật
- **Symmetric Encryption**: DES, RC2, Rijndael, TripleDES
- **Asymmetric Encryption**: RSA với key pair management
- **Hashing**: SHA1, SHA256, SHA384, SHA512, MD5, CRC32
- **CryptographyData**: Wrapper đa định dạng (Bytes, Text, Hex, Base64)

#### 2. Data Access Utilities
- **CBO Pattern**: Custom Business Object cho mapping DataReader → Object
- **Null Handling**: Xử lý DBNull và giá trị mặc định
- **SQL Utilities**: Escape string, kiểm tra kiểu dữ liệu

#### 3. Localization
- **Message System**: Load message từ XML theo culture (vi-VN, en-US...)
- **Custom MessageBox**: Tự động thay đổi text nút sang tiếng Việt

#### 4. Logging
- **Windows Event Log**: Ghi log vào Windows Event Viewer
- **File Log**: Ghi log ra file với rotation (Log.txt, Log1.txt...)

#### 5. System Information
- Lưu trữ thông tin người dùng, đường dẫn, phiên bản
- Hỗ trợ cả Simba Accounting và Asia Standard

### Đặc điểm kỹ thuật

- Sử dụng Reflection cho object mapping
- Windows API hook (WH_CBT) cho