# SO – Sales Order Module

---

## 1. Module Overview

### 1.1 Business Purpose

SO (Sales Order) quản lý toàn bộ quy trình bán hàng từ khi nhận đơn đặt hàng của khách hàng đến khi giao hàng và thanh toán. Module này:

- Quản lý đơn đặt hàng của khách hàng (Sales Orders)
- Theo dõi trạng thái đơn hàng (chờ xác nhận, đã xác nhận, đang giao hàng, đã giao hàng, đã thanh toán)
- Tạo hóa đơn bán hàng và liên kết với AR (Accounts Receivable)
- Quản lý giá bán, chiết khấu, thuế
- Liên kết với kho hàng (IN) để kiểm tra tồn kho và giao hàng
- Tạo báo cáo doanh thu và hiệu quả bán hàng

**Key Functions**:
- Quản lý đơn đặt hàng khách hàng
- Quy trình phê duyệt đơn hàng
- Kiểm tra tồn kho và đặt hàng
- Tạo hóa đơn bán hàng
- Theo dõi công nợ phải thu
- Quản lý giá bán và chiết khấu
- Báo cáo doanh thu và hiệu quả bán hàng

**Integration Points**:
- **AR (Accounts Receivable)**: Tạo hóa đơn bán hàng và theo dõi công nợ
- **IN (Inventory)**: Kiểm tra tồn kho, đặt hàng và giao hàng
- **GL (General Ledger)**: Post doanh thu và các bút toán liên quan
- **CA (Cash Management)**: Nhận thanh toán từ khách hàng
- **SI (System)**: Quản lý danh mục khách hàng, sản phẩm, đơn vị tính, thuế

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Sales Order Creation | Supported | Tạo đơn đặt hàng khách hàng |
| SO Approval Workflow | Supported | Quy trình phê duyệt nhiều cấp |
| Inventory Check | Supported | Kiểm tra tồn kho khi đặt hàng |
| Price Management | Supported | Quản lý giá bán, chiết khấu |
| SO to AR Invoice Conversion | Supported | Tạo hóa đơn từ SO |
| SO to IN Shipment | Supported | Giao hàng từ SO |
| SO to GL Posting | Required | Post doanh thu vào sổ cái |
| Customer Management | Linked to SI | Quản lý khách hàng |
| Sales Commission | Future | Tính hoa hồng bán hàng |
| Sales Return (RMA) | Future | Trả hàng từ khách hàng |
| Backorder Management | Future | Quản lý đơn hàng chờ |
| Sales Forecasting | Future | Dự báo bán hàng |
| Multi-currency SO | Supported | Đơn hàng ngoại tệ |
| Sales Contract | Future | Hợp đồng bán hàng |

---

### 1.3 Module Naming Convention

**Table Prefix**: `So` (e.g., `SoPh1`, `SoCt1`, `SoDmKh`)

**Stored Procedure Pattern**:
```sql
asSO{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asSOSavePh1` - Lưu header đơn bán hàng
- `asSOGetPh1` - Lấy thông tin đơn bán hàng
- `asSOProcessSO` - Xử lý phê duyệt/gửi SO
- `asARCreateFromSO` - Tạo hóa đơn AR từ SO
- `asINShipFromSO` - Ghi nhận xuất kho từ SO
- `asSORptSales` - Báo cáo doanh thu bán hàng

**Table Naming**:
- `SoPh1`: SO Header
- `SoCt1`: SO Detail
- `SoDmKh`: Customer Master (linked or copied)
- `SoPrice`: Price List
- `SoQuoteH`: Sales Quotation Header
- `SoQuoteCt`: Sales Quotation Detail

---

## 2. Multi-Tenancy Model

SO module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng SO đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Khách hàng và sản phẩm được quản lý riêng cho từng công ty (hoặc tham chiếu từ SI)
4. Đơn bán hàng, báo giá tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục khách hàng, báo giá, đơn bán hàng riêng
- SO chỉ tham chiếu đến khách hàng của cùng công ty
- Giá bán có thể khác nhau giữa các công ty
- Các báo cáo bán hàng chỉ hiển thị data của công ty hiện tại

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `SoPh1` – Sales Order Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `So_no` | `NVARCHAR(20)` | `NOT NULL` | | Số đơn hàng | Format: SO-YYYYMMDD-XXXX |
| `So_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày đơn hàng | Không được lớn hơn ngày hiện tại |
| `Kh_no` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng | Foreign key to customer master |
| `Kh_name` | `NVARCHAR(255)` | `NOT NULL` | | Tên khách hàng | |
| `Status` | `TINYINT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Pending, 2=Approved, 3=Shipped, 4=Invoiced, 5=Cancelled |
| `Total_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | Tổng của các dòng chi tiết |
| `Discount_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Chiết khấu | |
| `Tax_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thuế | |
| `Net_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền | = Total - Discount + Tax |
| `Currency` | `NVARCHAR(3)` | `NOT NULL` | `'VND'` | Loại tiền | |
| `Exchange_rate` | `DECIMAL(19,4)` | `NOT NULL` | `1` | Tỷ giá | |
| `Payment_terms` | `NVARCHAR(50)` | `NULL` | | Điều khoản thanh toán | |
| `Delivery_date` | `DATETIME` | `NULL` | | Ngày giao hàng dự kiến | |
| `Ship_to` | `NVARCHAR(500)` | `NULL` | | Địa chỉ giao hàng | |
| `Bill_to` | `NVARCHAR(500)` | `NULL` | | Địa chỉ thanh toán | |
| `Notes` | `NVARCHAR(1000)` | `NULL` | | Ghi chú | |
| `Created_by` | `NVARCHAR(50)` | `NOT NULL` | | Người tạo | |
| `Created_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo | |
| `Modified_by` | `NVARCHAR(50)` | `NULL` | | Người sửa | |
| `Modified_date` | `DATETIME` | `NULL` | | Ngày sửa | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, So_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Kh_no) REFERENCES SiDmKh(Ma_cty, Kh_no)
```

