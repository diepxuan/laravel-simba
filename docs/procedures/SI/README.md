# SI – System Module

---

## 1. Module Overview

### 1.1 Business Purpose

SI (System) là module nền tảng cung cấp các chức năng hệ thống cốt lõi và danh mục chung cho toàn bộ ERP. Module này:

- Quản lý thông tin công ty (company setup)
- Quản lý người dùng và phân quyền (user management)
- Quản lý danh mục chung (master data)
- Cung cấp các utility functions và system procedures
- Quản lý sequence numbers và system parameters
- Cung cấp audit logging và system monitoring

**Key Functions**:
- Company setup và configuration
- User authentication và authorization
- Master data management (customers, vendors, products, etc.)
- System utilities (sequence generation, parameter management)
- Audit logging và change tracking
- System monitoring và health checks

**Integration Points**: **TẤT CẢ modules** đều phụ thuộc vào SI module:
- **GL, AR, AP, CA, PO, SO, IN, CO**: Tất cả đều sử dụng SI cho company setup, user management, master data
- **All business modules**: Sử dụng SI utilities (`asGetSttRec`, `asGetSoCt`, `asGetRight`)

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Company Management | Supported | Thiết lập công ty, địa điểm, đơn vị |
| User Management | Supported | Tạo user, phân quyền, authentication |
| Role-Based Access Control | Supported | Phân quyền chi tiết theo role |
| Master Data Management | Supported | Danh mục chung (customers, vendors, products) |
| Sequence Management | Supported | Số thứ tự, số chứng tự tự động |
| System Parameters | Supported | Tham số hệ thống, cấu hình |
| Audit Logging | Supported | Ghi log thay đổi, truy cập |
| System Monitoring | Supported | Health checks, performance monitoring |
| Backup & Recovery | Supported | Utility cho backup và restore |
| Multi-language Support | Future | Hỗ trợ đa ngôn ngữ |
| API Management | Future | Quản lý API keys và access |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Si` (e.g., `SiSetup`, `SiUsers`, `SiDm*`)

**Stored Procedure Pattern**:
```
as{Action}{Entity}{OptionalSuffix}
```

**Note**: SI procedures thường không có module prefix vì là system-wide:
- `asGetSttRec` - Get sequence number (dùng bởi tất cả modules)
- `asGetSoCt` - Get document number
- `asGetRight` - Get user permissions
- `asLogError` - Log system errors

---

## 2. Multi-Tenancy Model

SI module là **nền tảng của multi-tenancy**:

**Key Principles**:
1. `Ma_cty` là cốt lõi của toàn bộ hệ thống
2. SI quản lý danh sách công ty (`SiSetup`)
3. Mỗi công ty có cấu hình riêng trong SI
4. User permissions được quản lý per company
5. Master data được quản lý per company

**Implementation Details**:
- `SiSetup` table chứa thông tin tất cả công ty
- `SiUsers` có mapping user-company-permissions
- Tất cả master data tables có `Ma_cty`
- System parameters có thể là global hoặc per-company

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `SiSetup` – Company Setup (Thiết lập công ty)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Primary key, unique |
| `Ten_cty` | `NVARCHAR(250)` | `NOT NULL` | | Tên công ty | Company name |
| `Dia_chi` | `NVARCHAR(500)` | | | Địa chỉ | Company address |
| `Ma_so_thue` | `NVARCHAR(20)` | | | Mã số thuế | Tax code |
| `Dien_thoai` | `NVARCHAR(50)` | | | Điện thoại | Phone number |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Default currency |
| `Ngay_bd_ks` | `SMALLDATETIME` | `NOT NULL` | | Ngày bắt đầu khóa sổ | Start of fiscal year |
| `Ngay_kt_ks` | `SMALLDATETIME` | `NOT NULL` | | Ngày kết thúc khóa sổ | End of fiscal year |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | Trạng thái | 1=Active, 0=Inactive |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty)
```

**Indexes**:
```sql
CREATE INDEX IX_SiSetup_TenCty ON SiSetup (Ten_cty)
```

---

