# Dashboard (Dash) - Bảng điều khiển và Báo cáo tổng hợp

Module cung cấp dữ liệu cho dashboard, báo cáo tổng hợp và các chỉ số KPI cho lãnh đạo.

---

## Tổng quan

**Purpose:** Cung cấp dữ liệu tổng hợp từ các module khác để hiển thị trên dashboard, hỗ trợ ra quyết định.

**Key Functions:**
- Báo cáo kết quả kinh doanh
- So sánh kế hoạch và thực tế
- Theo dõi doanh số bán hàng
- Theo dõi tồn kho
- Theo dõi hóa đơn đến hạn thanh toán
- Cung cấp dữ liệu cho biểu đồ

---

## Database Tables

### Primary Tables (Source)
```
GLCT           - Chi tiết sổ cái (Kết quả KD)
GLBudget       - Ngân sách/kế hoạch
SOCT           - Chi tiết bán hàng (Doanh số)
INCT           - Chi tiết nhập xuất kho (Tồn kho)
ARTT           - Theo dõi thanh toán (Công nợ)
ARPH3          - Hóa đơn bán hàng
INdmvt         - Danh mục vật tư
COdmspct       - Danh mục thành phẩm
GLdmtk         - Danh mục tài khoản
ARdmkh         - Danh mục khách hàng
```

### Helper Functions
```
afDuCuoiTk     - Lấy số dư cuối tài khoản
afGetTonCuoiVtAll - Lấy tồn cuối vật tư
```

---

## Stored Procedures

**Tổng số:** 10 procedures

### Categories

#### 1. Parameter Operations (Tham số)
```
asDashGetParameter      - Lấy danh sách tham số của stored procedure
```

#### 2. Sales Dashboard (Bán hàng)
```
asDashSODoanhSoMatHang      - Doanh số theo mặt hàng (bảng)
asDashSODoanhSoMatHang4Chart - Doanh số theo mặt hàng (chart)
asDashSOHoaDonDenHan        - Hóa đơn đến hạn thanh toán
```

#### 3. Financial Dashboard (Tài chính)
```
asDashGLKetQuaKinhDoanh     - Kết quả kinh doanh
asDashGLSoSanhKH_TT         - So sánh kế hoạch và thực tế
```

#### 4. Inventory Dashboard (Kho)
```
asDashINThanhPhamNhapKho    - Thành phẩm nhập kho
asDashINGetTonKhoNhoHonToiThieu - Tồn kho nhỏ hơn tối thiểu
```

#### 5. Demo/Example
```
asDashDemoChart             - Demo chart data
asDashExample               - Ví dụ dashboard data
```

---

## Business Flows

### 1. Dashboard Kết Quả Kinh Doanh
```
Period End
      ↓
1. asDashGLKetQuaKinhDoanh
      ↓
2. Tính Doanh thu (TK 511)
      ↓
3. Tính Giá vốn (TK 632)
      ↓
4. Tính Chi phí bán hàng (TK 641)
      ↓
5. Tính Chi phí QLDN (TK 642)
      ↓
6. Tính Lợi nhuận
      ↓
7. Hiển thị: Trong kỳ + Lũy kế
```

### 2. Dashboard So Sánh Kế Hoạch - Thực Tế
```
Budget Setup
      ↓
1. asDashGLSoSanhKH_TT
      ↓
2. Lấy kế hoạch từ GLBudget
      ↓
3. Lấy thực tế từ GLCT
      ↓
4. Tính tỷ lệ hoàn thành
      ↓
5. Hiển thị: Kế hoạch | Thực tế | % hoàn thành
```

### 3. Dashboard Doanh Số Bán Hàng
```
Sales Data
      ↓
1. asDashSODoanhSoMatHang
      ↓
2. Tính doanh số trong kỳ (tháng hiện tại)
      ↓
3. Tính doanh số lũy kế (từ đầu năm)
      ↓
4. Gom nhóm theo mặt hàng
      ↓
5. TOP N mặt hàng doanh số cao nhất
      ↓
6. Hiển thị: Mã, Tên, Số lượng, Doanh số
```

