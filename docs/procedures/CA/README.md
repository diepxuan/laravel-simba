# CA – Cash Management Module

---

## 1. Module Overview

### 1.1 Business Purpose

CA (Cash Management) quản lý toàn bộ dòng tiền của hệ thống ERP, bao gồm:

- Thu tiền khách hàng (Cash Receipt)
- Chi tiền nhà cung cấp (Cash Payment)
- Thu/chi nội bộ
- Chuyển khoản ngân hàng
- Theo dõi số dư tiền mặt / ngân hàng
- Tạo bút toán vào GL (General Ledger)

Module này đóng vai trò trung tâm dòng tiền và liên kết trực tiếp với:

- AR – Accounts Receivable: Nhận thanh toán từ khách hàng
- AP – Accounts Payable: Thanh toán cho nhà cung cấp
- GL – General Ledger: Ghi sổ các nghiệp vụ thu chi
- PO – Purchase Order: Tạo phiếu chi từ đơn mua hàng
- SO – Sales Order: Tạo phiếu thu từ đơn bán hàng

**Key Functions**:
- Quản lý phiếu thu, phiếu chi
- Theo dõi số dư tiền mặt và ngân hàng
- Xử lý thanh toán công nợ
- Tạo báo cáo dòng tiền
- Quản lý chuyển khoản nội bộ

**Integration Points**:
- **AR (Receivable)**: Nhận thanh toán từ khách hàng
- **AP (Payable)**: Thanh toán cho nhà cung cấp
- **GL (General Ledger)**: Post thu chi vào sổ cái
- **PO (Purchase Order)**: Tạo phiếu chi từ PO
- **SO (Sales Order)**: Tạo phiếu thu từ SO

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Cash Receipt Management | Supported | Phiếu thu tiền mặt |
| Cash Payment Management | Supported | Phiếu chi tiền mặt |
| Bank Transfer | Supported | Chuyển khoản ngân hàng |
| AR Settlement | Supported | Thanh toán công nợ phải thu |
| AP Settlement | Supported | Thanh toán công nợ phải trả |
| Internal Transfer | Supported | Chuyển nội bộ |
| GL Posting | Required | Bắt buộc post vào sổ cái |
| Bank Reconciliation | Future | Đối chiếu ngân hàng |
| Cash Flow Forecasting | Future | Dự báo dòng tiền |
| Multi-currency | Supported | Thu chi ngoại tệ |
| Petty Cash Management | Future | Quỹ tạm ứng |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Ca` (e.g., `CaPh1`, `CaCt1`, `CaPh2`, `CaCt2`)

**Stored Procedure Pattern**:
```
asCA{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asCASavePh1` - Lưu header phiếu thu
- `asCASavePh2` - Lưu header phiếu chi
- `asCAPostPh1` - Post phiếu thu vào GL
- `asCAProcessPayment` - Xử lý thanh toán
- `asCARptCashFlow` - Báo cáo dòng tiền

**Table Naming**:
- `CaPh1`: Phiếu thu (Receipt) header
- `CaCt1`: Phiếu thu (Receipt) detail
- `CaPh2`: Phiếu chi (Payment) header
- `CaCt2`: Phiếu chi (Payment) detail
- `CaDmTk`: Danh mục tài khoản ngân hàng

---

## 2. Multi-Tenancy Model

CA module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng CA đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Tài khoản ngân hàng được quản lý riêng cho từng công ty
4. Số dư tiền tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục tài khoản ngân hàng riêng (`CaDmTk`)
- Phiếu thu/chi chỉ trong phạm vi công ty
- Số dư tiền mặt tính riêng cho từng công ty
- Reports chỉ hiển thị data của công ty hiện tại

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `CaPh1` – Cash Receipt Header (Header phiếu thu)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record | Unique within company |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'PT' = Phiếu thu |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ | Receipt date |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ | Receipt number |
| `Ma_kh` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng | Customer code |
| `Ten_kh` | `NVARCHAR(250)` | `NOT NULL` | | Tên khách hàng | Customer name |
| `Ma_tk` | `NVARCHAR(20)` | `NOT NULL` | | Mã tài khoản | Cash/bank account |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải | Description |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | Total amount |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Posted, 2=Cancelled |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Currency code |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | Exchange rate |
| `User_id` | `NVARCHAR(20)` | `NOT NULL` | | User ID | Created by |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Ma_kh) REFERENCES ArDmKh(Ma_cty, Ma_kh)
FOREIGN KEY (Ma_cty, Ma_tk) REFERENCES CaDmTk(Ma_cty, Ma_tk)
```

**Indexes**:
```sql
CREATE INDEX IX_CaPh1_MaCty_MaKh ON CaPh1 (Ma_cty, Ma_kh)
CREATE INDEX IX_CaPh1_MaCty_NgayCt ON CaPh1 (Ma_cty, Ngay_ct)
CREATE INDEX IX_CaPh1_MaCty_MaTk ON CaPh1 (Ma_cty, Ma_tk)
CREATE INDEX IX_CaPh1_MaCty_TrangThai ON CaPh1 (Ma_cty, Trang_thai)
```

---

#### 3.1.2 `CaCt1` – Cash Receipt Detail (Chi tiết phiếu thu)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Stt_rec0` | `NVARCHAR(3)` | `NOT NULL` | | Số thứ tự dòng |
| `Stt_rec_ar` | `NVARCHAR(20)` | | | Reference đến AR invoice |
| `So_ct_ar` | `NVARCHAR(12)` | | | Số chứng từ AR |
| `So_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số tiền |
| `Dien_giai` | `NVARCHAR(250)` | | | Diễn giải chi tiết |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec, Stt_rec0)
```

**Foreign Key**:
```sql
FOREIGN KEY (Ma_cty, Stt_rec) REFERENCES CaPh1(Ma_cty, Stt_rec)
FOREIGN KEY (Ma_cty, Stt_rec_ar) REFERENCES ArPh1(Ma_cty, Stt_rec)
```

---

#### 3.1.3 `CaPh2` – Cash Payment Header (Header phiếu chi)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'PC' = Phiếu chi |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ |
| `Ma_ncc` | `NVARCHAR(20)` | `NOT NULL` | | Mã nhà cung cấp |
| `Ten_ncc` | `NVARCHAR(250)` | `NOT NULL` | | Tên nhà cung cấp |
| `Ma_tk` | `NVARCHAR(20)` | `NOT NULL` | | Mã tài khoản |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá |
| `User_id` | `NVARCHAR(20)` | `NOT NULL` | | User ID |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Ma_ncc) REFERENCES ApDmNcc(Ma_cty, Ma_ncc)
FOREIGN KEY (Ma_cty, Ma_tk) REFERENCES CaDmTk(Ma_cty, Ma_tk)
```

---

#### 3.1.4 `CaCt2` – Cash Payment Detail (Chi tiết phiếu chi)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Stt_rec0` | `NVARCHAR(3)` | `NOT NULL` | | Số thứ tự dòng |
| `Stt_rec_ap` | `NVARCHAR(20)` | | | Reference đến AP invoice |
| `So_ct_ap` | `NVARCHAR(12)` | | | Số chứng từ AP |
| `So_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số tiền |
| `Dien_giai` | `NVARCHAR(250)` | | | Diễn giải chi tiết |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec, Stt_rec0)
```

