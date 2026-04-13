# PO – Purchase Order Module

---

## 1. Module Overview

### 1.1 Business Purpose

PO (Purchase Order) quản lý quy trình mua sắm hàng hóa và dịch vụ, từ khi tạo yêu cầu mua hàng đến khi phát hành đơn đặt hàng chính thức cho nhà cung cấp. Module này:

- Theo dõi các yêu cầu mua hàng (Purchase Requisitions)
- Tạo và quản lý đơn mua hàng (Purchase Orders)
- Gửi đơn mua hàng cho nhà cung cấp
- Theo dõi tình trạng đơn mua hàng (chờ duyệt, đã duyệt, đã nhận hàng, đã thanh toán)
- Quản lý thông tin nhà cung cấp và điều khoản mua hàng
- Liên kết với các module khác như AP, GL, IN, SI.

**Key Functions**:
- Quản lý Yêu cầu mua hàng (PR)
- Quản lý Đơn mua hàng (PO)
- Quy trình phê duyệt PO
- Theo dõi trạng thái PO
- Liên kết với Nhập kho (IN) và Công nợ phải trả (AP)
- Quản lý danh mục nhà cung cấp và điều khoản thanh toán

**Integration Points**:
- **SI (System)**: Quản lý danh mục nhà cung cấp, vật tư, đơn vị tính, điều khoản thanh toán.
- **AP (Accounts Payable)**: Tạo hóa đơn mua hàng từ PO, đối chiếu công nợ.
- **GL (General Ledger)**: Post các bút toán liên quan đến mua hàng.
- **IN (Inventory)**: Nhận hàng theo PO, cập nhật số lượng tồn kho.
- **CA (Cash)**: Thanh toán cho nhà cung cấp dựa trên PO.

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Purchase Requisition | Supported | Yêu cầu mua hàng nội bộ |
| Purchase Order Creation | Supported | Tạo đơn mua hàng |
| PO Approval Workflow | Supported | Quy trình phê duyệt nhiều cấp |
| PO Receiving | Supported | Ghi nhận hàng nhận từ PO |
| PO to AP Invoice Conversion | Supported | Tạo hóa đơn từ PO |
| PO to GL Posting | Required | Post vào sổ cái |
| Vendor Management | Linked to SI | Quản lý nhà cung cấp |
| Payment Terms | Linked to AP/SI | Điều khoản thanh toán |
| Multi-currency PO | Supported | PO ngoại tệ |
| PO Returns | Future | Trả hàng cho NCC |
| Blanket PO | Future | Đơn mua hàng khung |
| Change Order | Future | Thay đổi PO đã phát hành |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Po` (e.g., `PoPh1`, `PoCt1`, `PoDmNcc`)

**Stored Procedure Pattern**:
```sql
asPO{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asPOSavePh1` - Lưu header đơn mua hàng
- `asPOGetPh1` - Lấy thông tin đơn mua hàng
- `asPOProcessPO` - Xử lý phê duyệt/gửi PO
- `asAPCreateFromPO` - Tạo hóa đơn AP từ PO
- `asINReceiveFromPO` - Ghi nhận nhập kho từ PO
- `asPORptPOStatus` - Báo cáo trạng thái PO

**Table Naming**:
- `PoPh1`: PO Header
- `PoCt1`: PO Detail
- `PoDmNcc`: Vendor Master (linked or copied)
- `PoTerms`: Payment Terms (linked or copied)
- `PoReqH`: Purchase Requisition Header
- `PoReqCt`: Purchase Requisition Detail

---

## 2. Multi-Tenancy Model

PO module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng PO đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Nhà cung cấp và vật tư được quản lý riêng cho từng công ty (hoặc tham chiếu từ SI)
4. Đơn mua hàng, yêu cầu mua hàng tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục yêu cầu mua hàng, đơn mua hàng riêng.
- PO chỉ tham chiếu đến nhà cung cấp của cùng công ty.
- Các báo cáo PO chỉ hiển thị data của công ty hiện tại.

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `PoPh1` – Purchase Order Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record | Unique within company |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'PO' = Purchase Order |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ | PO Date |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ | PO Number |
| `Ma_ncc` | `NVARCHAR(20)` | `NOT NULL` | | Mã nhà cung cấp | Vendor Code |
| `Ten_ncc` | `NVARCHAR(250)` | `NOT NULL` | | Tên nhà cung cấp | Vendor Name |
| `Ma_yc` | `NVARCHAR(20)` | | | Mã yêu cầu mua hàng | Link to PR |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải | PO Description |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | Total amount before tax |
| `Tien_thue` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thuế | Tax amount |
| `Tong_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng thanh toán | Total amount including tax |
| `Da_nhan` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đã nhận hàng | Quantity received |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Approved, 2=Sent, 3=Received, 4=Closed, 5=Cancelled |
| `Ma_nt` | `NVARCHAR(3)` | `NOT NULL` | `VND` | Mã ngoại tệ | Currency code |
| `Ty_gia` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | Exchange rate |
| `Ma_tt` | `NVARCHAR(20)` | | | Mã điều kiện TT | Payment Terms Code |
| `User_id` | `NVARCHAR(20)` | `NOT NULL` | | User ID | Created by |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Ma_ncc) REFERENCES SiDmNcc(Ma_cty, Ma_ncc)
FOREIGN KEY (Ma_cty, Ma_tt) REFERENCES ApTt(Ma_cty, Ma_tt)
FOREIGN KEY (Ma_cty, Ma_yc) REFERENCES PoReqH(Ma_cty, Stt_rec)
```

**Indexes**:
```sql
CREATE INDEX IX_PoPh1_MaCty_MaNcc ON PoPh1 (Ma_cty, Ma_ncc)
CREATE INDEX IX_PoPh1_MaCty_NgayCt ON PoPh1 (Ma_cty, Ngay_ct)
CREATE INDEX IX_PoPh1_MaCty_TrangThai ON PoPh1 (Ma_cty, Trang_thai)
CREATE INDEX IX_PoPh1_MaCty_MaYc ON PoPh1 (Ma_cty, Ma_yc)
```

---

#### 3.1.2 `PoCt1` – Purchase Order Detail

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Stt_rec0` | `NVARCHAR(3)` | `NOT NULL` | | Số thứ tự dòng |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư |
| `Ten_vt` | `NVARCHAR(250)` | `NOT NULL` | | Tên vật tư |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính |
| `So_luong_yc` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng yêu cầu |
| `So_luong_po` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng PO |
| `So_luong_nh` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng đã nhận |
| `Gia` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đơn giá |
| `Tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền |
| `Thue` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thuế |
| `Tien_tt` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thanh toán |
| `Ma_tk_nv` | `NVARCHAR(20)` | | | Tài khoản Nợ Vốn (cho GL Post) |
| `Ma_tk_co` | `NVARCHAR(20)` | | | Tài khoản Có Vốn (cho GL Post) |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec, Stt_rec0)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Stt_rec) REFERENCES PoPh1(Ma_cty, Stt_rec)
FOREIGN KEY (Ma_cty, Ma_vt) REFERENCES SiDmVt(Ma_cty, Ma_vt)
FOREIGN KEY (Ma_cty, Dvt) REFERENCES SiDmDvt(Ma_cty, Ma_dvt)
```

