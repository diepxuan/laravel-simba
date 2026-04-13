# AP – Accounts Payable Module

---

## 1. Module Overview

### 1.1 Business Purpose

AP (Accounts Payable) quản lý công nợ phải trả cho nhà cung cấp. Module này:

- Theo dõi các khoản phải trả từ mua hàng, dịch vụ
- Quản lý hóa đơn mua hàng từ nhà cung cấp
- Xử lý thanh toán cho nhà cung cấp
- Theo dõi tình hình công nợ và thời hạn thanh toán
- Quản lý chiết khấu mua hàng và điều kiện thanh toán

**Key Functions**:
- Tạo và quản lý hóa đơn mua hàng
- Theo dõi thanh toán cho nhà cung cấp
- Quản lý công nợ và thời hạn thanh toán
- Tạo báo cáo công nợ phải trả
- Xử lý chiết khấu và điều chỉnh công nợ

**Integration Points**:
- **PO (Purchase Order)**: Tạo hóa đơn từ đơn mua hàng
- **CA (Cash)**: Thanh toán cho nhà cung cấp
- **GL (General Ledger)**: Post công nợ vào sổ cái
- **IN (Inventory)**: Nhập kho hàng mua
- **SI (System)**: Quản lý thông tin nhà cung cấp

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Purchase Invoice Management | Supported | Hóa đơn mua hàng |
| Vendor Payment Processing | Supported | Thanh toán nhà cung cấp |
| Credit Note Management | Supported | Hóa đơn điều chỉnh giảm |
| Debit Note Management | Supported | Hóa đơn điều chỉnh tăng |
| Aging Report | Supported | Báo cáo công nợ theo hạn |
| Vendor Statement | Supported | Sao kê công nợ |
| Payment Term Management | Supported | Điều kiện thanh toán |
| Cash Flow Forecasting | Future | Dự báo dòng tiền chi |
| Multi-currency | Supported | Công nợ ngoại tệ |
| 1099 Reporting | Future | Báo cáo thuế (US) |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Ap` (e.g., `ApPh1`, `ApCt1`, `ApDmNcc`)

**Stored Procedure Pattern**:
```
asAP{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asAPSavePh1` - Lưu header hóa đơn
- `asAPGetPh1` - Lấy thông tin hóa đơn
- `asAPPostPh1` - Post hóa đơn vào GL
- `asAPRpt[ReportName]` - Báo cáo công nợ
- `asAPProcessPayment` - Xử lý thanh toán

---

## 2. Multi-Tenancy Model

AP module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng AP đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Nhà cung cấp được quản lý riêng cho từng công ty
4. Công nợ tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục nhà cung cấp riêng (`ApDmNcc`)
- Hóa đơn chỉ tham chiếu đến nhà cung cấp của cùng công ty
- Payment processing chỉ trong phạm vi công ty
- Reports chỉ hiển thị data của công ty hiện tại

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `ApPh1` – Accounts Payable Header (Header hóa đơn)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record | Unique within company |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'HD' = Hóa đơn, 'CN' = Credit Note |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ | Invoice date |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ | Invoice number |
| `Ma_ncc` | `NVARCHAR(20)` | `NOT NULL` | | Mã nhà cung cấp | Vendor code |
| `Ten_ncc` | `NVARCHAR(250)` | `NOT NULL` | | Tên nhà cung cấp | Vendor name |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải | Description |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | Total amount before tax |
| `Tien_thue` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thuế | Tax amount |
| `Tong_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng thanh toán | Total amount including tax |
| `Da_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đã thanh toán | Paid amount |
| `Con_phai_tra` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Còn phải trả | Outstanding balance |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Posted, 2=Paid, 3=Cancelled |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Currency code |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | Exchange rate |
| `Han_tt` | `SMALLDATETIME` | | | Hạn thanh toán | Payment due date |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Ma_ncc) REFERENCES ApDmNcc(Ma_cty, Ma_ncc)
```

**Indexes**:
```sql
CREATE INDEX IX_ApPh1_MaCty_MaNcc ON ApPh1 (Ma_cty, Ma_ncc)
CREATE INDEX IX_ApPh1_MaCty_NgayCt ON ApPh1 (Ma_cty, Ngay_ct)
CREATE INDEX IX_ApPh1_MaCty_HanTt ON ApPh1 (Ma_cty, Han_tt)
CREATE INDEX IX_ApPh1_MaCty_TrangThai ON ApPh1 (Ma_cty, Trang_thai)
```

---

#### 3.1.2 `ApCt1` – Accounts Payable Detail (Chi tiết hóa đơn)

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
FOREIGN KEY (Ma_cty, Stt_rec) REFERENCES ApPh1(Ma_cty, Stt_rec)
```

---

#### 3.1.3 `ApDmNcc` – Vendor Master (Danh mục nhà cung cấp)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_ncc` | `NVARCHAR(20)` | `NOT NULL` | | Mã nhà cung cấp |
| `Ten_ncc` | `NVARCHAR(250)` | `NOT NULL` | | Tên nhà cung cấp |
| `Dia_chi` | `NVARCHAR(500)` | | | Địa chỉ |
| `Ma_so_thue` | `NVARCHAR(20)` | | | Mã số thuế |
| `Dien_thoai` | `NVARCHAR(50)` | | | Điện thoại |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | Trạng thái (1=Active, 0=Inactive) |
| `Ma_tt` | `NVARCHAR(20)` | | | Mã điều kiện thanh toán |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_ncc)
```

---

#### 3.1.4 `ApTt` – Payment Terms (Điều kiện thanh toán)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_tt` | `NVARCHAR(20)` | `NOT NULL` | | Mã điều kiện TT |
| `Ten_tt` | `NVARCHAR(250)` | `NOT NULL` | | Tên điều kiện TT |
| `So_ngay` | `INT` | `NOT NULL` | `0` | Số ngày |
| `Ty_le_ck` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tỷ lệ chiết khấu |
| `So_ngay_ck` | `INT` | `NOT NULL` | `0` | Số ngày được CK |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_tt)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
ApDmNcc --(1:n)--> ApPh1
ApPh1 --(1:n)--> ApCt1
ApPh1 --(1:n)--> ApTt (via Ma_tt)
ApTt --(1:n)--> ApDmNcc (via Ma_tt)
```

**Key Relationships**:
1. **ApDmNcc → ApPh1**: Một nhà cung cấp có nhiều hóa đơn
2. **ApPh1 → ApCt1**: Một hóa đơn có nhiều dòng chi tiết
3. **ApTt → ApDmNcc**: Điều kiện thanh toán áp dụng cho nhà cung cấp
4. **ApPh1 → ApTt**: Hóa đơn tham chiếu điều kiện thanh toán

---

### 3.3 Data Types Usage

| Data Type | Usage in AP Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền, số lượng, đơn giá | `Tong_tien`, `Da_tt`, `Con_phai_tra` | 4 decimal places |
| `NVARCHAR(n)` | Mã, tên, địa chỉ | `Ma_ncc`, `Ten_ncc`, `Dia_chi` | Unicode support |
| `INT` | Mã công ty, trạng thái, số ngày | `Ma_cty`, `Trang_thai`, `So_ngay` | Integer values |
| `SMALLDATETIME` | Ngày chứng từ, hạn TT | `Ngay_ct`, `Han_tt` | Date values |
| `BIT` | Flag indicators | `Trang_thai` (partial) | Boolean values |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Vendor Status**: Nhà cung cấp phải active
   - Validation logic: `ApDmNcc.Trang_thai = 1`
   - Error message: "Nhà cung cấp [Ma_ncc] không active"
   - Stored procedure: `asAPValidateVendor`

2. **Duplicate Invoice Number**: `So_ct` phải unique trong kỳ
   - Validation logic: `So_ct` must be unique per `Ma_cty`, `Ma_ct`, year
   - Error message: "Số chứng từ [So_ct] đã tồn tại"
   - Stored procedure: `asAPValidateSoCt`

3. **Payment Due Date**: `Han_tt` phải >= `Ngay_ct`
   - Validation logic: `Han_tt >= Ngay_ct`
   - Error message: "Hạn thanh toán phải sau ngày chứng từ"
   - Stored procedure: `asAPValidateDueDate`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Post
Posted (1)
   ↓ Make Payment
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
| `1` | Posted | Đã ghi sổ | View, Make Payment, Cancel |
| `2` | Paid | Đã thanh toán đủ | View only |
| `3` | Cancelled | Đã hủy | View only |

### 4.3 Calculation Rules

**Outstanding Balance Calculation**:
- Formula: `Con_phai_tra = Tong_tt - Da_tt`
- Implementation: Auto-calculated in `asAPSavePh1`, `asAPProcessPayment`
- Update trigger: After payment, update `Da_tt` and `Con_phai_tra`

**Payment Due Date Calculation**:
- Formula: `Han_tt = Ngay_ct + So_ngay` (from `ApTt`)
- Implementation: Auto-calculated in `asAPSavePh1` if `Ma_tt` provided
- Can be overridden manually

**Discount Calculation**:
- Formula: `Discount = Tong_tt * Ty_le_ck` if payment within `So_ngay_ck`
- Implementation: `asAPCalculateDiscount`
- Applied during payment processing

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asAPSavePh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPSavePh1`
- **Mô tả**: Lưu header hóa đơn phải trả
- **Module**: AP
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pMa_ncc` | `nvarchar(20)` | Mã nhà cung cấp | ✓ | |
| `@pTen_ncc` | `nvarchar(250)` | Tên nhà cung cấp | ✓ | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTong_tien` | `decimal(19,4)` | Tổng tiền | ✓ | `0` |
| `@pTien_thue` | `decimal(19,4)` | Tiền thuế | ✓ | `0` |
| `@pTong_tt` | `decimal(19,4)` | Tổng thanh toán | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pHan_tt` | `smalldatetime` | Hạn thanh toán | | |
| `@pMa_tt` | `nvarchar(20)` | Mã điều kiện TT | | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate input parameters
2. Check vendor status (must be active)
3. Validate duplicate invoice number
4. Calculate payment due date if `@pMa_tt` provided
5. Insert/update `ApPh1` table
6. Update vendor balance if invoice is posted
7. Return success/failure code

**Tables Used**:
- `ApPh1`: Insert/update invoice header
- `ApDmNcc`: Validate vendor status
- `ApTt`: Get payment terms if `@pMa_tt` provided

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1001`: Vendor not found or inactive
- `@pRet = 1002`: Duplicate invoice number
- `@pRet = 1003`: Invalid payment terms

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @stt_rec NVARCHAR(20);

