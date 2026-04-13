# Báo cáo Phân tích DLL: AsiaLicenseCommon.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# / VB.NET |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | AsiaLicenseCommon |
| Assembly Title | AsiaLicenseCommon |
| Assembly Company | (trống) |
| Assembly Product | AsiaLicenseCommon |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | e5e9b536-dd35-4218-930b-4d8788d169ae |
| ComVisible | false |

---

## Cấu trúc File

```
AsiaLicenseCommon.dll/
├── AsiaLicenseCommon.csproj           # Project file
├── app.ico                            # Application icon
├── AsiaLicenseCommon.Resources.resx   # Resource file (chứa public key)
├── Properties/
│   └── AssemblyInfo.cs                # Assembly metadata
├── AsiaLicenseCommon/
│   ├── AsiaSoftLicense.cs             # License container class
│   ├── LicenseTerms.cs                # License terms data model
│   ├── LicenseTerms.patched.cs        # Patched version (hardcoded customer)
│   ├── RSA.cs                         # License validation (DSA signature)
│   ├── RSA_Patched.cs                 # Patched version (bypass validation)
│   ├── Serializer.cs                  # XML serialization helper
│   └── frmRSAKeyGenerator.cs          # Key pair generator form
├── AsiaLicenseCommon.My/
│   ├── MyProject.cs                   # VB.NET My project support
│   ├── MyApplication.cs               # Application context
│   ├── MyComputer.cs                  # Computer info helper
│   ├── MySettings.cs                  # Settings manager
│   ├── MySettingsProperty.cs          # Settings properties
│   └── InternalXmlHelper.cs           # XML helper utilities
└── AsiaLicenseCommon.My.Resources/
    └── Resources.cs                   # Strongly typed resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | VB.NET runtime support |
| System.Xml | XML serialization |
| System.Xml.Linq | LINQ to XML |
| System.Core | .NET Core extensions |

### Namespaces sử dụng

- `System`, `System.IO`, `System.Security.Cryptography`
- `System.Runtime.Serialization.Formatters.Binary`
- `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Namespace | Mục đích |
|-------|-----------|----------|
| `RSA` | `AsiaLicenseCommon` | Validation license bằng DSA signature |
| `LicenseTerms` | `AsiaLicenseCommon` | Data model chứa thông tin license |
| `AsiaSoftLicense` | `AsiaLicenseCommon` | Container cho license terms + signature |
| `Serializer` | `AsiaLicenseCommon` | XML serialize/deserialize helper |
| `frmRSAKeyGenerator` | `AsiaLicenseCommon` | Windows Form generate DSA key pair |
| `Resources` | `AsiaLicenseCommon.My.Resources` | Resource manager (chứa public key) |

---

## License Management System

### 1. File License

| Thuộc tính | Giá trị |
|------------|---------|
| Tên file | `Simba.asialic` |
| Vị trí | `Application.StartupPath` |
| Format | XML serialized (AsiaSoftLicense) |
| Encoding | Base64 cho license data và signature |

### 2. Cấu trúc License

```
AsiaSoftLicense
├── LicenseTerms (string, Base64)  →  LicenseTerms object
│   ├── CustomerName               →  Tên khách hàng
│   ├── CreatedDate                →  Ngày tạo license
│   ├── BranchID                   →  Mã chi nhánh
│   ├── StartDate                  →  Ngày bắt đầu hiệu lực
│   ├── EndDate                    →  Ngày hết hạn
│   ├── CreatedComputer            →  Máy tạo license
│   └── TrialMode                  →  Chế độ trial (90 ngày)
└── Signature (string, Base64)     →  DSA signature của license data
```

### 3. Thuật toán bảo mật

| Thuộc tính | Giá trị |
|------------|---------|
| Algorithm | DSA (Digital Signature Algorithm) |
| Provider | DSACryptoServiceProvider |
| Key storage | Embedded public key trong Resources |
| Data format | Binary serialization → Base64 |

### 4. Quy trình Validation

```
1. Load file Simba.asialic
2. Deserialize XML → AsiaSoftLicense object
3. Decode Base64(LicenseTerms) → byte[]
4. Decode Base64(Signature) → byte[]
5. Load public key từ Resources
6. DSA.VerifyData(data, signature)
7. Nếu valid → Deserialize LicenseTerms
8. Kiểm tra TrialMode và date range
9. Trả về true/false
```

### 5. Trial Mode

| Thuộc tính | Giá trị |
|------------|---------|
| Trial period | 90 ngày (DEFAULT_TRIAL_PERIOD) |
| Start date | File creation time của application folder |
| End date | Start date + 90 ngày |
| UsedDay | Số ngày đã sử dụng |
| RemainindDay | Số ngày còn lại |

---

## Các file Patched

### RSA_Patched.cs
- **Mục đích**: Bypass hoàn toàn kiểm tra license
- **Thay đổi**: Hàm `LicenseIsValid()` luôn trả về `true`
- **Code gốc**: Đã comment out, giữ lại để tham khảo

### LicenseTerms.patched.cs
- **Mục đích**: Hardcode tên khách hàng
- **Thay đổi**: Property `CustomerName` getter trả về:
  ```csharp
  "Công ty TNHH Điệp Xuân;Cty Sản Xuất Điệp Xuân;" + _customerName
  ```
- **Tác dụng**: License hiển thị tên khách hàng cố định

---

## Mục đích sử dụng

**AsiaLicenseCommon.dll là module quản lý license cho phần mềm Simba** (của Asia Software).

### Chức năng chính

#### 1. License Validation
- Kiểm tra tính hợp lệ của file license (`Simba.asialic`)
- Xác thực chữ ký số DSA
- Kiểm tra thời hạn sử dụng
- Hỗ trợ chế độ trial 90 ngày

#### 2. License Generation Tools
- `frmRSAKeyGenerator`: Tool generate cặp khóa DSA (public/private)
- Public key được embed vào Resources
- Private key dùng để ký license

#### 3. License Data Model
- `LicenseTerms`: Chứa thông tin khách hàng, thời hạn, chi nhánh
- `AsiaSoftLicense`: Container để serialize lưu file
- `Serializer`: Helper để XML serialize/deserialize

### Đặc điểm kỹ thuật

- Sử dụng DSA (Digital Signature Algorithm) để ký và xác thực
- License data được binary serialize rồi encode Base64
- Public key được nhúng cứng trong assembly resources
- Hỗ trợ cả license chính thức và trial mode

---

## Kết luận

Đây là module license management của hệ thống Simba ERP, sử dụng DSA digital signature để bảo vệ license file. Module cung cấp:
- Cơ chế ký và xác thực license bằng DSA
- Quản lý thời hạn sử dụng (trial và full)
- Tool generate key pair cho việc cấp license

Các file `RSA_Patched.cs` và `LicenseTerms.patched.cs` cho thấy đã có can thiệp để bypass kiểm tra license và hardcode thông tin khách hàng.

---

*Ngày phân tích: 2026-03-29*
