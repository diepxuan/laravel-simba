# Báo cáo Phân tích DLL: SMUserInfo.dll

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
| Assembly Name | SMUserInfo |
| Assembly Title | Quản lý người dùng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © asiasoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | adafc774-eb1e-4420-a987-3a60df54e3cf |
| ComVisible | false |

---

## Cấu trúc File

```
SMUserInfo.dll/
├── SMUserInfo.csproj            # Project file
├── app.ico                      # Application icon
├── Resources.resx               # Resource file
├── ucSmSetRightsCompany.cs      # User control phân quyền công ty
├── ucSmSetRightsDash.cs         # User control phân quyền dashboard
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MyApplication.cs         # Application settings
│   ├── MyComputer.cs            # Computer info wrapper
│   ├── MyProject.cs             # Project-wide utilities
│   ├── MySettings.cs            # Application settings
│   └── MySettingsProperty.cs    # Settings property wrapper
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.DataAccess/
│   ├── SMUserInfoDAO.cs         # Data access interface
│   └── MsSqlSMUserInfoDAO.cs    # SQL Server implementation
├── AsiaErp.UserInterface/
│   ├── frmSMUserInfo.cs         # Form danh sách người dùng
│   ├── frmSMUserInfoEdit.cs     # Form thêm/sửa người dùng
│   ├── frmSMUserChangePassword.cs  # Form đổi mật khẩu
│   ├── frmSMUserResetPassword.cs   # Form reset mật khẩu
│   ├── frmSmSetRights.cs        # Form phân quyền chức năng
│   └── frmSmSetRightsCompany.cs # Form phân quyền công ty
└── DTE.Bussiness/
    ├── SMUserInfoController.cs  # Business logic controller
    └── UserInfo.cs              # User entity class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Core | Core .NET functionality |
| System.Data | Data access |
| System.Data.DataSetExtensions | DataSet extensions |
| Framework | Asia ERP Framework (../../../../projects/SimbaSql/native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `DTE.Bussiness`
- `My.Resources`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

### Business Layer (DTE.Bussiness)

| Class | Mục đích |
|-------|----------|
| `SMUserInfoController` | Controller xử lý business logic cho quản lý người dùng |
| `UserInfo` | Entity class đại diện cho thông tin người dùng |

### Data Access Layer (AsiaErp.DataAccess)

| Class | Interface | Mục đích |
|-------|-----------|----------|
| `SMUserInfoDAO` | Interface | Định nghĩa interface truy xuất dữ liệu người dùng |
| `MsSqlSMUserInfoDAO` | `SMUserInfoDAO`, `MsSqlDAO` | Implementation SQL Server |

### User Interface Layer (AsiaErp.UserInterface)

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSMUserInfo` | `frmAsiaRoot` | Form danh sách và quản lý người dùng |
| `frmSMUserInfoEdit` | `frmAsiaRoot` | Form thêm mới/sửa thông tin người dùng |
| `frmSMUserChangePassword` | `frmAsiaRoot` | Form đổi mật khẩu người dùng |
| `frmSMUserResetPassword` | `frmAsiaRoot` | Form reset mật khẩu (admin) |
| `frmSmSetRights` | `frmAsiaRoot` | Form phân quyền chức năng cho người dùng |
| `frmSmSetRightsCompany` | `frmAsiaRoot` | Form phân quyền truy cập công ty |

### User Controls

| Class | Mục đích |
|-------|----------|
| `ucSmSetRightsCompany` | User control chọn công ty để phân quyền |
| `ucSmSetRightsDash` | User control phân quyền dashboard |

---

## UserInfo Entity

### Properties

| Property | Type | Mô tả |
|----------|------|-------|
| `username` | string | Tên đăng nhập (PK) |
| `fullname` | string | Tên đầy đủ |
| `password` | string | Mật khẩu (encrypted) |
| `isadmin` | object | Flag quản trị viên |
| `notactive` | object | Flag vô hiệu hóa |
| `grand` | object | Flag quyền admin cao cấp |
| `accesscompanies` | string | Danh sách công ty được truy cập |
| `cuser` | string | User tạo |
| `luser` | string | User cập nhật cuối |
| `cdate` | DateTime | Ngày tạo |
| `ldate` | DateTime | Ngày cập nhật cuối |

---

## SMUserInfoController Methods

### CRUD Operations

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `GetUserInfo` | Lấy danh sách người dùng | - | `DataTable` |
| `GetUserInfoByUserName` | Lấy thông tin user theo username | `aUserName` (string) | `UserInfo` |
| `InsertUserInfo` | Thêm người dùng mới | UserName, FullName, Password, IsAdmin, Grand, Disabled, User | `int` (0 = success) |
| `UpdateUserInfo` | Cập nhật thông tin user | UserName, FullName, IsAdmin, Grand, Disabled, User | `bool` |
| `DeleteUserInfo` | Xóa người dùng | UserName (string) | `bool` |