EXEC dbo.asAPSavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'HD',
    @pNgay_ct = '2024-01-15',
    @pSo_ct = 'HD001',
    @pMa_ncc = 'NCC001',
    @pTen_ncc = 'Công ty ABC',
    @pDien_giai = 'Mua hàng tháng 1',
    @pTong_tien = 10000000,
    @pTien_thue = 1000000,
    @pTong_tt = 11000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pHan_tt = '2024-02-15',
    @pMa_tt = 'TT30',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.2 `asAPGetPh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPGetPh1`
- **Mô tả**: Lấy thông tin hóa đơn phải trả
- **Module**: AP
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pIncludeDetails` | `bit` | Bao gồm chi tiết | | `0` |

**Workflow**:
1. Get invoice header from `ApPh1`
2. If `@pIncludeDetails = 1`, get details from `ApCt1`
3. Return invoice data

**Tables Used**:
- `ApPh1`: Invoice header
- `ApCt1`: Invoice details (if requested)

**Return Values**:
- Result set with invoice data
- Empty result if not found

**Ví dụ sử dụng**:
```sql
EXEC dbo.asAPGetPh1
    @pMa_cty = '001',
    @pStt_rec = 'AP001',
    @pIncludeDetails = 1;
```

---

#### 5.1.3 `asAPPostPh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPPostPh1`
- **Mô tả**: Post hóa đơn vào GL (General Ledger)
- **Module**: AP
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate invoice exists and is in Draft status
2. Create GL entries for accounts payable
3. Update invoice status to Posted (1)
4. Update vendor balance
5. Return success/failure

**Tables Used**:
- `ApPh1`: Update invoice status
- `GlPh1`: Create GL entries
- `ApDmNcc`: Update vendor balance

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 2001`: Invoice not found
- `@pRet = 2002`: Invoice already posted
- `@pRet = 2003`: GL posting failed

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asAPPostPh1
    @pMa_cty = '001',
    @pStt_rec = 'AP001',
    @pNgay_ct = '2024-01-15',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.4 `asAPProcessPayment`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPProcessPayment`
- **Mô tả**: Xử lý thanh toán cho hóa đơn
- **Module**: AP
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pSo_ct_ca` | `nvarchar(12)` | Số chứng từ CA | ✓ | |
| `@pNgay_ct_ca` | `smalldatetime` | Ngày chứng từ CA | ✓ | |
| `@pTien_tt` | `decimal(19,4)` | Số tiền thanh toán | ✓ | |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate invoice exists and is Posted
2. Check payment amount <= outstanding balance
3. Create CA (Cash) entry for payment
4. Update invoice paid amount and balance
5. Update vendor balance
6. Create GL entries if needed
7. Return success/failure