**Foreign Key**:
```sql
FOREIGN KEY (Ma_cty, Stt_rec) REFERENCES CaPh2(Ma_cty, Stt_rec)
FOREIGN KEY (Ma_cty, Stt_rec_ap) REFERENCES ApPh1(Ma_cty, Stt_rec)
```

---

#### 3.1.5 `CaDmTk` – Bank Account Master (Danh mục tài khoản ngân hàng)

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Ma_tk` | `NVARCHAR(20)` | `NOT NULL` | | Mã tài khoản |
| `Ten_tk` | `NVARCHAR(250)` | `NOT NULL` | | Tên tài khoản |
| `So_tk` | `NVARCHAR(50)` | | | Số tài khoản |
| `Ten_nh` | `NVARCHAR(250)` | | | Tên ngân hàng |
| `Chi_nhanh` | `NVARCHAR(250)` | | | Chi nhánh |
| `Loai_tk` | `INT` | `NOT NULL` | `0` | Loại tài khoản (0=Tiền mặt, 1=Ngân hàng) |
| `Trang_thai` | `INT` | `NOT NULL` | `1` | Trạng thái (1=Active, 0=Inactive) |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Ma_tk)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
CaDmTk --(1:n)--> CaPh1 (Receipts)
CaDmTk --(1:n)--> CaPh2 (Payments)
ArDmKh --(1:n)--> CaPh1 (Customer receipts)
ApDmNcc --(1:n)--> CaPh2 (Vendor payments)
CaPh1 --(1:n)--> CaCt1 (Receipt details)
CaPh2 --(1:n)--> CaCt2 (Payment details)
ArPh1 --(1:n)--> CaCt1 (AR settlement)
ApPh1 --(1:n)--> CaCt2 (AP settlement)
```

**Key Relationships**:
1. **CaDmTk → CaPh1/CaPh2**: Một tài khoản có nhiều phiếu thu/chi
2. **ArDmKh → CaPh1**: Một khách hàng có nhiều phiếu thu
3. **ApDmNcc → CaPh2**: Một nhà cung cấp có nhiều phiếu chi
4. **CaPh1 → CaCt1**: Một phiếu thu có nhiều dòng chi tiết
5. **CaPh2 → CaCt2**: Một phiếu chi có nhiều dòng chi tiết
6. **ArPh1 → CaCt1**: Thanh toán cho hóa đơn phải thu
7. **ApPh1 → CaCt2**: Thanh toán cho hóa đơn phải trả

