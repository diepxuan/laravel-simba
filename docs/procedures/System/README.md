# System (Sys) - Hệ thống và Quản trị

Module cung cấp các thủ tục hệ thống để quản trị công ty, copy dữ liệu, và bảo trì database.

---

## Tổng quan

**Purpose:** Cung cấp các công cụ quản trị hệ thống, tạo mới công ty, copy dữ liệu giữa các công ty, và bảo trì database.

**Key Functions:**
- Tạo công ty mới từ công ty mẫu
- Cập nhật thông tin công ty
- Đổi mã công ty
- Copy database theo mã công ty
- Xóa toàn bộ dữ liệu của công ty
- Quản lý danh mục chứng từ

---

## Database Tables

### System Tables
```
SysCompany        - Thông tin công ty
SysCompanyResx    - Thông tin công ty (đa ngôn ngữ)
SiSetup           - Thiết lập hệ thống
SiDmCt            - Danh mục chứng từ
SmSysTables       - Danh sách table hệ thống
```

### Related Tables
```
GLCT              - Sổ cái (để kiểm tra tồn tại)
GLDmTk            - Danh mục tài khoản
HRDmCcTc          - Cơ cấu tổ chức
```

---

## Stored Procedures

**Tổng số:** 5 procedures

### Categories

#### 1. Company Management (Quản lý công ty)
```
asSysCreateCompany      - Tạo công ty mới từ công ty mẫu
asSysUpdCompany         - Cập nhật thông tin công ty
asSysDoiMaCongTy        - Đổi mã công ty
```

#### 2. Database Operations (Thao tác database)
```
asSysCopyDatabaseCompany - Copy database theo công ty
asSysDelAllData         - Xóa toàn bộ dữ liệu
```

---

## Business Flows

### 1. Tạo Công Ty Mới
```
Yêu cầu tạo công ty mới
      ↓
1. Kiểm tra mã công ty đã tồn tại (GLCT, SiSetup)
      ↓
2. asSysCreateCompany(@pMa_cty_cu, @pMa_cty_moi)
      ↓
3. Copy tất cả table hệ thống từ công ty mẫu
      ↓
4. Đổi ma_cty = @pMa_cty_moi
      ↓
5. Insert vào các table đích
      ↓
6. Công ty mới sẵn sàng sử dụng
```

### 2. Cập Nhật Thông Tin Công Ty
```
Yêu cầu thay đổi thông tin
      ↓
1. asSysUpdCompany
      ↓
2. Cập nhật SysCompany
      ↓
3. Cập nhật SysCompanyResx (đa ngôn ngữ)
      ↓
4. Lưu thay đổi
```

### 3. Đổi Mã Công Ty
```
Yêu cầu đổi mã công ty
      ↓
1. Kiểm tra mã mới đã tồn tại
      ↓
2. asSysDoiMaCongTy(@pMa_cty_cu, @pMa_cty_moi)
      ↓
3. UPDATE tất cả table có MA_CTY
      ↓
4. Reset danh mục chứng từ (SiDmCt)
      ↓
5. Kiểm tra dữ liệu trong table hệ thống
      ↓
6. Hoàn tất đổi mã
```

### 4. Copy Database Theo Công Ty
```
Yêu cầu copy dữ liệu sang DB mới
      ↓
1. asSysCopyDatabaseCompany(@SourceDB, @DestDB, @Ma_CTy)
      ↓
2. Liệt kê tất cả table có MA_CTY
      ↓
3. Với mỗi table:
   - Xóa dữ liệu cũ ở DB đích
   - Copy dữ liệu từ DB nguồn
      ↓
4. Hoàn tất copy
```

### 5. Xóa Toàn Bộ Dữ Liệu
```
Yêu cầu xóa dữ liệu (cẩn trọng!)
      ↓
1. Backup database trước
      ↓
2. asSysDelAllData(@pMa_cty)
      ↓
3. Xóa dữ liệu trong tất cả table
      ↓
4. Reset danh mục chứng từ
      ↓
5. Dữ liệu đã xóa
```

