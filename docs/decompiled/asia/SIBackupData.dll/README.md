# Báo cáo Phân tích DLL: SIBackupData.dll

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
| Assembly Name | SIBackupData |
| Assembly Title | Bảo trì hệ thống |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | c289afee-c6c1-4121-8078-fa6d2a97b535 |
| ComVisible | false |

---

## Cấu trúc File

```
SIBackupData.dll/
├── SIBackupData.csproj          # Project file
├── app.ico                      # Application icon
├── frmBackup.cs                 # Form thực hiện backup
├── frmRestore.cs                # Form thực hiện restore
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── MsSqlSIMaintainDAO.cs    # DAO cho SQL Server
│   └── SIMaintainDAO.cs         # Interface DAO
├── AsiaErp.UserInterface/
│   ├── frmAutoBackup.cs         # Form cấu hình auto backup
│   ├── frmSIBackupDB.cs         # Form sao lưu dữ liệu
│   ├── frmSIMaintain.cs         # Form bảo trì hệ thống
│   └── frmSIRestoreDB.cs        # Form khôi phục dữ liệu
├── My/
│   ├── MyApplication.cs         # VB MyApplication wrapper
│   ├── MyComputer.cs            # VB MyComputer wrapper
│   ├── MyProject.cs             # VB MyProject wrapper
│   ├── MySettings.cs            # Application settings
│   ├── MySettingsProperty.cs    # Settings property wrapper
│   └── InternalXmlHelper.cs     # XML helper
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Data.SqlClient | SQL Server client |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System.Data`, `System.Data.SqlClient`
- `System.IO`, `System.Collections`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIBackupDB` | `frmAsiaRoot` | Form sao lưu dữ liệu thủ công |
| `frmSIRestoreDB` | `frmAsiaRoot` | Form khôi phục dữ liệu |
| `frmAutoBackup` | `frmAsiaRoot` | Form cấu hình sao lưu tự động |
| `frmSIMaintain` | `frmAsiaRoot` | Form tổng hợp bảo trì hệ thống |
| `frmBackup` | - | Form tiến trình backup |
| `frmRestore` | - | Form tiến trình restore |
| `MsSqlSIMaintainDAO` | `MsSqlDAO` | DAO thực thi SQL Server |
| `SIMaintainDAO` | - | Interface định nghĩa các phương thức DAO |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Sao lưu dữ liệu" - Form backup thủ công
- "Khôi phục dữ liệu" - Form restore
- "Tự động sao lưu dữ liệu" - Form cấu hình auto backup
- "Thư mục sao lưu" - Đường dẫn lưu file backup
- "Tập tin sao lưu" - File backup để restore
- "Database Data" - Database dữ liệu chính
- "Database Sys" - Database hệ thống
- "Ngày sao lưu" - Chọn ngày trong tuần
- "Vào lúc" - Thời gian thực hiện backup

### Các ngày trong tuần (Auto Backup)

- "Thứ hai-Monday"
- "Thứ ba-Tuesday"
- "Thứ tư-Wednesday"
- "Thứ năm-Thursday"
- "Thứ sáu-Friday"
- "Thứ bảy-Saturday"
- "Chủ nhật-Sunday"

### Stored Procedures

| Tên | Mục đích |
|-----|----------|
| `asSIMaintain05` | Thực hiện backup database |
| `asSiScheduleAutoBackupData` | Tạo job auto backup |
| `asSIMaintain01_ReIndex` | Đánh lại chỉ mục |
| `asSIMaintain021` | Lấy danh sách mã cần xử lý |
| `asSIMaintain022` | Thực hiện xóa khoảng trắng trong mã |

---

## Mục đích sử dụng

**SIBackupData.dll là module sao lưu và khôi phục dữ liệu** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Sao lưu dữ liệu thủ công (frmSIBackupDB)
- Chọn thư mục lưu file backup
- Hiển thị thông tin database Data và Sys
- Thực hiện backup qua stored procedure `asSIMaintain05`
- Form `frmBackup` hiển thị tiến trình

#### 2. Khôi phục dữ liệu (frmSIRestoreDB)
- Chọn file backup (.bak)
- Kiểm tra file tồn tại
- Thực hiện restore qua form `frmRestore`

#### 3. Cấu hình sao lưu tự động (frmAutoBackup)
- Chọn ngày trong tuần (multiselect)
- Chọn thời gian thực hiện
- Tạo SQL Server Agent Job
- Stored procedure: `asSiScheduleAutoBackupData`

#### 4. Tổng hợp bảo trì (frmSIMaintain)
- Menu chính cho các chức năng bảo trì
- Link đến các form con
- Giao diện trực quan với LinkLabel

### Đặc điểm kỹ thuật

#### DAO Pattern
```csharp
public interface SIMaintainDAO
{
    DataTable GetDSMa();
    int ExecuteDelSpace(string pMa_cty, string pLst_Ma);
    int BackupDB(string pStr_Path);
    int CreateAutoBackupDB(params object[] para);
    int ExecuteReIndex();
}
```

#### Auto Backup Bitmask
- Tính toán `Freq_interval` cho SQL Server Agent:
  - Sunday = 1
  - Monday = 2
  - Tuesday = 4
  - Wednesday = 8
  - Thursday = 16
  - Friday = 32
  - Saturday = 64
- Thời gian: `Active_start_time` định dạng HHMMSS

#### Database Configurations
- `DATADatabaseName`: Database dữ liệu chính
- `SYSDatabaseName`: Database hệ thống
- `ServerName`: SQL Server instance

### Cơ chế sao lưu

| Chế độ | Form | Mô tả |
|--------|------|-------|
| Thủ công | frmSIBackupDB | Người dùng chọn thư mục và thực hiện |
| Tự động | frmAutoBackup | Tạo job chạy theo lịch định sẵn |
| Khôi phục | frmSIRestoreDB | Chọn file .bak và restore |

---

## Kết luận

Đây là module quan trọng cho việc bảo vệ dữ liệu trong hệ thống ERP Asia Enterprise, cung cấp các chức năng sao lưu thủ công, tự động và khôi phục dữ liệu. Module này tích hợp với SQL Server Agent để thực hiện backup định kỳ, đảm bảo an toàn dữ liệu cho doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