---

### 3.3 Data Types Usage

| Data Type | Usage in CA Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền | `Tong_tien`, `So_tien` | 4 decimal places |
| `NVARCHAR(n)` | Mã, tên, diễn giải | `Ma_tk`, `Ten_tk`, `Dien_giai` | Unicode support |
| `INT` | Mã công ty, trạng thái, loại | `Ma_cty`, `Trang_thai`, `Loai_tk` | Integer values |
| `SMALLDATETIME` | Ngày chứng từ | `Ngay_ct` | Date values |
| `BIT` | Flag indicators | Various status flags | Boolean values |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Account Status**: Tài khoản phải active
   - Validation logic: `CaDmTk.Trang_thai = 1`
   - Error message: "Tài khoản [Ma_tk] không active"
   - Stored procedure: `asCAValidateAccount`

2. **Duplicate Document Number**: `So_ct` phải unique trong kỳ
   - Validation logic: `So_ct` must be unique per `Ma_cty`, `Ma_ct`, year
   - Error message: "Số chứng từ [So_ct] đã tồn tại"
   - Stored procedure: `asCAValidateSoCt`

3. **Sufficient Balance**: Số dư tài khoản phải đủ cho phiếu chi
   - Validation logic: `AccountBalance >= PaymentAmount`
   - Error message: "Số dư tài khoản không đủ"
   - Stored procedure: `asCAValidateBalance`

4. **Customer/Vendor Status**: Khách hàng/NCC phải active
   - Validation logic: `ArDmKh.Trang_thai = 1` or `ApDmNcc.Trang_thai = 1`
   - Error message: "Khách hàng/NCC [Ma_kh/Ma_ncc] không active"
   - Stored procedure: `asCAValidateCustomerVendor`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Post
Posted (1)
   ↓ Cancel
Cancelled (2)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp | Save, Delete, Post |
| `1` | Posted | Đã ghi sổ | View, Cancel |
| `2` | Cancelled | Đã hủy | View only |

**State Transition Rules**:
- Chỉ Draft được sửa/xóa
- Posted không được update trực tiếp
- Cancel phải tạo bút toán đảo ngược
- Không thể cancel document đã reconciled

### 4.3 Calculation Rules

**Account Balance Calculation**:
- Formula: `Balance = SUM(Receipts) - SUM(Payments)`
- Implementation: Real-time calculation in `asCAGetBalance`
- Update: After each posting, update cached balance

**Settlement Calculation**:
- Formula: `AppliedAmount = MIN(InvoiceBalance, PaymentAmount)`
- Implementation: `asCAProcessSettlement`
- Rules: Cannot overpay invoice, partial payments allowed

**Currency Conversion**:
- Formula: `LocalAmount = ForeignAmount * ExchangeRate`
- Implementation: Auto-converted in posting procedures
- Rate: Use rate on document date

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asCASavePh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCASavePh1`
- **Mô tả**: Lưu header phiếu thu
- **Module**: CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | 'PT' |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pMa_kh` | `nvarchar(20)` | Mã khách hàng | ✓ | |
| `@pTen_kh` | `nvarchar(250)` | Tên khách hàng | ✓ | |
| `@pMa_tk` | `nvarchar(20)` | Mã tài khoản | ✓ | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTong_tien` | `decimal(19,4)` | Tổng tiền | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate input parameters
2. Check account status (must be active)
3. Check customer status (must be active)
4. Validate duplicate document number
5. Insert/update `CaPh1` table
6. Return success/failure code

**Tables Used**:
- `CaPh1`: Insert/update receipt header
- `CaDmTk`: Validate account status
- `ArDmKh`: Validate customer status

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1001`: Account not found or inactive
- `@pRet = 1002`: Customer not found or inactive
- `@pRet = 1003`: Duplicate document number

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @stt_rec NVARCHAR(20);

EXEC dbo.asCASavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'PT',
    @pNgay_ct = '2024-01-15',
    @pSo_ct = 'PT001',
    @pMa_kh = 'KH001',
    @pTen_kh = 'Công ty ABC',
    @pMa_tk = 'TK001',
    @pDien_giai = 'Thu tiền bán hàng',
    @pTong_tien = 50000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.2 `asCASavePh2`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCASavePh2`
- **Mô tả**: Lưu header phiếu chi
- **Module**: CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | 'PC' |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pMa_ncc` | `nvarchar(20)` | Mã nhà cung cấp | ✓ | |
| `@pTen_ncc` | `nvarchar(250)` | Tên nhà cung cấp | ✓ | |
| `@pMa_tk` | `nvarchar(20)` | Mã tài khoản | ✓ | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTong_tien` | `decimal(19,4)` | Tổng tiền | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate input parameters
2. Check account status and balance
3. Check vendor status (must be active)
4. Validate duplicate document number
5. Insert/update `CaPh2` table
6. Return success/failure code

**Tables Used**:
- `CaPh2`: Insert/update payment header
- `CaDmTk`: Validate account status and balance
- `ApDmNcc`: Validate vendor status

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 2001`: Account not found or inactive
- `@pRet = 2002`: Insufficient account balance
- `@pRet = 2003`: Vendor not found or inactive
- `@pRet = 2004`: Duplicate document number

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @stt_rec NVARCHAR(20);