### Password Management

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `ChangePassword` | Đổi mật khẩu | `aUserName`, `aNew_pass` | `bool` |
| `ResetPassword` | Reset mật khẩu (admin) | UserName, Password, User | `int` |

### Group Management

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `GetGroupInfo` | Lấy danh sách nhóm | - | `DataSet` |
| `GetUserGroup` | Lấy nhóm của user | `UserName` (string) | `DataSet` |
| `InsertUserGroup` | Thêm user vào nhóm | GroupName, UserName, pDel | `int` |
| `DeleteUserGroup` | Xóa user khỏi nhóm | UserName (string) | `int` |

### Rights Management

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `GetMenuForm` | Lấy danh sách menu form | - | `DataTable` |
| `GetMenuBar` | Lấy danh sách menu bar | - | `DataTable` |
| `GetSubMenuBar` | Lấy danh sách sub menu bar | - | `DataTable` |
| `GetAllUserRights` | Lấy tất cả quyền của user | `UserName` (string) | `DataTable` |
| `InsertUserRight` | Thêm quyền cho user | UserName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight, LimitedPrint | `int` |
| `UpdateUserRight` | Cập nhật quyền user | UserName, UserName_Old | `int` |
| `DeleteUserRight` | Xóa quyền của user | UserName, MenuID (optional) | `int` |

### Company Rights Management

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `GetAllRightCompany` | Lấy quyền truy cập công ty | `UserName` (string) | `DataTable` |
| `InsRightCompany` | Thêm quyền công ty | Ma_cty, UserName, active | `int` (0 = success) |

### Dashboard Rights

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `GetAllUserRightDash` | Lấy quyền dashboard | `UserName` (string) | `DataTable` |

### Dynamic Operations

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `DynInsertUpdateDeleteData` | Thực thi dynamic SQL qua XML | pXmlData, pTableName, pMode, pKeyColumns | `int` |

---

## frmSMUserInfo Form

### Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `dgvDM` | AsDataGridView | Hiển thị danh sách người dùng |
| `UserName` | DataGridViewTextBoxColumn | Cột tên đăng nhập |
| `FullName` | DataGridViewTextBoxColumn | Cột tên đầy đủ |
| `isAdmin` | DataGridViewCheckBoxColumn | Cột flag admin |
| `notactive` | DataGridViewCheckBoxColumn | Cột flag vô hiệu hóa |
| `cmdAdd` | Button | Thêm mới (F5) |
| `cmdEdit` | Button | Sửa (F6) |
| `cmdDel` | Button | Xóa (F9) |
| `cmdSetRight` | SplitButton | Phân quyền chức năng |
| `btnResetPass` | Button | Reset mật khẩu |
| `cmdClose` | Button | Đóng form |
| `bsDanhMuc` | BindingSource | Binding data cho grid |

### DataGridView Columns

| Column | DataPropertyName | HeaderText | Width |
|--------|------------------|------------|-------|
| UserName | username | Tên đăng nhập | 150 |
| FullName | fullname | Tên đầy đủ | 300 |
| isAdmin | isAdmin | Là quản trị | CheckBox |
| notactive | disabled | Không sử dụng | CheckBox |

### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| `cmdAdd_Click` | `cmdAdd_Click` | Mở form thêm mới user |
| `cmdEdit_Click` | `cmdEdit_Click` | Mở form sửa user |
| `cmdDel_Click` | `cmdDel_Click` | Xóa user (có xác nhận) |
| `cmdSetRight_Click` | `cmdSetRight_Click` | Mở form phân quyền |
| `btnResetPass_Click` | `btnResetPass_Click` | Mở form reset mật khẩu |
| `cmdClose_Click` | `cmdClose_Click` | Đóng form |
| `frmDMView_Load` | `frmDMView_Load` | Load data và check rights |
| `ProcessCmdKey` | Override | Xử lý phím tắt (F5, F6, F9, Esc) |

### Business Logic

**GetData:**
- Gọi `MyController.GetUserInfo()` để lấy danh sách user
- Thiết lập PrimaryKey cho DataTable (UserName)
- Thiết lập default values cho các cột

**AddNew:**
- Mở `frmSMUserInfoEdit` với EditMode = false
- Tạo DataRow mới và add vào DataTable
- Bind data row vào form edit
- Accept/Reject changes dựa trên kết quả