---

#### 3.1.3 `PoReqH` – Purchase Requisition Header

| Column | Type | Nullable | Default | Description |
|--------|------|----------|---------|-------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty |
| `Stt_rec` | `NVARCHAR(20)` | `NOT NULL` | | Số thứ tự record |
| `Ma_ct` | `NVARCHAR(3)` | `NOT NULL` | | Mã chứng từ | 'PR' = Purchase Requisition |
| `Ngay_ct` | `SMALLDATETIME` | `NOT NULL` | | Ngày chứng từ |
| `So_ct` | `NVARCHAR(12)` | `NOT NULL` | | Số chứng từ |
| `Ma_phb` | `NVARCHAR(20)` | `NOT NULL` | | Mã phòng ban yêu cầu |
| `Dien_giai` | `NVARCHAR(250)` | `NOT NULL` | | Diễn giải |
| `Tong_tien` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền |
| `Trang_thai` | `INT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Approved, 2=Converted to PO, 3=Cancelled |
| `User_id` | `NVARCHAR(20)` | `NOT NULL` | | User ID |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Stt_rec)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
SiDmNcc --(1:n)--> PoPh1
ApTt --(1:n)--> PoPh1 (via Ma_tt)
PoReqH --(1:n)--> PoPh1 (via Ma_yc)
PoPh1 --(1:n)--> PoCt1
PoPh1 --(1:n)--> PoReqH (via Ma_yc)
SiDmVt --(1:n)--> PoCt1
SiDmDvt --(1:n)--> PoCt1
SiDmNcc --(1:n)--> PoPh1
ApPh1 --(1:n)--> PoCt1 (for AP Invoice linkage)
InPh1 --(1:n)--> PoCt1 (for GRN linkage)
```

**Key Relationships**:
1. **SiDmNcc → PoPh1**: Một nhà cung cấp có nhiều đơn mua hàng.
2. **ApTt → PoPh1**: Điều kiện thanh toán áp dụng cho đơn mua hàng.
3. **PoReqH → PoPh1**: Một yêu cầu mua hàng có thể tạo nhiều đơn mua hàng.
4. **PoPh1 → PoCt1**: Một đơn mua hàng có nhiều dòng chi tiết.
5. **SiDmVt → PoCt1**: Vật tư tham chiếu trong dòng chi tiết.
6. **PoCt1 → ApPh1**: Dòng chi tiết PO liên kết với hóa đơn AP.
7. **PoCt1 → InPh1**: Dòng chi tiết PO liên kết với phiếu nhập kho.

---

### 3.3 Data Types Usage

| Data Type | Usage in PO Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền, số lượng, đơn giá | `Tong_tien`, `So_luong_po`, `Gia` | 4 decimal places |
| `NVARCHAR(n)` | Mã, tên, diễn giải | `Ma_ncc`, `Ten_ncc`, `Dien_giai` | Unicode support |
| `INT` | Mã công ty, trạng thái | `Ma_cty`, `Trang_thai` | Integer values |
| `SMALLDATETIME` | Ngày chứng từ | `Ngay_ct` | Date values |
| `BIT` | Flag indicators | Various status flags | Boolean values |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **Vendor Status**: Nhà cung cấp phải active
   - Validation logic: `SiDmNcc.Trang_thai = 1`
   - Error message: "Nhà cung cấp [Ma_ncc] không active"
   - Stored procedure: `asPOValidateVendor`