EXEC dbo.asCASavePh2
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'PC',
    @pNgay_ct = '2024-01-15',
    @pSo_ct = 'PC001',
    @pMa_ncc = 'NCC001',
    @pTen_ncc = 'Công ty XYZ',
    @pMa_tk = 'TK001',
    @pDien_giai = 'Chi tiền mua hàng',
    @pTong_tien = 30000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.3 `asCAPostPh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCAPostPh1`
- **Mô tả**: Post phiếu thu vào GL và update balances
- **Module**: CA
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
1. Validate receipt exists and is in Draft status
2. Create GL entries (Cash/Bank debit, AR credit)
3. Update receipt status to Posted (1)
4. Update account balance
5. Update customer balance if settled
6. Return success/failure

**Tables Used**:
- `CaPh1`: Update receipt status
- `CaCt1`: Get receipt details for settlement
- `GlPh1`: Create GL entries
- `CaDmTk`: Update account balance
- `ArDmKh`: Update customer balance

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 3001`: Receipt not found
- `@pRet = 3002`: Receipt already posted
- `@pRet = 3003`: GL posting failed
- `@pRet = 3004`: Account balance update failed

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asCAPostPh1
    @pMa_cty = '001',
    @pStt_rec = 'PT001',
    @pNgay_ct = '2024-01-15',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.4 `asCAPostPh2`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCAPostPh2`
- **Mô tả**: Post phiếu chi vào GL và update balances
- **Module**: CA
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
1. Validate payment exists and is in Draft status
2. Create GL entries (AP debit, Cash/Bank credit)
3. Update payment status to Posted (1)
4. Update account balance
5. Update vendor balance if settled
6. Return success/failure

**Tables Used**:
- `CaPh2`: Update payment status
- `CaCt2`: Get payment details for settlement
- `GlPh1`: Create GL entries
- `CaDmTk`: Update account balance
- `ApDmNcc`: Update vendor balance

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 4001`: Payment not found
- `@pRet = 4002`: Payment already posted
- `@pRet = 4003`: GL posting failed
- `@pRet = 4004`: Account balance update failed

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asCAPostPh2
    @pMa_cty = '001',
    @pStt_rec = 'PC001',
    @pNgay_ct = '2024-01-15',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.5 `asCAGetBalance`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCAGetBalance`
- **Mô tả**: Lấy số dư tài khoản tiền mặt/ngân hàng
- **Module**: CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pMa_tk` | `nvarchar(20)` | Mã tài khoản | | `NULL` |
| `@pAsOfDate` | `smalldatetime` | Ngày tính số dư | | `GETDATE()` |

**Workflow**:
1. Calculate balance: `SUM(Receipts) - SUM(Payments)`
2. Filter by account if specified
3. Filter by date if specified
4. Return balance data

**Tables Used**:
- `CaPh1`: Receipt amounts
- `CaPh2`: Payment amounts
- `CaDmTk`: Account information

**Return Values**:
- Result set with account balances
- Columns: AccountCode, AccountName, Balance, Currency

**Ví dụ sử dụng**:
```sql
-- Get all account balances
EXEC dbo.asCAGetBalance
    @pMa_cty = '001',
    @pMa_tk = NULL,
    @pAsOfDate = '2024-01-31';

-- Get specific account balance
EXEC dbo.asCAGetBalance
    @pMa_cty = '001',
    @pMa_tk = 'TK001',
    @pAsOfDate = '2024-01-31';
```

---

#### 5.1.6 `asCARptCashFlow`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCARptCashFlow`
- **Mô tả**: Báo cáo dòng tiền (Cash Flow Report)
- **Module**: CA
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pFromDate` | `smalldatetime` | Từ ngày | ✓ | |
| `@pToDate` | `smalldatetime` | Đến ngày | ✓ | |
| `@pMa_tk` | `nvarchar(20)` | Mã tài khoản | | `NULL` |
| `@pGroupBy` | `int` | Nhóm theo (0=Day, 1=Week, 2=Month) | | `0` |

**Workflow**:
1. Get all receipts and payments in period
2. Group by time period
3. Calculate net cash flow
4. Calculate running balance
5. Return cash flow data

**Tables Used**:
- `CaPh1`: Receipt transactions
- `CaPh2`: Payment transactions
- `CaDmTk`: Account information

**Return Values**:
- Result set with cash flow data
- Columns: Period, Receipts, Payments, NetFlow, RunningBalance

**Ví dụ sử dụng**:
```sql
EXEC dbo.asCARptCashFlow
    @pMa_cty = '001',
    @pFromDate = '2024-01-01',
    @pToDate = '2024-01-31',
    @pMa_tk = NULL,
    @pGroupBy = 0;  -- Group by day
