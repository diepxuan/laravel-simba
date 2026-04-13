# Tables Index - ASIA ERP

Tài liệu này liệt kê các bảng (tables) được sử dụng trong ASIA ERP.

## Quy ước Đặt Tên

| Prefix | Ý nghĩa | Ví dụ |
|--------|---------|-------|
| `dmdb` | Danh mục đối tượng | dmdbCustomer |
| `dmct` | Danh mục chi tiết | dmctVoucherType |
| `ct` | Chi tiết chứng từ | ctGLVoucher |
| `ph` | Phiếu/Header chứng từ | phSOOrder |
| `cd` | Số dư đầu kỳ | cdGLAccount |
| `gl` | General Ledger | glCt1, glPh1 |

## Danh Sách Tables Theo Module

### GL (General Ledger)

| Table | Mô tả | Loại |
|-------|-------|------|
| GlPh1 | Phiếu kế toán header | ph |
| GlCt1 | Chi tiết phiếu kế toán | ct |
| GlCt | Chi tiết phiếu kế toán (mở rộng) | ct |
| GlDmTk | Danh mục tài khoản | dm |
| GlDmKc | Danh mục bút toán kết chuyển | dm |
| GlCdTk | Số dư đầu kỳ tài khoản | cd |
| GlBudget | Ngân sách | dm |

### AP (Accounts Payable)

| Table | Mô tả | Loại |
|-------|-------|------|
| ApPh1 | Phiếu công nợ phải trả header | ph |
| ApCt1 | Chi tiết công nợ phải trả | ct |
| ApDmNcc | Danh mục nhà cung cấp | dm |
| ApDmBp | Danh mục bộ phận | dm |

### AR (Accounts Receivable)

| Table | Mô tả | Loại |
|-------|-------|------|
| ArPh1 | Phiếu công nợ phải thu header | ph |
| ArCt1 | Chi tiết công nợ phải thu | ct |
| ArDmKh | Danh mục khách hàng | dm |
| ArDmNhKh | Danh mục nhóm khách hàng | dm |
| ArDmPlKh | Danh mục phân loại khách hàng | dm |

### CA (Cash)

| Table | Mô tả | Loại |
|-------|-------|------|
| CaPh1 | Phiếu thu/chi header | ph |
| CaCt1 | Chi tiết thu/chi | ct |
| CaDmKu | Danh mục khế ước | dm |
| CaCdKu | Số dư đầu kỳ khế ước | cd |
| CaCdPc | Số dư đầu kỳ phiếu chi | cd |
| CaLaiKu | Lãi khế ước | ct |

### CO (Cost)

| Table | Mô tả | Loại |
|-------|-------|------|
| CoBom | Bill of Materials | dm |
| CoDd | Định mức | dm |
| CoCptp | Chi phí thành phẩm | ct |

### FA (Fixed Asset)

| Table | Mô tả | Loại |
|-------|-------|------|
| FaTscd | Tài sản cố định | dm |
| FaKhts | Khấu hao tài sản | ct |
| FaDmNhts | Danh mục nhóm TSCD | dm |
| FaDmCcdc | Danh mục CCDC | dm |

### IN (Inventory)

| Table | Mô tả | Loại |
|-------|-------|------|
| InPh1 | Phiếu nhập/xuất kho header | ph |
| InCt1 | Chi tiết nhập/xuất kho | ct |
| InDmVt | Danh mục vật tư | dm |
| InDmKho | Danh mục kho | dm |
| InCdVt | Số dư đầu kỳ vật tư | cd |

### PO (Purchase Order)

| Table | Mô tả | Loại |
|-------|-------|------|
| PoPh1 | Phiếu đặt hàng mua header | ph |
| PoCt1 | Chi tiết đặt hàng mua | ct |
| PoDmNcc | Danh mục nhà cung cấp | dm |

### SO (Sales Order)

| Table | Mô tả | Loại |
|-------|-------|------|
| SoPh1 | Phiếu đơn hàng bán header | ph |
| SoCt1 | Chi tiết đơn hàng bán | ct |
| SoDmGiaBan | Danh mục giá bán | dm |
| SoDmKm | Danh mục khuyến mãi | dm |

### SI (Sales Invoice)

| Table | Mô tả | Loại |
|-------|-------|------|
| SiPh1 | Phiếu hóa đơn bán header | ph |
| SiCt1 | Chi tiết hóa đơn bán | ct |

