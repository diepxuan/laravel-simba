# PO Procedures (Purchase Order (Mua hàng))

*Generated on 2026-03-19 14:55:40*

Tổng số procedures: **120**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 22 |
| Update | 11 |
| Delete | 21 |
| Get | 26 |
| Filter | 8 |
| Report | 24 |
| Other | 8 |

## Insert Procedures

### asPOInsCP2

- **Class:** AsPOInsCP2
- **Description:** Stored procedure asPOInsCP2
- **SQL File:** `asPOInsCP2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |
| `pTen_cp` | nvarchar(100) | Yes |  |
| `pTt_pb` | nvarchar(1) | Yes |  |
| `pTien_cp_nt` | decimal(19 | Yes |  |
| `pTien_cp` | decimal(19 | Yes |  |
| `pTs_gtgt` | decimal(19 | Yes |  |
| `pThue_gtgt_nt` | decimal(19 | Yes |  |
| `pThue_gtgt` | decimal(19 | Yes |  |
| `pTt_nt` | decimal(19 | Yes |  |
| `pTt` | decimal(19 | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsCP3

- **Class:** AsPOInsCP3
- **Description:** Stored procedure asPOInsCP3
- **SQL File:** `asPOInsCP3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |
| `pTen_cp` | nvarchar(100) | Yes |  |
| `pTt_pb` | nvarchar(1) | Yes |  |
| `pTien_cp_nt` | decimal(19 | Yes |  |
| `pTien_cp` | decimal(19 | Yes |  |
| `pTs_gtgt` | decimal(19 | Yes |  |
| `pThue_gtgt_nt` | decimal(19 | Yes |  |
| `pThue_gtgt` | decimal(19 | Yes |  |
| `pTt_nt` | decimal(19 | Yes |  |
| `pTt` | decimal(19 | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsCP4

- **Class:** AsPOInsCP4
- **Description:** Stored procedure asPOInsCP4
- **SQL File:** `asPOInsCP4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |
| `pTen_cp` | nvarchar(100) | Yes |  |
| `pTt_pb` | nvarchar(1) | Yes |  |
| `pTien_cp_nt` | decimal(19 | Yes |  |
| `pTien_cp` | decimal(19 | Yes |  |
| `pTs_gtgt` | decimal(19 | Yes |  |
| `pThue_gtgt_nt` | decimal(19 | Yes |  |
| `pThue_gtgt` | decimal(19 | Yes |  |
| `pTt_nt` | decimal(19 | Yes |  |
| `pTt` | decimal(19 | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsCT0

- **Class:** AsPOInsCT0
- **Description:** Stored procedure asPOInsCT0
- **SQL File:** `asPOInsCT0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pStt_rec_dhb` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dhb` | NVARCHAR(3) | Yes |  |
| `pSo_dhb` | NVARCHAR(12) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT1

- **Class:** AsPOInsCT1
- **Description:** Stored procedure asPOInsCT1
- **SQL File:** `asPOInsCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pdn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pdn` | NVARCHAR(3) | Yes |  |
| `pSo_pdn` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt0` | DECIMAL(19 | Yes |  |
| `pGia0` | DECIMAL(19 | Yes |  |
| `pTien_nt0` | DECIMAL(19 | Yes |  |
| `pTien0` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT2

- **Class:** AsPOInsCT2
- **Description:** Stored procedure asPOInsCT2
- **SQL File:** `asPOInsCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pdn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pdn` | NVARCHAR(3) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_pdn` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt0` | DECIMAL(19 | Yes |  |
| `pGia0` | DECIMAL(19 | Yes |  |
| `pTien_nt0` | DECIMAL(19 | Yes |  |
| `pTien0` | DECIMAL(19 | Yes |  |
| `pCp_nt` | DECIMAL(19 | Yes |  |
| `pCp` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT3

- **Class:** AsPOInsCT3
- **Description:** Stored procedure asPOInsCT3
- **SQL File:** `asPOInsCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pn` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pdn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pdn` | NVARCHAR(3) | Yes |  |
| `pSo_pn` | NVARCHAR(12) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_pdn` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pTk_thue_nk` | NVARCHAR(20) | Yes |  |
| `pTk_thue_ttdb` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt0` | DECIMAL(19 | Yes |  |
| `pGia0` | DECIMAL(19 | Yes |  |
| `pTien_nt0` | DECIMAL(19 | Yes |  |
| `pTien0` | DECIMAL(19 | Yes |  |
| `pTs_nk` | DECIMAL(19 | Yes |  |
| `pThue_nk_nt` | DECIMAL(19 | Yes |  |
| `pThue_nk` | DECIMAL(19 | Yes |  |
| `pTs_ttdb` | DECIMAL(19 | Yes |  |
| `pThue_ttdb_nt` | DECIMAL(19 | Yes |  |
| `pThue_ttdb` | DECIMAL(19 | Yes |  |
| `pCp_nt` | DECIMAL(19 | Yes |  |
| `pCp` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pCk_nt` | DECIMAL(19 | Yes |  |
| `pCk` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT4

- **Class:** AsPOInsCT4
- **Description:** Stored procedure asPOInsCT4
- **SQL File:** `asPOInsCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_hd` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pn` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pdn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pdn` | NVARCHAR(3) | Yes |  |
| `pSo_hd` | NVARCHAR(12) | Yes |  |
| `pSo_pn` | NVARCHAR(12) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_pdn` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTien_nt0` | DECIMAL(19 | Yes |  |
| `pTien0` | DECIMAL(19 | Yes |  |
| `pCp_nt` | DECIMAL(19 | Yes |  |
| `pCp` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT5

- **Class:** AsPOInsCT5
- **Description:** Stored procedure asPOInsCT5
- **SQL File:** `asPOInsCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_hd` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pn` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pSo_hd` | NVARCHAR(12) | Yes |  |
| `pSo_pn` | NVARCHAR(12) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_dt` | NVARCHAR(20) | Yes |  |
| `pTk_gv` | NVARCHAR(20) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_tl` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pMa_thue` | NVARCHAR(2) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT6

- **Class:** AsPOInsCT6
- **Description:** Stored procedure asPOInsCT6
- **SQL File:** `asPOInsCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pTk_no` | NVARCHAR(20) | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pMa_ku` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsCT8

- **Class:** AsPOInsCT8
- **Description:** Stored procedure asPOInsCT8
- **SQL File:** `asPOInsCT8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pTk_thue` | NVARCHAR(20) | Yes |  |
| `pTk_thue_nk` | NVARCHAR(20) | Yes |  |
| `pTk_thue_ttdb` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt0` | DECIMAL(19 | Yes |  |
| `pGia0` | DECIMAL(19 | Yes |  |
| `pTien_nt0` | DECIMAL(19 | Yes |  |
| `pTien0` | DECIMAL(19 | Yes |  |
| `pTs_nk` | DECIMAL(19 | Yes |  |
| `pThue_nk_nt` | DECIMAL(19 | Yes |  |
| `pThue_nk` | DECIMAL(19 | Yes |  |
| `pTs_ttdb` | DECIMAL(19 | Yes |  |
| `pThue_ttdb_nt` | DECIMAL(19 | Yes |  |
| `pThue_ttdb` | DECIMAL(19 | Yes |  |
| `pCp_nt` | DECIMAL(19 | Yes |  |
| `pCp` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTs_gtgt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt_nt` | DECIMAL(19 | Yes |  |
| `pThue_gtgt` | DECIMAL(19 | Yes |  |
| `pTt_nt` | DECIMAL(19 | Yes |  |
| `pTt` | DECIMAL(19 | Yes |  |
| `pStt_rec_pn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pn` | NVARCHAR(3) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_dh` | NVARCHAR(3) | Yes |  |
| `pStt_rec_pdn` | NVARCHAR(20) | Yes |  |
| `pStt_rec0_pdn` | NVARCHAR(3) | Yes |  |
| `pSo_pn` | NVARCHAR(12) | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pSo_pdn` | NVARCHAR(12) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asPOInsDMCP

- **Class:** AsPOInsDMCP
- **Description:** Stored procedure asPOInsDMCP
- **SQL File:** `asPOInsDMCP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |
| `pTen_cp` | nvarchar(100) | Yes |  |
| `pTt_pb` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsDMTT

- **Class:** AsPOInsDMTT
- **Description:** Stored procedure asPOInsDMTT
- **SQL File:** `asPOInsDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pma_tt_po` | nvarchar(8) | Yes |  |
| `pMo_ta` | nvarchar(50) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pkSd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsDmGiaMua

- **Class:** AsPOInsDmGiaMua
- **Description:** Stored procedure asPOInsDmGiaMua
- **SQL File:** `asPOInsDmGiaMua.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pGia_nt0` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH0

- **Class:** AsPOInsPH0
- **Description:** Stored procedure asPOInsPH0
- **SQL File:** `asPOInsPH0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pNguoi_dn` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pHan_giao` | smalldatetime | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pTao_tu_dhb` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH1

- **Class:** AsPOInsPH1
- **Description:** Stored procedure asPOInsPH1
- **SQL File:** `asPOInsPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH2

- **Class:** AsPOInsPH2
- **Description:** Stored procedure asPOInsPH2
- **SQL File:** `asPOInsPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_gg` | decimal(19 | Yes |  |
| `pT_gg_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pTao_tu_dh` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH3

- **Class:** AsPOInsPH3
- **Description:** Stored procedure asPOInsPH3
- **SQL File:** `asPOInsPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMau_hd` | nvarchar(1) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue_nk_nt` | decimal(19 | Yes |  |
| `pT_thue_nk` | decimal(19 | Yes |  |
| `pT_thue_ttdb_nt` | decimal(19 | Yes |  |
| `pT_thue_ttdb` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pTl_ck_hd` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_thue_nk` | bit | Yes |  |
| `pSua_thue_ttdb` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pTao_tu_pn` | bit | Yes |  |
| `pTao_tu_dh` | bit | Yes |  |
| `pTs_nk` | decimal (19 | Yes |  |
| `pTs_ttdb` | decimal (19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH4

- **Class:** AsPOInsPH4
- **Description:** Stored procedure asPOInsPH4
- **SQL File:** `asPOInsPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH5

- **Class:** AsPOInsPH5
- **Description:** Stored procedure asPOInsPH5
- **SQL File:** `asPOInsPH5.sql`

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
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pTen_kh_vat` | nvarchar(100) | Yes |  |
| `pDia_chi_vat` | nvarchar(255) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pHttt` | nvarchar(50) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pGia_dd` | BIT | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH6

- **Class:** AsPOInsPH6
- **Description:** Stored procedure asPOInsPH6
- **SQL File:** `asPOInsPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOInsPH8

- **Class:** AsPOInsPH8
- **Description:** Stored procedure asPOInsPH8
- **SQL File:** `asPOInsPH8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMau_hd` | nvarchar(1) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue_nk_nt` | decimal(19 | Yes |  |
| `pT_thue_nk` | decimal(19 | Yes |  |
| `pT_thue_ttdb_nt` | decimal(19 | Yes |  |
| `pT_thue_ttdb` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_gg` | decimal(19 | Yes |  |
| `pT_gg_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(18 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_thue_nk` | bit | Yes |  |
| `pSua_thue_ttdb` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pTao_tu_pn` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Update Procedures

### asPOLookupDhPn

- **Class:** AsPOLookupDhPn
- **Description:** Stored procedure asPOLookupDhPn
- **SQL File:** `asPOLookupDhPn.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOLookupDn4Dh

- **Class:** AsPOLookupDn4Dh
- **Description:** Stored procedure asPOLookupDn4Dh
- **SQL File:** `asPOLookupDn4Dh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOUpdDMCP

- **Class:** AsPOUpdDMCP
- **Description:** Stored procedure asPOUpdDMCP
- **SQL File:** `asPOUpdDMCP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |
| `pTen_cp` | nvarchar(100) | Yes |  |
| `pTt_pb` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdDMTT

- **Class:** AsPOUpdDMTT
- **Description:** Stored procedure asPOUpdDMTT
- **SQL File:** `asPOUpdDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pma_tt_po` | nvarchar(8) | Yes |  |
| `pMo_ta` | nvarchar(50) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pkSd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdDmGiaMua

- **Class:** AsPOUpdDmGiaMua
- **Description:** Stored procedure asPOUpdDmGiaMua
- **SQL File:** `asPOUpdDmGiaMua.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pGia_nt0` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH1

- **Class:** AsPOUpdPH1
- **Description:** Stored procedure asPOUpdPH1
- **SQL File:** `asPOUpdPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH3

- **Class:** AsPOUpdPH3
- **Description:** Stored procedure asPOUpdPH3
- **SQL File:** `asPOUpdPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pmau_hd` | nvarchar(1) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue_nk_nt` | decimal(19 | Yes |  |
| `pT_thue_nk` | decimal(19 | Yes |  |
| `pT_thue_ttdb_nt` | decimal(19 | Yes |  |
| `pT_thue_ttdb` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pTl_ck_hd` | decimal(19 | Yes |  |
| `pT_ck` | decimal(19 | Yes |  |
| `pT_ck_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_thue_nk` | bit | Yes |  |
| `pSua_thue_ttdb` | bit | Yes |  |
| `pSua_Tt` | bit | Yes |  |
| `pTao_tu_pn` | bit | Yes |  |
| `pTao_tu_dh` | bit | Yes |  |
| `pTs_nk` | decimal (19 | Yes |  |
| `pTs_ttdb` | decimal (19 | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH4

- **Class:** AsPOUpdPH4
- **Description:** Stored procedure asPOUpdPH4
- **SQL File:** `asPOUpdPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH5

- **Class:** AsPOUpdPH5
- **Description:** Stored procedure asPOUpdPH5
- **SQL File:** `asPOUpdPH5.sql`

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
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pGia_dd` | BIT | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH6

- **Class:** AsPOUpdPH6
- **Description:** Stored procedure asPOUpdPH6
- **SQL File:** `asPOUpdPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pKht_tain` | BIT | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pTk_thue` | nvarchar(20) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOUpdPH8

- **Class:** AsPOUpdPH8
- **Description:** Stored procedure asPOUpdPH8
- **SQL File:** `asPOUpdPH8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMau_hd` | nvarchar(1) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pSo_seri` | nvarchar(12) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNgay_pn` | smalldatetime | Yes |  |
| `pSo_pn` | nvarchar(12) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt0` | decimal(19 | Yes |  |
| `pT_tien0` | decimal(19 | Yes |  |
| `pT_thue_nk_nt` | decimal(19 | Yes |  |
| `pT_thue_nk` | decimal(19 | Yes |  |
| `pT_thue_ttdb_nt` | decimal(19 | Yes |  |
| `pT_thue_ttdb` | decimal(19 | Yes |  |
| `pT_cp_nt` | decimal(19 | Yes |  |
| `pT_cp` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_gg` | decimal(19 | Yes |  |
| `pT_gg_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(18 | Yes |  |
| `pSua_tien` | bit | Yes |  |
| `pSua_thue` | bit | Yes |  |
| `pSua_thue_nk` | bit | Yes |  |
| `pSua_thue_ttdb` | bit | Yes |  |
| `pSua_tt` | bit | Yes |  |
| `pTao_tu_pn` | bit | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Delete Procedures

### asPODelCP2

- **Class:** AsPODelCP2
- **Description:** Stored procedure asPODelCP2
- **SQL File:** `asPODelCP2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCP3

- **Class:** AsPODelCP3
- **Description:** Stored procedure asPODelCP3
- **SQL File:** `asPODelCP3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCP4

- **Class:** AsPODelCP4
- **Description:** Stored procedure asPODelCP4
- **SQL File:** `asPODelCP4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCP8

- **Class:** AsPODelCP8
- **Description:** Stored procedure asPODelCP8
- **SQL File:** `asPODelCP8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT0

- **Class:** AsPODelCT0
- **Description:** Stored procedure asPODelCT0
- **SQL File:** `asPODelCT0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT1

- **Class:** AsPODelCT1
- **Description:** Stored procedure asPODelCT1
- **SQL File:** `asPODelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT2

- **Class:** AsPODelCT2
- **Description:** Stored procedure asPODelCT2
- **SQL File:** `asPODelCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT3

- **Class:** AsPODelCT3
- **Description:** Stored procedure asPODelCT3
- **SQL File:** `asPODelCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT4

- **Class:** AsPODelCT4
- **Description:** Stored procedure asPODelCT4
- **SQL File:** `asPODelCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT5

- **Class:** AsPODelCT5
- **Description:** Stored procedure asPODelCT5
- **SQL File:** `asPODelCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT6

- **Class:** AsPODelCT6
- **Description:** Stored procedure asPODelCT6
- **SQL File:** `asPODelCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelCT8

- **Class:** AsPODelCT8
- **Description:** Stored procedure asPODelCT8
- **SQL File:** `asPODelCT8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelDMCP

- **Class:** AsPODelDMCP
- **Description:** Stored procedure asPODelDMCP
- **SQL File:** `asPODelDMCP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_cp` | nvarchar(20) | Yes |  |

---

### asPODelDMTT

- **Class:** AsPODelDMTT
- **Description:** Stored procedure asPODelDMTT
- **SQL File:** `asPODelDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_tt_po` | nvarchar(8) | Yes |  |

---

### asPODelDmGiaMua

- **Class:** AsPODelDmGiaMua
- **Description:** Stored procedure asPODelDmGiaMua
- **SQL File:** `asPODelDmGiaMua.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pNgay_ad` | SMALLDATETIME | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |

---

### asPODelPH0

- **Class:** AsPODelPH0
- **Description:** Stored procedure asPODelPH0
- **SQL File:** `asPODelPH0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPODelPH1

- **Class:** AsPODelPH1
- **Description:** Stored procedure asPODelPH1
- **SQL File:** `asPODelPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asPODelPH2

- **Class:** AsPODelPH2
- **Description:** Stored procedure asPODelPH2
- **SQL File:** `asPODelPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asPODelPH3

- **Class:** AsPODelPH3
- **Description:** Stored procedure asPODelPH3
- **SQL File:** `asPODelPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asPODelPH4

- **Class:** AsPODelPH4
- **Description:** Stored procedure asPODelPH4
- **SQL File:** `asPODelPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asPODelPH8

- **Class:** AsPODelPH8
- **Description:** Stored procedure asPODelPH8
- **SQL File:** `asPODelPH8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

## Get Procedures

### asPOGetCA4PO

- **Class:** AsPOGetCA4PO
- **Description:** :	Lấy thông tin chứng từ thanh toán (Chi/Báo nợ) từ phân hệ mua hàng
- **SQL File:** `asPOGetCA4PO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

### asPOGetCP2

- **Class:** AsPOGetCP2
- **Description:** Stored procedure asPOGetCP2
- **SQL File:** `asPOGetCP2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetCP3

- **Class:** AsPOGetCP3
- **Description:** Stored procedure asPOGetCP3
- **SQL File:** `asPOGetCP3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetCP4

- **Class:** AsPOGetCP4
- **Description:** Stored procedure asPOGetCP4
- **SQL File:** `asPOGetCP4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetCP8

- **Class:** AsPOGetCP8
- **Description:** Stored procedure asPOGetCP8
- **SQL File:** `asPOGetCP8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetCT0

- **Class:** AsPOGetCT0
- **Description:** Stored procedure asPOGetCT0
- **SQL File:** `asPOGetCT0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT1

- **Class:** AsPOGetCT1
- **Description:** Stored procedure asPOGetCT1
- **SQL File:** `asPOGetCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStt_rec0` | NVARCHAR(3) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT2

- **Class:** AsPOGetCT2
- **Description:** Stored procedure asPOGetCT2
- **SQL File:** `asPOGetCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT2_SLM

- **Class:** AsPOGetCT2_SLM
- **Description:** Stored procedure asPOGetCT2_SLM
- **SQL File:** `asPOGetCT2_SLM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetCT3

- **Class:** AsPOGetCT3
- **Description:** Stored procedure asPOGetCT3
- **SQL File:** `asPOGetCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '111xPO30000013779139') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT5

- **Class:** AsPOGetCT5
- **Description:** Stored procedure asPOGetCT5
- **SQL File:** `asPOGetCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT6

- **Class:** AsPOGetCT6
- **Description:** Stored procedure asPOGetCT6
- **SQL File:** `asPOGetCT6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCT8

- **Class:** AsPOGetCT8
- **Description:** Stored procedure asPOGetCT8
- **SQL File:** `asPOGetCT8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetCt4

- **Class:** AsPOGetCt4
- **Description:** Stored procedure asPOGetCt4
- **SQL File:** `asPOGetCt4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asPOGetDMCP

- **Class:** AsPOGetDMCP
- **Description:** Stored procedure asPOGetDMCP
- **SQL File:** `asPOGetDMCP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_cp` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetDMTT

- **Class:** AsPOGetDMTT
- **Description:** Stored procedure asPOGetDMTT
- **SQL File:** `asPOGetDMTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_tt_po` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetDmGiaMua

- **Class:** AsPOGetDmGiaMua
- **Description:** Stored procedure asPOGetDmGiaMua
- **SQL File:** `asPOGetDmGiaMua.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

### asPOGetGiaNhap

- **Class:** AsPOGetGiaNhap
- **Description:** Stored procedure asPOGetGiaNhap
- **SQL File:** `asPOGetGiaNhap.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKieu_lay_gia` | nvarchar(1) | Yes |  |
| `pMa_vt` | varchar(20) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |

---

### asPOGetPH0

- **Class:** AsPOGetPH0
- **Description:** Stored procedure asPOGetPH0
- **SQL File:** `asPOGetPH0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH1

- **Class:** AsPOGetPH1
- **Description:** Stored procedure asPOGetPH1
- **SQL File:** `asPOGetPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH2

- **Class:** AsPOGetPH2
- **Description:** Stored procedure asPOGetPH2
- **SQL File:** `asPOGetPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH3

- **Class:** AsPOGetPH3
- **Description:** Stored procedure asPOGetPH3
- **SQL File:** `asPOGetPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH4

- **Class:** AsPOGetPH4
- **Description:** Stored procedure asPOGetPH4
- **SQL File:** `asPOGetPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH5

- **Class:** AsPOGetPH5
- **Description:** Stored procedure asPOGetPH5
- **SQL File:** `asPOGetPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH6

- **Class:** AsPOGetPH6
- **Description:** Stored procedure asPOGetPH6
- **SQL File:** `asPOGetPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asPOGetPH8

- **Class:** AsPOGetPH8
- **Description:** Stored procedure asPOGetPH8
- **SQL File:** `asPOGetPH8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

## Filter Procedures

### asPOFilt0

- **Class:** AsPOFilt0
- **Description:** Stored procedure asPOFilt0
- **SQL File:** `asPOFilt0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asPOFilt1

- **Class:** AsPOFilt1
- **Description:** Stored procedure asPOFilt1
- **SQL File:** `asPOFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | No |  (default: '1=1') |
| `pKeyCt` | nvarchar(1000) | No |  (default: ' ma_kho like ''%CT%''') |

---

### asPOFilt2

- **Class:** AsPOFilt2
- **Description:** Stored procedure asPOFilt2
- **SQL File:** `asPOFilt2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asPOFilt3

- **Class:** AsPOFilt3
- **Description:** Stored procedure asPOFilt3
- **SQL File:** `asPOFilt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asPOFilt4

- **Class:** AsPOFilt4
- **Description:** Stored procedure asPOFilt4
- **SQL File:** `asPOFilt4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asPOFilt5

- **Class:** AsPOFilt5
- **Description:** Stored procedure asPOFilt5
- **SQL File:** `asPOFilt5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | No |  (default: '1=1') |
| `pKeyCt` | nvarchar(1000) | No |  (default: '1=1') |

---

### asPOFilt6

- **Class:** AsPOFilt6
- **Description:** Stored procedure asPOFilt6
- **SQL File:** `asPOFilt6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asPOFilt8

- **Class:** AsPOFilt8
- **Description:** Stored procedure asPOFilt8
- **SQL File:** `asPOFilt8.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

## Report Procedures

### asPORptBCPT011

- **Class:** AsPORptBCPT011
- **Description:** Stored procedure asPORptBCPT011
- **SQL File:** `asPORptBCPT011.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pPOct1` | NVARCHAR(12) | No |  (default: '') |
| `pPOct2` | NVARCHAR(12) | No |  (default: '') |
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
| `pma_tt_po` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '') |

---

### asPORptBCPT012

- **Class:** AsPORptBCPT012
- **Description:** Stored procedure asPORptBCPT012
- **SQL File:** `asPORptBCPT012.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pPOct1` | NVARCHAR(12) | No |  (default: '') |
| `pPOct2` | NVARCHAR(12) | No |  (default: '') |
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
| `pma_tt_po` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '') |

---

### asPORptBCPT021

- **Class:** AsPORptBCPT021
- **Description:** Stored procedure asPORptBCPT021
- **SQL File:** `asPORptBCPT021.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pPOct1` | NVARCHAR(12) | No |  (default: '') |
| `pPOct2` | NVARCHAR(12) | No |  (default: '') |
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
| `pma_tt_po` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '') |

---

### asPORptBCPT022

- **Class:** AsPORptBCPT022
- **Description:** Stored procedure asPORptBCPT022
- **SQL File:** `asPORptBCPT022.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pPOct1` | NVARCHAR(12) | No |  (default: '') |
| `pPOct2` | NVARCHAR(12) | No |  (default: '') |
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
| `pma_tt_po` | NVARCHAR(20) | No |  (default: '') |
| `pStatus` | NVARCHAR(1) | No |  (default: '5') |

---

### asPORptBCPT03

- **Class:** AsPORptBCPT03
- **Description:** Stored procedure asPORptBCPT03
- **SQL File:** `asPORptBCPT03.sql`

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
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_HTTT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_tt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pTra_lai` | BIT | No |  (default: 1) |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_VT') |

---

### asPORptBK01

- **Class:** AsPORptBK01
- **Description:** Stored procedure asPORptBK01
- **SQL File:** `asPORptBK01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTrang_thai` | NVARCHAR(3) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Phi` | NVARCHAR(20) | No |  (default: '') |

---

### asPORptBK02

- **Class:** AsPORptBK02
- **Description:** Stored procedure asPORptBK02
- **SQL File:** `asPORptBK02.sql`

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
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pGroupType` | NVARCHAR(128) | No |  (default: 'MA_KH') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Phi` | NVARCHAR(20) | No |  (default: '') |

---

### asPORptBK03

- **Class:** AsPORptBK03
- **Description:** Stored procedure asPORptBK03
- **SQL File:** `asPORptBK03.sql`

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
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pGroupType` | NVARCHAR(128) | No |  (default: 'MA_KH') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Phi` | NVARCHAR(20) | No |  (default: '') |

---

### asPORptBK031

- **Class:** AsPORptBK031
- **Description:** Stored procedure asPORptBK031
- **SQL File:** `asPORptBK031.sql`

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
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |

---

### asPORptBK04

- **Class:** AsPORptBK04
- **Description:** Stored procedure asPORptBK04
- **SQL File:** `asPORptBK04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |

---

### asPORptBK05

- **Class:** AsPORptBK05
- **Description:** Stored procedure asPORptBK05
- **SQL File:** `asPORptBK05.sql`

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
| `pMa_Phi` | nvarchar(20) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_spct` | nvarchar(20) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |

---

### asPORptBK06

- **Class:** AsPORptBK06
- **Description:** Stored procedure asPORptBK06
- **SQL File:** `asPORptBK06.sql`

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
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pNhom_theo` | nvarchar(2) | No |  (default: '' -- 1- nhom tho NCC/ null - ko nhom theo NCC) |

---

### asPORptBK07

- **Class:** AsPORptBK07
- **Description:** Stored procedure asPORptBK07
- **SQL File:** `asPORptBK07.sql`

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
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pSo_DH` | nvarchar(12) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pGroupType` | nvarchar(128) | No |  (default: 'MA_KH') |

---

### asPORptF5Bcpt03

- **Class:** AsPORptF5Bcpt03
- **Description:** Stored procedure asPORptF5Bcpt03
- **SQL File:** `asPORptF5Bcpt03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kho` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Group` | NVARCHAR(20) | Yes |  |
| `pMa_Detail` | NVARCHAR(20) | Yes |  |
| `pGroup` | NVARCHAR(20) | Yes |  |
| `pDetail` | NVARCHAR(20) | Yes |  |
| `pTra_lai` | BIT | Yes |  |

---

### asPORptF5TH0

- **Class:** AsPORptF5TH0
- **Description:** Stored procedure asPORptF5TH0
- **SQL File:** `asPORptF5TH0.sql`

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
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pTrang_thai` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |

---

### asPORptF5TH02

- **Class:** AsPORptF5TH02
- **Description:** : f5	Tổng hợp mua hàng theo kỳ
- **SQL File:** `asPORptF5TH02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pLoai` | NVARCHAR(5) | Yes |  |
| `pMa_ct` | NVARCHAR(10) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | Yes |  |

---

### asPORptTH01

- **Class:** AsPORptTH01
- **Description:** Stored procedure asPORptTH01
- **SQL File:** `asPORptTH01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_loai` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pTrang_thai` | NVARCHAR(3) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |

---

### asPORptTH02

- **Class:** AsPORptTH02
- **Description:** Stored procedure asPORptTH02
- **SQL File:** `asPORptTH02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pLoai` | NVARCHAR(5) | Yes |  |
| `pMa_ct` | NVARCHAR(10) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pMa_nt` | NVARCHAR(3) | No |  (default: 'VND') |
| `pIs_nt` | BIT | No |  (default: 0) |

---

### asPORptTH03

- **Class:** AsPORptTH03
- **Description:** Stored procedure asPORptTH03
- **SQL File:** `asPORptTH03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_loai` | nvarchar(8) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: '') |
| `pTrang_thai` | nvarchar(3) | No |  (default: '') |
| `pMa_nhhd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_httt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_TT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |

---

### asPORptTH04

- **Class:** AsPORptTH04
- **Description:** Stored procedure asPORptTH04
- **SQL File:** `asPORptTH04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_loai` | nvarchar(8) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asPORptTH05

- **Class:** AsPORptTH05
- **Description:** Stored procedure asPORptTH05
- **SQL File:** `asPORptTH05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asPORptTH06

- **Class:** AsPORptTH06
- **Description:** Stored procedure asPORptTH06
- **SQL File:** `asPORptTH06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_loai` | nvarchar(8) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_TKVT` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

### asPORptTH07

- **Class:** AsPORptTH07
- **Description:** Stored procedure asPORptTH07
- **SQL File:** `asPORptTH07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pGroup` | nvarchar(20) | No |  (default: 'MA_KH') |
| `pDetail` | nvarchar(20) | No |  (default: 'MA_VT') |
| `pCtu1` | nvarchar(8) | No |  (default: '') |
| `pCtu2` | nvarchar(8) | No |  (default: '') |
| `pMa_NhNcc` | nvarchar(8) | No |  (default: '') |
| `pMa_PLNCC1` | nvarchar(8) | No |  (default: '') |
| `pMa_PLNCC2` | nvarchar(8) | No |  (default: '') |
| `pMa_PLNCC3` | nvarchar(8) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_Ncc` | nvarchar(20) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_Ncco` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_spct` | nvarchar(20) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pNhom_VT` | nvarchar(8) | No |  (default: '') |
| `pMa_httt` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asPORptTH08

- **Class:** AsPORptTH08
- **Description:** Stored procedure asPORptTH08
- **SQL File:** `asPORptTH08.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_loai` | nvarchar(8) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_hd` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

## Other Procedures

### asPOLookupHd4Px

- **Class:** AsPOLookupHd4Px
- **Description:** Stored procedure asPOLookupHd4Px
- **SQL File:** `asPOLookupHd4Px.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOLookupPn4Px

- **Class:** AsPOLookupPn4Px
- **Description:** Stored procedure asPOLookupPn4Px
- **SQL File:** `asPOLookupPn4Px.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOLookupPnHd

- **Class:** AsPOLookupPnHd
- **Description:** Stored procedure asPOLookupPnHd
- **SQL File:** `asPOLookupPnHd.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOLookupPnHd4PO4

- **Class:** AsPOLookupPnHd4PO4
- **Description:** Stored procedure asPOLookupPnHd4PO4
- **SQL File:** `asPOLookupPnHd4PO4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOLookupSO14PO0

- **Class:** AsPOLookupSO14PO0
- **Description:** Stored procedure asPOLookupSO14PO0
- **SQL File:** `asPOLookupSO14PO0.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pKey` | nvarchar(1000) | Yes |  |

---

### asPOReCalPO54Relate

- **Class:** AsPOReCalPO54Relate
- **Description:** Stored procedure asPOReCalPO54Relate
- **SQL File:** `asPOReCalPO54Relate.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asPOSaveCACT4PO

- **Class:** AsPOSaveCACT4PO
- **Description:** :	Post chứng từ thanh toán (Chi/Báo nợ) từ phân hệ mua hàng - Ban ghi chi tiet
- **SQL File:** `asPOSaveCACT4PO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pPs_no_nt` | decimal(19 | Yes |  |
| `pPs_no` | decimal(19 | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asPOSaveCAPH4PO

- **Class:** AsPOSaveCAPH4PO
- **Description:** :	Post chứng từ thanh toán (Chi/Báo nợ) từ phân hệ mua hàng
- **SQL File:** `asPOSaveCAPH4PO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) (output) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pDia_chi` | nvarchar(128) | Yes |  |
| `pNguoi_gd` | nvarchar(50) | Yes |  |
| `pDien_giai` | nvarchar(128) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pTk_co` | nvarchar(20) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
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
| [AP](../AP/) | Invoice creation |
| [IN](../IN/) | Goods receipt |
| [SI](../SI/) | Master data reference |

---

*End of PO Procedures Documentation*
