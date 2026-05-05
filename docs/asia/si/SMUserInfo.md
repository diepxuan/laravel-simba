# SMUserInfo.dll - Quản Lý Người Dùng & Phân Quyền

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Module | SMUserInfo |
| Loại | System/Infrastructure (SI) |
| Chức năng | Quản lý người dùng, phân quyền chức năng, phân quyền công ty, quản lý mật khẩu |
| Assembly | SMUserInfo.dll |
| Namespace | AsiaErp.UserInterface, AsiaErp.DataAccess, DTE.Bussiness |
| Base class | `frmAsiaRoot` (UI), `MsSqlDAO` (DataAccess), `RootController` (Business) |
| Framework | .NET Framework |

## Mô tả

Module **quản lý người dùng và phân quyền** - một trong những module hệ thống quan trọng nhất. Cung cấp đầy đủ các chức năng:
- CRUD người dùng
- Phân quyền chức năng theo menu (Xem/Thêm/Sửa/Xóa/Giới hạn in)
- Phân quyền theo công ty (multi-tenant)
- Phân quyền dashboard
- Quản lý nhóm người dùng
- Đổi mật khẩu / Reset mật khẩu

## Entity

### UserInfo (DTE.Bussiness)

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

## Forms

### frmSMUserInfo - Danh sách người dùng

Form quản lý danh sách người dùng với CRUD operations.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách user |
| `UserName` | DataGridViewTextBoxColumn | Cột tên đăng nhập (150px) |
| `FullName` | DataGridViewTextBoxColumn | Cột tên đầy đủ (300px) |
| `isAdmin` | DataGridViewCheckBoxColumn | Cột flag admin |
| `notactive` | DataGridViewCheckBoxColumn | Cột flag disabled |
| `cmdAdd` | Button | Thêm mới (F5) |
| `cmdEdit` | Button | Sửa (F6) |
| `cmdDel` | Button | Xóa (F9) |
| `cmdSetRight` | SplitButton | Phân quyền chức năng |
| `btnResetPass` | Button | Reset mật khẩu |
| `cmdClose` | Button | Đóng (Esc) |
| `bsDanhMuc` | BindingSource | Binding data cho grid |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `GetData()` | Gọi `MyController.GetUserInfo()` load danh sách |
| `AddNew()` | Mở frmSMUserInfoEdit (EditMode=false) |
| `Edit()` | Mở frmSMUserInfoEdit (EditMode=true) |
| `Delete()` | Xóa user với confirmation (msg 50003) |
| `ProcessCmdKey()` | Xử lý phím tắt: F5=Add, F6=Edit, F9=Delete |
| `cmdSetRight_Click()` | Mở frmSmSetRights phân quyền |
| `btnResetPass_Click()` | Mở frmSMUserResetPassword |

#### Permission Checks

| Flag | Kiểm tra trước |
|------|----------------|
| `f_blnViewRight` | Load grid |
| `f_blnInsertRight` | Thêm mới |
| `f_blnUpdateRight` | Sửa, Reset mật khẩu |
| `f_blnDeleteRight` | Xóa |

---

### frmSMUserInfoEdit - Thêm/Sửa người dùng

Form chi tiết để thêm mới hoặc chỉnh sửa thông tin user.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtUserName` | TextBox | Tên đăng nhập (MaxLength=20, Uppercase) |
| `txtFullName` | TextBox | Tên đầy đủ (MaxLength=50) |
| `txtPassword` | TextBox | Mật khẩu (MaxLength=30, PasswordChar=*) |
| `txtRePassword` | TextBox | Nhập lại mật khẩu |
| `chkIsAdmin` | AsCheckBox | Flag quản trị |
| `chkGrand` | AsCheckBox | Flag cấp lại quyền |
| `chkKSD` | AsCheckBox | Flag không sử dụng (disabled) |
| `asDGV_Available` | AsDataGridView | Danh sách nhóm chưa gán |
| `asDGV_Selected` | AsDataGridView | Danh sách nhóm đã gán |
| `cmdAdd` | Button | Thêm nhóm ("<") |
| `cmdRemove` | Button | Xóa nhóm (">") |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `ValidData()` | Validate: username, fullname không rỗng, password match |
| `InsertToDB()` | Mã hóa password (`Helper.Encrypted`), gọi `InsertUserInfo` |
| `UpdateDB()` | Gọi `UpdateUserInfo` (không đổi password) |
| `DisableFields()` | Edit mode: disable username/password fields |
| `cmdAdd_Click()` | Chuyển nhóm từ Available → Selected |
| `cmdRemove_Click()` | Chuyển nhóm từ Selected → Available |

---

### frmSMUserChangePassword - Đổi mật khẩu

Form để user tự đổi mật khẩu của mình.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtOld_Password` | TextBox | Mật khẩu cũ (PasswordChar=*) |
| `txtNewPassword` | TextBox | Mật khẩu mới |
| `txtRePassword` | TextBox | Nhập lại mật khẩu mới |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `ValidData()` | Kiểm tra old password đúng, new password match |
| `cmdSave_Click()` | Gọi `ChangePassword(username, encrypted_new_pass)` |

