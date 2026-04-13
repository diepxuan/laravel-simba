# GL – General Ledger Module

---

## 1. Module Overview

### 1.1 Business Purpose

GL (General Ledger) là module sổ cái tổng hợp, trung tâm của hệ thống kế toán ERP. Module này:

- Ghi nhận tất cả các nghiệp vụ kinh tế phát sinh
- Tổng hợp số liệu từ các module nghiệp vụ (AR, AP, CA, PO, SO, IN, CO)
- Cung cấp báo cáo tài chính (Balance Sheet, Income Statement)
- Quản lý tài khoản kế toán và hệ thống tài khoản
- Thực hiện khóa sổ kỳ kế toán

**Key Functions**:
- Ghi sổ các nghiệp vụ từ module khác
- Quản lý danh mục tài khoản
- Tạo báo cáo tài chính
- Khóa sổ kỳ kế toán (month-end, year-end)
- Phân tích số liệu tài chính

**Integration Points**:
- **CA (Cash)**: Post phiếu thu/chi vào sổ cái
- **AR (Receivable)**: Post công nợ phải thu
- **AP (Payable)**: Post công nợ phải trả
- **PO (Purchase)**: Post mua hàng
- **SO (Sales)**: Post bán hàng
- **IN (Inventory)**: Post xuất/nhập kho
- **CO (Manufacturing)**: Post chi phí sản xuất

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Chart of Accounts Management | Supported | Quản lý danh mục tài khoản |
| Journal Entry Posting | Supported | Ghi sổ từ module khác |
| Manual Journal Entry | Supported | Bút toán điều chỉnh thủ công |
| Financial Reports | Supported | Balance Sheet, Income Statement |
| Trial Balance | Supported | Bảng cân đối số phát sinh |
| Account Analysis | Supported | Phân tích tài khoản |
| Period Closing | Supported | Khóa sổ tháng/năm |
| Budget vs Actual | Future | So sánh ngân sách |
| Multi-currency | Supported | Ghi nhận ngoại tệ |
| Consolidation | Future | Tổng hợp công ty con |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Gl` (e.g., `GlCt`, `GlPh1`, `GlDmTk`)

**Stored Procedure Pattern**:
```
asGL{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asGLSaveCt` - Lưu chi tiết chứng từ
- `asGLGetCt` - Lấy chi tiết chứng từ
- `asGLPost[Module]` - Post từ module khác vào GL
- `asGLRpt[ReportName]` - Báo cáo tài chính
- `asGLClosePeriod` - Khóa sổ kỳ kế toán

---

## 2. Multi-Tenancy Model

GL module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng GL đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. KHÔNG được phép truy cập chéo công ty
4. Financial reports chỉ hiển thị data của công ty hiện tại

**Implementation Details**:
- Mỗi công ty có chart of accounts riêng
- Period closing thực hiện độc lập cho từng công ty
- Financial reports generated per company
- No consolidation across companies in base system

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `GlCt` – General Ledger Detail (Chi tiết sổ cái)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record | Unique within company |
| `Stt_rec0` | `NVARCHAR(3)` | `NOT NULL` | | Số thứ tự dòng | Sequence within document |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | Document type code |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ | Must be within open period |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ | Document number |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải | Description |
| `Tk_no` | `NVARCHAR(20)` | `NOT NULL` | | Tài khoản nợ | Debit account |
| `Tk_co` | `NVARCHAR(20)` | `NOT NULL` | | Tài khoản có | Credit account |
| `Ps_no` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Phát sinh nợ | Debit amount |
| `Ps_co` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Phát sinh có | Credit amount |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Currency code |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | Exchange rate |
| `Ma_dt` | `NVARCHAR(20)` | | | Mã đối tượng | Customer/Vendor code |
| `Ma_bp` | `NVARCHAR(20)` | | | Mã bộ phận | Department code |
| `Ma_vv` | `NVARCHAR(20)` | | | Mã vụ việc | Project code |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec, Stt_rec0)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Tk_no) REFERENCES GlDmTk(Ma_cty, Ma_tk)
FOREIGN KEY (Ma_cty, Tk_co) REFERENCES GlDmTk(Ma_cty, Ma_tk)
```

**Indexes**:
```sql
CREATE INDEX IX_GlCt_MaCty_NgayCt ON GlCt (Ma_cty, Ngay_ct)
CREATE INDEX IX_GlCt_MaCty_TkNo ON GlCt (Ma_cty, Tk_no)
CREATE INDEX IX_GlCt_MaCty_TkCo ON GlCt (Ma_cty, Tk_co)
```

---

#### 3.1.2 `GlPh1` – General Ledger Header (Header chứng từ)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải |
| `Tong_ps_no` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng phát sinh nợ |
| `Tong_ps_co` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng phát sinh có |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái (0=Draft, 1=Posted) |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

---

#### 3.1.3 `GlDmTk` – Chart of Accounts (Danh mục tài khoản)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_tk` | `NVARCHAR(20)` | `NOT NULL` | | Mã tài khoản |
| `Ten_tk` | `NVARCHAR(250)` | `NOT NULL` | | Tên tài khoản |
| `Loai_tk` | `INT` | `NOT NULL` | | Loại tài khoản (1=Tài sản, 2=Nợ phải trả, 3=Vốn chủ sở hữu, 4=Doanh thu, 5=Chi phí) |
| `Tk_me` | `NVARCHAR(20)` | | | Tài khoản mẹ |
| `Bac_tk` | `INT` | `NOT NULL` | `1` | Bậc tài khoản |
| `Tk_du` | `BIT` | `NOT NULL` | `0` | Có số dư (0=Không, 1=Có) |
| `Tk_nt` | `BIT` | `NOT NULL` | `0` | Tài khoản ngoại tệ |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_tk)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
GlPh1 --(1:n)--> GlCt
GlDmTk --(1:n)--> GlCt (as Tk_no)
GlDmTk --(1:n)--> GlCt (as Tk_co)
```

**Key Relationships**:
1. **GlPh1 → GlCt**: Một header chứng từ có nhiều dòng chi tiết
2. **GlDmTk → GlCt (Tk_no)**: Tài khoản nợ phải tồn tại trong danh mục
3. **GlDmTk → GlCt (Tk_co)**: Tài khoản có phải tồn tại trong danh mục

---

### 3.3 Data Types Usage

| Data Type | Usage in GL Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền, tỷ giá | `Ps_no`, `Ps_co`, `Tong_ps_no` | 4 decimal places for precision |
| `NVARCHAR(n)` | Mã, tên, diễn giải | `Ma_tk`, `Ten_tk`, `Dien_giai` | Unicode support |
| `INT` | Mã công ty, loại tài khoản | `Ma_cty`, `Loai_tk` | Integer values |
| `BIT` | Flag indicators | `Tk_du`, `Tk_nt` | Boolean values |
| `SMALLDATETIME` | Ngày chứng từ | `Ngay_ct` | Date with time |
| `NVARCHAR(20)` | Mã đối tượng, bộ phận | `Ma_dt`, `Ma_bp`, `Ma_vv` | Dimension codes |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Double-entry Accounting**: Tổng `Ps_no` = Tổng `Ps_co` trong một chứng từ
   - Validation logic: `SUM(Ps_no) = SUM(Ps_co)` for each `Stt_rec`
   - Error message: "Tổng nợ và tổng có không cân bằng"
   - Stored procedure: `asGLValidateBalance`

2. **Open Accounting Period**: `Ngay_ct` phải trong kỳ kế toán mở
   - Validation logic: `Ngay_ct` between `Ngay_dau` and `Ngay_cuoi` of open period
   - Error message: "Ngày chứng từ ngoài kỳ kế toán mở"
   - Stored procedure: `asGLValidatePeriod`

3. **Valid Account**: `Tk_no` và `Tk_co` phải tồn tại trong `GlDmTk`
   - Validation logic: `Tk_no` and `Tk_co` must exist in `GlDmTk` for given `Ma_cty`
   - Error message: "Tài khoản [Ma_tk] không tồn tại"
   - Stored procedure: `asGLValidateAccount`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Post
Posted (1)
   ↓ (Cannot edit/delete)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp | Save, Delete, Post |
| `1` | Posted | Đã ghi sổ | View, Reverse (create reversing entry) |

### 4.3 Calculation Rules

**Account Balance Calculation**:
- Formula: `Balance = SUM(Ps_no) - SUM(Ps_co)` for each account
- Implementation: `asGLGetAccountBalance`
- Example: `EXEC asGLGetAccountBalance @pMa_cty='001', @pMa_tk='1111', @pFromDate='2023-01-01', @pToDate='2023-12-31'`

**Trial Balance Calculation**:
- Formula: Aggregate `Ps_no` and `Ps_co` by account within period
- Implementation: `asGLRptTrialBalance`
- Example: Monthly trial balance report

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asGLSaveCt`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGLSaveCt`
- **Mô tả**: Lưu chi tiết chứng từ sổ cái
- **Module**: GL
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pStt_rec0` | `nvarchar(3)` | Số thứ tự dòng | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTk_no` | `nvarchar(20)` | Tài khoản nợ | ✓ | |
| `@pTk_co` | `nvarchar(20)` | Tài khoản có | ✓ | |
| `@pPs_no` | `decimal(19,4)` | Phát sinh nợ | ✓ | `0` |
| `@pPs_co` | `decimal(19,4)` | Phát sinh có | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pMa_dt` | `nvarchar(20)` | Mã đối tượng | | |
| `@pMa_bp` | `nvarchar(20)` | Mã bộ phận | | |
| `@pMa_vv` | `nvarchar(20)` | Mã vụ việc | | |
| `@pRet` | `int` OUTPUT | Kết quả trả về | ✓ | |

