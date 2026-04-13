# AR – Accounts Receivable Module

---

## 1. Module Overview

### 1.1 Business Purpose

AR (Accounts Receivable) quản lý công nợ phải thu từ khách hàng. Module này:

- Theo dõi các khoản phải thu từ bán hàng, cung cấp dịch vụ
- Quản lý hóa đơn bán hàng và các khoản phải thu
- Xử lý thanh toán từ khách hàng
- Theo dõi tình hình công nợ và tuổi nợ
- Cung cấp báo cáo công nợ phải thu

**Key Functions**:
- Tạo và quản lý hóa đơn bán hàng
- Theo dõi thanh toán từ khách hàng
- Quản lý công nợ và tuổi nợ
- Tạo báo cáo công nợ phải thu
- Xử lý chiết khấu và điều chỉnh công nợ

**Integration Points**:
- **SO (Sales Order)**: Tạo hóa đơn từ đơn bán hàng
- **CA (Cash)**: Nhận thanh toán từ khách hàng
- **GL (General Ledger)**: Post công nợ vào sổ cái
- **SI (System)**: Quản lý thông tin khách hàng

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Sales Invoice Management | Supported | Hóa đơn bán hàng |
| Customer Payment Processing | Supported | Nhận thanh toán |
| Credit Note Management | Supported | Hóa đơn điều chỉnh giảm |
| Debit Note Management | Supported | Hóa đơn điều chỉnh tăng |
| Aging Report | Supported | Báo cáo tuổi nợ |
| Customer Statement | Supported | Sao kê công nợ |
| Credit Limit Management | Supported | Hạn mức tín dụng |
| Collection Management | Future | Quản lý thu hồi nợ |
| Bad Debt Provision | Future | Trích lập dự phòng |
| Multi-currency | Supported | Công nợ ngoại tệ |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Ar` (e.g., `ArPh1`, `ArCt1`, `ArDmKh`)

**Stored Procedure Pattern**:
```
asAR{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asARSavePh1` - Lưu header hóa đơn
- `asARGetPh1` - Lấy thông tin hóa đơn
- `asARPostPh1` - Post hóa đơn vào GL
- `asARRpt[ReportName]` - Báo cáo công nợ
- `asARProcessPayment` - Xử lý thanh toán

---

## 2. Multi-Tenancy Model

AR module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng AR đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Khách hàng được quản lý riêng cho từng công ty
4. Công nợ tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục khách hàng riêng (`ArDmKh`)
- Hóa đơn chỉ tham chiếu đến khách hàng của cùng công ty
- Payment processing chỉ trong phạm vi công ty
- Reports chỉ hiển thị data của công ty hiện tại

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `ArPh1` – Accounts Receivable Header (Header hóa đơn)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record | Unique within company |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'HD' = Hóa đơn, 'CN' = Credit Note |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ | Invoice date |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ | Invoice number |
| `Ma_kh` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng | Customer code |
| `Ten_kh` | `NVARCHAR(250)` | `NOT NULL` | | Tên khách hàng | Customer name |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải | Description |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | Total amount before tax |
| `Tien_thue` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thuế | Tax amount |
| `Tong_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng thanh toán | Total amount including tax |
| `Da_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đã thanh toán | Paid amount |
| `Con_phai_thu` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Còn phải thu | Outstanding balance |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Posted, 2=Paid, 3=Cancelled |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Currency code |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | Exchange rate |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Ma_kh) REFERENCES ArDmKh(Ma_cty, Ma_kh)
```

**Indexes**:
```sql
CREATE INDEX IX_ArPh1_MaCty_MaKh ON ArPh1 (Ma_cty, Ma_kh)
CREATE INDEX IX_ArPh1_MaCty_NgayCt ON ArPh1 (Ma_cty, Ngay_ct)
CREATE INDEX IX_ArPh1_MaCty_TrangThai ON ArPh1 (Ma_cty, Trang_thai)
```

---

#### 3.1.2 `ArCt1` – Accounts Receivable Detail (Chi tiết hóa đơn)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Stt_rec0` | `NVARCHAR(3)` | `NOT NULL` | | Số thứ tự dòng |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư |
| `Ten_vt` | `NVARCHAR(250)` | `NOT NULL` | | Tên vật tư |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính |
| `So_luong` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng |
| `Gia` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đơn giá |
| `Tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền |
| `Thue` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thuế |
| `Tien_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thanh toán |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec, Stt_rec0)
```

**Foreign Key**:
```sql
FOREIGN KEY (Ma_cty, Stt_rec) REFERENCES ArPh1(Ma_cty, Stt_rec)
```

---

#### 3.1.3 `ArDmKh` – Customer Master (Danh mục khách hàng)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_kh` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng |
| `Ten_kh` | `NVARCHAR(250)` | `NOT NULL` | | Tên khách hàng |
| `Dia_chi` | `NVARCHAR(500)` | | | Địa chỉ |
| `Ma_so_thue` | `NVARCHAR(20)` | | | Mã số thuế |
| `Dien_thoai` | `NVARCHAR(50)` | | | Điện thoại |
| `Han_muc` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Hạn mức tín dụng |
| `No_hien_tai` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Nợ hiện tại |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | Trạng thái (1=Active, 0=Inactive) |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_kh)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
ArDmKh --(1:n)--> ArPh1
ArPh1 --(1:n)--> ArCt1
ArPh1 --(1:n)--> ArTt (Payments)
```

**Key Relationships**:
1. **ArDmKh → ArPh1**: Một khách hàng có nhiều hóa đơn
2. **ArPh1 → ArCt1**: Một hóa đơn có nhiều dòng chi tiết
3. **ArPh1 → ArTt**: Một hóa đơn có thể được thanh toán nhiều lần

---

### 3.3 Data Types Usage

| Data Type | Usage in AR Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền, số lượng, đơn giá | `Tong_tien`, `Da_tt`, `Con_phai_thu` | 4 decimal places |
| `NVARCHAR(n)` | Mã, tên, địa chỉ | `Ma_kh`, `Ten_kh`, `Dia_chi` | Unicode support |
| `INT` | Mã công ty, trạng thái | `Ma_cty`, `Trang_thai` | Integer values |
| `SMALLDATETIME` | Ngày chứng từ | `Ngay_ct` | Invoice date |
| `BIT` | Flag indicators | `Trang_thai` (partial) | Boolean values |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Credit Limit Check**: Tổng công nợ không vượt hạn mức
   - Validation logic: `No_hien_tai + Tong_tt <= Han_muc`
   - Error message: "Vượt hạn mức tín dụng khách hàng [Ma_kh]"
   - Stored procedure: `asARValidateCreditLimit`

2. **Duplicate Invoice Number**: `So_ct` phải unique trong kỳ
   - Validation logic: `So_ct` must be unique per `Ma_cty`, `Ma_ct`, year
   - Error message: "Số chứng từ [So_ct] đã tồn tại"
   - Stored procedure: `asARValidateSoCt`

3. **Customer Status**: Khách hàng phải active
   - Validation logic: `ArDmKh.Trang_thai = 1`
   - Error message: "Khách hàng [Ma_kh] không active"
   - Stored procedure: `asARValidateCustomer`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Post
Posted (1)
   ↓ Receive Payment
Partially Paid (1 with Da_tt > 0)
   ↓ Full Payment
Paid (2)
   ↓ Cancel
Cancelled (3)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp | Save, Delete, Post |
| `1` | Posted | Đã ghi sổ | View, Receive Payment, Cancel |
| `2` | Paid | Đã thanh toán đủ | View only |
| `3` | Cancelled | Đã hủy | View only |

### 4.3 Calculation Rules

**Outstanding Balance Calculation**:
- Formula: `Con_phai_thu = Tong_tt - Da_tt`
- Implementation: Auto-calculated in `asARSavePh1`, `asARProcessPayment`
- Update trigger: After payment, update `Da_tt` and `Con_phai_thu`

**Aging Calculation**:
- Formula: Categorize `Con_phai_thu` by days overdue
- Implementation: `asARRptAging`
- Categories: Current, 1-30 days, 31-60 days, 61-90 days, >90 days

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asARSavePh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asARSavePh1`
- **Mô tả**: Lưu header hóa đơn phải thu
- **Module**: AR
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pMa_kh` | `nvarchar(20)` | Mã khách hàng | ✓ | |
| `@pTen_kh` | `nvarchar(250)` | Tên khách hàng | ✓ | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTong_tien` | `decimal(19,4)` | Tổng tiền | ✓ | `0` |
| `@pTien_thue` | `decimal(19,4)` | Tiền thuế | ✓ | `0` |
| `@pTong_tt` | `decimal(19,4)` | Tổng thanh toán | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pUser` | `nvarchar(20)` | Người dùng | ✓ | |
| `@pRet` | `int` OUTPUT | Kết quả trả về | ✓ | |

**Workflow**:
1. Validate customer exists and is active
2. Check credit limit (if applicable)
3. Check duplicate invoice number
4. Get new `@pStt_rec` using `asGetSttRec`
5. Insert into `ArPh1`
6. Set `@pRet = 0` if success

**Tables Used**:
- `ArPh1`: Insert invoice header
- `ArDmKh`: Validate customer
- System tables: Get sequence number

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1`: Customer not found/inactive
- `@pRet = 2`: Credit limit exceeded
- `@pRet = 3`: Duplicate invoice number