```

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asCASave*` | `asCASavePh1`, `asCASavePh2`, `asCASaveCt1` | Insert/Update cash documents |
| **Get** | `asCAGet*` | `asCAGetBalance`, `asCAGetPh1`, `asCAGetPh2` | Query cash data |
| **Post** | `asCAPost*` | `asCAPostPh1`, `asCAPostPh2` | Post to GL and update balances |
| **Process** | `asCAProcess*` | `asCAProcessSettlement` | Process business operations |
| **Report** | `asCARpt*` | `asCARptCashFlow`, `asCARptBankReconciliation` | Generate reports |
| **Validate** | `asCAValidate*` | `asCAValidateAccount`, `asCAValidateBalance` | Validation functions |
| **Utility** | `asCA*` | `asCACalculateBalance`, `asCAUpdateBalance` | Utility functions |

---

## 6. Integration Points

### 6.1 With AR (Accounts Receivable)

**Integration Type**: Settlement and cash application

**Key Integration Points**:
1. **Receipt Application**: Áp dụng phiếu thu vào công nợ khách hàng
   - Trigger: Khi post phiếu thu
   - Data flow: Update `ArPh1.Da_tt` và `ArPh1.Con_phai_thu`
   - Stored procedures: `asCAPostPh1` → `asARUpdatePayment`

2. **Customer Balance Update**: Cập nhật số dư khách hàng
   - Trigger: Sau khi post phiếu thu
   - Data flow: Update `ArDmKh.So_du`
   - Stored procedures: `asCAPostPh1` → `asARUpdateCustomerBalance`

### 6.2 With AP (Accounts Payable)

**Integration Type**: Payment processing

**Key Integration Points**:
1. **Payment Application**: Áp dụng phiếu chi vào công nợ nhà cung cấp
   - Trigger: Khi post phiếu chi
   - Data flow: Update `ApPh1.Da_tt` và `ApPh1.Con_phai_tra`
   - Stored procedures: `asCAPostPh2` → `asAPUpdatePayment`

2. **Vendor Balance Update**: Cập nhật số dư nhà cung cấp
   - Trigger: Sau khi post phiếu chi
   - Data flow: Update `ApDmNcc.So_du`
   - Stored procedures: `asCAPostPh2` → `asAPUpdateVendorBalance`

### 6.3 With GL (General Ledger)

**Integration Type**: Financial posting

**Key Integration Points**:
1. **Receipt Posting**: Ghi sổ phiếu thu
   - Trigger: Khi post phiếu thu
   - Data flow: Create GL entries (Cash/Bank debit, AR credit)
   - Stored procedures: `asCAPostPh1` → `asGLSaveEntry`

2. **Payment Posting**: Ghi sổ phiếu chi
   - Trigger: Khi post phiếu chi
   - Data flow: Create GL entries (AP debit, Cash/Bank credit)
   - Stored procedures: `asCAPostPh2` → `asGLSaveEntry`

### 6.4 With PO (Purchase Order)

**Integration Type**: Payment creation from PO

**Key Integration Points**:
1. **Payment Creation**: Tạo phiếu chi từ đơn mua hàng
   - Trigger: Khi tạo payment từ PO
   - Data flow: Copy PO details to CA payment
   - Stored procedures: `asPOSaveCAPH4PO` → `asCASavePh2`

2. **PO Matching**: Đối chiếu payment với PO
   - Trigger: Khi tạo payment
   - Data flow: Link payment to PO reference
   - Stored procedures: `asCASavePh2` → `asPOMatchPayment`

### 6.5 With SO (Sales Order)

**Integration Type**: Receipt creation from SO

**Key Integration Points**:
1. **Receipt Creation**: Tạo phiếu thu từ đơn bán hàng
   - Trigger: Khi tạo receipt từ SO
   - Data flow: Copy SO details to CA receipt
   - Stored procedures: `asSOSaveCAPH4SO` → `asCASavePh1`