**Tables Used**:
- `ApPh1`: Update paid amount
- `CaPh1`: Create cash entry
- `ApDmNcc`: Update vendor balance
- `GlPh1`: Create GL entries

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 3001`: Invoice not found
- `@pRet = 3002`: Payment amount exceeds balance
- `@pRet = 3003`: Cash entry creation failed

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asAPProcessPayment
    @pMa_cty = '001',
    @pStt_rec = 'AP001',
    @pSo_ct_ca = 'PC001',
    @pNgay_ct_ca = '2024-02-10',
    @pTien_tt = 11000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.5 `asAPRptAging`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPRptAging`
- **Mô tả**: Báo cáo công nợ theo hạn (Aging Report)
- **Module**: AP
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pAsOfDate` | `smalldatetime` | Ngày báo cáo | ✓ | |
| `@pMa_ncc` | `nvarchar(20)` | Mã nhà cung cấp | | `NULL` |
| `@pIncludeZeroBalance` | `bit` | Bao gồm số dư 0 | | `0` |

**Workflow**:
1. Get all invoices with outstanding balance
2. Calculate aging buckets (current, 1-30, 31-60, 61-90, 90+)
3. Group by vendor
4. Return aging report data

**Tables Used**:
- `ApPh1`: Invoice data
- `ApDmNcc`: Vendor information

**Return Values**:
- Result set with aging report data
- Columns: Vendor, Current, 1-30, 31-60, 61-90, 90+, Total

**Ví dụ sử dụng**:
```sql
EXEC dbo.asAPRptAging
    @pMa_cty = '001',
    @pAsOfDate = '2024-01-31',
    @pMa_ncc = NULL,
    @pIncludeZeroBalance = 0;