**Ví dụ sử dụng**:
```sql
DECLARE @stt_rec NVARCHAR(20), @ret INT;

EXEC dbo.asARSavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'HD',
    @pNgay_ct = '2023-12-15',
    @pSo_ct = 'HD001',
    @pMa_kh = 'KH001',
    @pTen_kh = N'Công ty ABC',
    @pDien_giai = N'Hóa đơn bán hàng tháng 12',
    @pTong_tien = 10000000,
    @pTien_thue = 1000000,
    @pTong_tt = 11000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pUser = 'sales01',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.2 `asARPostPh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asARPostPh1`
- **Mô tả**: Post hóa đơn phải thu vào sổ cái
- **Module**: AR + GL
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc |
|-----|-------------|-------|----------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ |

**Workflow**:
1. Validate invoice exists and is in Posted state
2. Validate accounting period is open
3. Create GL entries:
   - Debit: AR account (from customer setup)
   - Credit: Sales account (from product setup)
   - Tax entry if applicable
4. Update `ArPh1.Trang_thai` = 1 (Posted)
5. Update customer balance in `ArDmKh`

**Tables Used**:
- `ArPh1`: Invoice header
- `ArCt1`: Invoice details
- `GlCt`: GL detail entries
- `GlPh1`: GL header
- `ArDmKh`: Customer master

**Ví dụ sử dụng**:
```sql
EXEC dbo.asARPostPh1
    @pMa_cty = '001',
    @pStt_rec = 'AR001';