**Workflow**:
1. Validate `@pMa_cty` exists
2. Validate `@pTk_no` and `@pTk_co` exist in `GlDmTk`
3. Validate accounting period is open for `@pNgay_ct`
4. Insert or update record in `GlCt`
5. Update totals in `GlPh1` (if exists)
6. Set `@pRet = 0` if success

**Tables Used**:
- `GlCt`: Insert/update chi tiết
- `GlPh1`: Update tổng cộng
- `GlDmTk`: Validate tài khoản
- `sisetup`: Validate company và period

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1`: Validation error (account not found)
- `@pRet = 2`: Period closed error
- `@pRet = 3`: Company not found

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asGLSaveCt
    @pMa_cty = '001',
    @pStt_rec = 'REC001',
    @pStt_rec0 = '001',
    @pMa_ct = 'PC',
    @pNgay_ct = '2023-12-01',
    @pSo_ct = 'PC001',
    @pDien_giai = 'Thu tiền khách hàng ABC',
    @pTk_no = '1111',
    @pTk_co = '131',
    @pPs_no = 10000000,
    @pPs_co = 10000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pMa_dt = 'KH001',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.2 `asGLRptNKC01`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGLRptNKC01`
- **Mô tả**: Báo cáo sổ cái tài khoản (Nhật ký chung)
- **Module**: GL
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pTu_ngay` | `smalldatetime` | Từ ngày | ✓ | |
| `@pDen_ngay` | `smalldatetime` | Đến ngày | ✓ | |
| `@pMa_tk` | `nvarchar(20)` | Mã tài khoản | | `''` (all accounts) |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | | `''` (all documents) |

**Workflow**:
1. Validate `@pMa_cty` exists
2. Validate `@pTu_ngay` <= `@pDen_ngay`
3. Query `GlCt` với filters
4. Join với `GlPh1` để lấy header info
5. Join với `GlDmTk` để lấy account info
6. Return result set với columns: Ngay_ct, So_ct, Dien_giai, Tk_no, Tk_co, Ps_no, Ps_co

**Tables Used**:
- `GlCt`: Chi tiết sổ cái
- `GlPh1`: Header chứng từ
- `GlDmTk`: Thông tin tài khoản

**Ví dụ sử dụng**:
```sql
EXEC dbo.asGLRptNKC01
    @pMa_cty = '001',
    @pTu_ngay = '2023-12-01',
    @pDen_ngay = '2023-12-31',
    @pMa_tk = '1111',
    @pMa_ct = 'PC';
