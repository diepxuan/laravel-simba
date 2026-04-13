# Tax (Ta) - Thuế và Hóa đơn

Module quản lý thuế giá trị gia tăng (VAT), thuế nhập khẩu, thuế tiêu thụ đặc biệt và hóa đơn mua vào/bán ra.

---

## Tổng quan

**Purpose:** Quản lý hóa đơn mua vào, bán ra và các khoản thuế liên quan (VAT, thuế NK, thuế TTĐB).

**Key Functions:**
- Quản lý hóa đơn mua vào (TaIn)
- Quản lý hóa đơn bán ra (TaOut)
- Tính thuế GTGT đầu vào/đầu ra
- Tính thuế nhập khẩu
- Tính thuế tiêu thụ đặc biệt
- Theo dõi hóa đơn theo kỳ thuế
- Báo cáo thuế GTGT

---

## Database Tables

### Primary Tables
```
TaIn           - Hóa đơn mua vào (Input invoices)
TaOut          - Hóa đơn bán ra (Output invoices)
```

### Master Data
```
TaDmthue       - Danh mục thuế suất
TaSetup        - Tham số thiết lập phân hệ thuế
```

### Related Tables
```
INdmvt         - Danh mục vật tư
ARdmkh         - Danh mục khách hàng
APdmkh         - Danh mục nhà cung cấp
GLdmtk         - Danh mục tài khoản
```

---

## Stored Procedures

**Tổng số:** 6 procedures

### Categories

#### 1. Input Invoice Operations (Hóa đơn mua vào)
```
asTaInsIn           - Thêm hóa đơn mua vào
asTaUpdIn           - Cập nhật hóa đơn mua vào
asTaDelIn           - Xóa hóa đơn mua vào
```

#### 2. Output Invoice Operations (Hóa đơn bán ra)
```
asTaInsOut          - Thêm hóa đơn bán ra
asTaUpdOut          - Cập nhật hóa đơn bán ra
asTaDelOut          - Xóa hóa đơn bán ra
```

---

## Business Flows

### 1. Hóa Đơn Mua Vào (Input Invoice)
```
Nhận hóa đơn từ NCC
      ↓
1. asTaInsIn - Lưu hóa đơn mua vào
      ↓
2. Thông tin: So_seri_mhd, Ngay_ct0, So_ct0
      ↓
3. Tính thuế: Thue_nk, Thue_ttdb, T_thue
      ↓
4. Hạch toán: Tk_thue_no, Tk_du
      ↓
5. Link với PN (stt_rec_pn)
      ↓
6. Post to GL
```

### 2. Hóa Đơn Bán Ra (Output Invoice)
```
Xuất hóa đơn cho KH
      ↓
1. asTaInsOut - Lưu hóa đơn bán ra
      ↓
2. Thông tin: So_seri_mhd, So_ct, So_seri
      ↓
3. Tính tiền: T_tien, T_tien_nt
      ↓
4. Tính thuế: Thue_suat, T_thue, T_thue_nt
      ↓
5. Hạch toán: Tk_thue, Tk_du
      ↓
6. Link với SO (ma_hd)
      ↓
7. Post to GL
```

### 3. Kỳ Thuế (Tax Period)
```
Month End
      ↓
1. Tập hợp hóa đơn mua vào
      ↓
2. Tập hợp hóa đơn bán ra
      ↓
3. Tính thuế GTGT đầu vào
      ↓
4. Tính thuế GTGT đầu ra
      ↓
5. Xác định thuế phải nộp
      ↓
6. Báo cáo thuế GTGT
```

---

## Key Parameters