```

---

#### 5.1.3 `asARProcessPayment`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asARProcessPayment`
- **Mô tả**: Xử lý thanh toán từ khách hàng
- **Module**: AR + CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc |
|-----|-------------|-------|----------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự invoice | ✓ |
| `@pSo_tien` | `decimal(19,4)` | Số tiền thanh toán | ✓ |
| `@pNgay_tt` | `smalldatetime` | Ngày thanh toán | ✓ |
| `@pPhuong_thuc` | `nvarchar(20)` | Phương thức TT | ✓ |
| `@pUser` | `nvarchar(20)` | Người dùng | ✓ |

**Workflow**:
1. Validate invoice exists and has outstanding balance
2. Validate payment amount <= outstanding balance
3. Create payment record in `ArTt` (payments table)
4. Update `ArPh1.Da_tt` and `ArPh1.Con_phai_thu`
5. Update customer balance in `ArDmKh`
6. If full payment, update `ArPh1.Trang_thai` = 2 (Paid)
7. Create cash receipt in CA module (if cash payment)

**Tables Used**:
- `ArPh1`: Invoice header
- `ArTt`: Payment records
- `ArDmKh`: Customer master
- `CaPh1`: Cash receipt (if applicable)

**Ví dụ sử dụng**:
```sql
EXEC dbo.asARProcessPayment
    @pMa_cty = '001',
    @pStt_rec = 'AR001',
    @pSo_tien = 5500000,
    @pNgay_tt = '2023-12-20',
    @pPhuong_thuc = 'TM',  -- Tiền mặt
    @pUser = 'cashier01';
```

---

#### 5.1.4 `asARRptBCCN01`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asARRptBCCN01`
- **Mô tả**: Báo cáo công nợ phải thu
- **Module**: AR
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pTu_ngay` | `smalldatetime` | Từ ngày | ✓ | |
| `@pDen_ngay` | `smalldatetime` | Đến ngày | ✓ | |
| `@pMa_kh` | `nvarchar(20)` | Mã khách hàng | | `''` (all customers) |
| `@pGroupBy` | `int` | Nhóm theo | | `1` (1=Customer, 2=Invoice) |

**Workflow**:
1. Query `ArPh1` for invoices in date range
2. Join with `ArDmKh` for customer info
3. Calculate opening balance, transactions, closing balance
4. Group by customer or invoice as requested
5. Return result set với aging columns

**Tables Used**:
- `ArPh1`: Invoice headers
- `ArDmKh`: Customer master
- `ArTt`: Payment records

**Ví dụ sử dụng**:
```sql
-- Báo cáo công nợ tháng 12/2023
EXEC dbo.asARRptBCCN01
    @pMa_cty = '001',
    @pTu_ngay = '2023-12-01',
    @pDen_ngay = '2023-12-31',
    @pMa_kh = '',  -- Tất cả khách hàng
    @pGroupBy = 1; -- Nhóm theo khách hàng