2. **SO Matching**: Đối chiếu receipt với SO
   - Trigger: Khi tạo receipt
   - Data flow: Link receipt to SO reference
   - Stored procedures: `asCASavePh1` → `asSOMatchReceipt`

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `1001` | `Account [Ma_tk] not found or inactive` | Tài khoản không tồn tại hoặc không active | Kiểm tra danh mục tài khoản |
| `1002` | `Customer [Ma_kh] not found or inactive` | Khách hàng không tồn tại hoặc không active | Kiểm tra danh mục khách hàng |
| `1003` | `Duplicate document number [So_ct]` | Số chứng từ đã tồn tại trong kỳ | Sử dụng số chứng từ khác |
| `2001` | `Insufficient balance in account [Ma_tk]` | Số dư tài khoản không đủ | Kiểm tra số dư hoặc chọn tài khoản khác |
| `2002` | `Vendor [Ma_ncc] not found or inactive` | Nhà cung cấp không tồn tại hoặc không active | Kiểm tra danh mục nhà cung cấp |
| `3001` | `Receipt not found` | Phiếu thu không tồn tại | Kiểm tra `Stt_rec` |
| `3002` | `Receipt already posted` | Phiếu thu đã được post | Không thể post lại |
| `3003` | `GL posting failed` | Lỗi khi tạo bút toán GL | Kiểm tra cấu hình tài khoản |
| `4001` | `Payment not found` | Phiếu chi không tồn tại | Kiểm tra `Stt_rec` |
| `4002` | `Payment already posted` | Phiếu chi đã được post | Không thể post lại |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for CA module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- CA-specific logic
    -- Validate business rules
    -- Process cash transactions
    -- Update balances
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- CA-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error with CA context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'CA',
        @pStt_rec = @pStt_rec,
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pErrorProcedure = ERROR_PROCEDURE();
    
    -- Return CA-specific error code
    DECLARE @errorCode INT = ERROR_NUMBER();
    DECLARE @customCode INT = CASE 
        WHEN @errorCode = 547 THEN 1001  -- Foreign key violation
        WHEN @errorCode = 2627 THEN 1003 -- Duplicate key
        WHEN @errorCode = 8115 THEN 2001 -- Arithmetic overflow (balance)
        ELSE 9999  -- General error
    END;
    
    THROW 50000, ERROR_MESSAGE(), 1;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Ma_tk)` - For account-based queries and balance calculations
2. `(Ma_cty, Ngay_ct)` - For date-based queries and reports
3. `(Ma_cty, Trang_thai)` - For status-based queries
4. `(Ma_cty, So_ct)` - For document number lookups
5. `(Ma_cty, Ma_kh)` - For customer receipt queries
6. `(Ma_cty, Ma_ncc)` - For vendor payment queries

**Recommended Indexes**:
1. `(Ma_cty, Ma_tk, Ngay_ct) INCLUDE (Tong_tien, Trang_thai)` - For cash flow reports
2. `(Ma_cty, Ngay_ct, Trang_thai) INCLUDE (Ma_tk, Tong_tien)` - For daily reconciliation
3. `(Ma_cty, Stt_rec_ar) WHERE Stt_rec_ar IS NOT NULL` - For AR settlement queries
4. `(Ma_cty, Stt_rec_ap) WHERE Stt_rec_ap IS NOT NULL` - For AP settlement queries

### 8.2 Query Optimization Tips

1. **Avoid**: SELECT * without WHERE clause on `Ma_cty`
2. **Use**: Parameterized queries with proper indexes
3. **Consider**: Partitioning by `Ma_cty` for large datasets
4. **Optimize**: Balance calculations with materialized views
5. **Cache**: Frequently accessed account balances

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| **Transaction Count** | < 50K per month per company | `SELECT COUNT(*) FROM CaPh1 WHERE Ma_cty = @ma_cty AND MONTH(Ngay_ct) = @month` |
| **Avg Response Time** | < 1 second | Monitor `asCAGetBalance`, `asCASavePh1` |
| **Lock Contention** | < 3% | Check blocking on `CaPh1`, `CaPh2`, `CaDmTk` |
| **Index Fragmentation** | < 20% | `sys.dm_db_index_physical_stats` |
| **Balance Calculation Time** | < 500ms | Monitor `asCAGetBalance` execution time |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `CA_User` | `Create Receipt` | Tạo phiếu thu | `asCASavePh1` |
| `CA_User` | `Create Payment` | Tạo phiếu chi | `asCASavePh2` |
| `CA_User` | `View Documents` | Xem phiếu thu/chi | `asCAGetPh1`, `asCAGetPh2` |
| `CA_Manager` | `Post Documents` | Post phiếu thu/chi | `asCAPostPh1`, `asCAPostPh2` |
| `CA_Manager` | `Cancel Documents` | Hủy phiếu thu/chi | `asCACancelPh1`, `asCACancelPh2` |
| `CA_Admin` | `Manage Accounts` | Quản lý tài khoản | `asCASaveAccount` |
| `Finance` | `View Reports` | Xem báo cáo dòng tiền | `asCARptCashFlow` |
| `Finance` | `View Balances` | Xem số dư tài khoản | `asCAGetBalance` |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering in all procedures
- Users can only access data of their assigned company
- No cross-company data access allowed
- Department-level restrictions for large organizations

**Column-level Security**:
- Sensitive columns: Bank account numbers, transaction details
- Masking: `XXXX-XXXX-XXXX-1234` for account numbers in reports
- Encryption: For highly sensitive financial data
- Audit logging for all financial transactions

**Procedure-level Security**:
- Execute permission granted based on role
- Validation of user permissions within procedures
- Parameter validation to prevent SQL injection
- Audit trail for all cash transactions

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo phiếu thu từ khách hàng

**Steps**:
1. Validate customer exists and is active
2. Validate account exists and is active
3. Generate document number
4. Save receipt header and details
5. Post receipt to update balances

**Example Code**:
```sql
-- Create cash receipt
DECLARE @ret INT, @stt_rec NVARCHAR(20);

