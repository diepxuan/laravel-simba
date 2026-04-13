# Báo cáo Phân tích DLL: SOND51mathd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Class Library) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51mathd |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51mathd.dll/
├── SOND51mathd.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── SOND51mathdDAO.cs        # DAO Interface
│   └── MsSqlSOND51mathdDAO.cs   # MSSQL DAO Implementation
├── My/
│   ├── MyApplication.cs         # Application settings
│   └── MyProject.cs             # Project settings
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

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System.Data`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `SOND51mathdDAO` | `DAO` | Interface định nghĩa các phương thức truy xuất dữ liệu mã hóa đơn |
| `MsSqlSOND51mathdDAO` | - | Implementation của SOND51mathdDAO cho MSSQL |

---

## Interface Methods (SOND51mathdDAO)

| Method | Parameters | Return | Mục đích |
|--------|------------|--------|----------|
| `GetData` | `string ma_tb` | `DataTable` | Lấy dữ liệu theo mã tờ báo cáo |
| `GetData` | `string ngay1, string ngay2` | `DataTable` | Lấy dữ liệu theo khoảng thời gian |
| `Insert` | `ma_tb, ma_chung, ten_loai, mau_so, so_seri, tu_so, den_so, so_luong, lien_hd, ghi_chu` | `int` | Thêm mới mã hóa đơn |
| `Delete` | `string ma_tb` | `int` | Xóa mã hóa đơn |

---

## Các trường dữ liệu

| Trường | Ý nghĩa |
|--------|---------|
| `ma_tb` | Mã tờ báo cáo |
| `ma_chung` | Mã chung |
| `ten_loai` | Tên loại hóa đơn |
| `mau_so` | Mẫu số hóa đơn |
| `so_seri` | Số seri hóa đơn |
| `tu_so` | Từ số hóa đơn |
| `den_so` | Đến số hóa đơn |
| `so_luong` | Số lượng hóa đơn |
| `lien_hd` | Liên hóa đơn |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**SOND51mathd.dll là module quản lý "Mã hóa đơn"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý mã hóa đơn
- Định nghĩa và quản lý các mã hóa đơn theo quy định
- Theo dõi seri hóa đơn (từ số - đến số)
- Phân loại hóa đơn theo mẫu số

#### 2. Quản lý tờ báo cáo
- Mã tờ báo cáo (`ma_tb`) để phân loại
- Liên kết với các báo cáo thuế

#### 3. Data Access
- Interface chuẩn cho các thao tác CRUD
- Implementation riêng cho MSSQL
- Hỗ trợ lấy dữ liệu theo nhiều tiêu chí

### Đặc điểm kỹ thuật

- DAO pattern cho data access
- Interface-based design
- Hỗ trợ multiple database providers
- Transaction support qua Framework

### Module liên quan

Module này thuộc nhóm Sales (SO) và liên quan đến quản lý hóa đơn GTGT theo quy định của Tổng cục Thuế.

---

## Kết luận

Đây là module Data Access Layer của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý mã hóa đơn và seri hóa đơn theo quy định. Module cung cấp interface chuẩn và implementation cho MSSQL.

---

*Ngày phân tích: 2026-03-29*
