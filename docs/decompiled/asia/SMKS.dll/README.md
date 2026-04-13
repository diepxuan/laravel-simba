# Báo cáo Phân tích DLL: SMKS.dll

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
| Assembly Name | SMKS |
| Assembly Title | Khóa số liệu |
| Assembly Company | AsiaSoft |
| Assembly Product | SMKS |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 513fca91-96aa-45be-a3eb-073412c58cd7 |
| ComVisible | false |

---

## Cấu trúc File

```
SMKS.dll/
├── SMKS.csproj                  # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── InternalXmlHelper.cs     # XML helper utilities
│   ├── MyApplication.cs         # Application settings
│   ├── MyComputer.cs            # Computer info wrapper
│   ├── MyProject.cs             # Project-wide utilities
│   ├── MySettings.cs            # Application settings
│   └── MySettingsProperty.cs    # Settings property wrapper
├── My.Resources/
│   └── Resources.cs             # Resource manager
└── AsiaERP/
    ├── DataAccess/
    │   ├── SMKSDAO.cs           # Data access interface
    │   └── MsSqlSMKSDAO.cs      # SQL Server implementation
    └── UserInterface/
        └── frmSMKS.cs           # Main form for locking data
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| System.Core | Core .NET functionality |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../projects/SimbaSql/native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaERP.UserInterface`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

### Data Access Layer

| Class | Interface | Mục đích |
|-------|-----------|----------|
| `SMKSDAO` | Interface | Định nghĩa interface truy xuất dữ liệu khóa số liệu |
| `MsSqlSMKSDAO` | `SMKSDAO`, `MsSqlDAO` | Implementation SQL Server cho khóa số liệu |

### User Interface

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSMKS` | `frmCalc` | Form chính để khóa số liệu theo năm tài chính |

### My Namespace (VB Helper Classes)

| Class | Mục đích |
|-------|----------|
| `MyApplication` | Quản lý thông tin application |
| `MyComputer` | Wrapper cho thông tin máy tính |
| `MyProject` | Utilities cho toàn project |
| `MySettings` | Quản lý application settings |
| `InternalXmlHelper` | Helper functions cho XML operations |

---

## Methods và Business Logic

### SMKSDAO Interface

```csharp
public interface SMKSDAO
{
    int Update(string ma_cty, DateTime ngay_ks);
}
```

### MsSqlSMKSDAO Implementation

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `Update` | Cập nhật ngày khóa số liệu | `ma_cty` (string), `ngay_ks` (DateTime) | `int` - 0 nếu thành công |

**Stored Procedure sử dụng:** `assiUpd_ks`
- `@pMa_cty`: Mã công ty
- `@pNgay_ks`: Ngày khóa sổ
- `@pRet`: Output parameter - kết quả trả về

### frmSMKS Form

#### Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `txtFinancialYear` | TextBox | Hiển thị năm tài chính (read-only) |
| `txtNgay_ks` | AsMaskedTextBox | Nhập ngày khóa sổ (mask: ##/##/####) |
| `lblFinancialYear` | Label | Nhãn "Năm tài chính" |
| `lblNgay_ks` | Label | Nhãn "Khóa sổ đến ngày" |
| `cmdOK` | Button | Xác nhận khóa số liệu |
| `cmdCancel` | Button | Hủy bỏ |

#### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| `cmdOK_Click` | `cmdOK_Click` | Thực thi khóa số liệu |
| `InitComponents` | Override | Khởi tạo giá trị mặc định |

#### Business Logic

**InitComponents:**
- Load cấu hình module từ `AsiaErp.Framework.Environment`
- Hiển thị năm tài chính hiện tại từ `SystemInformations.FinancialYear`
- Load ngày khóa sổ từ cấu hình hệ thống `Environment.GetSIConfiguration().ngay_ks`

**cmdOK_Click:**
1. Tạo instance `SMKSDAO` thông qua `DAOFactory`
2. Gọi `Update` với CompanyID và ngày khóa sổ
3. Nếu thành công (return 0):
   - Hiển thị message thành công (ID: 50015)
   - Refresh cấu hình module
   - Đóng form
4. Nếu thất bại:
   - Hiển thị message lỗi (ID: 50010)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

| Text | Ý nghĩa |
|------|---------|
| "Khóa số liệu" | Tên form chính |
| "Năm tài chính" | Label cho trường năm tài chính |
| "Khóa sổ đến ngày" | Label cho trường nhập ngày khóa sổ |

### Message IDs

| ID | Ngữ cảnh |
|----|----------|
| 50015 | Thành công khi khóa số liệu |
| 50010 | Lỗi khi khóa số liệu |

---

## Mục đích sử dụng

**SMKS.dll là module quản lý chức năng "Khóa số liệu"** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Khóa số liệu kế toán
- Cho phép người dùng thiết lập ngày khóa sổ cho công ty
- Ngăn chặn việc nhập liệu các chứng từ sau ngày khóa sổ
- Bảo vệ dữ liệu đã quyết toán khỏi bị thay đổi

#### 2. Quản lý theo năm tài chính
- Hiển thị năm tài chính hiện hành (read-only)
- Khóa số liệu theo từng công ty độc lập

#### 3. Validation và Control
- Kiểm tra quyền thực hiện khóa số liệu
- Xác nhận trước khi thực hiện khóa
- Refresh cấu hình hệ thống sau khi khóa thành công

### Đặc điểm kỹ thuật

- Sử dụng stored procedure `assiUpd_ks` để cập nhật ngày khóa sổ
- Tích hợp với Framework của Asia ERP để lấy cấu hình hệ thống
- Sử dụng DAO pattern cho data access
- Hỗ trợ đa công ty (CompanyID)

### Luồng xử lý

```
User mở form → Load năm tài chính và ngày khóa hiện tại
           ↓
User nhập ngày khóa mới → Click OK
           ↓
Gọi SMKSDAO.Update(ma_cty, ngay_ks)
           ↓
Thực thi stored procedure assiUpd_ks
           ↓
Trả về kết quả (0 = thành công)
           ↓
Hiển thị message → Refresh cấu hình → Đóng form
```

---

## Kết luận

SMKS.dll là một module quan trọng trong hệ thống ERP Asia Enterprise, cung cấp chức năng khóa số liệu kế toán - một tính năng bắt buộc trong quy trình kế toán doanh nghiệp để đảm bảo tính toàn vẹn của dữ liệu sau khi đã quyết toán.

Module này tuân thủ kiến trúc 3 lớp:
- **UI Layer:** `frmSMKS` (Windows Forms)
- **Business Logic Layer:** Interface `SMKSDAO`
- **Data Access Layer:** `MsSqlSMKSDAO` (SQL Server implementation)

---

*Ngày phân tích: 2026-03-29*