#### 3.1.2 `SiUsers` – User Management (Quản lý người dùng)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `UserID` | `INT` | `NOT NULL` | | User ID (system-wide) |
| `UserName` | `NVARCHAR(50)` | `NOT NULL` | | Tên đăng nhập |
| `PasswordHash` | `NVARCHAR(128)` | `NOT NULL` | | Mật khẩu (hashed) |
| `FullName` | `NVARCHAR(250)` | `NOT NULL` | | Họ tên đầy đủ |
| `Email` | `NVARCHAR(100)` | | | Email |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | 1=Active, 0=Inactive |
| `CreatedDate` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo |
| `LastLogin` | `DATETIME` | | | Lần đăng nhập cuối |

**Primary Key**:
```sql
PRIMARY KEY (UserID)
```

**Unique Constraint**:
```sql
UNIQUE (UserName)
```

---

#### 3.1.3 `SiUserCompany` – User-Company Permissions (Phân quyền user-công ty)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `UserID` | `INT` | `NOT NULL` | | User ID |
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `RoleID` | `INT` | `NOT NULL` | | Role ID |
| `Permissions` | `NVARCHAR(MAX)` | | | JSON permissions |

**Primary Key**:
```sql
PRIMARY KEY (UserID, Ma_cty)
```

**Foreign Keys**:
```sql
FOREIGN KEY (UserID) REFERENCES SiUsers(UserID)
FOREIGN KEY (Ma_cty) REFERENCES SiSetup(Ma_cty)
```

---

#### 3.1.4 `SiDmKh` – Customer Master (Danh mục khách hàng)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_kh` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng |
| `Ten_kh` | `NVARCHAR(250)` | `NOT NULL` | | Tên khách hàng |
| `Dia_chi` | `NVARCHAR(500)` | | | Địa chỉ |
| `Ma_so_thue` | `NVARCHAR(20)` | | | Mã số thuế |
| `Dien_thoai` | `NVARCHAR(50)` | | | Điện thoại |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | 1=Active, 0=Inactive |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_kh)
```

**Note**: AR module có `ArDmKh` riêng, nhưng SI cung cấp master data chung.

---

#### 3.1.5 `SiDmNcc` – Vendor Master (Danh mục nhà cung cấp)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_ncc` | `NVARCHAR(20)` | `NOT NULL` | | Mã nhà cung cấp |
| `Ten_ncc` | `NVARCHAR(250)` | `NOT NULL` | | Tên nhà cung cấp |
| `Dia_chi` | `NVARCHAR(500)` | | | Địa chỉ |
| `Ma_so_thue` | `NVARCHAR(20)` | | | Mã số thuế |
| `Dien_thoai` | `NVARCHAR(50)` | | | Điện thoại |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | 1=Active, 0=Inactive |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_ncc)
```

---

#### 3.1.6 `SiDmVt` – Product Master (Danh mục vật tư)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư |
| `Ten_vt` | `NVARCHAR(250)` | `NOT NULL` | | Tên vật tư |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính |
| `Ma_nhom` | `NVARCHAR(20)` | | | Mã nhóm |
| `Gia_ban` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Giá bán |
| `Gia_mua` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Giá mua |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | 1=Active, 0=Inactive |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_vt)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
SiSetup --(1:n)--> SiUserCompany
SiUsers --(1:n)--> SiUserCompany
SiSetup --(1:n)--> SiDmKh
SiSetup --(1:n)--> SiDmNcc
SiSetup --(1:n)--> SiDmVt
```

**Key Relationships**:
1. **SiSetup → SiUserCompany**: Một công ty có nhiều user permissions
2. **SiUsers → SiUserCompany**: Một user có permissions trong nhiều công ty
3. **SiSetup → SiDm***: Mỗi công ty có danh mục master data riêng

---

### 3.3 Data Types Usage

