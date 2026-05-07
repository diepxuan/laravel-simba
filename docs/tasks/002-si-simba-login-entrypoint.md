# Task #002 - Simba Login & Entry Point

## Header

| Trường | Giá trị |
|--------|---------|
| Task # | 002 |
| DLL name | Simba.exe.dll |
| Module | SI (System Information) |
| Loại | Entry Point |
| Assembly Name | Simba |
| Assembly Title | Simba Accounting |
| Assembly Version | 14.1.0.0 |
| Output type | WinExe (Windows Application) |

---

## 1. Mô tả chức năng

Simba.exe là **application launcher và entry point chính** cho hệ thống ERP Simba Accounting của Asia Software. Đây KHÔNG phải module CRUD thông thường, mà là:

- **Launcher Application**: Quản lý đăng nhập người dùng
- **Product Authentication**: Xác thực license sản phẩm (RSA)
- **Menu Container**: Hiển thị menu động theo quyền user
- **Module Integration**: Load các module ERP động qua Reflection
- **Multi-Company Support**: Chọn công ty, năm tài chính
- **Multi-language Support**: vi-VN, en-US

### Luồng khởi động (Startup Flow)

```
1. Load Configuration (Simba.exe.config)
   ↓
2. First Run Check → AttachData.exe (nếu FirstRun=1)
   ↓
3. Product Authentication (frmProductAuthentication)
   - RSA license validation
   - Nếu không valid → hiển thị form authentication
   - Nếu exit → Application.Exit()
   ↓
4. Login (frmLogin)
   - Nhập username/password
   - Chọn năm tài chính
   - Chọn công ty
   - Mã hóa password (Helper.Encrypted)
   - Nếu fail → Application.Exit()
   ↓
5. Load Data Environment
   - GetSIConfiguration()
   - GetSOConfiguration()
   - GetPOConfiguration()
   - GetINConfiguration()
   - GetFAConfiguration()
   ↓
6. Load Menu (theo MENU_TYPE config)
   - Type 1: frmT1TreeMenu (Tree menu)
   - Type 2: frmT2Startup (Startup type 2)
   - Type 3: FrmT3Startup (Startup type 3)
   - Type 4/default: frmSimbaStartup (Simba startup)
   ↓
7. User chọn module → ExecuteCommand()
   - ChkExecRight(menuid) - kiểm tra quyền
   - Assembly.Load(dllName) - load DLL động
   - Activator.CreateInstance - tạo form
   - Form cache 15 ngày
```

---

## 2. Form Classes

### 2.1 startup (Entry Point)

**Class:** `startup` (StandardModule / sealed)

**Entry Point:**
```csharp
[STAThread]
public static void Main()
```

**Methods:**
| Method | Mô tả |
|--------|-------|
| `Main()` | Entry point chính của ứng dụng |
| `LoadDataEnvironment(companyName)` | Load cấu hình các phân hệ SI, SO, PO, IN, FA. Kiểm tra license company name |
| `LoadMenu()` | Load form menu chính theo MENU_TYPE config |
| `ExecuteCommand(MenuInformation mnu, DockPanel dockPanel)` | Thực thi command: check quyền, load DLL, tạo form |
| `CallMyForm(MenuID, oType, dllName, dockPanel)` | Load form từ DLL qua Reflection, quản lý cache |
| `LoadCR()` | Load Crystal Report document (background thread) |

### 2.2 frmLogin

**Kế thừa:** `frmAsiaRoot`

**Mục đích:** Form đăng nhập hệ thống

**Fields:**
| Field | Type | Mô tả |
|-------|------|-------|
| `f_isOk` | bool | Cờ đăng nhập thành công |
| `strUserName` | string | Tên đăng nhập |
| `strFullName` | string | Họ tên đầy đủ |
| `strCompanyID` | string | Mã công ty |
| `strCompanyName` | string | Tên công ty |
| `strHeadCompanyName` | string | Tên công ty đầu |
| `strAddress` | string | Địa chỉ |
| `strTel` | string | Số điện thoại |
| `strEmail` | string | Email |
| `strFax` | string | Fax |
| `intFinanceYear` | int | Năm tài chính |
| `strPassword` | string | Password (encrypted) |
| `oTblCompany` | DataTable | Bảng danh sách công ty |
| `oTblLanguage` | DataTable | Bảng ngôn ngữ |
| `isLoading` | bool | Cờ đang load |