2. **Duplicate PO Number**: `So_ct` phải unique trong kỳ
   - Validation logic: `So_ct` must be unique per `Ma_cty`, `Ma_ct`, year
   - Error message: "Số chứng từ [So_ct] đã tồn tại"
   - Stored procedure: `asPOValidateSoCt`

3. **Sufficient Requisition Quantity**: Số lượng PO không được vượt số lượng yêu cầu
   - Validation logic: `PoCt1.So_luong_po <= PoReqCt.So_luong_yc` (if linked)
   - Error message: "Số lượng PO vượt quá số lượng yêu cầu"
   - Stored procedure: `asPOValidateQty`

4. **PO Total vs. Details**: Tổng tiền PO phải bằng tổng chi tiết
   - Validation logic: `PoPh1.Tong_tien = SUM(PoCt1.Tien_tt)`
   - Error message: "Tổng tiền đơn hàng không khớp với tổng chi tiết"
   - Stored procedure: `asPOValidateTotal`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Submit for Approval
Pending Approval (0.5)
   ↓ Approve
Approved (1)
   ↓ Send to Vendor
Sent (2)
   ↓ Receive Goods
Partially Received (3)
   ↓ Fully Received
Received (3.1)
   ↓ Create Invoice
Invoiced (4)
   ↓ Cancel
Cancelled (5)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp | Save, Delete, Submit, Cancel |
| `0.5` | Pending Approval | Chờ duyệt | Approve/Reject |
| `1` | Approved | Đã duyệt | Send, Edit (limited), Cancel |
| `2` | Sent | Đã gửi NCC | Receive Goods, Cancel |
| `3` | Partially Received | Đã nhận một phần | Receive Goods, Cancel |
| `3.1` | Received | Đã nhận đủ | Create Invoice, Cancel |
| `4` | Invoiced | Đã xuất hóa đơn AP | View only |
| `5` | Cancelled | Đã hủy | View only |

### 4.3 Calculation Rules

**PO Total Calculation**:
- Formula: `Tong_tt = SUM(Tien_tt)` of all `PoCt1` lines for the PO
- Implementation: Auto-calculated in `asPOSavePh1` and `asPOSaveCt1`

**Received Quantity Calculation**:
- Formula: `Da_nhan` in `PoPh1` is SUM(`So_luong_nh`) from `PoCt1` linked to GRN.
- Implementation: Updated when Goods Receipt (IN module) is posted.

**PO Status Update**:
- Status changes based on approvals, sending, receiving, and invoicing.
- Logic in `asPOProcessPO`, `asINReceiveFromPO`, `asAPCreateFromPO`.

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asPOSavePh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asPOSavePh1`
- **Mô tả**: Lưu header đơn mua hàng
- **Module**: PO
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record | ✓ | |
| `@pMa_ct` | `nvarchar(3)` | Mã chứng từ | ✓ | 'PO' |
| `@pNgay_ct` | `smalldatetime` | Ngày chứng từ | ✓ | |
| `@pSo_ct` | `nvarchar(12)` | Số chứng từ | ✓ | |
| `@pMa_ncc` | `nvarchar(20)` | Mã nhà cung cấp | ✓ | |
| `@pTen_ncc` | `nvarchar(250)` | Tên nhà cung cấp | ✓ | |
| `@pMa_yc` | `nvarchar(20)` | Mã yêu cầu mua hàng | | |
| `@pDien_giai` | `nvarchar(250)` | Diễn giải | ✓ | |
| `@pTong_tien` | `decimal(19,4)` | Tổng tiền | ✓ | `0` |
| `@pTien_thue` | `decimal(19,4)` | Tiền thuế | ✓ | `0` |
| `@pTong_tt` | `decimal(19,4)` | Tổng thanh toán | ✓ | `0` |
| `@pMa_nt` | `nvarchar(3)` | Mã ngoại tệ | | `VND` |
| `@pTy_gia` | `decimal(19,4)` | Tỷ giá | | `1` |
| `@pMa_tt` | `nvarchar(20)` | Mã điều kiện TT | | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate input parameters
2. Check vendor status (must be active)
3. Check PR linkage and quantity if provided
4. Validate duplicate PO number
5. Insert/update `PoPh1` table
6. Update PO status to Draft (0)
7. Return success/failure code

**Tables Used**:
- `PoPh1`: Insert/update PO header
- `SiDmNcc`: Validate vendor status
- `PoReqH`, `PoReqCt`: Validate PR linkage and quantity

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1001`: Vendor not found or inactive
- `@pRet = 1002`: PR not found or invalid
- `@pRet = 1003`: Duplicate PO number

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @stt_rec NVARCHAR(20);

EXEC dbo.asPOSavePh1
    @pMa_cty = '001',
    @pStt_rec = @stt_rec OUTPUT,
    @pMa_ct = 'PO',
    @pNgay_ct = '2024-02-01',
    @pSo_ct = 'PO20240201001',
    @pMa_ncc = 'NCC001',
    @pTen_ncc = 'Nhà Cung Cấp A',
    @pMa_yc = 'PR001',
    @pDien_giai = 'Mua máy tính văn phòng',
    @pTong_tien = 10000000,
    @pTien_thue = 1000000,
    @pTong_tt = 11000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pMa_tt = 'TT30',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.2 `asPOSaveCt1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asPOSaveCt1`
