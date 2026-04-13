# IN Procedures (Inventory (Kho))

*Generated on 2026-03-19 14:55:40*

Tổng số procedures: **119**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 23 |
| Update | 16 |
| Delete | 23 |
| Get | 20 |
| Filter | 6 |
| Report | 30 |
| Other | 1 |

## Insert Procedures

### asINInsCDVT

- **Class:** AsINInsCDVT
- **Description:** Stored procedure asINInsCDVT
- **SQL File:** `asINInsCDVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsCT1

- **Class:** AsINInsCT1
- **Description:** Stored procedure asINInsCT1
- **SQL File:** `asINInsCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pStt_rec_lsx` | nvarchar(20) | Yes |  |
| `pStt_rec0_lsx` | nvarchar(3) | Yes |  |
| `pSo_lsx` | NVARCHAR(12) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pTen_vt` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_co` | nvarchar(20) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pSo_luong_qd` | decimal(19 | Yes |  |
| `pGia_nt` | decimal(19 | Yes |  |
| `pGia` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsCT2

- **Class:** AsINInsCT2
- **Description:** Stored procedure asINInsCT2
- **SQL File:** `asINInsCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pStt_rec_lsx` | nvarchar(20) | Yes |  |
| `pStt_rec0_lsx` | nvarchar(3) | Yes |  |
| `pSo_lsx` | NVARCHAR(12) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pTen_vt` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pSo_luong_qd` | decimal(19 | Yes |  |
| `pGia_nt` | decimal(19 | Yes |  |
| `pGia` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsCT3

- **Class:** AsINInsCT3
- **Description:** Stored procedure asINInsCT3
- **SQL File:** `asINInsCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_khon` | NVARCHAR(8) | Yes |  |
| `pMa_khox` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_vitrin` | NVARCHAR(8) | Yes |  |
| `pMa_vitrix` | NVARCHAR(8) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pMa_nx` | NVARCHAR(20) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_no` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asINInsCT5

- **Class:** AsINInsCT5
- **Description:** Stored procedure asINInsCT5
- **SQL File:** `asINInsCT5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_nx` | NVARCHAR(20) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pTk_no` | NVARCHAR(20) | Yes |  |
| `pTk_cp` | NVARCHAR(20) | Yes |  |
| `pKy_pb` | INT | Yes |  |
| `pSo_ky` | INT | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pMa_bpsd` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asINInsCT6D

- **Class:** AsINInsCT6D
- **Description:** Stored procedure asINInsCT6D
- **SQL File:** `asINInsCT6D.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_bo` | NVARCHAR(20) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nx` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asINInsCT6M

- **Class:** AsINInsCT6M
- **Description:** Stored procedure asINInsCT6M
- **SQL File:** `asINInsCT6M.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pTen_vt` | NVARCHAR(100) | Yes |  |
| `pDvt` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nx` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pSo_luong` | DECIMAL(19 | Yes |  |
| `pSo_luong_qd` | DECIMAL(19 | Yes |  |
| `pGia_nt` | DECIMAL(19 | Yes |  |
| `pGia` | DECIMAL(19 | Yes |  |
| `pTien_nt` | DECIMAL(19 | Yes |  |
| `pTien` | DECIMAL(19 | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asINInsCT9

- **Class:** AsINInsCT9
- **Description:** Stored procedure asINInsCT9
- **SQL File:** `asINInsCT9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pTen_vt` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_co` | nvarchar(20) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pSl_ton` | decimal(19 | Yes |  |
| `pSl_kk` | decimal(19 | Yes |  |
| `pSl_cl` | decimal(19 | Yes |  |
| `pTien_ss` | decimal(19 | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pCon_tot` | INT | Yes |  |
| `pKem_pc` | INT | Yes |  |
| `pMat_pc` | INT | Yes |  |
| `pGhi_chu` | NVARCHAR(255) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMBARCODE

- **Class:** AsINInsDMBARCODE
- **Description:** Stored procedure asINInsDMBARCODE
- **SQL File:** `asINInsDMBARCODE.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_vach` | nvarchar(128) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMBOM

- **Class:** AsINInsDMBOM
- **Description:** Stored procedure asINInsDMBOM
- **SQL File:** `asINInsDMBOM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_lk` | nvarchar(20) | Yes |  |
| `pTen_lk` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pHe_so` | decimal(19 | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMKHO

- **Class:** AsINInsDMKHO
- **Description:** Stored procedure asINInsDMKHO
- **SQL File:** `asINInsDMKHO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pTen_kho` | nvarchar(50) | Yes |  |
| `pKho_dl` | bit | Yes |  |
| `pTk_dl` | nvarchar(20) | Yes |  |
| `pStt_ntxt` | int | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_lh` | nvarchar(20) | Yes |  |
| `pTel` | nvarchar(50) | Yes |  |
| `pFax` | nvarchar(50) | Yes |  |
| `pEmail` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMLO

- **Class:** AsINInsDMLO
- **Description:** Stored procedure asINInsDMLO
- **SQL File:** `asINInsDMLO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pTen_lo` | nvarchar(50) | Yes |  |
| `pHan_dung` | smalldatetime | Yes |  |
| `pTrang_thai` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMNHVAT

- **Class:** AsINInsDMNHVAT
- **Description:** Stored procedure asINInsDMNHVAT
- **SQL File:** `asINInsDMNHVAT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvat` | nvarchar(8) | Yes |  |
| `pTen_nhvat` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMNHVT

- **Class:** AsINInsDMNHVT
- **Description:** Stored procedure asINInsDMNHVT
- **SQL File:** `asINInsDMNHVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |
| `pTen_nhvt` | nvarchar(50) | Yes |  |
| `pCap` | int | Yes |  |
| `pStt_nhom` | nvarchar(18) | Yes |  |
| `pNhom_me` | nvarchar(8) | Yes |  |
| `pCong_sl` | bit | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_dt` | nvarchar(20) | Yes |  |
| `pTk_dtnb` | nvarchar(20) | Yes |  |
| `pTk_gv` | nvarchar(20) | Yes |  |
| `pTk_tl` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMPLVT

- **Class:** AsINInsDMPLVT
- **Description:** Stored procedure asINInsDMPLVT
- **SQL File:** `asINInsDMPLVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plvt` | nvarchar(8) | Yes |  |
| `pTen_plvt` | nvarchar(50) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMVITRI

- **Class:** AsINInsDMVITRI
- **Description:** Stored procedure asINInsDMVITRI
- **SQL File:** `asINInsDMVITRI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pTen_vitri` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsDMVT

- **Class:** AsINInsDMVT
- **Description:** Stored procedure asINInsDMVT
- **SQL File:** `asINInsDMVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pTen_vt` | nvarchar(100) | Yes |  |
| `pPart_no` | nvarchar(16) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pDvt_ban` | nvarchar(8) | Yes |  |
| `pHs_dvtban` | decimal(19 | Yes |  |
| `pDvt_mua` | nvarchar(8) | Yes |  |
| `pDvdg` | decimal(19 | Yes |  |
| `pQcdg` | nvarchar(150) | Yes |  |
| `pHs_dvtmua` | decimal(19 | Yes |  |
| `pTon_kho` | bit | Yes |  |
| `pGia_ton` | nvarchar(1) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_dt` | nvarchar(20) | Yes |  |
| `pTk_dtnb` | nvarchar(20) | Yes |  |
| `pTk_gv` | nvarchar(20) | Yes |  |
| `pTk_tl` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pTinh_gt` | bit | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |
| `pMa_plvt1` | nvarchar(8) | Yes |  |
| `pMa_plvt2` | nvarchar(8) | Yes |  |
| `pMa_plvt3` | nvarchar(8) | Yes |  |
| `pMa_nhvat` | nvarchar(8) | Yes |  |
| `pSl_min` | decimal(19 | Yes |  |
| `pSl_max` | decimal(19 | Yes |  |
| `pGia_nt0` | decimal(19 | Yes |  |
| `pGia_nt2` | decimal(19 | Yes |  |
| `pTs_nk` | int | Yes |  |
| `pTs_gtgt` | int | Yes |  |
| `pTs_xk` | int | Yes |  |
| `pTs_ttdb` | int | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pCo_ct` | bit | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pNha_sx` | NVARCHAR(100) | Yes |  |
| `pNha_pp` | NVARCHAR(100) | Yes |  |
| `pNuoc_sx` | NVARCHAR(100) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH1

- **Class:** AsINInsPH1
- **Description:** Stored procedure asINInsPH1
- **SQL File:** `asINInsPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPN_GTB` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pGia_thanh` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH2

- **Class:** AsINInsPH2
- **Description:** Stored procedure asINInsPH2
- **SQL File:** `asINInsPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH3

- **Class:** AsINInsPH3
- **Description:** Stored procedure asINInsPH3
- **SQL File:** `asINInsPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pso_pn` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH5

- **Class:** AsINInsPH5
- **Description:** Stored procedure asINInsPH5
- **SQL File:** `asINInsPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPx_gdd` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH6

- **Class:** AsINInsPH6
- **Description:** Stored procedure asINInsPH6
- **SQL File:** `asINInsPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ctn` | smalldatetime | Yes |  |
| `pSo_ctn` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pPN_GTB` | bit | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTk_vt_lrtd` | nvarchar(20) | Yes |  |
| `pTk_lrtd` | nvarchar(20) | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINInsPH9

- **Class:** AsINInsPH9
- **Description:** Stored procedure asINInsPH9
- **SQL File:** `asINInsPH9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pMa_kh1` | nvarchar(50) | Yes |  |
| `pMa_kh2` | nvarchar(50) | Yes |  |
| `pMa_kh3` | nvarchar(50) | Yes |  |
| `pChuc_vu1` | nvarchar(50) | Yes |  |
| `pChuc_vu2` | nvarchar(50) | Yes |  |
| `pChuc_vu3` | nvarchar(50) | Yes |  |
| `pDai_dien1` | nvarchar(50) | Yes |  |
| `pDai_dien2` | nvarchar(50) | Yes |  |
| `pDai_dien3` | nvarchar(50) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pT_sl_ton` | decimal(19 | Yes |  |
| `pT_sl_kk` | decimal(19 | Yes |  |
| `pT_sl_cl` | decimal(19 | Yes |  |
| `pT_tien_ss` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Update Procedures

### asINUpdCDVT

- **Class:** AsINUpdCDVT
- **Description:** Stored procedure asINUpdCDVT
- **SQL File:** `asINUpdCDVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMBARCODE

- **Class:** AsINUpdDMBARCODE
- **Description:** Stored procedure asINUpdDMBARCODE
- **SQL File:** `asINUpdDMBARCODE.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_vach` | nvarchar(128) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMBOM

- **Class:** AsINUpdDMBOM
- **Description:** Stored procedure asINUpdDMBOM
- **SQL File:** `asINUpdDMBOM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_lk` | nvarchar(8) | Yes |  |
| `pTen_lk` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pSo_luong` | decimal(19 | Yes |  |
| `pHe_so` | decimal(19 | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMKHO

- **Class:** AsINUpdDMKHO
- **Description:** Stored procedure asINUpdDMKHO
- **SQL File:** `asINUpdDMKHO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pTen_kho` | nvarchar(50) | Yes |  |
| `pKho_dl` | bit | Yes |  |
| `pTk_dl` | nvarchar(20) | Yes |  |
| `pStt_ntxt` | int | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_lh` | nvarchar(20) | Yes |  |
| `pTel` | nvarchar(50) | Yes |  |
| `pFax` | nvarchar(50) | Yes |  |
| `pEmail` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMLO

- **Class:** AsINUpdDMLO
- **Description:** Stored procedure asINUpdDMLO
- **SQL File:** `asINUpdDMLO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pTen_lo` | nvarchar(50) | Yes |  |
| `pHan_dung` | smalldatetime | Yes |  |
| `pTrang_thai` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMNHVAT

- **Class:** AsINUpdDMNHVAT
- **Description:** Stored procedure asINUpdDMNHVAT
- **SQL File:** `asINUpdDMNHVAT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvat` | nvarchar(8) | Yes |  |
| `pTen_nhvat` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMNHVT

- **Class:** AsINUpdDMNHVT
- **Description:** Stored procedure asINUpdDMNHVT
- **SQL File:** `asINUpdDMNHVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |
| `pTen_nhvt` | nvarchar(50) | Yes |  |
| `pCap` | int | Yes |  |
| `pStt_nhom` | nvarchar(18) | Yes |  |
| `pNhom_me` | nvarchar(8) | Yes |  |
| `pCong_sl` | bit | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_dt` | nvarchar(20) | Yes |  |
| `pTk_dtnb` | nvarchar(20) | Yes |  |
| `pTk_gv` | nvarchar(20) | Yes |  |
| `pTk_tl` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMPLVT

- **Class:** AsINUpdDMPLVT
- **Description:** Stored procedure asINUpdDMPLVT
- **SQL File:** `asINUpdDMPLVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plvt` | nvarchar(8) | Yes |  |
| `pTen_plvt` | nvarchar(50) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMVITRI

- **Class:** AsINUpdDMVITRI
- **Description:** Stored procedure asINUpdDMVITRI
- **SQL File:** `asINUpdDMVITRI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pTen_vitri` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdDMVT

- **Class:** AsINUpdDMVT
- **Description:** Stored procedure asINUpdDMVT
- **SQL File:** `asINUpdDMVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pTen_vt` | nvarchar(100) | Yes |  |
| `pPart_no` | nvarchar(16) | Yes |  |
| `pDvt` | nvarchar(8) | Yes |  |
| `pDvt_ban` | nvarchar(8) | Yes |  |
| `pHs_dvtban` | decimal(19 | Yes |  |
| `pDvt_mua` | nvarchar(8) | Yes |  |
| `pHs_dvtmua` | decimal(19 | Yes |  |
| `pTon_kho` | bit | Yes |  |
| `pGia_ton` | nvarchar(1) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pTk_dt` | nvarchar(20) | Yes |  |
| `pTk_dtnb` | nvarchar(20) | Yes |  |
| `pTk_gv` | nvarchar(20) | Yes |  |
| `pTk_tl` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pTinh_gt` | bit | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |
| `pMa_plvt1` | nvarchar(8) | Yes |  |
| `pMa_plvt2` | nvarchar(8) | Yes |  |
| `pMa_plvt3` | nvarchar(8) | Yes |  |
| `pMa_nhvat` | nvarchar(8) | Yes |  |
| `pSl_min` | decimal(19 | Yes |  |
| `pSl_max` | decimal(19 | Yes |  |
| `pGia_nt0` | decimal(19 | Yes |  |
| `pGia_nt2` | decimal(19 | Yes |  |
| `pTs_nk` | int | Yes |  |
| `pTs_gtgt` | int | Yes |  |
| `pTs_xk` | int | Yes |  |
| `pTs_ttdb` | int | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pCo_ct` | bit | Yes |  |
| `pMa_lo` | nvarchar(10) | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pNha_sx` | NVARCHAR(100) | Yes |  |
| `pNha_pp` | NVARCHAR(100) | Yes |  |
| `pNuoc_sx` | NVARCHAR(100) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH1

- **Class:** AsINUpdPH1
- **Description:** Stored procedure asINUpdPH1
- **SQL File:** `asINUpdPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPN_GTB` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pGia_thanh` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH2

- **Class:** AsINUpdPH2
- **Description:** Stored procedure asINUpdPH2
- **SQL File:** `asINUpdPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH3

- **Class:** AsINUpdPH3
- **Description:** Stored procedure asINUpdPH3
- **SQL File:** `asINUpdPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pso_pn` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH5

- **Class:** AsINUpdPH5
- **Description:** Stored procedure asINUpdPH5
- **SQL File:** `asINUpdPH5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pPx_gdd` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH6

- **Class:** AsINUpdPH6
- **Description:** Stored procedure asINUpdPH6
- **SQL File:** `asINUpdPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ctn` | smalldatetime | Yes |  |
| `pSo_ctn` | nvarchar(12) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pPN_GTB` | bit | Yes |  |
| `pPX_GDD` | bit | Yes |  |
| `pTk_vt_lrtd` | nvarchar(20) | Yes |  |
| `pTk_lrtd` | nvarchar(20) | Yes |  |
| `pT_so_luong` | decimal(19 | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asINUpdPH9

- **Class:** AsINUpdPH9
- **Description:** Stored procedure asINUpdPH9
- **SQL File:** `asINUpdPH9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_nx` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pMa_kh1` | nvarchar(50) | Yes |  |
| `pMa_kh2` | nvarchar(50) | Yes |  |
| `pMa_kh3` | nvarchar(50) | Yes |  |
| `pChuc_vu1` | nvarchar(50) | Yes |  |
| `pChuc_vu2` | nvarchar(50) | Yes |  |
| `pChuc_vu3` | nvarchar(50) | Yes |  |
| `pDai_dien1` | nvarchar(50) | Yes |  |
| `pDai_dien2` | nvarchar(50) | Yes |  |
| `pDai_dien3` | nvarchar(50) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pT_sl_ton` | decimal(19 | Yes |  |
| `pT_sl_kk` | decimal(19 | Yes |  |
| `pT_sl_cl` | decimal(19 | Yes |  |
| `pT_tien_ss` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | bit | Yes |  |
| `pPost2in` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Delete Procedures

### asINDelCDVT

- **Class:** AsINDelCDVT
- **Description:** Stored procedure asINDelCDVT
- **SQL File:** `asINDelCDVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |
| `pTk_vt` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |

---

### asINDelCT1

- **Class:** AsINDelCT1
- **Description:** Stored procedure asINDelCT1
- **SQL File:** `asINDelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelCT2

- **Class:** AsINDelCT2
- **Description:** Stored procedure asINDelCT2
- **SQL File:** `asINDelCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelCT6D

- **Class:** AsINDelCT6D
- **Description:** Stored procedure asINDelCT6D
- **SQL File:** `asINDelCT6D.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelCT6M

- **Class:** AsINDelCT6M
- **Description:** Stored procedure asINDelCT6M
- **SQL File:** `asINDelCT6M.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelCT9

- **Class:** AsINDelCT9
- **Description:** Stored procedure asINDelCT9
- **SQL File:** `asINDelCT9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |

---

### asINDelCt3

- **Class:** AsINDelCt3
- **Description:** Stored procedure asINDelCt3
- **SQL File:** `asINDelCt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelCt5

- **Class:** AsINDelCt5
- **Description:** :
- **SQL File:** `asINDelCt5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asINDelDMBOM

- **Class:** AsINDelDMBOM
- **Description:** Stored procedure asINDelDMBOM
- **SQL File:** `asINDelDMBOM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_lk` | nvarchar(20) | Yes |  |

---

### asINDelDMBarcode

- **Class:** AsINDelDMBarcode
- **Description:** Stored procedure asINDelDMBarcode
- **SQL File:** `asINDelDMBarcode.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_vach` | nvarchar(128) | Yes |  |

---

### asINDelDMKHO

- **Class:** AsINDelDMKHO
- **Description:** Stored procedure asINDelDMKHO
- **SQL File:** `asINDelDMKHO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |

---

### asINDelDMLO

- **Class:** AsINDelDMLO
- **Description:** Stored procedure asINDelDMLO
- **SQL File:** `asINDelDMLO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_lo` | nvarchar(20) | Yes |  |

---

### asINDelDMNHVAT

- **Class:** AsINDelDMNHVAT
- **Description:** Stored procedure asINDelDMNHVAT
- **SQL File:** `asINDelDMNHVAT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvat` | nvarchar(8) | Yes |  |

---

### asINDelDMNHVT

- **Class:** AsINDelDMNHVT
- **Description:** Stored procedure asINDelDMNHVT
- **SQL File:** `asINDelDMNHVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhvt` | nvarchar(8) | Yes |  |

---

### asINDelDMPLVT

- **Class:** AsINDelDMPLVT
- **Description:** Stored procedure asINDelDMPLVT
- **SQL File:** `asINDelDMPLVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plvt` | nvarchar(8) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |

---

### asINDelDMVITRI

- **Class:** AsINDelDMVITRI
- **Description:** Stored procedure asINDelDMVITRI
- **SQL File:** `asINDelDMVITRI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |
| `pMa_vitri` | nvarchar(8) | Yes |  |

---

### asINDelDMVT

- **Class:** AsINDelDMVT
- **Description:** Stored procedure asINDelDMVT
- **SQL File:** `asINDelDMVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |

---

### asINDelPH1

- **Class:** AsINDelPH1
- **Description:** Stored procedure asINDelPH1
- **SQL File:** `asINDelPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asINDelPH2

- **Class:** AsINDelPH2
- **Description:** Stored procedure asINDelPH2
- **SQL File:** `asINDelPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asINDelPH3

- **Class:** AsINDelPH3
- **Description:** Stored procedure asINDelPH3
- **SQL File:** `asINDelPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asINDelPH6

- **Class:** AsINDelPH6
- **Description:** Stored procedure asINDelPH6
- **SQL File:** `asINDelPH6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asINDelPH9

- **Class:** AsINDelPH9
- **Description:** Stored procedure asINDelPH9
- **SQL File:** `asINDelPH9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asINDelPh5

- **Class:** AsINDelPh5
- **Description:** :
- **SQL File:** `asINDelPh5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

## Get Procedures

### asINGetCDVT

- **Class:** AsINGetCDVT
- **Description:** Stored procedure asINGetCDVT
- **SQL File:** `asINGetCDVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pNam` | int | Yes |  |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |

---

### asINGetCT1

- **Class:** AsINGetCT1
- **Description:** Stored procedure asINGetCT1
- **SQL File:** `asINGetCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asINGetCT2

- **Class:** AsINGetCT2
- **Description:** Stored procedure asINGetCT2
- **SQL File:** `asINGetCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asINGetCT6D

- **Class:** AsINGetCT6D
- **Description:** Stored procedure asINGetCT6D
- **SQL File:** `asINGetCT6D.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |

---

### asINGetCT6M

- **Class:** AsINGetCT6M
- **Description:** Stored procedure asINGetCT6M
- **SQL File:** `asINGetCT6M.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |

---

### asINGetCT9

- **Class:** AsINGetCT9
- **Description:** Stored procedure asINGetCT9
- **SQL File:** `asINGetCT9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStt_rec0` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetCt3

- **Class:** AsINGetCt3
- **Description:** Stored procedure asINGetCt3
- **SQL File:** `asINGetCt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '') |

---

### asINGetCt5

- **Class:** AsINGetCt5
- **Description:** :
- **SQL File:** `asINGetCt5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '') |

---

### asINGetDMBARCODE

- **Class:** AsINGetDMBARCODE
- **Description:** Stored procedure asINGetDMBARCODE
- **SQL File:** `asINGetDMBARCODE.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_vt` | nvarchar(20) | No |  (default: null) |

---

### asINGetDMBOM

- **Class:** AsINGetDMBOM
- **Description:** Stored procedure asINGetDMBOM
- **SQL File:** `asINGetDMBOM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_vt` | nvarchar(20) | No |  (default: null) |

---

### asINGetDMLO

- **Class:** AsINGetDMLO
- **Description:** Stored procedure asINGetDMLO
- **SQL File:** `asINGetDMLO.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_lo` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetDMNHVAT

- **Class:** AsINGetDMNHVAT
- **Description:** Stored procedure asINGetDMNHVAT
- **SQL File:** `asINGetDMNHVAT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_nhvat` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetDMPLVT

- **Class:** AsINGetDMPLVT
- **Description:** Stored procedure asINGetDMPLVT
- **SQL File:** `asINGetDMPLVT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_plvt` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |
| `pLoai` | nvarchar(1) | No |  (default: null) |

---

### asINGetDMVITRI

- **Class:** AsINGetDMVITRI
- **Description:** Stored procedure asINGetDMVITRI
- **SQL File:** `asINGetDMVITRI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pStruct` | nvarchar(1) | No |  (default: '0') |
| `pMa_kho` | nvarchar(20) | No |  (default: '') |

---

### asINGetPH1

- **Class:** AsINGetPH1
- **Description:** Stored procedure asINGetPH1
- **SQL File:** `asINGetPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetPH2

- **Class:** AsINGetPH2
- **Description:** Stored procedure asINGetPH2
- **SQL File:** `asINGetPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetPH9

- **Class:** AsINGetPH9
- **Description:** Stored procedure asINGetPH9
- **SQL File:** `asINGetPH9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '') |
| `pStt_rec` | nvarchar(20) | No |  (default: '%') |
| `pMa_ct` | nvarchar(3) | No |  (default: '%') |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetPh3

- **Class:** AsINGetPh3
- **Description:** Stored procedure asINGetPh3
- **SQL File:** `asINGetPh3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '%') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asINGetPh5

- **Class:** AsINGetPh5
- **Description:** :
- **SQL File:** `asINGetPh5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: '%') |
| `pMa_ct` | nvarchar(3) | No |  (default: '') |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asINGetTonVtAll

- **Class:** AsINGetTonVtAll
- **Description:** Stored procedure asINGetTonVtAll
- **SQL File:** `asINGetTonVtAll.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pStt_rec` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(20) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '156') |

---

## Filter Procedures

### asINFilt1

- **Class:** AsINFilt1
- **Description:** Stored procedure asINFilt1
- **SQL File:** `asINFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | No |  (default: ' 1=1 ') |
| `pKeyCt` | nvarchar(1000) | No |  (default: ' ma_spct like ''%AAA%''') |

---

### asINFilt2

- **Class:** AsINFilt2
- **Description:** Stored procedure asINFilt2
- **SQL File:** `asINFilt2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asINFilt3

- **Class:** AsINFilt3
- **Description:** Stored procedure asINFilt3
- **SQL File:** `asINFilt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asINFilt5

- **Class:** AsINFilt5
- **Description:** Stored procedure asINFilt5
- **SQL File:** `asINFilt5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asINFilt6

- **Class:** AsINFilt6
- **Description:** Stored procedure asINFilt6
- **SQL File:** `asINFilt6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCtM` | nvarchar(1000) | Yes |  |
| `pKeyCtD` | nvarchar(1000) | Yes |  |

---

### asINFilt9

- **Class:** AsINFilt9
- **Description:** Stored procedure asINFilt9
- **SQL File:** `asINFilt9.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

## Report Procedures

### asINRptBK01

- **Class:** AsINRptBK01
- **Description:** Stored procedure asINRptBK01
- **SQL File:** `asINRptBK01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pThang` | int | Yes |  |
| `pMa_vt` | nvarchar(20) | Yes |  |
| `pMa_kho` | nvarchar(8) | Yes |  |

---

### asINRptBKN01

- **Class:** AsINRptBKN01
- **Description:** Stored procedure asINRptBKN01
- **SQL File:** `asINRptBKN01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pLoai_pn` | nvarchar(3) | No |  (default: '') |
| `pMa_nx` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptBKN02

- **Class:** AsINRptBKN02
- **Description:** Stored procedure asINRptBKN02
- **SQL File:** `asINRptBKN02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nx` | nvarchar(20) | No |  (default: '') |
| `pSoct1` | nvarchar(8) | No |  (default: '') |
| `pSoct2` | nvarchar(8) | No |  (default: '') |
| `pLoai_pn` | nvarchar(8) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |
| `pMa_NHVT` | nvarchar(8) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptBKN03

- **Class:** AsINRptBKN03
- **Description:** Stored procedure asINRptBKN03
- **SQL File:** `asINRptBKN03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pSoct1` | nvarchar(8) | No |  (default: '') |
| `pSoct2` | nvarchar(8) | No |  (default: '') |
| `pLoai_pn` | nvarchar(8) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_nx` | nvarchar(20) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pMa_NhVT` | nvarchar(8) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '') |
| `pGroupType` | nvarchar(128) | No |  (default: 'MA_VT' -- KH) |

---

### asINRptBKN04

- **Class:** AsINRptBKN04
- **Description:** Stored procedure asINRptBKN04
- **SQL File:** `asINRptBKN04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pSoct1` | NVARCHAR(8) | No |  (default: '') |
| `pSoct2` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_pn` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nx` | NVARCHAR(20) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pTK_Du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NhVT` | NVARCHAR(8) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pGroupType` | NVARCHAR(128) | No |  (default: 'Ma_VT') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '0') |

---

### asINRptBKX01

- **Class:** AsINRptBKX01
- **Description:** Stored procedure asINRptBKX01
- **SQL File:** `asINRptBKX01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pGroupType` | nvarchar(128) | Yes |  |
| `pCtu1` | nvarchar(12) | No |  (default: '') |
| `pCtu2` | nvarchar(12) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_NhKh` | nvarchar(8) | No |  (default: '') |
| `pMa_PlKh1` | nvarchar(20) | No |  (default: '') |
| `pMa_PlKh2` | nvarchar(20) | No |  (default: '') |
| `pMa_PlKh3` | nvarchar(20) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_nx` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_spct` | nvarchar(20) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pLoai_px` | nvarchar(3) | No |  (default: '') |
| `pMa_Nt` | nvarchar(3) | No |  (default: '') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `PMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `ptk_vt` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptBKX02

- **Class:** AsINRptBKX02
- **Description:** Stored procedure asINRptBKX02
- **SQL File:** `asINRptBKX02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_dangnx` | nvarchar(20) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_VT` | nvarchar(20) | No |  (default: '') |
| `pLoai_px` | nvarchar(3) | No |  (default: '') |
| `pSP_CT` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |
| `pMa_NhVT` | nvarchar(8) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptBKX03

- **Class:** AsINRptBKX03
- **Description:** Stored procedure asINRptBKX03
- **SQL File:** `asINRptBKX03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pLoai_px` | nvarchar(3) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_Hd` | nvarchar(20) | No |  (default: '') |
| `pMa_dangnx` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_VT` | nvarchar(20) | No |  (default: '') |
| `pTK_VT` | nvarchar(20) | No |  (default: '') |
| `pNhom_VT` | nvarchar(20) | No |  (default: '') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: 'VND') |
| `pTk_Du` | nvarchar(20) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '0' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptBKX04

- **Class:** AsINRptBKX04
- **Description:** Stored procedure asINRptBKX04
- **SQL File:** `asINRptBKX04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '001') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2015/01/01') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2015/12/31') |
| `pGroupType` | NVARCHAR(128) | No |  (default: 'stt_rec') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pLoai_px` | NVARCHAR(3) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '') |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `PMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `ptk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '' --0 chứng tư / 1 kho / 2 mua / 3 bán) |

---

### asINRptCD01

- **Class:** AsINRptCD01
- **Description:** Stored procedure asINRptCD01
- **SQL File:** `asINRptCD01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '999') |
| `pNgay1` | smalldatetime | No |  (default: '2011-01-01') |
| `pNgay2` | smalldatetime | No |  (default: '2013-12-30') |
| `pLoai_bc` | nvarchar(20) | No |  (default: '1.Tong hop nhap xuat ton') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pma_plvt1` | nvarchar(8) | No |  (default: '') |
| `pma_plvt2` | nvarchar(8) | No |  (default: '') |
| `pma_plvt3` | nvarchar(8) | No |  (default: '') |
| `group1` | nvarchar(1) | No |  (default: '0') |
| `group2` | nvarchar(1) | No |  (default: '0') |
| `group3` | nvarchar(1) | No |  (default: '0') |
| `pDVT` | nvarchar(1) | No |  (default: '1') |
| `pPSDC` | nvarchar(8) | No |  (default: '1') |
| `pNgoai_te` | nvarchar(1) | No |  (default: '0' --0:đồng tiền hoạch toán/1:ngoại tệ) |

---

### asINRptCD01_4check

- **Class:** AsINRptCD01_4check
- **Description:** Stored procedure asINRptCD01_4check
- **SQL File:** `asINRptCD01_4check.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '999') |
| `pNgay1` | smalldatetime | No |  (default: '2011-01-01') |
| `pNgay2` | smalldatetime | No |  (default: '2013-12-30') |
| `pLoai_bc` | nvarchar(20) | No |  (default: '1.Tong hop nhap xuat ton') |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pma_plvt1` | nvarchar(8) | No |  (default: '') |
| `pma_plvt2` | nvarchar(8) | No |  (default: '') |
| `pma_plvt3` | nvarchar(8) | No |  (default: '') |
| `group1` | nvarchar(1) | No |  (default: '0') |
| `group2` | nvarchar(1) | No |  (default: '0') |
| `group3` | nvarchar(1) | No |  (default: '0') |
| `pDVT` | nvarchar(1) | No |  (default: '1') |
| `pPSDC` | nvarchar(8) | No |  (default: '1') |
| `pNgoai_te` | nvarchar(1) | No |  (default: '0' --0:đồng tiền hoạch toán/1:ngoại tệ) |

---

### asINRptCD01_Lo

- **Class:** AsINRptCD01_Lo
- **Description:** Stored procedure asINRptCD01_Lo
- **SQL File:** `asINRptCD01_Lo.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2015/01/01') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2015/01/31') |
| `pLoai_bc` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `group1` | NVARCHAR(1) | No |  (default: '') |
| `group2` | NVARCHAR(1) | No |  (default: '') |
| `group3` | NVARCHAR(1) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '0' --0:đồng tiền hoạch toán/1:ngoại tệ) |

---

### asINRptCD01_PL123

- **Class:** AsINRptCD01_PL123
- **Description:** Stored procedure asINRptCD01_PL123
- **SQL File:** `asINRptCD01_PL123.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: 'GBB') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2013/01/01') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2013/06/30') |
| `pLoai_bc` | NVARCHAR(20) | No |  (default: '5.NXT cong theo phan loai') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `group1` | NVARCHAR(1) | No |  (default: '0') |
| `group2` | NVARCHAR(1) | No |  (default: '0') |
| `group3` | NVARCHAR(1) | No |  (default: '0') |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '0' --0:đồng tiền hoạch toán/1:ngoại tệ) |

---

### asINRptCD01_ViTri

- **Class:** AsINRptCD01_ViTri
- **Description:** Stored procedure asINRptCD01_ViTri
- **SQL File:** `asINRptCD01_ViTri.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: 'GBB') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2013/01/01') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2013/06/30') |
| `pLoai_bc` | NVARCHAR(20) | No |  (default: '4.Tong hop nhap xuat ton theo vi tri') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt1` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt2` | NVARCHAR(8) | No |  (default: '') |
| `pma_plvt3` | NVARCHAR(8) | No |  (default: '') |
| `group1` | NVARCHAR(1) | No |  (default: '') |
| `group2` | NVARCHAR(1) | No |  (default: '') |
| `group3` | NVARCHAR(1) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '0' --0:đồng tiền hoạch toán/1:ngoại tệ) |

---

### asINRptCD04

- **Class:** AsINRptCD04
- **Description:** Stored procedure asINRptCD04
- **SQL File:** `asINRptCD04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nhvt` | NVARCHAR(8) | Yes |  |
| `pNgay` | SMALLDATETIME | Yes |  |
| `pDVT` | NVARCHAR(1) | No |  (default: '0') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '') |
| `pDk_Ck` | BIT | No |  (default: 1) |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pQuaToiThieu` | BIT | No |  (default: 0) |
| `pQuaToiDa` | BIT | No |  (default: 0 -- Chi loc cac vat tu ton lon hon ton toi da) |

---

### asINRptCD06

- **Class:** AsINRptCD06
- **Description:** Stored procedure asINRptCD06
- **SQL File:** `asINRptCD06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nhvt` | NVARCHAR(8) | Yes |  |
| `pNgay` | SMALLDATETIME | Yes |  |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '') |
| `pDk_Ck` | BIT | No |  (default: 1) |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pQuaToiThieu` | BIT | No |  (default: 0) |
| `pQuaToiDa` | BIT | No |  (default: 0				-- Chi loc cac vat tu ton lon hon ton toi da) |

---

### asINRptCD07

- **Class:** AsINRptCD07
- **Description:** Stored procedure asINRptCD07
- **SQL File:** `asINRptCD07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pMa_nhvt` | NVARCHAR(8) | Yes |  |
| `pNgay` | SMALLDATETIME | Yes |  |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '') |
| `pDk_Ck` | BIT | No |  (default: 1) |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pQuaToiThieu` | BIT | No |  (default: 0) |
| `pQuaToiDa` | BIT | No |  (default: 0			-- Chi loc cac vat tu ton lon hon ton toi da) |

---

### asINRptCTVT01

- **Class:** AsINRptCTVT01
- **Description:** Stored procedure asINRptCTVT01
- **SQL File:** `asINRptCTVT01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2015') |
| `pNgay2` | SMALLDATETIME | No |  (default: '12/31/2015') |
| `pMa_vt` | nvarchar(20) | No |  (default: 'CD001') |
| `pMa_kho` | nvarchar(8) | No |  (default: 'KCT') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pMau_bc` | nvarchar(20) | No |  (default: '02') |
| `pDVT` | nvarchar(1) | No |  (default: '') |
| `pTK_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: 'VND') |

---

### asINRptCTVT02

- **Class:** AsINRptCTVT02
- **Description:** Stored procedure asINRptCTVT02
- **SQL File:** `asINRptCTVT02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pDVT` | nvarchar(1) | No |  (default: '') |
| `pPSDC` | nvarchar(8) | No |  (default: '') |
| `pNgoai_te` | nvarchar(1) | No |  (default: '0') |
| `pMau_bc` | nvarchar(20) | No |  (default: '02') |
| `pMa_nt` | nvarchar(3) | No |  (default: 'vnd') |

---

### asINRptCTVT02_crys

- **Class:** AsINRptCTVT02_crys
- **Description:** Stored procedure asINRptCTVT02_crys
- **SQL File:** `asINRptCTVT02_crys.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pXml` | XML | Yes |  |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMau_bc` | NVARCHAR(20) | No |  (default: '02') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: 'VND') |

---

### asINRptF5CD01

- **Class:** AsINRptF5CD01
- **Description:** Stored procedure asINRptF5CD01
- **SQL File:** `asINRptF5CD01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | Yes |  |
| `pMa_kho` | NVARCHAR(8) | Yes |  |
| `pMa_vitri` | NVARCHAR(8) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pTk_vt` | NVARCHAR(20) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pNxt` | NVARCHAR(20) | No |  (default: '%') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1' --0: khong tinh ps dieu chuyen/ 1: co tinh) |

---

### asINRptF5CD05

- **Class:** AsINRptF5CD05
- **Description:** Stored procedure asINRptF5CD05
- **SQL File:** `asINRptF5CD05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_kho` | nvarchar(8) | No |  (default: '') |
| `pMa_vitri` | nvarchar(8) | No |  (default: '') |
| `pTk_vt` | nvarchar(20) | No |  (default: '') |
| `pMa_nhvt` | nvarchar(8) | No |  (default: '') |
| `pNgay` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | No |  (default: 'VND') |
| `pdvt` | nvarchar(1) | No |  (default: '0') |
| `pMa_lo` | nvarchar(8) | Yes |  |

---

### asINRptF5CD05_kho

- **Class:** AsINRptF5CD05_kho
- **Description:** Stored procedure asINRptF5CD05_kho
- **SQL File:** `asINRptF5CD05_kho.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pNgay` | SMALLDATETIME | Yes |  |
| `pMa_nt` | NVARCHAR(3) | No |  (default: 'VND') |
| `pdvt` | NVARCHAR(1) | No |  (default: '0') |
| `pMa_lo` | NVARCHAR(20) | Yes |  |

---

### asINRptF5CT01

- **Class:** AsINRptF5CT01
- **Description:** Stored procedure asINRptF5CT01
- **SQL File:** `asINRptF5CT01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150101') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150131') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: 'VT001') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_khon` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pTk_du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pNxt` | NVARCHAR(20) | No |  (default: '2') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pMa_nhkh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_dangnx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(20) | No |  (default: '') |
| `pTk_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '0') |

---

### asINRptF5THN02

- **Class:** AsINRptF5THN02
- **Description:** Stored procedure asINRptF5THN02
- **SQL File:** `asINRptF5THN02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_VT') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NhKH` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH3` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_pn` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '') |
| `pMa_dangnx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '0') |
| `pGroup_Value` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail_Value` | NVARCHAR(20) | No |  (default: 'MA_VT') |

---

### asINRptF5THX02

- **Class:** AsINRptF5THX02
- **Description:** Stored procedure asINRptF5THX02
- **SQL File:** `asINRptF5THX02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pCtu1` | NVARCHAR(8) | No |  (default: '') |
| `pCtu2` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_px` | NVARCHAR(8) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_VT') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_dangnx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_khon` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '0') |

---

### asINRptTHN01

- **Class:** AsINRptTHN01
- **Description:** : Tổng hợp hàng nhập kho
- **SQL File:** `asINRptTHN01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pCtu1` | NVARCHAR(12) | No |  (default: '') |
| `pCtu2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NhKH` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH3` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_pn` | NVARCHAR(20) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '' --0 chứng từ / 1 kho / 2 mua / 3 bán) |

---

### asINRptTHN02

- **Class:** AsINRptTHN02
- **Description:** : Tổng hợp hàng nhập kho theo hai chỉ tiêu
- **SQL File:** `asINRptTHN02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pCtu1` | NVARCHAR(12) | No |  (default: '') |
| `pCtu2` | NVARCHAR(12) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: '') |
| `pDetail` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NhKH` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_PLKH3` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_pn` | NVARCHAR(20) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '' --0 chung tu / 1 kho / 2 mua / 3 ban) |

---

### asINRptTHX01

- **Class:** AsINRptTHX01
- **Description:** : Tổng hợp hàng xuất kho
- **SQL File:** `asINRptTHX01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150101') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150131') |
| `pCtu1` | NVARCHAR(8) | No |  (default: '') |
| `pCtu2` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_px` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho_xuat` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho_nhap` | NVARCHAR(8) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '0') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '' --0 chứng từ / 1 kho / 2 mua / 3 bán) |

---

### asINRptTHX02

- **Class:** AsINRptTHX02
- **Description:** : Tổng hợp hàng xuất kho theo hai chỉ tiêu
- **SQL File:** `asINRptTHX02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2015-01-01') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2015-01-31') |
| `pCtu1` | NVARCHAR(12) | No |  (default: '') |
| `pCtu2` | NVARCHAR(12) | No |  (default: '') |
| `pLoai_px` | NVARCHAR(8) | No |  (default: '') |
| `pLoai_gd` | NVARCHAR(1) | No |  (default: '') |
| `pGroup` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pDetail` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_Hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_dangnx` | NVARCHAR(20) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_khon` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vitri` | NVARCHAR(8) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pNhom_VT` | NVARCHAR(8) | No |  (default: '') |
| `pTK_VT` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pPSDC` | NVARCHAR(8) | No |  (default: '1') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |
| `pTk_Du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pNgoai_te` | NVARCHAR(1) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pDVT` | NVARCHAR(1) | No |  (default: '' --0 chứng từ / 1 kho / 2 mua / 3 bán) |

---

## Other Procedures

### asINChuyenTonKho

- **Class:** AsINChuyenTonKho
- **Description:** Stored procedure asINChuyenTonKho
- **SQL File:** `asINChuyenTonKho.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pngay_cnt` | SMALLDATETIME | Yes |  |
| `pma_kho` | NVARCHAR(8) | No |  (default: '') |
| `pRet` | INT (output) | Yes |  |

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
| [PO](../PO/) | Purchase receipts |
| [SO](../SO/) | Sales shipments |
| [CO](../CO/) | Production materials/FG |
| [SI](../SI/) | Master data reference |

---

*End of IN Procedures Documentation*
