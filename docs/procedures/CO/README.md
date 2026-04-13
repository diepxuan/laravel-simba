# CO – Manufacturing Module

---

## 1. Module Overview

### 1.1 Business Purpose

CO (Manufacturing) quản lý toàn bộ quy trình sản xuất, từ lập kế hoạch sản xuất đến xuất xưởng thành phẩm. Module này:

- Quản lý Định mức nguyên vật liệu (Bill of Materials - BOM)
- Lập kế hoạch sản xuất (Production Planning)
- Tạo lệnh sản xuất (Production Orders)
- Theo dõi quy trình sản xuất theo từng công đoạn
- Quản lý tiêu hao nguyên vật liệu và nhân công
- Quản lý xuất/nhập thành phẩm
- Tính giá thành sản phẩm

**Key Functions**:
- Quản lý BOM đa cấp
- Lập kế hoạch và tạo lệnh sản xuất
- Theo dõi tiến độ sản xuất
- Quản lý tiêu hao NVL và chi phí nhân công
- Quản lý sản xuất theo lô hoặc serial number
- Tính giá thành sản phẩm theo các phương pháp khác nhau
- Báo cáo hiệu quả sản xuất

**Integration Points**:
- **IN (Inventory)**: Xuất NVL, nhập thành phẩm
- **PO (Purchase Order)**: Đặt mua NVL thiếu cho sản xuất
- **SO (Sales Order)**: Lập kế hoạch sản xuất theo đơn hàng
- **GL (General Ledger)**: Post giá vốn thành phẩm, chi phí sản xuất
- **SI (System)**: Danh mục vật tư, kho, công đoạn, máy móc

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Bill of Materials (BOM) | Supported | Định mức nguyên vật liệu |
| Production Planning | Supported | Lập kế hoạch sản xuất |
| Production Order Creation | Supported | Tạo lệnh sản xuất |
| Work Center Management | Supported | Quản lý chuyền/phân xưởng |
| Routing Management | Supported | Quản lý quy trình sản xuất |
| Material Issuance | Supported | Xuất NVL cho lệnh SX |
| Labor Tracking | Supported | Theo dõi thời gian nhân công |
| Production Reporting | Supported | Ghi nhận thành phẩm, phế phẩm |
| Cost Accounting | Supported | Tính giá thành sản phẩm |
| Scrap Reporting | Supported | Báo cáo phế liệu |
| Job Costing | Future | Tính giá thành theo lệnh SX |
| MRP (Material Requirements Planning) | Future | Lập kế hoạch NVL tự động |
| Capacity Planning | Future | Lập kế hoạch năng lực sản xuất |
| Quality Control | Future | Quản lý chất lượng sản phẩm |
| Serial/Lot Traceability | Supported | Theo dõi lô/serial trên thành phẩm và NVL |
| Batch Production | Supported | Sản xuất theo lô thành phẩm |
| Make-to-Stock | Supported | Sản xuất tồn kho |
| Make-to-Order | Supported | Sản xuất theo đơn hàng |

---

### 1.3 Module Naming Convention

**Table Prefix**: `Co` (e.g., `CoPh1`, `CoCt1`, `CoBOM`)

**Stored Procedure Pattern**:
```sql
asCO{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asCOSavePh1` - Lưu header lệnh sản xuất
- `asCOSaveBOM` - Lưu định mức nguyên vật liệu
- `asCOProcessProduction` - Xử lý lệnh sản xuất (xuất NVL, ghi nhận SP)
- `asINIssueForCO` - Xuất NVL cho lệnh sản xuất
- `asINReceiveForCO` - Nhập thành phẩm từ lệnh sản xuất
- `asCOCalculateCost` - Tính giá thành sản phẩm
- `asCORptProductionStatus` - Báo cáo trạng thái lệnh sản xuất

**Table Naming**:
- `CoPh1`: Lệnh sản xuất header
- `CoCt1`: Lệnh sản xuất detail (NVL tiêu hao)
- `CoBOM`: Định mức nguyên vật liệu
- `CoRoute`: Quy trình sản xuất
- `CoWorkCenter`: Phân xưởng/chuyền
- `CoOp`: Công đoạn sản xuất
- `CoYield`: Báo cáo năng suất/phế phẩm

---

## 2. Multi-Tenancy Model

CO module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng CO đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Định mức, lệnh sản xuất, kho hàng được quản lý riêng cho từng công ty
4. Chi phí sản xuất tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có hệ thống BOM, quy trình sản xuất riêng.
- Không thể chuyển NVL hoặc thành phẩm giữa các công ty qua CO module.
- Báo cáo sản xuất chỉ hiển thị data của công ty hiện tại.

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `CoPh1` – Production Order Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `Co_no` | `NVARCHAR(20)` | `NOT NULL` | | Số lệnh sản xuất | Format: CO-YYYYMMDD-XXXX |
| `Co_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày lệnh sản xuất | |
| `So_no` | `NVARCHAR(20)` | `NULL` | | Số SO (nếu sản xuất theo đơn hàng) | |
| `Item_code` | `NVARCHAR(20)` | `NOT NULL` | | Mã thành phẩm | Foreign key to item master |
| `Item_name` | `NVARCHAR(255)` | `NOT NULL` | | Tên thành phẩm | |
| `Quantity_ordered` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng đặt | |
| `Quantity_produced` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng đã sản xuất | <= Quantity_ordered |
| `Quantity_scrapped` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng phế phẩm | |
| `Start_date` | `DATETIME` | `NULL` | | Ngày bắt đầu dự kiến | |
| `End_date` | `DATETIME` | `NULL` | | Ngày kết thúc dự kiến | |
| `Status` | `TINYINT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Planned, 2=In Progress, 3=Completed, 4=Cancelled |
| `Warehouse` | `NVARCHAR(20)` | `NOT NULL` | | Kho chứa thành phẩm | |
| `Cost_center` | `NVARCHAR(20)` | `NULL` | | Trung tâm chi phí | |
| `Notes` | `NVARCHAR(1000)` | `NULL` | | Ghi chú | |
| `Created_by` | `NVARCHAR(50)` | `NOT NULL` | | Người tạo | |
| `Created_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo | |
| `Posted_by` | `NVARCHAR(50)` | `NULL` | | Người post | |
| `Posted_date` | `DATETIME` | `NULL` | | Ngày post | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Co_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, So_no) REFERENCES SoPh1(Ma_cty, So_no)
FOREIGNKEY (Ma_cty, Item_code) REFERENCES SiDmVt(Ma_cty, Ma_vt)
FOREIGN KEY (Ma_cty, Warehouse) REFERENCES SiDmKho(Ma_cty, Ma_kho)
```