**Indexes**:
```sql
CREATE INDEX IX_SoPh1_Kh_no ON SoPh1 (Ma_cty, Kh_no)
CREATE INDEX IX_SoPh1_Status ON SoPh1 (Ma_cty, Status)
CREATE INDEX IX_SoPh1_Date ON SoPh1 (Ma_cty, So_date)
```

---

#### 3.1.2 `SoCt1` – Sales Order Detail

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `So_no` | `NVARCHAR(20)` | `NOT NULL` | | Số đơn hàng | |
| `Line_no` | `INT` | `NOT NULL` | | Số dòng | |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư | Foreign key to item master |
| `Ten_vt` | `NVARCHAR(255)` | `NOT NULL` | | Tên vật tư | |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `Quantity` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng | > 0 |
| `Unit_price` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đơn giá | >= 0 |
| `Discount_pct` | `DECIMAL(5,2)` | `NOT NULL` | `0` | % chiết khấu | 0-100 |
| `Discount_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền chiết khấu | = Quantity * Unit_price * Discount_pct/100 |
| `Tax_pct` | `DECIMAL(5,2)` | `NOT NULL` | `0` | % thuế | 0-100 |
| `Tax_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tiền thuế | = (Quantity * Unit_price - Discount_amount) * Tax_pct/100 |
| `Line_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền dòng | = Quantity * Unit_price - Discount_amount + Tax_amount |
| `Shipped_qty` | `DECIMAL(19,4)` | `NOT NULL` | `0` | SL đã giao | <= Quantity |
| `Invoiced_qty` | `DECIMAL(19,4)` | `NOT NULL` | `0` | SL đã xuất hóa đơn | <= Shipped_qty |
| `Warehouse` | `NVARCHAR(20)` | `NULL` | | Kho xuất | |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú dòng | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, So_no, Line_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, So_no) REFERENCES SoPh1(Ma_cty, So_no)
FOREIGN KEY (Ma_cty, Ma_vt) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

**Indexes**:
```sql
CREATE INDEX IX_SoCt1_Ma_vt ON SoCt1 (Ma_cty, Ma_vt)
CREATE INDEX IX_SoCt1_So_no ON SoCt1 (Ma_cty, So_no)
```

---

#### 3.1.3 `SoQuoteH` – Sales Quotation Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Quote_no` | `NVARCHAR(20)` | `NOT NULL` | | Số báo giá | Format: QT-YYYYMMDD-XXXX |
| `Quote_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày báo giá | |
| `Kh_no` | `NVARCHAR(20)` | `NOT NULL` | | Mã khách hàng | |
| `Kh_name` | `NVARCHAR(255)` | `NOT NULL` | | Tên khách hàng | |
| `Valid_until` | `DATETIME` | `NULL` | | Hiệu lực đến ngày | |
| `Status` | `TINYINT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Sent, 2=Accepted, 3=Rejected, 4=Converted to SO |
| `Total_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng tiền | |
| `So_no` | `NVARCHAR(20)` | `NULL` | | Số SO tạo từ báo giá | |
| `Notes` | `NVARCHAR(1000)` | `NULL` | | Ghi chú | |
| `Created_by` | `NVARCHAR(50)` | `NOT NULL` | | Người tạo | |
| `Created_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Quote_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Kh_no) REFERENCES SiDmKh(Ma_cty, Kh_no)
FOREIGN KEY (Ma_cty, So_no) REFERENCES SoPh1(Ma_cty, So_no)
```

---

#### 3.1.4 `SoQuoteCt` – Sales Quotation Detail

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Quote_no` | `NVARCHAR(20)` | `NOT NULL` | | Số báo giá | |
| `Line_no` | `INT` | `NOT NULL` | | Số dòng | |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư | |
| `Ten_vt` | `NVARCHAR(255)` | `NOT NULL` | | Tên vật tư | |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `Quantity` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng | |
| `Unit_price` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đơn giá | |
| `Discount_pct` | `DECIMAL(5,2)` | `NOT NULL` | `0` | % chiết khấu | |
| `Line_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền | |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Quote_no, Line_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Quote_no) REFERENCES SoQuoteH(Ma_cty, Quote_no)
FOREIGN KEY (Ma_cty, Ma_vt) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
SoQuoteH --(1:n)--> SoQuoteCt
SoQuoteH --(1:1)--> SoPh1 (when converted)
SoPh1 --(1:n)--> SoCt1
SoPh1 --(1:1)--> SiDmKh (customer)
SoCt1 --(1:1)--> SiDmVt (item)
SoPh1 --(1:n)--> ArPh1 (invoices)
SoCt1 --(1:n)--> InPh2 (shipments)
```

**Key Relationships**:
1. **SO Header → SO Detail**: Một đơn hàng có nhiều dòng chi tiết
2. **SO → Customer**: Mỗi đơn hàng thuộc về một khách hàng
3. **SO Detail → Item**: Mỗi dòng chi tiết tham chiếu một sản phẩm
4. **SO → AR Invoice**: Đơn hàng có thể tạo một hoặc nhiều hóa đơn
5. **SO → IN Shipment**: Đơn hàng có thể giao hàng nhiều lần

---

### 3.3 Data Types Usage

