# AsiaLicenseCommon.dll - Tài liệu phân tích

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | AsiaLicenseCommon |
| Loại file | .NET Class Library (DLL) |
| Framework | .NET Framework 3.5 |
| Version | 1.0.0.0 |
| Copyright | 2014 |
| GUID | e5e9b536-dd35-4218-930b-4d8788d169ae |
| AllowUnsafeBlocks | True |

**Mục đích:** Module quản lý bản quyền (license) cho phần mềm Simba ERP của Asia Software. Cung cấp cơ chế tạo, lưu, load và xác thực file license bằng chữ ký số DSA.

---

## Cấu trúc thư mục

```
AsiaLicenseCommon.dll/
├── AsiaLicenseCommon/
│   ├── AsiaSoftLicense.cs          # License container (serialize/deserialize)
│   ├── LicenseTerms.cs             # Data model thông tin license
│   ├── LicenseTerms.patched.cs     # Patched version (hardcode customer name)
│   ├── RSA.cs                      # License validation logic (gốc)
│   ├── RSA_Patched.cs              # Patched version (bypass validation)
│   ├── Serializer.cs               # Generic XML serializer helper
│   └── frmRSAKeyGenerator.cs       # Form tạo DSA key pair
├── AsiaLicenseCommon.My/           # VB.NET My namespace boilerplate
│   ├── MyProject.cs
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
├── AsiaLicenseCommon.My.Resources/
│   └── Resources.cs                # ResourceManager (chứa DSA public key)
└── Properties/
    └── AssemblyInfo.cs
```

---

## Classes chi tiết

### 1. AsiaSoftLicense

**Namespace:** `AsiaLicenseCommon`

Container chính cho license file, được XML serialize ra file `Simba.asialic`.

| Property | Type | Mô tả |
|----------|------|-------|
| `LicenseTerms` | `string` | Base64-encoded binary serialized `LicenseTerms` object |
| `Signature` | `string` | Base64-encoded DSA signature của LicenseTerms data |

**Methods:**

| Method | Signature | Mô tả |
|--------|-----------|-------|
| `Save` | `void Save(string filename)` | Serialize object ra file XML qua `Serializer.Save()` |
| `Load` | `static AsiaSoftLicense Load(string filename)` | Deserialize từ file XML qua `Serializer.Load<>()` |

---

### 2. LicenseTerms

**Namespace:** `AsiaLicenseCommon`

Data model chứa thông tin chi tiết của license. `[Serializable]` để binary serialize.

| Property | Type | Mô tả |
|----------|------|-------|
| `CustomerName` | `string` | Tên khách hàng được cấp license |
| `CreatedDate` | `DateTime` | Ngày tạo license |
| `BranchID` | `string` | Mã chi nhánh |
| `StartDate` | `DateTime` | Ngày bắt đầu hiệu lực |
| `EndDate` | `DateTime` | Ngày hết hạn |
| `CreatedComputer` | `string` | Tên máy tạo license |
| `TrialMode` | `bool` | Chế độ dùng thử |

**Constants:**

| Constant | Value | Mô tả |
|----------|-------|-------|
| `DEFAULT_TRIAL_PERIOD` | `90` | Số ngày dùng thử mặc định |
| `TRIAL_PERIOD` | `90` | Property getter, alias của DEFAULT_TRIAL_PERIOD |

**Computed Properties:**

| Property | Type | Logic |
|----------|------|-------|
| `UsedDay` | `int` | Số ngày đã dùng = Today - StartDate (nếu Today < StartDate → trả TRIAL_PERIOD) |
| `RemainindDay` | `int` | Số ngày còn lại = EndDate - Today (nếu ngoài range → trả 0) |

**Methods:**

| Method | Signature | Mô tả |
|--------|-----------|-------|
| `GetLicenseData` | `byte[] GetLicenseData()` | Binary serialize object này thành `byte[]` qua `BinaryFormatter` |
| `FromString` | `static LicenseTerms FromString(string licenseTerm)` | Deserialize từ Base64 string → `LicenseTerms` object |

**Patched version (`LicenseTerms.patched.cs`):**
- Property `CustomerName` getter bị override: nếu `_customerName` không rỗng, trả về `"Công ty TNHH Điệp Xuân;Cty Sản Xuất Điệp Xuân;" + _customerName`
- Mục đích: hardcode tên khách hàng khi hiển thị

---

### 3. RSA

**Namespace:** `AsiaLicenseCommon`

Class chứa logic kiểm tra license hợp lệ và copy file license.

| Member | Type | Giá trị/Mô tả |
|--------|------|---------------|
| `LICENSE_FILE_NAME` | `const string` | `"\\Simba.asialic"` |
| `LicenseTerm` | `static LicenseTerms` | Kết quả license terms sau khi validate thành công |

**Methods:**

| Method | Signature | Mô tả |
|--------|-----------|-------|
| `LicenseIsValid` | `static bool LicenseIsValid()` | **Core validation logic** - xem chi tiết bên dưới |
| `CopyLicenseFile` | `static void CopyLicenseFile(string filePath)` | Copy file license vào `Application.StartupPath\Simba.asialic` |

**Quy trình `LicenseIsValid()` (bản gốc):**