**Indexes**:
```sql
CREATE INDEX IX_CoPh1_So_no ON CoPh1 (Ma_cty, So_no)
CREATE INDEX IX_CoPh1_Item_code ON CoPh1 (Ma_cty, Item_code)
CREATE INDEX IX_CoPh1_Status ON CoPh1 (Ma_cty, Status)
CREATE INDEX IX_CoPh1_Date ON CoPh1 (Ma_cty, Co_date)
```

---

#### 3.1.2 `CoCt1` – Production Order Detail (Materials)

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Co_no` | `NVARCHAR(20)` | `NOT NULL` | | Số lệnh sản xuất | |
| `Line_no` | `INT` | `NOT NULL` | | Số dòng | |
| `BOM_line_id` | `INT` | `NOT NULL` | | ID dòng BOM | |
| `Ma_vt_raw` | `NVARCHAR(20)` | `NOT NULL` | | Mã NVL tiêu hao | Foreign key to item master |
| `Ten_vt_raw` | `NVARCHAR(255)` | `NOT NULL` | | Tên NVL tiêu hao | |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `Quantity_required` | `DECIMAL(19,4)` | `NOT NULL` | `0` | SL NVL yêu cầu | |
| `Quantity_issued` | `DECIMAL(19,4)` | `NOT NULL` | `0` | SL NVL đã xuất | <= Quantity_required |
| `Unit_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Giá vốn đơn vị NVL | |
| `Total_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng giá vốn NVL | |
| `Lot_no` | `NVARCHAR(50)` | `NULL` | | Số lô NVL xuất | |
| `Location` | `NVARCHAR(20)` | `NULL` | | Vị trí xuất NVL | |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Co_no, Line_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Co_no) REFERENCES CoPh1(Ma_cty, Co_no)
FOREIGNKEY (Ma_cty, Ma_vt_raw) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

**Indexes**:
```sql
CREATE INDEX IX_CoCt1_Ma_vt_raw ON CoCt1 (Ma_cty, Ma_vt_raw)
CREATE INDEX IX_CoCt1_Lot_no ON CoCt1 (Ma_cty, Lot_no)
```

---

#### 3.1.3 `CoBOM` – Bill of Materials

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Parent_item` | `NVARCHAR(20)` | `NOT NULL` | | Mã thành phẩm | |
| `Component_item` | `NVARCHAR(20)` | `NOT NULL` | | Mã NVL/BHP | |
| `Component_desc` | `NVARCHAR(255)` | `NOT NULL` | | Mô tả NVL/BHP | |
| `Quantity_per_parent` | `DECIMAL(19,4)` | `NOT NULL` | `0` | SL trên 1 đơn vị thành phẩm | |
| `UOM` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `BOM_level` | `INT` | `NOT NULL` | `0` | Cấp độ BOM | |
| `Effective_start_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày bắt đầu hiệu lực | |
| `Effective_end_date` | `DATETIME` | `NULL` | | Ngày kết thúc hiệu lực | |
| `Is_active` | `BIT` | `NOT NULL` | `1` | Trạng thái hoạt động | 1=Active, 0=Inactive |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Parent_item, Component_item, Effective_start_date)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Parent_item) REFERENCES SiDmVt(Ma_cty, Ma_vt)
FOREIGNKEY (Ma_cty, Component_item) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

---

#### 3.1.4 `CoRoute` – Production Routing

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Item_code` | `NVARCHAR(20)` | `NOT NULL` | | Mã thành phẩm | |
| `Routing_code` | `NVARCHAR(20)` | `NOT NULL` | | Mã quy trình | |
| `Routing_desc` | `NVARCHAR(255)` | `NOT NULL` | | Mô tả quy trình | |
| `Version` | `NVARCHAR(10)` | `NOT NULL` | `1.0` | Phiên bản | |
| `Operation_no` | `INT` | `NOT NULL` | | Số công đoạn | |
| `Operation_name` | `NVARCHAR(100)` | `NOT NULL` | | Tên công đoạn | |
| `Work_center` | `NVARCHAR(20)` | `NOT NULL` | | Mã phân xưởng | |
| `Setup_time` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thời gian chuẩn bị | Minutes |
| `Run_time_per_unit` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thời gian chạy/đơn vị | Minutes per unit |
| `Labor_cost_per_hour` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Chi phí nhân công/giờ | |
| `Machine_cost_per_hour` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Chi phí máy/giờ | |
| `Is_active` | `BIT` | `NOT NULL` | `1` | Trạng thái hoạt động | |
| `Effective_start_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày bắt đầu hiệu lực | |
| `Effective_end_date` | `DATETIME` | `NULL` | | Ngày kết thúc hiệu lực | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Item_code, Routing_code, Version, Operation_no)
```