| Data Type | Usage in Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số tiền, số lượng, đơn giá | `Total_amount`, `Quantity`, `Unit_price` | Độ chính xác 4 số thập phân cho tiền tệ |
| `NVARCHAR(n)` | Chuỗi ký tự Unicode | `So_no`, `Kh_name`, `Ten_vt` | `n` tùy theo độ dài dự kiến |
| `INT` | Mã số, khóa ngoại | `Ma_cty`, `Line_no` | Dùng cho các trường số nguyên |
| `TINYINT` | Trạng thái, cờ | `Status` | 0-255, dùng cho enum |
| `DATETIME` | Ngày tháng | `So_date`, `Delivery_date` | Lưu cả ngày và giờ |
| `BIT` | Cờ boolean | `Is_active`, `Is_approved` | 0/1 cho true/false |
| `DECIMAL(5,2)` | Tỷ lệ phần trăm | `Discount_pct`, `Tax_pct` | 0-100 với 2 số thập phân |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **SO Number Format**: Số đơn hàng phải theo format "SO-YYYYMMDD-XXXX"
   - Validation logic: Kiểm tra regex pattern
   - Error message: "Số đơn hàng không đúng định dạng. Phải là SO-YYYYMMDD-XXXX"
   - Stored procedure: `asSOValidateSONumber`

2. **Customer Validation**: Khách hàng phải tồn tại và active
   - Validation logic: Kiểm tra `SiDmKh` với `Status = 1`
   - Error message: "Khách hàng không tồn tại hoặc đã bị khóa"
   - Stored procedure: `asSOValidateCustomer`

3. **Inventory Check**: Số lượng đặt hàng không được vượt quá tồn kho khả dụng
   - Validation logic: `Quantity <= AvailableStock` từ `InTonKho`
   - Error message: "Số lượng vượt quá tồn kho khả dụng. Tồn kho: {0}"
   - Stored procedure: `asSOCheckInventory`

4. **Price Validation**: Đơn giá phải >= giá vốn và <= giá bán tối đa
   - Validation logic: `CostPrice <= UnitPrice <= MaxPrice`
   - Error message: "Đơn giá không hợp lệ. Phải từ {0} đến {1}"
   - Stored procedure: `asSOValidatePrice`

5. **Discount Limit**: Chiết khấu không được vượt quá giới hạn cho phép
   - Validation logic: `DiscountPct <= MaxDiscountPct`
   - Error message: "Chiết khấu vượt quá giới hạn cho phép ({0}%)"
   - Stored procedure: `asSOValidateDiscount`

### 4.2 State Management

**State Machine**:
```
Draft (0)
   ↓ Save/Submit
Pending Approval (1)
   ↓ Approve
Approved (2)
   ↓ Ship
Shipped (3)
   ↓ Invoice
Invoiced (4)
   ↓ Complete
Completed (5)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp | Save, Delete, Submit |
| `1` | Pending Approval | Chờ duyệt | Approve, Reject, Cancel |
| `2` | Approved | Đã duyệt | Ship, Cancel |
| `3` | Shipped | Đã giao hàng | Invoice, Partial Ship |
| `4` | Invoiced | Đã xuất hóa đơn | Receive Payment, Cancel |
| `5` | Completed | Hoàn thành | View only |
| `9` | Cancelled | Đã hủy | View only |

**State Transition Rules**:
- Chỉ có thể ship từ trạng thái Approved
- Chỉ có thể invoice từ trạng thái Shipped
- Chỉ có thể cancel từ trạng thái Draft, Pending, Approved
- Không thể sửa đơn hàng đã Shipped trở lên

### 4.3 Calculation Rules

**Line Amount Calculation**:
- Formula: `LineAmount = Quantity * UnitPrice * (1 - DiscountPct/100) * (1 + TaxPct/100)`
- Implementation: `asSOCalculateLineAmount`
- Example: Quantity=10, UnitPrice=1000, Discount=10%, Tax=10% → LineAmount = 10 * 1000 * 0.9 * 1.1 = 9900

**Total Amount Calculation**:
- Formula: `TotalAmount = SUM(LineAmount)` cho tất cả các dòng
- Implementation: `asSOCalculateTotalAmount`
- Trigger: Tự động tính khi save SO detail

**Tax Calculation**:
- Formula: `TaxAmount = (Quantity * UnitPrice - DiscountAmount) * TaxPct/100`
- Implementation: `asSOCalculateTax`
- Business rule: Tính thuế trên giá sau chiết khấu

**Available Stock Calculation**:
- Formula: `AvailableStock = OnHand - Committed - Reserved`
- Implementation: `asINGetAvailableStock`
- Used in: Inventory check during SO creation

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asSOSavePh1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asSOSavePh1`
- **Mô tả**: Lưu hoặc cập nhật header đơn bán hàng
- **Module**: SO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số đơn hàng | ✓ | |
| `@pSo_date` | `DATETIME` | Ngày đơn hàng | ✓ | |
| `@pKh_no` | `NVARCHAR(20)` | Mã khách hàng | ✓ | |
| `@pKh_name` | `NVARCHAR(255)` | Tên khách hàng | ✓ | |
| `@pStatus` | `TINYINT` | Trạng thái | | `0` |
| `@pDelivery_date` | `DATETIME` | Ngày giao hàng | | |
| `@pShip_to` | `NVARCHAR(500)` | Địa chỉ giao hàng | | |
| `@pBill_to` | `NVARCHAR(500)` | Địa chỉ thanh toán | | |
| `@pPayment_terms` | `NVARCHAR(50)` | Điều khoản thanh toán | | |
| `@pCurrency` | `NVARCHAR(3)` | Loại tiền | | `'VND'` |
| `@pExchange_rate` | `DECIMAL(19,4)` | Tỷ giá | | `1` |
| `@pNotes` | `NVARCHAR(1000)` | Ghi chú | | |
| `@pUser_id` | `NVARCHAR(50)` | User ID thực hiện | ✓ | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate input parameters
2. Check customer exists and active
3. If new SO: generate SO number if not provided
4. Validate SO number format
5. Insert or update `SoPh1` table
6. Recalculate totals from detail lines
7. Log transaction
8. Return success/failure