- **Mô tả**: Lưu chi tiết đơn mua hàng
- **Module**: PO
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record PO Header | ✓ | |
| `@pStt_rec0` | `nvarchar(3)` | Số thứ tự dòng | ✓ | |
| `@pMa_vt` | `nvarchar(20)` | Mã vật tư |
| `@pTen_vt` | `nvarchar(250)` | Tên vật tư |
| `@pDvt` | `nvarchar(20)` | Đơn vị tính |
| `@pSo_luong_yc` | `decimal(19,4)` | Số lượng yêu cầu | ✓ | `0` |
| `@pSo_luong_po` | `decimal(19,4)` | Số lượng PO | ✓ | `0` |
| `@pGia` | `decimal(19,4)` | Đơn giá |
| `@pTien` | `decimal(19,4)` | Thành tiền |
| `@pThue` | `decimal(19,4)` | Thuế |
| `@pTien_tt` | `decimal(19,4)` | Tiền thanh toán |
| `@pMa_tk_nv` | `nvarchar(20)` | Tài khoản Nợ Vốn | | |
| `@pMa_tk_co` | `nvarchar(20)` | Tài khoản Có Vốn | | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate input parameters
2. Check item and unit of measure validity
3. Check if `So_luong_po` <= `So_luong_yc` (if linked to PR)
4. Calculate `Tien` = `So_luong_po` * `Gia`
5. Calculate `Tien_tt` = `Tien` + `Thue`
6. Insert/update `PoCt1` table
7. Recalculate `PoPh1.Tong_tien`, `Tong_tt`
8. Return success/failure code

**Tables Used**:
- `PoCt1`: Insert/update PO detail
- `PoPh1`: Update header totals
- `SiDmVt`: Validate item code
- `SiDmDvt`: Validate unit of measure
- `PoReqCt`: Validate against requisition quantity

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 1101`: Item not found
- `@pRet = 1102`: Invalid unit of measure
- `@pRet = 1103`: PO quantity exceeds requisition quantity

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asPOSaveCt1
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pStt_rec0 = '001',
    @pMa_vt = 'VT001',
    @pTen_vt = 'Máy tính Dell',
    @pDvt = 'Chiếc',
    @pSo_luong_yc = 10,
    @pSo_luong_po = 10,
    @pGia = 10000000,
    @pThue = 1000000,
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.3 `asPOGetPh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asPOGetPh1`
- **Mô tả**: Lấy thông tin header đơn mua hàng
- **Module**: PO
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pIncludeDetails` | `bit` | Bao gồm chi tiết | | `0` |

**Workflow**:
1. Get PO header from `PoPh1`
2. If `@pIncludeDetails = 1`, get details from `PoCt1`
3. Return PO data

**Tables Used**:
- `PoPh1`: PO header
- `PoCt1`: PO details (if requested)

**Return Values**:
- Result set with PO data
- Empty result if not found

**Ví dụ sử dụng**:
```sql
EXEC dbo.asPOGetPh1
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pIncludeDetails = 1;
```

---

#### 5.1.4 `asPOProcessPO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asPOProcessPO`
- **Mô tả**: Xử lý các hành động trên PO (Submit, Approve, Send, Receive, Invoice)
- **Module**: PO
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pStt_rec` | `nvarchar(20)` | Số thứ tự record | ✓ | |
| `@pAction` | `nvarchar(50)` | Hành động ('SUBMIT', 'APPROVE', 'SEND', 'RECEIVE', 'INVOICE', 'CANCEL') | ✓ | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate current PO status and user permissions
2. Perform actions based on `@pAction`:
   - **SUBMIT**: Change status to Pending Approval (0.5)
   - **APPROVE**: Change status to Approved (1)
   - **SEND**: Change status to Sent (2), trigger notification
   - **RECEIVE**: Link to IN receipt, update `Da_nhan`, change status (Partial/Full Received)
   - **INVOICE**: Link to AP invoice, change status to Invoiced (4)
   - **CANCEL**: Change status to Cancelled (5)
3. Update PO status and related records
4. Return success/failure

**Tables Used**:
- `PoPh1`: Update PO status and received quantities
- `PoCt1`: Update received quantities per line
- `SiUser`: Validate user permissions
- `InPh1`: Link to GRN
- `ApPh1`: Link to AP Invoice

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 5001`: PO not found
- `@pRet = 5002`: Invalid action for current status
- `@pRet = 5003`: Permission denied
- `@pRet = 5004`: Linked document error (e.g., IN, AP)

