# CA Module - Cash & Bank

Module quản lý tiền mặt và ngân hàng (Cash & Bank).

## Cấu trúc thư mục

- `vouchers/` - Chứng từ nghiệp vụ CA
- `reports/` - Báo cáo CA
- `masters/` - Danh mục và dữ liệu nền tảng

## Vouchers

| File | Mã CT | Mô tả |
|------|-------|-------|
| [CAVchCA1.md](vouchers/CAVchCA1.md) | CA1 | Chứng từ thu tiền mặt/chuyển khoản |
| [CAVchCA2.md](vouchers/CAVchCA2.md) | CA2 | Chứng từ chi tiền mặt/chuyển khoản (PC) |
| [CAVchCA3.md](vouchers/CAVchCA3.md) | CA3 | Voucher báo nợ ngân hàng (UNC) |
| [CAVchCA4.md](vouchers/CAVchCA4.md) | CA4 | Voucher báo có/Ủy nhiệm chi |
| [CAVchCA5.md](vouchers/CAVchCA5.md) | CA5 | Voucher khế ước vay (CA51/CA52/CA53) |

## Reports

### Báo cáo tiền mặt/ngân hàng

| File | Mô tả |
|------|-------|
| [CARptTMNH01.md](reports/CARptTMNH01.md) | Báo cáo sổ chi tiết tiền mặt/ngân hàng |
| [CARptTMNH02.md](reports/CARptTMNH02.md) | Báo cáo sổ quỹ tiền mặt/ngân hàng |

### Báo cáo vay theo khế ước

| File | Mô tả |
|------|-------|
| [CARptTMNH03.md](reports/CARptTMNH03.md) | Báo cáo sổ chi tiết vay theo khế ước |
| [CARptTMNH04.md](reports/CARptTMNH04.md) | Báo cáo tổng hợp TM/NH theo nhân viên/nhóm KH |
| [CARptTMNH05.md](reports/CARptTMNH05.md) | Báo cáo tình hình vay nợ theo khế ước |
| [CARptTMNH06.md](reports/CARptTMNH06.md) | Báo cáo sổ chi tiết vay (Crystal Report) |
| [CARptTMNH07.md](reports/CARptTMNH07.md) | Báo cáo tổng hợp vay nợ theo TK và KU |

## Masters

### Danh mục

| File | Mô tả |
|------|-------|
| [CADMKU.md](masters/CADMKU.md) | Danh mục khế ước vay |
| [CALAIKU.md](masters/CALAIKU.md) | Lãi khế ước theo tháng |

### Số dư đầu kỳ

| File | Mô tả |
|------|-------|
| [CACDKU.md](masters/CACDKU.md) | Số dư đầu kỳ khế ước vay |
| [CACDPC.md](masters/CACDPC.md) | Số dư đầu kỳ phiếu chi phân cấp |

### Tính toán

| File | Mô tả |
|------|-------|
| [CACalLaiKu.md](masters/CACalLaiKu.md) | Tính lãi khế ước theo tháng |
| [CADelLaiKu.md](masters/CADelLaiKu.md) | Xóa lãi khế ước đã tính |

## Tổng quan chức năng

### Vouchers (5 loại)

1. **CA1 - Thu tiền**: Phiếu thu tiền mặt/chuyển khoản từ khách hàng
2. **CA2 - Chi tiền**: Phiếu chi tiền mặt/chuyển khoản, có xử lý thuế VAT
3. **CA3 - Báo nợ NH**: Ủy nhiệm chi/ngân hàng (chỉ ngân hàng)
4. **CA4 - Báo có NH**: Ủy nhiệm chi nhận tiền, có form in chuẩn
5. **CA5 - Khế ước**: Giải ngân/trả gốc/trả lãi vay

### Reports (7 loại)

- 2 báo cáo sổ TM/NH cơ bản (sổ chi tiết, sổ quỹ)
- 5 báo cáo vay theo khế ước (chi tiết, tổng hợp, Crystal)

### Masters (6 loại)

- 2 danh mục nền tảng (DMKU, CALAIKU)
- 2 form số dư đầu kỳ (CADKU, CADPC)
- 2 form tính toán (Tính lãi, Xóa lãi)

## Tables chính

### Voucher tables
| Table | Mô tả |
|-------|-------|
| CA1PH, CA1CT | Thu tiền mặt/chuyển khoản |
| CA2PH, CA2CT, CA2TAIN | Chi tiền mặt/chuyển khoản |
| CA3PH, CA3CT | Báo nợ ngân hàng |
| CA4PH, CA4CT, CA4TAIN | Báo có/Ủy nhiệm chi |
| CA5PH, CA5CT, CA5TAIN | Khế ước vay |

### Master tables
| Table | Mô tả |
|-------|-------|
| DMKU | Danh mục khế ước |
| CALAIKU | Lãi khế ước theo tháng |
| CADKU | Số dư đầu kỳ khế ước |
| CADPC | Số dư đầu kỳ phiếu chi |

## Cross-module interactions

```
CA (Cash & Bank) ↔ AR (Accounts Receivable)
    ↓
GL (General Ledger)
    ↓
CA ↔ DMKU (Khế ước) ↔ CALAIKU (Lãi KU)
```

- CA1/CA2/CA3/CA4 post sang GL qua sp_post2gl
- CA5 liên kết với DMKU (danh mục khế ước)
- CACalLaiKu tính lãi từ DMKU và lưu vào CALAIKU
- ARPost2TT phân bổ thanh toán từ CA cho hóa đơn AR
