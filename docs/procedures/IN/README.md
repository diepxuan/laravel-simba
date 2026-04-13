# IN – Inventory Management Module

---

## 1. Module Overview

### 1.1 Business Purpose

IN (Inventory Management) quản lý toàn bộ hàng tồn kho trong hệ thống ERP, bao gồm:

- Theo dõi số lượng tồn kho thực tế
- Quản lý nhập kho, xuất kho, chuyển kho
- Kiểm kê và điều chỉnh tồn kho
- Quản lý lô hàng, hạn sử dụng
- Tính giá vốn hàng tồn kho (FIFO, Average Cost)
- Cảnh báo tồn kho tối thiểu/tối đa
- Quản lý nhiều kho, vị trí trong kho

Module này đóng vai trò trung tâm cho quản lý vật tư và liên kết với:

- **PO (Purchase Order)**: Nhận hàng từ đơn mua
- **SO (Sales Order)**: Xuất hàng cho đơn bán
- **CO (Manufacturing)**: Xuất NVL và nhập thành phẩm
- **GL (General Ledger)**: Ghi sổ giá trị tồn kho
- **SI (System)**: Danh mục vật tư, kho, đơn vị tính

**Key Functions**:
- Quản lý tồn kho theo nhiều kho, vị trí
- Xử lý phiếu nhập, xuất, chuyển kho
- Tính giá vốn và giá trị tồn kho
- Quản lý lô, serial number, hạn sử dụng
- Kiểm kê và điều chỉnh tồn kho
- Báo cáo tồn kho, luân chuyển hàng tồn
- Cảnh báo tồn kho

**Integration Points**:
- **PO (Purchase)**: Nhập kho từ đơn mua hàng
- **SO (Sales)**: Xuất kho cho đơn bán hàng
- **CO (Manufacturing)**: Xuất NVL và nhập thành phẩm
- **GL (General Ledger)**: Post giá trị tồn kho
- **SI (System)**: Danh mục vật tư, kho, đơn vị tính
- **AP (Payable)**: Đối chiếu nhập kho với hóa đơn

---

### 1.2 Scope

| Chức năng | Trạng thái | Ghi chú |
|-----------|------------|---------|
| Inventory Receiving | Supported | Nhập kho từ PO, nhập khác |
| Inventory Issuing | Supported | Xuất kho cho SO, xuất khác |
| Inventory Transfer | Supported | Chuyển kho nội bộ |
| Inventory Adjustment | Supported | Điều chỉnh tồn kho |
| Physical Count | Supported | Kiểm kê thực tế |
| Lot/Serial Tracking | Supported | Theo dõi lô, serial number |
| Expiry Date Management | Supported | Quản lý hạn sử dụng |
| Cost Calculation (FIFO) | Supported | Tính giá vốn FIFO |
| Cost Calculation (Average) | Supported | Tính giá vốn bình quân |
| Multi-location Inventory | Supported | Nhiều vị trí trong kho |
| Stock Reservation | Supported | Giữ hàng cho đơn hàng |
| Stock Replenishment | Future | Tự động đặt hàng bổ sung |
| Cycle Counting | Future | Kiểm kê theo chu kỳ |
| Quality Inspection | Future | Kiểm tra chất lượng nhập kho |
| Barcode Integration | Future | Quét mã vạch |
| Inventory Forecasting | Future | Dự báo nhu cầu tồn kho |

---

### 1.3 Module Naming Convention

**Table Prefix**: `In` (e.g., `InPh1`, `InCt1`, `InTonKho`)

**Stored Procedure Pattern**:
```sql
asIN{Action}{Entity}{OptionalSuffix}
```

**Examples**:
- `asINSavePh1` - Lưu phiếu nhập kho
- `asINSavePh2` - Lưu phiếu xuất kho
- `asINProcessReceipt` - Xử lý nhập kho
- `asINUpdateInventory` - Cập nhật tồn kho
- `asINRptInventory` - Báo cáo tồn kho
- `asINGetAvailableStock` - Lấy tồn kho khả dụng

**Table Naming**:
- `InPh1`: Phiếu nhập kho header
- `InCt1`: Phiếu nhập kho detail
- `InPh2`: Phiếu xuất kho header
- `InCt2`: Phiếu xuất kho detail
- `InPh3`: Phiếu chuyển kho header
- `InCt3`: Phiếu chuyển kho detail
- `InTonKho`: Tồn kho hiện tại
- `InLot`: Quản lý lô hàng
- `InSerial`: Quản lý serial number