| Data Type | Usage in SI Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `INT` | Mã công ty, UserID, RoleID | `Ma_cty`, `UserID`, `RoleID` | Primary keys |
| `NVARCHAR(n)` | Tên, mã, địa chỉ | `Ten_cty`, `Ma_kh`, `Dia_chi` | Unicode support |
| `DECIMAL(19,4)` | Giá cả | `Gia_ban`, `Gia_mua` | 4 decimal places |
| `DATETIME` | Ngày tháng | `CreatedDate`, `LastLogin` | Timestamps |
| `BIT` | Flag indicators | `Trang_thai` (sometimes) | Boolean values |
| `NVARCHAR(MAX)` | JSON permissions | `Permissions` | Flexible permission storage |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Unique Company Code**: `Ma_cty` phải unique
   - Validation logic: `Ma_cty` must be unique in `SiSetup`
   - Error message: "Mã công ty [Ma_cty] đã tồn tại"
   - Stored procedure: `asValidateCompanyCode`

2. **Unique UserName**: `UserName` phải unique
   - Validation logic: `UserName` must be unique in `SiUsers`
   - Error message: "Tên đăng nhập [UserName] đã tồn tại"
   - Stored procedure: `asValidateUserName`

3. **Active Company**: Công ty phải active để user được assign
   - Validation logic: `SiSetup.Trang_thai = 1`
   - Error message: "Công ty [Ma_cty] không active"
   - Stored procedure: `asValidateCompanyActive`

### 4.2 State Management

**Company State Machine**:
```
Active (1)
   ↓ Deactivate
Inactive (0)
   ↓ Reactivate
Active (1)
```

**User State Machine**:
```
Active (1)
   ↓ Deactivate
Inactive (0)
   ↓ Reactivate
Active (1)
   ↓ Lock (after failed attempts)
Locked (2)
```

**State Definitions**:
| Entity | State Code | State Name | Description |
|--------|------------|------------|-------------|
| Company | `1` | Active | Hoạt động bình thường |
| Company | `0` | Inactive | Ngừng hoạt động |
| User | `1` | Active | Hoạt động bình thường |
| User | `0` | Inactive | Ngừng hoạt động |
| User | `2` | Locked | Khóa do đăng nhập sai nhiều lần |

### 4.3 Calculation Rules

**Password Strength Calculation**:
- Minimum 8 characters
- At least 1 uppercase, 1 lowercase, 1 number, 1 special character
- Implementation: `asValidatePasswordStrength`

**Permission Inheritance**:
- User permissions = Role permissions + Individual permissions
- Implementation: `asGetRight` aggregates permissions
- Hierarchy: System → Company → Module → Function

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asGetSttRec`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGetSttRec`
- **Mô tả**: Lấy số thứ tự record mới (sequence number)
- **Module**: SI (System)
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pMa_bang` | `nvarchar(50)` | Tên bảng | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |

**Workflow**:
1. Kiểm tra `@pMa_cty` tồn tại trong `SiSetup`
2. Tìm sequence record trong `SiSequences` cho `@pMa_bang`
3. Nếu không có: tạo mới với giá trị 1
4. Nếu có: increment current value
5. Return new value trong `@pStt_rec`
6. Update `SiSequences` với new value

**Tables Used**:
- `SiSetup`: Validate company
- `SiSequences`: Sequence management

**Return Values**:
- `@pStt_rec`: New sequence number (e.g., "0000000001", "0000000002")

**Ví dụ sử dụng**:
```sql
DECLARE @stt_rec NVARCHAR(20);

EXEC dbo.asGetSttRec
    @pMa_cty = '001',
    @pMa_bang = 'ArPh1',
    @pStt_rec = @stt_rec OUTPUT;

-- @stt_rec now contains new sequence number
```

---

#### 5.1.2 `asGetSoCt`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGetSoCt`
- **Mô tả**: Lấy số chứng từ mới theo loại chứng từ
- **Module**: SI (System)
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` OUTPUT | Số chứng từ | ✓ | |

**Workflow**:
1. Kiểm tra `@pMa_cty` tồn tại
2. Xác định pattern số chứng từ từ `SiDocPatterns`
3. Lấy số hiện tại từ `SiDocNumbers`
4. Format theo pattern (thường: prefix + sequence + suffix)
5. Increment và update `SiDocNumbers`
6. Return formatted `@pSo_ct`

**Tables Used**:
- `SiSetup`: Validate company
- `SiDocPatterns`: Document number patterns
- `SiDocNumbers`: Current document numbers

**Ví dụ sử dụng**:
```sql
DECLARE @so_ct NVARCHAR(12);