```

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asARSave*` | `asARSavePh1`, `asARSaveCt1` | Lưu hóa đơn/chi tiết |
| **Get** | `asARGet*` | `asARGetPh1`, `asARGetCustomer` | Lấy thông tin |
| **Post** | `asARPost*` | `asARPostPh1` | Post vào GL |
| **Process** | `asARProcess*` | `asARProcessPayment` | Xử lý thanh toán |
| **Report** | `asARRpt*` | `asARRptBCCN01`, `asARRptAging` | Báo cáo công nợ |
| **Validate** | `asARValidate*` | `asARValidateCreditLimit` | Kiểm tra business rules |

---

## 6. Integration Points

### 6.1 With SO (Sales Order)

**Integration Type**: Invoice creation

**Key Integration Points**:
1. **Create Invoice from Sales Order**: `asARCreateFromSO`
   - Trigger: Khi đơn bán hàng được xác nhận giao hàng
   - Data flow: `SoPh1` → `ArPh1` + `ArCt1`
   - Copy order details to invoice
   - Stored procedures: `asSOConfirmDelivery` → `asARCreateFromSO`

### 6.2 With CA (Cash Management)

**Integration Type**: Payment processing

**Key Integration Points**:
1. **Receive Cash Payment**: `asARProcessPayment` → `asCASaveReceipt`
   - Trigger: Khi nhận thanh toán tiền mặt
   - Data flow: AR payment → CA cash receipt
   - Create cash receipt for payment
   - Stored procedures: `asARProcessPayment` → `asCASaveReceipt`

2. **Receive Bank Transfer**: Similar flow với bank account

### 6.3 With GL (General Ledger)

**Integration Type**: Financial posting