**Tables Used**:
- `SoPh1`: Insert/Update SO header
- `SiDmKh`: Validate customer
- `SoLog`: Log transaction

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: Validation error
- `@pRet = -2`: Customer not found
- `@pRet = -3`: Database error

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;

EXEC dbo.asSOSavePh1
    @pMa_cty = 1,
    @pSo_no = 'SO-20240224-0001',
    @pSo_date = '2024-02-24',
    @pKh_no = 'KH001',
    @pKh_name = 'Công ty ABC',
    @pStatus = 0,
    @pDelivery_date = '2024-02-28',
    @pShip_to = '123 Đường XYZ, Quận 1, TP.HCM',
    @pBill_to = '123 Đường XYZ, Quận 1, TP.HCM',
    @pPayment_terms = 'Net 30',
    @pCurrency = 'VND',
    @pExchange_rate = 1,
    @pNotes = 'Đơn hàng khẩn',
    @pUser_id = 'admin',
    @pRet = @ret OUTPUT;

SELECT @ret AS ReturnCode;
```

---

#### 5.1.2 `asSOSaveCt1`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asSOSaveCt1`
- **Mô tả**: Lưu hoặc cập nhật dòng chi tiết đơn bán hàng
- **Module**: SO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số đơn hàng | ✓ | |
| `@pLine_no` | `INT` | Số dòng | ✓ | |
| `@pMa_vt` | `NVARCHAR(20)` | Mã vật tư | ✓ | |
| `@pTen_vt` | `NVARCHAR(255)` | Tên vật tư | ✓ | |
| `@pDvt` | `NVARCHAR(20)` | Đơn vị tính | ✓ | |
| `@pQuantity` | `DECIMAL(19,4)` | Số lượng | ✓ | |
| `@pUnit_price` | `DECIMAL(19,4)` | Đơn giá | ✓ | |
| `@pDiscount_pct` | `DECIMAL(5,2)` | % chiết khấu | | `0` |
| `@pTax_pct` | `DECIMAL(5,2)` | % thuế | | `0` |
| `@pWarehouse` | `NVARCHAR(20)` | Kho xuất | | |
| `@pNotes` | `NVARCHAR(500)` | Ghi chú dòng | | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate SO exists and in editable state (Draft/Pending)
2. Validate item exists
3. Check inventory availability
4. Validate price
5. Calculate line amounts
6. Insert or update `SoCt1`
7. Update SO header totals
8. Log transaction

**Tables Used**:
- `SoCt1`: Insert/Update detail
- `SoPh1`: Validate SO and update totals
- `SiDmVt`: Validate item
- `InTonKho`: Check inventory
- `SoPrice`: Validate price

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: SO not found or not editable
- `@pRet = -2`: Item not found
- `@pRet = -3`: Insufficient inventory
- `@pRet = -4`: Invalid price

---

#### 5.1.3 `asSOProcessSO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asSOProcessSO`
- **Mô tả**: Xử lý chuyển trạng thái đơn hàng (Submit, Approve, Reject, Ship, Cancel)
- **Module**: SO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số đơn hàng | ✓ | |
| `@pAction` | `NVARCHAR(20)` | Hành động | ✓ | |
| `@pNew_status` | `TINYINT` | Trạng thái mới | ✓ | |
| `@pReason` | `NVARCHAR(500)` | Lý do (cho reject/cancel) | | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate SO exists
2. Check current status
3. Validate state transition is allowed
4. Perform action-specific logic:
   - Submit: Check all validations passed
   - Approve: Check user has approval permission
   - Reject: Require reason
   - Ship: Create shipment in IN module
   - Cancel: Release reserved inventory
5. Update SO status
6. Log status change
7. Return result

**Tables Used**:
- `SoPh1`: Get current status and update
- `SoCt1`: Get detail lines
- `InPh2`: Create shipment (for Ship action)
- `SoLog`: Log status changes

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: Invalid state transition
- `@pRet = -2`: User not authorized
- `@pRet = -3`: Validation failed

---