EXEC dbo.asGetSoCt
    @pMa_cty = '001',
    @pMa_ct = 'HD',  -- Hóa đơn
    @pNgay_ct = '2023-12-15',
    @pSo_ct = @so_ct OUTPUT;

-- @so_ct might be "HD23120001" (HD + year/month + sequence)
```

---

#### 5.1.3 `asGetRight`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGetRight`
- **Mô tả**: Lấy quyền của người dùng cho module/chức năng cụ thể
- **Module**: SI (System)
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pUserID` | `int` | User ID | ✓ | |
| `@pModule` | `nvarchar(10)` | Module code | ✓ | |
| `@pFunction` | `nvarchar(50)` | Chức năng | ✓ | |
| `@pRet` | `int` OUTPUT | Kết quả quyền | ✓ | |

**Workflow**:
1. Lấy role của user cho company từ `SiUserCompany`
2. Lấy role permissions từ `SiRolePermissions`
3. Lấy individual permissions từ `SiUserPermissions`
4. Combine permissions (individual override role)
5. Check permission cho `@pModule`/`@pFunction`
6. Set `@pRet` = 1 nếu có quyền, 0 nếu không

**Tables Used**:
- `SiUserCompany`: User-company-role mapping
- `SiRolePermissions`: Role permissions
- `SiUserPermissions`: Individual user permissions

**Return Values**:
- `@pRet = 1`: User có quyền
- `@pRet = 0`: User không có quyền

**Ví dụ sử dụng**:
```sql
DECLARE @hasPermission INT;

EXEC dbo.asGetRight
    @pMa_cty = '001',
    @pUserID = 1001,
    @pModule = 'AR',
    @pFunction = 'SaveInvoice',
    @pRet = @hasPermission OUTPUT;

IF @hasPermission = 1
    PRINT 'User có quyền tạo hóa đơn';
ELSE
    PRINT 'User không có quyền tạo hóa đơn';
```

---

#### 5.1.4 `asLogError`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asLogError`
- **Mô tả**: Ghi log lỗi hệ thống
- **Module**: SI (System)
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pModule` | `nvarchar(10)` | Module code | | `'SYSTEM'` |
| `@pErrorNumber` | `int` | Mã lỗi | ✓ | |
| `@pErrorMessage` | `nvarchar(4000)` | Thông báo lỗi | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | | |
| `@pUserID` | `int` | User ID | | |
| `@pStackTrace` | `nvarchar(MAX)` | Stack trace | | |

**Workflow**:
1. Insert record vào `SiErrorLog`
2. Capture timestamp, server name, database name
3. Optionally send alert nếu là critical error
4. Maintain error log retention (auto-delete old logs)

**Tables Used**:
- `SiErrorLog`: Error logging table

**Ví dụ sử dụng**:
```sql
BEGIN TRY
    -- Some operation that might fail
    EXEC dbo.asSomeProcedure @pParam = 'value';
END TRY
BEGIN CATCH
    EXEC dbo.asLogError
        @pMa_cty = '001',
        @pModule = 'AR',
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pStt_rec = @stt_rec,
        @pUserID = @userID;
    
    THROW;