### Common Parameters
```sql
@pMa_cty       -- Mã công ty (Company ID)
@pStt_rec      -- Số record (Record ID)
@pStt_rec0     -- Số record con (Child record ID)
@pMa_ct        -- Mã chứng từ (Document type)
@pMa_bp        -- Mã bộ phận (Department ID)
@pNgay_ct      -- Ngày chứng từ (Document date)
@pSo_ct        -- Số chứng từ (Document number)
@pSo_seri      -- Số sê-ri (Serial number)
@pSo_seri_mhd  -- Số sê-ri máy hóa đơn
@pMa_kh        -- Mã khách hàng/NCC (Customer/Vendor ID)
@pTen_kh       -- Tên khách hàng/NCC
@pDia_chi      -- Địa chỉ
@pMa_so_thue   -- Mã số thuế
@pMa_vt        -- Mã vật tư (Item ID)
@pTen_vt       -- Tên vật tư
@pSo_luong     -- Số lượng
@pGia          -- Đơn giá
@pT_tien       -- Tổng tiền
@pT_tien_nt    -- Tổng tiền nguyên tệ
@pThue_suat    -- Thuế suất (%)
@pT_thue       -- Tiền thuế
@pT_thue_nt    -- Tiền thuế nguyên tệ
@pTk_thue      -- Tài khoản thuế
@pTk_du        -- Tài khoản đối ứng
@pUser         -- Người dùng
@pRet          -- Return code (output)
```

### Tax Fields
```sql
-- Thuế nhập khẩu
Thue_nk        -- Tiền thuế nhập khẩu

-- Thuế tiêu thụ đặc biệt
Thue_ttdb      -- Tiền thuế TTĐB

-- Thuế GTGT
Thue_suat      -- Thuế suất (%)
T_thue         -- Tiền thuế GTGT
T_thue_nt      -- Tiền thuế GTGT nguyên tệ

-- Tài khoản
Tk_thue_no     -- TK thuế bên nợ
Tk_thue        -- TK thuế
Tk_du          -- TK đối ứng
```

---

## Usage Examples

### 1. Thêm Hóa Đơn Mua Vào
```sql
-- Thêm hóa đơn mua vào
EXEC asTaInsIn
    @pMa_cty = '001',
    @pStt_rec = 'HDN2026001',
    @pStt_rec_pn = 'PN2026001',
    @pStt_rec0 = '001',
    @pMa_ct = 'HDN',
    @pMa_bp = 'BP001',
    @pNgay_ct = '2026-03-12',
    @pSo_ct = 'HDN-001',
    @pSo_seri_mhd = 'AA/2026P',
    @pNgay_ct0 = '2026-03-12',
    @pSo_ct0 = '001',
    @pSo_seri0 = 'AA/2026P',
    @pMau_bc = '1',
    @pMa_kh = 'VENDOR001',
    @pTen_kh = 'Cong ty ABC',
    @pDia_chi = 'Ha Noi',
    @pMa_so_thue = '0123456789',
    @pMa_vt = 'VT001',
    @pTen_vt = 'Nguyen lieu A',
    @pSo_luong = 100,
    @pGia = 10000,
    @pTien_hang = 1000000,
    @pThue_nk = 0,
    @pThue_ttdb = 0,
    @pT_tien = 1100000,
    @pThue_suat = 10,
    @pT_thue = 100000,
    @pTk_thue_no = '1331',
    @pTk_du = '3311',
    @pGhi_chu = 'Hoa don mua vao',
    @pMa_spct = '',
    @pMa_lo = '',
    @pUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 2. Cập Nhật Hóa Đơn Mua Vào
```sql
-- Cập nhật hóa đơn mua vào
EXEC asTaUpdIn
    @pMa_cty = '001',
    @pStt_rec = 'HDN2026001',
    @pStt_rec_pn = 'PN2026001',
    @pStt_rec0 = '001',
    @pMa_ct = 'HDN',
    @pMa_bp = 'BP001',
    @pNgay_ct = '2026-03-12',
    @pSo_ct = 'HDN-001',
    @pSo_seri_mhd = 'AA/2026P',
    @pNgay_ct0 = '2026-03-12',
    @pSo_ct0 = '001',
    @pSo_seri0 = 'AA/2026P',
    @pMau_bc = '1',
    @pMa_kh = 'VENDOR001',
    @pTen_kh = 'Cong ty ABC',
    @pDia_chi = 'Ha Noi',
    @pMa_so_thue = '0123456789',
    @pMa_vt = 'VT001',
    @pTen_vt = 'Nguyen lieu A',
    @pSo_luong = 100,
    @pGia = 10000,
    @pTien_hang = 1000000,
    @pThue_nk = 0,
    @pThue_ttdb = 0,
    @pT_tien = 1100000,
    @pThue_suat = 10,
    @pT_thue = 100000,
    @pTk_thue_no = '1331',
    @pTk_du = '3311',
    @pGhi_chu = 'Hoa don mua vao',
    @pMa_spct = '',
    @pMa_lo = '',
    @pUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 3. Xóa Hóa Đơn Mua Vào