---

## Key Parameters

### Common Parameters
```sql
@pMa_cty       -- Mã công ty (Company ID)
@pMa_cty_cu    -- Mã công ty cũ (Old company ID)
@pMa_cty_moi   -- Mã công ty mới (New company ID)
@pTen_tcty     -- Tên tổng công ty
@pTen_cty      -- Tên công ty
@pDia_chi      -- Địa chỉ
@pLanguage     -- Ngôn ngữ (vi-VN, en-US)
@SourceDB      -- Database nguồn
@DestDB        -- Database đích
```

### System Configuration
```sql
vn_pattern      -- Pattern số chứng từ
vn_prefix       -- Prefix số chứng từ
vn_sequence     -- Số sequence hiện tại
vn_width        -- Độ dài số chứng từ
```

---

## Usage Examples

### 1. Tạo Công Ty Mới
```sql
-- Tạo công ty 002 từ công ty mẫu 001
EXEC asSysCreateCompany
    @pMa_cty_cu = '001',
    @pMa_cty_moi = '002'

-- Lưu ý:
-- - Ma_cty_moi phải có độ dài 3 ký tự
-- - Kiểm tra ma_cty_moi chưa tồn tại
-- - Copy tất cả table hệ thống
```

### 2. Cập Nhật Thông Tin Công Ty
```sql
-- Cập nhật thông tin công ty
EXEC asSysUpdCompany
    @pMa_cty = '001',
    @pTen_tcty = 'Tap doan ABC',
    @pTen_cty = 'Cong ty TNHH ABC',
    @pDia_chi = 'Ha Noi, Viet Nam',
    @pLanguage = 'vi-VN'

-- Cập nhật cho ngôn ngữ tiếng Anh
EXEC asSysUpdCompany
    @pMa_cty = '001',
    @pTen_tcty = 'ABC Corporation',
    @pTen_cty = 'ABC Co., Ltd',
    @pDia_chi = 'Hanoi, Vietnam',
    @pLanguage = 'en-US'
```

### 3. Đổi Mã Công Ty
```sql
-- Đổi mã công ty từ 001 sang 002
EXEC asSysDoiMaCongTy
    @pMa_cty_cu = '001',
    @pMa_cty_moi = '002'

-- Lưu ý:
-- - Ma_cty_moi phải có độ dài 3 ký tự
-- - Kiểm tra ma_cty_moi chưa tồn tại
-- - UPDATE tất cả table có MA_CTY
-- - Reset danh mục chứng từ
```

### 4. Copy Database Theo Công Ty
```sql
-- Copy dữ liệu công ty 001 từ DB nguồn sang DB đích
EXEC asSysCopyDatabaseCompany
    @SourceDB = 'zAe91VPData',
    @DestDB = 'Ae91VPData',
    @Ma_CTy = '001'

-- Lưu ý:
-- - Chạy trên DB nguồn
-- - Copy tất cả table có MA_CTY
-- - Xóa dữ liệu cũ ở DB đích trước khi insert
```

### 5. Xóa Toàn Bộ Dữ Liệu
```sql
-- Xóa toàn bộ dữ liệu công ty 001
-- WARNING: Backup trước khi thực hiện!
EXEC asSysDelAllData
    @pMa_cty = '001',
    @pmau = '200'

-- Lưu ý:
-- - Backup database trước
-- - Xóa dữ liệu trong tất cả table
-- - Reset danh mục chứng từ
-- - Không thể khôi phục
```

---

## Validation Rules

### 1. Company Code Validation
```
LEN(@pMa_cty_moi) = 3
@pMa_cty_moi NOT EXISTS in GLCT
@pMa_cty_moi NOT EXISTS in SiSetup
```

### 2. Data Validation
```
@pTen_cty NOT NULL
@pLanguage IN ('vi-VN', 'en-US', ...)
```

### 3. Database Validation
```
@SourceDB EXISTS
@DestDB EXISTS
@Table có MA_CTY column
```

---

## Error Handling

