# Báo cáo Phân tích DLL: SMFFY.dll

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
| Assembly Name | SMFFY |
| Assembly Title | Khóa số liệu |
| Assembly Company | AsiaSoft |
| Assembly Product | SMKS |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly File Version | 1.0.0.0 |
| GUID | 513fca91-96aa-45be-a3eb-073412c58cd7 |
| ComVisible | false |

---

## Cấu trúc File

```
SMFFY.dll/
├── SMFFY.csproj                     # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── SMFFYDAO.cs                  # Data Access Object interface
│   └── MsSqlSMFFYDAO.cs             # SQL Server Implementation
├── AsiaERP.UserInterface/
│   └── frmSMFFY.cs                  # Form khóa số liệu
└── My/
    ├── MyApplication.cs             # Application settings
    ├── MyComputer.cs                # Computer info
    ├── MySettings.cs                # User settings
    ├── MySettingsProperty.cs        # Settings property
    └── MyProject.cs                 # Project helpers
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSMFFY` | `frmCalc` | Form khóa số liệu cuối năm |
| `SMFFYDAO` | Interface | Data access interface |
| `MsSqlSMFFYDAO` | - | SQL Server implementation |

---

## Các trường dữ liệu chính

### Form frmSMFFY

#### Controls

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `txtNgay_dntc` | AsMaskedTextBox | Nhập ngày đầu năm tài chính (mask: ##/##) |
| `cmdOK` | Button | Xác nhận khóa số liệu |
| `cmdCancel` | Button | Hủy bỏ |

#### Labels

| Label | Text |
|-------|------|
| `Label2` | "Ngày đầu năm tài chính" |

---

## Mục đích sử dụng

**SMFFY.dll là module khóa số liệu cuối năm tài chính** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Thiết lập ngày đầu năm tài chính
- Nhập ngày/tháng bắt đầu năm tài chính
- Format: dd/MM (không cần năm)
- Mask input: `##/##` với valid type DateTime

#### 2. Khóa số liệu
- Thực hiện khóa sổ kế toán cuối năm
- Ngăn chặn chỉnh sửa chứng từ trong kỳ đã khóa
- Chuyển số dư sang năm tài chính mới
- Tạo bút toán kết chuyển tự động

#### 3. Validation
- Kiểm tra ngày nhập hợp lệ
- Xác nhận trước khi thực hiện khóa
- Kiểm tra quyền thực hiện thao tác

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` của Framework
- Sử dụng DAO pattern cho data access
- MaskedTextBox cho nhập ngày với format `@Ddd/MM`
- Form modal (MaximizeBox = false, MinimizeBox = false)
- Tích hợp với hệ thống fiscal year của Asia ERP

### Quy trình khóa số liệu

1. Người dùng mở form khóa số liệu
2. Nhập ngày đầu năm tài chính mới
3. Nhấn OK để xác nhận
4. Hệ thống kiểm tra điều kiện khóa sổ
5. Thực hiện khóa số liệu kỳ hiện tại
6. Mở kỳ mới với ngày đầu năm đã thiết lập

---

## Kết luận

Đây là module quan trọng trong quy trình kế toán cuối năm, cho phép khóa số liệu kỳ kế toán cũ và thiết lập năm tài chính mới. Module đảm bảo tính toàn vẹn dữ liệu khi chuyển đổi giữa các kỳ kế toán và ngăn chặn chỉnh sửa sai sót trong kỳ đã khóa.

**SMFFY** có thể là viết tắt của "Sổ Mẹ Fiscal Year" hoặc "Set Mother Fiscal Year" - chức năng thiết lập năm tài chính gốc.

---

*Ngày phân tích: 2026-03-29*