### 4. Dashboard Tồn Kho
```
Inventory Data
      ↓
1. asDashINGetTonKhoNhoHonToiThieu
      ↓
2. Lấy tồn cuối tất cả vật tư
      ↓
3. So sánh với tồn tối thiểu (sl_min)
      ↓
4. Tính chênh lệch
      ↓
5. Hiển thị: VT có tồn < tối thiểu
```

### 5. Dashboard Hóa Đơn Đến Hạn
```
AR Data
      ↓
1. asDashSOHoaDonDenHan
      ↓
2. Lấy hóa đơn chưa thanh toán
      ↓
3. Tính ngày đến hạn (ngay_ct + han_tt)
      ↓
4. So sánh với ngày hiện tại
      ↓
5. Lọc theo số ngày báo trước
      ↓
6. Hiển thị: Sắp đến hạn + Quá hạn
```

---

## Key Parameters

### Common Parameters
```sql
@pMa_cty       -- Mã công ty (Company ID)
@pNam          -- Năm (Year)
@pThang        -- Tháng (Month)
@pTOP          -- Số dòng TOP (default 5)
@pMa_kh        -- Mã khách hàng
@pMa_bp        -- Mã bộ phận
@pMa_vt        -- Mã vật tư
@pMa_kho       -- Mã kho
@pSoNgayBaoTruoc -- Số ngày báo trước
@pHien_KT      -- Hiển thị kỳ trước (0/1)
@pHien_LK      -- Hiển thị lũy kế (0/1)
@pTheo_kho     -- Theo từng kho (1) hay theo VT (2)
```

### Dashboard Accounts
```sql
@tk_dt         -- Tài khoản doanh thu (511)
@tk_gv         -- Tài khoản giá vốn (632)
@tk_cpbh       -- Tài khoản chi phí bán hàng (641)
@tk_cpql       -- Tài khoản chi phí QLDN (642)
```

---

## Usage Examples

### 1. Kết Quả Kinh Doanh
```sql
-- Xem kết quả kinh doanh năm 2026
EXEC asDashGLKetQuaKinhDoanh
    @pMa_cty = '001',
    @pNam = 2026

-- Kết quả trả về:
-- Chỉ tiêu        | Trong kỳ | Lũy kế
-- Doanh thu       | xxx      | xxx
-- Giá vốn         | xxx      | xxx
-- CP bán hàng     | xxx      | xxx
-- CP QLDN         | xxx      | xxx
-- Lợi nhuận       | xxx      | xxx
-- Tồn quỹ         | xxx      |
```

### 2. So Sánh Kế Hoạch - Thực Tế
```sql
-- So sánh kế hoạch và thực tế năm 2026
EXEC asDashGLSoSanhKH_TT
    @pMa_cty = '001',
    @pNam = 2026

-- Kết quả trả về:
-- Tài khoản | Tên TK | Kế hoạch | Thực tế | % hoàn thành
```

### 3. Doanh Số Theo Mặt Hàng
```sql
-- TOP 10 mặt hàng doanh số cao nhất
EXEC asDashSODoanhSoMatHang
    @pMa_cty = '001',
    @pNam = 2026,
    @pTOP = 10

-- Kết quả trả về:
-- Mã hàng | Tên hàng | Đvt | Số lượng | Doanh số | SL LK | DS LK
```

### 4. Doanh Số Cho Chart
```sql
-- Dữ liệu cho biểu đồ (chỉ Tên hàng và DS LK)
EXEC asDashSODoanhSoMatHang4Chart
    @pMa_cty = '001',
    @pNam = 2026,
    @pTOP = 5
```

### 5. Thành Phẩm Nhập Kho
```sql
-- Xem thành phẩm nhập kho tháng này + lũy kế
EXEC asDashINThanhPhamNhapKho
    @pMa_cty = '001',
    @pNam = 2026,
    @pHien_KT = '0',
    @pHien_LK = '1'

-- Kết quả trả về:
-- Mã hàng | Tên hàng | Đvt | Tháng này | Lũy kế
```

### 6. Tồn Kho Dưới Mức Tối Thiểu
```sql
-- Cảnh báo tồn kho dưới mức tối thiểu
EXEC asDashINGetTonKhoNhoHonToiThieu
    @pMa_cty = '001',
    @pNam = 2026,
    @pMa_Kho = '',
    @pMa_vt = '',
    @pTheo_kho = '2'

-- Kết quả trả về:
-- Mã VT | Tên VT | Tồn cuối | Tối thiểu | Chênh lệch | Kho
```

