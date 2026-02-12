# Nhóm stored procedures IN (Inventory)

Tài liệu này liệt kê các stored procedure thuộc nhóm IN (Inventory) đã được chuyển đổi thành class PHP.

## Danh sách procedures

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asINChuyenTonKho | `AsInChuyenTonKho` | `pma_cty`, `pngay_cnt`, `pma_kho`, `pRet` (output) | Chuyển tồn kho sang năm sau |
| asINDelCDFIFO | `AsInDelCDFIFO` | `pMa_cty`, `pStt_rec_nt`, `pStt_rec0` | Xóa bản ghi trong bảng InCdFifo |
| asINDelCDVT | `AsInDelCDVT` | `pMa_cty`, `pNam`, `pMa_vt`, `pMa_kho`, `pMa_vitri`, `pMa_lo`, `pTk_vt`, `pMa_nt`, `pRet` (output) | Xóa bản ghi trong bảng INCDVT |
| asINDelCT1 | `AsInDelCT1` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng INCT1 |
| asINDelCT2 | `AsInDelCT2` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng INCT2 |
| asINDelCT6D | `AsInDelCT6D` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng INCT6D |
| asINDelCT6M | `AsInDelCT6M` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng INCT6M |
| asINDelCT9 | `AsInDelCT9` | `pMa_cty`, `pStt_rec`, `pStt_rec0`, `pRet` (output) | Xóa bản ghi trong bảng INCT9 |
| asINDelCt3 | `AsInDelCt3` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng InCt3 |
| asINDelCt5 | `AsInDelCt5` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa bản ghi trong bảng InCt5 |
| asINDelDMBOM | `AsInDelDMBOM` | `pMa_cty`, `pMa_vt`, `pMa_lk`, `pRet` (output) | Xóa bản ghi trong bảng INDMBOM |
| asINDelDMBarcode | `AsInDelDMBarcode` | `pMa_cty`, `pMa_vt`, `pMa_vach`, `pRet` (output) | Xóa bản ghi trong bảng INDMBARCODE |
| asINDelDMKHO | `AsInDelDMKHO` | `pMa_cty`, `pMa_kho`, `pRet` (output) | Xóa bản ghi trong bảng INDMKHO |
| asINDelDMLO | `AsInDelDMLO` | `pMa_cty`, `pMa_lo`, `pRet` (output) | Xóa bản ghi trong bảng INDMLO |
| asINDelDMNHVAT | `AsInDelDMNHVAT` | `pMa_cty`, `pMa_nhvat`, `pRet` (output) | Xóa bản ghi trong bảng INDMNHVAT |
| asINDelDMNHVT | `AsInDelDMNHVT` | `pMa_cty`, `pMa_nhvt`, `pRet` (output) | Xóa bản ghi trong bảng INDMNHVT |
| asINDelDMPLVT | `AsInDelDMPLVT` | `pMa_cty`, `pMa_plvt`, `pLoai`, `pRet` (output) | Xóa bản ghi trong bảng INDMPLVT |
| asINDelDMVITRI | `AsInDelDMVITRI` | `pMa_cty`, `pMa_kho`, `pMa_vitri`, `pRet` (output) | Xóa bản ghi trong bảng INDMVITRI |
| asINDelDMVT | `AsInDelDMVT` | `pMa_cty`, `pMa_vt`, `pRet` (output) | Xóa bản ghi trong bảng INDMVT và các bảng liên quan |
| asINDelPH1 | `AsInDelPH1` | `pMa_cty`, `pStt_rec`, `pLUser`, `pRet` (output) | Xóa phiếu nhập kho (INPH1) và các dữ liệu liên quan |
| asINGetPh5 | `AsINGetPh5` | `pMa_cty`, `pStt_rec`, `pMa_ct`, `pStruct` | Get INPH5 data |
| asSIInsDMCT | `AsInsDMCT` | `pMa_cty`, `pMa_ct`, `pPhan_he`, `pMa_ct_me`, `pTen_ct`, `pTk_no`, `pTk_co`, `pMa_nt`, `pSo_lien`, `pStt_nkc`, `pStt_ntxt`, `pCt_dc`, `pLoc_nsd`, `pVv`, `pSpct`, `pPhi`, `pBp`, `pLo`, `pSp_post`, `pSp_process`, `pPh`, `pSd`, `pNxt`, `pMenuid`, `pVn_prefix`, `pVn_sequence`, `pVn_pattern`, `pVn_width`, `pKieu_trung_so_ct`, `pRet` (output) | Thêm một loại chứng từ (danh mục chứng từ) trong module Sales & Inventory |
| asInsDictionaryInfo | `AsInsDictionaryInfo` | `pMa_cty`, `pTableName`, `pFieldName`, `pValue`, `pDescription`, `pRet` (output) | Thêm thông tin từ điển |

*Lưu ý: Danh sách này sẽ được cập nhật liên tục khi có thêm procedure mới được chuyển đổi.*

## Chi tiết từng procedure

### asINChuyenTonKho
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInChuyenTonKho`
- **Mô tả:** Chuyển tồn kho sang năm sau. Xóa dữ liệu tồn kho của năm tiếp theo và chèn dữ liệu tồn kho cuối năm trước.
- **Tham số:** Xem chi tiết trong class.

### asINDelCDFIFO
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCDFIFO`
- **Mô tả:** Xóa bản ghi trong bảng InCdFifo và gọi stored procedure asINPostCDFIFO2CDVT với chế độ DELETE.
- **Tham số:** Xem chi tiết trong class.

### asINDelCDVT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCDVT`
- **Mô tả:** Xóa bản ghi trong bảng INCDVT (tồn kho chi tiết) dựa trên các khóa chính.
- **Tham số:** Xem chi tiết trong class.