---

### 3.2 Table Relationships

**Relationship Diagram**:
```
CoPh1 (Production Order) --(1:n)--> CoCt1 (Materials Issued)
CoPh1 --(1:n)--> CoYield (Production Yield)

CoBOM --(1:n)--> SiDmVt (Component Item)
CoBOM --(n:1)--> SiDmVt (Parent Item)

CoRoute --(1:n)--> CoWorkCenter (Work Center)
CoRoute --(1:n)--> SiDmVt (Item Code)

CoCt1 --(1:1)--> SiDmVt (Raw Material)
CoCt1 --(1:1)--> InPh2 (Goods Issue)
CoCt1 --(1:1)--> InLot (Issued Lot)

CoPh1 --(1:1)--> SoPh1 (Sales Order)
CoPh1 --(1:1)--> SiDmKho (Finished Goods Warehouse)
CoPh1 --(1:1)--> SiDmKho (Raw Material Warehouse - implicit)
```

**Key Relationships**:
1. **Production Order → Materials**: Một lệnh sản xuất sử dụng nhiều loại NVL.
2. **Production Order → Yield**: Ghi nhận sản phẩm sản xuất ra và phế phẩm.
3. **BOM → Item**: Định mức liên kết thành phẩm với các NVL cấu thành.
4. **Routing → Operation**: Quy trình định nghĩa các bước sản xuất.
5. **Materials Issued → Goods Issue**: Phiếu xuất NVL cho sản xuất.
6. **Production Order → Sales Order**: Lệnh sản xuất có thể được tạo để đáp ứng đơn hàng bán.
7. **Production Order → Inventory**: Ảnh hưởng đến tồn kho NVL và thành phẩm.

---

### 3.3 Data Types Usage

| Data Type | Usage in Module | Examples | Notes |
|-----------|-----------------|----------|-------|
| `DECIMAL(19,4)` | Số lượng, đơn giá, chi phí | `Quantity_ordered`, `Unit_cost`, `Setup_time` | Độ chính xác 4 số thập phân cho số liệu tài chính và số lượng |
| `NVARCHAR(n)` | Mã, tên, mô tả | `Co_no`, `Item_code`, `Notes`, `Work_center` | `n` tùy theo độ dài dự kiến |
| `INT` | Mã số, khóa ngoại, cấp độ | `Ma_cty`, `Line_no`, `BOM_level`, `Operation_no` | |
| `TINYINT` | Trạng thái, cờ | `Status` | 0-255 |
| `DATETIME` | Ngày tháng | `Co_date`, `Start_date`, `Expiry_date` | |
| `BIT` | Cờ boolean | `Is_active`, `Is_lot_controlled` | |

---

## 4. Business Rules

### 4.1 Validation Rules

1. **BOM Validity**: Định mức NVL phải hợp lệ (active, không hết hạn, không có chu kỳ)
   - Validation logic: Check `CoBOM` status, dates, and prevent circular references.
   - Error message: "Định mức NVL không hợp lệ."
   - Stored procedure: `asCOValidateBOM`

2. **Routing Validity**: Quy trình sản xuất phải hợp lệ (active, có đủ công đoạn)
   - Validation logic: Check `CoRoute` status and dates.
   - Error message: "Quy trình sản xuất không hợp lệ."
   - Stored procedure: `asCOValidateRouting`

3. **Inventory Availability**: NVL yêu cầu phải có đủ tồn kho
   - Validation logic: `IssuedQuantity <= AvailableStock` from `InTonKho`
   - Error message: "Không đủ tồn kho NVL {0}. Yêu cầu: {1}, Có sẵn: {2}"
   - Stored procedure: `asCOCheckInventory`

4. **Quantity Check**: Số lượng sản xuất không được âm
   - Validation logic: `Quantity_produced >= 0`
   - Error message: "Số lượng sản xuất không được âm."
   - Stored procedure: `asCOValidateQuantity`

5. **Costing Rules**: Giá vốn được tính theo phương pháp đã định (FIFO/Average)
   - Validation logic: Apply costing logic during production posting.
   - Error message: "Lỗi tính giá vốn."
   - Stored procedure: `asCOCalculateCost`

### 4.2 State Management

**State Machine for Production Order**:
```
Draft (0) -- Submit --> Planned (1)
Planned (1) -- Start --> In Progress (2)
In Progress (2) -- Complete --> Completed (3)
In Progress (2) -- Scrap --> Completed (3) with Scrap
Any State -- Cancel --> Cancelled (4)
```

**State Definitions**:
| State Code | State Name | Description | Allowed Actions |
|------------|------------|-------------|-----------------|
| `0` | Draft | Nháp lệnh sản xuất | Save, Delete, Submit |
| `1` | Planned | Đã lập kế hoạch | Start Production, Cancel |
| `2` | In Progress | Đang sản xuất | Issue Materials, Track Labor, Report Yield, Complete, Scrap, Cancel |
| `3` | Completed | Hoàn thành | View, Post Cost |
| `4` | Cancelled | Đã hủy | View only |

