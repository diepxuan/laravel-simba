# Báo cáo Phân tích DLL: SiInfomationProduct.dll

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
| Assembly Name | SiInfomationProduct |
| Assembly Title | WindowsApplication1 |
| Assembly Company | AsiaHN |
| Assembly Product | WindowsApplication1 |
| Assembly Copyright | Copyright © AsiaHN 2012 |
| Assembly File Version | 1.0.0.0 |
| GUID | e8b67976-75ae-4f31-b656-1bc21e04b1d4 |
| ComVisible | false |

---

## Cấu trúc File

```
SiInfomationProduct.dll/
├── SiInfomationProduct.csproj       # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSiInfomationProduct.cs    # Main form - thông tin sản phẩm
│   └── frmRegister.cs               # Form đăng ký bản quyền
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs             # Application settings
│   ├── MyComputer.cs                # Computer info
│   ├── MySettings.cs                # User settings
│   ├── MySettingsProperty.cs        # Settings property
│   └── MyProject.cs                 # Project helpers
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs                 # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| AsiaLicenseCommon | License management |
| System.Core | Core functionality |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface.My.Resources`
- `AsiaLicenseCommon`
- `System`, `System.Windows.Forms`, `System.Drawing`
- `Microsoft.Win32` (Registry access)
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSiInfomationProduct` | `frmAsiaRoot` | Form hiển thị thông tin sản phẩm và bản quyền |
| `frmRegister` | - | Form đăng ký kích hoạt sản phẩm |

---

## Các trường dữ liệu chính

### Form frmSiInfomationProduct

#### Labels hiển thị thông tin

| Control | Mục đích |
|---------|----------|
| `lblProductName` | Tên sản phẩm |
| `lblProductVersion` | Phiên bản sản phẩm |
| `lblCompanyName` | Tên công ty |
| `lblBuild` | Build number |
| `lblBuildCreateDate` | Ngày tạo build |
| `lblCap_pheh` | Thông tin cấp phép |
| `lblActive` | Trạng thái kích hoạt |
| `lblData` | Thông tin database |
| `lblServer` | Server kết nối |

#### LinkLabels

| Control | Mục đích |
|---------|----------|
| `llbWeb` | Link website sản phẩm (http://www.simba.vn) |
| `lblEmail` | Link email hỗ trợ (info@simba.vn) |
| `llbAsiaSoftWebsite` | Link website AsiaSoft (http://www.asiasoft.com.vn) |
| `llbAsiaSoftEmail` | Link email AsiaSoft (info@asiasoft.com.vn) |
| `lblActive` | Link kích hoạt sản phẩm |

---

## Mục đích sử dụng

**SiInfomationProduct.dll là module hiển thị thông tin sản phẩm và quản lý đăng ký bản quyền** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Hiển thị thông tin sản phẩm
- Tên sản phẩm, phiên bản, build number
- Thông tin công ty phát triển (AsiaHN/AsiaSoft)
- Ngày tạo build
- Thông tin database và server kết nối

#### 2. Quản lý bản quyền (License)
- Hiển thị trạng thái kích hoạt sản phẩm
- Kiểm tra registration key trong Registry
- Sử dụng `AsiaLicenseCommon` để validate license
- Hỗ trợ đăng ký/kích hoạt sản phẩm qua form `frmRegister`

#### 3. Thông tin liên hệ
- Website sản phẩm: www.simba.vn
- Email hỗ trợ: info@simba.vn
- Website công ty: www.asiasoft.com.vn
- Email công ty: info@asiasoft.com.vn

### Đặc điểm kỹ thuật

- Kế thừa từ `frmAsiaRoot` của Framework
- Sử dụng Registry để lưu thông tin đăng ký (`Registry.CurrentUser`)
- Tích hợp `Helper.CryptographyData` cho mã hóa license key
- Sử dụng `LinkLabel` để mở website/email từ form
- Form hiển thị dạng About/Information dialog

### Registry Keys

Module đọc thông tin đăng ký từ Registry:
- `RegSubKeyName`: Tên subkey chứa license info
- `f_sProductKey`: Product key lưu trong registry
- `f_sUserName`: Tên người dùng đăng ký
- `f_isRegisted`: Flag trạng thái đăng ký

---

## Kết luận

Đây là module About/Information của sản phẩm SIMBA ERP, hiển thị thông tin phiên bản, bản quyền và cung cấp chức năng đăng ký kích hoạt phần mềm. Module tích hợp với AsiaLicenseCommon để quản lý license và sử dụng Registry Windows để lưu thông tin đăng ký.

---

*Ngày phân tích: 2026-03-29*