**Ví dụ sử dụng**:
```sql
-- Submit PO for approval
DECLARE @ret INT;
EXEC dbo.asPOProcessPO
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pAction = 'SUBMIT',
    @pUser_id = 'user02',
    @pRet = @ret OUTPUT;

-- Approve PO
EXEC dbo.asPOProcessPO
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pAction = 'APPROVE',
    @pUser_id = 'manager01',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.5 `asAPCreateFromPO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asAPCreateFromPO`
- **Mô tả**: Tạo hóa đơn mua hàng (AP Invoice) từ Đơn mua hàng (PO)
- **Module**: PO / AP Integration
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pPoStt_rec` | `nvarchar(20)` | Số thứ tự record PO | ✓ | |
| `@pApStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record AP Invoice | ✓ | |
| `@pNgay_ct_ap` | `smalldatetime` | Ngày hóa đơn AP | ✓ | |
| `@pSo_ct_ap` | `nvarchar(12)` | Số chứng từ AP | ✓ | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate PO exists and is in 'Approved' or 'Received' status
2. Validate vendor and payment terms from PO
3. Create AP invoice header (`ApPh1`)
4. For each PO line, create AP invoice detail (`ApCt1`)
   - Match PO line to AP line based on item, quantity, price
   - Consider GRN linkage for received quantities
5. Update PO status to 'Invoiced' (4)
6. Return success/failure

**Tables Used**:
- `PoPh1`, `PoCt1`: Source PO data
- `ApPh1`, `ApCt1`: Target AP invoice data
- `InPh1`, `InCt1`: Link GRN for received quantities

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 6001`: PO not found or in wrong status
- `@pRet = 6002`: Vendor or payment terms invalid
- `@pRet = 6003`: PO lines do not match AP invoice amount/quantity

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @ap_stt_rec NVARCHAR(20);

EXEC dbo.asAPCreateFromPO
    @pMa_cty = '001',
    @pPoStt_rec = 'PO001',
    @pApStt_rec = @ap_stt_rec OUTPUT,
    @pNgay_ct_ap = '2024-02-15',
    @pSo_ct_ap = 'AP20240215001',
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;
```

---

#### 5.1.6 `asINReceiveFromPO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asINReceiveFromPO`
- **Mô tả**: Ghi nhận nhập kho từ Đơn mua hàng (PO)
- **Module**: PO / IN Integration
- **Tạo bởi**: AsiaSoft System (Base system)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `nvarchar(3)` | Mã công ty | ✓ | |
| `@pPoStt_rec` | `nvarchar(20)` | Số thứ tự record PO | ✓ | |
| `@pInStt_rec` | `nvarchar(20)` OUTPUT | Số thứ tự record Nhập kho | ✓ | |
| `@pNgay_ct_in` | `smalldatetime` | Ngày nhập kho | ✓ | |
| `@pSo_ct_in` | `nvarchar(12)` | Số chứng từ Nhập kho | ✓ | |
| `@pUser_id` | `nvarchar(20)` | User ID | ✓ | |
| `@pRet` | `int` OUTPUT | Return code | ✓ | |

**Workflow**:
1. Validate PO exists and is in 'Approved' or 'Sent' status
2. Create Goods Receipt Note (GRN) header (`InPh1`)
3. For each PO line, create GRN detail (`InCt1`)
   - Match PO line to GRN line based on item, quantity, unit of measure
   - Update `PoCt1.So_luong_nh` (Quantity Received)
4. Update PO status based on received quantities (Partially Received or Fully Received)
5. Return success/failure

**Tables Used**:
- `PoPh1`, `PoCt1`: Source PO data
- `InPh1`, `InCt1`: Target GRN data
- `SiDmVt`, `SiDmDvt`: Item and UOM master

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = 7001`: PO not found or in wrong status
- `@pRet = 7002`: GRN linkage error
- `@pRet = 7003`: Quantity mismatch in GRN

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT, @in_stt_rec NVARCHAR(20);

EXEC dbo.asINReceiveFromPO
    @pMa_cty = '001',
    @pPoStt_rec = 'PO001',
    @pInStt_rec = @in_stt_rec OUTPUT,
    @pNgay_ct_in = '2024-02-10',
    @pSo_ct_in = 'GRN001',
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;
```

---

### 5.3 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asPOSave*` | `asPOSavePh1`, `asPOSaveCt1` | Insert/Update PO documents |
| **Get** | `asPOGet*` | `asPOGetPh1`, `asPOGetVendor` | Query PO data |
| **Process** | `asPOProcess*` | `asPOProcessPO` | Process PO lifecycle |
| **Integration** | `asAPCreateFromPO`, `asINReceiveFromPO` | `asAPCreateFromPO` | Link PO to AP/IN |
| **Report** | `asPORpt*` | `asPORptPOStatus` | Generate PO reports |
| **Validate** | `asPOValidate*` | `asPOValidateVendor`, `asPOValidateSoCt` | Validation functions |

---

## 6. Integration Points

### 6.1 With AP (Accounts Payable)

**Integration Type**: Invoice Creation and Payment

**Key Integration Points**:
1. **Create Invoice from PO**: Tạo hóa đơn AP từ PO
   - Trigger: User action to convert approved/received PO to AP Invoice
   - Data flow: Copies PO header/detail to AP header/detail. Sets PO status to 'Invoiced'.
   - Stored procedures: `asPOProcessPO` (to change PO status), `asAPSavePh1`, `asAPSaveCt1`, `asAPCreateFromPO`.

2. **PO Matching for AP**: Đối chiếu hóa đơn AP với PO
   - Trigger: When creating AP invoice from PO.
   - Data flow: Validates quantities and prices against PO.
   - Stored procedures: `asAPCreateFromPO` calls validation logic.

### 6.2 With GL (General Ledger)

**Integration Type**: Financial Posting

**Key Integration Points**:
1. **PO Posting (on receipt)**: Post purchase when goods are received.
   - Trigger: When goods receipt is posted (IN module).
   - Data flow: Creates GL entries for inventory asset and temporary liability accounts.
   - Stored procedures: `asINPostReceipt` calls `asPOGLPosting` (hypothetical SP).