**Controls:**
| Control | Type | Label | Mô tả |
|---------|------|-------|-------|
| `txtUserName` | TextBox | Tên đăng nhập | Nhập username |
| `txtPassword` | TextBox | Mật khẩu | Nhập password |
| `cboFinanceYear` | ComboBox | Năm tài chính | Chọn năm tài chính |
| `cboComanyName` | ComboBox | Công ty | Chọn công ty |
| `cboLanguage` | ComboBox | Ngôn ngữ | Chọn ngôn ngữ (vi-VN, en-US) |
| `cmdLogin` | Button | Đăng nhập | Thực hiện đăng nhập |
| `cmdQuit` | Button | Thoát | Thoát ứng dụng |
| `btnTeamviewer` | Button | Simba QS | Mở TeamViewer Quick Support |
| `cmdOption` | Button | Tùy chọn | Mở options |
| `gbOption` | GroupBox | Tùy chọn | Groupbox tùy chọn |
| `GroupBox1` | GroupBox | - | Groupbox form login |
| `panelLogo` | Panel | - | Panel logo |
| `PictureBox1` | PictureBox | - | Hiển thị logo |
| `lblUserName` | Label | Tên / User Name | - |
| `lblPassword` | Label | Mật khẩu / Password | - |
| `lblFinanceYear` | Label | Năm tài chính / Finance Year | - |
| `lblCompanyName` | Label | Công ty / Company | - |
| `lblLanguage` | Label | Ngôn ngữ / Language | - |

**Events:**
| Event Handler | Trigger | Mô tả |
|---------------|---------|-------|
| `txtUserName_Validated` | txtUserName, txtPassword validate | Set f_isOk, load dữ liệu |
| `cmdLogin_Click` | Button Login click | Thực hiện đăng nhập |
| `cmdQuit_Click` | Button Quit click | Thoát ứng dụng |
| `btnTeamviewer_Click` | Button Simba QS click | Mở SimbaQS.exe |
| `cmdOption_Click` | Button Option click | Mở form tùy chọn |
| `cboLanguage_SelectedIndexChanged` | Language change | Đổi ngôn ngữ UI |

**Business Logic:**
- Password mã hóa qua `Helper.Encrypted`
- Load danh sách công ty từ database
- Load danh sách năm tài chính
- Load danh sách ngôn ngữ
- Multi-language: vi-VN, en-US (config: `Multi_lang_enabled`, `CURRENT_LANG`)

### 2.3 FrmSimbaMenu

**Kế thừa:** `Form`

**Mục đích:** Form menu chính (Simba style)

**Methods:**
| Method | Mô tả |
|--------|-------|
| `InitMenu()` | Khởi tạo menu |
| `LoadMenuTree()` | Load tree menu |

### 2.4 frmSimbaStartup

**Mục đích:** Form khởi động Simba (default menu type)

**Methods:**
| Method | Mô tả |
|--------|-------|
| `InitMenu()` | Khởi tạo menu |

### 2.5 frmT1TreeMenu

**Mục đích:** Menu dạng cây (Tree menu) - Type 1

### 2.6 frmT2Startup

**Mục đích:** Startup type 2

### 2.7 FrmT3Startup

**Mục đích:** Startup type 3

### 2.8 User Controls

| Class | Kế thừa | Mô tả |
|-------|---------|-------|
| `ucModuleMenu` | UserControl | Menu module bên trái |
| `ucCenterMenu` | UserControl | Menu trung tâm |
| `ucBottomMenu` | UserControl | Menu dưới cùng |
| `ucReportMenu` | UserControl | Menu báo cáo |

### 2.9 Dockable Controls

| Class | Mô tả |
|-------|-------|
| `dcModuleMenu` | Dockable module menu |
| `dcCenterMenu` | Dockable center menu |
| `dcBottomMenu` | Dockable bottom menu |
| `dcReportMenu` | Dockable report menu |

### 2.10 Data Classes