```

---

#### 5.1.3 `asGLPostCaPh2`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asGLPostCaPh2`
- **Mô tả**: Post phiếu chi (CA module) vào sổ cái
- **Module**: GL + CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc |
|-----|-------------|-------|----------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record từ CaPh2 | ✓ |

**Workflow**:
1. Lấy thông tin từ `CaPh2` (phiếu chi header)
2. Lấy chi tiết từ `CaCt2`
3. Validate accounting period
4. Insert vào `GlCt` (multiple rows)
5. Insert/update `GlPh1`
6. Update `CaPh2.Trang_thai` = 1 (Posted)

**Tables Used**:
- `CaPh2`: Phiếu chi header
- `CaCt2`: Phiếu chi detail
- `GlCt`: Insert GL details
- `GlPh1`: Insert GL header

**Ví dụ sử dụng**:
```sql
EXEC dbo.asGLPostCaPh2
    @pMa_cty = '001',
    @pStt_rec = 'CAPH2001';
```

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asGLSave*` | `asGLSaveCt`, `asGLSaveTk` | Lưu chi tiết/tài khoản |
| **Get** | `asGLGet*` | `asGLGetCt`, `asGLGetBalance` | Lấy thông tin |
| **Post** | `asGLPost*` | `asGLPostCaPh2`, `asGLPostArPh1` | Post từ module khác |
| **Report** | `asGLRpt*` | `asGLRptNKC01`, `asGLRptCDKT` | Báo cáo tài chính |
| **Close** | `asGLClose*` | `asGLCloseMonth`, `asGLCloseYear` | Khóa sổ kỳ kế toán |
| **Validate** | `asGLValidate*` | `asGLValidateBalance`, `asGLValidatePeriod` | Kiểm tra business rules |

---

## 6. Integration Points

### 6.1 With CA (Cash Management)

**Integration Type**: Transaction posting

**Key Integration Points**:
1. **Post Cash Receipt**: `asGLPostCaPh1`
   - Trigger: Khi phiếu thu được post trong CA module
   - Data flow: `CaPh1` → `GlCt`
   - Debit: Cash account, Credit: AR account
   - Stored procedures: `asCAPostReceipt` → `asGLPostCaPh1`

2. **Post Cash Payment**: `asGLPostCaPh2`
   - Trigger: Khi phiếu chi được post trong CA module
   - Data flow: `CaPh2` → `GlCt`
   - Debit: AP account, Credit: Cash account
   - Stored procedures: `asCAPostPayment` → `asGLPostCaPh2`

### 6.2 With AR (Accounts Receivable)

**Integration Type**: Transaction posting

**Key Integration Points**:
1. **Post Sales Invoice**: `asGLPostArPh1`
   - Trigger: Khi hóa đơn bán hàng được post
   - Data flow: `ArPh1` → `GlCt`
   - Debit: AR account, Credit: Sales account
   - Stored procedures: `asARPostInvoice` → `asGLPostArPh1`

### 6.3 With AP (Accounts Payable)

**Integration Type**: Transaction posting

**Key Integration Points**:
1. **Post Purchase Invoice**: `asGLPostApPh1`
   - Trigger: Khi hóa đơn mua hàng được post
   - Data flow: `ApPh1` → `GlCt`
   - Debit: Expense account, Credit: AP account
   - Stored procedures: `asAPPostInvoice` → `asGLPostApPh1`

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `GL001` | `Tài khoản [Ma_tk] không tồn tại` | Tài khoản chưa được tạo trong danh mục | Tạo tài khoản trong GlDmTk |
| `GL002` | `Ngày chứng từ [Ngay_ct] ngoài kỳ kế toán mở` | Kỳ kế toán đã đóng | Mở kỳ kế toán hoặc sửa ngày chứng từ |
| `GL003` | `Tổng nợ [SumNo] không bằng tổng có [SumCo]` | Double-entry rule violation | Điều chỉnh số tiền cho cân bằng |
| `GL004` | `Tài khoản [Ma_tk] đã khóa số dư` | Tài khoản không cho phép ghi sổ | Sử dụng tài khoản khác hoặc mở khóa |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for GL module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- GL-specific logic
    -- Validate accounts, period, balance
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- GL-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error với module context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'GL',
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pStt_rec = @pStt_rec;
    
    -- Return GL-specific error code
    DECLARE @errorCode INT = CASE 
        WHEN ERROR_NUMBER() = 50000 THEN ERROR_STATE()
        ELSE 999 
    END;
    
    SELECT @errorCode AS ReturnCode, ERROR_MESSAGE() AS Message;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Ngay_ct)` - For date-range queries in reports