**Production Order Lifecycle**:
- Draft → Planned: Validates BOM and Routing, reserves raw materials.
- Planned → In Progress: Issues raw materials, starts tracking labor and machine time.
- In Progress → Completed: Reports finished goods and scrap. Calculates production cost.
- Completed → Posted Cost: Finalizes cost and posts to GL.

### 4.3 Calculation Rules

**Material Consumption Calculation**:
- Formula: `Quantity Issued = Quantity Required * (1 + Scrap_Factor)`
- Implementation: `asCOIssueMaterials`
- Business rule: Factor in expected scrap rate.

**Production Cost Calculation**:
- Formula: `Total Cost = Material Cost + Labor Cost + Machine Cost + Overhead`
- Material Cost: Sum of `(Quantity Issued * Unit Cost)` from `CoCt1`.
- Labor Cost: Sum of `(Labor Hours * Labor Cost Per Hour)` from `CoRoute` and actual hours tracked.
- Machine Cost: Sum of `(Machine Hours * Machine Cost Per Hour)` from `CoRoute` and actual hours tracked.
- Overhead: Applied as a percentage of direct costs (configured in SI).
- Implementation: `asCOCalculateCost`

**Finished Good Cost Calculation**:
- Determined by the module's costing method (e.g., Average Cost, Standard Cost).
- If using Standard Cost, compare actual vs. standard and generate variance entries.

**Scrap Calculation**:
- Formula: `Scrap Quantity = Reported Scrap - Expected Scrap`
- Impact: Reduces finished goods quantity, increases cost of goods sold (or reduces inventory value).
- Implementation: `asCOReportScrap`

---

## 5. Stored Procedures

### 5.1 Key Stored Procedures

---

#### 5.1.1 `asCOSaveProductionOrder`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCOSaveProductionOrder`
- **Mô tả**: Lưu hoặc cập nhật lệnh sản xuất (header và detail)
- **Module**: CO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pCo_no` | `NVARCHAR(20)` | Số lệnh sản xuất | ✓ | |
| `@pCo_date` | `DATETIME` | Ngày lệnh sản xuất | ✓ | |
| `@pItem_code` | `NVARCHAR(20)` | Mã thành phẩm | ✓ | |
| `@pQuantity_ordered` | `DECIMAL(19,4)` | Số lượng đặt | ✓ | |
| `@pSo_no` | `NVARCHAR(20)` | Số SO (nếu có) | | |
| `@pWarehouse` | `NVARCHAR(20)` | Kho thành phẩm | ✓ | |
| `@pStart_date` | `DATETIME` | Ngày bắt đầu dự kiến | | |
| `@pEnd_date` | `DATETIME` | Ngày kết thúc dự kiến | | |
| `@pStatus` | `TINYINT` | Trạng thái | | `0` |
| `@pNotes` | `NVARCHAR(1000)` | Ghi chú | | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pCoCt1_data` | `XML` / `UDTT` | Dữ liệu dòng NVL | | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate input parameters and item details.
2. Validate BOM and Routing for the item.
3. If new order: Generate `Co_no`.
4. Insert/Update `CoPh1` header.
5. Process `CoCt1` detail lines (materials required).
   - Validate raw materials.
   - Calculate quantities based on BOM and `Quantity_ordered`.
   - Insert/Update `CoCt1`.
6. Log transaction.
7. Return success/failure.

**Tables Used**:
- `CoPh1`: Insert/Update Production Order Header.
- `CoCt1`: Insert/Update Production Order Details.
- `CoBOM`: Validate BOM structure.
- `CoRoute`: Validate Routing.
- `SiDmVt`: Validate item codes.
- `SiDmKho`: Validate warehouse.

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: Validation error
- `@pRet = -2`: BOM/Routing not found or invalid
- `@pRet = -3`: Material not found

**Ví dụ sử dụng**:
```sql
DECLARE @ret INT;
DECLARE @co_no NVARCHAR(20) = 'CO-20240225-0001';

-- XML/UDTT for materials data
DECLARE @materials TABLE (
    Line_no INT, Ma_vt_raw NVARCHAR(20), Quantity_required DECIMAL(19,4), Unit_cost DECIMAL(19,4), Location NVARCHAR(20)
);
INSERT INTO @materials (Line_no, Ma_vt_raw, Quantity_required, Unit_cost, Location)
VALUES
(1, 'NVL001', 10.0000, 5000.0000, 'WHS01-A1'),
(2, 'NVL002', 5.0000, 10000.0000, 'WHS01-B2');

EXEC dbo.asCOSaveProductionOrder
    @pMa_cty = 1,
    @pCo_no = @co_no,
    @pCo_date = GETDATE(),
    @pItem_code = 'SP001',
    @pQuantity_ordered = 100,
    @pWarehouse = 'WHS01',
    @pStart_date = '2024-02-28',
    @pEnd_date = '2024-03-01',
    @pUser_id = 'planner1',
    @pCoCt1_data = (SELECT Line_no, Ma_vt_raw, Quantity_required, Unit_cost, Location FROM @materials),
    @pRet = @ret OUTPUT;

SELECT @ret AS ReturnCode, @co_no AS ProductionOrderNo;
```

---