| Class | Mô tả |
|-------|-------|
| `MenuInformations` | Thông tin menu tổng hợp |
| `ModuleInformation` | Thông tin module |
| `LinkMenu` | Link menu |
| `ReportCollection` | Collection báo cáo |
| `ReportCollectionPropertyDescriptor` | Property descriptor |

### 2.11 Custom Controls

| Class | Mô tả |
|-------|-------|
| `asFlowPanel` | Custom flow panel |
| `asPanel` | Custom panel |
| `asModuleButtonAtBottom` | Module button at bottom |

### 2.12 frmProductAuthentication

**Mục đích:** Form xác thực license sản phẩm

**Methods:**
| Method | Mô tả |
|--------|-------|
| `ProductValid()` | Kiểm tra license valid (RSA) |

**Field:**
| Field | Type | Mô tả |
|-------|------|-------|
| `f_isExit` | bool | Cờ thoát ứng dụng |

### 2.13 frmRegister

**Mục đích:** Form đăng ký sản phẩm

### 2.14 frmDmdvcsEdit

**Mục đích:** Form chỉnh sửa đơn vị cơ sở

---

## 3. Data Structures

### 3.1 Bảng asUser (Người dùng)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty |
| Ma_User | nvarchar(20) | NOT NULL | Mã người dùng (PK) |
| Ten_User | nvarchar(100) | NOT NULL | Tên người dùng |
| Password | nvarchar(100) | NOT NULL | Password (encrypted) |
| Active | bit | NULL | Trạng thái hoạt động |
| Admin | bit | NULL | Quyền admin |
| luser | nvarchar(50) | NULL | User cập nhật |
| ldate | datetime | NULL | Ngày cập nhật |

### 3.2 Bảng asCompany (Công ty)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty (PK) |
| Ten_Cty | nvarchar(200) | NOT NULL | Tên công ty |
| Dia_Chi | nvarchar(300) | NULL | Địa chỉ |
| Dien_Thoai | nvarchar(50) | NULL | Điện thoại |
| Email | nvarchar(100) | NULL | Email |
| Fax | nvarchar(50) | NULL | Fax |

### 3.3 Bảng asFinanceYear (Năm tài chính)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty (PK) |
| Nam_TC | int | NOT NULL | Năm tài chính (PK) |
| Bat_Dau | datetime | NOT NULL | Ngày bắt đầu |
| Ket_Thuc | datetime | NOT NULL | Ngày kết thúc |
| Khoa_So | bit | NULL | Khóa sổ |

### 3.4 Bảng asMenu (Menu)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| MenuID | nvarchar(20) | NOT NULL | Mã menu (PK) |
| Ten_Menu | nvarchar(100) | NOT NULL | Tên menu |
| Menu_Type | int | NULL | Loại menu |
| Parent_ID | nvarchar(20) | NULL | Menu cha |
| DLL_Name | nvarchar(100) | NULL | Tên DLL |
| Form_Name | nvarchar(100) | NULL | Tên form |
| Command | nvarchar(200) | NULL | Command |
| Image_Name | nvarchar(50) | NULL | Tên icon |
| Sort_Order | int | NULL | Thứ tự sắp xếp |

### 3.5 Bảng asUserRight (Phân quyền user)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty (PK) |
| Ma_User | nvarchar(20) | NOT NULL | Mã user (PK) |
| MenuID | nvarchar(20) | NOT NULL | Mã menu (PK) |
| Exec_Right | bit | NULL | Quyền thực thi |

---

## 4. Stored Procedures

### 4.1 Login & Authentication

| SP | Type | Parameters | Mô tả |
|----|------|-----------|-------|
| `asGetUserInfo` | SELECT | @pMa_Cty, @pMa_User | Lấy thông tin user |
| `asGetCompanyList` | SELECT | - | Lấy danh sách công ty |
| `asGetFinanceYear` | SELECT | @pMa_Cty | Lấy năm tài chính của công ty |
| `asGetMenuList` | SELECT | @pMa_Cty, @pMa_User | Lấy menu theo quyền user |
| `asChkUserRight` | SELECT | @pMa_Cty, @pMa_User, @pMenuID | Kiểm tra quyền user |

### 4.2 Configuration