**Key Integration Points**:
1. **Post Invoice to GL**: `asARPostPh1` → `asGLPostArPh1`
   - Trigger: Khi hóa đơn được post trong AR
   - Data flow: `ArPh1` → `GlCt`
   - Debit: AR account, Credit: Sales account
   - Stored procedures: `asARPostPh1` → `asGLPostArPh1`

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `AR001` | `Khách hàng [Ma_kh] không tồn tại hoặc không active` | Customer not found/inactive | Tạo/activate customer trong ArDmKh |
| `AR002` | `Vượt hạn mức tín dụng khách hàng [Ma_kh]` | Credit limit exceeded | Tăng hạn mức hoặc giảm số tiền |
| `AR003` | `Số chứng từ [So_ct] đã tồn tại` | Duplicate invoice number | Sử dụng số chứng từ khác |
| `AR004` | `Số tiền thanh toán vượt số dư còn phải thu` | Overpayment | Điều chỉnh số tiền thanh toán |
| `AR005` | `Hóa đơn đã được thanh toán đủ` | Invoice already paid | Không thể nhận thêm thanh toán |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for AR module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- AR-specific logic
    -- Validate customer, credit limit, invoice number
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- AR-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error với AR context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'AR',
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pStt_rec = @pStt_rec,
        @pMa_kh = @pMa_kh;
    
    -- Return AR-specific error code
    DECLARE @errorCode INT = CASE 
        WHEN ERROR_NUMBER() = 50000 THEN ERROR_STATE()
        WHEN ERROR_MESSAGE() LIKE '%khách hàng%' THEN 1
        WHEN ERROR_MESSAGE() LIKE '%hạn mức%' THEN 2
        WHEN ERROR_MESSAGE() LIKE '%chứng từ%' THEN 3
        ELSE 999 
    END;
    
    SELECT @errorCode AS ReturnCode, ERROR_MESSAGE() AS Message;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Ma_kh)` - For customer-based queries
2. `(Ma_cty, Ngay_ct)` - For date-range queries in reports
3. `(Ma_cty, Trang_thai)` - For status-based queries
4. `(Ma_cty, So_ct)` - For invoice number lookup

**Recommended Indexes**:
1. `(Ma_cty, Ma_kh, Ngay_ct)` INCLUDE (Tong_tt, Da_tt, Con_phai_thu) - For customer aging
2. `(Ma_cty, Ngay_ct, Trang_thai)` INCLUDE (Ma_kh, So_ct, Tong_tt) - For reporting

### 8.2 Query Optimization Tips

1. **Avoid**: Full table scan trên `ArPh1` (có thể rất lớn)
2. **Use**: Date range filters luôn kèm `Ma_cty`
3. **Consider**: Archive old paid invoices (> 2 years)
4. **Use**: Batch processing cho payment applications

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| AR Invoice Count | < 1K/day | `SELECT COUNT(*) FROM ArPh1 WHERE Ma_cty=@pMa_cty AND Ngay_ct=@pNgay` |
| AR Outstanding Balance | Monitor trend | `SELECT SUM(Con_phai_thu) FROM ArPh1 WHERE Ma_cty=@pMa_cty AND Trang_thai=1` |
| Average Collection Period | < 45 days | `SELECT DATEDIFF(day, Ngay_ct, GETDATE()) FROM ArPh1 WHERE Ma_cty=@pMa_cty AND Con_phai_thu > 0` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `AR_User` | View AR | Xem hóa đơn công nợ | `asARGetPh1`, `asARRpt*` |
| `AR_Clerk` | Create Invoice | Tạo hóa đơn | `asARSavePh1`, `asARSaveCt1` |
| `AR_Accountant` | Post Invoice | Ghi sổ hóa đơn | `asARPostPh1` |
| `AR_Cashier` | Process Payment | Nhận thanh toán | `asARProcessPayment` |
| `AR_Manager` | Manage Customers | Quản lý khách hàng | `asARSaveCustomer`, `asARDeleteCustomer` |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering trong tất cả queries
- Sales representatives chỉ thấy khách hàng được phân công
- Regional managers chỉ thấy data trong khu vực

**Column-level Security**:
- Sensitive columns: `Tong_tt`, `Da_tt`, `Con_phai_thu` (financial amounts)
- Customer credit info: `Han_muc`, `No_hien_tai` (credit limits)
- Masking: Số tiền có thể mask cho certain roles

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo hóa đơn bán hàng mới

**Steps**:
1. Validate khách hàng tồn tại và active
2. Kiểm tra hạn mức tín dụng
3. Tạo header hóa đơn (`asARSavePh1`)
4. Thêm các dòng chi tiết (`asARSaveCt1`)
5. Post hóa đơn vào sổ cái (`asARPostPh1`)

**Example Code**:
```sql
-- Tạo hóa đơn bán hàng
DECLARE @stt_rec NVARCHAR(20), @ret INT;

-- 1. Tạo header
EXEC dbo.asARSavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'HD',
    @pNgay_ct = '2023-12-15',
    @pSo_ct = 'HD123',
    @pMa_kh = 'KH001',
    @pTen_kh = N'Công ty ABC',
    @pDien_giai = N'Hóa đơn bán hàng tháng 12',
    @pTong_tien = 20000000,
    @pTien_thue = 2000000,
    @pTong_tt = 22000000,
    @pUser = 'sales01',
    @pRet = @ret OUTPUT;

-- 2. Thêm chi tiết (nếu cần)
-- EXEC dbo.asARSaveCt1 ... 

-- 3. Post vào sổ cái
EXEC dbo.asARPostPh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec;
```

### 10.2 Task 2: Nhận thanh toán từ khách hàng

**Steps**:
1. Xác định hóa đơn cần thanh toán
2. Kiểm tra số dư còn phải thu
3. Xử lý thanh toán (`asARProcessPayment`)
4. Cập nhật trạng thái hóa đơn nếu thanh toán đủ

**Example Code**:
```sql
-- Nhận thanh toán 50% cho hóa đơn
EXEC dbo.asARProcessPayment
    @pMa_cty = '001',
    @pStt_rec = 'AR001',
    @pSo_tien = 11000000,  -- 50% của 22,000,000
    @pNgay_tt = '2023-12-20',
    @pPhuong_thuc = 'CK',  -- Chuyển khoản
    @pUser = 'cashier01';
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Cannot create invoice** | Error "Khách hàng không tồn tại" | Customer not created in ArDmKh | Tạo khách hàng trong danh mục |
| **Credit limit error** | Error "Vượt hạn mức tín dụng" | Customer balance + new invoice > credit limit | Tăng hạn mức hoặc giảm số tiền |
| **Duplicate invoice number** | Error "Số chứng từ đã tồn tại" | Invoice number already used in period | Sử dụng số chứng từ khác |
| **Payment not applied** | Payment recorded but invoice balance not updated | Bug in payment processing logic | Debug `asARProcessPayment` |
| **Slow aging report** | Report takes > 1 minute | Missing indexes on ArPh1 | Create recommended indexes |