## Tables Hệ Thống (System)

| Table | Mô tả |
|-------|-------|
| SiDmTk | Danh mục tài khoản hệ thống |
| SiDmNv | Danh mục nhân viên |
| SiDmBp | Danh mục bộ phận |
| SiDmPhi | Danh mục phí |
| SiDmHd | Danh mục hợp đồng |
| SiDmSpct | Danh mục sản phẩm công trình |
| SiDmNt | Danh mục ngoại tệ |
| SiDmThue | Danh mục thuế |
| SiUser | Danh sách user |
| SiGroup | Danh sách nhóm user |
| SiRight | Phân quyền |

## Cấu Trúc Bảng Chuẩn

### Header Table (ph*)
```sql
CREATE TABLE [Module]Ph1 (
    ma_cty VARCHAR(10) NOT NULL,      -- Company ID
    ma_ct VARCHAR(3) NOT NULL,        -- Mã chứng từ
    stt_rec VARCHAR(20) NOT NULL,     -- Số thứ tự bản ghi
    so_ct VARCHAR(12),                -- Số chứng từ
    ngay_ct SMALLDATETIME,            -- Ngày chứng từ
    ngay_lct SMALLDATETIME,           -- Ngày lập chứng từ
    ma_nt VARCHAR(3),                 -- Mã ngoại tệ
    ty_gia DECIMAL(19,4),             -- Tỷ giá
    t_tien DECIMAL(19,4),             -- Tổng tiền VND
    t_tien_nt DECIMAL(19,4),          -- Tổng tiền ngoại tệ
    trang_thai VARCHAR(1),            -- Trạng thái
    cdate SMALLDATETIME,              -- Ngày tạo
    cuser VARCHAR(20),                -- User tạo
    ldate SMALLDATETIME,              -- Ngày sửa
    luser VARCHAR(20),                -- User sửa
    PRIMARY KEY (ma_cty, ma_ct, stt_rec)
);
```

### Detail Table (ct*)
```sql
CREATE TABLE [Module]Ct1 (
    ma_cty VARCHAR(10) NOT NULL,      -- Company ID
    ma_ct VARCHAR(3) NOT NULL,        -- Mã chứng từ
    stt_rec VARCHAR(20) NOT NULL,     -- Số thứ tự bản ghi
    stt_rec0 VARCHAR(3) NOT NULL,     -- Số thứ tự dòng
    tk VARCHAR(16),                   -- Tài khoản
    ma_kh VARCHAR(20),                -- Mã khách hàng
    ma_bp VARCHAR(20),                -- Mã bộ phận
    ma_phi VARCHAR(20),               -- Mã phí
    ma_hd VARCHAR(20),                -- Mã hợp đồng
    ma_spct VARCHAR(20),              -- Mã SPCT
    ps_no DECIMAL(19,4),              -- Phát sinh nợ VND
    ps_co DECIMAL(19,4),              -- Phát sinh có VND
    ps_no_nt DECIMAL(19,4),           -- Phát sinh nợ NT
    ps_co_nt DECIMAL(19,4),           -- Phát sinh có NT
    dien_giai NVARCHAR(128),          -- Diễn giải
    PRIMARY KEY (ma_cty, ma_ct, stt_rec, stt_rec0)
);
```

### Danh Mục Table (dm*)
```sql
CREATE TABLE [Module]Dm[Name] (
    ma_cty VARCHAR(10) NOT NULL,      -- Company ID
    ma_[name] VARCHAR(20) NOT NULL,   -- Mã
    ten_[name] NVARCHAR(128),         -- Tên
    ten_[name]2 NVARCHAR(128),        -- Tên 2 (tiếng Anh)
    trang_thai VARCHAR(1),            -- Trạng thái
    cdate SMALLDATETIME,              -- Ngày tạo
    cuser VARCHAR(20),                -- User tạo
    ldate SMALLDATETIME,              -- Ngày sửa
    luser VARCHAR(20),                -- User sửa
    PRIMARY KEY (ma_cty, ma_[name])
);
```

## Tổng Kết

| Loại | Số lượng |
|------|----------|
| Header (ph*) | ~10 |
| Detail (ct*) | ~10 |
| Danh mục (dm*) | ~30 |
| Số dư (cd*) | ~5 |
| Hệ thống (si*) | ~10 |
| **Tổng** | **~65** |