| SP | Type | Parameters | Mô tả |
|----|------|-----------|-------|
| `asGetSIConfiguration` | SELECT | @pMa_Cty | Cấu hình phân hệ SI |
| `asGetSOConfiguration` | SELECT | @pMa_Cty | Cấu hình phân hệ SO |
| `asGetPOConfiguration` | SELECT | @pMa_Cty | Cấu hình phân hệ PO |
| `asGetINConfiguration` | SELECT | @pMa_Cty | Cấu hình phân hệ IN |
| `asGetFAConfiguration` | SELECT | @pMa_Cty | Cấu hình phân hệ FA |

---

## 5. Business Logic

### 5.1 Login Flow

1. User nhập username + password
2. Password được mã hóa qua `Helper.Encrypted`
3. Kiểm tra user tồn tại trong asUser
4. Kiểm tra Active = 1
5. Load danh sách công ty → User chọn công ty
6. Load danh sách năm tài chính → User chọn năm
7. Load cấu hình environment (SI, SO, PO, IN, FA)
8. Load menu theo quyền user
9. Chuyển đến menu chính (theo MENU_TYPE)

### 5.2 Module Execution (ExecuteCommand)

```csharp
ExecuteCommand(MenuInformation mnu, DockPanel dockPanel):
    1. Kiểm tra ChkExecRight(mnu.menuid)
       - Nếu không có quyền → CMessageBox.Show(50005)
    2. Nếu form == "1":
       - CallMyForm(mnu.menuid, mnu.command, mnu.dllName, dockPanel)
    3. Nếu form != "9":
       - Process.Start(mnu.command)  // external process
```

```csharp
CallMyForm(MenuID, oType, dllName, dockPanel):
    1. Kiểm tra form đã mở chưa (Application.OpenForms)
    2. Kiểm tra cache (15 ngày từ LastModifiedDate)
    3. Nếu hết cache hoặc không tồn tại:
       - Assembly.Load(dllName)  // load DLL
       - type.InvokeMember(..., CreateInstance, ...)  // tạo form
       - form.Show(dockPanel)
       - form.LastModifiedDate = Now
    4. Nếu tồn tại và còn cache:
       - BringToFront()
```

### 5.3 License Validation

- RSA license kiểm tra qua `RSA.LicenseTerm.CustomerName`
- So sánh company name với license
- Nếu không match → CMessageBox.ShowWithFormat(50205, companyName)

### 5.4 Multi-language

- Config: `Multi_lang_enabled`, `CURRENT_LANG`
- Supported: vi-VN, en-US
- CultureInfo áp dụng khi tạo form

---

## 6. Mapping PHP

### 6.1 Model: AsUser.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class AsUser extends Model
{
    protected $table = 'asUser';
    protected $primaryKey = ['Ma_Cty', 'Ma_User'];
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Ma_User', 'Ten_User', 'Password', 'Active', 'Admin', 'luser', 'ldate',
    ];

    protected $casts = [
        'Active' => 'boolean',
        'Admin' => 'boolean',
        'ldate' => 'datetime',
    ];

    public function companies()
    {
        return $this->belongsToMany(AsCompany::class, 'asUserCompany', 'Ma_User', 'Ma_Cty');
    }
}
```

### 6.2 Model: AsCompany.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class AsCompany extends Model
{
    protected $table = 'asCompany';
    protected $primaryKey = 'Ma_Cty';
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Ten_Cty', 'Dia_Chi', 'Dien_Thoai', 'Email', 'Fax',
    ];
}
```

### 6.3 Model: AsFinanceYear.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class AsFinanceYear extends Model
{
    protected $table = 'asFinanceYear';
    protected $primaryKey = ['Ma_Cty', 'Nam_TC'];
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Nam_TC', 'Bat_Dau', 'Ket_Thuc', 'Khoa_So',
    ];

    protected $casts = [
        'Nam_TC' => 'integer',
        'Bat_Dau' => 'datetime',
        'Ket_Thuc' => 'datetime',
        'Khoa_So' => 'boolean',
    ];
}
```

### 6.4 Model: AsMenu.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class AsMenu extends Model
{
    protected $table = 'asMenu';
    protected $primaryKey = 'MenuID';
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'MenuID', 'Ten_Menu', 'Menu_Type', 'Parent_ID',
        'DLL_Name', 'Form_Name', 'Command', 'Image_Name', 'Sort_Order',
    ];

    protected $casts = [
        'Menu_Type' => 'integer',
        'Sort_Order' => 'integer',
    ];

    public function parent()
    {
        return $this->belongsTo(AsMenu::class, 'Parent_ID', 'MenuID');
    }

    public function children()
    {
        return $this->hasMany(AsMenu::class, 'Parent_ID', 'MenuID');
    }
}
```