```

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asAPSave*` | `asAPSavePh1`, `asAPSaveCt1` | Insert/Update invoice data |
| **Get** | `asAPGet*` | `asAPGetPh1`, `asAPGetVendor` | Query invoice/vendor data |
| **Post** | `asAPPost*` | `asAPPostPh1`, `asAPPostPayment` | Post to GL or update status |
| **Process** | `asAPProcess*` | `asAPProcessPayment` | Process business operations |
| **Report** | `asAPRpt*` | `asAPRptAging`, `asAPRptVendorLedger` | Generate reports |
| **Validate** | `asAPValidate*` | `asAPValidateVendor`, `asAPValidateSoCt` | Validation functions |
| **Utility** | `asAP*` | `asAPCalculateDiscount` | Utility functions |

---

## 6. Integration Points

### 6.1 With PO (Purchase Order)

**Integration Type**: Data flow from PO to AP

**Key Integration Points**:
1. **Invoice Creation from PO**: Tạo hóa đơn từ đơn mua hàng
   - Trigger: Khi hàng nhận đủ từ PO
   - Data flow: Copy PO details to AP invoice
   - Stored procedures: `asPOSavePh1` → `asAPCreateFromPO`

2. **PO Matching**: Đối chiếu hóa đơn với PO
   - Trigger: Khi tạo hóa đơn
   - Data flow: Validate invoice against PO quantities/prices
   - Stored procedures: `asAPValidatePO`, `asPOMatchInvoice`

### 6.2 With CA (Cash Management)

**Integration Type**: Transaction processing

**Key Integration Points**:
1. **Payment Processing**: Thanh toán cho nhà cung cấp
   - Trigger: Khi tạo phiếu chi
   - Data flow: Create CA entry, update AP balance
   - Stored procedures: `asAPProcessPayment` → `asCASavePayment`