2. `(Ma_cty, Tk_no)` - For account-based queries
3. `(Ma_cty, Tk_co)` - For account-based queries
4. `(Ma_cty, Stt_rec)` - For document-based queries

**Recommended Indexes**:
1. `(Ma_cty, Ma_ct, Ngay_ct)` INCLUDE (So_ct, Dien_giai) - For document type queries
2. `(Ma_cty, Ma_dt)` INCLUDE (Ngay_ct, Ps_no, Ps_co) - For customer/vendor analysis

### 8.2 Query Optimization Tips

1. **Avoid**: `SELECT *` từ `GlCt` (table rất lớn)
2. **Use**: Date range filters luôn kèm `Ma_cty`
3. **Consider**: Partition by `Ngay_ct` cho tables lớn
4. **Use**: Covered indexes cho report queries

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| GL Transaction Volume | < 10K/day | `SELECT COUNT(*) FROM GlCt WHERE Ma_cty=@pMa_cty AND Ngay_ct=@pNgay` |
| GL Table Size | < 10GB | `SELECT SUM(reserved_page_count)*8/1024 FROM sys.dm_db_partition_stats WHERE object_id=OBJECT_ID('GlCt')` |
| Index Fragmentation | < 30% | `SELECT avg_fragmentation_in_percent FROM sys.dm_db_index_physical_stats(DB_ID(), OBJECT_ID('GlCt'), NULL, NULL, 'LIMITED')` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `GL_User` | View GL | Xem sổ cái | `asGLGetCt`, `asGLRpt*` |
| `GL_Accountant` | Post GL | Ghi sổ | `asGLSaveCt`, `asGLPost*` |
| `GL_Manager` | Close Period | Khóa sổ | `asGLCloseMonth`, `asGLCloseYear` |
| `GL_Admin` | Manage Accounts | Quản lý danh mục TK | `asGLSaveTk`, `asGLDeleteTk` |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering trong tất cả queries
- Users chỉ thấy data của công ty được phân quyền
- No cross-company access even for admins