-- Step 1: Save receipt
EXEC dbo.asCASavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'PT',
    @pNgay_ct = '2024-01-15',
    @pSo_ct = 'PT20240115001',
    @pMa_kh = 'KH001',
    @pTen_kh = 'Công ty ABC',
    @pMa_tk = 'TK001',
    @pDien_giai = 'Thu tiền bán hàng tháng 1',
    @pTong_tien = 75000000,
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0
BEGIN
    PRINT 'Receipt created: ' + @stt_rec;
    
    -- Step 2: Post receipt
    EXEC dbo.asCAPostPh1
        @pMa_cty = '001',
        @pStt_rec = @stt_rec,
        @pNgay_ct = '2024-01-15',
        @pUser_id = 'user01',
        @pRet = @ret OUTPUT;
        
    IF @ret = 0
        PRINT 'Receipt posted successfully';
    ELSE
        PRINT 'Error posting receipt: ' + CAST(@ret AS NVARCHAR(10));
END
ELSE
    PRINT 'Error creating receipt: ' + CAST(@ret AS NVARCHAR(10));
```

### 10.2 Task 2: Tạo phiếu chi cho nhà cung cấp

**Steps**:
1. Validate vendor exists and is active
2. Validate account has sufficient balance
3. Generate document number
4. Save payment header and details
5. Post payment to update balances

**Example Code**:
```sql
-- Create cash payment
DECLARE @ret INT, @stt_rec NVARCHAR(20);

-- Step 1: Check account balance first
DECLARE @balance DECIMAL(19,4);
SELECT @balance = dbo.fnCAGetAccountBalance('001', 'TK001', GETDATE());

IF @balance >= 50000000
BEGIN
    -- Step 2: Save payment
    EXEC dbo.asCASavePh2
        @pMa_cty = '001',
        @pStt_rec = @stt_rec OUTPUT,
        @pMa_ct = 'PC',
        @pNgay_ct = '2024-01-20',
        @pSo_ct = 'PC20240120001',
        @pMa_ncc = 'NCC001',
        @pTen_ncc = 'Công ty XYZ',
        @pMa_tk = 'TK001',
        @pDien_giai = 'Chi tiền mua nguyên vật liệu',
        @pTong_tien = 50000000,
        @pUser_id = 'user01',
        @pRet = @ret OUTPUT;

    IF @ret = 0
    BEGIN
        PRINT 'Payment created: ' + @stt_rec;
        
        -- Step 3: Post payment
        EXEC dbo.asCAPostPh2
            @pMa_cty = '001',
            @pStt_rec = @stt_rec,
            @pNgay_ct = '2024-01-20',
            @pUser_id = 'user01',
            @pRet = @ret OUTPUT;
            
        IF @ret = 0
            PRINT 'Payment posted successfully';
        ELSE
            PRINT 'Error posting payment: ' + CAST(@ret AS NVARCHAR(10));
    END
    ELSE
        PRINT 'Error creating payment: ' + CAST(@ret AS NVARCHAR(10));
END
ELSE
    PRINT 'Insufficient balance: ' + CAST(@balance AS NVARCHAR(20));
```

### 10.3 Task 3: Chạy báo cáo dòng tiền hàng tháng

**Steps**:
1. Specify date range
2. Optionally filter by account
3. Run cash flow report
4. Export results for analysis

**Example Code**:
```sql
-- Run monthly cash flow report
EXEC dbo.asCARptCashFlow
    @pMa_cty = '001',
    @pFromDate = '2024-01-01',
    @pToDate = '2024-01-31',
    @pMa_tk = NULL,  -- All accounts
    @pGroupBy = 2;   -- Group by month