2. **Cash Flow**: Dòng tiền chi
   - Trigger: Khi lập dự báo dòng tiền
   - Data flow: Get upcoming payments from AP
   - Stored procedures: `asAPGetUpcomingPayments`

### 6.3 With GL (General Ledger)

**Integration Type**: Financial posting

**Key Integration Points**:
1. **Invoice Posting**: Ghi sổ hóa đơn
   - Trigger: Khi post hóa đơn
   - Data flow: Create GL entries for accounts payable
   - Stored procedures: `asAPPostPh1` → `asGLSaveEntry`

2. **Payment Posting**: Ghi sổ thanh toán
   - Trigger: Khi thanh toán
   - Data flow: Create GL entries for cash/bank
   - Stored procedures: `asAPProcessPayment` → `asGLSaveEntry`

### 6.4 With IN (Inventory)

**Integration Type**: Goods receipt

**Key Integration Points**:
1. **GRN Matching**: Đối chiếu nhập kho với hóa đơn
   - Trigger: Khi nhập kho từ mua hàng
   - Data flow: Link GRN to AP invoice
   - Stored procedures: `asINSavePh1` → `asAPLinkGRN`

### 6.5 With SI (System)

**Integration Type**: Master data

**Key Integration Points**:
1. **Vendor Management**: Quản lý nhà cung cấp
   - Trigger: Khi tạo/sửa nhà cung cấp
   - Data flow: Sync vendor data between SI and AP
   - Stored procedures: `asSISaveVendor` → `asAPUpdateVendor`

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `1001` | `Vendor [Ma_ncc] not found or inactive` | Nhà cung cấp không tồn tại hoặc không active | Kiểm tra danh mục nhà cung cấp |
| `1002` | `Duplicate invoice number [So_ct]` | Số chứng từ đã tồn tại trong kỳ | Sử dụng số chứng từ khác |
| `1003` | `Invalid payment terms [Ma_tt]` | Mã điều kiện thanh toán không hợp lệ | Kiểm tra danh mục điều kiện TT |
| `2001` | `Invoice not found` | Hóa đơn không tồn tại | Kiểm tra `Stt_rec` |
| `2002` | `Invoice already posted` | Hóa đơn đã được post | Không thể post lại |
| `2003` | `GL posting failed` | Lỗi khi tạo bút toán GL | Kiểm tra cấu hình tài khoản |
| `3001` | `Payment amount exceeds outstanding balance` | Số tiền thanh toán lớn hơn số dư | Kiểm tra số dư công nợ |
| `3002` | `Cash entry creation failed` | Lỗi khi tạo phiếu chi | Kiểm tra module CA |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for AP module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- AP-specific logic
    -- Validate business rules
    -- Process transactions
    -- Update balances
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- AP-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error with AP context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'AP',
        @pStt_rec = @pStt_rec,
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pErrorProcedure = ERROR_PROCEDURE();
    
    -- Return AP-specific error code
    DECLARE @errorCode INT = ERROR_NUMBER();
    DECLARE @customCode INT = CASE 
        WHEN @errorCode = 547 THEN 1001  -- Foreign key violation
        WHEN @errorCode = 2627 THEN 1002 -- Duplicate key
        ELSE 9999  -- General error
    END;
    
    THROW 50000, ERROR_MESSAGE(), 1;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Ma_ncc)` - For vendor queries and aging reports
2. `(Ma_cty, Ngay_ct)` - For date-based queries and reports
3. `(Ma_cty, Han_tt)` - For payment due date queries
4. `(Ma_cty, Trang_thai)` - For status-based queries
5. `(Ma_cty, So_ct)` - For invoice number lookups

**Recommended Indexes**:
1. `(Ma_cty, Ma_ncc, Han_tt) INCLUDE (Tong_tt, Da_tt, Con_phai_tra)` - For aging calculations
2. `(Ma_cty, Ngay_ct, Trang_thai) INCLUDE (Ma_ncc, Tong_tt)` - For daily reports

### 8.2 Query Optimization Tips

1. **Avoid**: SELECT * without WHERE clause on `Ma_cty`
2. **Use**: Parameterized queries with proper indexes
3. **Consider**: Partitioning by `Ma_cty` for large datasets
4. **Optimize**: Aging reports with pre-aggregated data

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| **Invoice Count** | < 100K per company | `SELECT COUNT(*) FROM ApPh1 WHERE Ma_cty = @ma_cty` |
| **Avg Response Time** | < 2 seconds | Monitor `asAPGetPh1`, `asAPSavePh1` |
| **Lock Contention** | < 5% | Check blocking on `ApPh1`, `ApDmNcc` |
| **Index Fragmentation** | < 30% | `sys.dm_db_index_physical_stats` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `AP_User` | `Create Invoice` | Tạo hóa đơn mua hàng | `asAPSavePh1` |
| `AP_User` | `View Invoice` | Xem hóa đơn | `asAPGetPh1` |
| `AP_Manager` | `Post Invoice` | Post hóa đơn vào GL | `asAPPostPh1` |
| `AP_Manager` | `Process Payment` | Xử lý thanh toán | `asAPProcessPayment` |
| `AP_Admin` | `Manage Vendors` | Quản lý nhà cung cấp | `asAPSaveVendor` |
| `Finance` | `View Reports` | Xem báo cáo công nợ | `asAPRptAging` |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering in all procedures
- Users can only access data of their assigned company
- No cross-company data access allowed

**Column-level Security**:
- Sensitive columns: `Ma_so_thue` (tax code), bank account info
- Masking: `XXXX-XXXX-XXXX-1234` for bank accounts in reports
- Audit logging for sensitive data access

**Procedure-level Security**:
- Execute permission granted based on role
- Validation of user permissions within procedures
- Audit trail for all financial transactions

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo hóa đơn mua hàng mới

**Steps**:
1. Validate vendor exists and is active
2. Generate invoice number
3. Calculate payment due date based on terms
4. Save invoice header and details
5. Return invoice reference

**Example Code**:
```sql
-- Create new purchase invoice
DECLARE @ret INT, @stt_rec NVARCHAR(20);