---

## 2. Multi-Tenancy Model

IN module tuân thủ strict multi-tenancy với `Ma_cty`:

**Key Principles**:
1. Tất cả bảng IN đều có `Ma_cty INT NOT NULL` trong primary key
2. Mọi stored procedure BẮT BUỘC filter theo `@pMa_cty`
3. Kho hàng được quản lý riêng cho từng công ty
4. Tồn kho tính toán độc lập cho từng công ty

**Implementation Details**:
- Mỗi công ty có danh mục kho hàng riêng
- Không thể chuyển kho giữa các công ty
- Báo cáo tồn kho chỉ hiển thị data của công ty hiện tại
- Giá vốn có thể khác nhau giữa các công ty

---

## 3. Data Model

### 3.1 Core Tables

---

#### 3.1.1 `InPh1` – Goods Receipt Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | Foreign key to company table |
| `In_no` | `NVARCHAR(20)` | `NOT NULL` | | Số phiếu nhập | Format: IN-YYYYMMDD-XXXX |
| `In_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày nhập kho | |
| `In_type` | `TINYINT` | `NOT NULL` | `1` | Loại nhập | 1=From PO, 2=Other Receipt, 3=Return |
| `Po_no` | `NVARCHAR(20)` | `NULL` | | Số PO (nếu từ PO) | |
| `Warehouse` | `NVARCHAR(20)` | `NOT NULL` | | Mã kho nhập | Foreign key to warehouse master |
| `Supplier` | `NVARCHAR(20)` | `NULL` | | Nhà cung cấp | |
| `Reference` | `NVARCHAR(50)` | `NULL` | | Số tham chiếu | |
| `Status` | `TINYINT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Posted, 2=Cancelled |
| `Total_qty` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng số lượng | |
| `Total_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng giá trị | |
| `Notes` | `NVARCHAR(1000)` | `NULL` | | Ghi chú | |
| `Created_by` | `NVARCHAR(50)` | `NOT NULL` | | Người tạo | |
| `Created_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo | |
| `Posted_by` | `NVARCHAR(50)` | `NULL` | | Người post | |
| `Posted_date` | `DATETIME` | `NULL` | | Ngày post | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, In_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Po_no) REFERENCES PoPh1(Ma_cty, Po_no)
FOREIGN KEY (Ma_cty, Warehouse) REFERENCES SiDmKho(Ma_cty, Ma_kho)
```

**Indexes**:
```sql
CREATE INDEX IX_InPh1_Po_no ON InPh1 (Ma_cty, Po_no)
CREATE INDEX IX_InPh1_Warehouse ON InPh1 (Ma_cty, Warehouse)
CREATE INDEX IX_InPh1_Date ON InPh1 (Ma_cty, In_date)
```

---

#### 3.1.2 `InCt1` – Goods Receipt Detail

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `In_no` | `NVARCHAR(20)` | `NOT NULL` | | Số phiếu nhập | |
| `Line_no` | `INT` | `NOT NULL` | | Số dòng | |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư | Foreign key to item master |
| `Ten_vt` | `NVARCHAR(255)` | `NOT NULL` | | Tên vật tư | |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `Quantity` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng nhập | > 0 |
| `Unit_price` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Đơn giá nhập | >= 0 |
| `Line_amount` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền | = Quantity * Unit_price |
| `Lot_no` | `NVARCHAR(50)` | `NULL` | | Số lô | |
| `Expiry_date` | `DATETIME` | `NULL` | | Hạn sử dụng | |
| `Location` | `NVARCHAR(20)` | `NULL` | | Vị trí trong kho | |
| `Po_line_no` | `INT` | `NULL` | | Dòng PO tương ứng | |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú dòng | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, In_no, Line_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, In_no) REFERENCES InPh1(Ma_cty, In_no)
FOREIGN KEY (Ma_cty, Ma_vt) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

**Indexes**:
```sql
CREATE INDEX IX_InCt1_Ma_vt ON InCt1 (Ma_cty, Ma_vt)
CREATE INDEX IX_InCt1_Lot_no ON InCt1 (Ma_cty, Lot_no)
```

---

#### 3.1.3 `InPh2` – Goods Issue Header

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Out_no` | `NVARCHAR(20)` | `NOT NULL` | | Số phiếu xuất | Format: OUT-YYYYMMDD-XXXX |
| `Out_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày xuất kho | |
| `Out_type` | `TINYINT` | `NOT NULL` | `1` | Loại xuất | 1=For SO, 2=For Production, 3=Other Issue |
| `So_no` | `NVARCHAR(20)` | `NULL` | | Số SO (nếu từ SO) | |
| `Co_no` | `NVARCHAR(20)` | `NULL` | | Số lệnh sản xuất | |
| `Warehouse` | `NVARCHAR(20)` | `NOT NULL` | | Mã kho xuất | |
| `Customer` | `NVARCHAR(20)` | `NULL` | | Khách hàng | |
| `Reference` | `NVARCHAR(50)` | `NULL` | | Số tham chiếu | |
| `Status` | `TINYINT` | `NOT NULL` | `0` | Trạng thái | 0=Draft, 1=Posted, 2=Cancelled |
| `Total_qty` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng số lượng | |
| `Total_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Tổng giá vốn | |
| `Notes` | `NVARCHAR(1000)` | `NULL` | | Ghi chú | |
| `Created_by` | `NVARCHAR(50)` | `NOT NULL` | | Người tạo | |
| `Created_date` | `DATETIME` | `NOT NULL` | `GETDATE()` | Ngày tạo | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Out_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, So_no) REFERENCES SoPh1(Ma_cty, So_no)
FOREIGN KEY (Ma_cty, Co_no) REFERENCES CoPh1(Ma_cty, Co_no)
FOREIGN KEY (Ma_cty, Warehouse) REFERENCES SiDmKho(Ma_cty, Ma_kho)
```

---

#### 3.1.4 `InCt2` – Goods Issue Detail

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Out_no` | `NVARCHAR(20)` | `NOT NULL` | | Số phiếu xuất | |
| `Line_no` | `INT` | `NOT NULL` | | Số dòng | |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư | |
| `Ten_vt` | `NVARCHAR(255)` | `NOT NULL` | | Tên vật tư | |
| `Dvt` | `NVARCHAR(20)` | `NOT NULL` | | Đơn vị tính | |
| `Quantity` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng xuất | > 0 |
| `Unit_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Giá vốn đơn vị | Tính theo FIFO/Average |
| `Line_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Thành tiền giá vốn | = Quantity * Unit_cost |
| `Lot_no` | `NVARCHAR(50)` | `NULL` | | Số lô xuất | |
| `Location` | `NVARCHAR(20)` | `NULL` | | Vị trí xuất | |
| `So_line_no` | `INT` | `NULL` | | Dòng SO tương ứng | |
| `Co_line_no` | `INT` | `NULL` | | Dòng CO tương ứng | |
| `Notes` | `NVARCHAR(500)` | `NULL` | | Ghi chú dòng | |

