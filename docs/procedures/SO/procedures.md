# SO Procedures (Sales Order (Đơn hàng))

*Generated on 2026-03-19 14:55:40*

Tổng số procedures: **152**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 29 |
| Update | 18 |
| Delete | 31 |
| Get | 33 |
| Report | 38 |
| Process | 1 |
| Other | 2 |

## Insert Procedures

### asSOInsCT3

- **Class:** AsSOInsCT3
- **Description:** Stored procedure asSOInsCT3
- **SQL File:** `asSOInsCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_px` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_px` | NVARCHAR(3) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_px` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt2` | DECIMAL(19 | Yes |  |
| `pGia2` | DECIMAL(19 | Yes |  |
| `pTien_nt2` | DECIMAL(19 | Yes |  |
| `pTien2` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pTien_ck_nt` | DECIMAL(19 | Yes |  |
| `pTien_ck` | DECIMAL(19 | Yes |  |
| `pCk_ds` | DECIMAL(19 | Yes |  |
| `pCk_ds_nt` | DECIMAL(19 | Yes |  |
| `pMa_thue` | NVARCHAR(2) | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pTk_dt` | NVARCHAR(20) | Yes |  |
| `pTk_gv` | NVARCHAR(20) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_ck` | NVARCHAR(20) | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pKhuyen_mai` | BIT | Yes |  |
| `pTra_ck` | BIT | Yes |  |
| `pSl_xuat` | DECIMAL(19 | Yes |  |
| `pSl_xuat_qd` | DECIMAL(19 | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pMa_nvkd` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsCT4

- **Class:** AsSOInsCT4
- **Description:** Stored procedure asSOInsCT4
- **SQL File:** `asSOInsCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_px` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_px` | NVARCHAR(3) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_hd` | NVARCHAR(3) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_px` | NVARCHAR(12) | Yes |  |
| `pSo_hd` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt2` | DECIMAL(19 | Yes |  |
| `pGia2` | DECIMAL(19 | Yes |  |
| `pTien_nt2` | DECIMAL(19 | Yes |  |
| `pTien2` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pTien_ck_nt` | DECIMAL(19 | Yes |  |
| `pTien_ck` | DECIMAL(19 | Yes |  |
| `pCk_ds` | DECIMAL(19 | Yes |  |
| `pCk_ds_nt` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `ptk_tl` | NVARCHAR(20) | Yes |  |
| `pTk_gv` | NVARCHAR(20) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_ck` | NVARCHAR(20) | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pKhuyen_mai` | BIT | Yes |  |
| `pTra_ck` | BIT | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pMa_nvkd` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsCT5

- **Class:** AsSOInsCT5
- **Description:** Stored procedure asSOInsCT5
- **SQL File:** `asSOInsCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt2` | DECIMAL(19 | Yes |  |
| `pGia2` | DECIMAL(19 | Yes |  |
| `pTien_nt2` | DECIMAL(19 | Yes |  |
| `pTien2` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pTien_ck_nt` | DECIMAL(19 | Yes |  |
| `pTien_ck` | DECIMAL(19 | Yes |  |
| `pCk_ds` | DECIMAL(19 | Yes |  |
| `pCk_ds_nt` | DECIMAL(19 | Yes |  |
| `pMa_thue` | NVARCHAR(2) | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pTk_dt` | NVARCHAR(20) | Yes |  |
| `pTk_ck` | NVARCHAR(20) | Yes |  |
| `pKhuyen_mai` | NVARCHAR(1) | Yes |  |
| `pTra_ck` | NVARCHAR(1) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pMa_nvkd` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsCT6

- **Class:** AsSOInsCT6
- **Description:** Stored procedure asSOInsCT6
- **SQL File:** `asSOInsCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia2` | DECIMAL(19 | Yes |  |
| `pTien2` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pTien_ck` | DECIMAL(19 | Yes |  |
| `pMa_thue` | NVARCHAR(2) | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsCk

- **Class:** AsSOInsCk
- **Description:** :	Ins danh muc chiết khấu
- **SQL File:** `asSOInsCk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pVt_nhomvt` | nvarchar(1) | Yes |  |
| `pKh_nhomkh` | nvarchar(1) | Yes |  |
| `pSl_ds` | nvarchar(1) | Yes |  |
| `pTl_gt` | nvarchar(1) | Yes |  |
| `pTl_sl_ds` | nvarchar(1) | Yes |  |
| `pma_kyck` | nvarchar(1) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |
| `pGt0` | money | Yes |  |
| `pGt1` | money | Yes |  |
| `pCk1` | money | Yes |  |
| `pGt2` | money | Yes |  |
| `pCk2` | money | Yes |  |
| `pGt3` | money | Yes |  |
| `pCk3` | money | Yes |  |
| `pGt4` | money | Yes |  |
| `pCk4` | money | Yes |  |
| `pGt5` | money | Yes |  |
| `pCk5` | money | Yes |  |
| `pGt6` | money | Yes |  |
| `pCk6` | money | Yes |  |
| `pGt7` | money | Yes |  |
| `pCk7` | money | Yes |  |
| `pGt8` | money | Yes |  |
| `pCk8` | money | Yes |  |
| `pGt9` | money | Yes |  |
| `pCk9` | money | Yes |  |
| `pGt10` | money | Yes |  |
| `pCk10` | money | Yes |  |
| `pGt11` | money | Yes |  |
| `pCk11` | money | Yes |  |
| `pGt12` | money | Yes |  |
| `pCk12` | money | Yes |  |
| `pGt13` | money | Yes |  |
| `pCk13` | money | Yes |  |
| `pGt14` | money | Yes |  |
| `pCk14` | money | Yes |  |
| `pGt15` | money | Yes |  |
| `pCk15` | money | Yes |  |
| `pCUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMHHKM

- **Class:** AsSOInsDMHHKM
- **Description:** Stored procedure asSOInsDMHHKM
- **SQL File:** `asSOInsDMHHKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pLoai_km` | nvarchar(1) | Yes |  |
| `pSl_km` | decimal(19 | Yes |  |
| `pMuc_km` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMKM

- **Class:** AsSOInsDMKM
- **Description:** Stored procedure asSOInsDMKM
- **SQL File:** `asSOInsDMKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pTen_km` | nvarchar(100) | Yes |  |
| `pTu_ngay` | smalldatetime | Yes |  |
| `pDen_ngay` | smalldatetime | Yes |  |
| `pTk_cpkm` | nvarchar(20) | Yes |  |
| `pMo_ta` | nvarchar(MAX) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMNVKD

- **Class:** AsSOInsDMNVKD
- **Description:** Stored procedure asSOInsDMNVKD
- **SQL File:** `asSOInsDMNVKD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nvkd` | nvarchar(8) | Yes |  |
| `pTen_nvkd` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMPTVT

- **Class:** AsSOInsDMPTVT
- **Description:** Stored procedure asSOInsDMPTVT
- **SQL File:** `asSOInsDMPTVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pTen_pt` | nvarchar(50) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_dk` | nvarchar(30) | Yes |  |
| `pCao` | decimal(19 | Yes |  |
| `pDai` | decimal(19 | Yes |  |
| `pRong` | decimal(19 | Yes |  |
| `pThe_tich` | decimal(19 | Yes |  |
| `pTrong_tai` | decimal(19 | Yes |  |
| `pTg_xep` | decimal(19 | Yes |  |
| `pTg_do` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMTKM

- **Class:** AsSOInsDMTKM
- **Description:** Stored procedure asSOInsDMTKM
- **SQL File:** `asSOInsDMTKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pSl_km` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMTS

- **Class:** AsSOInsDMTS
- **Description:** Stored procedure asSOInsDMTS
- **SQL File:** `asSOInsDMTS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_thue` | nvarchar(2) | Yes |  |
| `pTen_Thue` | nvarchar(100) | Yes |  |
| `pKct` | BIT | Yes |  |
| `pTs_gtgt` | decimal(19 | Yes |  |
| `pTk_thue_co` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMTT

- **Class:** AsSOInsDMTT
- **Description:** Stored procedure asSOInsDMTT
- **SQL File:** `asSOInsDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pMo_ta` | nvarchar(50) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsDMgiaban

- **Class:** AsSOInsDMgiaban
- **Description:** Stored procedure asSOInsDMgiaban
- **SQL File:** `asSOInsDMgiaban.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pGia_nt2` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsND51bkhd

- **Class:** AsSOInsND51bkhd
- **Description:** :	Thêm thông tin bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51bkhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pTen_cty` | NVARCHAR(50) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pDai_dien` | NVARCHAR(50) | Yes |  |
| `pCdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51bkhdct

- **Class:** AsSOInsND51bkhdct
- **Description:** :	Thêm chi tiết bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51bkhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pMa_ph` | NVARCHAR(8) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pLoai` | BIT | Yes |  |
| `pSo_seri` | NVARCHAR(6) | Yes |  |
| `pTen_loai` | NVARCHAR(255) | Yes |  |
| `pTu_so` | NVARCHAR(7) | Yes |  |
| `pDen_so` | NVARCHAR(7) | Yes |  |
| `pSo_luong` | NVARCHAR(7) | Yes |  |
| `pSo_hdin` | NVARCHAR(7) | Yes |  |
| `pSo_hdph` | NVARCHAR(7) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51dmmhdct

- **Class:** AsSOInsND51dmmhdct
- **Description:** :	Thêm chi tiết mẫu hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51dmmhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pMota1` | NVARCHAR(255) | Yes |  |
| `pMota2` | NVARCHAR(255) | Yes |  |
| `pMota3` | NVARCHAR(255) | No |  (default: '') |
| `pMota4` | NVARCHAR(255) | No |  (default: '') |
| `pMota5` | NVARCHAR(255) | No |  (default: '') |
| `pMota6` | NVARCHAR(255) | No |  (default: '') |
| `pMota7` | NVARCHAR(255) | No |  (default: '') |
| `pMota8` | NVARCHAR(255) | No |  (default: '') |
| `pMota9` | NVARCHAR(255) | No |  (default: '') |
| `pMau_goc` | BIT | No |  (default: 0) |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51dmmhdph

- **Class:** AsSOInsND51dmmhdph
- **Description:** :	Thêm mẫu hoá đơn
- **SQL File:** `asSOInsND51dmmhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pTen_loai` | NVARCHAR(255) | Yes |  |
| `pMa_loai` | NVARCHAR(6) | Yes |  |
| `pSo_lien` | INT | Yes |  |
| `pSo_hd` | CHAR(3) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pTen_mau` | NVARCHAR(255) | Yes |  |
| `pLoai_in` | BIT | Yes |  |
| `pKh_hd` | CHAR(2) | Yes |  |
| `pKh_nam` | CHAR(2) | Yes |  |
| `pSo_seri` | NVARCHAR(6) | Yes |  |
| `pSo_dong` | INT | Yes |  |
| `pGhi_chu` | NVARCHAR(255) | Yes |  |
| `pMau_goc` | BIT | No |  (default: 0) |
| `pCdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51dmqdadhd

- **Class:** AsSOInsND51dmqdadhd
- **Description:** : Thêm mới quyết định áp dụng hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51dmqdadhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_qd` | NVARCHAR(20) | Yes |  |
| `pNgay_qd` | SMALLDATETIME | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pNgay_hl` | SMALLDATETIME | Yes |  |
| `pTen_cty` | NVARCHAR(50) | Yes |  |
| `pGiam_doc` | NVARCHAR(40) | Yes |  |
| `pDangky_kd` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pCq_thue` | NVARCHAR(80) | Yes |  |
| `pHt_tb` | NVARCHAR(255) | Yes |  |
| `pNcc` | NVARCHAR(255) | Yes |  |
| `pHdmd` | NTEXT | Yes |  |
| `pTnbp` | NTEXT | Yes |  |
| `pCdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51opt

- **Class:** AsSOInsND51opt
- **Description:** : Thêm mới options hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51opt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_opt` | NVARCHAR(20) | Yes |  |
| `pGia_tri` | NVARCHAR(255) | Yes |  |
| `pKsd` | BIT | Yes |  |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51phhdct

- **Class:** AsSOInsND51phhdct
- **Description:** :	Thêm chi tiết phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51phhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pMa_loai` | NVARCHAR(6) | Yes |  |
| `pSo_seri` | NVARCHAR(6) | Yes |  |
| `pSo_hd` | NVARCHAR(3) | Yes |  |
| `pTu_so` | NVARCHAR(7) | Yes |  |
| `pDen_so` | NVARCHAR(7) | Yes |  |
| `pSo_luong` | NVARCHAR(7) | Yes |  |
| `pNgay_sd` | SMALLDATETIME | Yes |  |
| `pDonvi_in` | NVARCHAR(50) | Yes |  |
| `pMa_thuedvi` | NVARCHAR(20) | Yes |  |
| `pNgay_in` | SMALLDATETIME | Yes |  |
| `pTen_loai` | NVARCHAR(255) | Yes |  |
| `pIsclose` | BIT | No |  (default: 0) |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51phhdph

- **Class:** AsSOInsND51phhdph
- **Description:** :	Thêm thông tin phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51phhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pDonvi_ph` | NVARCHAR(100) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pDia_chi` | NVARCHAR(128) | Yes |  |
| `pTel` | NVARCHAR(20) | Yes |  |
| `pDonvi_cq` | NVARCHAR(128) | Yes |  |
| `pMa_thuedvcq` | NVARCHAR(20) | Yes |  |
| `pCq_thue` | NVARCHAR(80) | Yes |  |
| `pDai_dien` | NVARCHAR(50) | Yes |  |
| `pNgay_duyet` | SMALLDATETIME | Yes |  |
| `pChap_nhan` | BIT | Yes |  |
| `pCdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51tkhd

- **Class:** AsSOInsND51tkhd
- **Description:** :	Lấy danh sách thống kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOInsND51tkhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asSOInsND51xlhd

- **Class:** AsSOInsND51xlhd
- **Description:** :	Thêm thông báo xử lý hoá đơn
- **SQL File:** `asSOInsND51xlhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pNoi_nhan` | NVARCHAR(128) | Yes |  |
| `pTen_tc` | NVARCHAR(50) | Yes |  |
| `pDai_dien` | NVARCHAR(40) | Yes |  |
| `pDia_chi` | NVARCHAR(128) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pGhi_chu` | NTEXT | Yes |  |
| `pGio_xl` | NVARCHAR(2) | Yes |  |
| `pPhut_xl` | NVARCHAR(2) | Yes |  |
| `pNgay_xl` | SMALLDATETIME | Yes |  |
| `pGui_cqt` | BIT | Yes |  |
| `pNgay_guicqt` | SMALLDATETIME | Yes |  |
| `pCdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pCuser` | NVARCHAR(20) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsND51xlhdct

- **Class:** AsSOInsND51xlhdct
- **Description:** :	Thêm chi tiết xử lý hoá đơn
- **SQL File:** `asSOInsND51xlhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pMa_chung` | NVARCHAR(20) | Yes |  |
| `pTen_loai` | NVARCHAR(255) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pSo_seri` | NVARCHAR(6) | Yes |  |
| `pTu_so` | NVARCHAR(7) | Yes |  |
| `pDen_so` | NVARCHAR(7) | Yes |  |
| `pSo_luong` | NVARCHAR(7) | Yes |  |
| `pLien_hd` | CHAR(1) | Yes |  |
| `pGhi_chu` | NVARCHAR(255) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOInsPH2

- **Class:** AsSOInsPH2
- **Description:** Stored procedure asSOInsPH2
- **SQL File:** `asSOInsPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pNguoi_nhan` | nvarchar(30) | Yes |  |
| `pCty_nhan` | nvarchar(50) | Yes |  |
| `pDc_nhan` | nvarchar(50) | Yes |  |
| `pTel_nhan` | nvarchar(20) | Yes |  |
| `pMa_nvt` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_lai` | nvarchar(30) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pTen_td` | nvarchar(50) | Yes |  |
| `pKm` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pGia_dd` | bit | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pt_so_luong` | decimal(19 | Yes |  |
| `pTao_tu_dh` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsPH3

- **Class:** AsSOInsPH3
- **Description:** Stored procedure asSOInsPH3
- **SQL File:** `asSOInsPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pHttt` | nvarchar(50) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pNguoi_nhan` | nvarchar(30) | Yes |  |
| `pCty_nhan` | nvarchar(50) | Yes |  |
| `pDc_nhan` | nvarchar(50) | Yes |  |
| `pTel_nhan` | nvarchar(20) | Yes |  |
| `pMa_nvt` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_lai` | nvarchar(30) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pTen_td` | nvarchar(50) | Yes |  |
| `pKm` | decimal(19 | Yes |  |
| `pGia_dd` | bit | Yes |  |
| `pCk_st` | bit | Yes |  |
| `pGia_st` | bit | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pSo_px` | nvarchar(12) | Yes |  |
| `pNgay_px` | smalldatetime | Yes |  |
| `pDia_chi_px` | nvarchar(255) | Yes |  |
| `pNguoi_gd_px` | nvarchar(30) | Yes |  |
| `pTel_px` | nvarchar(20) | Yes |  |
| `pDien_giai_px` | nvarchar(255) | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pTl_ck_ds` | decimal(6 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pt_so_luong` | decimal(19 | Yes |  |
| `pTao_tu_px` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsPH4

- **Class:** AsSOInsPH4
- **Description:** Stored procedure asSOInsPH4
- **SQL File:** `asSOInsPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pSo_seri_mhd` | NVARCHAR(11) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pGia_tb` | bit | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pDia_chi_pn` | nvarchar(255) | Yes |  |
| `pNguoi_gd_pn` | nvarchar(30) | Yes |  |
| `pTel_pn` | nvarchar(20) | Yes |  |
| `pDien_giai_pn` | nvarchar(255) | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pkht_tain` | bit | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pTao_tu_hd` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsPH5

- **Class:** AsSOInsPH5
- **Description:** Stored procedure asSOInsPH5
- **SQL File:** `asSOInsPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_seri_mhd` | NVARCHAR(11) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pHttt` | nvarchar(50) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSo_px` | nvarchar(12) | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOInsPH6

- **Class:** AsSOInsPH6
- **Description:** Stored procedure asSOInsPH6
- **SQL File:** `asSOInsPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |
| `pCa` | NVARCHAR(20) | Yes |  |
| `pT_tien2` | DECIMAL(19 | Yes |  |
| `pT_ck` | DECIMAL(19 | Yes |  |
| `pT_thue` | DECIMAL(19 | Yes |  |
| `pT_tt` | DECIMAL(19 | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

## Update Procedures

### asSOUpdDMKM

- **Class:** AsSOUpdDMKM
- **Description:** Stored procedure asSOUpdDMKM
- **SQL File:** `asSOUpdDMKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pTen_km` | nvarchar(100) | Yes |  |
| `pTu_ngay` | smalldatetime | Yes |  |
| `pDen_ngay` | smalldatetime | Yes |  |
| `pTk_cpkm` | nvarchar(20) | Yes |  |
| `pMo_ta` | nvarchar(MAX) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdDMNVKD

- **Class:** AsSOUpdDMNVKD
- **Description:** Stored procedure asSOUpdDMNVKD
- **SQL File:** `asSOUpdDMNVKD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nvkd` | nvarchar(8) | Yes |  |
| `pTen_nvkd` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdDMPTVT

- **Class:** AsSOUpdDMPTVT
- **Description:** Stored procedure asSOUpdDMPTVT
- **SQL File:** `asSOUpdDMPTVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pTen_pt` | nvarchar(50) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_dk` | nvarchar(30) | Yes |  |
| `pCao` | decimal(19 | Yes |  |
| `pDai` | decimal(19 | Yes |  |
| `pRong` | decimal(19 | Yes |  |
| `pThe_tich` | decimal(19 | Yes |  |
| `pTrong_tai` | decimal(19 | Yes |  |
| `pTg_xep` | decimal(19 | Yes |  |
| `pTg_do` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdDMTKM

- **Class:** AsSOUpdDMTKM
- **Description:** Stored procedure asSOUpdDMTKM
- **SQL File:** `asSOUpdDMTKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pSl_km` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdDMTS

- **Class:** AsSOUpdDMTS
- **Description:** Stored procedure asSOUpdDMTS
- **SQL File:** `asSOUpdDMTS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_thue` | nvarchar(2) | Yes |  |
| `pTen_Thue` | nvarchar(100) | Yes |  |
| `pTs_gtgt` | decimal(19 | Yes |  |
| `pKct` | BIT | Yes |  |
| `pTk_thue_co` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdDMTT

- **Class:** AsSOUpdDMTT
- **Description:** Stored procedure asSOUpdDMTT
- **SQL File:** `asSOUpdDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pMo_ta` | nvarchar(50) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdND51bkhd

- **Class:** AsSOUpdND51bkhd
- **Description:** :	Sửa thông tin bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOUpdND51bkhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pTen_cty` | NVARCHAR(50) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pDai_dien` | NVARCHAR(50) | Yes |  |
| `pLdate` | SMALLDATETIME | Yes |  |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdND51dmmhdph

- **Class:** AsSOUpdND51dmmhdph
- **Description:** :	Sửa mẫu hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOUpdND51dmmhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_loai` | NVARCHAR(6) | Yes |  |
| `pSo_lien` | INT | Yes |  |
| `pSo_hd` | CHAR(3) | Yes |  |
| `pTen_mau` | NVARCHAR(255) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pLoai_in` | BIT | Yes |  |
| `pKh_hd` | CHAR(2) | Yes |  |
| `pKh_nam` | CHAR(2) | Yes |  |
| `pSo_seri` | NVARCHAR(6) | Yes |  |
| `pSo_dong` | INT | Yes |  |
| `pGhi_chu` | NVARCHAR(255) | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdND51dmqdadhd

- **Class:** AsSOUpdND51dmqdadhd
- **Description:** : Cập nhật quyết định áp dụng hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOUpdND51dmqdadhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_qd` | NVARCHAR(20) | Yes |  |
| `pNgay_qd` | SMALLDATETIME | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pNgay_hl` | SMALLDATETIME | Yes |  |
| `pTen_cty` | NVARCHAR(50) | Yes |  |
| `pGiam_doc` | NVARCHAR(40) | Yes |  |
| `pDangky_kd` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pCq_thue` | NVARCHAR(80) | Yes |  |
| `pHt_tb` | NVARCHAR(255) | Yes |  |
| `pNcc` | NVARCHAR(255) | Yes |  |
| `pHdmd` | NTEXT | Yes |  |
| `pTnbp` | NTEXT | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdND51opt

- **Class:** AsSOUpdND51opt
- **Description:** : Cập nhật option hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOUpdND51opt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_opt` | NVARCHAR(20) | Yes |  |
| `pGia_tri` | NVARCHAR(255) | Yes |  |
| `pKsd` | BIT | Yes |  |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdND51phhdph

- **Class:** AsSOUpdND51phhdph
- **Description:** :	Sửa thông tin phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOUpdND51phhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pDonvi_ph` | NVARCHAR(50) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pDia_chi` | NVARCHAR(128) | Yes |  |
| `pTel` | NVARCHAR(20) | Yes |  |
| `pDonvi_cq` | NVARCHAR(128) | Yes |  |
| `pMa_thuedvcq` | NVARCHAR(20) | Yes |  |
| `pCq_thue` | NVARCHAR(80) | Yes |  |
| `pDai_dien` | NVARCHAR(50) | Yes |  |
| `pNgay_duyet` | SMALLDATETIME | Yes |  |
| `pChap_nhan` | BIT | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdND51xlhd

- **Class:** AsSOUpdND51xlhd
- **Description:** :	Sửa thông báo xử lý hoá đơn
- **SQL File:** `asSOUpdND51xlhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pNgay_tb` | SMALLDATETIME | Yes |  |
| `pNoi_nhan` | NVARCHAR(128) | Yes |  |
| `pTen_tc` | NVARCHAR(50) | Yes |  |
| `pDai_dien` | NVARCHAR(40) | Yes |  |
| `pDia_chi` | NVARCHAR(128) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pGhi_chu` | NTEXT | Yes |  |
| `pGio_xl` | NVARCHAR(2) | Yes |  |
| `pPhut_xl` | NVARCHAR(2) | Yes |  |
| `pNgay_xl` | SMALLDATETIME | Yes |  |
| `pGui_cqt` | BIT | Yes |  |
| `pNgay_guicqt` | SMALLDATETIME | Yes |  |
| `pLdate` | SMALLDATETIME | No |  (default: GETDATE) |
| `pLuser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSOUpdPH1

- **Class:** AsSOUpdPH1
- **Description:** Stored procedure asSOUpdPH1
- **SQL File:** `asSOUpdPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_hh` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pCk_st` | bit | Yes |  |
| `pGia_st` | bit | Yes |  |
| `pMa_dckh` | nvarchar(1) | Yes |  |
| `pNguoi_nhan` | nvarchar(30) | Yes |  |
| `pCty_nhan` | nvarchar(50) | Yes |  |
| `pDc_nhan` | nvarchar(50) | Yes |  |
| `pTel_nhan` | nvarchar(20) | Yes |  |
| `pMa_nvt` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_lai` | nvarchar(30) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pTen_td` | nvarchar(50) | Yes |  |
| `pKm` | decimal(19 | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pTl_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pt_so_luong` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdPH2

- **Class:** AsSOUpdPH2
- **Description:** Stored procedure asSOUpdPH2
- **SQL File:** `asSOUpdPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pNguoi_nhan` | nvarchar(30) | Yes |  |
| `pCty_nhan` | nvarchar(50) | Yes |  |
| `pDc_nhan` | nvarchar(50) | Yes |  |
| `pTel_nhan` | nvarchar(20) | Yes |  |
| `pMa_nvt` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_lai` | nvarchar(30) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pTen_td` | nvarchar(50) | Yes |  |
| `pKm` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pGia_dd` | bit | Yes |  |
| `pt_so_luong` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdPH3

- **Class:** AsSOUpdPH3
- **Description:** Stored procedure asSOUpdPH3
- **SQL File:** `asSOUpdPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pHttt` | nvarchar(50) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pNguoi_nhan` | nvarchar(30) | Yes |  |
| `pCty_nhan` | nvarchar(50) | Yes |  |
| `pDc_nhan` | nvarchar(50) | Yes |  |
| `pTel_nhan` | nvarchar(20) | Yes |  |
| `pMa_nvt` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |
| `pBien_so` | nvarchar(20) | Yes |  |
| `pNguoi_lai` | nvarchar(30) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pTen_td` | nvarchar(50) | Yes |  |
| `pKm` | decimal(19 | Yes |  |
| `pGia_dd` | bit | Yes |  |
| `pCk_st` | bit | Yes |  |
| `pGia_st` | bit | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pSo_px` | nvarchar(12) | Yes |  |
| `pNgay_px` | smalldatetime | Yes |  |
| `pDia_chi_px` | nvarchar(255) | Yes |  |
| `pNguoi_gd_px` | nvarchar(30) | Yes |  |
| `pTel_px` | nvarchar(20) | Yes |  |
| `pDien_giai_px` | nvarchar(255) | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pTl_ck_ds` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pt_so_luong` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdPH4

- **Class:** AsSOUpdPH4
- **Description:** Stored procedure asSOUpdPH4
- **SQL File:** `asSOUpdPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_seri_mhd` | NVARCHAR(11) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pGia_tb` | bit | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pDia_chi_pn` | nvarchar(255) | Yes |  |
| `pNguoi_gd_pn` | nvarchar(30) | Yes |  |
| `pTel_pn` | nvarchar(20) | Yes |  |
| `pDien_giai_pn` | nvarchar(255) | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pkht_tain` | bit | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpdPH5

- **Class:** AsSOUpdPH5
- **Description:** Stored procedure asSOUpdPH5
- **SQL File:** `asSOUpdPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_seri_mhd` | NVARCHAR(11) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pTk_ck_ds` | nvarchar(20) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pHttt` | nvarchar(50) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pSua_ck` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_ck_ds` | decimal(19 | Yes |  |
| `pT_ck_ds_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pPost2in` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOUpddmgiaban

- **Class:** AsSOUpddmgiaban
- **Description:** Stored procedure asSOUpddmgiaban
- **SQL File:** `asSOUpddmgiaban.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pGia_nt2` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Delete Procedures

### asSODelCT1

- **Class:** AsSODelCT1
- **Description:** Stored procedure asSODelCT1
- **SQL File:** `asSODelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCT2

- **Class:** AsSODelCT2
- **Description:** Stored procedure asSODelCT2
- **SQL File:** `asSODelCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCT3

- **Class:** AsSODelCT3
- **Description:** Stored procedure asSODelCT3
- **SQL File:** `asSODelCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCT4

- **Class:** AsSODelCT4
- **Description:** Stored procedure asSODelCT4
- **SQL File:** `asSODelCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(4) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCT5

- **Class:** AsSODelCT5
- **Description:** Stored procedure asSODelCT5
- **SQL File:** `asSODelCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCT6

- **Class:** AsSODelCT6
- **Description:** Stored procedure asSODelCT6
- **SQL File:** `asSODelCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asSODelCk

- **Class:** AsSODelCk
- **Description:** :	delete data danh mục chiết khấu
- **SQL File:** `asSODelCk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_kyck` | NVARCHAR(1) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nhvt` | NVARCHAR(8) | Yes |  |
| `pMa_kh` | NVARCHAR(20) | Yes |  |
| `pMa_nhkh` | NVARCHAR(8) | Yes |  |
| `pSl_ds` | NVARCHAR(1) | Yes |  |
| `ptl_sl_ds` | NVARCHAR(1) | Yes |  |
| `pTl_gt` | NVARCHAR(1) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelDMKM

- **Class:** AsSODelDMKM
- **Description:** Stored procedure asSODelDMKM
- **SQL File:** `asSODelDMKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |

---

### asSODelDMNVKD

- **Class:** AsSODelDMNVKD
- **Description:** Stored procedure asSODelDMNVKD
- **SQL File:** `asSODelDMNVKD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nvkd` | nvarchar(8) | Yes |  |

---

### asSODelDMPTVT

- **Class:** AsSODelDMPTVT
- **Description:** Stored procedure asSODelDMPTVT
- **SQL File:** `asSODelDMPTVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |

---

### asSODelDMTKM

- **Class:** AsSODelDMTKM
- **Description:** Stored procedure asSODelDMTKM
- **SQL File:** `asSODelDMTKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_km` | nvarchar(20) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |

---

### asSODelDMTS

- **Class:** AsSODelDMTS
- **Description:** Stored procedure asSODelDMTS
- **SQL File:** `asSODelDMTS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_thue` | nvarchar(2) | Yes |  |

---

### asSODelDMTT

- **Class:** AsSODelDMTT
- **Description:** Stored procedure asSODelDMTT
- **SQL File:** `asSODelDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |

---

### asSODelND51bkhd

- **Class:** AsSODelND51bkhd
- **Description:** :	Xoá thông tin bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51bkhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51bkhdct

- **Class:** AsSODelND51bkhdct
- **Description:** :	Xoá thông tin chi tiết bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51bkhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51dmmhdct

- **Class:** AsSODelND51dmmhdct
- **Description:** :	Xoá chi tiết mẫu hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51dmmhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51dmmhdph

- **Class:** AsSODelND51dmmhdph
- **Description:** :	Xoá thông tin khai báo mẫu hoá đơn theo nghị định 51
- **SQL File:** `asSODelND51dmmhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51dmqdadhd

- **Class:** AsSODelND51dmqdadhd
- **Description:** :	Xoá quyết định áp dụng hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51dmqdadhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_qd` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51opt

- **Class:** AsSODelND51opt
- **Description:** :	Xoá options hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51opt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_opt` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51phhdct

- **Class:** AsSODelND51phhdct
- **Description:** :	Xoá thông tin chi tiết phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51phhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51phhdph

- **Class:** AsSODelND51phhdph
- **Description:** :	Xoá thông tin phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSODelND51phhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51xlhd

- **Class:** AsSODelND51xlhd
- **Description:** :	Xoá thông báo xử lý hoá đơn
- **SQL File:** `asSODelND51xlhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelND51xlhdct

- **Class:** AsSODelND51xlhdct
- **Description:** :	Xoá chi tiết xử lý hoá đơn
- **SQL File:** `asSODelND51xlhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asSODelPH1

- **Class:** AsSODelPH1
- **Description:** Stored procedure asSODelPH1
- **SQL File:** `asSODelPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODelPH2

- **Class:** AsSODelPH2
- **Description:** Stored procedure asSODelPH2
- **SQL File:** `asSODelPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(4) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODelPH3

- **Class:** AsSODelPH3
- **Description:** Stored procedure asSODelPH3
- **SQL File:** `asSODelPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODelPH4

- **Class:** AsSODelPH4
- **Description:** Stored procedure asSODelPH4
- **SQL File:** `asSODelPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(4) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODelPH5

- **Class:** AsSODelPH5
- **Description:** Stored procedure asSODelPH5
- **SQL File:** `asSODelPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODelPH6

- **Class:** AsSODelPH6
- **Description:** Stored procedure asSODelPH6
- **SQL File:** `asSODelPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asSODeldmgiaban

- **Class:** AsSODeldmgiaban
- **Description:** Stored procedure asSODeldmgiaban
- **SQL File:** `asSODeldmgiaban.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |

---

### asSODeldmgiavantai

- **Class:** AsSODeldmgiavantai
- **Description:** Stored procedure asSODeldmgiavantai
- **SQL File:** `asSODeldmgiavantai.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_td` | nvarchar(8) | Yes |  |
| `pMa_pt` | nvarchar(8) | Yes |  |

---

## Get Procedures

### asSOGetBKHDCT

- **Class:** AsSOGetBKHDCT
- **Description:** :	Lấy thông tin chi tiết bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetBKHDCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

### asSOGetCA4SO

- **Class:** AsSOGetCA4SO
- **Description:** :	Lấy thông tin chứng từ thanh toán (Thu/Báo có) từ phân hệ bán hàng
- **SQL File:** `asSOGetCA4SO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

### asSOGetCT3

- **Class:** AsSOGetCT3
- **Description:** Stored procedure asSOGetCT3
- **SQL File:** `asSOGetCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '111xSO30000013778506') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asSOGetCT4

- **Class:** AsSOGetCT4
- **Description:** Stored procedure asSOGetCT4
- **SQL File:** `asSOGetCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asSOGetCT5

- **Class:** AsSOGetCT5
- **Description:** Stored procedure asSOGetCT5
- **SQL File:** `asSOGetCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '999wSO50000013778512') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asSOGetCT6

- **Class:** AsSOGetCT6
- **Description:** Stored procedure asSOGetCT6
- **SQL File:** `asSOGetCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetCk

- **Class:** AsSOGetCk
- **Description:** :	Get data danh mục chiết khấu
- **SQL File:** `asSOGetCk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pVt_nhomvt` | nvarchar(1) | No |  (default: null) |
| `pKh_nhomkh` | nvarchar(1) | No |  (default: null) |
| `pSl_ds` | nvarchar(1) | No |  (default: null) |
| `pTl_gt` | nvarchar(1) | No |  (default: null) |
| `pTl_sl_ds` | nvarchar(1) | No |  (default: null) |
| `pma_kyck` | nvarchar(1) | No |  (default: null) |
| `pMa_vt` | nvarchar(20) | No |  (default: null) |
| `pMa_nhvt` | nvarchar(8) | No |  (default: null) |
| `pMa_kh` | nvarchar(20) | No |  (default: null) |
| `pMa_nhkh` | nvarchar(8) | No |  (default: null) |

---

### asSOGetDMKM

- **Class:** AsSOGetDMKM
- **Description:** Stored procedure asSOGetDMKM
- **SQL File:** `asSOGetDMKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_km` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDMNVKD

- **Class:** AsSOGetDMNVKD
- **Description:** Stored procedure asSOGetDMNVKD
- **SQL File:** `asSOGetDMNVKD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_nvkd` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDMPTVT

- **Class:** AsSOGetDMPTVT
- **Description:** Stored procedure asSOGetDMPTVT
- **SQL File:** `asSOGetDMPTVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_pt` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDMTKM

- **Class:** AsSOGetDMTKM
- **Description:** Stored procedure asSOGetDMTKM
- **SQL File:** `asSOGetDMTKM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_km` | nvarchar(20) | No |  (default: null) |
| `pMa_vt` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDMTS

- **Class:** AsSOGetDMTS
- **Description:** Stored procedure asSOGetDMTS
- **SQL File:** `asSOGetDMTS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_thue` | nvarchar(2) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDMTT

- **Class:** AsSOGetDMTT
- **Description:** Stored procedure asSOGetDMTT
- **SQL File:** `asSOGetDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_tt` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetDSHD

- **Class:** AsSOGetDSHD
- **Description:** :	Lấy thông tin hoá đơn
- **SQL File:** `asSOGetDSHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asSOGetGiaban

- **Class:** AsSOGetGiaban
- **Description:** Stored procedure asSOGetGiaban
- **SQL File:** `asSOGetGiaban.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pKieu_lay_gia` | nvarchar(1) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nt` | NVARCHAR(8) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |

---

### asSOGetGiabanGiamGia

- **Class:** AsSOGetGiabanGiamGia
- **Description:** Stored procedure asSOGetGiabanGiamGia
- **SQL File:** `asSOGetGiabanGiamGia.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(8) | No |  (default: 'VND') |
| `pSo_luong` | money | Yes |  |
| `pTl_gt` | nvarchar(1) (output) | Yes |  |
| `pGg` | money (output) | Yes |  |

---

### asSOGetKyCk

- **Class:** AsSOGetKyCk
- **Description:** :	Get ky chiết khấu
- **SQL File:** `asSOGetKyCk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asSOGetND51bkhd

- **Class:** AsSOGetND51bkhd
- **Description:** :	Lấy thông tin bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51bkhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_tb` | NVARCHAR(8) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51bkhdct

- **Class:** AsSOGetND51bkhdct
- **Description:** :	Lấy thông tin chi tiết bảng kê hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51bkhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_tb` | NVARCHAR(8) | No |  (default: NULL) |
| `pLoai` | BIT | No |  (default: 0) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51dmmhdct

- **Class:** AsSOGetND51dmmhdct
- **Description:** :	Lấy thông tin chi tiết mẫu hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51dmmhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau_so` | NVARCHAR(11) | Yes |  |

---

### asSOGetND51dmmhdph

- **Class:** AsSOGetND51dmmhdph
- **Description:** :	Lấy thông tin mẫu hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51dmmhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMau_so` | NVARCHAR(11) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pMuduleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51dmqdadhd

- **Class:** AsSOGetND51dmqdadhd
- **Description:** :	Lấy thông tin quyết định áp dụng hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51dmqdadhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

### asSOGetND51opt

- **Class:** AsSOGetND51opt
- **Description:** :	Lấy thông tin options hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51opt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_opt` | NVARCHAR(20) | Yes |  |

---

### asSOGetND51phhdct

- **Class:** AsSOGetND51phhdct
- **Description:** :	Lấy thông tin chi tiết phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSOGetND51phhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_tb` | NVARCHAR(8) | No |  (default: NULL) |
| `pChap_nhan` | BIT | No |  (default: 0) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51phhdph

- **Class:** AsSOGetND51phhdph
- **Description:** :	Lấy thông tin phát hành hoá đơn
- **SQL File:** `asSOGetND51phhdph.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_tb` | NVARCHAR(8) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51xlhd

- **Class:** AsSOGetND51xlhd
- **Description:** :	Lấy thông tin xử lý hoá đơn
- **SQL File:** `asSOGetND51xlhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pKieu_xl` | CHAR(3) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asSOGetND51xlhdct

- **Class:** AsSOGetND51xlhdct
- **Description:** :	Lấy thông tin chi tiết xử lý hoá đơn
- **SQL File:** `asSOGetND51xlhdct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pKieu_xl` | CHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |

---

### asSOGetPH3

- **Class:** AsSOGetPH3
- **Description:** Stored procedure asSOGetPH3
- **SQL File:** `asSOGetPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetPH4

- **Class:** AsSOGetPH4
- **Description:** Stored procedure asSOGetPH4
- **SQL File:** `asSOGetPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetPH5

- **Class:** AsSOGetPH5
- **Description:** Stored procedure asSOGetPH5
- **SQL File:** `asSOGetPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetPH6

- **Class:** AsSOGetPH6
- **Description:** Stored procedure asSOGetPH6
- **SQL File:** `asSOGetPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetPh1

- **Class:** AsSOGetPh1
- **Description:** Stored procedure asSOGetPh1
- **SQL File:** `asSOGetPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: '') |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSOGetdmgiaban

- **Class:** AsSOGetdmgiaban
- **Description:** Stored procedure asSOGetdmgiaban
- **SQL File:** `asSOGetdmgiaban.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

## Report Procedures

### asSORptBCPT011

- **Class:** AsSORptBCPT011
- **Description:** Stored procedure asSORptBCPT011
- **SQL File:** `asSORptBCPT011.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '') |

---

### asSORptBCPT021

- **Class:** AsSORptBCPT021
- **Description:** Stored procedure asSORptBCPT021
- **SQL File:** `asSORptBCPT021.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '') |

---

### asSORptBCPT022

- **Class:** AsSORptBCPT022
- **Description:** Stored procedure asSORptBCPT022
- **SQL File:** `asSORptBCPT022.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '1') |

---

### asSORptBCPT03

- **Class:** AsSORptBCPT03
- **Description:** Stored procedure asSORptBCPT03
- **SQL File:** `asSORptBCPT03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pkhuyen_mai` | BIT | No |  (default: 0) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pHang_ban` | BIT | No |  (default: 0) |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pTkCP_BH` | NVARCHAR(20) | No |  (default: '641') |
| `pTkCP_QL` | NVARCHAR(20) | No |  (default: '642') |
| `pPsNc_BH` | BIT | No |  (default: 0) |
| `pPsNc_QL` | BIT | No |  (default: 0) |
| `pTKCP_BH_DU` | NVARCHAR(20) | No |  (default: '') |
| `pTKCP_QL_DU` | NVARCHAR(20) | No |  (default: '') |

---

### asSORptBCPT04

- **Class:** AsSORptBCPT04
- **Description:** Stored procedure asSORptBCPT04
- **SQL File:** `asSORptBCPT04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150301') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150331') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NhHd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pkhuyen_mai` | BIT | No |  (default: 1) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pTra_lai` | BIT | No |  (default: 0) |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pType` | NVARCHAR(3) | No |  (default: '02') |

---

### asSORptBCPT05

- **Class:** AsSORptBCPT05
- **Description:** Stored procedure asSORptBCPT05
- **SQL File:** `asSORptBCPT05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_Bp` | nvarchar(20) | No |  (default: '') |
| `pMa_Nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_NhHd` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pkhuyen_mai` | bit | No |  (default: 1) |
| `pTra_ck` | bit | No |  (default: 1) |
| `pHang_ban` | bit | No |  (default: 1) |
| `pTra_lai` | bit | No |  (default: 1) |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asSORptBCPT06

- **Class:** AsSORptBCPT06
- **Description:** Stored procedure asSORptBCPT06
- **SQL File:** `asSORptBCPT06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_HTTT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pkhuyen_mai` | BIT | No |  (default: 1) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_NV') |

---

### asSORptBCPT07

- **Class:** AsSORptBCPT07
- **Description:** Stored procedure asSORptBCPT07
- **SQL File:** `asSORptBCPT07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pkhuyen_mai` | BIT | No |  (default: 1) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_VT') |
| `pTarget` | NVARCHAR(20) | No |  (default: 'MA_BP') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |

---

### asSORptBCPT08

- **Class:** AsSORptBCPT08
- **Description:** :	Báo cáo chiết khấu bán hàng
- **SQL File:** `asSORptBCPT08.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pma_nhhd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |

---

### asSORptBK02

- **Class:** AsSORptBK02
- **Description:** Stored procedure asSORptBK02
- **SQL File:** `asSORptBK02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_ct` | NVARCHAR(3) | No |  (default: 'SO4') |
| `pTrang_thai` | NVARCHAR(3) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pGroupType` | NVARCHAR(128) | No |  (default: 'MA_KH' -- KH) |

---

### asSORptBK021

- **Class:** AsSORptBK021
- **Description:** Stored procedure asSORptBK021
- **SQL File:** `asSORptBK021.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTrang_thai` | NVARCHAR(1) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pSo_DH` | NVARCHAR(12) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |

---

### asSORptBK022

- **Class:** AsSORptBK022
- **Description:** Stored procedure asSORptBK022
- **SQL File:** `asSORptBK022.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTrang_thai` | NVARCHAR(1) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pSo_PX` | NVARCHAR(12) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |

---

### asSORptBK03

- **Class:** AsSORptBK03
- **Description:** Stored procedure asSORptBK03
- **SQL File:** `asSORptBK03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_PX` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK031

- **Class:** AsSORptBK031
- **Description:** Stored procedure asSORptBK031
- **SQL File:** `asSORptBK031.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_PX` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK032

- **Class:** AsSORptBK032
- **Description:** Stored procedure asSORptBK032
- **SQL File:** `asSORptBK032.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK04

- **Class:** AsSORptBK04
- **Description:** Stored procedure asSORptBK04
- **SQL File:** `asSORptBK04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK041

- **Class:** AsSORptBK041
- **Description:** Stored procedure asSORptBK041
- **SQL File:** `asSORptBK041.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK042

- **Class:** AsSORptBK042
- **Description:** Stored procedure asSORptBK042
- **SQL File:** `asSORptBK042.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK05

- **Class:** AsSORptBK05
- **Description:** Stored procedure asSORptBK05
- **SQL File:** `asSORptBK05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_Nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK051

- **Class:** AsSORptBK051
- **Description:** Stored procedure asSORptBK051
- **SQL File:** `asSORptBK051.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_Nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK052

- **Class:** AsSORptBK052
- **Description:** Stored procedure asSORptBK052
- **SQL File:** `asSORptBK052.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_Nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |

---

### asSORptBK06

- **Class:** AsSORptBK06
- **Description:** Stored procedure asSORptBK06
- **SQL File:** `asSORptBK06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pTrang_thai` | nvarchar(1) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pGroupType` | nvarchar(128) | No |  (default: 'MA_KH' -- KH) |

---

### asSORptCVT01

- **Class:** AsSORptCVT01
- **Description:** Stored procedure asSORptCVT01
- **SQL File:** `asSORptCVT01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_td` | nvarchar(8) | No |  (default: '') |
| `pMa_pt` | nvarchar(8) | No |  (default: '') |
| `pMa_nvt` | nvarchar(20) | No |  (default: '') |

---

### asSORptCVT02

- **Class:** AsSORptCVT02
- **Description:** Stored procedure asSORptCVT02
- **SQL File:** `asSORptCVT02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_td` | nvarchar(8) | No |  (default: '') |
| `pMa_pt` | nvarchar(8) | No |  (default: '') |
| `pMa_nvt` | nvarchar(20) | No |  (default: '') |

---

### asSORptCommon

- **Class:** AsSORptCommon
- **Description:** Stored procedure asSORptCommon
- **SQL File:** `asSORptCommon.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(20) | No |  (default: '') |
| `pMa_lo` | nvarchar(20) | No |  (default: '') |
| `pMa_vitri` | nvarchar(20) | No |  (default: '') |
| `pMa_httt` | nvarchar(20) | No |  (default: '') |
| `pMa_TT` | nvarchar(20) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nvkd` | nvarchar(8) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: '') |
| `pDien_giai` | nvarchar(3) | No |  (default: '') |
| `pTrang_thai` | nvarchar(3) | No |  (default: '') |

---

### asSORptF5BCPT03

- **Class:** AsSORptF5BCPT03
- **Description:** Stored procedure asSORptF5BCPT03
- **SQL File:** `asSORptF5BCPT03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pkhuyen_mai` | BIT | No |  (default: 0) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pHang_ban` | BIT | No |  (default: 0) |
| `pTra_lai` | BIT | No |  (default: 0) |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |

---

### asSORptF5BCPT04

- **Class:** AsSORptF5BCPT04
- **Description:** Stored procedure asSORptF5BCPT04
- **SQL File:** `asSORptF5BCPT04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: N'10005') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: N'00301') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pkhuyen_mai` | BIT | No |  (default: 1) |
| `pTra_ck` | BIT | No |  (default: 1) |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150101') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20151231') |

---

### asSORptF5BCPT06

- **Class:** AsSORptF5BCPT06
- **Description:** Stored procedure asSORptF5BCPT06
- **SQL File:** `asSORptF5BCPT06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Httt` | NVARCHAR(20) | No |  (default: '') |
| `pkhuyen_mai` | NVARCHAR(1) | No |  (default: '') |
| `pTra_ck` | NVARCHAR(1) | No |  (default: '') |
| `pHang_ban` | NVARCHAR(1) | No |  (default: '') |
| `pTra_lai` | NVARCHAR(1) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pDvt` | NVARCHAR(8) | No |  (default: '') |

---

### asSORptF5TH0

- **Class:** AsSORptF5TH0
- **Description:** Stored procedure asSORptF5TH0
- **SQL File:** `asSORptF5TH0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '30001') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Httt` | NVARCHAR(20) | No |  (default: '') |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pkhuyen_mai` | BIT | No |  (default: 0) |
| `pTra_ck` | BIT | No |  (default: 0) |
| `pTra_lai` | BIT | No |  (default: 0) |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pDvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_tt` | NVARCHAR(8) | No |  (default: '') |

---

### asSORptF5TH02

- **Class:** AsSORptF5TH02
- **Description:** : f5	Tổng hợp bán hàng theo kỳ
- **SQL File:** `asSORptF5TH02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pLoai` | NVARCHAR(5) | Yes |  |
| `pLoai_CT` | NVARCHAR(3) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |

---

### asSORptND51phhd

- **Class:** AsSORptND51phhd
- **Description:** :	In phát hành hoá đơn tự in theo nghị định 51
- **SQL File:** `asSORptND51phhd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_tb` | NVARCHAR(8) | Yes |  |

---

### asSORptTH01

- **Class:** AsSORptTH01
- **Description:** Stored procedure asSORptTH01
- **SQL File:** `asSORptTH01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pHang_ban` | BIT | No |  (default: 1) |
| `pkhuyen_mai` | BIT | No |  (default: 0) |
| `pTra_ck` | BIT | No |  (default: 0) |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pTrang_thai` | NVARCHAR(3) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |

---

### asSORptTH02

- **Class:** AsSORptTH02
- **Description:** :	Tổng hợp bán hàng theo kỳ
- **SQL File:** `asSORptTH02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pLoai` | NVARCHAR(5) | Yes |  |
| `pLoai_CT` | NVARCHAR(3) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pIs_NT` | BIT | No |  (default: 0) |

---

### asSORptTH03

- **Class:** AsSORptTH03
- **Description:** Stored procedure asSORptTH03
- **SQL File:** `asSORptTH03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_loai` | nvarchar(3) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pMa_HTTT` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pHang_ban` | bit | No |  (default: 1) |
| `pkhuyen_mai` | bit | No |  (default: 0) |
| `pTra_ck` | bit | No |  (default: 0) |
| `pTra_lai` | bit | No |  (default: 0) |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asSORptTH04

- **Class:** AsSORptTH04
- **Description:** Stored procedure asSORptTH04
- **SQL File:** `asSORptTH04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asSORptTH05

- **Class:** AsSORptTH05
- **Description:** Stored procedure asSORptTH05
- **SQL File:** `asSORptTH05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pMa_loai` | nvarchar(1) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asSORptTH06

- **Class:** AsSORptTH06
- **Description:** Stored procedure asSORptTH06
- **SQL File:** `asSORptTH06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_loai` | nvarchar(3) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt1` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt2` | nvarchar(8) | No |  (default: '') |
| `pMa_plvt3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(8) | No |  (default: '') |
| `pMa_HTTT` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pHang_ban` | bit | No |  (default: 1) |
| `pkhuyen_mai` | bit | No |  (default: 0) |
| `pTra_ck` | bit | No |  (default: 0) |
| `pTra_lai` | bit | No |  (default: 0) |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asSORptTH07

- **Class:** AsSORptTH07
- **Description:** :	Tổng hợp bán hàng theo kỳ
- **SQL File:** `asSORptTH07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pLoai` | NVARCHAR(5) | Yes |  |
| `pLoai_CT` | NVARCHAR(3) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |

---

## Process Procedures

### asSOPostTraTruoc_arTt

- **Class:** AsSOPostTraTruoc_arTt
- **Description:** Stored procedure asSOPostTraTruoc_arTt
- **SQL File:** `asSOPostTraTruoc_arTt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pt` | NVARCHAR(20) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pTien_tra_truoc` | MONEY | Yes |  |
| `pTien_tra_truoc_nt` | MONEY | Yes |  |

---

## Other Procedures

### asSOSaveCACT4SO

- **Class:** AsSOSaveCACT4SO
- **Description:** :	Post chứng từ thanh toán (Thu/Báo có) từ phân hệ bán hàng - Ban ghi chi tiet
- **SQL File:** `asSOSaveCACT4SO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pPs_co_nt` | decimal(19 | Yes |  |
| `pPs_co` | decimal(19 | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSOSaveCAPH4SO

- **Class:** AsSOSaveCAPH4SO
- **Description:** :	Post chứng từ thanh toán (Thu/Báo có) từ phân hệ bán hàng
- **SQL File:** `asSOSaveCAPH4SO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) (output) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(128) | Yes |  |
| `pNguoi_gd` | nvarchar(50) | Yes |  |
| `pDien_giai` | nvarchar(128) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |

---


## Related Tables

*(Cần bổ sung danh sách bảng liên quan)*


---

## Related Documentation

| Document | Description |
|----------|-------------|
| [Module Overview](./README.md) | Tổng quan module |
| [Data Model](./README.md#data-model) | Mô hình dữ liệu |
| [Business Rules](./README.md#business-rules) | Quy tắc nghiệp vụ |

## Cross-Module References

| Module | Relationship |
|--------|--------------|
| [GL](../GL/) | Posting to General Ledger |
| [AR](../AR/) | Invoice creation |
| [IN](../IN/) | Goods shipment |
| [SI](../SI/) | Master data reference |

---

*End of SO Procedures Documentation*
