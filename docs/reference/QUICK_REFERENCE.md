# Quick Reference

Tra cứu nhanh stored procedure theo nghiệp vụ.

---

## Cash & Banking (CA)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Tạo phiếu thu | `asCASaveReceipt` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_kh, @pSo_tien` |
| Tạo phiếu chi | `asCASavePayment` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_ncc, @pSo_tien` |
| Lấy số dư TM | `asCAGetBalance` | `@pMa_cty, @pMa_tk` |
| Post vào GL | `asCAPostReceipt` / `asCAPostPayment` | `@pMa_cty, @pStt_rec` |

---

## General Ledger (GL)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Lưu CT | `asGLSaveCt` | `@pMa_cty, @pSo_ct, @pTk_no, @pTk_co, @pSo_tien` |
| Lấy CT | `asGLGetCt` | `@pMa_cty, @pSo_ct` |
| Báo cáo sổ cái | `asGLRptNKC01` | `@pMa_cty, @pTk, @pFromDate, @pToDate` |
| Bảng CDSP | `asGLRptCDSFPS` | `@pMa_cty, @pMonth, @pYear` |
| Khóa sổ | `asGLClosePeriod` | `@pMa_cty, @pMonth, @pYear` |

---

## Accounts Receivable (AR)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Tạo HĐ bán | `asARSaveInvoice` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_kh, @pTong_tien` |
| Lấy công nợ | `asARGetTT` | `@pMa_cty, @pMa_kh` |
| Ghi nhận TT | `asARSavePayment` | `@pMa_cty, @pSo_ct, @pMa_kh, @pSo_tien` |
| Báo cáo công nợ | `asARRptBCCN01` | `@pMa_cty, @pMa_kh` |

---

## Accounts Payable (AP)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Tạo HĐ mua | `asAPSaveInvoice` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_ncc, @pTong_tien` |
| Lấy công nợ | `asAPGetTT` | `@pMa_cty, @pMa_ncc` |
| Ghi nhận TT | `asAPSavePayment` | `@pMa_cty, @pSo_ct, @pMa_ncc, @pSo_tien` |

---

## Purchase Order (PO)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Tạo PO | `asPOSaveOrder` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_ncc, @pTong_tien` |
| Lấy PO | `asPOGetPH3` | `@pMa_cty, @pSo_ct` |
| Duyệt PO | `asPOApprove` | `@pMa_cty, @pStt_rec` |
| Hủy PO | `asPOCancel` | `@pMa_cty, @pStt_rec` |
| Nhận hàng | `asPOSaveReceipt` | `@pMa_cty, @pMa_po, @pNgay_nhan` |

---

## Sales Order (SO)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Tạo SO | `asSOSaveOrder` | `@pMa_cty, @pSo_ct, @pNgay_ct, @pMa_kh, @pTong_tien` |
| Lấy SO | `asSOGetPH3` | `@pMa_cty, @pSo_ct` |
| Duyệt SO | `asSOApprove` | `@pMa_cty, @pStt_rec` |
| Hủy SO | `asSOCancel` | `@pMa_cty, @pStt_rec` |
| Giao hàng | `asSOSaveDelivery` | `@pMa_cty, @pMa_so, @pNgay_giao` |

---

## Inventory (IN)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Nhập kho | `asINInsPH1`, `asINInsCT1` | `@pMa_cty, @pStt_rec, @pMa_vt, @pSo_luong` |
| Xuất kho | `asINInsIssue` | `@pMa_cty, @pStt_rec, @pMa_vt, @pSo_luong` |
| Lấy tồn kho | `asINGetTonVtAll` | `@pMa_cty, @pMa_vt` |

---

## System (SI)

| Task | Stored Procedure | Parameters chính |
|------|------------------|------------------|
| Lấy STT rec | `asGetSttRec` | `@pMa_cty, @pTen_bang` |
| Lấy số CT | `asGetSoCt` | `@pMa_cty, @pMa_ct` |
| Kiểm tra quyền | `asGetRight` | `@pMa_cty, @pUserId, @pChuc_nang` |
| Kiểm tra tồn tại | `asCheckExists` | `@pMa_cty, @pTen_bang, @pCondition` |

---

## Common Parameters

| Parameter | Type | Mô tả | Ví dụ |
|-----------|------|-------|-------|
| `@pMa_cty` | `VARCHAR(3)` | Mã công ty | `'001'` |
| `@pSo_ct` | `VARCHAR(20)` | Số chứng từ | `'PT000001'` |
| `@pNgay_ct` | `DATETIME` | Ngày CT | `GETDATE()` |
| `@pStt_rec` | `INT` | Số thứ tự record | `> 0` |
| `@pRet` | `INT` | Return code | `0` = Success |

---

## Error Codes

| Code | Ý nghĩa |
|------|---------|
| `0` | Success |
| `-1` | Validation failed |
| `-2` | Duplicate found |
| `-3` | Not found |
| `-4` | Permission denied |
| `-5` | Business rule violation |
| `-10` | Database error |
| `-99` | Unknown error |

---

## Tham khảo

- Chi tiết code → SP: [CODE_REFERENCE.md](CODE_REFERENCE.md)
- Mapping Asia App: [ASIA_SIMBA_MAPPING.md](ASIA_SIMBA_MAPPING.md)
- File index: [FILE_INDEX.md](FILE_INDEX.md)
