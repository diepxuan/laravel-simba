# CA Module Summary - ASIA ERP

## Tổng quan Module CA (Cash & Bank)

Module CA quản lý tiền mặt và ngân hàng, bao gồm:
- Chứng từ thu/chi tiền mặt và chuyển khoản
- Chứng từ báo nợ/báo có ngân hàng (Ủy nhiệm chi)
- Quản lý khế ước vay (giải ngân, trả gốc, trả lãi)
- Tính lãi khế ước theo tháng
- Các báo cáo tiền mặt/ngân hàng và vay nợ

## Danh sách Components

### 1. Vouchers (5 files)

| DLL | Mã CT | Chức năng | Mô tả |
|-----|-------|-----------|-------|
| CAVchCA1 | CA1 | Thu tiền mặt/chuyển khoản | Phiếu thu từ khách hàng |
| CAVchCA2 | CA2 | Chi tiền mặt/chuyển khoản | Phiếu chi, có xử lý VAT |
| CAVchCA3 | CA3 | Báo nợ ngân hàng | UNC chi tiền qua NH |
| CAVchCA4 | CA4 | Báo có ngân hàng | UNC nhận tiền qua NH |
| CAVchCA5 | CA5 | Khế ước vay | CA51: Giải ngân, CA52: Trả gốc, CA53: Trả lãi |

### 2. Reports (7 files)

#### Báo cáo tiền mặt/ngân hàng
| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| CARptTMNH01 | Sổ chi tiết TM/NH | Sổ chi tiết phát sinh TK 111/112 |
| CARptTMNH02 | Sổ quỹ TM/NH | Sổ quỹ dạng tổng hợp |

#### Báo cáo vay theo khế ước
| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| CARptTMNH03 | Sổ chi tiết vay theo KU | Chi tiết vay theo từng khế ước |
| CARptTMNH04 | Tổng hợp theo NV/Nhóm KH | Báo cáo quản lý theo nhân viên |
| CARptTMNH05 | Tình hình vay nợ theo KU | Chi tiết một khế ước cụ thể |
| CARptTMNH06 | Sổ chi tiết vay (Crystal) | Báo cáo Crystal Report |
| CARptTMNH07 | Tổng hợp vay nợ | Tổng hợp theo TK và KU |

### 3. Masters (6 files)

#### Danh mục
| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| CADMKU | Danh mục khế ước | Quản lý thông tin khế ước vay |
| CALAIKU | Lãi khế ước | Quản lý lãi theo tháng |

#### Số dư đầu kỳ
| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| CACDKU | Số dư đầu kỳ KU | Số dư đầu kỳ khế ước vay |
| CACDPC | Số dư đầu kỳ PC | Số dư đầu kỳ phiếu chi phân cấp |

#### Tính toán
| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| CACalLaiKu | Tính lãi KU | Tính lãi khế ước theo tháng |
| CADelLaiKu | Xóa lãi KU | Xóa lãi đã tính để tính lại |

## Stored Procedures chính

### Vouchers
| SP Prefix | DLL sử dụng | Mô tả |
|-----------|-------------|-------|
| SP_CA1_* | CAVchCA1 | CRUD chứng từ thu tiền |
| SP_CA2_* | CAVchCA2 | CRUD chứng từ chi tiền |
| SP_CA3_* | CAVchCA3 | CRUD báo nợ NH |
| SP_CA4_* | CAVchCA4 | CRUD báo có NH |
| SP_CA5_* | CAVchCA5 | CRUD khế ước vay |

### Reports
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| SP_CARptTMNH01 | CARptTMNH01 | Sổ chi tiết TM/NH |
| SP_CARptTMNH02 | CARptTMNH02 | Sổ quỹ TM/NH |
| SP_CARptTMNH03 | CARptTMNH03 | Sổ chi tiết vay theo KU |
| SP_CARptTMNH04 | CARptTMNH04 | Tổng hợp theo NV/Nhóm KH |
| SP_CARptTMNH05 | CARptTMNH05 | Tình hình vay nợ theo KU |
| SP_CARptTMNH06 | CARptTMNH06 | Sổ chi tiết vay (Crystal) |
| SP_CARptTMNH07 | CARptTMNH07 | Tổng hợp vay nợ |

### Masters
| SP Prefix | DLL sử dụng | Mô tả |
|-----------|-------------|-------|
| SP_CACDKU_* | CACDKU | CRUD số dư đầu kỳ KU |
| SP_CACDPC_* | CACDPC | CRUD số dư đầu kỳ PC |
| SP_CADMKU_* | CADMKU | CRUD danh mục khế ước |
| SP_CALAIKU_* | CALAIKU | CRUD lãi khế ước |
| SP_CACALKU | CACalLaiKu | Tính lãi khế ước |
| SP_CADELLAIKU | CADelLaiKu | Xóa lãi khế ước |

