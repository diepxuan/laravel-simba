# Báo cáo Phân tích DLL: FAThoiKHTS.dll

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
| Assembly Name | FAThoiKHTS |
| Assembly Title | Khai báo tạm ngưng khấu hao tài sản |
| Assembly Product | AsiaERP |
| Assembly Company | ASIASOFT |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | b973ca93-646c-40ea-97cc-11fdb42a919a |
| ComVisible | false |

---

## Cấu trúc File

```
FAThoiKHTS.dll/
├── FAThoiKHTS.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   ├── frmFAThoiKHTS.cs         # Main form class
│   └── frmFAThoiKHTSEdit.cs     # Edit form
├── AsiaERP.DataAccess/
│   ├── IFAThoiKHTSDAO.cs        # Data Access Interface
│   └── MsSqlFAThoiKHTSDAO.cs    # SQL Server DAO Implementation
└── My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    └── InternalXmlHelper.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| System.Core | Core library |
| System.Data | Data access |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaERP.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Data.SqlClient`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

### User Interface

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAThoiKHTS` | `frmDMComplexView` | Form danh sách khai báo tạm ngưng khấu hao TS |
| `frmFAThoiKHTSEdit` | `frmDMComplexEdit` | Form chỉnh sửa khai báo tạm ngưng khấu hao TS |

### Data Access Layer

| Class/Interface | Mục đích |
|-----------------|----------|
| `IFAThoiKHTSDAO` | Interface định nghĩa các phương thức truy xuất dữ liệu |
| `MsSqlFAThoiKHTSDAO` | Implementation cho SQL Server |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã tài sản" - Mã số tài sản cố định
- "Tên tài sản" - Tên tài sản (tự động lookup)
- "Ngày dừng khấu hao" - Ngày bắt đầu tạm ngưng khấu hao
- "Ngày khấu hao lại" - Ngày bắt đầu khấu hao trở lại
- "Diễn giải" - Ghi chú, diễn giải lý do

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản cố định |
| `ten_ts` | Tên tài sản |
| `ngay_dung_kh` | Ngày dừng khấu hao |
| `ngay_kh_lai` | Ngày khấu hao lại |
| `dien_giai` | Diễn giải, ghi chú |

---

## Stored Procedures sử dụng

| SP Name | Mục đích |
|---------|----------|
| `asFAChkThoiKHTS` | Kiểm tra trùng khai báo tạm ngưng khấu hao |
| `asFaDelDungKH` | Xóa khai báo tạm ngưng khấu hao |

### Tham số Stored Procedures

**asFAChkThkTS:**
- `@pMa_cty` - Mã công ty
- `@pMa_ts` - Mã tài sản
- `@pNgay_dung_kh` - Ngày dừng khấu hao
- Returns: Số lượng bản ghi trùng (int)

**asFaDelDungKH:**
- `@pMa_cty` - Mã công ty
- `@pMa_ts` - Mã tài sản
- `@pNgay_dung_kh` - Ngày dừng khấu hao
- `@pRet` - Output parameter, kết quả xóa (int)

---

## Mục đích sử dụng

**FAThoiKHTS.dll là module quản lý khai báo tạm ngưng khấu hao tài sản cố định** trong hệ thống ERP Asia.

### Chức năng chính

#### 1. Khai báo tạm ngưng khấu hao
- Nhập mã tài sản cố định cần tạm ngưng khấu hao
- Tự động lookup tên tài sản từ danh mục
- Nhập ngày dừng khấu hao (bắt buộc)
- Nhập ngày khấu hao lại (tùy chọn)
- Nhập diễn giải lý do tạm ngưng

#### 2. Validation dữ liệu
- Kiểm tra mã tài sản không được rỗng
- Kiểm tra ngày dừng khấu hao phải có giá trị hợp lệ
- Kiểm tra ngày khấu hao lại >= ngày dừng khấu hao
- Kiểm tra trùng khai báo (cùng mã TS + ngày dừng KH)

#### 3. Xóa khai báo
- Xác nhận trước khi xóa
- Gọi stored procedure `asFaDelDungKH` để xóa
- Cập nhật DataTable sau khi xóa thành công

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AsTextBox với AutoLookup và AutoValid cho mã tài sản
- AsMaskedTextBox cho ngày tháng (format: dd/MM/yyyy)
- Sử dụng DAOFactory để tạo instance data access
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit` của Framework
- Validation ngày khấu hao lại phải lớn hơn hoặc bằng ngày dừng khấu hao

### Business Rules

1. **Ngày dừng khấu hao**: Bắt buộc, không được để trống
2. **Ngày khấu hao lại**: Tùy chọn, nếu nhập phải >= ngày dừng khấu hao
3. **Trùng khai báo**: Không cho phép trùng mã TS + ngày dừng KH
4. **Lookup tài sản**: Tự động điền tên TS khi nhập mã TS

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia, phục vụ cho việc quản lý khai báo tạm ngưng khấu hao tài sản cố định - một chức năng quan trọng trong kế toán tài sản cố định khi có tài sản tạm thời không sử dụng, chờ thanh lý, hoặc các trường hợp đặc biệt khác cần dừng trích khấu hao.

Module có đầy đủ lớp data access với interface và implementation cho SQL Server, sử dụng stored procedures để thao tác với cơ sở dữ liệu.

---

*Ngày phân tích: 2026-03-29*