#### 5.1.4 `asARCreateFromSO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asARCreateFromSO`
- **Mô tả**: Tạo hóa đơn bán hàng (AR) từ đơn hàng đã giao
- **Module**: SO/AR
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số đơn hàng | ✓ | |
| `@pInvoice_date` | `DATETIME` | Ngày hóa đơn | ✓ | |
| `@pDue_date` | `DATETIME` | Ngày đến hạn | | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pAr_no` | `NVARCHAR(20)` OUTPUT | Số hóa đơn tạo | | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate SO exists and is in Shipped status
2. Check if already invoiced
3. Get SO details
4. Create AR header (`ArPh1`)
5. Create AR detail lines (`ArCt1`) from shipped quantities
6. Update SO status to Invoiced
7. Update invoiced quantities in SO detail
8. Return AR invoice number

**Tables Used**:
- `SoPh1`: Get SO info
- `SoCt1`: Get detail lines
- `ArPh1`: Create AR header
- `ArCt1`: Create AR detail
- `InPh2`: Get shipment details

**Return Values**:
- `@pRet = 0`: Success, `@pAr_no` contains new invoice number
- `@pRet = -1`: SO not found or not shippable
- `@pRet = -2`: Already invoiced
- `@pRet = -3`: No shipped quantities

---

#### 5.1.5 `asINShipFromSO`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asINShipFromSO`
- **Mô tả**: Tạo phiếu xuất kho từ đơn hàng đã duyệt
- **Module**: SO/IN
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số đơn hàng | ✓ | |
| `@pShip_date` | `DATETIME` | Ngày xuất kho | ✓ | |
| `@pWarehouse` | `NVARCHAR(20)` | Kho xuất | ✓ | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pIn_no` | `NVARCHAR(20)` OUTPUT | Số phiếu xuất kho | | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate SO exists and is in Approved status
2. Get SO details with quantities to ship
3. Check inventory availability in specified warehouse
4. Create IN shipment header (`InPh2`)
5. Create IN shipment detail lines (`InCt2`)
6. Update inventory quantities
7. Update shipped quantities in SO detail
8. Update SO status to Shipped if all quantities shipped
9. Return IN shipment number

**Tables Used**:
- `SoPh1`: Get SO info
- `SoCt1`: Get detail lines
- `InPh2`: Create shipment header
- `InCt2`: Create shipment detail
- `InTonKho`: Update inventory

**Return Values**:
- `@pRet = 0`: Success, `@pIn_no` contains new shipment number
- `@pRet = -1`: SO not found or not approvable
- `@pRet = -2`: Insufficient inventory
- `@pRet = -3`: Warehouse not found

---

#### 5.1.6 `asSORptSales`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asSORptSales`
- **Mô tả**: Báo cáo doanh thu bán hàng theo nhiều tiêu chí
- **Module**: SO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pFrom_date` | `DATETIME` | Từ ngày | ✓ | |
| `@pTo_date` | `DATETIME` | Đến ngày | ✓ | |
| `@pKh_no` | `NVARCHAR(20)` | Mã khách hàng | | `NULL` |
| `@pMa_vt` | `NVARCHAR(20)` | Mã vật tư | | `NULL` |
| `@pStatus` | `TINYINT` | Trạng thái | | `NULL` |
| `@pGroup_by` | `NVARCHAR(20)` | Nhóm theo | | `'Date'` |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate date range
2. Build dynamic SQL based on filters
3. Execute query with appropriate grouping
4. Return result set

**Tables Used**:
- `SoPh1`: SO headers
- `SoCt1`: SO details
- `SiDmKh`: Customer info
- `SiDmVt`: Item info

**Return Result Set**:
| Column | Type | Description |
|--------|------|-------------|
| `Period` | `NVARCHAR(50)` | Period (Date, Month, Customer, Item) |
| `So_count` | `INT` | Số đơn hàng |
| `Quantity` | `DECIMAL(19,4)` | Tổng số lượng |
| `Total_amount` | `DECIMAL(19,4)` | Tổng tiền |
| `Discount_amount` | `DECIMAL(19,4)` | Tổng chiết khấu |
| `Tax_amount` | `DECIMAL(19,4)` | Tổng thuế |
| `Net_amount` | `DECIMAL(19,4)` | Thành tiền |

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asSOSave*` | `asSOSavePh1`, `asSOSaveCt1` | Insert/Update SO data |
| **Get** | `asSOGet*` | `asSOGetPh1`, `asSOGetCt1` | Query SO data |
| **Process** | `asSOProcess*` | `asSOProcessSO` | Process SO workflows |
| **Report** | `asSORpt*` | `asSORptSales`, `asSORptPending` | Generate reports |
| **Integration** | `asSO*FromSO` | `asARCreateFromSO`, `asINShipFromSO` | Integration with other modules |
| **Utility** | `asSOValidate*` | `asSOValidateCustomer`, `asSOCheckInventory` | Validation functions |

---

## 6. Integration Points

### 6.1 With AR (Accounts Receivable)

**Integration Type**: Transaction flow (SO → AR Invoice)

**Key Integration Points**:
1. **Create Invoice from SO**: Tạo hóa đơn bán hàng từ đơn hàng đã giao
   - Trigger: Khi đơn hàng đã được giao (Shipped status)
   - Data flow: SO details → AR invoice lines
   - Stored procedures: `asARCreateFromSO`, `asSOUpdateInvoiced`

2. **Payment Application**: Áp dụng thanh toán vào đơn hàng
   - Trigger: Khi nhận thanh toán từ khách hàng
   - Data flow: AR payment → SO payment allocation
   - Stored procedures: `asARApplyPayment`, `asSOUpdatePaid`

3. **Credit Management**: Quản lý hạn mức tín dụng khách hàng
   - Trigger: Khi tạo đơn hàng mới
   - Data flow: Check customer credit limit
   - Stored procedures: `asSOCheckCreditLimit`

### 6.2 With IN (Inventory)

**Integration Type**: Inventory movement (SO → Shipment)

**Key Integration Points**:
1. **Ship from SO**: Tạo phiếu xuất kho từ đơn hàng
   - Trigger: Khi đơn hàng được duyệt và chuẩn bị giao
   - Data flow: SO quantities → IN shipment → Inventory reduction
   - Stored procedures: `asINShipFromSO`, `asSOUpdateShipped`

2. **Inventory Check**: Kiểm tra tồn kho khi tạo đơn hàng
   - Trigger: Khi thêm/sửa dòng chi tiết SO
   - Data flow: Check available stock
   - Stored procedures: `asSOCheckInventory`