### 11.2 Debugging Tips

1. **Check**: `SELECT * FROM ArDmKh WHERE Ma_cty=@pMa_cty AND Ma_kh=@pMa_kh`
2. **Verify**: `SELECT Han_muc, No_hien_tai FROM ArDmKh WHERE Ma_cty=@pMa_cty AND Ma_kh=@pMa_kh`
3. **Test**: Run `asARValidateCreditLimit` để check credit availability
4. **Monitor**: Check invoice volume với `SELECT COUNT(*) FROM ArPh1 WHERE Ma_cty=@pMa_cty AND Ngay_ct=@pNgay`

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Accounts Receivable / Customer Management  
**Dependencies**: SO (Sales), CA (Cash), GL (General Ledger)  
**Criticality**: **HIGH** (Direct impact on cash flow)  
**Financial Impact**: **YES** (Customer payments and collections)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query customer information (`asARGetCustomer`)
- View invoice details (`asARGetPh1`)
- Generate aging reports (`asARRptAging`)
- Calculate customer balances
- Identify overdue invoices

**AI Agent KHÔNG được phép**:
- Create new invoices (`asARSavePh1`)
- Post invoices to GL (`asARPostPh1`)
- Process customer payments (`asARProcessPayment`)
- Modify customer credit limits
- Cancel or delete invoices

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required | Impact Scope |
|--------|-----------|-------------------|--------------|
| Modify credit limit logic | **HIGH** | **YES** (Credit Manager) | Customer credit decisions |
| Change payment application | **HIGH** | **YES** (AR Manager) | Cash application accuracy |
| Modify aging calculation | **MEDIUM** | **YES** (Controller) | Collection reporting |
| Add new report | **LOW** | NO (AR User) | Reporting only |
| Query optimization | **LOW** | NO (DBA) | Performance only |

---

## 13. Future Enhancements

1. **Automated Collection Workflow**: Tự động gửi nhắc nợ
2. **Credit Scoring Integration**: Tích hợp hệ thống chấm điểm tín dụng
3. **Electronic Invoicing**: Hóa đơn điện tử (e-invoice)
4. **Payment Gateway Integration**: Thanh toán online
5. **Customer Portal**: Self-service portal cho khách hàng
6. **Advanced Analytics**: Phân tích xu hướng thanh toán
7. **Dunning Management**: Quản lý quy trình đòi nợ
8. **Bad Debt Prediction**: Dự đoán nợ xấu bằng AI

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - AR transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - AR error handling
- [Database Design](../02_DATABASE_DESIGN.md) - AR table structures
- [Naming Conventions](../09_NAMING_CONVENTION.md) - AR naming rules
- [GL Module](GL.md) - GL integration for posting
- [CA Module](CA.md) - Cash integration for payments
- [SO Module](SO.md) - Sales order integration

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
| [GL](../GL/) | General Ledger - Sổ cái |
| [CA](../CA/) | Cash - Tiền mặt/Ngân hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [SI](../SI/) | System - Hệ thống |

---

## ASIA ERP Reference

Tài liệu tham khảo từ hệ thống ASIA ERP (legacy system):

- [AR Module Analysis](../../asia/modules/AR/) - Phân tích chi tiết module AR từ ASIA ERP
- [AR Components](../../asia/AR_SUMMARY.md) - Tổng hợp components (nếu cần tham khảo)

### Tổng quan Module AR từ ASIA ERP

Module AR trong ASIA ERP quản lý công nợ phải thu, bao gồm:
- Chứng từ hạch toán công nợ
- Phân bổ thanh toán cho hóa đơn
- Danh mục điều khoản thanh toán
- Các báo cáo công nợ phải thu đa dạng

**Components chính:**
- 10 Reports: 6 Báo cáo cân đối công nợ (BCCN01-06), 3 Bảng kê (BK01-03), 1 Drill-down (F5BCCN01a)
- 1 Voucher: ARVchAR4 (Chứng từ hạch toán công nợ)
- 1 Danh mục: ARTT (Điều khoản thanh toán)
- 1 Posting: ARPost2TT (Phân bổ thanh toán)

**Luồng dữ liệu:**
```
SO (Đơn hàng) → SI (Hóa đơn) → AR (Công nợ) → GL (Sổ cái)
```

---

# End of AR Module Documentation