### 6.5 Model: AsUserRight.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class AsUserRight extends Model
{
    protected $table = 'asUserRight';
    protected $primaryKey = ['Ma_Cty', 'Ma_User', 'MenuID'];
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Ma_User', 'MenuID', 'Exec_Right',
    ];

    protected $casts = [
        'Exec_Right' => 'boolean',
    ];
}
```

### 6.6 Stored Procedure Classes

```php
<?php

namespace App\Services\StoredProcedure;

use Illuminate\Support\Facades\DB;

class SimbaAuthSp
{
    public static function getUserInfo(string $maCty, string $maUser): ?object
    {
        $result = DB::select('EXEC asGetUserInfo ?, ?', [$maCty, $maUser]);
        return $result[0] ?? null;
    }

    public static function getCompanyList(): array
    {
        return DB::select('EXEC asGetCompanyList');
    }

    public static function getFinanceYears(string $maCty): array
    {
        return DB::select('EXEC asGetFinanceYear ?', [$maCty]);
    }

    public static function getMenuList(string $maCty, string $maUser): array
    {
        return DB::select('EXEC asGetMenuList ?, ?', [$maCty, $maUser]);
    }

    public static function chkUserRight(string $maCty, string $maUser, string $menuId): bool
    {
        $result = DB::select('EXEC asChkUserRight ?, ?, ?', [$maCty, $maUser, $menuId]);
        return !empty($result);
    }

    public static function getSIConfiguration(string $maCty): ?object
    {
        $result = DB::select('EXEC asGetSIConfiguration ?', [$maCty]);
        return $result[0] ?? null;
    }

    public static function getSOConfiguration(string $maCty): ?object
    {
        $result = DB::select('EXEC asGetSOConfiguration ?', [$maCty]);
        return $result[0] ?? null;
    }

    public static function getPOConfiguration(string $maCty): ?object
    {
        $result = DB::select('EXEC asPOConfiguration ?', [$maCty]);
        return $result[0] ?? null;
    }

    public static function getINConfiguration(string $maCty): ?object
    {
        $result = DB::select('EXEC asGetINConfiguration ?', [$maCty]);
        return $result[0] ?? null;
    }

    public static function getFAConfiguration(string $maCty): ?object
    {
        $result = DB::select('EXEC asGetFAConfiguration ?', [$maCty]);
        return $result[0] ?? null;
    }
}
```

### 6.7 Livewire Component: SimbaLogin

```php
<?php

namespace App\Livewire\Auth;

use Livewire\Component;
use App\Services\StoredProcedure\SimbaAuthSp;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Session;

class SimbaLogin extends Component
{
    public string $username = '';
    public string $password = '';
    public string $selectedCompany = '';
    public int $selectedYear = 0;
    public string $language = 'vi-VN';

    public array $companies = [];
    public array $financeYears = [];

    public string $error = '';

    protected $rules = [
        'username' => 'required|string|max:20',
        'password' => 'required|string',
        'selectedCompany' => 'required|string',
        'selectedYear' => 'required|integer',
    ];

    public function mount(): void
    {
        $this->companies = SimbaAuthSp::getCompanyList();
        if (!empty($this->companies)) {
            $this->selectedCompany = $this->companies[0]->Ma_Cty;
            $this->loadFinanceYears();
        }
    }

    public function loadFinanceYears(): void
    {
        if ($this->selectedCompany) {
            $this->financeYears = SimbaAuthSp::getFinanceYears($this->selectedCompany);
            if (!empty($this->financeYears)) {
                $this->selectedYear = $this->financeYears[0]->Nam_TC;
            }
        }
    }