EXEC dbo.asAPSavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'HD',
    @pNgay_ct = '2024-01-15',
    @pSo_ct = 'HD20240115001',
    @pMa_ncc = 'NCC001',
    @pTen_ncc = 'Công ty ABC',
    @pDien_giai = 'Mua nguyên vật liệu tháng 1',
    @pTong_tien = 50000000,
    @pTien_thue = 5000000,
    @pTong_tt = 55000000,
    @pMa_tt = 'TT30',
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0
    PRINT 'Invoice created: ' + @stt_rec;
ELSE
    PRINT 'Error creating invoice: ' + CAST(@ret AS NVARCHAR(10));
```

### 10.2 Task 2: Thanh toán hóa đơn

**Steps**:
1. Check invoice exists and has outstanding balance
2. Validate payment amount <= outstanding balance
3. Create cash payment entry
4. Update invoice paid amount and balance
5. Update vendor balance

**Example Code**:
```sql
-- Process payment for invoice
DECLARE @ret INT;

EXEC dbo.asAPProcessPayment
    @pMa_cty = '001',
    @pStt_rec = 'AP20240115001',
    @pSo_ct_ca = 'PC20240210001',
    @pNgay_ct_ca = '2024-02-10',
    @pTien_tt = 55000000,
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0
    PRINT 'Payment processed successfully';
ELSE
    PRINT 'Error processing payment: ' + CAST(@ret AS NVARCHAR(10));
```

### 10.3 Task 3: Chạy báo cáo công nợ theo hạn

**Steps**:
1. Specify report date
2. Optionally filter by vendor
3. Run aging report
4. Export results

**Example Code**:
```sql
-- Run aging report as of month-end
EXEC dbo.asAPRptAging
    @pMa_cty = '001',
    @pAsOfDate = '2024-01-31',
    @pMa_ncc = NULL,
    @pIncludeZeroBalance = 0;