-- Result format:
-- Period | Receipts | Payments | NetFlow | RunningBalance
-- Jan 2024 | 150,000,000 | 120,000,000 | 30,000,000 | 30,000,000
```

### 10.4 Task 4: Kiểm tra số dư tài khoản

**Steps**:
1. Specify account (optional)
2. Specify date (optional)
3. Run balance query
4. Review results

**Example Code**:
```sql
-- Check all account balances
EXEC dbo.asCAGetBalance
    @pMa_cty = '001',
    @pMa_tk = NULL,
    @pAsOfDate = '2024-01-31';

-- Check specific account balance
EXEC dbo.asCAGetBalance
    @pMa_cty = '001',
    @pMa_tk = 'TK001',
    @pAsOfDate = '2024-01-31';
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Insufficient Balance** | Error 2001 when saving payment | Account balance < payment amount | Check account balance or use different account |
| **Duplicate Document Number** | Error 1003 when saving | Document number already exists | Use auto-numbering or check existing documents |
| **Posting Failed** | Error 3003/4003 when posting | GL account configuration missing | Check GL account mapping for CA |
| **Slow Balance Query** | `asCAGetBalance` takes > 5 seconds | Missing indexes on `CaPh1`, `CaPh2` | Create indexes on `(Ma_cty, Ma_tk, Ngay_ct)` |
| **Lock Contention** | Timeout during month-end posting | Concurrent posting to same account | Implement queue or batch processing |
| **Currency Conversion Error** | Incorrect amounts in foreign currency | Wrong exchange rate or calculation | Verify exchange rates and conversion logic |

### 11.2 Debugging Tips

1. **Check**: Account status in `CaDmTk.Trang_thai`
2. **Verify**: Document status in `CaPh1.Trang_thai` or `CaPh2.Trang_thai`
3. **Test**: Balance calculation with `fnCAGetAccountBalance`
4. **Monitor**: Lock contention on `CaPh1`, `CaPh2` during peak hours
5. **Review**: Error logs in `asLogError` table for CA module
6. **Validate**: GL account mappings in system configuration

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Finance & Treasury  
**Dependencies**: GL (required), AR (required), AP (required), PO (optional), SO (optional)  
**Criticality**: CRITICAL (Direct cash impact)  
**Financial Impact**: YES (Actual cash movements)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query account balances (read-only)
- Generate cash flow reports
- Validate document data
- Suggest payment schedules
- Check document status
- Calculate currency conversions

**AI Agent KHÔNG được phép**:
- Post receipts or payments (requires manager approval)
- Modify account master data
- Change exchange rates
- Delete financial records
- Bypass balance validation
- Process bulk payments without review

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required | Notes |
|--------|-----------|-------------------|-------|
| **Create Receipt** | High | YES (CA_User + Manager) | Cash inflow transaction |
| **Create Payment** | Critical | YES (CA_User + Manager + Finance) | Cash outflow transaction |
| **Post Document** | Critical | YES (CA_Manager) | Financial posting to GL |
| **Cancel Document** | High | YES (CA_Manager + Finance) | Reversal of cash transaction |
| **Modify Account** | High | YES (CA_Admin + Finance) | Master data change |
| **Run Reports** | Low | NO | Read-only operation |
| **Check Balance** | Low | NO | Read-only operation |

---

## 13. Future Enhancements

1. **Bank Reconciliation**: Tự động đối chiếu ngân hàng với statement
2. **Cash Flow Forecasting**: Dự báo dòng tiền dựa trên lịch thanh toán
3. **Electronic Funds Transfer**: Tích hợp chuyển khoản điện tử
4. **Multi-bank Integration**: Kết nối với nhiều ngân hàng
5. **Payment Batch Processing**: Xử lý thanh toán hàng loạt
6. **Cash Position Dashboard**: Dashboard theo dõi vị thế tiền mặt
7. **FX Risk Management**: Quản lý rủi ro tỷ giá
8. **Cash Pooling**: Tập trung tiền mặt cho tập đoàn
9. **Automated Sweeping**: Tự động chuyển tiền giữa các tài khoản
10. **Payment Approval Workflow**: Luồng phê duyệt thanh toán đa cấp

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - Transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - Error handling guidelines
- [Database Design](../02_DATABASE_DESIGN.md) - Database design principles
- [Naming Conventions](../09_NAMING_CONVENTION.md) - Naming rules
- [GL Module Documentation](./GL.md) - General Ledger integration
- [AR Module Documentation](./AR.md) - Accounts Receivable integration
- [AP Module Documentation](./AP.md) - Accounts Payable integration
- [PO Module Documentation](./PO.md) - Purchase Order integration
- [SO Module Documentation](./SO.md) - Sales Order integration

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
| [AR](../AR/) | Accounts Receivable - Công nợ phải thu |
| [AP](../AP/) | Accounts Payable - Công nợ phải trả |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [SI](../SI/) | System - Hệ thống |

---

# End of CA Module Documentation