**Edit:**
- Mở `frmSMUserInfoEdit` với EditMode = true
- Load thông tin user từ row hiện tại
- Accept/Reject changes dựa trên kết quả

**Delete:**
- Hiển thị confirmation dialog (message ID: 50003)
- Gọi `MyController.DeleteUserInfo()`
- Xóa row và accept changes nếu thành công

**Check Rights:**
- `f_blnViewRight`, `f_blnInsertRight`, `f_blnUpdateRight`, `f_blnDeleteRight`
- Được load từ `Commons.GetRights()` khi form load
- Kiểm tra trước khi thực hiện CRUD operations

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

| Text | Ý nghĩa |
|------|---------|
| "Tên đăng nhập" | Column header cho username |
| "Tên đầy đủ" | Column header cho fullname |
| "Là quản trị" | Column header cho isAdmin |
| "Không sử dụng" | Column header cho disabled |
| "&Phân quyền" | Button phân quyền chức năng |
| "Đặt &lại mật khẩu" | Button reset password |
| "&Mới" | Button thêm mới (F5) |
| "&Sửa" | Button sửa (F6) |
| "&Xoá" | Button xóa (F9) |
| "T&hoát" | Button thoát |

### Message IDs

| ID | Ngữ cảnh |
|----|----------|
| 50003 | Xác nhận xóa |
| 50005 | Không có quyền thực hiện |
| 50010 | Lỗi thao tác |
| 50106 | Lỗi DAO không tồn tại |

---

## Mục đích sử dụng

**SMUserInfo.dll là module quản lý người dùng và phân quyền** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Quản lý thông tin người dùng
- Thêm, sửa, xóa tài khoản người dùng
- Quản lý thông tin: username, fullname, password, admin flag
- Kích hoạt/vô hiệu hóa tài khoản

#### 2. Quản lý mật khẩu
- Đổi mật khẩu (người dùng tự đổi)
- Reset mật khẩu (admin reset cho user khác)
- Mã hóa mật khẩu trong database

#### 3. Phân quyền chức năng (Role-based Access Control)
- Phân quyền theo menu: View, Insert, Update, Delete
- Giới hạn số lần in ấn (LimitedPrint)
- Phân quyền theo form/bar/submenu

#### 4. Phân quyền đa công ty
- Cho phép user truy cập nhiều công ty
- Thiết lập quyền admin theo công ty
- User control `ucSmSetRightsCompany` cho việc chọn công ty

#### 5. Quản lý nhóm người dùng
- Tạo và quản lý nhóm người dùng
- Thêm/xóa user khỏi nhóm
- Kế thừa quyền từ nhóm

#### 6. Phân quyền Dashboard
- Cấu hình dashboard hiển thị theo user
- User control `ucSmSetRightsDash`

### Đặc điểm kỹ thuật

- Sử dụng MVC pattern: Controller (`SMUserInfoController`) + Entity (`UserInfo`) + DAO
- Data binding với BindingSource và AsDataGridView
- Check quyền truy cập trước khi thực hiện thao tác
- Hỗ trợ phím tắt: F5 (Add), F6 (Edit), F9 (Delete), Esc (Close)
- Sử dụng stored procedures trong SQL Server cho data access
- Hỗ trợ dynamic SQL qua XML (`DynInsertUpdateDeleteData`)

### Luồng xử lý phân quyền

```
User login → Load UserInfo từ database
          ↓
Kiểm tra isAdmin, grand, accesscompanies
          ↓
Load rights từ USERRIGHT table (theo MenuID)
          ↓
Enable/disable controls dựa trên rights
          ↓
User thực hiện action → Check rights → Execute/Show error
```

### Database Tables (reference)

| Table | Mục đích |
|-------|----------|
| USERINFO | Lưu thông tin người dùng |
| USERGROUP | Lưu thông tin nhóm người dùng |
| USER_GROUP | Mapping user - group |
| USERRIGHT | Lưu quyền của user theo menu |
| RIGHTCOMPANY | Lưu quyền truy cập công ty |

---

## Kết luận

SMUserInfo.dll là module core quan trọng trong hệ thống ERP Asia Enterprise, cung cấp:
- **User Management:** CRUD operations cho tài khoản người dùng
- **Authentication Support:** Quản lý mật khẩu, reset password
- **Authorization:** Hệ thống phân quyền chi tiết theo menu và công ty
- **Multi-tenancy:** Hỗ trợ người dùng truy cập nhiều công ty

Module này tuân thủ kiến trúc 3 lớp với business logic được tổ chức trong Controller, data access qua DAO pattern, và UI layer sử dụng Windows Forms với data binding.

---

*Ngày phân tích: 2026-03-29*