```sql
-- Xóa hóa đơn mua vào
DECLARE @ret INT
EXEC asTaDelIn
    @pMa_cty = '001',
    @pStt_rec = 'HDN2026001',
    @pStt_rec0 = '001'
```

### 4. Thêm Hóa Đơn Bán Ra
```sql
-- Thêm hóa đơn bán ra
EXEC asTaInsOut
    @pMa_cty = '001',
    @pStt_rec = 'HDX2026001',
    @pStt_rec0 = '001',
    @pMa_ct = 'HDX',
    @pNgay_ct = '2026-03-12',
    @pThang = 3,
    @pNam = 2026,
    @pSo_seri_mhd = 'AA/2026P',
    @pNgay_lct = '2026-03-12',
    @pSo_ct = 'HDX-001',
    @pSo_seri = 'AA/2026P',
    @pTen_kh = 'Khach hang XYZ',
    @pDia_chi = 'HCMC',
    @pMa_so_thue = '9876543210',
    @pMa_vt = 'TP001',
    @pTen_vt = 'Thanh pham A',
    @pSo_luong = 50,
    @pGia = 20000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pT_tien = 1100000,
    @pT_tien_nt = 1100000,
    @pMa_thue = 'VAT10',
    @pThue_suat = 10,
    @pT_thue = 100000,
    @pT_thue_nt = 100000,
    @pTk_thue = '3331',
    @pTk_du = '5111',
    @pMa_spct = '',
    @pMa_lo = '',
    @pMa_bp = 'BP001',
    @pMa_hd = 'SO2026001',
    @pGhi_chu = 'Hoa don ban ra',
    @pMa_kh = 'CUST001',
    @pUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 5. Cập Nhật Hóa Đơn Bán Ra
```sql
-- Cập nhật hóa đơn bán ra
EXEC asTaUpdOut
    @pMa_cty = '001',
    @pStt_rec = 'HDX2026001',
    @pStt_rec0 = '001',
    @pMa_ct = 'HDX',
    @pNgay_ct = '2026-03-12',
    @pThang = 3,
    @pNam = 2026,
    @pSo_seri_mhd = 'AA/2026P',
    @pNgay_lct = '2026-03-12',
    @pSo_ct = 'HDX-001',
    @pSo_seri = 'AA/2026P',
    @pTen_kh = 'Khach hang XYZ',
    @pDia_chi = 'HCMC',
    @pMa_so_thue = '9876543210',
    @pMa_vt = 'TP001',
    @pTen_vt = 'Thanh pham A',
    @pSo_luong = 50,
    @pGia = 20000,
    @pMa_nt = 'VND',
    @pTy_gia = 1,
    @pT_tien = 1100000,
    @pT_tien_nt = 1100000,
    @pMa_thue = 'VAT10',
    @pThue_suat = 10,
    @pT_thue = 100000,
    @pT_thue_nt = 100000,
    @pTk_thue = '3331',
    @pTk_du = '5111',
    @pMa_spct = '',
    @pMa_lo = '',
    @pMa_bp = 'BP001',
    @pMa_hd = 'SO2026001',
    @pGhi_chu = 'Hoa don ban ra',
    @pMa_kh = 'CUST001',
    @pUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 6. Xóa Hóa Đơn Bán Ra
```sql
-- Xóa hóa đơn bán ra
DECLARE @ret INT
EXEC asTaDelOut
    @pMa_cty = '001',
    @pStt_rec = 'HDX2026001',
    @pStt_rec0 = '001',
    @pRet = @ret OUTPUT
```

---