END CATCH
```

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Get** | `asGet*` | `asGetSttRec`, `asGetSoCt`, `asGetRight` | Lấy thông tin hệ thống |
| **Validate** | `asValidate*` | `asValidateCompanyCode`, `asValidateUserName` | Kiểm tra tính hợp lệ |
| **Log** | `asLog*` | `asLogError`, `asLogAudit` | Ghi log hệ thống |
| **Manage** | `asManage*` | `asManageUser`, `asManageCompany` | Quản lý hệ thống |
| **Utility** | `as*` | `asChkSoCt`, `asChkRight` | Utility functions |

---

## 6. Integration Points

### 6.1 With ALL Modules (Foundation)

**Integration Type**: System foundation

**Key Integration Points**:
1. **Company Context**: Tất cả modules sử dụng `@pMa_cty` từ SI
   - Validation: `asValidateCompany` được gọi bởi tất cả procedures
   - Data: Tất cả tables có `Ma_cty` tham chiếu đến `SiSetup`

2. **User Authentication & Authorization**:
   - Tất cả business procedures gọi `asGetRight` để check permissions
   - User sessions managed by SI
   - Audit logging via `asLogError` và `asLogAudit`

3. **Sequence Management**:
   - Tất cả modules sử dụng `asGetSttRec` cho new records
   - Tất cả modules sử dụng `asGetSoCt` cho document numbers
   - Centralized sequence management prevents conflicts

4. **Master Data**:
   - AR, AP, PO, SO, IN, CO sử dụng master data từ SI (`SiDmKh`, `SiDmNcc`, `SiDmVt`)
   - Single source of truth cho danh mục chung

### 6.2 Specific Module Dependencies

**GL Module**:
- Company fiscal year setup từ `SiSetup`
- Account master data management

**CA Module**:
- Cash/bank account setup
- Payment method configuration

**AR/AP Modules**:
- Customer/vendor master data
- Credit terms và payment conditions

**PO/SO Modules**:
- Product master data
- Pricing và discount rules

**IN Module**:
- Warehouse setup
- Unit of measure conversion

**CO Module**:
- Production routing setup
- Bill of materials management

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `SI001` | `Mã công ty [Ma_cty] không tồn tại` | Company not found in SiSetup | Tạo công ty trong hệ thống |
| `SI002` | `Tên đăng nhập [UserName] đã tồn tại` | Duplicate username | Sử dụng username khác |
| `SI003` | `User không có quyền truy cập module [Module]` | Insufficient permissions | Cấp quyền cho user |
| `SI004` | `Mật khẩu không đủ mạnh` | Password policy violation | Sử dụng mật khẩu mạnh hơn |
| `SI005` | `Số chứng từ [So_ct] đã tồn tại` | Duplicate document number | Hệ thống sequence error |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern cho SI module
BEGIN TRY
    -- SI-specific logic
    -- Validate company, user, permissions
    
    -- Log success (optional)
    EXEC asLogAudit 
        @pMa_cty = @pMa_cty,
        @pUserID = @pUserID,
        @pAction = 'ActionName',
        @pDetails = 'Success details';
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- SI-specific error handling
    -- Log error với đầy đủ context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'SI',
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pUserID = @pUserID,
        @pStackTrace = ERROR_PROCEDURE() + ' line ' + CAST(ERROR_LINE() AS NVARCHAR);
    
    -- Return SI-specific error code
    DECLARE @errorCode INT = CASE 
        WHEN ERROR_NUMBER() = 50000 THEN ERROR_STATE()
        WHEN ERROR_MESSAGE() LIKE '%công ty%' THEN 1
        WHEN ERROR_MESSAGE() LIKE '%đăng nhập%' THEN 2
        WHEN ERROR_MESSAGE() LIKE '%quyền%' THEN 3
        ELSE 999 
    END;
    
    SELECT @errorCode AS ReturnCode, ERROR_MESSAGE() AS Message;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `SiSetup(Ma_cty)` - Primary key, all lookups
2. `SiUsers(UserName)` - Login authentication
3. `SiUserCompany(UserID, Ma_cty)` - Permission lookups
4. `SiSequences(Ma_cty, Ma_bang)` - Sequence generation
5. `SiDocNumbers(Ma_cty, Ma_ct)` - Document number generation

**Recommended Indexes**:
1. `SiErrorLog(LogDate)` INCLUDE (Ma_cty, Module) - Error log queries
2. `SiAuditLog(UserID, ActionDate)` - Audit trail queries
3. `SiDmKh(Ma_cty, Ten_kh)` - Customer search by name

### 8.2 Query Optimization Tips

1. **Avoid**: Full table scan trên `SiErrorLog` (có thể rất lớn)
2. **Use**: Parameterized queries để tránh SQL injection
3. **Consider**: Partition `SiErrorLog` và `SiAuditLog` by date
4. **Use**: Caching cho static data (company info, user permissions)

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| User Login Success Rate | > 95% | `SELECT COUNT(*) FROM SiAuditLog WHERE Action='LOGIN' AND Success=1` |
| System Error Rate | < 1% | `SELECT COUNT(*) FROM SiErrorLog WHERE LogDate > DATEADD(hour, -1, GETDATE())` |
| Sequence Generation Performance | < 100ms | Monitor `asGetSttRec`, `asGetSoCt` execution time |
| Permission Check Performance | < 50ms | Monitor `asGetRight` execution time |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `SystemAdmin` | Full System Access | Toàn quyền hệ thống | Tất cả procedures |
| `CompanyAdmin` | Company Management | Quản lý công ty | `asManageCompany`, `asManageUser` |
| `ModuleAdmin` | Module Management | Quản lý module cụ thể | Module-specific procedures |
| `PowerUser` | Advanced Functions | Chức năng nâng cao | Selected procedures |
| `StandardUser` | Basic Functions | Chức năng cơ bản | Read/limited write |
| `ViewOnly` | Read Only | Chỉ xem | Read-only procedures |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering trong tất cả queries
- `asGetRight` kiểm tra user có quyền truy cập company không
- No cross-company data access trừ SystemAdmin

**Column-level Security**:
- Sensitive columns: `PasswordHash`, `Permissions`, `SalaryInfo`
- Masking: PII data masked cho certain roles
- Encryption: Sensitive data encrypted at rest

**Audit Trail**:
- Tất cả sensitive actions logged trong `SiAuditLog`
- Change tracking cho master data
- Login/logout tracking

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo công ty mới

**Steps**:
1. Validate company code chưa tồn tại
2. Insert vào `SiSetup`
3. Tạo default users và roles
4. Tạo default master data
5. Tạo default sequences và document patterns

**Example Code**:
```sql
-- Tạo công ty mới
DECLARE @ret INT;