-- Result format:
-- VendorCode | VendorName | Current | 1-30 Days | 31-60 Days | 61-90 Days | 90+ Days | Total
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Invoice not posting** | Error 2003 when posting | GL account configuration missing | Check GL account mapping for AP |
| **Duplicate invoice number** | Error 1002 when saving | Invoice number already exists in period | Use auto-numbering or check existing invoices |
| **Payment amount mismatch** | Error 3001 when paying | Payment > outstanding balance | Verify invoice balance before payment |
| **Vendor not found** | Error 1001 when saving | Vendor inactive or deleted | Check vendor status in ApDmNcc |
| **Slow aging report** | Report takes > 10 seconds | Missing indexes on ApPh1 | Create indexes on (Ma_cty, Han_tt, Ma_ncc) |

### 11.2 Debugging Tips

1. **Check**: Vendor status in `ApDmNcc.Trang_thai`
2. **Verify**: Invoice status in `ApPh1.Trang_thai`
3. **Test**: Payment terms in `ApTt` table
4. **Monitor**: Lock contention on `ApPh1` during month-end
5. **Review**: Error logs in `asLogError` table

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Finance & Accounting  
**Dependencies**: GL (required), CA (required), PO (optional), SI (optional)  
**Criticality**: HIGH (Financial impact)  
**Financial Impact**: YES (Direct impact on liabilities)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query invoice data (read-only)
- Generate aging reports
- Validate vendor information
- Calculate payment due dates
- Suggest payment schedules

**AI Agent KHÔNG được phép**:
- Post invoices to GL (requires manager approval)
- Process payments (financial transaction)
- Modify vendor master data
- Change payment terms
- Delete financial records

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required | Notes |
|--------|-----------|-------------------|-------|
| **Create Invoice** | Medium | YES (AP_User) | Validate vendor and amounts |
| **Post Invoice** | High | YES (AP_Manager) | Financial posting to GL |
| **Process Payment** | Critical | YES (AP_Manager + Finance) | Actual cash outflow |
| **Modify Vendor** | High | YES (AP_Admin) | Master data change |
| **Run Reports** | Low | NO | Read-only operation |

---

## 13. Future Enhancements

1. **Automated Payment Processing**: Tự động tạo lệnh thanh toán theo hạn
2. **Early Payment Discount**: Tính toán và áp dụng chiết khấu thanh toán sớm
3. **Vendor Portal**: Portal cho nhà cung cấp xem công nợ và hóa đơn
4. **Three-way Matching**: Tự động đối chiếu PO - GRN - Invoice
5. **Cash Flow Forecasting**: Dự báo dòng tiền chi từ công nợ phải trả
6. **Electronic Invoicing**: Nhận và xử lý hóa đơn điện tử
7. **Vendor Performance Analytics**: Phân tích hiệu quả nhà cung cấp
8. **Multi-currency Optimization**: Tối ưu tỷ giá và thanh toán ngoại tệ

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - Transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - Error handling guidelines
- [Database Design](../02_DATABASE_DESIGN.md) - Database design principles
- [Naming Conventions](../09_NAMING_CONVENTION.md) - Naming rules
- [GL Module Documentation](./GL.md) - General Ledger integration
- [CA Module Documentation](./CA.md) - Cash Management integration
- [PO Module Documentation](./PO.md) - Purchase Order integration

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
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [IN](../IN/) | Inventory - Kho hàng |
| [SI](../SI/) | System - Hệ thống |

---

## ASIA ERP Reference

Tài liệu tham khảo từ hệ thống ASIA ERP (legacy system):

- [AP Module Analysis](../../asia/modules/AP/) - Phân tích chi tiết module AP từ ASIA ERP
- [AP Components](../../asia/AP_SUMMARY.md) - Tổng hợp components (nếu cần tham khảo)

### Tổng quan Module AP từ ASIA ERP

Module AP trong ASIA ERP quản lý công nợ phải trả, bao gồm:
- Chứng từ thanh toán phải trả
- Thông tin thanh toán (thanh toán tất toán)
- Các báo cáo công nợ phải trả

**Components chính:**
- 3 Reports: APRptBK01 (Bảng kê chứng từ mua hàng), APRptBK02 (Bảng kê công nợ theo hạn), APRptBK03 (Chi tiết công nợ phải trả)
- 1 Voucher: ApVchAP4 (Chứng từ thanh toán)
- 1 Danh mục: APTT (Thông tin thanh toán)

**Luồng dữ liệu:**
```
PO (Mua hàng) → AP (Công nợ phải trả) → GL (Sổ cái)
```

---

# End of AP Module Documentation