    public function login(): void
    {
        $this->validate();

        $user = SimbaAuthSp::getUserInfo($this->selectedCompany, $this->username);

        if (!$user) {
            $this->error = 'Sai tên đăng nhập hoặc mật khẩu';
            return;
        }

        // Simba encrypts passwords - in PHP we can use bcrypt and store comparison
        // The original uses Helper.Encrypted - need to replicate or adapt
        if (!password_verify($this->password, $user->Password)) {
            $this->error = 'Sai tên đăng nhập hoặc mật khẩu';
            return;
        }

        if (!($user->Active ?? false)) {
            $this->error = 'Tài khoản đã bị khóa';
            return;
        }

        // Save session
        Session::put('user_id', $user->Ma_User);
        Session::put('user_name', $user->Ten_User);
        Session::put('company_id', $this->selectedCompany);
        Session::put('finance_year', $this->selectedYear);
        Session::put('language', $this->language);

        // Load configurations
        $this->loadConfigurations();

        // Redirect to dashboard
        $this->redirect(route('dashboard'));
    }

    private function loadConfigurations(): void
    {
        SimbaAuthSp::getSIConfiguration($this->selectedCompany);
        SimbaAuthSp::getSOConfiguration($this->selectedCompany);
        SimbaAuthSp::getPOConfiguration($this->selectedCompany);
        SimbaAuthSp::getINConfiguration($this->selectedCompany);
        SimbaAuthSp::getFAConfiguration($this->selectedCompany);
    }

    public function render()
    {
        return view('livewire.auth.simba-login');
    }
}
```

### 6.8 Livewire Component: SimbaDashboard

```php
<?php

namespace App\Livewire;

use Livewire\Component;
use App\Services\StoredProcedure\SimbaAuthSp;
use Illuminate\Support\Facades\Session;

class SimbaDashboard extends Component
{
    public array $menuTree = [];
    public string $currentMenu = '';

    public function mount(): void
    {
        $userId = Session::get('user_id');
        $companyId = Session::get('company_id');

        if (!$userId || !$companyId) {
            $this->redirect(route('login'));
            return;
        }

        $this->menuTree = $this->buildMenuTree(
            SimbaAuthSp::getMenuList($companyId, $userId)
        );
    }

    private function buildMenuTree(array $flatMenu): array
    {
        $tree = [];
        $indexed = [];

        foreach ($flatMenu as $item) {
            $item->children = [];
            $indexed[$item->MenuID] = $item;
        }

        foreach ($indexed as $id => $item) {
            if ($item->Parent_ID && isset($indexed[$item->Parent_ID])) {
                $indexed[$item->Parent_ID]->children[] = $item;
            } else {
                $tree[] = $item;
            }
        }

        return $tree;
    }

    public function executeMenu(string $menuId, string $dllName, string $formName, string $command): void
    {
        $companyId = Session::get('company_id');
        $userId = Session::get('user_id');

        if (!SimbaAuthSp::chkUserRight($companyId, $userId, $menuId)) {
            $this->dispatch('error', message: 'Bạn không có quyền truy cập chức năng này');
            return;
        }

        // For web: redirect to appropriate route
        // For desktop: load DLL via reflection (original behavior)
        $this->currentMenu = $menuId;
        $this->dispatch('menu-selected', menuId: $menuId, dll: $dllName, form: $formName, command: $command);
    }