### 7. Hóa Đơn Đến Hạn Thanh Toán
```sql
-- Hóa đơn sắp đến hạn trong 10 ngày tới
EXEC asDashSOHoaDonDenHan
    @pMa_cty = '001',
    @pNam = 2026,
    @pSoNgayBaoTruoc = 10

-- Kết quả trả về:
-- Số CT | Ngày CT | Tên khách | Hạn TT | Ngày đến hạn | Phải thu | Đã thu | Còn phải thu
```

### 8. Lấy Tham Số Procedure
```sql
-- Lấy danh sách tham số của procedure
EXEC asDashGetParameter
    @pSp_name = 'asDashGLKetQuaKinhDoanh'

-- Kết quả trả về:
-- PARAMETER_NAME | DATA_TYPE | DESCRIPTION
```

---

## Integration Points

### 1. General Ledger (GL)
- Lấy dữ liệu kết quả kinh doanh từ GLCT
- Lấy ngân sách từ GLBudget
- Tài khoản doanh thu, giá vốn, chi phí

### 2. Sales Order (SO)
- Lấy doanh số bán hàng từ SOCT
- Theo dõi hóa đơn, thanh toán

### 3. Inventory (IN)
- Lấy tồn kho từ INCT
- Danh mục vật tư từ INdmvt

### 4. Accounts Receivable (AR)
- Lấy công nợ khách hàng từ ARTT
- Thanh toán hóa đơn

### 5. Costing (CO)
- Thành phẩm nhập kho từ COdmspct

---

## Validation Rules

### 1. Period Validation
```
Nam > 2000
Thang IN (1, 2, ..., 12)
```

### 2. TOP Validation
```
@pTOP >= 0 (0 = lấy tất cả)
```

### 3. Flag Validation
```
@pHien_KT IN ('0', '1')
@pHien_LK IN ('0', '1')
@pTheo_kho IN ('1', '2')
```

---

## Performance Guidelines

### Indexing Strategy
```sql
-- Recommended indexes cho dashboard
CREATE INDEX IX_GLCT_Ma_cty_Thang_Nam_Tk ON GLCT(Ma_cty, Thang, Nam, Tk)
CREATE INDEX IX_SOCT_Ma_cty_Thang_Nam ON SOCT(Ma_cty, Thang, Nam)
CREATE INDEX IX_INCT_Ma_cty_Thang_Nam_Ma_vt ON INCT(Ma_cty, Thang, Nam, Ma_vt)
```

### Query Optimization
```sql
-- Sử dụng temp table để xử lý dữ liệu
CREATE TABLE #Kq (...)
INSERT #Kq SELECT ...
UPDATE #Kq SET ...
SELECT * FROM #Kq
DROP TABLE #Kq
```

---

## Security & Permissions

### Role-based Access
```
ROLE_DASH_ADMIN     - Full access
ROLE_DASH_VIEW      - Xem dashboard
ROLE_DASH_SALES     - Xem báo cáo bán hàng
ROLE_DASH_FINANCE   - Xem báo cáo tài chính
ROLE_DASH_INVENTORY - Xem báo cáo kho
```

---

## Related Documentation

### Modules
- [docs/modules/GL/README.md](../GL/README.md) - Tổng hợp
- [docs/modules/SO/README.md](../SO/README.md) - Bán hàng
- [docs/modules/IN/README.md](../IN/README.md) - Kho
- [docs/modules/AR/README.md](../AR/README.md) - Công nợ

### Core Docs
- [docs/DATA_DICTIONARY.md](../../DATA_DICTIONARY.md) - Định nghĩa cột

---

## Change History

| Date | Version | Change | Author |
|------|---------|--------|--------|
| 2026-03-12 | 1.0 | Initial documentation | Bột |

---

*Last updated: 2026-03-12*


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
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [IN](../IN/) | Inventory - Kho hàng |
| [AR](../AR/) | Accounts Receivable - Công nợ phải thu |
| [CO](../CO/) | Manufacturing - Sản xuất |

---

# End of Dash Module Documentation