**Column-level Security**:
- Sensitive columns: `Ps_no`, `Ps_co` (financial amounts)
- Audit columns: `CreatedBy`, `CreatedDate` (track changes)
- Masking: Số tiền có thể mask cho certain roles

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo bút toán điều chỉnh thủ công

**Steps**:
1. Xác định tài khoản nợ và có
2. Tính toán số tiền cân bằng
3. Gọi `asGLSaveCt` để lưu từng dòng
4. Gọi `asGLSaveCt` cho dòng đối ứng
5. Verify tổng nợ = tổng có

**Example Code**:
```sql
-- Tạo bút toán điều chỉnh chi phí
DECLARE @stt_rec NVARCHAR(20) = 'ADJ001';
DECLARE @ret INT;

-- Dòng 1: Nợ chi phí
EXEC dbo.asGLSaveCt
    @pMa_cty = '001',
    @pStt_rec = @stt_rec,
    @pStt_rec0 = '001',
    @pMa_ct = 'AD',
    @pNgay_ct = '2023-12-31',
    @pSo_ct = 'ADJ001',
    @pDien_giai = 'Điều chỉnh chi phí tháng 12',
    @pTk_no = '642',
    @pTk_co = '338',
    @pPs_no = 5000000,
    @pPs_co = 0,
    @pRet = @ret OUTPUT;

-- Dòng 2: Có phải trả
EXEC dbo.asGLSaveCt
    @pMa_cty = '001',
    @pStt_rec = @stt_rec,
    @pStt_rec0 = '002',
    @pMa_ct = 'AD',
    @pNgay_ct = '2023-12-31',
    @pSo_ct = 'ADJ001',
    @pDien_giai = 'Điều chỉnh chi phí tháng 12',
    @pTk_no = '338',
    @pTk_co = '642',
    @pPs_no = 0,
    @pPs_co = 5000000,
    @pRet = @ret OUTPUT;
```

### 10.2 Task 2: Chạy báo cáo sổ cái tháng