---

### frmSMUserResetPassword - Reset mật khẩu (Admin)

Form admin reset mật khẩu cho user khác.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtPassword` | TextBox | Mật khẩu mới |
| `txtRePassword` | TextBox | Nhập lại mật khẩu mới |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `ValidData()` | Kiểm tra admin rights, password match |
| `cmdSave_Click()` | Gọi `ChangePassword(sUserName, encrypted_pass)` |

---

### frmSmSetRights - Phân quyền chức năng

Form phân quyền chi tiết theo menu/function.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `cboMainMenu` | ComboBox | Chọn menu chính |
| `cboSubMenu` | ComboBox | Chọn menu con |
| `dgvDM` | AsDataGridView | Grid phân quyền |
| `dgvcViewRight` | DataGridViewCheckBoxColumn | Xem |
| `dgvcAddRight` | DataGridViewCheckBoxColumn | Thêm |
| `dgvcEditRight` | DataGridViewCheckBoxColumn | Sửa |
| `dgvcDeleteRight` | DataGridViewCheckBoxColumn | Xóa |
| `dgvcLimitedPrint` | DataGridViewAsTextNumericColumn | Giới hạn in |
| `chkAllView` | CheckBox | Check all Xem |
| `chkAllAdd` | CheckBox | Check all Thêm |
| `chkAllEdit` | CheckBox | Check all Sửa |
| `chkAllDel` | CheckBox | Check all Xóa |
| `pnl_SetRightsCompany` | GroupBox | Panel phân quyền công ty |
| `pnl_SetRightDash` | GroupBox | Panel phân quyền dashboard |
| `UcSmSetRightsCompany` | ucSmSetRightsCompany | UC phân quyền công ty |
| `UcRightsDash` | ucSmSetRightsDash | UC phân quyền dashboard |
| `cmdSave` | Button | Lưu |
| `cmdClose` | Button | Đóng |

#### DataGridView Columns

| Column | DataPropertyName | HeaderText | Width |
|--------|------------------|------------|-------|
| UserName | bar | Chức năng | 530px (frozen) |
| dgvcViewRight | viewright | Xem | 40px |
| dgvcAddRight | InsertRight | Thêm | 40px |
| dgvcEditRight | UpdateRight | Sửa | 40px |
| dgvcDeleteRight | deleteright | Xóa | 40px |
| dgvcLimitedPrint | limitedPrint | Giới hạn in | 70px |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `GetDataUserRight()` | Load rights cho user và grand admin user |
| `GetDataCompany()` | Load company rights qua UcSmSetRightsCompany |
| `GetDataDash()` | Load dashboard rights qua UcRightsDash |
| `ProcessUserRight()` | Save rights: delete old + insert new cho modified rows |
| `cboMainMenu_SelectedValueChanged()` | Filter submenu + userright table |
| `cboSubMenu_SelectedIndexChanged()` | Filter userright by MenuID prefix |
| `chkAll*_CheckedChanged()` | Check/uncheck all cho column tương ứng |

#### Permission Constraints

- User không thể grant quyền vượt quá quyền của grand admin user
- Admin (`f_bIsAdmin`) có thể grant mọi quyền
- Cell validation: không cho phép set quyền vượt quá grand rights

---

### frmSmSetRightsCompany - Phân quyền công ty

Form phân quyền truy cập theo công ty (multi-tenant).

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `dgvDM` | AsDataGridView | Grid danh sách công ty |
| `ma_cty` | DataGridViewTextBoxColumn | Mã công ty (64px, frozen) |
| `Ten_cty` | DataGridViewTextBoxColumn | Tên công ty (436px, frozen) |
| `dgvcViewRight` | DataGridViewCheckBoxColumn | Active/Chọn (38px) |
| `chkAllActive` | CheckBox | Check all Active |
| `cmdSave` | Button | Lưu |
| `cmdClose` | Button | Đóng |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `GetData()` | Load company rights cho user và grand admin |
| `cmdSave_Click()` | Iterate modified rows, gọi `InsRightCompany` |
| `chkAllActive_CheckedChanged()` | Check/uncheck all active (respecting grand rights) |

## User Controls

### ucSmSetRightsCompany

User control chọn công ty để phân quyền, được nhúng trong frmSmSetRights.

| Property | Type | Mô tả |
|----------|------|-------|
| `UserName` | string | User cần phân quyền |
| `GrandRightUserName` | string | Admin/granting user |
| `IsAdmin` | bool | Flag admin |
| `MySourceCompanyRight` | DataTable | Quyền hiện tại của user |
| `MySourceGrandCompanyRight` | DataTable | Quyền của admin |

| Method | Mô tả |
|--------|-------|
| `GetData()` | Load data từ controller |
| `ProcessDB()` | Lưu thay đổi vào database |

### ucSmSetRightsDash

User control phân quyền dashboard widgets.

| Property | Type | Mô tả |
|----------|------|-------|
| `UserName` | string | User cần phân quyền |
| `GrandRightUserName` | string | Admin/granting user |
| `IsAdmin` | bool | Flag admin |
| `MySourceUserRight` | DataTable | Dashboard rights của user |
| `MySourceGrandRight` | DataTable | Dashboard rights của admin |

| Method | Mô tả |
|--------|-------|
| `GetData()` | Load data từ controller |
| `ProcessDB()` | Lưu thay đổi vào database |

## Business Logic

### SMUserInfoController

Controller chính, kế thừa `RootController`.

| Method | Tham số | Return | Mô tả |
|--------|---------|--------|-------|
| `GetUserInfo` | - | DataTable | Danh sách tất cả user |
| `GetUserInfoByUserName` | aUserName | UserInfo | Thông tin chi tiết user |
| `InsertUserInfo` | UserName, FullName, Password, IsAdmin, Grand, Disabled, User | int | Thêm user mới |
| `UpdateUserInfo` | UserName, FullName, IsAdmin, Grand, Disabled, User | bool | Cập nhật user |
| `DeleteUserInfo` | UserName | bool | Xóa user |
| `ChangePassword` | aUserName, aNew_pass | bool | Đổi mật khẩu |
| `ResetPassword` | UserName, Password, User | int | Admin reset password |
| `GetGroupInfo` | - | DataSet | Danh sách nhóm |
| `GetUserGroup` | UserName | DataSet | Nhóm của user |
| `InsertUserGroup` | GroupName, UserName, pDel | int | Thêm user vào nhóm |
| `DeleteUserGroup` | UserName | int | Xóa user khỏi nhóm |
| `GetMenuBar` | - | DataTable | Danh sách menu chính |
| `GetSubMenuBar` | - | DataTable | Danh sách menu con |
| `GetMenuForm` | - | DataTable | Danh sách form/menu |
| `GetAllUserRights` | UserName | DataTable | Tất cả quyền của user |
| `InsertUserRight` | UserName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight, LimitedPrint | int | Thêm quyền |
| `UpdateUserRight` | UserName, UserName_Old | int | Cập nhật quyền |
| `DeleteUserRight` | UserName, MenuID | int | Xóa quyền |
| `GetAllRightCompany` | UserName | DataTable | Quyền công ty |
| `InsRightCompany` | Ma_cty, UserName, active | int | Thêm quyền công ty |
| `GetAllUserRightDash` | UserName | DataTable | Dashboard rights |
| `DynInsertUpdateDeleteData` | pXmlData, pTableName, pMode, pKeyColumns | int | Dynamic SQL qua XML |

### Constants

| Constant | Value |
|----------|-------|
| `TABLE_NAME` | "USERINFO" |

## DataAccess

### Interface: SMUserInfoDAO

Kế thừa từ `DAO` interface.

| Method | Tham số | Return | Stored Procedure |
|--------|---------|--------|------------------|
| `GetUserInfo` | - | DataTable | `asGetUserInfo` |
| `GetUserInfoByUserName` | aUserName | UserInfo | `asGetUserInfoByUserName` |
| `InsertUserInfo` | UserName, FullName, Password, IsAdmin, Grand, Disabled, User | int | `asInsUserInfo` |
| `UpdateUserInfo` | UserName, FullName, IsAdmin, Grand, Disabled, User | int | `asUpdUserInfo` |
| `DeleteUserInfo` | UserName | int | `asDelUserInfo` |
| `ChangePassword` | aUserName, aNew_pass | bool | `asChangePassword` |
| `ResetPassword` | UserName, Password, User | int | `asResetPassword` |
| `GetGroupInfo` | - | DataSet | `asGetGroupInfo` |
| `GetUserGroup` | UserName | DataSet | `asGetUserGroup` |
| `InsertUserGroup` | GroupName, UserName, pDel | int | `asInsUserGroup` |
| `DeleteUserGroup` | UserName | int | `asDelUserGroup` |
| `GetMenuBar` | - | DataTable | `asGetMenuBar` |
| `GetSubMenuBar` | - | DataTable | `asGetMenuDetail` |
| `GetMenuForm` | - | DataTable | `asGetMenuForm` |
| `GetAllUserRights` | UserName | DataTable | `asGetAllUserRights` |
| `InsertUserRight` | UserName, MenuID, ViewRight, InsertRight, UpdateRight, DeleteRight, LimitedPrint | int | `asInsUserRight` |
| `UpdateUserRight` | UserName, UserName_Old | int | `asUpdUserRight` |
| `DeleteUserRight` | UserName, MenuID | int | `asDelUserRight` |
| `GetAllRightCompany` | UserName | DataTable | `asGetAllRightCompany` |
| `InsRightCompany` | Ma_cty, UserName, active | int | `asInsRightCompany` |
| `GetAllUserRightDash` | UserName | DataTable | `asGetAllRightDash` |
| `DynInsertUpdateDeleteData` | pXmlData, pTableName, pMode, pKeyColumns | int | `asSiDynInsertUpdateDeleteData` |

### MsSqlSMUserInfoDAO

Implementation của `SMUserInfoDAO`, kế thừa `MsSqlDAO`.

## Luồng xử lý phân quyền

```
1. Admin mở frmSMUserInfo → Load danh sách user
2. Chọn user → Click "Phân quyền" → Mở frmSmSetRights
3. frmSmSetRights load:
   - Rights hiện tại của user
   - Rights của grand admin (để validate không vượt quyền)
   - Danh sách menu/submenu
   - Company rights (qua UcSmSetRightsCompany)
   - Dashboard rights (qua UcRightsDash)
4. Admin chọn menu → Grid hiển thị functions với checkboxes
5. Admin tick quyền → Save:
   - Delete old rights (asDelUserRight)
   - Insert new rights (asInsUserRight)
   - Process company rights (asInsRightCompany)
   - Process dashboard rights
```

## Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework.dll | Base classes (frmAsiaRoot, RootController, Commons, Environment) |
| Helper.dll | Utility functions (encryption, error handling) |

## Ghi chú

- Module sử dụng **3-tier architecture**: UI → Controller → DAO → SQL Server
- Password được mã hóa qua `Helper.Encrypted(txt, 100)`
- Permission system hỗ trợ **granular rights**: View/Insert/Update/Delete/LimitedPrint
- LimitedPrint: 0=Không giới hạn, 1=In lần đầu, 2=In các lần tiếp theo
- Hỗ trợ **multi-tenant**: user có thể truy cập nhiều công ty
- **Grand rights**: user chỉ có thể grant quyền trong phạm vi quyền của mình
- Dynamic SQL qua XML (`DynInsertUpdateDeleteData`) cho phép thao tác data linh hoạt