### asINDelCT1
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCT1`
- **Mô tả:** Xóa bản ghi trong bảng INCT1 (chi tiết phiếu nhập kho) dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCT2
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCT2`
- **Mô tả:** Xóa bản ghi trong bảng INCT2 (chi tiết phiếu xuất kho?) dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCT6D
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCT6D`
- **Mô tả:** Xóa bản ghi trong bảng INCT6D dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCT6M
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCT6M`
- **Mô tả:** Xóa bản ghi trong bảng INCT6M dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCT9
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCT9`
- **Mô tả:** Xóa bản ghi trong bảng INCT9 dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCt3
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCt3`
- **Mô tả:** Xóa bản ghi trong bảng InCt3 dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelCt5
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelCt5`
- **Mô tả:** Xóa bản ghi trong bảng InCt5 dựa trên mã công ty và số chứng từ.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMBOM
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMBOM`
- **Mô tả:** Xóa bản ghi trong bảng INDMBOM (danh mục BOM - Bill of Materials) dựa trên mã công ty, mã vật tư và mã liên kết.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMBarcode
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMBarcode`
- **Mô tả:** Xóa bản ghi trong bảng INDMBARCODE (danh mục mã vạch) dựa trên mã công ty, mã vật tư và mã vạch.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMKHO
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMKHO`
- **Mô tả:** Xóa bản ghi trong bảng INDMKHO (danh mục kho) dựa trên mã công ty và mã kho.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMLO
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMLO`
- **Mô tả:** Xóa bản ghi trong bảng INDMLO (danh mục lô) dựa trên mã công ty và mã lô. Kiểm tra tồn tại trước khi xóa.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMNHVAT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMNHVAT`
- **Mô tả:** Xóa bản ghi trong bảng INDMNHVAT (danh mục nhóm vật tư) dựa trên mã công ty và mã nhóm vật tư. Kiểm tra tồn tại trước khi xóa.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMNHVT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMNHVT`
- **Mô tả:** Xóa bản ghi trong bảng INDMNHVT (danh mục nhóm vật tư) dựa trên mã công ty và mã nhóm vật tư. Kiểm tra tồn tại trước khi xóa.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMPLVT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMPLVT`
- **Mô tả:** Xóa bản ghi trong bảng INDMPLVT (danh mục phân loại vật tư) dựa trên mã công ty, mã phân loại và loại. Kiểm tra tồn tại trước khi xóa.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMVITRI
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMVITRI`
- **Mô tả:** Xóa bản ghi trong bảng INDMVITRI (danh mục vị trí) dựa trên mã công ty, mã kho và mã vị trí. Kiểm tra tồn tại trước khi xóa.
- **Tham số:** Xem chi tiết trong class.

### asINDelDMVT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelDMVT`
- **Mô tả:** Xóa bản ghi trong bảng INDMVT (danh mục vật tư) và xóa các dữ liệu liên quan trong bảng CODMSPCT, INDMBOM, INDMBARCODE.
- **Tham số:** Xem chi tiết trong class.

### asINDelPH1
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInDelPH1`
- **Mô tả:** Xóa phiếu nhập kho (INPH1) và các dữ liệu liên quan trong bảng GLCT, INCT, INCT1. Ghi log xóa.
- **Tham số:** Xem chi tiết trong class.

### asINGetPh5
- **Class:** `Diepxuan\Simba\StoredProcedures\AsINGetPh5`
- **Mô tả:** Lấy dữ liệu INPH5.
- **Tham số:** Xem chi tiết trong class.

### asSIInsDMCT
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInsDMCT`
- **Mô tả:** Thêm một loại chứng từ (danh mục chứng từ) trong module Sales & Inventory.
- **Tham số:** Xem chi tiết trong class.

### asInsDictionaryInfo
- **Class:** `Diepxuan\Simba\StoredProcedures\AsInsDictionaryInfo`
- **Mô tả:** Thêm thông tin từ điển.
- **Tham số:** Xem chi tiết trong class.


## asINUpdDMBARCODE

- **Class:** AsINUpdDMBARCODE
- **Parameters:** pMa_cty, pMa_vt, pMa_vach, pKsd, pLUser
- **Description:** 
- **SQL File:** `asINUpdDMBARCODE.sql`

## asINInsPH6

- **Class:** AsINInsPH6
- **Parameters:** pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pNgay_ctn, pSo_ctn, pMa_kh, pNguoi_gd, pDien_giai, pPN_GTB, pPX_GDD, pTk_vt_lrtd, pTk_lrtd, pT_so_luong, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pPost2gl, pPost2in, pLUser
- **Description:** 
- **SQL File:** `asINInsPH6.sql`

## asInsRightgroupCompany

- **Class:** AsInsRightgroupCompany
- **Parameters:** pGroupName, pMa_cty, pActive
- **Description:** 
- **SQL File:** `asInsRightgroupCompany.sql`

## asINGetDMKHO

- **Class:** AsINGetDMKHO
- **Parameters:** 
- **Description:** 
- **SQL File:** `asINGetDMKHO.sql`

## asINInsPH1

- **Class:** AsINInsPH1
- **Parameters:** pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pMa_kh, pTen_kh, pDia_chi, pNguoi_gd, pDien_giai, pMa_nx, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pT_so_luong, pPN_GTB, pTrang_thai, pPost2gl, pPost2in, pGia_thanh, pLUser
- **Description:** 
- **SQL File:** `asINInsPH1.sql`

## asINGetDMBARCODE

- **Class:** AsINGetDMBARCODE
- **Parameters:** pMa_cty, pMa_vt
- **Description:** 
- **SQL File:** `asINGetDMBARCODE.sql`



