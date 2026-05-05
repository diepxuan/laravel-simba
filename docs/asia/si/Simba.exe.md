# Simba.exe.dll - Application Entry Point & Menu Container

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Module | Simba (Main Application) |
| Loại | System/Infrastructure (SI) |
| Chức năng | Application launcher, đăng nhập, xác thực license, quản lý menu, điều hướng module |
| Assembly | Simba.exe (WinExe) |
| Namespace | Global, AsiaErp.Framework, AsiaErp.Framework.Docking |
| Entry point | `startup.Main()` |
| Framework | .NET Framework |

## Mô tả

**Simba.exe** là ứng dụng chính của hệ thống ERP Simba Accounting. Đây là entry point, đảm nhận:
1. Xác thực license sản phẩm (RSA)
2. Đăng nhập người dùng
3. Load cấu hình môi trường (SI, SO, PO, IN, FA)
4. Hiển thị menu chính (4 kiểu khác nhau)
5. Điều hướng và load các module DLL động qua Reflection

## Startup Flow

```
1. startup.Main()
   ↓
2. Kiểm tra Simba.exe.config → Nếu FirstRun=1 → Chạy AttachData.exe
   ↓
3. frmProductAuthentication → ProductValid() (RSA license check)
   ↓
4. frmLogin → Login (username/password/company/finance year)
   ↓
5. LoadDataEnvironment(companyName) → Load SI/SO/PO/IN/FA configuration
   ↓
6. LoadMenu() → Hiển thị menu theo MENU_TYPE config
   ↓
7. User click menu → ExecuteCommand() → Load DLL động → Show form
```

## Classes

### startup (Entry Point)

Class chứa phương thức `Main()` - điểm khởi động ứng dụng.

| Method | Mô tả |
|--------|-------|
| `Main()` | Entry point: Config → Auth → Login → LoadMenu |
| `LoadDataEnvironment(companyName)` | Validate license company name + load SI/SO/PO/IN/FA config |
| `LoadMenu()` | Load form menu theo MENU_TYPE (1/2/3/4) |
| `LoadCR()` | Load Crystal Report document (background thread) |
| `ExecuteCommand(mnu, dockPanel)` | Thực thi command: check rights → Load DLL → Create form |
| `CallMyForm(MenuID, oType, dllName, dockPanel)` | Reflection: Assembly.Load → GetType → InvokeMember → Show |

#### Menu Types

| MENU_TYPE | Form Class | Mô tả |
|-----------|------------|-------|
| 1 | `frmT1TreeMenu` | Menu dạng cây |
| 2 | `frmT2Startup` | Startup type 2 |
| 3 | `FrmT3Startup` | Startup type 3 |
| 4 (default) | `frmSimbaStartup` | Simba startup (InitMenu) |

#### ExecuteCommand Logic

```
1. Check command string không rỗng
2. Commons.ChkExecRight(menuid) → Kiểm tra quyền
3. Nếu form=1 → CallMyForm() (load DLL, tạo form, show trong DockPanel)
4. Nếu form!=9 → Process.Start(command) (chạy external process)
```

#### CallMyForm Logic

```
1. Check form đã mở trong Application.OpenForms (cache 15 ngày)
2. Nếu chưa có hoặc đã dispose hoặc quá 15 ngày → Tạo mới:
   a. Assembly.Load(dllName)
   b. assembly.GetType(oType)
   c. type.InvokeMember(CreateInstance, args=[MenuID])
   d. frmAsiaRoot.Show(dockPanel)
3. Nếu đã có → BringToFront()
```

## Forms