3. **Backorder Management**: Quản lý đơn hàng chờ hàng
   - Trigger: Khi tồn kho không đủ
   - Data flow: Reserve inventory, create backorder
   - Stored procedures: `asSOReserveInventory`

### 6.3 With GL (General Ledger)

**Integration Type**: Financial posting (SO → GL Entries)

**Key Integration Points**:
1. **Revenue Posting**: Ghi nhận doanh thu khi xuất hóa đơn
   - Trigger: Khi tạo AR invoice từ SO
   - Data flow: SO revenue → GL revenue accounts
   - Stored procedures: `asGLPostRevenue`

2. **Cost of Goods Sold**: Ghi nhận giá vốn khi xuất kho
   - Trigger: Khi tạo shipment từ SO
   - Data flow: Inventory cost → GL COGS accounts
   - Stored procedures: `asGLPostCOGS`

3. **Tax Posting**: Ghi nhận thuế GTGT
   - Trigger: Khi tạo hóa đơn có thuế
   - Data flow: Tax amounts → GL tax accounts
   - Stored procedures: `asGLPostTax`

### 6.4 With CA (Cash Management)

**Integration Type**: Payment processing

**Key Integration Points**:
1. **Receive Payment**: Nhận thanh toán từ khách hàng
   - Trigger: Khi khách hàng thanh toán hóa đơn
   - Data flow: CA receipt → SO payment allocation
   - Stored procedures: `asCAReceivePayment`

2. **Deposit Management**: Quản lý tiền đặt cọc
   - Trigger: Khi khách hàng đặt cọc đơn hàng
   - Data flow: CA receipt → SO deposit
   - Stored procedures: `asCASaveDeposit`

### 6.5 With SI (System)

**Integration Type**: Master data reference

**Key Integration Points**:
1. **Customer Reference**: Tham chiếu thông tin khách hàng
   - Trigger: Khi tạo/sửa đơn hàng
   - Data flow: `SiDmKh` → `SoPh1` customer fields
   - Stored procedures: `asSOGetCustomerInfo`

2. **Item Reference**: Tham chiếu thông tin sản phẩm
   - Trigger: Khi thêm dòng chi tiết
   - Data flow: `SiDmVt` → `SoCt1` item fields
   - Stored procedures: `asSOGetItemInfo`

3. **Price Management**: Quản lý giá bán
   - Trigger: Khi tính giá cho dòng chi tiết
   - Data flow: `SiPrice` → `SoCt1` unit price
   - Stored procedures: `asSOGetPrice`

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `SO001` | `Số đơn hàng đã tồn tại` | Duplicate SO number | Sử dụng số đơn hàng khác |
| `SO002` | `Khách hàng không tồn tại` | Customer not found in `SiDmKh` | Kiểm tra mã khách hàng |
| `SO003` | `Sản phẩm không tồn tại` | Item not found in `SiDmVt` | Kiểm tra mã sản phẩm |
| `SO004` | `Số lượng vượt quá tồn kho` | Quantity > available stock | Giảm số lượng hoặc nhập thêm hàng |
| `SO005` | `Đơn giá không hợp lệ` | Price outside allowed range | Kiểm tra giá trong danh mục |
| `SO006` | `Không thể chuyển trạng thái` | Invalid state transition | Kiểm tra workflow rules |
| `SO007` | `Đơn hàng đã bị khóa` | SO is in read-only state | Tạo đơn hàng mới |
| `SO008` | `Chiết khấu vượt quá giới hạn` | Discount > max allowed | Giảm % chiết khấu |
| `SO009` | `Hạn mức tín dụng đã vượt` | Customer credit limit exceeded | Yêu cầu thanh toán trước |
| `SO010` | `Ngày giao hàng không hợp lệ` | Delivery date in the past | Chọn ngày trong tương lai |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for SO module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- Validate input parameters
    IF @pMa_cty IS NULL OR @pSo_no IS NULL
    BEGIN
        RAISERROR('Tham số bắt buộc thiếu', 16, 1);
    END
    
    -- Business logic validation
    IF NOT EXISTS (SELECT 1 FROM SiDmKh WHERE Ma_cty = @pMa_cty AND Kh_no = @pKh_no AND Status = 1)
    BEGIN
        RAISERROR('SO003: Khách hàng không tồn tại hoặc đã bị khóa', 16, 1);
    END
    
    -- Main business logic
    -- ...
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    -- Module-specific error handling
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error with module context
    DECLARE @ErrorNumber INT = ERROR_NUMBER();
    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
    
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'SO',
        @pProcedure = ERROR_PROCEDURE(),
        @pErrorNumber = @ErrorNumber,
        @pErrorMessage = @ErrorMessage,
        @pSo_no = @pSo_no;
    
    -- Return user-friendly error
    IF @ErrorNumber >= 50000
        THROW;
    ELSE
        RAISERROR('Lỗi hệ thống khi xử lý đơn hàng. Vui lòng thử lại sau.', 16, 1);
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, So_no)` - Primary key for all SO tables
2. `(Ma_cty, Kh_no)` - For customer-based queries
3. `(Ma_cty, So_date)` - For date-range reports
4. `(Ma_cty, Status)` - For status-based queries
5. `(Ma_cty, Ma_vt)` - For item-based queries in detail tables

**Recommended Indexes**:
1. `(Ma_cty, So_date) INCLUDE (Kh_no, Total_amount, Status)` - For sales reports
2. `(Ma_cty, Kh_no, So_date)` - For customer history
3. `(Ma_cty, Created_date)` - For audit trail queries

### 8.2 Query Optimization Tips

1. **Avoid**: `SELECT *` - Always specify columns needed
2. **Use**: Parameterized queries to prevent SQL injection and reuse execution plans
3. **Consider**: Partitioning `SoPh1` by `So_date` for large datasets
4. **Implement**: Pagination for large result sets using `OFFSET FETCH`
5. **Cache**: Frequently accessed customer/item data in application layer

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| SO Creation Time | < 500ms | `AVG(DATEDIFF(ms, StartTime, EndTime))` from `SoLog` |
| Concurrent SO Users | < 100 | `COUNT(DISTINCT User_id)` from active sessions |
| SO Table Size Growth | < 10GB/month | Monthly growth of `SoPh1` and `SoCt1` |
| Index Fragmentation | < 30% | `sys.dm_db_index_physical_stats` |
| Long-running Queries | < 5 seconds | Queries in `sys.dm_exec_requests` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `Sales Clerk` | Create SO | Tạo đơn hàng mới | `asSOSavePh1`, `asSOSaveCt1` |
| `Sales Manager` | Approve SO | Duyệt đơn hàng | `asSOProcessSO` (Approve action) |
| `Sales Admin` | Edit SO | Sửa đơn hàng đã tạo | All `asSOSave*` procedures |
| `Warehouse Staff` | Ship SO | Xuất kho đơn hàng | `asINShipFromSO` |
| `Accounting` | Invoice SO | Tạo hóa đơn | `asARCreateFromSO` |
| `View Only` | View SO | Xem đơn hàng | `asSOGet*` procedures |

### 9.2 Data Access Security

**Row-level Security**:
- Implemented via `Ma_cty` filtering in all procedures
- Users can only access SOs of their assigned company
- No cross-company data access allowed

**Column-level Security**:
- Sensitive columns: `Unit_price`, `Discount_pct`, `Cost_price`
- Price masking: Show only list price to sales clerks
- Discount limits: Enforced by business rules

**Audit Trail**:
- All SO changes logged in `SoLog` table
- Track: Who, When, What changed
- Required for SO approval workflows

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Tạo đơn hàng bán hàng mới

**Steps**:
1. Validate customer information
2. Check inventory availability
3. Create SO header
4. Add line items with prices
5. Calculate totals and taxes
6. Save and submit for approval

**Example Code**:
```sql
-- Tạo đơn hàng mới
DECLARE @ret INT, @so_no NVARCHAR(20) = 'SO-' + CONVERT(NVARCHAR(8), GETDATE(), 112) + '-0001';