2. **PO Invoicing Posting**: Post AP invoice related to PO.
   - Trigger: When AP invoice is posted.
   - Data flow: Creates GL entries for AP liability and expense accounts.
   - Stored procedures: `asAPPostPh1` (triggered by `asAPCreateFromPO`).

### 6.3 With IN (Inventory)

**Integration Type**: Goods Receipt

**Key Integration Points**:
1. **Goods Receipt from PO**: Nhận hàng theo đơn mua hàng
   - Trigger: User action to record received goods.
   - Data flow: Updates `PoCt1.So_luong_nh`, changes PO status (Partial/Full Received). Creates GRN header/details.
   - Stored procedures: `asINReceiveFromPO`.

2. **Receipt Posting**: Post GRN to update inventory levels.
   - Trigger: When GRN is posted.
   - Data flow: Updates inventory quantities and costs.
   - Stored procedures: `asINPostReceipt` (which might trigger PO status updates).

### 6.4 With SI (System)

**Integration Type**: Master Data Management

**Key Integration Points**:
1. **Vendor Master Data**: Quản lý thông tin nhà cung cấp.
   - Trigger: When vendor is created or updated in SI.
   - Data flow: Sync vendor details (`SiDmNcc`) to PO module or reference directly.
   - Stored procedures: `asSISaveVendor` (maintains master data).

2. **Item Master Data**: Quản lý thông tin vật tư.
   - Trigger: When item is created or updated in SI.
   - Data flow: Sync item details (`SiDmVt`) to PO module.
   - Stored procedures: `asSISaveVt`.

3. **Unit of Measure**: Quản lý đơn vị tính.
   - Trigger: When UOM is created or updated in SI.
   - Data flow: Sync UOM details (`SiDmDvt`) to PO module.
   - Stored procedures: `asSISaveDvt`.

