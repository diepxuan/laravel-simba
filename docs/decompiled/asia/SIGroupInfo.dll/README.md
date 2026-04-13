# Báo cáo Phân tích DLL: SIGroupInfo.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SIGroupInfo |
| Assembly Title | Danh mục bộ phận |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
SIGroupInfo.dll/
├── SIGroupInfo.csproj           # Project file
├── app.ico                      # Application icon
├── Resources.resx               # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── MsSqlSiGroupInfoDao.cs   # DAO cho SQL Server
│   └── iSiGroupInfo.cs          # Interface DAO
├── AsiaErp.UserInterface/
│   ├── frmSIGroupInfo.cs        # Form danh sách nhóm
│   ├── frmSIGroupInfoEdit.cs    # Form chỉnh sửa nhóm
│   └── frmSiSetRights.cs        # Form phân quyền nhóm
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System.Data`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIGroupInfo` | `frmAsiaRoot` | Form quản lý danh sách nhóm người dùng |
| `frmSIGroupInfoEdit` | `frmAsiaRoot` | Form thêm/sửa thông tin nhóm |
| `frmSiSetRights` | `frmAsiaRoot` | Form phân quyền chức năng cho nhóm |
| `MsSqlSiGroupInfoDao` | - | DAO thực thi SQL Server |
| `iSiGroupInfo` | - | Interface định nghĩa các phương thức DAO |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục bộ phận" / "Thông tin nhóm" - Tên chức năng chính
- "Tên nhóm" - GroupName (khóa chính)
- "Tên đầy đủ" - FullName (tên hiển thị)
- "Phân lại quyền" - Grand (quyền phân quyền lại)
- "KSD" - Không sử dụng
- "Phân quyền" - Chức năng phân quyền chi tiết

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| GroupName | Tên nhóm (khóa chính) |
| FullName | Tên đầy đủ của nhóm |
| Grand | Có quyền phân quyền lại (Admin) |
| KSD | Trạng thái không sử dụng |

### Phân quyền (frmSiSetRights)

| Quyền | Ý nghĩa |
|-------|---------|
| Xem | ViewRight - Quyền xem dữ liệu |
| Thêm | InsertRight - Quyền thêm mới |
| Sửa | UpdateRight - Quyền chỉnh sửa |
| Xoá | DeleteRight - Quyền xóa dữ liệu |

---

## Mục đích sử dụng

**SIGroupInfo.dll là module quản lý nhóm người dùng và phân quyền** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý nhóm người dùng (frmSIGroupInfo)
- Hiển thị danh sách các nhóm người dùng
- Thêm nhóm mới
- Sửa thông tin nhóm
- Xóa nhóm (kiểm tra ràng buộc)
- Phân quyền cho nhóm

#### 2. Thêm/Sửa nhóm (frmSIGroupInfoEdit)
- Nhập Tên nhóm (GroupName) - khóa chính, không trùng
- Nhập Tên đầy đủ (FullName)
- Chọn trạng thái KSD (Không sử dụng)
- Chọn quyền Grand (Phân lại quyền)
- Validation dữ liệu trước khi lưu

#### 3. Phân quyền chi tiết (frmSiSetRights)
- Chọn Phân hệ (Main Menu)
- Chọn Chức năng trong phân hệ (Sub Menu)
- Grid hiển thị các chức năng và quyền:
  - Xem (ViewRight)
  - Thêm (InsertRight)
  - Sửa (UpdateRight)
  - Xóa (DeleteRight)
- Checkbox "Chọn tất cả" cho mỗi quyền
- Lưu phân quyền vào database

### Đặc điểm kỹ thuật

#### Data Access
- Sử dụng interface `iSiGroupInfo` để định nghĩa các phương thức
- `MsSqlSiGroupInfoDao` implement interface cho SQL Server
- Các phương thức chính:
  - `GetGroupInfo()` - Lấy danh sách nhóm
  - `InsertGroupInfo()` - Thêm nhóm mới
  - `UpdateGroupInfo()` - Cập nhật nhóm
  - `DeleteGroupInfo()` - Xóa nhóm
  - `GetAllGroupRights()` - Lấy tất cả quyền của nhóm
  - `InsertGroupRight()` - Thêm quyền
  - `DeleteGroupRight()` - Xóa quyền

#### Phân quyền
- Phân quyền theo MenuID (cấu trúc phân cấp)
- Hỗ trợ phân quyền theo phân hệ và chức năng
- Lọc dữ liệu theo Link và LinkDetail
- Mỗi nhóm có thể có nhiều quyền khác nhau cho từng chức năng

#### Security
- Kiểm tra quyền trước khi thực hiện các thao tác
- Phân biệt quyền: View, Insert, Update, Delete
- Hỗ trợ phím tắt: F4 (Thêm), F3 (Sửa), F8 (Xóa)

### Cấu trúc bảng dữ liệu (dự đoán)

```sql
-- Bảng nhóm người dùng
SIGroupInfo (
    GroupName VARCHAR(20) PRIMARY KEY,
    FullName NVARCHAR(100),
    Grand BIT,
    KSD BIT,
    cdate DATETIME,
    ldate DATETIME,
    cuser VARCHAR(20),
    luser VARCHAR(20)
)

-- Bảng phân quyền
SIGroupRight (
    GroupName VARCHAR(20),
    MenuID VARCHAR(10),
    ViewRight BIT,
    InsertRight BIT,
    UpdateRight BIT,
    DeleteRight BIT
)
```

---

## Kết luận

Đây là một module Windows Forms quan trọng của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý nhóm người dùng và phân quyền truy cập chức năng. Module này đảm bảo tính bảo mật và kiểm soát truy cập trong hệ thống kế toán.

---

*Ngày phân tích: 2026-03-29*