#### 5.1.2 `asCOProcessProduction`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCOProcessProduction`
- **Mô tả**: Xử lý các bước của lệnh sản xuất (Issue Materials, Report Yield, Post Cost)
- **Module**: CO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pCo_no` | `NVARCHAR(20)` | Số lệnh sản xuất | ✓ | |
| `@pAction` | `NVARCHAR(50)` | Hành động ('IssueMaterials', 'ReportYield', 'PostCost', 'Complete') | ✓ | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Validate `Co_no` and `Action`.
2. Perform action-specific logic:
   - **IssueMaterials**: Calls `asINIssueForCO` to issue raw materials from inventory.
   - **ReportYield**: Records produced and scrapped quantities, updates `CoPh1`.
   - **PostCost**: Calculates and posts production costs to GL.
   - **Complete**: Marks the production order as complete after all steps.
3. Update `CoPh1` status.
4. Log transaction.

**Tables Used**:
- `CoPh1`: Update status, quantities.
- `CoCt1`: Track issued materials.
- `CoYield`: Record yield and scrap.
- `IN` module SPs (e.g., `asINIssueForCO`, `asINReceiveForCO`)
- `GL` module SPs (e.g., `asGLPostProductionCost`)

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: Invalid action or status
- `@pRet = -2`: Inventory issue failed
- `@pRet = -3`: Cost posting failed

---

#### 5.1.3 `asCOCalculateCost`

**Thông tin cơ bản**:
- **Tên đầy đủ**: `dbo.asCOCalculateCost`
- **Mô tả**: Tính toán tổng giá thành cho lệnh sản xuất
- **Module**: CO
- **Tạo bởi**: System Admin (2024-01-01)

**Parameters**:
| Tên | Kiểu dữ liệu | Mô tả | Bắt buộc | Default |
|-----|-------------|-------|----------|---------|
| `@pMa_cty` | `INT` | Mã công ty | ✓ | |
| `@pCo_no` | `NVARCHAR(20)` | Số lệnh sản xuất | ✓ | |
| `@pUser_id` | `NVARCHAR(50)` | User ID | ✓ | |
| `@pRet` | `INT` OUTPUT | Return code | | |

**Workflow**:
1. Retrieve BOM and Routing details for the production order.
2. Calculate total material cost based on `CoCt1` and `InTonKho`.
3. Calculate labor and machine costs based on `CoRoute` and actual production time (if tracked).
4. Apply overhead costs based on system configuration.
5. Sum all costs to get the total production cost.
6. Update `CoPh1` with total cost.
7. Return success/failure.

**Tables Used**:
- `CoPh1`: Get production order details.
- `CoCt1`: Get issued material costs.
- `CoRoute`: Get labor/machine rates.
- `SiDmVt`: Get item costs.
- `SiDmKho` (for overhead config).

**Return Values**:
- `@pRet = 0`: Success
- `@pRet = -1`: Production order not found
- `@pRet = -2`: BOM/Routing not found

---

### 5.2 Procedure Categories

| Category | Prefix Pattern | Examples | Purpose |
|----------|----------------|----------|---------|
| **Save** | `asCOSave*` | `asCOSaveProductionOrder` | Create/Update production orders and BOMs |
| **Get** | `asCOGet*` | `asCOGetBOM`, `asCOGetRouting` | Query production data |
| **Process** | `asCOProcess*` | `asCOProcessProduction` | Execute production steps |
| **Report** | `asCORpt*` | `asCORptProductionStatus` | Generate production reports |
| **Costing** | `asCOCalculate*` | `asCOCalculateCost` | Calculate production costs |
| **Utility** | `asCOValidate*` | `asCOValidateBOM` | Validation functions |

---

## 6. Integration Points

### 6.1 With IN (Inventory Management)

**Integration Type**: Material movement (Issue/Receipt)

**Key Integration Points**:
1. **Material Issuance**: Issue raw materials for production orders.
   - Trigger: When production starts or progresses.
   - Data flow: `CoCt1` → `InPh2` (Issue Header), `InCt2` (Issue Detail).
   - Stored procedures: `asCOProcessProduction` (IssueMaterials action), `asINIssueForCO`.

2. **Finished Goods Receipt**: Receive finished products into inventory.
   - Trigger: When production is completed.
   - Data flow: `CoPh1` (produced qty) → `InPh1` (Receipt Header), `InCt1` (Receipt Detail).
   - Stored procedures: `asCOProcessProduction` (ReportYield action), `asINReceiveForCO`.

3. **Inventory Check**: Validate availability of raw materials.
   - Trigger: During production order creation and material issuance.
   - Data flow: Check `InTonKho`.
   - Stored procedures: `asCOCheckInventory`, `asINValidateAvailability`.

### 6.2 With PO (Purchase Order)

**Integration Type**: Replenishment

**Key Integration Points**:
1. **Generate Purchase Requisitions/Orders**: If raw materials are insufficient, automatically create POs.
   - Trigger: When inventory check fails for required materials.
   - Data flow: `CoCt1` (shortage qty) → `PoReqH`, `PoPh1`.
   - Stored procedures: `asCOGeneratePO` (or integrated with MRP).

### 6.3 With SO (Sales Order)

**Integration Type**: Demand fulfillment

**Key Integration Points**:
1. **Plan Production based on Sales Orders**: Create production orders to meet SO demand.
   - Trigger: When SO is approved or during planning phase.
   - Data flow: `SoPh1` (demand qty) → `CoPh1` (production order).
   - Stored procedures: `asCOCreateFromSO`.

### 6.4 With GL (General Ledger)

**Integration Type**: Financial Posting

**Key Integration Points**:
1. **Cost of Goods Manufactured (COGM)**: Post the cost of finished goods.
   - Trigger: When production order is completed and cost is calculated.
   - Data flow: Production costs → WIP inventory, Finished Goods Inventory.
   - Stored procedures: `asGLPostCOGM`.

2. **Work-in-Progress (WIP)**: Track costs incurred during production.
   - Trigger: As materials are issued and labor is tracked.
   - Data flow: Material costs, labor costs → WIP account.
   - Stored procedures: `asGLPostWIP`.

3. **Scrap Cost**: Post costs associated with scrapped materials/products.
   - Trigger: When scrap is reported.
   - Data flow: Scrap costs → Expense account.
   - Stored procedures: `asGLPostScrap`.

### 6.5 With SI (System)

**Integration Type**: Master Data Reference

**Key Integration Points**:
1. **Item Master**: Reference all items (raw materials, WIP, finished goods).
   - Data flow: `SiDmVt` → `CoBOM`, `CoCt1`, `CoPh1`.

2. **Warehouse Master**: Reference warehouses for material issuance and finished goods receipt.
   - Data flow: `SiDmKho` → `CoPh1`, `CoCt1`.

3. **Work Center / Routing**: Define production steps and resources.
   - Data flow: `SiDmWC`, `CoRoute` → `CoPh1`.

4. **Costing Parameters**: Define overhead rates and costing methods.
   - Data flow: Configured in SI module.

---

## 7. Error Handling

### 7.1 Module-specific Errors

| Error Code | Error Message | Cause | Resolution |
|------------|---------------|-------|------------|
| `CO001` | `Lệnh sản xuất không tồn tại` | Invalid `Co_no` provided. | Verify `Co_no`. |
| `CO002` | `Định mức NVL không hợp lệ` | BOM is inactive, expired, or circular. | Review and update BOM in `CoBOM`. |
| `CO003` | `Quy trình sản xuất không hợp lệ` | Routing is inactive or incomplete. | Review and update `CoRoute`. |
| `CO004` | `Không đủ tồn kho NVL` | Insufficient stock in `InTonKho` for issuance. | Adjust issue quantity or procure more materials. |
| `CO005` | `Lỗi khi xuất NVL` | Failure in `asINIssueForCO` or related IN transactions. | Check IN module logs and stock. |
| `CO006` | `Lỗi khi ghi nhận thành phẩm` | Failure in `asINReceiveForCO` or related IN transactions. | Check IN module logs and stock. |
| `CO007` | `Lỗi tính toán giá thành` | Calculation errors in material, labor, or overhead. | Review costing rules and data. |
| `CO008` | `Không thể chuyển trạng thái` | Invalid state transition attempted. | Follow the defined production order workflow. |
| `CO009` | `NVL không được kiểm soát lô` | Attempted to issue lot for item not lot-controlled. | Use correct item or update item master. |
| `CO010` | `Số lượng phế phẩm không hợp lệ` | Scrap quantity exceeds produced quantity. | Correct reported scrap figures. |

### 7.2 Error Handling Pattern

```sql
-- Standard error handling pattern for CO module
BEGIN TRY
    BEGIN TRANSACTION;
    
    -- Validate input parameters
    IF @pMa_cty IS NULL OR @pCo_no IS NULL OR @pAction IS NULL
    BEGIN
        RAISERROR('Tham số bắt buộc thiếu', 16, 1);
    END
    
    -- Check if Production Order exists and is in a valid state for the action
    SELECT @CurrentStatus = Status FROM CoPh1 WHERE Ma_cty = @pMa_cty AND Co_no = @pCo_no;
    IF @CurrentStatus IS NULL
    BEGIN
        RAISERROR('CO001: Lệnh sản xuất không tồn tại.', 16, 1);
    END
    -- Add logic to check valid state transitions based on @pAction

    -- Execute action-specific logic (e.g., call to IN module SPs)
    IF @pAction = 'IssueMaterials'
    BEGIN
        -- EXEC asINIssueForCO ...
    END
    ELSE IF @pAction = 'ReportYield'
    BEGIN
        -- Update CoPh1.Quantity_produced, CoPh1.Quantity_scrapped
    END
    -- ... other actions

    -- Update Production Order Status
    UPDATE CoPh1 SET Status = @pNewStatus, Modified_by = @pUser_id, Modified_date = GETDATE() WHERE Ma_cty = @pMa_cty AND Co_no = @pCo_no;
    
    COMMIT TRANSACTION;
    
    SELECT 0 AS ReturnCode, 'Success' AS Message;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
    
    -- Log error with module context
    EXEC asLogError 
        @pMa_cty = @pMa_cty,
        @pModule = 'CO',
        @pProcedure = ERROR_PROCEDURE(),
        @pErrorNumber = ERROR_NUMBER(),
        @pErrorMessage = ERROR_MESSAGE(),
        @pCo_no = @pCo_no; -- Include relevant entity ID
    
    THROW; -- Re-throw the error