4. **Payment Terms**: Quản lý điều kiện thanh toán.
   - Trigger: When payment terms are managed (could be AP or SI).
   - Data flow: Sync payment terms (`ApTt`) to PO module.
   - Stored procedures: `asAPSaveTt` or `asSISavePaymentTerms`.

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `1001` | `Vendor [Ma_ncc] not found or inactive` | Nhà cung cấp không tồn tại hoặc không active | Kiểm tra danh mục nhà cung cấp trong SI |
| `1002` | `PR [Ma_yc] not found or invalid` | Yêu cầu mua hàng không tồn tại hoặc không hợp lệ | Kiểm tra Yêu cầu mua hàng |
| `1003` | `Duplicate PO number [So_ct]` | Số chứng từ đã tồn tại trong kỳ | Sử dụng số chứng từ khác hoặc kiểm tra tính năng tự đánh số |
| `1101` | `Item [Ma_vt] not found` | Mã vật tư không tồn tại | Kiểm tra danh mục vật tư trong SI |
| `1102` | `Invalid unit of measure [Dvt]` | Đơn vị tính không hợp lệ | Kiểm tra danh mục đơn vị tính trong SI |
| `1103` | `PO quantity exceeds requisition quantity` | Số lượng PO vượt quá số lượng yêu cầu | Điều chỉnh số lượng PO hoặc yêu cầu bổ sung PR |
| `5001` | `PO not found or in wrong status` | Đơn mua hàng không tồn tại hoặc không ở trạng thái phù hợp cho hành động |
| `5002` | `Invalid action for current PO status` | Hành động không hợp lệ với trạng thái hiện tại của PO |
| `6001` | `PO not found or in wrong status for AP conversion` | PO không tồn tại hoặc chưa đủ điều kiện tạo hóa đơn AP |
| `6003` | `PO lines do not match AP invoice amount/quantity` | Sai lệch số lượng/giá giữa PO và hóa đơn AP |
| `7001` | `PO not found or in wrong status for GRN creation` | PO không tồn tại hoặc chưa đủ điều kiện nhập kho |
| `7003` | `Quantity mismatch in GRN` | Số lượng nhập kho không khớp với PO |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for PO module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- PO-specific logic
    -- Validate business rules
    -- Perform PO lifecycle actions
    -- Update related tables (PoPh1, PoCt1, PoReqCt)
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- PO-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error with PO context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'PO',
        @pStt_rec = @pStt_rec,
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pErrorProcedure = ERROR_PROCEDURE();
    
    -- Return PO-specific error code
    DECLARE @errorCode INT = ERROR_NUMBER();
    DECLARE @customCode INT = CASE 
        WHEN @errorCode = 547 THEN 1001  -- Foreign key violation
        WHEN @errorCode = 2627 THEN 1003 -- Duplicate key
        ELSE 9999  -- General error
    END;
    
    THROW 50000, ERROR_MESSAGE(), 1;
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Ma_ncc)` - For vendor-specific PO searches and reports.
2. `(Ma_cty, Ngay_ct)` - For date-based PO queries.
3. `(Ma_cty, Trang_thai)` - For filtering POs by status.
4. `(Ma_cty, So_ct)` - For direct PO number lookups.
5. `(Ma_cty, Ma_yc)` - For finding POs related to a specific PR.
6. `(Ma_cty, Ma_vt, Ma_ct)` - For checking item quantities across POs.

**Recommended Indexes**:
1. `(Ma_cty, Ma_ncc, Ngay_ct) INCLUDE (So_ct, Tong_tt, Trang_thai)` - For vendor performance reports.
2. `(Ma_cty, Ma_yc, Trang_thai)` - For tracking PR conversion status.
3. `(Ma_cty, Ma_vt, So_luong_nh)` - For analyzing received quantities.

### 8.2 Query Optimization Tips

1. **Avoid**: SELECT * without WHERE clause on `Ma_cty`.
2. **Use**: Parameterized stored procedures for all data access.
3. **Consider**: Partitioning `PoPh1` and `PoCt1` tables by `Ma_cty` for very large datasets.
4. **Optimize**: Approval workflows by ensuring efficient status checks.
5. **Batch Processing**: For mass updates or status changes, use batch operations.

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| **PO Count per Company** | < 50K per company | `SELECT COUNT(*) FROM PoPh1 WHERE Ma_cty = @ma_cty` |
| **Avg PO Save Time** | < 1.5 seconds | Monitor `asPOSavePh1` execution time |
| **Avg PO Process Time** | < 3 seconds | Monitor `asPOProcessPO` execution time |
| **Lock Contention** | < 4% | Check blocking on `PoPh1`, `PoCt1`, `SiDmNcc` during peak hours |
| **Index Fragmentation** | < 30% | Use `sys.dm_db_index_physical_stats` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `PO_Requester` | `Create Requisition` | Tạo yêu cầu mua hàng | `asPOSaveReqH` |
| `PO_User` | `Create PO` | Tạo đơn mua hàng | `asPOSavePh1`, `asPOSaveCt1` |
| `PO_User` | `View PO` | Xem đơn mua hàng | `asPOGetPh1` |
| `PO_Approver` | `Approve PO` | Phê duyệt đơn mua hàng | `asPOProcessPO` (APPROVE) |
| `PO_Receiver` | `Receive Goods` | Ghi nhận nhập kho từ PO | `asINReceiveFromPO` (called by IN module) |
| `AP_Clerk` | `Create AP from PO` | Tạo hóa đơn AP từ PO | `asAPCreateFromPO` (called by AP module) |
| `PO_Admin` | `Manage PO Settings` | Quản lý trạng thái, quy trình |
| `Finance` | `View PO Reports` | Xem báo cáo PO | `asPORpt*` |

### 9.2 Data Access Security

**Row-level Security**:
- Enforced by `Ma_cty` filtering in all procedures.
- Users can only access POs belonging to their company.

**Column-level Security**:
- Sensitive columns: Vendor contact details, pricing, PO totals.
- Access restricted based on roles (e.g., only PO_Admin can modify PO pricing).
- Audit logging for all changes to POs, especially price and quantity.

**Procedure-level Security**:
- Execute permissions granted based on assigned roles.
- Input validation to prevent unauthorized access or data manipulation.
- PO approval workflow ensures that sensitive actions (like approving or sending) require appropriate authorization.

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo đơn mua hàng mới

**Steps**:
1. Validate vendor and PR (if applicable).
2. Create PO header and detail lines.
3. Submit PO for approval.

**Example Code**:
```sql
-- Create PO Header
DECLARE @ret INT, @po_stt_rec NVARCHAR(20);
EXEC dbo.asPOSavePh1
    @pMa_cty = '001',
    @pStt_rec = @po_stt_rec OUTPUT,
    @pMa_ct = 'PO',
    @pNgay_ct = '2024-02-01',
    @pSo_ct = 'PO20240201001',
    @pMa_ncc = 'NCC001',
    @pTen_ncc = 'Nhà Cung Cấp A',
    @pMa_yc = 'PR001',
    @pDien_giai = 'Mua máy tính văn phòng',
    @pTong_tien = 10000000,
    @pTien_thue = 1000000,
    @pTong_tt = 11000000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pMa_tt = 'TT30',
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'PO Header created: ' + @po_stt_rec;

-- Create PO Detail
EXEC dbo.asPOSaveCt1
    @pMa_cty = '001',
    @pStt_rec = @po_stt_rec,
    @pStt_rec0 = '001',
    @pMa_vt = 'VT001',
    @pTen_vt = 'Máy tính Dell',
    @pDvt = 'Chiếc',
    @pSo_luong_yc = 10,
    @pSo_luong_po = 10,
    @pGia = 10000000,
    @pThue = 1000000,
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'PO Detail created.';

-- Submit PO for approval
EXEC dbo.asPOProcessPO
    @pMa_cty = '001',
    @pStt_rec = @po_stt_rec,
    @pAction = 'SUBMIT',
    @pUser_id = 'user01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'PO submitted for approval.';
```

### 10.2 Task 2: Phê duyệt và gửi Đơn mua hàng

**Steps**:
1. Approve the PO.
2. Send the PO to the vendor.

**Example Code**:
```sql
-- Approve PO
DECLARE @ret INT;
EXEC dbo.asPOProcessPO
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pAction = 'APPROVE',
    @pUser_id = 'approver01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'PO Approved.';

-- Send PO to vendor (simulated)
EXEC dbo.asPOProcessPO
    @pMa_cty = '001',
    @pStt_rec = 'PO001',
    @pAction = 'SEND',
    @pUser_id = 'purchaser01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'PO Sent to Vendor.';
```

### 10.3 Task 3: Nhận hàng từ Đơn mua hàng

**Steps**:
1. Receive goods against an approved PO.
2. Update PO status and received quantities.

**Example Code**:
```sql
-- Simulate Goods Receipt for PO
DECLARE @ret INT, @grn_stt_rec NVARCHAR(20);

