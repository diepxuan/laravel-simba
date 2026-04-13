# Báo cáo Phân tích EXE: Simba.exe

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms Application) |
| Ngôn ngữ | C# / VB.NET |
| Framework | .NET Framework 3.5 |
| Output type | Windows Application (WinExe) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | Simba |
| Assembly Title | Simba Accounting |
| Assembly Description | Simba Accounting - Product of AsiaSoft |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © AsiaSoft 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
Simba.exe.dll/
├── Simba.csproj                 # Project file
├── app.config                   # Configuration file
├── app.manifest                 # Application manifest
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── startup.cs                   # Entry point (Main method)
├── frmLogin.cs                  # Login form
├── FrmSimbaMenu.cs              # Main menu form
├── frmSimbaStartup.cs           # Startup form
├── frmT1TreeMenu.cs             # Tree menu type 1
├── frmT2Startup.cs              # Startup type 2
├── frmT3Startup.cs              # Startup type 3
├── ucModuleMenu.cs              # Module menu user control
├── ucCenterMenu.cs              # Center menu user control
├── ucBottomMenu.cs              # Bottom menu user control
├── ucReportMenu.cs              # Report menu user control
├── dcModuleMenu.cs              # Dockable module menu
├── dcCenterMenu.cs              # Dockable center menu
├── dcBottomMenu.cs              # Dockable bottom menu
├── dcReportMenu.cs              # Dockable report menu
├── frmProductAuthentication.cs  # Product authentication
├── frmRegister.cs               # Registration form
├── frmDmdvcsEdit.cs             # Company edit form
├── frmSmVideo.cs                # Video help form
├── MenuInformations.cs          # Menu information class
├── ModuleInformation.cs         # Module information class
├── LinkMenu.cs                  # Link menu class
├── ReportCollection.cs          # Report collection
├── asFlowPanel.cs               # Custom flow panel
├── asPanel.cs                   # Custom panel
└── asModuleButtonAtBottom.cs    # Module button at bottom
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Configuration | Configuration management |
| System.Xml.Linq | LINQ to XML |
| System.Core | .NET Core features |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| Docking | Docking library (../../../../native-apps/ASIA/Docking.dll) |
| AsiaLicenseCommon | License management (../../../../native-apps/ASIA/AsiaLicenseCommon.dll) |
| SiInfomationProduct | Product information (../../../../native-apps/ASIA/SiInfomationProduct.dll) |
| DashBoard | Dashboard module (../../../../native-apps/ASIA/DashBoard.dll) |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports engine |
| CrystalDecisions.Shared | Crystal Reports shared |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `AsiaErp.Framework.Docking`
- `AsiaLicenseCommon`
- `CrystalDecisions.CrystalReports.Engine`
- `CrystalDecisions.Shared`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Entry Point và Startup Flow

### Entry Point

```csharp
[STAThread]
public static void Main()
```

### Luồng khởi động

1. **Load Configuration**: Đọc file `Simba.exe.config`
2. **First Run Check**: Kiểm tra `FirstRun` setting, chạy `AttachData.exe` nếu cần
3. **Product Authentication**: Kiểm tra license qua `frmProductAuthentication`
4. **Login**: Hiển thị `frmLogin` để đăng nhập
5. **Load Data Environment**: Tải cấu hình SI, SO, PO, IN, FA
6. **Load Menu**: Chuyển đến menu chính theo `MENU_TYPE` config

### Menu Types

| Type | Form |
|------|------|
| 1 | `frmT1TreeMenu` - Tree menu |
| 2 | `frmT2Startup` - Startup type 2 |
| 3 | `FrmT3Startup` - Startup type 3 |
| 4/default | `frmSimbaStartup` - Simba startup |

---

## Classes và Components