END CATCH
```

---

## 8. Performance Guidelines

### 8.1 Indexing Strategy

**Must-have Indexes**:
1. `(Ma_cty, Co_no)` - Primary key for `CoPh1`, `CoCt1`.
2. `(Ma_cty, Item_code, Co_date)` - For querying production orders by item and date range.
3. `(Ma_cty, Status)` - For filtering orders by their current status.
4. `(Ma_cty, Ma_vt_raw)` - For material issuance queries.
5. `(Ma_cty, Warehouse)` - For inventory-related checks.

**Recommended Indexes**:
1. `(Ma_cty, Co_date)` INCLUDE (`Item_code`, `Quantity_ordered`, `Status`) - For production planning reports.
2. `(Ma_cty, So_no)` - If `CoPh1` is frequently joined with `SoPh1`.
3. `(Ma_cty, Ma_vt_raw, Location)` - For optimizing material issuance from specific locations.

### 8.2 Query Optimization Tips

1. **BOM Explosion**: Optimize BOM explosion queries (recursive CTEs or iterative approaches) for performance, especially for deep BOMs.
2. **Material Issuance**: Ensure efficient lookups for available stock and lots (`InTonKho`, `InLot`).
3. **Cost Calculation**: Pre-calculate standard costs or use efficient methods for average cost updates.
4. **Avoid `SELECT *`**: Always specify required columns.
5. **Batch Processing**: For large volumes (e.g., reporting, cost calculation), use batch processing or scheduled jobs.

### 8.3 Monitoring Metrics

| Metric | Target | Monitoring Query |
|--------|--------|------------------|
| Production Order Creation Time | < 1s | `AVG(DATEDIFF(ms, Created_date, Posted_date))` from `CoPh1` logs |
| Material Issuance Time | < 500ms | `AVG(DATEDIFF(ms, IssueStartTime, IssueEndTime))` in `InLog` |
| Production Cost Calculation Time | < 10s (for single PO) | `AVG(DATEDIFF(ms, StartTime, EndTime))` from cost calculation log |
| WIP Inventory Value | Tracked | `SUM(On_hand * Unit_cost)` from `InTonKho` linked to WIP items |
| Scrap Rate | < 2% | `SUM(Quantity_scrapped) / SUM(Quantity_produced + Quantity_scrapped)` |

---

## 9. Security Model

### 9.1 Permission Matrix

| Role | Permission | Description | Stored Procedure |
|------|------------|-------------|------------------|
| `Planner` | Plan PO | Create/Edit production plan and orders | `asCOSaveProductionOrder` |
| `Shop Floor Operator` | Issue Materials | Issue raw materials for production | `asCOProcessProduction` (IssueMaterials) |
| `Shop Floor Operator` | Report Yield | Report finished goods and scrap | `asCOProcessProduction` (ReportYield) |
| `Cost Accountant` | Calculate & Post Cost | Calculate and post production costs | `asCOCalculateCost`, `asCOProcessProduction` (PostCost) |
| `Warehouse Staff` | Receive FG | Receive finished goods | `asINReceiveForCO` |
| `View Only` | View Production Data | Read production orders, BOMs, routes | `asCOGet*` procedures |

### 9.2 Data Access Security

- **Row-level Security**: Enforced via `Ma_cty` filtering for all data access.
- **BOM/Routing Security**: Only authorized users (e.g., Engineering, Production Manager) can modify BOMs and Routings.
- **Costing Security**: Only Cost Accountants can access and post production costs.
- **Audit Trail**: All significant actions (creation, modification, posting, cancellation) are logged in `CoLog` or `InLog` tables.

---

## 10. Common Tasks & Examples

### 10.1 Task 1: Create and Issue Materials for a Production Order

**Steps**:
1. Define BOM and Routing for the finished product.
2. Create a Production Order header (`CoPh1`).
3. Add material requirements to `CoCt1` based on BOM.
4. Validate and issue raw materials from inventory.
5. Update `CoPh1` status to 'In Progress'.

**Example Code**:
```sql
-- 1. Create Production Order
DECLARE @ret INT, @co_no NVARCHAR(20) = 'CO-20240225-0002';