**Primary Key**:
```sql
PRIMARY KEY (Ma_cty, Out_no, Line_no)
```

**Foreign Keys**:
```sql
FOREIGN KEY (Ma_cty, Out_no) REFERENCES InPh2(Ma_cty, Out_no)
FOREIGN KEY (Ma_cty, Ma_vt) REFERENCES SiDmVt(Ma_cty, Ma_vt)
```

---

#### 3.1.5 `InTonKho` – Current Inventory

| Column | Type | Nullable | Default | Description | Business Rules |
|--------|------|----------|---------|-------------|----------------|
| `Ma_cty` | `INT` | `NOT NULL` | | Mã công ty | |
| `Ma_vt` | `NVARCHAR(20)` | `NOT NULL` | | Mã vật tư | |
| `Warehouse` | `NVARCHAR(20)` | `NOT NULL` | | Mã kho | |
| `Location` | `NVARCHAR(20)` | `NULL` | | Vị trí | |
| `Lot_no` | `NVARCHAR(50)` | `NULL` | | Số lô | |
| `On_hand` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng tồn | |
| `Committed` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng đã cam kết | |
| `Available` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Số lượng khả dụng | = On_hand - Committed |
| `Unit_cost` | `DECIMAL(19,4)` | `NOT NULL` | `0` | Giá vốn đơn vị | |
| `Total_cost` | `DECIMAL(19,4)` | `

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
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [CO](../CO/) | Manufacturing - Sản xuất |
| [SI](../SI/) | System - Hệ thống |

---

# End of IN Module Documentation