-- Assume IN module handles GRN creation and calls this PO function
-- This is a simplified representation of the integration
EXEC dbo.asINReceiveFromPO
    @pMa_cty = '001',
    @pPoStt_rec = 'PO001',
    @pInStt_rec = @grn_stt_rec OUTPUT,
    @pNgay_ct_in = '2024-02-10',
    @pSo_ct_in = 'GRN001',
    @pUser_id = 'warehouse01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'Goods receipt processed for PO.';
```

### 10.4 Task 4: Tạo hóa đơn AP từ Đơn mua hàng

**Steps**:
1. Convert a received PO to an AP Invoice.
2. Match PO details with invoice details.

**Example Code**:
```sql
-- Create AP Invoice from PO
DECLARE @ret INT, @ap_stt_rec NVARCHAR(20);

EXEC dbo.asAPCreateFromPO
    @pMa_cty = '001',
    @pPoStt_rec = 'PO001',
    @pApStt_rec = @ap_stt_rec OUTPUT,
    @pNgay_ct_ap = '2024-02-15',
    @pSo_ct_ap = 'AP20240215001',
    @pUser_id = 'apclerk01',
    @pRet = @ret OUTPUT;

IF @ret = 0 PRINT 'AP Invoice created from PO: ' + @ap_stt_rec;
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **PO not saving** | Error 1001/1002/1003 on save | Invalid vendor, PR, or duplicate number | Check master data and sequences |
| **PO not approved** | Stuck in 'Pending Approval' status | Approval matrix misconfiguration or user permission issue | Review approval workflow and user roles |
| **PO not sending** | 'Sent' status not updated | Email/notification service issue or incorrect vendor contact |
| **Goods Receipt mismatch** | Error 7003 when receiving | Quantity or item mismatch between PO and GRN | Verify physical count and PO details |
| **AP Invoice creation fails** | Error 6001/6003 on conversion | PO status wrong or mismatch in amounts/quantities | Ensure PO is received/approved, check for quantity/price variances |
| **Slow PO reports** | Reports taking too long to load | Missing indexes on PO tables | Add necessary indexes, especially on `Ma_cty`, `Ngay_ct`, `Trang_thai`, `Ma_ncc` |

### 11.2 Debugging Tips

1. **Check**: Vendor status in `SiDmNcc.Trang_thai`.
2. **Verify**: PR status and quantities in `PoReqH`, `PoReqCt`.
3. **Test**: PO number generation sequence.
4. **Monitor**: PO approval workflow steps and user assignments.
5. **Review**: `asLogError` table for specific PO-related errors.
6. **Inspect**: `PoPh1.Trang_thai` and `PoCt1.So_luong_nh` for accurate status.

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Procurement & Supply Chain  
**Dependencies**: SI (required for master data), AP (required for invoicing), IN (required for receiving), GL (required for posting)  
**Criticality**: HIGH (Impacts cost of goods sold and inventory)  
**Financial Impact**: YES (Commitment to purchase)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query PO data (read-only).
- Check PO status and details.
- Validate vendor information and items.
- Generate PO status reports.
- Suggest POs for approval based on predefined rules.
- Draft POs based on requisitions.

**AI Agent KHÔNG được phép**:
- Create or modify POs (requires user input/approval).
- Approve or reject POs.
- Send POs to vendors.
- Mark POs as received.
- Initiate AP invoice creation from PO.
- Cancel or delete POs.

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required |
|--------|-----------|-------------------|
| **Create PO** | High | YES (PO_User) |
| **Approve PO** | High | YES (PO_Approver) |
| **Send PO** | High | YES (PO_User/Purchaser) |
| **Receive Goods** | Medium | YES (Warehouse User) |
| **Convert PO to Invoice** | High | YES (AP Clerk) |
| **Run PO Reports** | Low | NO |

---

## 13. Future Enhancements

1. **Automated PO Sending**: Tự động gửi PO qua email hoặc cổng nhà cung cấp.
2. **Advanced Approval Workflows**: Phê duyệt đa cấp, phê duyệt dựa trên giá trị.
3. **PO Change Order Management**: Quản lý các thay đổi đối với PO đã phát hành.
4. **Supplier Performance Tracking**: Theo dõi hiệu suất nhà cung cấp (on-time delivery, quality).
5. **Demand Planning Integration**: Tích hợp với kế hoạch nhu cầu.
6. **Catalog Management**: Quản lý danh mục giá/sản phẩm của nhà cung cấp.
7. **Automated GRN Matching**: Đối chiếu tự động PO với Phiếu Nhập Kho.
8. **e-Invoicing Integration**: Tích hợp hóa đơn điện tử từ nhà cung cấp.

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - Transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - Error handling guidelines
- [Database Design](../02_DATABASE_DESIGN.md) - Database design principles
- [Naming Conventions](../09_NAMING_CONVENTION.md) - Naming rules
- [AP Module Documentation](./AP.md) - Accounts Payable integration
- [IN Module Documentation](./IN.md) - Inventory integration
- [GL Module Documentation](./GL.md) - General Ledger integration
- [SI Module Documentation](./SI.md) - System (Master Data) integration

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
| [AP](../AP/) | Accounts Payable - Công nợ phải trả |
| [IN](../IN/) | Inventory - Kho hàng |
| [SI](../SI/) | System - Hệ thống |

---

# End of PO Module Documentation