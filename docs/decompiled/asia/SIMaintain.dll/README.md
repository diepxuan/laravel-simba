# Báo cáo Phân tích DLL: SIMaintain.dll

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
| Assembly Name | SIMaintain |
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
SIMaintain.dll/
├── SIMaintain.csproj            # Project file
├── app.ico                      # Application icon
├── frmBackup.cs                 # Form tiến trình backup
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── MsSqlSIMaintainDAO.cs    # DAO cho SQL Server
│   └── ISIMaintainDAO.cs        # Interface DAO
├── AsiaErp.UserInterface/
│   ├── frmAutoBackup.cs         # Form cấu hình auto backup
│   ├── frmSIBackupDB.cs         # Form sao lưu dữ liệu
│   ├── frmSICheckHT2TKTH.cs     # Form kiểm tra hạch toán
│   ├── frmSICheckLechSo.cs      # Form kiểm tra lệch sổ
│   ├── frmSIMaintain.cs         # Form tổng hợp bảo trì
│   └── frmSITrim_Ma.cs          # Form loại bỏ dấu trắng
├── My/
│   ├── MyApplication.cs         # VB MyApplication wrapper
│   ├── MyComputer.cs            # VB MyComputer wrapper
│   ├── MyProject.cs             # VB MyProject wrapper
│   ├── MySettings.cs            # Application settings
│   └── MySettingsProperty.cs    # Settings property wrapper
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
- `System.IO`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIMaintain` | `frmAsiaRoot` | Form tổng hợp các chức năng bảo trì |
| `frmSIBackupDB` | `frmAsiaRoot` | Form sao lưu dữ liệu |
| `frmAutoBackup` | `frmAsiaRoot` | Form cấu hình sao lưu tự động |
| `frmSICheckHT2TKTH` | - | Form kiểm tra hạch toán vào TK tổng hợp |
| `frmSICheckLechSo` | - | Form kiểm tra lệch giữa các sổ |
| `frmSITrim_Ma` | - | Form loại bỏ khoảng trắng trong mã |
| `frmBackup` | - | Form hiển thị tiến trình backup |
| `MsSqlSIMaintainDAO` | `MsSqlDAO` | DAO thực thi SQL Server |
| `ISIMaintainDAO` | - | Interface định nghĩa các phương thức DAO |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảo trì hệ thống" - Tên chức năng chính
- "Danh mục chức năng" - Header của form
- "Đánh lại chỉ mục các bảng" - ReIndex database
- "Loại bỏ các dấu khoảng trắng ở đầu và cuối các loại mã" - Trim mã
- "Kiểm tra hạch toán vào tài khoản tổng hợp" - Kiểm tra HT
- "Kiểm tra lệch giữa các sổ (Kế toán - Kho)" - Kiểm tra lệch
- "Sao lưu dữ liệu" - Backup thủ công
- "Khai báo tự động sao lưu dữ liệu" - Auto backup

### Stored Procedures

| Tên | Mục đích |
|-----|----------|
| `asSIMaintain01_ReIndex` | Đánh lại chỉ mục toàn bộ database |
| `asSIMaintain05` | Thực hiện backup database |
| `asSiScheduleAutoBackupData` | Tạo SQL Server Job cho auto backup |
| `asSIMaintain021` | Lấy danh sách mã cần xử lý trim |
| `asSIMaintain022` | Thực hiện xóa khoảng trắng trong mã |

---

## Mục đích sử dụng

**SIMaintain.dll là module bảo trì và bảo dưỡng hệ thống** trong ERP Asia Software Development JSC.

### Chức năng chính

#### 1. Đánh lại chỉ mục (ReIndex)
- Thực thi stored procedure `asSIMaintain01_ReIndex`
- Tối ưu hóa performance của database
- Hiển thị thông báo xác nhận trước khi thực hiện

#### 2. Loại bỏ dấu trắng (Trim)
- Form `frmSITrim_Ma` cho phép chọn loại mã cần xử lý
- Thực thi stored procedure `asSIMaintain022`
- Xóa khoảng trắng đầu và cuối các mã (mã KH, mã VT, mã TK...)

#### 3. Kiểm tra hạch toán
- Form `frmSICheckHT2TKTH` kiểm tra hạch toán vào TK tổng hợp
- Phát hiện các bút toán sai tài khoản
- MenuID: 90.10.72

#### 4. Kiểm tra lệch sổ
- Form `frmSICheckLechSo` kiểm tra chênh lệch giữa các sổ
- So sánh số liệu kế toán và kho
- MenuID: 90.10.73

#### 5. Sao lưu dữ liệu
- Form `frmSIBackupDB`: Backup thủ công
- Form `frmAutoBackup`: Cấu hình auto backup theo lịch
- Hỗ trợ cả database Data và Sys

### Đặc điểm kỹ thuật

#### DAO Pattern
```csharp
public interface ISIMaintainDAO
{
    DataTable GetDSMa();                           // Lấy danh sách mã
    int ExecuteDelSpace(string pMa_cty, string pLst_Ma);  // Xóa khoảng trắng
    int BackupDB(string pStr_Path);                // Backup database
    int CreateAutoBackupDB(params object[] para);  // Tạo auto backup job
    int ExecuteReIndex();                          // ReIndex database
}
```

#### Auto Backup
- Sử dụng SQL Server Agent để tạo job
- Tính toán `Freq_interval` theo bitmask:
  - Sunday = 1
  - Monday = 2
  - Tuesday = 4
  - Wednesday = 8
  - Thursday = 16
  - Friday = 32
  - Saturday = 64
- Thời gian chạy: `Active_start_time` (HHMMSS)

#### UI Design
- Sử dụng `LinkLabel` cho các chức năng
- Icon cho mỗi chức năng
- Panel layout với DockStyle
- Hỗ trợ phím ESC để đóng form

### Cơ chế kiểm tra

| Chức năng | Form | Mục đích |
|-----------|------|----------|
| ReIndex | frmSIMaintain | Tối ưu database |
| Trim | frmSITrim_Ma | Chuẩn hóa mã |
| Check HT | frmSICheckHT2TKTH | Kiểm tra đúng TK |
| Check Lech | frmSICheckLechSo | Đối chiếu sổ |
| Backup | frmSIBackupDB | Sao lưu thủ công |
| Auto Backup | frmAutoBackup | Lập lịch sao lưu |

---

## Kết luận

Đây là module bảo trì hệ thống quan trọng của ERP Asia Enterprise, cung cấp các công cụ để quản trị viên duy trì hiệu suất và tính toàn vẹn của cơ sở dữ liệu. Module này bao gồm các chức năng: tối ưu database, chuẩn hóa dữ liệu, kiểm tra số liệu và sao lưu dữ liệu.

---

*Ngày phân tích: 2026-03-29*