EXEC dbo.asCreateCompany
    @pMa_cty = '002',
    @pTen_cty = N'Công ty TNHH XYZ',
    @pDia_chi = N'123 Đường ABC, Quận 1, TP.HCM',
    @pMa_so_thue = '0123456789',
    @pDien_thoai = '028123456',
    @pMa_nt = 'VND',
    @pNgay_bd_ks = '2024-01-01',
    @pNgay_kt_ks = '2024-12-31',
    @pAdminUser = N'admin002',
    @pAdminPassword = N'Password123!',
    @pAdminEmail = N'admin@xyz.com',
    @pRet = @ret OUTPUT;
```

### 10.2 Task 2: Tạo user mới và phân quyền

**Steps**:
1. Validate username chưa tồn tại
2. Insert vào `SiUsers`
3. Assign user đến công ty
4. Assign role và permissions
5. Send welcome email (nếu cấu hình)

**Example Code**:
```sql
-- Tạo user mới
DECLARE @userID INT, @ret INT;

EXEC dbo.asCreateUser
    @pUserName = N'sales.user1',
    @pPassword = N'Sales@123',
    @pFullName = N'Nguyễn Văn A',
    @pEmail = N'nguyenvana@company.com',
    @pMa_cty = '001',
    @pRoleID = 3,  -- Sales role
    @pUserID = @userID OUTPUT,
    @pRet = @ret OUTPUT;
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Cannot login** | "Invalid username or password" | User không tồn tại hoặc password sai | Reset password hoặc tạo user mới |
| **Permission denied** | "User không có quyền" | User chưa được phân quyền | Assign permissions trong `SiUserCompany` |
| **Duplicate document number** | "Số chứng từ đã tồn tại" | Sequence corruption trong `SiDocNumbers` | Reset sequence hoặc manual fix |
| **Company not found** | "Mã công ty không tồn tại" | Company chưa được tạo hoặc inactive | Tạo/activate company trong `SiSetup` |
| **Slow system performance** | High CPU trên SQL Server | Missing indexes hoặc query optimization | Create recommended indexes |

