# AR Module - Accounts Receivable

Module quản lý công nợ phải thu (Accounts Receivable).

## Tổng quan

Module AR xử lý toàn bộ nghiệp vụ công nợ phải thu từ khách hàng:
- Ghi nhận công nợ từ hóa đơn bán hàng (SI) và các nghiệp vụ khác
- Theo dõi công nợ theo khách hàng, nhóm KH, phân loại KH
- Phân bổ thanh toán từ phiếu thu (CA) vào công nợ
- Báo cáo công nợ chi tiết và tổng hợp
- Tính lại số dư khách hàng khi cần

## Cấu trúc thư mục

- `vouchers/` - Chứng từ nghiệp vụ và báo cáo AR (19 files)
- `reports/` - Báo cáo AR (11 files, trùng với vouchers)

## Tables chính

| Table | Mô tả |
|-------|-------|
| ArPh1 | Phiếu công nợ phải thu header |
| ArCt1 | Chi tiết công nợ phải thu |
| ArDmKh | Danh mục khách hàng |
| ArDmNhKh | Danh mục nhóm khách hàng |
| ArDmPlKh | Danh mục phân loại khách hàng |

## Vouchers & Reports

### Chứng từ nghiệp vụ

| File | DLL | Mô tả |
|------|-----|-------|
| [ARVchAR4.md](vouchers/ARVchAR4.md) | ARVchAR4.dll | Chứng từ hạch toán công nợ (AR4) |
| [ARPost2TT.md](vouchers/ARPost2TT.md) | ARTT.dll | Phân bổ thanh toán vào công nợ |
| [ARRecalCustBalance.md](vouchers/ARRecalCustBalance.md) | - | Tính lại số dư khách hàng |
| [ARCDKH.md](vouchers/ARCDKH.md) | - | Công nợ đầu kỳ khách hàng |
| [ARTT.md](vouchers/ARTT.md) | - | Điều khoản thanh toán |

### Danh mục

| File | DLL | Mô tả |
|------|-----|-------|
| [ARDMKH.md](vouchers/ARDMKH.md) | - | Danh mục khách hàng |
| [ARDMNHKH.md](vouchers/ARDMNHKH.md) | ARDMNHKH.dll | Danh mục nhóm khách hàng |
| [ARDMPLKH.md](vouchers/ARDMPLKH.md) | ARDMPLKH.dll | Danh mục phân loại khách hàng |

### Báo cáo công nợ

| File | DLL | Mô tả |
|------|-----|-------|
| [ARRptBCCN01.md](reports/ARRptBCCN01.md) | ARRptBCCN01.dll | Báo cáo công nợ theo TK và KH |
| [ARRptBCCN01a.md](reports/ARRptBCCN01a.md) | ARRptBCCN01a.dll | Báo cáo công nợ Excel nâng cao |
| [ARRptBCCN02.md](reports/ARRptBCCN02.md) | ARRptBCCN02.dll | Báo cáo công nợ theo phân loại |
| [ARRptBCCN03.md](reports/ARRptBCCN03.md) | ARRptBCCN03.dll | Báo cáo công nợ tổng hợp phân loại |
| [ARRptBCCN04.md](reports/ARRptBCCN04.md) | ARRptBCCN04.dll | Báo cáo công nợ nhóm và chi tiết |
| [ARRptBCCN05.md](reports/ARRptBCCN05.md) | ARRptBCCN05.dll | Báo cáo đối chiếu công nợ |
| [ARRptBCCN06.md](reports/ARRptBCCN06.md) | ARRptBCCN06.dll | Báo cáo so sánh công nợ theo hạn kỳ |
| [ArRptF5BCCN01a.md](reports/ArRptF5BCCN01a.md) | ArRptF5BCCN01a.dll | Báo cáo F5 công nợ 01a (Drill-down) |

### Bảng kê

| File | DLL | Mô tả |
|------|-----|-------|
| [ARRptBK01.md](reports/ARRptBK01.md) | ARRptBK01.dll | Bảng kê chứng từ bán hàng |
| [ARRptBK02.md](reports/ARRptBK02.md) | ARRptBK02.dll | Bảng kê công nợ theo hạn |
| [ARRptBK03.md](reports/ARRptBK03.md) | ARRptBK03.dll | Bảng kê chứng từ thanh toán |

## Stored Procedures chính

| SP | Mô tả |
|----|-------|
| asARInsPH1 | Insert phiếu AR header |
| asARInsCt1 | Insert chi tiết AR |
| asARUpdPH1 | Update phiếu AR |
| asARDelPH1 | Delete phiếu AR |
| asARGetPH1 | Lấy phiếu AR |
| asARFilt1 | Filter danh sách AR |
| asARPost2TT | Post thanh toán AR |
| asARGetDMKH | Lấy danh mục KH |
| asARRecalCustBalance | Tính lại số dư KH |

## Luồng nghiệp vụ

```
SI (Hóa đơn) → AR (Ghi công nợ) → CA (Thu tiền) → ARPost2TT (Phân bổ) → GL (Sổ cái)
```

## Cross-module dependencies

| Module | Phụ thuộc | Mô tả |
|--------|-----------|-------|
| SI | → AR | Hóa đơn bán hàng tạo công nợ |
| CA | → AR | Phiếu thu phân bổ vào công nợ |
| GL | ← AR | Post công nợ lên sổ cái |
| SO | → AR | Đơn hàng ảnh hưởng công nợ |

## Thống kê

| Loại | Số lượng |
|------|----------|
| Chứng từ | 5 |
| Danh mục | 3 |
| Báo cáo | 8 |
| Bảng kê | 3 |
| **Tổng** | **19** |

---

*Last updated: 2026-05-05*