EXEC dbo.asCOSaveProductionOrder
    @pMa_cty = 1,
    @pCo_no = @co_no,
    @pCo_date = GETDATE(),
    @pItem_code = 'SP001', -- Finished Product
    @pQuantity_ordered = 50,
    @pWarehouse = 'WHS01', -- FG Warehouse
    @pStart_date = '2024-02-28',
    @pUser_id = 'planner1',
    @pRet = @ret OUTPUT;

IF @ret = 0
BEGIN
    PRINT 'Production Order ' + @co_no + ' created.';

    -- 2. Issue Materials (example, assuming details are pre-defined or fetched)
    -- This usually involves calling a specific action within ProcessProduction
    -- For simplicity, we show a direct call to a hypothetical IN SP that links to CO
    
    -- Assuming materials are already in CoCt1 from SaveProductionOrder
    -- Let's simulate issuing materials
    EXEC dbo.asCOProcessProduction
        @pMa_cty = 1,
        @pCo_no = @co_no,
        @pAction = 'IssueMaterials',
        @pUser_id = 'shopfloor1',
        @pRet = @ret OUTPUT;

    IF @ret = 0
        PRINT 'Materials issued successfully for CO ' + @co_no;
    ELSE
        PRINT 'Error issuing materials for CO ' + @co_no;
END
ELSE
BEGIN
    PRINT 'Error creating Production Order: ' + CAST(@ret AS NVARCHAR(10));
END
```

### 10.2 Task 2: Report Production Yield and Complete Order

**Steps**:
1. Report the number of good units produced and scrapped units.
2. Update the production order status.
3. Calculate the production cost.
4. Post the costs to GL.

**Example Code**:
```sql
DECLARE @ret INT, @co_no NVARCHAR(20) = 'CO-20240225-0002';

-- 1. Report Yield and Scrap
-- This action updates CoPh1.Quantity_produced and Quantity_scrapped
EXEC dbo.asCOProcessProduction
    @pMa_cty = 1,
    @pCo_no = @co_no,
    @pAction = 'ReportYield',
    @pUser_id = 'shopfloor1',
    @pRet = @ret OUTPUT;