### 11.2 Debugging Tips

1. **Check**: `SELECT * FROM SiSetup WHERE Ma_cty=@pMa_cty`
2. **Verify**: `SELECT * FROM SiUsers WHERE UserName=@pUserName`
3. **Test**: Run `asGetRight` với các parameters để debug permissions
4. **Monitor**: Check `SiErrorLog` cho recent errors
5. **Analyze**: Use SQL Profiler để trace slow queries

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: System Foundation / Platform Services  
**Dependencies**: **NONE** (SI là nền tảng)  
**Criticality**: **CRITICAL** (Toàn bộ hệ thống phụ thuộc)  
**Financial Impact**: **INDIRECT** (Enable all financial modules)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query system configuration (`SiSetup`)
- Get user information (non-sensitive)
- Check system health và metrics
- Generate reports từ audit logs
- Validate data consistency

**AI Agent KHÔNG được phép**:
- Create/modify companies (`asCreateCompany`, `asUpdateCompany`)
- Create/modify users (`asCreateUser`, `asUpdateUser`)
- Change user permissions (`asAssignRole`)
- Modify system sequences (`asGetSttRec`, `asGetSoCt` logic)
- Access sensitive data (passwords, encryption keys)

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required | Impact Scope |
|--------|-----------|-------------------|--------------|
| Modify company setup | **CRITICAL** | **YES** (System Admin) | Toàn bộ hệ thống |
| Change user permissions | **HIGH** | **YES** (Security Admin) | User access control |
| Modify sequence logic | **HIGH** | **YES** (DBA) | Data integrity |
| Add new system parameter | **MEDIUM** | **YES** (System Admin) | System configuration |
| Query optimization | **LOW** | NO (DBA) | Performance only |

---

## 13. Future Enhancements

1. **Single Sign-On (SSO)**: Integration với Active Directory, OAuth
2. **Multi-factor Authentication**: 2FA cho sensitive operations
3. **API Gateway**: Centralized API management và security
4. **Configuration Management**: GUI-based system configuration
5. **Dashboard & Monitoring**: Real-time system health dashboard
6. **Automated Backup**: Scheduled backup và recovery
7. **Disaster Recovery**: High availability và failover
8. **Compliance Reporting**: Audit reports for regulatory compliance
9. **Mobile App**: Mobile access cho system administration
10. **AI-powered Security**: Anomaly detection và threat prevention

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Security Model](../05_SECURITY_MODEL.md) - Security framework built on SI
- [Multi-tenancy Model](../03_MULTI_TENANCY_MODEL.md) - Multi-tenant architecture
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - Error handling built on SI
- [Database Design](../02_DATABASE_DESIGN.md) - SI table structures
- [Naming Conventions](../09_NAMING_CONVENTION.md) - SI naming rules
- [GL Module](GL.md) - GL integration with SI
- [AR Module](AR.md) - AR integration with SI
- [AP Module](AP.md) - AP integration with SI
- [CA Module](CA.md) - CA integration with SI
- [PO Module](PO.md) - PO integration with SI
- [SO Module](SO.md) - SO integration with SI
- [IN Module](IN.md) - IN integration with SI
- [CO Module](CO.md) - CO integration with SI

---

## Technical Reference

| Document | Description |
|----------|-------------|
| [Database Schema](../../dbo/Tables/) | Cấu trúc bảng dữ liệu |
| [Module Index](../../catalog/PROCEDURES.md) | Danh mục procedures |

## Related Modules

| Module | Description |
|--------|-------------|
| [GL](../GL/) | General Ledger - Sổ cái |
| [AR](../AR/) | Accounts Receivable - Công nợ phải thu |
| [AP](../AP/) | Accounts Payable - Công nợ phải trả |
| [CA](../CA/) | Cash - Tiền mặt/Ngân hàng |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [IN](../IN/) | Inventory - Kho hàng |
| [CO](../CO/) | Manufacturing - Sản xuất |

---

# End of SI Module Documentation