1. Load file `Simba.asialic` từ `Application.StartupPath`
2. Deserialize XML → `AsiaSoftLicense` object
3. Load DSA public key từ `Resources.publicKey`
4. Decode Base64 `LicenseTerms` và `Signature`
5. `DSACryptoServiceProvider.VerifyData(data, signature)` → kiểm tra chữ ký
6. Nếu valid → `LicenseTerms.FromString()` deserialize license data
7. Nếu `TrialMode == true` → tính StartDate từ folder creation time, EndDate = StartDate + 90 ngày
8. Kiểm tra Today nằm trong [StartDate, EndDate]
9. Trả về `true`/`false`

**Patched version (`RSA_Patched.cs`):**
- `LicenseIsValid()` luôn `return true;` - bypass hoàn toàn validation
- Code gốc được comment out để tham khảo

---

### 4. Serializer

**Namespace:** `AsiaLicenseCommon`

Generic XML serializer helper dùng `XmlSerializer`.

| Method | Signature | Mô tả |
|--------|-----------|-------|
| `getSerializer<T>` | `private static XmlSerializer getSerializer<T>()` | Tạo XmlSerializer cho type T |
| `Save<T>` | `void Save(T o, string fileName)` | Serialize object ra file |
| `Save<T>` | `void Save(T o, Stream stream)` | Serialize object ra stream |
| `Save<T>` | `object Save(T o)` | Serialize → trả byte array |
| `Save<T>` | `object Save(T o, Encoding encoding)` | Serialize → trả string theo encoding |
| `Load<T>` | `object Load<T>(Stream stream)` | Deserialize từ stream |
| `Load<T>` | `T Load<T>(FileInfo file)` | Deserialize từ file |
| `Load<T>` | `T Load<T>(byte[] data)` | Deserialize từ byte array |
| `Load<T>` | `T Load<T>(string data)` | Deserialize từ ASCII string |

---

### 5. frmRSAKeyGenerator

**Namespace:** `AsiaLicenseCommon` | **Kế thừa:** `Form`

Windows Form tạo cặp khóa DSA (public/private key).

**Controls:**

| Control | Type | Tên biến | Mô tả |
|---------|------|----------|-------|
| Button | `Button` | `btGenerate` | Nút tạo key pair |
| TextBox | `TextBox` | `txtPublicKey` | Hiển thị public key (multiline, 967x184) |
| TextBox | `TextBox` | `txtPrivateKey` | Hiển thị private key (multiline, 967x184) |
| Label | `Label` | `Label1` | Nhãn "Public Key" |
| Label | `Label` | `Label2` | Nhãn "Private Key" |

**Form size:** 1007 x 538

**Logic `btGenerate_Click`:**
```csharp
DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
txtPublicKey.Text = dsa.ToXmlString(false);   // public key only
txtPrivateKey.Text = dsa.ToXmlString(true);   // include private key
```

---

### 6. Resources

**Namespace:** `AsiaLicenseCommon.My.Resources`

Strongly-typed resource wrapper.

| Property | Type | Mô tả |
|----------|------|-------|
| `publicKey` | `string` | DSA public key XML (embedded trong assembly resources) |

---

## Dependencies

| Assembly | Mục đích |
|----------|----------|
| `Microsoft.VisualBasic` | VB.NET runtime (DateAndTime, Conversions, ProjectData) |
| `System.Xml` | XML serialization |
| `System.Xml.Linq` | LINQ to XML |
| `System.Core` | .NET extensions |
| `System.Security.Cryptography` | DSACryptoServiceProvider cho chữ ký số |
| `System.Windows.Forms` | Form, Application.StartupPath |
| `System.Runtime.Serialization.Formatters.Binary` | BinaryFormatter serialize LicenseTerms |

---

## Luồng License

```
┌─────────────────────────────────────────────────┐
│              LICENSE LIFECYCLE                   │
├─────────────────────────────────────────────────┤
│                                                  │
│  1. CREATE (Developer/Admin)                    │
│     ├─ frmRSAKeyGenerator → tạo DSA key pair    │
│     ├─ Public key embed vào Resources            │
│     └─ Private key giữ để ký license             │
│                                                  │
│  2. GENERATE (Developer/Admin)                   │
│     ├─ Tạo LicenseTerms (customer, dates, etc.)  │
│     ├─ BinarySerialize → Base64                  │
│     ├─ DSA Sign với Private Key                  │
│     ├─ Đóng gói vào AsiaSoftLicense              │
│     └─ XML Serialize → Simba.asialic             │
│                                                  │
│  3. VALIDATE (Client app startup)               │
│     ├─ RSA.LicenseIsValid()                      │
│     ├─ Load Simba.asialic                        │
│     ├─ Verify DSA signature với Public Key       │
│     ├─ Deserialize LicenseTerms                  │
│     ├─ Check TrialMode + date range              │
│     └─ Return true/false                         │
│                                                  │
└─────────────────────────────────────────────────┘
```

---

## Bảo mật

| Aspect | Chi tiết |
|--------|----------|
| Algorithm | DSA (Digital Signature Algorithm) |
| Provider | `DSACryptoServiceProvider` |
| Key storage | Public key nhúng trong assembly Resources |
| License format | Binary serialized LicenseTerms → Base64 → XML |
| License file | `Simba.asialic` tại `Application.StartupPath` |

**Lưu ý:** Module đã bị patch (`RSA_Patched.cs`, `LicenseTerms.patched.cs`) để bypass validation và hardcode thông tin khách hàng.