    public function render()
    {
        return view('livewire.simba-dashboard');
    }
}
```

### 6.9 View: simba-login.blade.php

```blade
<div class="min-h-screen flex items-center justify-center bg-gradient-to-br from-blue-500 to-indigo-600">
    <div class="bg-white rounded-lg shadow-xl p-8 w-full max-w-md">
        {{-- Logo --}}
        <div class="text-center mb-6">
            <h1 class="text-2xl font-bold text-indigo-600">SIMBA</h1>
            <p class="text-gray-500 text-sm">Simba.NET Accounting</p>
        </div>

        @if($error)
        <div class="bg-red-50 border border-red-200 text-red-700 px-4 py-2 rounded mb-4">
            {{ $error }}
        </div>
        @endif

        <form wire:submit="login">
            {{-- Username --}}
            <div class="mb-4">
                <label class="block text-sm font-medium text-gray-700 mb-1">
                    Tên đăng nhập / User Name
                </label>
                <input type="text" wire:model="username"
                       class="w-full border rounded-lg px-3 py-2 focus:ring-2 focus:ring-indigo-500">
            </div>

            {{-- Password --}}
            <div class="mb-4">
                <label class="block text-sm font-medium text-gray-700 mb-1">
                    Mật khẩu / Password
                </label>
                <input type="password" wire:model="password"
                       class="w-full border rounded-lg px-3 py-2 focus:ring-2 focus:ring-indigo-500">
            </div>

            {{-- Company --}}
            <div class="mb-4">
                <label class="block text-sm font-medium text-gray-700 mb-1">
                    Công ty / Company
                </label>
                <select wire:model.live="selectedCompany" wire:change="loadFinanceYears"
                        class="w-full border rounded-lg px-3 py-2">
                    @foreach($companies as $company)
                    <option value="{{ $company->Ma_Cty }}">{{ $company->Ten_Cty }}</option>
                    @endforeach
                </select>
            </div>

            {{-- Finance Year --}}
            <div class="mb-4">
                <label class="block text-sm font-medium text-gray-700 mb-1">
                    Năm tài chính / Finance Year
                </label>
                <select wire:model="selectedYear"
                        class="w-full border rounded-lg px-3 py-2">
                    @foreach($financeYears as $fy)
                    <option value="{{ $fy->Nam_TC }}">{{ $fy->Nam_TC }}</option>
                    @endforeach
                </select>
            </div>

            {{-- Language --}}
            <div class="mb-6">
                <label class="block text-sm font-medium text-gray-700 mb-1">
                    Ngôn ngữ / Language
                </label>
                <select wire:model="language"
                        class="w-full border rounded-lg px-3 py-2">
                    <option value="vi-VN">Tiếng Việt</option>
                    <option value="en-US">English</option>
                </select>
            </div>

            {{-- Buttons --}}
            <div class="flex gap-3">
                <button type="submit" class="flex-1 bg-indigo-600 text-white rounded-lg px-4 py-2 hover:bg-indigo-700">
                    Đăng nhập / Login
                </button>
                <button type="button" class="bg-gray-300 text-gray-700 rounded-lg px-4 py-2 hover:bg-gray-400">
                    Thoát / Quit
                </button>
            </div>
        </form>
    </div>
</div>
```

### 6.10 View: simba-dashboard.blade.php

```blade
<div class="flex h-screen">
    {{-- Sidebar Menu --}}
    <div class="w-64 bg-gray-800 text-white overflow-y-auto">
        <div class="p-4 border-b border-gray-700">
            <h2 class="text-lg font-bold">SIMBA ERP</h2>
            <p class="text-xs text-gray-400">
                {{ session('user_name') }} - {{ session('company_id') }}
            </p>
        </div>

        <nav class="p-2">
            @foreach($menuTree as $menu)
            <div class="mb-1">
                <button wire:click="executeMenu('{{ $menu->MenuID }}', '{{ $menu->DLL_Name }}', '{{ $menu->Form_Name }}', '{{ $menu->Command }}')"
                        class="w-full text-left px-3 py-2 rounded hover:bg-gray-700 text-sm">
                    {{ $menu->Ten_Menu }}
                </button>

                @if(!empty($menu->children))
                <div class="ml-4">
                    @foreach($menu->children as $child)
                    <button wire:click="executeMenu('{{ $child->MenuID }}', '{{ $child->DLL_Name }}', '{{ $child->Form_Name }}', '{{ $child->Command }}')"
                            class="w-full text-left px-3 py-1.5 rounded hover:bg-gray-700 text-xs text-gray-300">
                        {{ $child->Ten_Menu }}
                    </button>
                    @endforeach
                </div>
                @endif
            </div>
            @endforeach
        </nav>
    </div>

    {{-- Main Content --}}
    <div class="flex-1 overflow-y-auto bg-gray-100">
        {{-- Top Bar --}}
        <div class="bg-white shadow px-4 py-2 flex justify-between items-center">
            <span class="text-sm text-gray-600">
                Năm TC: {{ session('finance_year') }} |
                Ngôn ngữ: {{ session('language') === 'vi-VN' ? 'Tiếng Việt' : 'English' }}
            </span>
            <form method="POST" action="{{ route('logout') }}">
                @csrf
                <button type="submit" class="text-sm text-red-600 hover:text-red-800">
                    Đăng xuất
                </button>
            </form>
        </div>

        {{-- Content Area --}}
        <div class="p-6">
            <div id="module-content">
                {{-- Dynamic module content loads here --}}
                <div class="text-center text-gray-500 mt-20">
                    <p class="text-xl">Chọn chức năng từ menu bên trái</p>
                </div>
            </div>
        </div>
    </div>