### frmLogin - Form đăng nhập

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtUserName` | TextBox | Tên đăng nhập (Uppercase) |
| `txtPassword` | TextBox | Mật khẩu (PasswordChar=*) |
| `cboFinanceYear` | ComboBox | Năm tài chính (Year-5 đến Year+15) |
| `cboComanyName` | ComboBox | Danh sách công ty (load theo user) |
| `cboLanguage` | ComboBox | Ngôn ngữ (vi-VN, en-US, ...) |
| `cmdLogin` | Button | Đăng nhập |
| `cmdQuit` | Button | Thoát |
| `btnTeamviewer` | Button | Mở SimbaQS.exe (remote support) |
| `cmdOption` | Button | Toggle panel option (<<< / >>>) |
| `gbOption` | GroupBox | Panel chứa cboLanguage |
| `panelLogo` | Panel | Logo panel (background image) |
| `PictureBox1` | PictureBox | Login icon |

#### Properties

| Property | Giá trị |
|----------|---------|
| `Text` | "Đăng nhập" / "Login" |
| `FormBorderStyle` | FixedDialog |
| `BackColor` | RGB(254, 236, 217) |
| `MaximizeBox` | false |
| `MinimizeBox` | false |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `OnLoad()` | Setup paths, load languages, populate finance years, trial mode auto-fill |
| `cmdLogin_Click()` | Validate → CheckUser → Load company info → LoadDataEnvironment → Set SystemInformations |
| `CheckUser()` | Gọi `MainDAO.Logon(ma_cty, username, password)` |
| `Valid4GetCompany()` | PreLogon → Load companies cho user |
| `txtUserName_Validated()` | Trigger load company list |
| `cboLanguage_SelectedIndexChanged()` | Change language, reload company list |
| `btnTeamviewer_Click()` | Process.Start("SimbaQS.exe") |

#### Trial Mode

| Condition | Auto-fill |
|-----------|-----------|
| `RSA.LicenseTerm.TrialMode == true` | Username: "ASIA", Password: "admin" |

#### Company Information Loaded

| Field | Source | Stored in |
|-------|--------|-----------|
| TEN_CTY | Company table | CompanyInformations.CompanyName |
| MA_CTY | Company table | CompanyInformations.CompanyID |
| TEN_TCTY | Company table | CompanyInformations.ParentCompanyName |
| Dia_Chi | Company table | CompanyInformations.CompanyAddress |
| Tel | Company table | CompanyInformations.CompanyTel |
| Fax | Company table | CompanyInformations.CompanyFax |
| email | Company table | CompanyInformations.Email |
| ma_thue | Company table | CompanyInformations.Ma_thue |
| ten_nh | Company table | CompanyInformations.BankName |
| so_tk_nh | Company table | CompanyInformations.BankAccount |
| tinh_tp_nh | Company table | CompanyInformations.BankLocation |
| giam_doc | Company table | CompanyInformations.Director_Name |
| ktt | Company table | CompanyInformations.Chief_Accountant_Name |

### FrmSimbaMenu - Menu chính (Simba style)

Form menu chính với docking panel.

| Property | Mô tả |
|----------|-------|
| Kế thừa | Form |
| DockPanel | AsiaErp.Framework.Docking.DockPanel |

### frmT1TreeMenu - Menu dạng cây

Form menu hiển thị dưới dạng TreeView.

### frmT2Startup / FrmT3Startup / frmSimbaStartup

Các biến thể của form startup/menu chính, được chọn theo config `MENU_TYPE`.

## Menu Data Classes

### MenuInformation

| Property | Type | Mô tả |
|----------|------|-------|
| `menuid` | string | Menu ID |
| `bar` | string | Tên hiển thị |
| `command` | string | Command/type |
| `dllName` | string | Tên DLL |
| `form` | object | Form type indicator (1=form, 9=external) |

### ModuleInformation

| Property | Type | Mô tả |
|----------|------|-------|
| `moduleid` | string | Module ID |
| `name` | string | Tên module |

### ReportCollection

Collection quản lý báo cáo.

| Property | Type | Mô tả |
|----------|------|-------|
| Reports | Collection | Danh sách báo cáo |

### LinkMenu

| Property | Type | Mô tả |
|----------|------|-------|
| Menu links | Collection | Liên kết menu |

## Menu UI Controls

### User Controls

| Control | Kế thừa | Mô tả |
|---------|---------|-------|
| `ucModuleMenu` | UserControl | Menu module |
| `ucCenterMenu` | UserControl | Menu trung tâm |
| `ucBottomMenu` | UserControl | Menu dưới cùng |
| `ucReportMenu` | UserControl | Menu báo cáo |

### Dockable Controls

| Control | Mô tả |
|---------|-------|
| `dcModuleMenu` | Dockable module menu |
| `dcCenterMenu` | Dockable center menu |
| `dcBottomMenu` | Dockable bottom menu |
| `dcReportMenu` | Dockable report menu |

### Custom Controls

| Control | Kế thừa | Mô tả |
|---------|---------|-------|
| `asFlowPanel` | Panel | Custom flow panel |
| `asPanel` | Panel | Custom panel |
| `asModuleButtonAtBottom` | Button | Module button hiển thị ở dưới |

## DataAccess

### MainDAO / MsSqlMainDAO

| Method | Tham số | Return | Mô tả |
|--------|---------|--------|-------|
| `Logon` | ma_cty, username, password, ref isAdmin, ref isGrand | bool | Xác thực đăng nhập |
| `PreLogon` | username, password | bool | Pre-validation (load company list) |
| `GetCompanyInfoByUserName` | username | DataTable | Danh sách công ty của user |
| `GetCompanyInfo` | ma_cty | DataTable | Thông tin chi tiết công ty |
| `GetAllLanguage` | - | DataTable | Danh sách ngôn ngữ hỗ trợ |

## SystemInformations (Loaded at Login)

| Property | Set at | Giá trị |
|----------|--------|---------|
| `RootPath` | OnLoad | Application.StartupPath |
| `GraphicPath` | OnLoad | RootPath + "\\Graphics\\" |
| `ReportPath` | OnLoad/AfterLogin | RootPath + "\\Reports\\[lang]\\" |
| `FReportPath` | OnLoad/AfterLogin | RootPath + "\\Reports\\[lang]\\Nt\\" |
| `ResourcesPath` | OnLoad | RootPath + "\\Resx\\" |
| `HelpPath` | OnLoad | RootPath + "\\Helps\\" |
| `VideoHelpPath` | OnLoad | HelpPath + "Videos\\" |
| `UserName` | Login | strUserName |
| `FullName` | Login | strFullName |
| `IsAdmin` | Login | aIsAdmin |
| `FinancialYear` | Login | intFinanceYear |
| `CurrentCultureName` | Login/Option | vi-VN / en-US / ... |

## Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework.dll | Core framework (Environment, Commons, SystemInformations) |
| Helper.dll | Utility functions (encryption, error handling) |
| Docking.dll | DockPanel for form hosting |
| AsiaLicenseCommon.dll | RSA license validation |
| CrystalDecisions.CrystalReports.Engine | Report rendering |
| CrystalDecisions.Shared | Crystal Reports shared components |

## Ghi chú

- **Reflection-based module loading**: Các module DLL được load động tại runtime qua `Assembly.Load()` + `Activator.CreateInstance`
- **Form caching**: Form đã mở được cache trong `Application.OpenForms`, dispose sau 15 ngày không sử dụng
- **Docking architecture**: Forms được hiển thị trong DockPanel, cho phép multiple document interface (MDI)
- **RSA License**: Xác thực license bằng RSA, kiểm tra tên công ty trong `LoadDataEnvironment`
- **Multi-language**: Hỗ trợ vi-VN, en-US và các ngôn ngữ khác, config qua `CURRENT_LANG`
- **Crystal Reports**: Background thread load report `SB.rpt` khi tồn tại
- **Trial mode**: Auto-fill ASIA/admin khi ở chế độ trial
- **TeamViewer support**: Nút SimbaQS.exe để remote support