## Tables liên quan

### Voucher tables
| Table | Mô tả |
|-------|-------|
| CA1PH, CA1CT | Thu tiền mặt/chuyển khoản - Header/Detail |
| CA2PH, CA2CT, CA2TAIN | Chi tiền - Header/Detail/Thuế |
| CA3PH, CA3CT | Báo nợ NH - Header/Detail |
| CA4PH, CA4CT, CA4TAIN | Báo có NH - Header/Detail/Thuế |
| CA5PH, CA5CT, CA5TAIN | Khế ước - Header/Detail/Thuế |

### Master tables
| Table | Mô tả |
|-------|-------|
| DMKU | Danh mục khế ước vay |
| CALAIKU | Lãi khế ước theo tháng |
| CADKU | Số dư đầu kỳ khế ước |
| CADPC | Số dư đầu kỳ phiếu chi phân cấp |

### Danh mục liên quan
| Table | Mô tả |
|-------|-------|
| dmkh | Danh mục khách hàng |
| dmtk | Danh mục tài khoản |
| dmnt | Danh mục ngoại tệ |
| dmbp | Danh mục bộ phận |
| dmphi | Danh mục phí |
| dmhd | Danh mục hợp đồng |
| dmspct | Danh mục sản phẩm công trình |

## Cross-module interactions

```
SO (Đơn hàng) → SI (Hóa đơn) → AR (Công nợ) → CA (Thu/Chi) → GL (Sổ cái)
                                    ↓
                              DMKU (Khế ước) → CALAIKU (Lãi)
```

- CA1/CA2/CA3/CA4/CA5 post sang module GL qua sp_post2gl
- CA1/CA2 liên kết với module AR (khách hàng)
- CA5 liên kết với DMKU (khế ước vay)
- CACalLaiKu tính lãi từ DMKU, lưu vào CALAIKU
- ARPost2TT phân bổ thanh toán từ CA1 cho hóa đơn AR

## Business logic patterns

### 1. Voucher Pattern (CA1/CA2/CA3/CA4/CA5)
- Header: Ngày CT, Ngoại tệ, Tỷ giá, Tổng tiền
- Detail: Grid với TK, Mã KH, Ps nợ/có NT, Ps nợ/có VND
- Tính tiền VND = Tiền NT × Tỷ giá
- Validate: Tổng Ps nợ = Tổng Ps có

### 2. Interest Calculation Pattern (CACalLaiKu)
- Input: Tháng, Năm, Mã khế ước
- Lấy thông tin KU từ DMKU (số tiền, lãi suất, phương pháp tính)
- Tính lãi theo phương pháp đã chọn
- Lưu kết quả vào CALAIKU

### 3. Loan Management Pattern (CA5 + DMKU)
- DMKU: Quản lý thông tin khế ước (số tiền, lãi suất, kỳ hạn)
- CA51: Giải ngân (ghi nhận tiền vay thực tế)
- CA52: Trả gốc (giảm dư nợ gốc)
- CA53: Trả lãi (ghi nhận chi phí lãi)
- CALAIKU: Theo dõi lãi phải trả theo tháng

### 4. Opening Balance Pattern (CACDKU/CACDPC)
- CACDKU: Số dư đầu kỳ khế ước (đã vay, đã trả)
- CACDPC: Số dư đầu kỳ phiếu chi phân cấp
- Tính số dư = Tiền vay/PC - Đã thanh toán
- Tự động check "Tất toán" khi số dư <= 0

## Tổng kết

- **Tổng số DLL**: 18
- **Tổng số Vouchers**: 5 (CA1-CA5)
- **Tổng số Reports**: 7 (TMNH01-07)
- **Tổng số Masters**: 6 (2 danh mục, 2 số dư, 2 tính toán)
- **Tổng số SP**: ~40
- **Tổng số Tables**: ~15

## Phân loại theo nghiệp vụ

### Thu/Chi tiền
- CA1: Thu tiền
- CA2: Chi tiền

### Ngân hàng
- CA3: Báo nợ NH (chi)
- CA4: Báo có NH (thu)

### Vay nợ
- CA5: Khế ước vay (giải ngân/trả gốc/trả lãi)
- DMKU: Danh mục khế ước
- CALAIKU: Lãi khế ước
- CACalLaiKu: Tính lãi
- CADelLaiKu: Xóa lãi

### Số dư đầu kỳ
- CACDKU: Số dư khế ước
- CACDPC: Số dư phiếu chi

### Báo cáo
- TMNH01-02: Sổ TM/NH
- TMNH03-07: Báo cáo vay nợ