### Main Forms

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmLogin` | `frmAsiaRoot` | Form đăng nhập hệ thống |
| `FrmSimbaMenu` | `Form` | Form menu chính (Simba style) |
| `frmSimbaStartup` | - | Form khởi động Simba |
| `frmT1TreeMenu` | - | Menu dạng cây |
| `frmT2Startup` | - | Startup type 2 |
| `FrmT3Startup` | - | Startup type 3 |

### User Controls

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `ucModuleMenu` | `UserControl` | Menu module bên trái |
| `ucCenterMenu` | `UserControl` | Menu trung tâm |
| `ucBottomMenu` | `UserControl` | Menu dưới cùng |
| `ucReportMenu` | `UserControl` | Menu báo cáo |

### Dockable Controls

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `dcModuleMenu` | - | Dockable module menu |
| `dcCenterMenu` | - | Dockable center menu |
| `dcBottomMenu` | - | Dockable bottom menu |
| `dcReportMenu` | - | Dockable report menu |

### Data Classes

| Class | Mục đích |
|-------|----------|
| `MenuInformations` | Thông tin menu tổng hợp |
| `MenuInformation` | Thông tin menu |
| `ModuleInformation` | Thông tin module |
| `ReportCollection` | Collection báo cáo |
| `LinkMenu` | Link menu |

---

## Chức năng chính

### 1. Đăng nhập (frmLogin)

- Nhập username/password
- Chọn năm tài chính
- Chọn công ty
- Hỗ trợ đa ngôn ngữ (vi-VN, en-US)
- Nút TeamViewer (`SimbaQS.exe`)
- Mã hóa password (Helper.Encrypted)

### 2. Menu System

**Menu Types:**
- Type 5: Module menu (bên trái)
- Type 3: Top menu buttons
- Type 1: Center menu
- Type 2: Bottom menu
- Type 4: Report menu

**Các menu UI controls:**
- `ucModuleMenu`: Hiển thị module buttons
- `ucCenterMenu`: Hiển thị menu trung tâm
- `ucBottomMenu`: Hiển thị menu dưới
- `ucReportMenu`: Hiển thị báo cáo

### 3. Form Execution

```csharp
ExecuteCommand(MenuInformation mnu, DockPanel dockPanel)
```

- Kiểm tra quyền thực thi (`ChkExecRight`)
- Load DLL động qua `Assembly.Load(dllName)`
- Tạo instance form qua `Activator.CreateInstance`
- Quản lý form lifecycle (cache 15 ngày)

### 4. Multi-language Support

- Config key: `Multi_lang_enabled`
- Config key: `CURRENT_LANG`
- Hỗ trợ: vi-VN, en-US

---

## Các chuỗi Text đáng chú ý

### UI Labels

- "Đăng nhập" / "Login"
- "Tên" / "User Name"
- "Mật khẩu" / "Password"
- "Năm tài chính" / "Finance Year"
- "Công ty" / "Company"
- "Ngôn ngữ" / "Language"
- "Thoát" / "Quit"
- "HDSD" (Hướng dẫn sử dụng)
- "Simba QS" (Quick Support)

### Status Bar

- "CAPS" - Caps Lock indicator
- "NUM" - Num Lock indicator
- "INS" - Insert key indicator
- Current date/time display

### Product Info

- "SIMBA" - Product name
- "Simba.NET 2014" - Window title
- "Nhập thử" - Demo company name

---

## Mục đích sử dụng

**Simba.exe là ứng dụng ERP Desktop chính** của Asia Software Development JSC.

### Chức năng chính

#### 1. Launcher Application
- Quản lý đăng nhập người dùng
- Xác thực license sản phẩm
- Quản lý session và cấu hình

#### 2. Menu Container
- Hiển thị menu động theo quyền user
- Hỗ trợ nhiều kiểu menu (Tree, Tile, Docking)
- Load và quản lý các module DLL

#### 3. Module Integration
- Load các module ERP động qua Reflection
- Quản lý vòng đời form (cache/dispose)
- Tích hợp Crystal Reports

#### 4. Multi-Company Support
- Chọn công ty sau khi đăng nhập
- Quản lý nhiều năm tài chính
- Phân quyền theo user/company

---

## Đặc điểm kỹ thuật

- **Architecture**: WinForms desktop application
- **Data Access**: AsiaErp.DataAccess (DAO pattern)
- **UI Framework**: Custom Asia ERP Framework với Docking support
- **Reporting**: Crystal Reports integration
- **Localization**: Resource-based multi-language
- **Security**: RSA license validation, user authentication
- **Configuration**: App.config với custom sections

---

## Kết luận

Simba.exe là **application launcher và menu container** cho hệ thống ERP Simba Accounting của Asia Software Development JSC. Đây là entry point chính để người dùng đăng nhập, xác thực license, và truy cập các module chức năng của hệ thống ERP.

---

*Ngày phân tích: 2026-03-29*