## Integration Points

### 1. Inventory (IN)
- Link hóa đơn mua vào với phiếu nhập (stt_rec_pn)
- Link hóa đơn bán ra với phiếu xuất
- Vật tư từ INdmvt

### 2. Sales Order (SO)
- Link hóa đơn bán ra với đơn hàng (ma_hd)
- Khách hàng từ ARdmkh

### 3. Purchase Order (PO)
- Link hóa đơn mua vào với nhà cung cấp
- Nhà cung cấp từ APdmkh

### 4. General Ledger (GL)
- Post thuế GTGT vào TK 133, 333
- Post doanh thu vào TK 511
- Post phải trả/phải thu

### 5. Accounts Receivable (AR)
- Theo dõi công nợ từ hóa đơn bán ra

### 6. Accounts Payable (AP)
- Theo dõi công nợ từ hóa đơn mua vào

---

## Validation Rules

### 1. Amount Validation
```
So_luong >= 0
Gia >= 0
T_tien >= 0
T_thue >= 0
Thue_suat >= 0
```

### 2. Date Validation
```
Ngay_ct <= Ngay_lct
Ngay_ct0 <= Ngay_ct (hóa đơn mua vào)
```

### 3. Tax Validation
```
T_thue = T_tien * Thue_suat / 100
T_tien = Tien_hang + Thue_nk + Thue_ttdb + T_thue
```

### 4. Currency Validation
```
IF Ma_nt = 'VND' THEN Ty_gia = 1
T_tien_nt = T_tien / Ty_gia
T_thue_nt = T_thue / Ty_gia
```

---

## Error Handling

### Common Errors
```
Error 0    - Thành công
Error 1    - Lỗi chung
Error > 0  - Không xóa được (tồn tại liên kết)
```

### Error Handling Pattern
```sql
BEGIN TRY
    EXEC asTaInsOut ...
    
    IF @pRet <> 0
    BEGIN
        RAISERROR('Failed to insert invoice', 16, 1)
        ROLLBACK
        RETURN
    END
    
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
    DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE()
    RAISERROR(@ErrMsg, 16, 1)
END CATCH
```

---

## Performance Guidelines

### Indexing Strategy
```sql
-- Recommended indexes
CREATE INDEX IX_TaIn_Ma_cty_Ngay_ct ON TaIn(Ma_cty, Ngay_ct)
CREATE INDEX IX_TaIn_Ma_kh ON TaIn(Ma_kh)
CREATE INDEX IX_TaIn_Stt_rec ON TaIn(Stt_rec)
CREATE INDEX IX_TaOut_Ma_cty_Ngay_ct ON TaOut(Ma_cty, Ngay_ct)
CREATE INDEX IX_TaOut_Ma_kh ON TaOut(Ma_kh)
CREATE INDEX IX_TaOut_Stt_rec ON TaOut(Stt_rec)
```

### Query Optimization
```sql
-- Lọc theo kỳ thuế
WHERE Ma_cty = @pMa_cty 
  AND Thang = @pThang 
  AND Nam = @pNam

-- Lọc theo khách hàng
WHERE Ma_kh LIKE @pMa_kh + '%'
```

---

## Security & Permissions

### Role-based Access
```
ROLE_TA_ADMIN     - Full access
ROLE_TA_CREATE    - Tạo hóa đơn
ROLE_TA_VIEW      - Xem hóa đơn
ROLE_TA_REPORT    - Báo cáo thuế
```

---

## Audit Trail

### Tracked Fields
```
Cuser       - Người tạo
Cdate       - Ngày tạo
Luser       - Người sửa cuối
Ldate       - Ngày sửa cuối
```

---

## Related Documentation

### Modules
- [docs/modules/GL/README.md](../GL/README.md) - Tổng hợp
- [docs/modules/IN/README.md](../IN/README.md) - Kho
- [docs/modules/SO/README.md](../SO/README.md) - Bán hàng
- [docs/modules/PO/README.md](../PO/README.md) - Mua hàng

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
| [IN](../IN/) | Inventory - Kho hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |

---

# End of Ta Module Documentation