IF @ret = 0
BEGIN
    PRINT 'Yield reported for CO ' + @co_no;

    -- 2. Complete the Production Order
    EXEC dbo.asCOProcessProduction
        @pMa_cty = 1,
        @pCo_no = @co_no,
        @pAction = 'Complete',
        @pUser_id = 'supervisor1',
        @pRet = @ret OUTPUT;

    IF @ret = 0
    BEGIN
        PRINT 'Production Order ' + @co_no + ' completed.';

        -- 3. Calculate and Post Cost
        EXEC dbo.asCOProcessProduction
            @pMa_cty = 1,
            @pCo_no = @co_no,
            @pAction = 'PostCost',
            @pUser_id = 'cost_accountant1',
            @pRet = @ret OUTPUT;
            
        IF @ret = 0
            PRINT 'Production cost posted for CO ' + @co_no;
        ELSE
            PRINT 'Error posting cost for CO ' + @co_no;
    END
END
```

---

## 11. Troubleshooting

### 11.1 Common Issues

| Issue | Symptoms | Root Cause | Solution |
|-------|----------|------------|----------|
| **Cannot create Production Order** | Error: "BOM not found" or "Routing not found" | Inactive or missing BOM/Routing definitions. | Ensure `CoBOM` and `CoRoute` are set up correctly for the item and active. |
| **Material Issuance fails** | Error: "Insufficient inventory" or "Lot not found" | Lack of stock, incorrect lot specified, or item not lot-controlled. | Check `InTonKho` and `InLot` status. Verify item's lot control setting. |
| **Production Cost is inaccurate** | Calculated cost is too high/low. | Incorrect BOM quantities, labor rates, overhead rates, or scrap factors. | Review BOM accuracy, routing costs, and overhead configuration. |
| **Cannot complete Production Order** | Order stuck in 'In Progress' state. | Unreported yield, unissued materials, or failed cost posting. | Ensure all steps are completed and transactions are posted. Check logs. |
| **Inventory Discrepancies** | System inventory does not match physical counts. | Errors in material issuance, yield reporting, or manual adjustments. | Perform regular physical counts and adjustments. Review transaction logs. |

### 11.2 Debugging Tips

1. **Check BOM & Routing**: Verify `CoBOM` and `CoRoute` for the item code and effective dates.
2. **Inspect Inventory**: Use `asINGetAvailableStock` to check `InTonKho` and `InLot` for raw materials.
3. **Review Transaction Logs**: Check `InLog` for material issuance/receipts and `CoLog` for production order changes.
4. **Trace Cost Calculation**: Step through `asCOCalculateCost` SP to understand cost breakdown.
5. **Verify GL Postings**: Check `GlEntry` table for the expected financial impact.

---

## 12. AI Agent Contract Section

### 12.1 Module Summary

**Domain**: Manufacturing Operations  
**Dependencies**: IN (Inventory), PO (Procurement), SO (Sales Demand), GL (Accounting), SI (Master Data)  
**Criticality**: HIGH (Directly impacts cost of goods sold and production efficiency)  
**Financial Impact**: YES (Crucial for inventory valuation and COGS)  

### 12.2 Safe Operations

**AI Agent được phép**:
- Query BOM, Routing, and Production Order data.
- Generate production reports (e.g., status, yield, cost).
- Create draft production orders based on demand.
- Suggest material issuance quantities based on BOM.
- Monitor inventory levels for raw materials and finished goods.

**AI Agent KHÔNG được phép**:
- Modify BOMs or Routings without Engineering approval.
- Directly issue materials or report yield without operator confirmation.
- Post production costs without Cost Accountant review.
- Override inventory availability checks.
- Cancel production orders.

### 12.3 Impact Matrix

| Change | Risk Level | Approval Required |
|--------|-----------|-------------------|
| Modify BOM structure | Critical | YES (Engineering + Production Mgmt) |
| Change costing method | High | YES (Finance + IT) |
| Automate material issuance | Medium | YES (Production Manager) |
| Add new production stages | Medium | YES (Production Manager) |
| Modify yield reporting logic | Low | NO (Documentation change) |

---

## 13. Future Enhancements

1. **Material Requirements Planning (MRP)**: Automated planning of raw material procurement based on production schedules and inventory levels.
2. **Capacity Planning**: Analysis of production capacity and scheduling optimization.
3. **Advanced Costing Methods**: Support for Standard Costing, Activity-Based Costing.
4. **Shop Floor Data Collection**: Real-time tracking of production progress, labor, and machine usage.
5. **Quality Management Integration**: Deeper integration with quality control processes.
6. **Serial Number Tracking**: End-to-end traceability of individual serialized items.
7. **Lean Manufacturing Principles**: Implementation of Kanban, Just-In-Time (JIT) concepts.
8. **MES Integration**: Seamless connection with Manufacturing Execution Systems.
9. **Predictive Maintenance**: For machinery used in production.
10. **AI-powered Yield Prediction**: Forecasting yield based on historical data and current conditions.

---

## 14. Related Documents

- [Stored Procedures Catalog](../STORED_PROCEDURES_CATALOG.md)
- [Transaction Model](../04_TRANSACTION_MODEL.md)
- [Error Handling Standard](../08_ERROR_HANDLING_STANDARD.md)
- [Database Design](../02_DATABASE_DESIGN.md)
- [Naming Conventions](../09_NAMING_CONVENTION.md)
- [IN Module](./IN.md) - Inventory Integration
- [PO Module](./PO.md) - Purchase Order Integration
- [SO Module](./SO.md) - Sales Order Integration
- [GL Module](./GL.md) - General Ledger Integration
- [SI Module](./SI.md) - System Master Data

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
| [IN](../IN/) | Inventory - Kho hàng |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [SI](../SI/) | System - Hệ thống |

---

# End of CO Module Documentation