</div>

@script
<script>
    $wire.on('menu-selected', (event) => {
        // Load module content dynamically
        // In web context: make AJAX/fetch request to load module
        console.log('Menu selected:', event);
    });

    $wire.on('error', (event) => {
        alert(event.message);
    });
</script>
@endscript
```

### 6.11 Routes

```php
// routes/web.php
use App\Livewire\Auth\SimbaLogin;
use App\Livewire\SimbaDashboard;

Route::middleware(['guest'])->group(function () {
    Route::get('/login', SimbaLogin::class)->name('login');
});

Route::middleware(['auth'])->group(function () {
    Route::get('/dashboard', SimbaDashboard::class)->name('dashboard');
    Route::post('/logout', function () {
        Session::flush();
        return redirect()->route('login');
    })->name('logout');
});
```

### 6.12 Middleware: CheckExecRight

```php
<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Session;
use App\Services\StoredProcedure\SimbaAuthSp;

class CheckExecRight
{
    public function handle(Request $request, Closure $next, string $menuId)
    {
        $companyId = Session::get('company_id');
        $userId = Session::get('user_id');

        if (!$companyId || !$userId) {
            abort(401, 'Unauthorized');
        }

        if (!SimbaAuthSp::chkUserRight($companyId, $userId, $menuId)) {
            abort(403, 'Bạn không có quyền truy cập chức năng này');
        }

        return $next($request);
    }
}
```

---

## 7. Dependencies

| Dependency | Type | Mô tả |
|-----------|------|-------|
| Framework.dll | External | AsiaErp.Framework (frmAsiaRoot, Commons, Environment) |
| Helper.dll | External | AsiaErp.Helper (Encrypted, ProcessError) |
| Docking.dll | External | WeifenLuo DockPanel Suite |
| AsiaLicenseCommon.dll | External | RSA license validation |
| CrystalDecisions | External | Crystal Reports engine |
| Microsoft.VisualBasic | External | VB runtime support |
| asUser | Table | Bảng người dùng |
| asCompany | Table | Bảng công ty |
| asFinanceYear | Table | Bảng năm tài chính |
| asMenu | Table | Bảng menu |
| asUserRight | Table | Bảng phân quyền |

---

## 8. Progress Checklist

### C# Decompiled
- [x] startup.cs (Entry point)
- [x] frmLogin.cs (Login form)
- [x] FrmSimbaMenu.cs (Main menu)
- [x] README.md phân tích
- [ ] Các form menu khác (frmT1TreeMenu, frmT2Startup, FrmT3Startup)
- [ ] User controls (ucModuleMenu, ucCenterMenu, etc.)
- [ ] Dockable controls

### PHP Implementation
- [ ] Models (AsUser, AsCompany, AsFinanceYear, AsMenu, AsUserRight)
- [ ] Stored Procedure classes (SimbaAuthSp)
- [ ] Livewire components (SimbaLogin, SimbaDashboard)
- [ ] Views (simba-login.blade.php, simba-dashboard.blade.php)
- [ ] Routes
- [ ] Middleware (CheckExecRight)

### Database
- [ ] Kiểm tra/đảm bảo bảng asUser tồn tại
- [ ] Kiểm tra/đảm bảo bảng asCompany tồn tại
- [ ] Kiểm tra/đảm bảo bảng asFinanceYear tồn tại
- [ ] Kiểm tra/đảm bảo bảng asMenu tồn tại
- [ ] Kiểm tra/đảm bảo bảng asUserRight tồn tại
- [ ] Kiểm tra Stored Procedures

### Testing
- [ ] Test login flow
- [ ] Test company selection
- [ ] Test finance year selection
- [ ] Test menu loading theo quyền
- [ ] Test module execution (ChkExecRight)
