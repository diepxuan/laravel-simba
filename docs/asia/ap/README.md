# AP Module - Accounts Payable

Module quản lý công nợ phải trả (Accounts Payable).

## Tổng quan

Module AP xử lý toàn bộ nghiệp vụ công nợ phải trả cho nhà cung cấp:
- Ghi nhận công nợ từ hóa đơn mua hàng và các nghiệp vụ khác
- Theo dõi công nợ theo nhà cung cấp
- Phân bổ thanh toán từ phiếu chi (CA) vào công nợ
- Báo cáo công nợ và bảng kê

## Cấu trúc thư mục

- `vouchers/` - Chứng từ nghiệp vụ AP
- `reports/` - Báo cáo AP (trùng với vouchers/)
- `masters/` - Danh mục (trùng với vouchers/)

## Tables chính

| Table | Mô tả |
|-------|-------|
| ApPh1 | Phiếu công nợ phải trả header |
| ApCt1 | Chi tiết công nợ phải trả |
| ApDmNcc | Danh mục nhà cung cấp |
| ApDmBp | Danh mục bộ phận |

## Vouchers & Reports

### Chứng từ nghiệp vụ

| File | DLL | Mô tả |
|------|-----|-------|
| [ApVchAP4.md](vouchers/ApVchAP4.md) | ApVchAP4.dll | Chứng từ bù trừ công nợ phải trả |
| [APPost2TT.md](vouchers/APPost2TT.md) | APTT.dll | Phân bổ thanh toán công nợ phải trả |
| [APTT.md](vouchers/APTT.md) | - | Danh mục điều khoản thanh toán mua hàng |

### Bảng kê

| File | DLL | Mô tả |
|------|-----|-------|
| [APRptBK01.md](reports/APRptBK01.md) | APRptBK01.dll | Bảng kê chứng từ mua hàng |
| [APRptBK02.md](reports/APRptBK02.md) | APRptBK02.dll | Bảng kê công nợ theo hạn thanh toán |
| [APRptBK03.md](reports/APRptBK03.md) | APRptBK03.dll | Bảng kê chứng từ thanh toán |

## Stored Procedures chính

| SP | Mô tả |
|----|-------|
| asAPInsPH1 | Insert phiếu AP header |
| asAPInsCt1 | Insert chi tiết AP |
| asAPUpdPH1 | Update phiếu AP |
| asAPDelPH1 | Delete phiếu AP |
| asAPGetPH1 | Lấy phiếu AP |
| asAPFilt1 | Filter danh sách AP |
| asAPPost2TT | Post thanh toán AP |
| asAPGetDMNCC | Lấy danh mục NCC |
| asAPGetDMBP | Lấy danh mục BP |

## Luồng nghiệp vụ

```
PO (Đơn mua) → IN (Nhập kho) → AP (Ghi công nợ) → CA (Chi tiền) → APPost2TT (Phân bổ) → GL (Sổ cái)
```

## Cross-module dependencies

| Module | Phụ thuộc | Mô tả |
|--------|-----------|-------|
| PO | → AP | Đơn mua tạo công nợ NCC |
| IN | → AP | Nhập kho ảnh hưởng công nợ |
| CA | → AP | Phiếu chi phân bổ vào công nợ |
| GL | ← AP | Post công nợ lên sổ cái |

## Thống kê

| Loại | Số lượng |
|------|----------|
| Chứng từ | 3 |
| Bảng kê | 3 |
| **Tổng** | **6** |

---

*Last updated: 2026-05-05*