### Common Errors
```
Error 16,1  - Mã công ty đã tồn tại
Error 16,1  - Công ty chưa có dữ liệu trong bảng
Error <> 0  - Lỗi copy table
```

### Error Handling Pattern
```sql
-- Kiểm tra tồn tại
IF (SELECT COUNT(ma_cty) FROM glct WHERE ma_cty = @pMa_cty_moi) > 0
BEGIN
    RAISERROR(N'Mã công ty %s đã tồn tại', 16, 1, @pMa_cty_moi)
    RETURN
END

-- Kiểm tra sau copy
IF @count = 0
    RAISERROR(N'Công ty %s chưa có dữ liệu trong bảng %s', 16, 1, @pMa_cty_moi, @tblName)
```

---

## Performance Guidelines

### Cursor Usage
```sql
-- Sử dụng cursor để duyệt qua tất cả table
DECLARE tblCursor CURSOR FOR
    SELECT table_name FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE COLUMN_NAME = 'MA_CTY'
    GROUP BY TABLE_NAME

-- Dynamic SQL cho mỗi table
SET @sql = 'UPDATE ' + @tblName + ' SET ma_cty = @pMa_cty_moi WHERE ma_cty = @pMa_cty_cu'
EXEC sp_executesql @sql, @ParamDefines, ...
```

### Bulk Operations
```sql
-- Copy dữ liệu hàng loạt
SELECT @colList = @colList + column_name + ',' FROM ...
SET @colList = LEFT(@colList, LEN(@colList)-1)

SET @s = 'INSERT ' + @DestDB + '.dbo.' + @tbl + '(' + @colList + ') 
          SELECT ' + @colList + ' FROM ' + @tbl + ' WHERE ma_cty = ' + @ma_cty
EXEC(@s)
```

---

## Security & Permissions

### Role-based Access
```
ROLE_SYS_ADMIN      - Full access (DBA only)
ROLE_SYS_CREATE     - Tạo công ty mới
ROLE_SYS_UPDATE     - Cập nhật thông tin công ty
ROLE_SYS_DELETE     - Xóa dữ liệu (cảnh báo cao)
```

### Security Warnings
```
WARNING: asSysDelAllData - Không thể khôi phục
WARNING: asSysDoiMaCongTy - Ảnh hưởng toàn bộ dữ liệu
WARNING: asSysCopyDatabaseCompany - Cần quyền DB owner
```

---

## Audit Trail

### Tracked Operations
```
Create Company  - Log thời gian tạo, công ty nguồn
Update Company  - Log thay đổi thông tin
Change Code     - Log mã cũ/mới
Delete Data     - Log thời gian xóa (cảnh báo)
Copy Database   - Log nguồn/đích, thời gian
```

---

## Related Documentation

### Core Docs
- [docs/DATA_DICTIONARY.md](../../DATA_DICTIONARY.md) - Định nghĩa cột
- [docs/08_ERROR_HANDLING_STANDARD.md](../../08_ERROR_HANDLING_STANDARD.md) - Xử lý lỗi
- [docs/09_NAMING_CONVENTION.md](../../09_NAMING_CONVENTION.md) - Quy tắc đặt tên

### Administration
- [docs/admin/company_setup.md](../../admin/company_setup.md) - Hướng dẫn tạo công ty
- [docs/admin/database_maintenance.md](../../admin/database_maintenance.md) - Bảo trì database

---

## Technical Reference

| Document | Description |
|----------|-------------|
| [Stored Procedures](./procedures.md) | Chi tiết tất cả stored procedures |
| [Database Schema](../../dbo/Tables/) | Cấu trúc bảng dữ liệu |
| [Module Index](../../catalog/PROCEDURES.md) | Danh mục procedures |

## Related Modules

| Module | Description |
|--------|-------------|
| [SI](../SI/) | System - Hệ thống chung |

---

## Change History

| Date | Version | Change | Author |
|------|---------|--------|--------|
| 2026-03-12 | 1.0 | Initial documentation | Bột |

---

*Last updated: 2026-03-12*