**Steps**:
1. Xác định kỳ báo cáo (từ ngày, đến ngày)
2. Chọn tài khoản (nếu cần)
3. Gọi `asGLRptNKC01`
4. Export kết quả

**Example Code**:
```sql
-- Báo cáo sổ cái tháng 12/2023
EXEC dbo.asGLRptNKC01
    @pMa_cty = '001',
    @pTu_ngay = '2023-12-01',
    @pDen_ngay = '2023-12-31',
    @pMa_tk = '',  -- Tất cả tài khoản
    @pMa_ct = '';  -- Tất cả chứng từ
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Cannot post transaction** | Error "Tài khoản không tồn tại" | Tài khoản chưa được tạo trong danh mục | Tạo tài khoản trong GlDmTk |
| **Date out of range** | Error "Ngày chứng từ ngoài kỳ kế toán mở" | Accounting period closed | Mở kỳ kế toán trong hệ thống |
| **Unbalanced transaction** | Error "Tổng nợ không bằng tổng có" | Calculation error trong application | Debug application logic |
| **Slow report generation** | Report takes > 30 seconds | Missing indexes trên GlCt | Create recommended indexes |

### 11.2 Debugging Tips

1. **Check**: `SELECT * FROM GlDmTk WHERE Ma_cty=@pMa_cty AND Ma_tk=@pMa_tk`
2. **Verify**: `SELECT * FROM ssetup WHERE Ma_cty=@pMa_cty` (accounting period)
3. **Test**: Run `asGLValidateBalance` để check transaction balance
4. **Monitor**: Check index fragmentation với `sys.dm_db_index_physical_stats`

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Financial Accounting  
**Dependencies**: ALL modules (CA, AR, AP, PO, SO, IN, CO)  
**Criticality**: **CRITICAL** (Central to financial system)  
**Financial Impact**: **YES** (Direct financial reporting)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query GL data for reporting (`asGLRpt*` procedures)
- Get account balances (`asGLGetBalance`)
- View transaction details (`asGLGetCt`)
- Generate standard financial reports

**AI Agent KHÔNG được phép**:
- Create manual journal entries (`asGLSaveCt`)
- Post transactions from other modules (`asGLPost*`)
- Close accounting periods (`asGLClose*`)
- Modify chart of accounts (`asGLSaveTk`, `asGLDeleteTk`)
- Change transaction dates or amounts

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required | Impact Scope |
|--------|-----------|-------------------|--------------|
| Modify posting logic | **CRITICAL** | **YES** (CFO/Controller) | Financial statements |
| Change account mapping | **HIGH** | **YES** (Accounting Manager) | All future transactions |
| Modify report calculations | **MEDIUM** | **YES** (GL Manager) | Financial reporting |
| Add new report | **LOW** | NO (GL User) | Reporting only |
| Query optimization | **LOW** | NO (DBA) | Performance only |

---

## 13. Future Enhancements

1. **Budget vs Actual Reporting**: So sánh thực tế với ngân sách
2. **Multi-currency Revaluation**: Tự động đánh giá lại ngoại tệ cuối kỳ
3. **Consolidation Reporting**: Tổng hợp báo cáo công ty con
4. **Automated Recurring Entries**: Bút toán định kỳ tự động
5. **Advanced Analytics**: Phân tích xu hướng tài chính
6. **Integration với BI Tools**: Power BI, Tableau connectors
7. **Audit Trail Enhancement**: Chi tiết hóa log thay đổi
8. **Workflow Approval**: Luồng phê duyệt bút toán

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - GL transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - GL error handling
- [Database Design](../02_DATABASE_DESIGN.md) - GL table structures
- [Naming Conventions](../09_NAMING_CONVENTION.md) - GL naming rules
- [CA Module](CA.md) - Cash module integration
- [AR Module](AR.md) - Receivable module integration
- [AP Module](AP.md) - Payable module integration

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
| [CA](../CA/) | Cash - Tiền mặt/Ngân hàng |
| [AR](../AR/) | Accounts Receivable - Công nợ phải thu |
| [AP](../AP/) | Accounts Payable - Công nợ phải trả |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [IN](../IN/) | Inventory - Kho hàng |
| [CO](../CO/) | Manufacturing - Sản xuất |
| [SI](../SI/) | System - Hệ thống |

---

# End of GL Module Documentation