-- 1. Tạo header
EXEC asSOSavePh1
    @pMa_cty = 1,
    @pSo_no = @so_no,
    @pSo_date = GETDATE(),
    @pKh_no = 'KH001',
    @pKh_name = 'Công ty ABC',
    @pStatus = 0,
    @pDelivery_date = DATEADD(DAY, 7, GETDATE()),
    @pPayment_terms = 'Net 30',
    @pUser_id = 'sales1',
    @pRet = @ret OUTPUT;

IF @ret = 0
BEGIN
    -- 2. Thêm dòng chi tiết
    EXEC asSOSaveCt1
        @pMa_cty = 1,
        @pSo_no = @so_no,
        @pLine_no = 1,
        @pMa_vt = 'VT001',
        @pTen_vt = 'Sản phẩm A',
        @pDvt = 'Cái',
        @pQuantity = 10,
        @pUnit_price = 100000,
        @pDiscount_pct = 5,
        @pTax_pct = 10,
        @pWarehouse = 'KHO01',
        @pUser_id = 'sales1',
        @pRet = @ret OUTPUT;
        
    -- 3. Thêm dòng thứ 2
    EXEC asSOSaveCt1
        @pMa_cty = 1,
        @pSo_no = @so_no,
        @pLine_no = 2,
        @pMa_vt = 'VT002',
        @pTen_vt = 'Sản phẩm B',
        @pDvt = 'Cái',
        @pQuantity = 5,
        @pUnit_price = 200000,
        @pDiscount_pct = 0,
        @pTax_pct = 10,
        @pWarehouse = 'KHO01',
        @pUser_id = 'sales1',
        @pRet = @ret OUTPUT;
        
    -- 4. Submit đơn hàng để duyệt
    EXEC asSOProcessSO
        @pMa_cty = 1,
        @pSo_no = @so_no,
        @pAction = 'Submit',
        @pNew_status = 1,
        @pUser_id = 'sales1',
        @pRet = @ret OUTPUT;
        
    PRINT 'Đơn hàng ' + @so_no + ' đã được tạo và submit thành công.';
END
ELSE
BEGIN
    PRINT 'Lỗi khi tạo đơn hàng: ' + CAST(@ret AS NVARCHAR(10));
END
```

### 10.2 Task 2: Duyệt và giao đơn hàng

**Steps**:
1. Manager approves the SO
2. Warehouse prepares shipment
3. Create shipment from SO
4. Update SO status to Shipped
5. Create invoice from shipped SO

**Example Code**:
```sql
-- 1. Manager duyệt đơn hàng
DECLARE @ret INT, @so_no NVARCHAR(20) = 'SO-20240224-0001';

EXEC asSOProcessSO
    @pMa_cty = 1,
    @pSo_no = @so_no,
    @pAction = 'Approve',
    @pNew_status = 2,
    @pUser_id = 'manager1',
    @pRet = @ret OUTPUT;

