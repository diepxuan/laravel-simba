# Nhóm Cost Accounting (asCA*) - Procedures

Nhóm stored procedures liên quan đến Kế toán chi phí (Cost Accounting) trong hệ thống Simba ERP.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asCACalLaiKU | `AsCACalLaiKU` | `pMa_cty` (string), `pThang` (int), `pNam` (int), `pMa_ct` (string, default 'CA6'), `pMa_ku` (string, default ''), `pUser` (string, default ''), `pRet` (int, output) | Tính lãi khế ước trong kỳ. |
| asCADelCDKU | `AsCADelCDKU` | `pMa_cty` (string), `pNam` (int), `pMa_ku` (string), `pRet` (int, output) | Xóa chi tiết khế ước theo mã công ty, năm, mã khế ước. |
| asCADelCT1 | `AsCADelCT1` | `pMa_cty` (string), `pStt_rec` (string), `pRet` (int, output) | Xóa bản ghi trong bảng CACT1 theo mã công ty và số thứ tự record. |
| asCADelCT2 | `AsCADelCT2` | `pMa_cty` (string), `pStt_rec` (string), `pRet` (int, output) | Xóa bản ghi trong bảng CACT2 theo mã công ty và số thứ tự record. |
| asCADelCT3 | `AsCADelCT3` | `pMa_cty` (string), `pStt_rec` (string), `pRet` (int, output) | Xóa bản ghi trong bảng CACT3 theo mã công ty và số thứ tự record. |
| asCADelDMKU | `AsCADelDMKU` | `pMa_cty` (string), `pMa_ku` (string), `pRet` (int, output) | Xóa danh mục khế ước, kiểm tra ràng buộc trước khi xóa. |
| asCADelLaiKU | `AsCADelLaiKU` | `pMa_cty` (string), `pThang` (int), `pNam` (int), `pMa_ku` (string), `pRet` (int, output) | Xóa bản ghi lãi khế ước theo mã công ty, tháng, năm và mã khế ước (pattern). |

## Tổng quan

- **Prefix**: `asCA*`
- **Số lượng procedures ước tính**: 53 (theo thống kê file SQL).
- **Số lượng đã chuyển đổi**: 7 (cập nhật 2026-02-11).

## Ghi chú

- Nhóm Cost Accounting quản lý các khế ước vay, tính lãi, phân bổ chi phí.
- Các procedures thường thao tác với các bảng: `cadmku` (danh mục khế ước), `cacdku` (chi tiết khế ước), `calaiku` (lãi khế ước), `glct` (chi tiết general ledger).
- Một số procedures có sử dụng cursor để duyệt từng khế ước, cần lưu ý hiệu năng.