IF @ret = 0
BEGIN
    -- 2. Kho xuất hàng
    DECLARE @in_no NVARCHAR(20);
    
    EXEC asINShipFromSO
        @pMa_cty = 1,
        @pSo_no = @so_no,
        @pShip_date = GETDATE(),
        @pWarehouse = 'KHO01',
        @pUser_id = 'warehouse1',
        @pIn_no = @in_no OUTPUT,
        @pRet = @ret OUTPUT;
        
    IF @ret = 0
    BEGIN
        PRINT 'Đã xuất kho phiếu số: ' + @in_no;
        
        -- 3. Tạo hóa đơn
        DECLARE @ar_no NVARCHAR(20);
        
        EXEC asARCreateFromSO
            @pMa_cty = 1,
            @pSo_no = @so_no,
            @pInvoice_date = GETDATE(),
            @pDue_date = DATEADD(DAY, 30, GETDATE()),
            @pUser_id = 'accounting1',
            @pAr_no = @ar_no OUTPUT,
            @pRet = @ret OUTPUT;
            
        IF @ret = 0
            PRINT 'Đã tạo hóa đơn số: ' + @ar_no;
    END
END
```

### 10.3 Task 3: Báo cáo doanh thu theo khách hàng

**Example Code**:
```sql
-- Báo cáo doanh thu tháng 2/2024 theo khách hàng
DECLARE @ret INT;

EXEC asSORptSales
    @pMa_cty = 1,
    @pFrom_date = '2024-02-01',
    @pTo_date = '2024-02-29',
    @pGroup_by = 'Customer',
    @pRet = @ret OUTPUT;
    
-- Kết quả trả về:
-- Period (Customer), So_count, Quantity, Total_amount, Discount_amount, Tax_amount, Net_amount
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **SO không lưu được** | Error "Số đơn hàng đã tồn tại" | Duplicate SO number | Sử dụng số đơn hàng tự động hoặc kiểm tra trùng |
| **Không thêm được dòng** | Error "Sản phẩm không tồn tại" | Item code not in master | Kiểm tra mã sản phẩm trong `SiDmVt` |
| **Không duyệt được SO** | Error "Không thể chuyển trạng thái" | Invalid workflow transition | Kiểm tra current status và allowed transitions |
| **Xuất kho thất bại** | Error "Số lượng vượt quá tồn kho" | Insufficient inventory | Kiểm tra tồn kho thực tế trong `InTonKho` |
| **Báo cáo chậm** | Report takes > 10 seconds | Missing indexes or large data | Thêm indexes và consider partitioning |

### 11.2 Debugging Tips

1. **Check SO Status**: `SELECT * FROM SoPh1 WHERE Ma_cty = @Ma_cty AND So_no = @So_no`
2. **Verify Inventory**: `SELECT * FROM InTonKho WHERE Ma_cty = @Ma_cty AND Ma_vt = @Ma_vt`
3. **Review Error Log**: `SELECT * FROM SoLog WHERE Ma_cty = @Ma_cty AND So_no = @So_no ORDER BY Log_date DESC`
4. **Test Permissions**: Run procedure with different user roles
5. **Monitor Performance**: Use SQL Server Profiler for slow queries

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Sales & Order Management  
**Dependencies**: SI (Customers, Items), IN (Inventory), AR (Invoicing), GL (Accounting)  
**Criticality**: HIGH (Direct revenue impact)  
**Financial Impact**: YES (Affects revenue recognition)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query SO data for reporting and analysis
- Create draft SOs with validation
- Update SO status following workflow rules
- Generate sales reports and analytics
- Suggest inventory levels based on sales patterns

**AI Agent KHÔNG được phép**:
- Approve SOs without human review
- Modify prices outside approved ranges
- Override credit limit checks
- Delete SOs (only cancel with reason)
- Bypass inventory validation

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required |
|--------|-----------|-------------------|
| Modify SO calculation formulas | Critical | YES (Finance + IT) |
| Add new SO status | High | YES (Business Process Owner) |
| Change discount rules | Medium | YES (Sales Director) |
| Add new report fields | Low | NO (Document change only) |
| Modify validation rules | Medium | YES (Module Owner) |

---

## 13. Future Enhancements

1. **Sales Commission Calculation**: Tự động tính hoa hồng bán hàng dựa trên doanh thu và sản phẩm
2. **Sales Return (RMA) Management**: Quản lý quy trình trả hàng từ khách hàng
3. **Advanced Pricing Engine**: Hỗ trợ giá theo khối lượng, khách hàng nhóm, chiến dịch
4. **Sales Forecasting**: Dự báo bán hàng dựa trên lịch sử và mùa vụ
5. **Customer Portal**: Cho phép khách hàng tự theo dõi đơn hàng
6. **Mobile Sales App**: Ứng dụng di động cho sales force
7. **Integration with E-commerce**: Kết nối với các nền tảng thương mại điện tử
8. **Advanced Analytics**: Phân tích xu hướng bán hàng, khách hàng tiềm năng
9. **Automated Reordering**: Tự động tạo đơn mua hàng dựa trên mức tồn kho tối thiểu
10. **Multi-warehouse Fulfillment**: Tối ưu hóa giao hàng từ nhiều kho

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md) - High-level SP overview
- [Transaction Model](../04_TRANSACTION_MODEL.md) - Transaction patterns
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md) - Error handling guidelines
- [Database Design](../02_DATABASE_DESIGN.md) - Database design principles
- [Naming Conventions](../09_NAMING_CONVENTION.md) - Naming rules
- [AR Module](./AR.md) - Accounts Receivable integration
- [IN Module](./IN.md) - Inventory integration
- [GL Module](./GL.md) - General Ledger integration
- [SI Module](./SI.md) - System master data

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
| [IN](../IN/) | Inventory - Kho hàng |
| [SI](../SI/) | System - Hệ thống |

---

# End of SO Module Documentation