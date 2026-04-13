# GL Procedures (General Ledger (Sổ cái))

*Generated on 2026-03-19 14:55:32*

Tổng số procedures: **290**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 46 |
| Update | 44 |
| Delete | 47 |
| Get | 50 |
| Filter | 2 |
| Report | 94 |
| Other | 7 |

## Insert Procedures

### asGLInsBudget

- **Class:** AsGLInsBudget
- **Description:** Stored procedure asGLInsBudget
- **SQL File:** `asGLInsBudget.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNam` | INT | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pTtps_no_co` | NVARCHAR(10) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pUser` | NVARCHAR(20) | Yes |  |
| `pT1` | DECIMAL(19 | Yes |  |
| `pT2` | DECIMAL(19 | Yes |  |
| `pT3` | DECIMAL(19 | Yes |  |
| `pT4` | DECIMAL(19 | Yes |  |
| `pT5` | DECIMAL(19 | Yes |  |
| `pT6` | DECIMAL(19 | Yes |  |
| `pT7` | DECIMAL(19 | Yes |  |
| `pT8` | DECIMAL(19 | Yes |  |
| `pT9` | DECIMAL(19 | Yes |  |
| `pT10` | DECIMAL(19 | Yes |  |
| `pT11` | DECIMAL(19 | Yes |  |
| `pT12` | DECIMAL(19 | Yes |  |
| `pRet` | INT OUT | Yes |  |

---

### asGLInsCRCt1

- **Class:** AsGLInsCRCt1
- **Description:** Stored procedure asGLInsCRCt1
- **SQL File:** `asGLInsCRCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pMa_dv` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_so` | nvarchar(20) | No |  (default: '') |
| `pMa_bang` | nvarchar(50) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pPs_co` | Decimal(19 | Yes |  |
| `pPs_co_nt` | Decimal(19 | Yes |  |
| `pPs_no` | Decimal(19 | Yes |  |
| `pPs_no_nt` | Decimal(19 | Yes |  |
| `pNh_dk` | nvarchar(4) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pMa_ku` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsCRPh1

- **Class:** AsGLInsCRPh1
- **Description:** Stored procedure asGLInsCRPh1
- **SQL File:** `asGLInsCRPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pKht_thue_vao` | bit | Yes |  |
| `pKht_thue_ra` | bit | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue_vao` | decimal(19 | Yes |  |
| `pT_thue_ra` | decimal(19 | Yes |  |
| `pT_thue_vao_nt` | decimal(19 | Yes |  |
| `pT_thue_ra_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `Post2gl` | nvarchar(1) | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsCdTk

- **Class:** AsGLInsCdTk
- **Description:** Stored procedure asGLInsCdTk
- **SQL File:** `asGLInsCdTk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pDu_no_nt00` | decimal(19 | Yes |  |
| `pDu_co_nt00` | decimal(19 | Yes |  |
| `pDu_no00` | decimal(19 | Yes |  |
| `pDu_co00` | decimal(19 | Yes |  |
| `pDu_no_nt` | decimal(19 | Yes |  |
| `pDu_co_nt` | decimal(19 | Yes |  |
| `pDu_no` | decimal(19 | Yes |  |
| `pDu_co` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsCt1

- **Class:** AsGLInsCt1
- **Description:** Stored procedure asGLInsCt1
- **SQL File:** `asGLInsCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTy_gia` | DECIMAL(19 | Yes |  |
| `pMa_kh` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pPs_co` | DECIMAL(19 | Yes |  |
| `pPs_co_nt` | DECIMAL(19 | Yes |  |
| `pPs_no` | DECIMAL(19 | Yes |  |
| `pPs_no_nt` | DECIMAL(19 | Yes |  |
| `pNh_dk` | NVARCHAR(4) | Yes |  |
| `pMa_ku` | NVARCHAR(20) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsDMCTGS

- **Class:** AsGLInsDMCTGS
- **Description:** Stored procedure asGLInsDMCTGS
- **SQL File:** `asGLInsDMCTGS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTen_ctgs` | NVARCHAR(50) | Yes |  |
| `pSo_hieu` | NVARCHAR(3) | Yes |  |
| `pNgay` | INT | Yes |  |
| `pStt` | INT | Yes |  |
| `pKsd` | BIT | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsDMDGTG

- **Class:** AsGLInsDMDGTG
- **Description:** Stored procedure asGLInsDMDGTG
- **SQL File:** `asGLInsDMDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pLoai_dg` | NVARCHAR(1) | Yes |  |
| `pTk_dgtg` | NVARCHAR(20) | Yes |  |
| `pStt` | INT | Yes |  |
| `pTk_lai_cltg` | NVARCHAR(20) | Yes |  |
| `pTk_lo_cltg` | NVARCHAR(20) | Yes |  |
| `pTk_cltg_cn` | NVARCHAR(20) | Yes |  |
| `pTen_bt` | NVARCHAR(50) | Yes |  |
| `pDg_kh` | BIT | Yes |  |
| `pDg_bp` | BIT | Yes |  |
| `pDg_hd` | BIT | Yes |  |
| `pDg_spct` | BIT | Yes |  |
| `pDg_phi` | BIT | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pKsd` | BIT | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsDMKC

- **Class:** AsGLInsDMKC
- **Description:** Stored procedure asGLInsDMKC
- **SQL File:** `asGLInsDMKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt` | INT | Yes |  |
| `pTen_bt` | NVARCHAR(150) | Yes |  |
| `pLoai_kc` | NVARCHAR(1) | Yes |  |
| `pKc_ps` | BIT | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pModuleID` | NVARCHAR(2) | Yes |  |
| `pKc_spct` | BIT | Yes |  |
| `pKc_bp` | BIT | Yes |  |
| `pKc_hd` | BIT | Yes |  |
| `pKc_phi` | BIT | Yes |  |
| `pKc_dt_ps` | BIT | Yes |  |
| `pKc_lo` | BIT | Yes |  |
| `pkSd` | BIT | Yes |  |
| `pCUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsDMTK

- **Class:** AsGLInsDMTK
- **Description:** Stored procedure asGLInsDMTK
- **SQL File:** `asGLInsDMTK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTen_tk` | nvarchar(150) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pChi_tiet` | bit | Yes |  |
| `pTk_me` | nvarchar(20) | Yes |  |
| `pBac_tk` | int | Yes |  |
| `pTk_sc` | bit | Yes |  |
| `pTk_cn` | bit | Yes |  |
| `pPp_tinh_tggs_no` | nvarchar(1) | Yes |  |
| `pPp_tinh_tggs_co` | nvarchar(1) | Yes |  |
| `pKieu_sd` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pMa_ngh` | nvarchar(50) | Yes |  |
| `pSo_tk` | nvarchar(50) | Yes |  |
| `pTen_ngh` | NVARCHAR(100) | Yes |  |
| `pTinh_tp` | NVARCHAR(50) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsMAUBCTCTMI

- **Class:** AsGLInsMAUBCTCTMI
- **Description:** :	Thêm thuyết minh BCTC mục I,II,III,IV
- **SQL File:** `asGLInsMAUBCTCTMI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMIX

- **Class:** AsGLInsMAUBCTCTMIX
- **Description:** Stored procedure asGLInsMAUBCTCTMIX
- **SQL File:** `asGLInsMAUBCTCTMIX.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI01

- **Class:** AsGLInsMAUBCTCTMVI01
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI02B

- **Class:** AsGLInsMAUBCTCTMVI02B
- **Description:** Stored procedure asGLInsMAUBCTCTMVI02B
- **SQL File:** `asGLInsMAUBCTCTMVI02B.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI02a

- **Class:** AsGLInsMAUBCTCTMVI02a
- **Description:** Stored procedure asGLInsMAUBCTCTMVI02a
- **SQL File:** `asGLInsMAUBCTCTMVI02a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pgia_goc_dk` | DECIMAL(19 | Yes |  |
| `pgia_hl_dk` | DECIMAL(19 | Yes |  |
| `pgia_dp_dk` | DECIMAL(19 | Yes |  |
| `pgia_goc_ck` | DECIMAL(19 | Yes |  |
| `pgia_hl_ck` | DECIMAL(19 | Yes |  |
| `pgia_dp_ck` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI02c

- **Class:** AsGLInsMAUBCTCTMVI02c
- **Description:** Stored procedure asGLInsMAUBCTCTMVI02c
- **SQL File:** `asGLInsMAUBCTCTMVI02c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pgia_goc_dk` | DECIMAL(19 | Yes |  |
| `pgia_hl_dk` | DECIMAL(19 | Yes |  |
| `pgia_dp_dk` | DECIMAL(19 | Yes |  |
| `pgia_goc_ck` | DECIMAL(19 | Yes |  |
| `pgia_hl_ck` | DECIMAL(19 | Yes |  |
| `pgia_dp_ck` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI03

- **Class:** AsGLInsMAUBCTCTMVI03
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI04

- **Class:** AsGLInsMAUBCTCTMVI04
- **Description:** Stored procedure asGLInsMAUBCTCTMVI04
- **SQL File:** `asGLInsMAUBCTCTMVI04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI05

- **Class:** AsGLInsMAUBCTCTMVI05
- **Description:** Stored procedure asGLInsMAUBCTCTMVI05
- **SQL File:** `asGLInsMAUBCTCTMVI05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI06

- **Class:** AsGLInsMAUBCTCTMVI06
- **Description:** : Thêm thuyết minh BCTC mục V.02
- **SQL File:** `asGLInsMAUBCTCTMVI06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pgia_goc_dk` | DECIMAL(19 | Yes |  |
| `pgia_hl_dk` | NVARCHAR(100) | No |  (default: '') |
| `pgia_dp_dk` | DECIMAL(19 | Yes |  |
| `pgia_goc_ck` | DECIMAL(19 | Yes |  |
| `pgia_hl_ck` | NVARCHAR(100) | No |  (default: '') |
| `pgia_dp_ck` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI0708

- **Class:** AsGLInsMAUBCTCTMVI0708
- **Description:** Stored procedure asGLInsMAUBCTCTMVI0708
- **SQL File:** `asGLInsMAUBCTCTMVI0708.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI08b

- **Class:** AsGLInsMAUBCTCTMVI08b
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI08b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI09

- **Class:** AsGLInsMAUBCTCTMVI09
- **Description:** Stored procedure asGLInsMAUBCTCTMVI09
- **SQL File:** `asGLInsMAUBCTCTMVI09.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTien_01` | decimal(19 | Yes |  |
| `pTien_02` | decimal(19 | Yes |  |
| `pTien_03` | decimal(19 | Yes |  |
| `pTien_04` | decimal(19 | Yes |  |
| `pTien_05` | decimal(19 | Yes |  |
| `pTien_06` | decimal(19 | Yes |  |
| `pTong` | decimal(19 | Yes |  |
| `pUserData` | bit | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | smalldatetime | No |  (default: '1/1/2012') |
| `pNgay2` | smalldatetime | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 output) |

---

### asGLInsMAUBCTCTMVI10

- **Class:** AsGLInsMAUBCTCTMVI10
- **Description:** Stored procedure asGLInsMAUBCTCTMVI10
- **SQL File:** `asGLInsMAUBCTCTMVI10.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTien_01` | DECIMAL(19 | Yes |  |
| `pTien_02` | DECIMAL(19 | Yes |  |
| `pTien_03` | DECIMAL(19 | Yes |  |
| `pTien_04` | DECIMAL(19 | Yes |  |
| `pTien_05` | DECIMAL(19 | Yes |  |
| `pTien_06` | DECIMAL(19 | Yes |  |
| `pTien_07` | DECIMAL(19 | Yes |  |
| `pTong` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI11

- **Class:** AsGLInsMAUBCTCTMVI11
- **Description:** Stored procedure asGLInsMAUBCTCTMVI11
- **SQL File:** `asGLInsMAUBCTCTMVI11.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTien_01` | DECIMAL(19 | Yes |  |
| `pTien_02` | DECIMAL(19 | Yes |  |
| `pTien_03` | DECIMAL(19 | Yes |  |
| `pTien_04` | DECIMAL(19 | Yes |  |
| `pTien_05` | DECIMAL(19 | Yes |  |
| `pTien_06` | DECIMAL(19 | Yes |  |
| `pTien_07` | DECIMAL(19 | Yes |  |
| `pTong` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI12

- **Class:** AsGLInsMAUBCTCTMVI12
- **Description:** Stored procedure asGLInsMAUBCTCTMVI12
- **SQL File:** `asGLInsMAUBCTCTMVI12.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pDu_dau` | decimal(19 | Yes |  |
| `pPs_no` | decimal(19 | Yes |  |
| `pPs_co` | decimal(19 | Yes |  |
| `pDu_cuoi` | decimal(19 | Yes |  |
| `pUserData` | bit | No |  (default: 0) |
| `pGhi_chu` | nvarchar(MAX) | Yes |  |
| `pNgay1` | smalldatetime | No |  (default: '1/1/2012') |
| `pNgay2` | smalldatetime | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 output) |

---

### asGLInsMAUBCTCTMVI13

- **Class:** AsGLInsMAUBCTCTMVI13
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI13.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI15a

- **Class:** AsGLInsMAUBCTCTMVI15a
- **Description:** Stored procedure asGLInsMAUBCTCTMVI15a
- **SQL File:** `asGLInsMAUBCTCTMVI15a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pgia_tri_dk` | DECIMAL | No |  (default: 0) |
| `pton_dk` | DECIMAL | No |  (default: 0) |
| `pps_tang` | DECIMAL | No |  (default: 0) |
| `pps_giam` | DECIMAL | No |  (default: 0) |
| `pgia_tri_ck` | DECIMAL | No |  (default: 0) |
| `pton_ck` | DECIMAL | No |  (default: 0) |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI15d

- **Class:** AsGLInsMAUBCTCTMVI15d
- **Description:** Stored procedure asGLInsMAUBCTCTMVI15d
- **SQL File:** `asGLInsMAUBCTCTMVI15d.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI16

- **Class:** AsGLInsMAUBCTCTMVI16
- **Description:** Stored procedure asGLInsMAUBCTCTMVI16
- **SQL File:** `asGLInsMAUBCTCTMVI16.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI17

- **Class:** AsGLInsMAUBCTCTMVI17
- **Description:** Stored procedure asGLInsMAUBCTCTMVI17
- **SQL File:** `asGLInsMAUBCTCTMVI17.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTon_CK` | DECIMAL(19 | Yes |  |
| `pCuoi_ky` | DECIMAL(19 | Yes |  |
| `pTon_DK` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI18

- **Class:** AsGLInsMAUBCTCTMVI18
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI18.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI212

- **Class:** AsGLInsMAUBCTCTMVI212
- **Description:** Stored procedure asGLInsMAUBCTCTMVI212
- **SQL File:** `asGLInsMAUBCTCTMVI212.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVI23

- **Class:** AsGLInsMAUBCTCTMVI23
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI23.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI25a

- **Class:** AsGLInsMAUBCTCTMVI25a
- **Description:** Stored procedure asGLInsMAUBCTCTMVI25a
- **SQL File:** `asGLInsMAUBCTCTMVI25a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pNam_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pTk_08` | NVARCHAR(10) | Yes |  |
| `pTk_09` | NVARCHAR(10) | Yes |  |
| `pTk_10` | NVARCHAR(10) | Yes |  |
| `pTk_11` | NVARCHAR(10) | Yes |  |
| `pTk_12` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTien_01` | decimal(19 | Yes |  |
| `pTien_02` | decimal(19 | Yes |  |
| `pTien_03` | decimal(19 | Yes |  |
| `pTien_04` | decimal(19 | Yes |  |
| `pTien_05` | decimal(19 | Yes |  |
| `pTien_06` | decimal(19 | Yes |  |
| `pTien_07` | decimal(19 | Yes |  |
| `pTien_08` | decimal(19 | Yes |  |
| `pTien_09` | decimal(19 | Yes |  |
| `pTien_10` | decimal(19 | Yes |  |
| `pTien_11` | decimal(19 | Yes |  |
| `pTien_12` | decimal(19 | Yes |  |
| `pTong` | decimal(19 | Yes |  |
| `pUserData` | bit | No |  (default: 0) |
| `pGhi_chu` | nvarchar(MAX) | Yes |  |
| `pNgay1` | smalldatetime | No |  (default: '1/1/2012') |
| `pNgay2` | smalldatetime | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 output) |

---

### asGLInsMAUBCTCTMVI25b

- **Class:** AsGLInsMAUBCTCTMVI25b
- **Description:** : Thêm thuyết minh BCTC mục V.01
- **SQL File:** `asGLInsMAUBCTCTMVI25b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pcuoi_ky` | DECIMAL(19 | Yes |  |
| `pDau_ky` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVI29b

- **Class:** AsGLInsMAUBCTCTMVI29b
- **Description:** Stored procedure asGLInsMAUBCTCTMVI29b
- **SQL File:** `asGLInsMAUBCTCTMVI29b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pma_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2011') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMAUBCTCTMVII

- **Class:** AsGLInsMAUBCTCTMVII
- **Description:** :	Thuyết minh BCTC mục VI
- **SQL File:** `asGLInsMAUBCTCTMVII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pNam_nay` | DECIMAL(19 | Yes |  |
| `pNam_truoc` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBCTCTMVIII

- **Class:** AsGLInsMAUBCTCTMVIII
- **Description:** :	Thuyết minh BCTC mục VII
- **SQL File:** `asGLInsMAUBCTCTMVIII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTK_01` | NVARCHAR (10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pNam_nay` | decimal(19 | Yes |  |
| `pNam_truoc` | decimal(19 | Yes |  |
| `pUserData` | bit | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | smalldatetime | No |  (default: '1/1/2012') |
| `pNgay2` | smalldatetime | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 output) |

---

### asGLInsMAUBCTCTmVI15c

- **Class:** AsGLInsMAUBCTCTmVI15c
- **Description:** : Thuyết minh BCTC mục V.20C
- **SQL File:** `asGLInsMAUBCTCTmVI15c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pTien_01` | DECIMAL(19 | Yes |  |
| `pTien_02` | DECIMAL(19 | Yes |  |
| `pTien_03` | DECIMAL(19 | Yes |  |
| `pTien_04` | DECIMAL(19 | Yes |  |
| `pTien_05` | DECIMAL(19 | Yes |  |
| `pTien_06` | DECIMAL(19 | Yes |  |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT) |

---

### asGLInsMAUBctcTmVI211

- **Class:** AsGLInsMAUBctcTmVI211
- **Description:** : Thêm thuyết minh BCTC mục V.02
- **SQL File:** `asGLInsMAUBctcTmVI211.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pcach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | No |  (default: 0) |
| `pgia_tri_dk` | DECIMAL(19 | Yes |  |
| `plai_suat_dk` | NVARCHAR(50) | No |  (default: '') |
| `pky_han_dk` | NVARCHAR(50) | No |  (default: '') |
| `pgia_tri_ck` | DECIMAL(19 | Yes |  |
| `plai_suat_ck` | NVARCHAR(50) | No |  (default: '') |
| `pky_han_ck` | NVARCHAR(50) | No |  (default: '') |
| `pUserData` | BIT | No |  (default: 0) |
| `pGhi_chu` | NVARCHAR(MAX) | Yes |  |
| `pNgay1` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pNgay2` | SMALLDATETIME | No |  (default: '1/1/2012') |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMauBs

- **Class:** AsGLInsMauBs
- **Description:** Stored procedure asGLInsMauBs
- **SQL File:** `asGLInsMauBs.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pXtag` | INT | Yes |  |
| `pXstt` | INT | Yes |  |
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pStt` | INT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pIn_ck` | BIT | Yes |  |
| `pTs_nv` | BIT | Yes |  |
| `pCong_no` | BIT | Yes |  |
| `pNgoai_bang` | BIT | Yes |  |
| `pSodu_duong` | BIT | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pCach_tinh` | NVARCHAR(255) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pTien0` | MONEY | Yes |  |
| `pTien` | MONEY | Yes |  |
| `pTien_nt0` | MONEY | Yes |  |
| `pTien_nt` | MONEY | Yes |  |
| `pTm` | NVARCHAR(10) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMauCf1

- **Class:** AsGLInsMauCf1
- **Description:** Stored procedure asGLInsMauCf1
- **SQL File:** `asGLInsMauCf1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMau` | NVARCHAR(3) | Yes |  |
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pStt` | INT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pIn_ck` | BIT | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pMa_so` | NVARCHAR(3) | Yes |  |
| `pCach_tinh` | NVARCHAR(255) | Yes |  |
| `pTk_no` | NVARCHAR(100) | Yes |  |
| `pTk_co` | NVARCHAR(100) | Yes |  |
| `pDau` | BIT | Yes |  |
| `pTm` | NVARCHAR(55) | Yes |  |
| `pLoai_ps` | NVARCHAR(1) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsMauPl1

- **Class:** AsGLInsMauPl1
- **Description:** Stored procedure asGLInsMauPl1
- **SQL File:** `asGLInsMauPl1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pMau` | NVARCHAR(8) | Yes |  |
| `pStt` | INT | Yes |  |
| `pBold` | NVARCHAR(53) | Yes |  |
| `pIn_ck` | NVARCHAR(53) | Yes |  |
| `pMa_so` | NVARCHAR(53) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pCach_tinh` | NVARCHAR(100) | Yes |  |
| `pTk_no` | NVARCHAR(20) | Yes |  |
| `pTk_co` | NVARCHAR(20) | Yes |  |
| `pGiam_tru` | BIT | Yes |  |
| `pTm` | NVARCHAR(255) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLInsNB

- **Class:** AsGLInsNB
- **Description:** Stored procedure asGLInsNB
- **SQL File:** `asGLInsNB.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pPs_co` | decimal(19 | Yes |  |
| `pPs_co_nt` | decimal(19 | Yes |  |
| `pPs_no` | decimal(19 | Yes |  |
| `pPs_no_nt` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsPh1

- **Class:** AsGLInsPh1
- **Description:** Stored procedure asGLInsPh1
- **SQL File:** `asGLInsPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pKht_thue_vao` | bit | Yes |  |
| `pKht_thue_ra` | bit | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue_vao` | decimal(19 | Yes |  |
| `pT_thue_ra` | decimal(19 | Yes |  |
| `pT_thue_vao_nt` | decimal(19 | Yes |  |
| `pT_thue_ra_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLInsmauBctc06

- **Class:** AsGLInsmauBctc06
- **Description:** Stored procedure asGLInsmauBctc06
- **SQL File:** `asGLInsmauBctc06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |
| `pChi_tieu` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(10) | Yes |  |
| `pGia_tri` | decimal | Yes |  |
| `pRep_ref` | nvarchar(20) | Yes |  |
| `pMa_so_ref` | nvarchar(20) | Yes |  |
| `pCach_tinh` | nvarchar(100) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pIn_ck` | nvarchar(1) | Yes |  |
| `pBold` | bit | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Update Procedures

### asGLUpdBudget

- **Class:** AsGLUpdBudget
- **Description:** Stored procedure asGLUpdBudget
- **SQL File:** `asGLUpdBudget.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_du` | nvarchar(20) | Yes |  |
| `pTtps_no_co` | NVARCHAR(10) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pT1` | decimal(19 | Yes |  |
| `pT2` | decimal(19 | Yes |  |
| `pT3` | decimal(19 | Yes |  |
| `pT4` | decimal(19 | Yes |  |
| `pT5` | decimal(19 | Yes |  |
| `pT6` | decimal(19 | Yes |  |
| `pT7` | decimal(19 | Yes |  |
| `pT8` | decimal(19 | Yes |  |
| `pT9` | decimal(19 | Yes |  |
| `pT10` | decimal(19 | Yes |  |
| `pT11` | decimal(19 | Yes |  |
| `pT12` | decimal(19 | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLUpdCRPh1

- **Class:** AsGLUpdCRPh1
- **Description:** Stored procedure asGLUpdCRPh1
- **SQL File:** `asGLUpdCRPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pKht_thue_vao` | bit | Yes |  |
| `pKht_thue_ra` | bit | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue_vao` | decimal(19 | Yes |  |
| `pT_thue_ra` | decimal(19 | Yes |  |
| `pT_thue_vao_nt` | decimal(19 | Yes |  |
| `pT_thue_ra_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdCdTk

- **Class:** AsGLUpdCdTk
- **Description:** Stored procedure asGLUpdCdTk
- **SQL File:** `asGLUpdCdTk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |
| `pDu_No_Nt00` | Decimal (19 | Yes |  |
| `pDu_Co_Nt00` | Decimal (19 | Yes |  |
| `pDu_No00` | Decimal (19 | Yes |  |
| `pDu_Co00` | Decimal (19 | Yes |  |
| `pDu_No_Nt` | Decimal (19 | Yes |  |
| `pDu_Co_Nt` | Decimal (19 | Yes |  |
| `pDu_No` | Decimal (19 | Yes |  |
| `pDu_Co` | Decimal (19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdDMCTGS

- **Class:** AsGLUpdDMCTGS
- **Description:** Stored procedure asGLUpdDMCTGS
- **SQL File:** `asGLUpdDMCTGS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTen_ctgs` | NVARCHAR(50) | Yes |  |
| `pSo_hieu` | NVARCHAR(3) | Yes |  |
| `pNgay` | INT | Yes |  |
| `pStt` | INT | Yes |  |
| `pKsd` | BIT | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLUpdDMDGTG

- **Class:** AsGLUpdDMDGTG
- **Description:** Stored procedure asGLUpdDMDGTG
- **SQL File:** `asGLUpdDMDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pLoai_dg` | nvarchar(1) | Yes |  |
| `pTk_dgtg` | nvarchar(20) | Yes |  |
| `pStt` | int | Yes |  |
| `pTk_lai_cltg` | nvarchar(20) | Yes |  |
| `pTk_lo_cltg` | nvarchar(20) | Yes |  |
| `pTk_cltg_cn` | nvarchar(20) | Yes |  |
| `pTen_bt` | nvarchar(50) | Yes |  |
| `pDg_kh` | bit | Yes |  |
| `pDg_bp` | bit | Yes |  |
| `pDg_hd` | bit | Yes |  |
| `pDg_spct` | bit | Yes |  |
| `pDg_phi` | bit | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdDMKC

- **Class:** AsGLUpdDMKC
- **Description:** Stored procedure asGLUpdDMKC
- **SQL File:** `asGLUpdDMKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt` | int | Yes |  |
| `pModuleID` | nvarchar(2) | Yes |  |
| `pTen_bt` | nvarchar(150) | Yes |  |
| `pLoai_kc` | nvarchar(1) | Yes |  |
| `pKc_ps` | bit | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_du` | nvarchar(20) | Yes |  |
| `pKc_spct` | bit | Yes |  |
| `pKc_bp` | bit | Yes |  |
| `pso_ct` | nvarchar(10) | Yes |  |
| `pKc_hd` | bit | Yes |  |
| `pKc_phi` | bit | Yes |  |
| `pKc_dt_ps` | BIT | Yes |  |
| `pKc_lo` | bit | Yes |  |
| `pkSd` | bit | Yes |  |
| `pCUser` | nvarchar(20) | Yes |  |
| `pOld_Tk` | nvarchar(20) | Yes |  |
| `pOld_Tk_du` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdDMTK

- **Class:** AsGLUpdDMTK
- **Description:** Stored procedure asGLUpdDMTK
- **SQL File:** `asGLUpdDMTK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTen_tk` | nvarchar(150) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pChi_tiet` | bit | Yes |  |
| `pTk_me` | nvarchar(20) | Yes |  |
| `pBac_tk` | int | Yes |  |
| `pTk_sc` | bit | Yes |  |
| `pTk_cn` | bit | Yes |  |
| `pPp_tinh_tggs_no` | nvarchar(1) | Yes |  |
| `pPp_tinh_tggs_co` | nvarchar(1) | Yes |  |
| `pKieu_sd` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pMa_ngh` | nvarchar(20) | Yes |  |
| `pSo_tk` | nvarchar(50) | Yes |  |
| `pTen_ngh` | NVARCHAR(100) | Yes |  |
| `pTinh_tp` | NVARCHAR(50) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdMAUBCTCTMI

- **Class:** AsGLUpdMAUBCTCTMI
- **Description:** :	Sửa thuyết minh BCTC mục I,II,III,IV
- **SQL File:** `asGLUpdMAUBCTCTMI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMIX

- **Class:** AsGLUpdMAUBCTCTMIX
- **Description:** Stored procedure asGLUpdMAUBCTCTMIX
- **SQL File:** `asGLUpdMAUBCTCTMIX.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI01

- **Class:** AsGLUpdMAUBCTCTMVI01
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI02B

- **Class:** AsGLUpdMAUBCTCTMVI02B
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI02B
- **SQL File:** `asGLUpdMAUBCTCTMVI02B.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI02a

- **Class:** AsGLUpdMAUBCTCTMVI02a
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI02a
- **SQL File:** `asGLUpdMAUBCTCTMVI02a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI02c

- **Class:** AsGLUpdMAUBCTCTMVI02c
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI02c
- **SQL File:** `asGLUpdMAUBCTCTMVI02c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pGia_goc_dk` | DECIMAL | Yes |  |
| `pGia_hl_dk` | DECIMAL | Yes |  |
| `pGia_dp_dk` | DECIMAL | Yes |  |
| `pGia_goc_ck` | DECIMAL | Yes |  |
| `pGia_hl_ck` | DECIMAL | Yes |  |
| `pGia_dp_ck` | DECIMAL | Yes |  |
| `pIsprint` | BIT | Yes |  |
| `pIsitalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLUpdMAUBCTCTMVI03

- **Class:** AsGLUpdMAUBCTCTMVI03
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI04

- **Class:** AsGLUpdMAUBCTCTMVI04
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI04
- **SQL File:** `asGLUpdMAUBCTCTMVI04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI05

- **Class:** AsGLUpdMAUBCTCTMVI05
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI05
- **SQL File:** `asGLUpdMAUBCTCTMVI05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI06

- **Class:** AsGLUpdMAUBCTCTMVI06
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI06
- **SQL File:** `asGLUpdMAUBCTCTMVI06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |
| `pChi_tieu` | nvarchar(255) | Yes |  |
| `pNd_chtieu` | nvarchar(max) | Yes |  |
| `pCach_tinh` | nvarchar(50) | Yes |  |
| `pTk_01` | nvarchar(10) | Yes |  |
| `pGia_goc_dk` | decimal | Yes |  |
| `pGia_hl_dk` | NVARCHAR(100) | Yes |  |
| `pGia_dp_dk` | DECIMAL(19 | Yes |  |
| `pGia_goc_ck` | decimal | Yes |  |
| `pGia_hl_ck` | NVARCHAR(100) | Yes |  |
| `pGia_dp_ck` | DECIMAL(19 | Yes |  |
| `pIsprint` | bit | Yes |  |
| `pIsitalic` | bit | Yes |  |
| `pBold` | bit | Yes |  |
| `pModify` | bit | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdMAUBCTCTMVI0708

- **Class:** AsGLUpdMAUBCTCTMVI0708
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI0708
- **SQL File:** `asGLUpdMAUBCTCTMVI0708.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI08b

- **Class:** AsGLUpdMAUBCTCTMVI08b
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI08b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI09

- **Class:** AsGLUpdMAUBCTCTMVI09
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI09
- **SQL File:** `asGLUpdMAUBCTCTMVI09.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI10

- **Class:** AsGLUpdMAUBCTCTMVI10
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI10
- **SQL File:** `asGLUpdMAUBCTCTMVI10.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(1000) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI11

- **Class:** AsGLUpdMAUBCTCTMVI11
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI11
- **SQL File:** `asGLUpdMAUBCTCTMVI11.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(1000) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI12

- **Class:** AsGLUpdMAUBCTCTMVI12
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI12
- **SQL File:** `asGLUpdMAUBCTCTMVI12.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI13

- **Class:** AsGLUpdMAUBCTCTMVI13
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI13.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI15a

- **Class:** AsGLUpdMAUBCTCTMVI15a
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI15a
- **SQL File:** `asGLUpdMAUBCTCTMVI15a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pgia_tri_dk` | DECIMAL | Yes |  |
| `pton_dk` | DECIMAL | Yes |  |
| `pps_tang` | DECIMAL | Yes |  |
| `pps_giam` | DECIMAL | Yes |  |
| `pgia_tri_ck` | DECIMAL | Yes |  |
| `pton_ck` | DECIMAL | Yes |  |
| `pIsprint` | BIT | Yes |  |
| `pIsitalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pModify` | BIT | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLUpdMAUBCTCTMVI15d

- **Class:** AsGLUpdMAUBCTCTMVI15d
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI15d
- **SQL File:** `asGLUpdMAUBCTCTMVI15d.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI16

- **Class:** AsGLUpdMAUBCTCTMVI16
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI16
- **SQL File:** `asGLUpdMAUBCTCTMVI16.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI17

- **Class:** AsGLUpdMAUBCTCTMVI17
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI17
- **SQL File:** `asGLUpdMAUBCTCTMVI17.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI18

- **Class:** AsGLUpdMAUBCTCTMVI18
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI18.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI212

- **Class:** AsGLUpdMAUBCTCTMVI212
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI212
- **SQL File:** `asGLUpdMAUBCTCTMVI212.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI23

- **Class:** AsGLUpdMAUBCTCTMVI23
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI23.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI25a

- **Class:** AsGLUpdMAUBCTCTMVI25a
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI25a
- **SQL File:** `asGLUpdMAUBCTCTMVI25a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pNam_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pTk_03` | NVARCHAR(10) | Yes |  |
| `pTk_04` | NVARCHAR(10) | Yes |  |
| `pTk_05` | NVARCHAR(10) | Yes |  |
| `pTk_06` | NVARCHAR(10) | Yes |  |
| `pTk_07` | NVARCHAR(10) | Yes |  |
| `pTk_08` | NVARCHAR(10) | Yes |  |
| `pTk_09` | NVARCHAR(10) | Yes |  |
| `pTk_10` | NVARCHAR(10) | Yes |  |
| `pTk_11` | NVARCHAR(10) | Yes |  |
| `pTk_12` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI25b

- **Class:** AsGLUpdMAUBCTCTMVI25b
- **Description:** : S?a thuy?t minh BCTC m?c V.01
- **SQL File:** `asGLUpdMAUBCTCTMVI25b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | NVARCHAR(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | No |  (default: '') |
| `pTk_01` | NVARCHAR(10) | No |  (default: '') |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVI29b

- **Class:** AsGLUpdMAUBCTCTMVI29b
- **Description:** Stored procedure asGLUpdMAUBCTCTMVI29b
- **SQL File:** `asGLUpdMAUBCTCTMVI29b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVII

- **Class:** AsGLUpdMAUBCTCTMVII
- **Description:** :	Thuyết minh BCTC mục VI
- **SQL File:** `asGLUpdMAUBCTCTMVII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTMVIII

- **Class:** AsGLUpdMAUBCTCTMVIII
- **Description:** :	Thuyết minh BCTC mục VII
- **SQL File:** `asGLUpdMAUBCTCTMVIII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR (10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBCTCTmVI15c

- **Class:** AsGLUpdMAUBCTCTmVI15c
- **Description:** : Thuyết minh BCTC mục V.20C
- **SQL File:** `asGLUpdMAUBCTCTmVI15c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pNd_chtieu` | nvarchar(MAX) | Yes |  |
| `pCach_tinh` | NVARCHAR(50) | Yes |  |
| `pLoai_ps` | NVARCHAR(10) | Yes |  |
| `pTk_01` | NVARCHAR(10) | Yes |  |
| `pTk_02` | NVARCHAR(10) | Yes |  |
| `pIsPrint` | BIT | Yes |  |
| `pIsItalic` | BIT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLUpdMAUBctcTmVI211

- **Class:** AsGLUpdMAUBctcTmVI211
- **Description:** Stored procedure asGLUpdMAUBctcTmVI211
- **SQL File:** `asGLUpdMAUBctcTmVI211.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |
| `pChi_tieu` | nvarchar(255) | Yes |  |
| `pNd_chtieu` | nvarchar(max) | Yes |  |
| `pCach_tinh` | nvarchar(50) | Yes |  |
| `pTk_01` | nvarchar(10) | Yes |  |
| `pgia_tri_dk` | DECIMAL(19 | Yes |  |
| `plai_suat_dk` | NVARCHAR(50) | No |  (default: '') |
| `pky_han_dk` | NVARCHAR(50) | No |  (default: '') |
| `pgia_tri_ck` | DECIMAL(19 | Yes |  |
| `plai_suat_ck` | NVARCHAR(50) | No |  (default: '') |
| `pky_han_ck` | NVARCHAR(50) | No |  (default: '') |
| `pIsprint` | bit | Yes |  |
| `pIsitalic` | bit | Yes |  |
| `pBold` | bit | Yes |  |
| `pModify` | bit | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdMauBs

- **Class:** AsGLUpdMauBs
- **Description:** Stored procedure asGLUpdMauBs
- **SQL File:** `asGLUpdMauBs.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asGLUpdMauCf1

- **Class:** AsGLUpdMauCf1
- **Description:** Stored procedure asGLUpdMauCf1
- **SQL File:** `asGLUpdMauCf1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMau` | NVARCHAR(3) | Yes |  |
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pStt` | INT | Yes |  |
| `pBold` | BIT | Yes |  |
| `pIn_ck` | BIT | Yes |  |
| `pChi_tieu` | NVARCHAR(255) | Yes |  |
| `pMa_so` | NVARCHAR(3) | Yes |  |
| `pCach_tinh` | NVARCHAR(255) | Yes |  |
| `pTk_no` | NVARCHAR(100) | Yes |  |
| `pTk_co` | NVARCHAR(100) | Yes |  |
| `pDau` | BIT | Yes |  |
| `pTm` | NVARCHAR(55) | Yes |  |
| `pLoai_ps` | NVARCHAR(1) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLUpdMauPl1

- **Class:** AsGLUpdMauPl1
- **Description:** Stored procedure asGLUpdMauPl1
- **SQL File:** `asGLUpdMauPl1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asGLUpdNB

- **Class:** AsGLUpdNB
- **Description:** Stored procedure asGLUpdNB
- **SQL File:** `asGLUpdNB.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pPs_co` | decimal(19 | Yes |  |
| `pPs_co_nt` | decimal(19 | Yes |  |
| `pPs_no` | decimal(19 | Yes |  |
| `pPs_no_nt` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdPh1

- **Class:** AsGLUpdPh1
- **Description:** Stored procedure asGLUpdPh1
- **SQL File:** `asGLUpdPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pKht_thue_vao` | bit | Yes |  |
| `pKht_thue_ra` | bit | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_thue_vao` | decimal(19 | Yes |  |
| `pT_thue_ra` | decimal(19 | Yes |  |
| `pT_thue_vao_nt` | decimal(19 | Yes |  |
| `pT_thue_ra_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLUpdmauBctc06

- **Class:** AsGLUpdmauBctc06
- **Description:** Stored procedure asGLUpdmauBctc06
- **SQL File:** `asGLUpdmauBctc06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |
| `pChi_tieu` | nvarchar(100) | Yes |  |
| `pDvt` | nvarchar(10) | Yes |  |
| `pGia_tri` | decimal | Yes |  |
| `pRep_ref` | nvarchar(20) | Yes |  |
| `pMa_so_ref` | nvarchar(20) | Yes |  |
| `pCach_tinh` | nvarchar(100) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pIn_ck` | nvarchar(1) | Yes |  |
| `pBold` | bit | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Delete Procedures

### asGLDelBudget

- **Class:** AsGLDelBudget
- **Description:** Stored procedure asGLDelBudget
- **SQL File:** `asGLDelBudget.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_cty` | nvarchar(3) | Yes |  |

---

### asGLDelCRCt1

- **Class:** AsGLDelCRCt1
- **Description:** Stored procedure asGLDelCRCt1
- **SQL File:** `asGLDelCRCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asGLDelCRPh1

- **Class:** AsGLDelCRPh1
- **Description:** Stored procedure asGLDelCRPh1
- **SQL File:** `asGLDelCRPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asGLDelCdTk

- **Class:** AsGLDelCdTk
- **Description:** Stored procedure asGLDelCdTk
- **SQL File:** `asGLDelCdTk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |

---

### asGLDelCt1

- **Class:** AsGLDelCt1
- **Description:** Stored procedure asGLDelCt1
- **SQL File:** `asGLDelCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asGLDelDGTG

- **Class:** AsGLDelDGTG
- **Description:** Stored procedure asGLDelDGTG
- **SQL File:** `asGLDelDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pngay1` | smalldatetime | Yes |  |
| `pngay2` | smalldatetime | Yes |  |
| `pstt` | int | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLDelDMCTGS

- **Class:** AsGLDelDMCTGS
- **Description:** Stored procedure asGLDelDMCTGS
- **SQL File:** `asGLDelDMCTGS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |

---

### asGLDelDMDGTG

- **Class:** AsGLDelDMDGTG
- **Description:** Stored procedure asGLDelDMDGTG
- **SQL File:** `asGLDelDMDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pLoai_dg` | nvarchar(1) | Yes |  |
| `pTk_dgtg` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSTT` | int | Yes |  |

---

### asGLDelDMKC

- **Class:** AsGLDelDMKC
- **Description:** Stored procedure asGLDelDMKC
- **SQL File:** `asGLDelDMKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pModuleID` | nvarchar(2) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_du` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSTT` | int | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLDelDMTK

- **Class:** AsGLDelDMTK
- **Description:** Stored procedure asGLDelDMTK
- **SQL File:** `asGLDelDMTK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |

---

### asGLDelKC

- **Class:** AsGLDelKC
- **Description:** Stored procedure asGLDelKC
- **SQL File:** `asGLDelKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pngay1` | smalldatetime | Yes |  |
| `pngay2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_du` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLDelMAUBCTCTMI

- **Class:** AsGLDelMAUBCTCTMI
- **Description:** :	Xoá thuyết minh BCTC mục I,II,III,IV
- **SQL File:** `asGLDelMAUBCTCTMI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMIX

- **Class:** AsGLDelMAUBCTCTMIX
- **Description:** Stored procedure asGLDelMAUBCTCTMIX
- **SQL File:** `asGLDelMAUBCTCTMIX.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI01

- **Class:** AsGLDelMAUBCTCTMVI01
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI02B

- **Class:** AsGLDelMAUBCTCTMVI02B
- **Description:** Stored procedure asGLDelMAUBCTCTMVI02B
- **SQL File:** `asGLDelMAUBCTCTMVI02B.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI02a

- **Class:** AsGLDelMAUBCTCTMVI02a
- **Description:** Stored procedure asGLDelMAUBCTCTMVI02a
- **SQL File:** `asGLDelMAUBCTCTMVI02a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI02c

- **Class:** AsGLDelMAUBCTCTMVI02c
- **Description:** Stored procedure asGLDelMAUBCTCTMVI02c
- **SQL File:** `asGLDelMAUBCTCTMVI02c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |

---

### asGLDelMAUBCTCTMVI03

- **Class:** AsGLDelMAUBCTCTMVI03
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI04

- **Class:** AsGLDelMAUBCTCTMVI04
- **Description:** Stored procedure asGLDelMAUBCTCTMVI04
- **SQL File:** `asGLDelMAUBCTCTMVI04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI05

- **Class:** AsGLDelMAUBCTCTMVI05
- **Description:** Stored procedure asGLDelMAUBCTCTMVI05
- **SQL File:** `asGLDelMAUBCTCTMVI05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI06

- **Class:** AsGLDelMAUBCTCTMVI06
- **Description:** Stored procedure asGLDelMAUBCTCTMVI06
- **SQL File:** `asGLDelMAUBCTCTMVI06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |

---

### asGLDelMAUBCTCTMVI0708

- **Class:** AsGLDelMAUBCTCTMVI0708
- **Description:** Stored procedure asGLDelMAUBCTCTMVI0708
- **SQL File:** `asGLDelMAUBCTCTMVI0708.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI08b

- **Class:** AsGLDelMAUBCTCTMVI08b
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI08b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI10

- **Class:** AsGLDelMAUBCTCTMVI10
- **Description:** Stored procedure asGLDelMAUBCTCTMVI10
- **SQL File:** `asGLDelMAUBCTCTMVI10.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI11

- **Class:** AsGLDelMAUBCTCTMVI11
- **Description:** Stored procedure asGLDelMAUBCTCTMVI11
- **SQL File:** `asGLDelMAUBCTCTMVI11.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI12

- **Class:** AsGLDelMAUBCTCTMVI12
- **Description:** Stored procedure asGLDelMAUBCTCTMVI12
- **SQL File:** `asGLDelMAUBCTCTMVI12.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI13

- **Class:** AsGLDelMAUBCTCTMVI13
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI13.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI15C

- **Class:** AsGLDelMAUBCTCTMVI15C
- **Description:** : Thuyết minh BCTC mục V.20C
- **SQL File:** `asGLDelMAUBCTCTMVI15C.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI15a

- **Class:** AsGLDelMAUBCTCTMVI15a
- **Description:** Stored procedure asGLDelMAUBCTCTMVI15a
- **SQL File:** `asGLDelMAUBCTCTMVI15a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |

---

### asGLDelMAUBCTCTMVI15d

- **Class:** AsGLDelMAUBCTCTMVI15d
- **Description:** Stored procedure asGLDelMAUBCTCTMVI15d
- **SQL File:** `asGLDelMAUBCTCTMVI15d.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI16

- **Class:** AsGLDelMAUBCTCTMVI16
- **Description:** Stored procedure asGLDelMAUBCTCTMVI16
- **SQL File:** `asGLDelMAUBCTCTMVI16.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI17

- **Class:** AsGLDelMAUBCTCTMVI17
- **Description:** Stored procedure asGLDelMAUBCTCTMVI17
- **SQL File:** `asGLDelMAUBCTCTMVI17.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `ret` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI18

- **Class:** AsGLDelMAUBCTCTMVI18
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI18.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI211

- **Class:** AsGLDelMAUBCTCTMVI211
- **Description:** Stored procedure asGLDelMAUBCTCTMVI211
- **SQL File:** `asGLDelMAUBCTCTMVI211.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |

---

### asGLDelMAUBCTCTMVI212

- **Class:** AsGLDelMAUBCTCTMVI212
- **Description:** Stored procedure asGLDelMAUBCTCTMVI212
- **SQL File:** `asGLDelMAUBCTCTMVI212.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI23

- **Class:** AsGLDelMAUBCTCTMVI23
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI23.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI25a

- **Class:** AsGLDelMAUBCTCTMVI25a
- **Description:** Stored procedure asGLDelMAUBCTCTMVI25a
- **SQL File:** `asGLDelMAUBCTCTMVI25a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI25b

- **Class:** AsGLDelMAUBCTCTMVI25b
- **Description:** : Xoá	thuyết minh BCTC mục V.01
- **SQL File:** `asGLDelMAUBCTCTMVI25b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVI29b

- **Class:** AsGLDelMAUBCTCTMVI29b
- **Description:** Stored procedure asGLDelMAUBCTCTMVI29b
- **SQL File:** `asGLDelMAUBCTCTMVI29b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVII

- **Class:** AsGLDelMAUBCTCTMVII
- **Description:** :	Xoá thuyết minh BCTC mục VI
- **SQL File:** `asGLDelMAUBCTCTMVII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMAUBCTCTMVIII

- **Class:** AsGLDelMAUBCTCTMVIII
- **Description:** :	Xoá thuyết minh BCTC mục VII
- **SQL File:** `asGLDelMAUBCTCTMVIII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pMa_so` | NVARCHAR(10) | Yes |  |
| `pRet` | INT | Yes |  |

---

### asGLDelMauBs

- **Class:** AsGLDelMauBs
- **Description:** Stored procedure asGLDelMauBs
- **SQL File:** `asGLDelMauBs.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '200') |
| `pMau` | NVARCHAR(10) | No |  (default: '01') |
| `pMa_so` | NVARCHAR(8) | No |  (default: '110') |
| `pRet` | INT (output) | No |  (default: 0 OUTPUT   -- 0: duoc xoa) |

---

### asGLDelMauCf1

- **Class:** AsGLDelMauCf1
- **Description:** Stored procedure asGLDelMauCf1
- **SQL File:** `asGLDelMauCf1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pMau` | NVARCHAR(3) | Yes |  |
| `pMa_so` | NVARCHAR(3) | Yes |  |

---

### asGLDelNB

- **Class:** AsGLDelNB
- **Description:** Stored procedure asGLDelNB
- **SQL File:** `asGLDelNB.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asGLDelPh1

- **Class:** AsGLDelPh1
- **Description:** Stored procedure asGLDelPh1
- **SQL File:** `asGLDelPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asGLDelmauBctc06

- **Class:** AsGLDelmauBctc06
- **Description:** Stored procedure asGLDelmauBctc06
- **SQL File:** `asGLDelmauBctc06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt` | nvarchar(10) | Yes |  |
| `pMa_so` | nvarchar(10) | Yes |  |

---

### asGLRptBCTCTMDel

- **Class:** AsGLRptBCTCTMDel
- **Description:** :	Xoá dữ liệu cũ trong bảng glbctctm
- **SQL File:** `asGLRptBCTCTMDel.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTab_Name` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

## Get Procedures

### asGLCR1GetMaSo_MaBang

- **Class:** AsGLCR1GetMaSo_MaBang
- **Description:** :	Lấy mã số + bảng tương ứng với TK
- **SQL File:** `asGLCR1GetMaSo_MaBang.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |

---

### asGLGetBudget

- **Class:** AsGLGetBudget
- **Description:** Stored procedure asGLGetBudget
- **SQL File:** `asGLGetBudget.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | varchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pMa_tk` | NVARCHAR(20) | No |  (default: NULL) |
| `pMa_tk_du` | NVARCHAR(20) | No |  (default: NULL) |
| `pMa_bp` | NVARCHAR(20) | No |  (default: NULL) |
| `pMa_phi` | NVARCHAR(20) | No |  (default: NULL) |
| `pMa_spct` | NVARCHAR(20) | No |  (default: NULL) |
| `pTtps_no_co` | NVARCHAR(10) | No |  (default: NULL) |

---

### asGLGetCRCt1

- **Class:** AsGLGetCRCt1
- **Description:** Stored procedure asGLGetCRCt1
- **SQL File:** `asGLGetCRCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetCRph1

- **Class:** AsGLGetCRph1
- **Description:** Stored procedure asGLGetCRph1
- **SQL File:** `asGLGetCRph1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetCdTk

- **Class:** AsGLGetCdTk
- **Description:** Stored procedure asGLGetCdTk
- **SQL File:** `asGLGetCdTk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |

---

### asGLGetCt1

- **Class:** AsGLGetCt1
- **Description:** Stored procedure asGLGetCt1
- **SQL File:** `asGLGetCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asGLGetDMCTGS

- **Class:** AsGLGetDMCTGS
- **Description:** Stored procedure asGLGetDMCTGS
- **SQL File:** `asGLGetDMCTGS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_ct` | NVARCHAR(3) | No |  (default: NULL) |

---

### asGLGetDMDGTG

- **Class:** AsGLGetDMDGTG
- **Description:** Stored procedure asGLGetDMDGTG
- **SQL File:** `asGLGetDMDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pLoai_dg` | nvarchar(1) | No |  (default: null) |
| `pTk_dgtg` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetDMKC

- **Class:** AsGLGetDMKC
- **Description:** Stored procedure asGLGetDMKC
- **SQL File:** `asGLGetDMKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pModuleid` | nvarchar(2) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetDMKC4KC

- **Class:** AsGLGetDMKC4KC
- **Description:** Stored procedure asGLGetDMKC4KC
- **SQL File:** `asGLGetDMKC4KC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pModuleid` | nvarchar(2) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetDMTK

- **Class:** AsGLGetDMTK
- **Description:** Stored procedure asGLGetDMTK
- **SQL File:** `asGLGetDMTK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pTk` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetDMTK_Parent

- **Class:** AsGLGetDMTK_Parent
- **Description:** Stored procedure asGLGetDMTK_Parent
- **SQL File:** `asGLGetDMTK_Parent.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pTk` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetMAUBCTCTMI

- **Class:** AsGLGetMAUBCTCTMI
- **Description:** :	Lấy thuyết minh BCTC mục I,II,III,IV
- **SQL File:** `asGLGetMAUBCTCTMI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMIX

- **Class:** AsGLGetMAUBCTCTMIX
- **Description:** Stored procedure asGLGetMAUBCTCTMIX
- **SQL File:** `asGLGetMAUBCTCTMIX.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI01

- **Class:** AsGLGetMAUBCTCTMVI01
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI02B

- **Class:** AsGLGetMAUBCTCTMVI02B
- **Description:** Stored procedure asGLGetMAUBCTCTMVI02B
- **SQL File:** `asGLGetMAUBCTCTMVI02B.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI02a

- **Class:** AsGLGetMAUBCTCTMVI02a
- **Description:** Stored procedure asGLGetMAUBCTCTMVI02a
- **SQL File:** `asGLGetMAUBCTCTMVI02a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI02c

- **Class:** AsGLGetMAUBCTCTMVI02c
- **Description:** Stored procedure asGLGetMAUBCTCTMVI02c
- **SQL File:** `asGLGetMAUBCTCTMVI02c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMau` | nvarchar(10) | No |  (default: null) |
| `pMa_so` | nvarchar(10) | No |  (default: null) |

---

### asGLGetMAUBCTCTMVI03

- **Class:** AsGLGetMAUBCTCTMVI03
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI04

- **Class:** AsGLGetMAUBCTCTMVI04
- **Description:** Stored procedure asGLGetMAUBCTCTMVI04
- **SQL File:** `asGLGetMAUBCTCTMVI04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI05

- **Class:** AsGLGetMAUBCTCTMVI05
- **Description:** Stored procedure asGLGetMAUBCTCTMVI05
- **SQL File:** `asGLGetMAUBCTCTMVI05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI06

- **Class:** AsGLGetMAUBCTCTMVI06
- **Description:** Stored procedure asGLGetMAUBCTCTMVI06
- **SQL File:** `asGLGetMAUBCTCTMVI06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMau` | nvarchar(10) | No |  (default: null) |
| `pMa_so` | nvarchar(10) | No |  (default: null) |

---

### asGLGetMAUBCTCTMVI0708

- **Class:** AsGLGetMAUBCTCTMVI0708
- **Description:** Stored procedure asGLGetMAUBCTCTMVI0708
- **SQL File:** `asGLGetMAUBCTCTMVI0708.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI08b

- **Class:** AsGLGetMAUBCTCTMVI08b
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI08b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI09

- **Class:** AsGLGetMAUBCTCTMVI09
- **Description:** Stored procedure asGLGetMAUBCTCTMVI09
- **SQL File:** `asGLGetMAUBCTCTMVI09.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI10

- **Class:** AsGLGetMAUBCTCTMVI10
- **Description:** Stored procedure asGLGetMAUBCTCTMVI10
- **SQL File:** `asGLGetMAUBCTCTMVI10.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI11

- **Class:** AsGLGetMAUBCTCTMVI11
- **Description:** Stored procedure asGLGetMAUBCTCTMVI11
- **SQL File:** `asGLGetMAUBCTCTMVI11.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI12

- **Class:** AsGLGetMAUBCTCTMVI12
- **Description:** Stored procedure asGLGetMAUBCTCTMVI12
- **SQL File:** `asGLGetMAUBCTCTMVI12.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI13

- **Class:** AsGLGetMAUBCTCTMVI13
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI13.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI15a

- **Class:** AsGLGetMAUBCTCTMVI15a
- **Description:** Stored procedure asGLGetMAUBCTCTMVI15a
- **SQL File:** `asGLGetMAUBCTCTMVI15a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMau` | nvarchar(10) | No |  (default: null) |
| `pMa_so` | nvarchar(10) | No |  (default: null) |

---

### asGLGetMAUBCTCTMVI15d

- **Class:** AsGLGetMAUBCTCTMVI15d
- **Description:** Stored procedure asGLGetMAUBCTCTMVI15d
- **SQL File:** `asGLGetMAUBCTCTMVI15d.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |

---

### asGLGetMAUBCTCTMVI16

- **Class:** AsGLGetMAUBCTCTMVI16
- **Description:** Stored procedure asGLGetMAUBCTCTMVI16
- **SQL File:** `asGLGetMAUBCTCTMVI16.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |

---

### asGLGetMAUBCTCTMVI17

- **Class:** AsGLGetMAUBCTCTMVI17
- **Description:** Stored procedure asGLGetMAUBCTCTMVI17
- **SQL File:** `asGLGetMAUBCTCTMVI17.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |

---

### asGLGetMAUBCTCTMVI18

- **Class:** AsGLGetMAUBCTCTMVI18
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI18.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI212

- **Class:** AsGLGetMAUBCTCTMVI212
- **Description:** Stored procedure asGLGetMAUBCTCTMVI212
- **SQL File:** `asGLGetMAUBCTCTMVI212.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI23

- **Class:** AsGLGetMAUBCTCTMVI23
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI23.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI25a

- **Class:** AsGLGetMAUBCTCTMVI25a
- **Description:** Stored procedure asGLGetMAUBCTCTMVI25a
- **SQL File:** `asGLGetMAUBCTCTMVI25a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI25b

- **Class:** AsGLGetMAUBCTCTMVI25b
- **Description:** : Lấy	thuyết minh BCTC mục V.01
- **SQL File:** `asGLGetMAUBCTCTMVI25b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVI29b

- **Class:** AsGLGetMAUBCTCTMVI29b
- **Description:** Stored procedure asGLGetMAUBCTCTMVI29b
- **SQL File:** `asGLGetMAUBCTCTMVI29b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVII

- **Class:** AsGLGetMAUBCTCTMVII
- **Description:** :	Thuyết minh BCTC mục VI
- **SQL File:** `asGLGetMAUBCTCTMVII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTMVIII

- **Class:** AsGLGetMAUBCTCTMVIII
- **Description:** :	Thuyết minh BCTC mục VII
- **SQL File:** `asGLGetMAUBCTCTMVIII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBCTCTmVI15c

- **Class:** AsGLGetMAUBCTCTmVI15c
- **Description:** : Thuyết minh BCTC mục V.20C
- **SQL File:** `asGLGetMAUBCTCTmVI15c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |

---

### asGLGetMAUBctcTmVI211

- **Class:** AsGLGetMAUBctcTmVI211
- **Description:** Stored procedure asGLGetMAUBctcTmVI211
- **SQL File:** `asGLGetMAUBctcTmVI211.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMau` | nvarchar(10) | No |  (default: null) |
| `pMa_so` | nvarchar(10) | No |  (default: null) |

---

### asGLGetMaNTBudget

- **Class:** AsGLGetMaNTBudget
- **Description:** Stored procedure asGLGetMaNTBudget
- **SQL File:** `asGLGetMaNTBudget.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |

---

### asGLGetMauBs

- **Class:** AsGLGetMauBs
- **Description:** Stored procedure asGLGetMauBs
- **SQL File:** `asGLGetMauBs.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '999') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '48') |
| `pMau` | nvarchar(10) | No |  (default: '01') |

---

### asGLGetMauCf1

- **Class:** AsGLGetMauCf1
- **Description:** Stored procedure asGLGetMauCf1
- **SQL File:** `asGLGetMauCf1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '48') |
| `pMau` | NVARCHAR(10) | No |  (default: '01') |

---

### asGLGetMauPl1

- **Class:** AsGLGetMauPl1
- **Description:** Stored procedure asGLGetMauPl1
- **SQL File:** `asGLGetMauPl1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '999') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '200') |
| `pMau` | nvarchar(3) | No |  (default: '01') |

---

### asGLGetNB

- **Class:** AsGLGetNB
- **Description:** Stored procedure asGLGetNB
- **SQL File:** `asGLGetNB.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetPh1

- **Class:** AsGLGetPh1
- **Description:** Stored procedure asGLGetPh1
- **SQL File:** `asGLGetPh1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLGetmauBctc06

- **Class:** AsGLGetmauBctc06
- **Description:** Stored procedure asGLGetmauBctc06
- **SQL File:** `asGLGetmauBctc06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(3) | No |  (default: '') |

---

## Filter Procedures

### asGLFilt1

- **Class:** AsGLFilt1
- **Description:** Stored procedure asGLFilt1
- **SQL File:** `asGLFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asGLFiltCR1

- **Class:** AsGLFiltCR1
- **Description:** Stored procedure asGLFiltCR1
- **SQL File:** `asGLFiltCR1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

## Report Procedures

### asGLRptBCPT01

- **Class:** AsGLRptBCPT01
- **Description:** Stored procedure asGLRptBCPT01
- **SQL File:** `asGLRptBCPT01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNgay_Ct1` | smalldatetime | Yes |  |
| `pNgay_Ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3)
) | Yes |  |

---

### asGLRptBCPT02

- **Class:** AsGLRptBCPT02
- **Description:** Stored procedure asGLRptBCPT02
- **SQL File:** `asGLRptBCPT02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asGLRptBCPT04

- **Class:** AsGLRptBCPT04
- **Description:** Stored procedure asGLRptBCPT04
- **SQL File:** `asGLRptBCPT04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pThang1` | int | Yes |  |
| `pThang2` | int | Yes |  |
| `pQuyThang` | nvarchar(1) | No |  (default: '1') |
| `pMau` | nvarchar(3) | No |  (default: '15') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |

---

### asGLRptBCPT05

- **Class:** AsGLRptBCPT05
- **Description:** Stored procedure asGLRptBCPT05
- **SQL File:** `asGLRptBCPT05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | varchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pTK` | nvarchar(20) | Yes |  |
| `pMa_phi` | nvarchar(10) | Yes |  |
| `pMa_BP` | nvarchar(10) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pGroup1` | nvarchar(20) | No |  (default: 'TK') |
| `pGroup2` | nvarchar(20) | No |  (default: '') |
| `pGroup3` | nvarchar(20) | No |  (default: '') |
| `pGroup4` | nvarchar(20) | No |  (default: '') |

---

### asGLRptBCPT08

- **Class:** AsGLRptBCPT08
- **Description:** Stored procedure asGLRptBCPT08
- **SQL File:** `asGLRptBCPT08.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |

---

### asGLRptBCT01

- **Class:** AsGLRptBCT01
- **Description:** Stored procedure asGLRptBCT01
- **SQL File:** `asGLRptBCT01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20151001') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20151031') |
| `pThue_suat` | INT | No |  (default: 5) |
| `pTk_thue` | NVARCHAR(20) | No |  (default: '13311') |
| `pTk_du` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMau_bc` | INT | No |  (default: 1) |

---

### asGLRptBCT02

- **Class:** AsGLRptBCT02
- **Description:** Stored procedure asGLRptBCT02
- **SQL File:** `asGLRptBCT02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pThue_suat` | NUMERIC | No |  (default: 0) |
| `pTk` | NVARCHAR(20) | No |  (default: '') |
| `pTk_du` | NVARCHAR(20) | No |  (default: '') |

---

### asGLRptBCT03

- **Class:** AsGLRptBCT03
- **Description:** Stored procedure asGLRptBCT03
- **SQL File:** `asGLRptBCT03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: 'A01') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150201') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150228') |

---

### asGLRptBCT03_dieuchinh

- **Class:** AsGLRptBCT03_dieuchinh
- **Description:** :	Thêm, sửa, xoá điều chỉnh tăng, giảm thuế GTGT kỳ trước
- **SQL File:** `asGLRptBCT03_dieuchinh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pThang1` | INT | Yes |  |
| `pThang2` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pStt_rec` | DECIMAL(18 | Yes |  |
| `pDoanh_so` | DECIMAL(19 | Yes |  |
| `pThue` | DECIMAL(19 | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asGLRptBCT04

- **Class:** AsGLRptBCT04
- **Description:** Stored procedure asGLRptBCT04
- **SQL File:** `asGLRptBCT04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMau` | CHAR(3) | No |  (default: '01') |

---

### asGLRptBCT05

- **Class:** AsGLRptBCT05
- **Description:** Stored procedure asGLRptBCT05
- **SQL File:** `asGLRptBCT05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMau` | CHAR(3) | No |  (default: '01') |

---

### asGLRptBCT06

- **Class:** AsGLRptBCT06
- **Description:** Stored procedure asGLRptBCT06
- **SQL File:** `asGLRptBCT06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMau` | CHAR(3) | No |  (default: '01') |

---

### asGLRptBCTC01

- **Class:** AsGLRptBCTC01
- **Description:** Stored procedure asGLRptBCTC01
- **SQL File:** `asGLRptBCTC01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `Ngay_ct1` | smalldatetime | Yes |  |
| `Ngay_ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | No |  (default: '') |
| `pBac_tk` | INT | No |  (default: 9) |
| `pTk_sc` | BIT | No |  (default: 0) |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |

---

### asGLRptBCTC02

- **Class:** AsGLRptBCTC02
- **Description:** Stored procedure asGLRptBCTC02
- **SQL File:** `asGLRptBCTC02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: '111') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '200') |
| `pNgay` | smalldatetime | No |  (default: '20151231') |
| `pChiTieuCoSoLieu` | bit | No |  (default: 0) |
| `pMau` | nvarchar(10) | No |  (default: '01') |
| `pDest` | nvarchar(50) | No |  (default: '') |

---

### asGLRptBCTC02_CheckSL

- **Class:** AsGLRptBCTC02_CheckSL
- **Description:** Stored procedure asGLRptBCTC02_CheckSL
- **SQL File:** `asGLRptBCTC02_CheckSL.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: 'GBB') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '200') |
| `pNgay` | smalldatetime | No |  (default: '20130331') |
| `pChiTieuCoSoLieu` | bit | No |  (default: 0) |
| `pMau` | nvarchar(10) | No |  (default: '01') |
| `pDest` | nvarchar(50) | No |  (default: '') |

---

### asGLRptBCTC03

- **Class:** AsGLRptBCTC03
- **Description:** Stored procedure asGLRptBCTC03
- **SQL File:** `asGLRptBCTC03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | No |  (default: 'GBB') |
| `pQd_cdkt` | nvarchar(10) | No |  (default: '200') |
| `pNgay_Ct1` | SMALLDATETIME | No |  (default: '2012-01-01') |
| `pNgay_Ct2` | SMALLDATETIME | No |  (default: '2012-12-31') |
| `pNgay_Ct01` | SMALLDATETIME | No |  (default: '2011-01-01') |
| `pNgay_Ct02` | SMALLDATETIME | No |  (default: '2011-12-31') |
| `pMau` | CHAR(3) | No |  (default: '15') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pDest` | NVARCHAR(50) | No |  (default: '') |

---

### asGLRptBCTC04

- **Class:** AsGLRptBCTC04
- **Description:** Stored procedure asGLRptBCTC04
- **SQL File:** `asGLRptBCTC04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pQd_cdkt` | nvarchar(10) | Yes |  |
| `pNgay_Ct1` | smalldatetime | Yes |  |
| `pNgay_Ct2` | smalldatetime | Yes |  |
| `pNgay_Ct01` | smalldatetime | Yes |  |
| `pNgay_Ct02` | smalldatetime | Yes |  |
| `pMau` | char(30) | No |  (default: '') |

---

### asGLRptBCTC05

- **Class:** AsGLRptBCTC05
- **Description:** Stored procedure asGLRptBCTC05
- **SQL File:** `asGLRptBCTC05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNgay_Ct1` | smalldatetime | Yes |  |
| `pNgay_Ct2` | smalldatetime | Yes |  |
| `pNgay_Ct01` | smalldatetime | Yes |  |
| `pNgay_Ct02` | smalldatetime | Yes |  |
| `pMau` | char(3) | No |  (default: '15') |
| `pMa_bp` | nvarchar(20) | No |  (default: '') |
| `pMa_Nt` | nvarchar(3) | No |  (default: '') |

---

### asGLRptBCTCCDTb02

- **Class:** AsGLRptBCTCCDTb02
- **Description:** Stored procedure asGLRptBCTCCDTb02
- **SQL File:** `asGLRptBCTCCDTb02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: 'CDT') |
| `Ngay_ct1` | smalldatetime | No |  (default: '01-01-2010') |
| `Ngay_ct2` | smalldatetime | No |  (default: '10-31-2010') |
| `pTk` | nvarchar(20) | No |  (default: '441) |

---

### asGLRptBCTCCDTf02

- **Class:** AsGLRptBCTCCDTf02
- **Description:** Stored procedure asGLRptBCTCCDTf02
- **SQL File:** `asGLRptBCTCCDTf02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: 'CDT') |
| `Ngay_ct1` | SMALLDATETIME | No |  (default: '01/01/2010') |
| `Ngay_ct2` | SMALLDATETIME | No |  (default: '01/31/2013') |
| `pTk` | nvarchar(20) | No |  (default: '441') |
| `pMa_spct` | nvarchar(20) | No |  (default: '') |

---

### asGLRptBCTCCR01

- **Class:** AsGLRptBCTCCR01
- **Description:** Stored procedure asGLRptBCTCCR01
- **SQL File:** `asGLRptBCTCCR01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `Ngay_ct1` | smalldatetime | Yes |  |
| `Ngay_ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | No |  (default: '') |
| `pBac_tk` | INT | No |  (default: 9) |

---

### asGLRptBCTCCR01CtrlF5

- **Class:** AsGLRptBCTCCR01CtrlF5
- **Description:** Stored procedure asGLRptBCTCCR01CtrlF5
- **SQL File:** `asGLRptBCTCCR01CtrlF5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pNgay_ct1` | SMALLDATETIME | Yes |  |
| `pNgay_ct2` | SMALLDATETIME | Yes |  |
| `pMa_Nt` | NVARCHAR(3)
) | Yes |  |

---

### asGLRptBCTCCR01F5

- **Class:** AsGLRptBCTCCR01F5
- **Description:** Stored procedure asGLRptBCTCCR01F5
- **SQL File:** `asGLRptBCTCCR01F5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `Ngay_ct1` | SMALLDATETIME | Yes |  |
| `Ngay_ct2` | SMALLDATETIME | Yes |  |
| `pNhom_tk` | nvarchar(1) | Yes |  |
| `pMa_nt` | NVARCHAR(3)
) | Yes |  |

---

### asGLRptBCTCCR01ShiftF5

- **Class:** AsGLRptBCTCCR01ShiftF5
- **Description:** Stored procedure asGLRptBCTCCR01ShiftF5
- **SQL File:** `asGLRptBCTCCR01ShiftF5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCCR02

- **Class:** AsGLRptBCTCCR02
- **Description:** Stored procedure asGLRptBCTCCR02
- **SQL File:** `asGLRptBCTCCR02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: 'CR') |
| `pNam` | int | No |  (default: 2013) |
| `pNgay` | smalldatetime | No |  (default: '08/23/2013') |
| `pChiTieuCoSoLieu` | bit | No |  (default: 0) |
| `pMau` | nvarchar(10) | No |  (default: '01') |
| `pDest` | nvarchar(50) | No |  (default: '') |

---

### asGLRptBCTCCR03

- **Class:** AsGLRptBCTCCR03
- **Description:** Stored procedure asGLRptBCTCCR03
- **SQL File:** `asGLRptBCTCCR03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | No |  (default: 'CR') |
| `pNam` | int | No |  (default: 2013) |
| `pNgay_Ct1` | SMALLDATETIME | No |  (default: '2013-01-01') |
| `pNgay_Ct2` | SMALLDATETIME | No |  (default: '2013-01-31') |
| `pNgay_Ct01` | SMALLDATETIME | No |  (default: '2013-01-01') |
| `pNgay_Ct02` | SMALLDATETIME | No |  (default: '2013-01-31') |
| `pMau` | CHAR(3) | No |  (default: '15') |
| `pDest` | NVARCHAR(50) | No |  (default: '') |

---

### asGLRptBCTCCR04

- **Class:** AsGLRptBCTCCR04
- **Description:** Stored procedure asGLRptBCTCCR04
- **SQL File:** `asGLRptBCTCCR04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | No |  (default: 'CR') |
| `pNam` | int | No |  (default: 2013) |
| `pNgay_Ct1` | smalldatetime | No |  (default: '20130101') |
| `pNgay_Ct2` | smalldatetime | No |  (default: '20130131') |
| `pNgay_Ct01` | smalldatetime | No |  (default: '20130101') |
| `pNgay_Ct02` | smalldatetime | No |  (default: '20130131') |
| `pMau` | char(30) | No |  (default: '') |

---

### asGLRptBCTCTM

- **Class:** AsGLRptBCTCTM
- **Description:** :	Thuyet minh BCTC: Nhận tham số cho các subreport
- **SQL File:** `asGLRptBCTCTM.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMCal

- **Class:** AsGLRptBCTCTMCal
- **Description:** :	Tính lại giá trị cho bảng glbctctm
- **SQL File:** `asGLRptBCTCTMCal.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: N'999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2014-12-31 00:00:00') |
| `pTab_Name` | NVARCHAR(20) | No |  (default: N'VI01') |
| `pRet` | INT (output) | No |  (default: 6 OUTPUT) |

---

### asGLRptBCTCTMI

- **Class:** AsGLRptBCTCTMI
- **Description:** :	Báo cáo thuyết minh BCTC mục I,II,III,IV
- **SQL File:** `asGLRptBCTCTMI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMIX

- **Class:** AsGLRptBCTCTMIX
- **Description:** Stored procedure asGLRptBCTCTMIX
- **SQL File:** `asGLRptBCTCTMIX.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI01

- **Class:** AsGLRptBCTCTMVI01
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI02B

- **Class:** AsGLRptBCTCTMVI02B
- **Description:** Stored procedure asGLRptBCTCTMVI02B
- **SQL File:** `asGLRptBCTCTMVI02B.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI02a

- **Class:** AsGLRptBCTCTMVI02a
- **Description:** Stored procedure asGLRptBCTCTMVI02a
- **SQL File:** `asGLRptBCTCTMVI02a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2014-12-31 00:00:00') |

---

### asGLRptBCTCTMVI02c

- **Class:** AsGLRptBCTCTMVI02c
- **Description:** Stored procedure asGLRptBCTCTMVI02c
- **SQL File:** `asGLRptBCTCTMVI02c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2014-12-31 00:00:00') |

---

### asGLRptBCTCTMVI03

- **Class:** AsGLRptBCTCTMVI03
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI04

- **Class:** AsGLRptBCTCTMVI04
- **Description:** Stored procedure asGLRptBCTCTMVI04
- **SQL File:** `asGLRptBCTCTMVI04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI05

- **Class:** AsGLRptBCTCTMVI05
- **Description:** Stored procedure asGLRptBCTCTMVI05
- **SQL File:** `asGLRptBCTCTMVI05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI06

- **Class:** AsGLRptBCTCTMVI06
- **Description:** : Thuyết minh BCTC mục V.06
- **SQL File:** `asGLRptBCTCTMVI06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2014-12-31 00:00:00') |

---

### asGLRptBCTCTMVI0708

- **Class:** AsGLRptBCTCTMVI0708
- **Description:** Stored procedure asGLRptBCTCTMVI0708
- **SQL File:** `asGLRptBCTCTMVI0708.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI08b

- **Class:** AsGLRptBCTCTMVI08b
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI08b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI09

- **Class:** AsGLRptBCTCTMVI09
- **Description:** Stored procedure asGLRptBCTCTMVI09
- **SQL File:** `asGLRptBCTCTMVI09.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI10

- **Class:** AsGLRptBCTCTMVI10
- **Description:** Stored procedure asGLRptBCTCTMVI10
- **SQL File:** `asGLRptBCTCTMVI10.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI11

- **Class:** AsGLRptBCTCTMVI11
- **Description:** Stored procedure asGLRptBCTCTMVI11
- **SQL File:** `asGLRptBCTCTMVI11.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI12

- **Class:** AsGLRptBCTCTMVI12
- **Description:** Stored procedure asGLRptBCTCTMVI12
- **SQL File:** `asGLRptBCTCTMVI12.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI13

- **Class:** AsGLRptBCTCTMVI13
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI13.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI15D

- **Class:** AsGLRptBCTCTMVI15D
- **Description:** Stored procedure asGLRptBCTCTMVI15D
- **SQL File:** `asGLRptBCTCTMVI15D.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI15a

- **Class:** AsGLRptBCTCTMVI15a
- **Description:** Stored procedure asGLRptBCTCTMVI15a
- **SQL File:** `asGLRptBCTCTMVI15a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pTk_01` | NVARCHAR(20) | No |  (default: '311') |

---

### asGLRptBCTCTMVI16

- **Class:** AsGLRptBCTCTMVI16
- **Description:** Stored procedure asGLRptBCTCTMVI16
- **SQL File:** `asGLRptBCTCTMVI16.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI17

- **Class:** AsGLRptBCTCTMVI17
- **Description:** Stored procedure asGLRptBCTCTMVI17
- **SQL File:** `asGLRptBCTCTMVI17.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '01/01/2014') |
| `pNgay2` | SMALLDATETIME | No |  (default: '01/31/2014') |

---

### asGLRptBCTCTMVI18

- **Class:** AsGLRptBCTCTMVI18
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI18.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI212

- **Class:** AsGLRptBCTCTMVI212
- **Description:** Stored procedure asGLRptBCTCTMVI212
- **SQL File:** `asGLRptBCTCTMVI212.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI23

- **Class:** AsGLRptBCTCTMVI23
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI23.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI25a

- **Class:** AsGLRptBCTCTMVI25a
- **Description:** Stored procedure asGLRptBCTCTMVI25a
- **SQL File:** `asGLRptBCTCTMVI25a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |

---

### asGLRptBCTCTMVI25b

- **Class:** AsGLRptBCTCTMVI25b
- **Description:** : Sửa thuyết minh BCTC mục VI.01
- **SQL File:** `asGLRptBCTCTMVI25b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVI29b

- **Class:** AsGLRptBCTCTMVI29b
- **Description:** Stored procedure asGLRptBCTCTMVI29b
- **SQL File:** `asGLRptBCTCTMVI29b.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVII

- **Class:** AsGLRptBCTCTMVII
- **Description:** : Báo cáo thuyết minh BCTC mục VI
- **SQL File:** `asGLRptBCTCTMVII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBCTCTMVIII

- **Class:** AsGLRptBCTCTMVIII
- **Description:** : Báo cáo thuyết minh BCTC mục VII
- **SQL File:** `asGLRptBCTCTMVIII.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |

---

### asGLRptBCTCTmVI15c

- **Class:** AsGLRptBCTCTmVI15c
- **Description:** : Báo cáo thuyết minh BCTC mục V.20C
- **SQL File:** `asGLRptBCTCTmVI15c.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pMau` | NVARCHAR(10) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptBK01

- **Class:** AsGLRptBK01
- **Description:** Stored procedure asGLRptBK01
- **SQL File:** `asGLRptBK01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: 'GBB') |
| `pngay_ct1` | smalldatetime | No |  (default: '20120401') |
| `pngay_ct2` | smalldatetime | No |  (default: '20120630') |
| `pso_ct1` | nvarchar(12) | No |  (default: '') |
| `pso_ct2` | nvarchar(12) | No |  (default: '') |
| `ptk` | nvarchar(20) | No |  (default: '153') |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '') |
| `pma_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_Nhkh` | nvarchar(8) | No |  (default: '') |
| `pma_bp` | nvarchar(20) | No |  (default: '') |
| `pma_phi` | nvarchar(20) | No |  (default: '') |
| `pma_hd` | nvarchar(20) | No |  (default: '') |
| `pma_ku` | nvarchar(20) | No |  (default: '') |
| `pma_spct` | nvarchar(20) | No |  (default: '') |
| `pma_lo` | nvarchar(20) | No |  (default: '') |
| `pma_ct` | nvarchar(50) | No |  (default: '') |
| `pdien_giai` | nvarchar(255) | No |  (default: '') |
| `pma_nt` | nvarchar(3) | No |  (default: '') |

---

### asGLRptBK02

- **Class:** AsGLRptBK02
- **Description:** Stored procedure asGLRptBK02
- **SQL File:** `asGLRptBK02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: 'A01') |
| `pngay_ct1` | smalldatetime | No |  (default: '20150101') |
| `pngay_ct2` | smalldatetime | No |  (default: '20151231') |
| `pGroupType` | NVARCHAR(20) | No |  (default: 'MA_KH') |
| `pso_ct1` | nvarchar(12) | No |  (default: '') |
| `pso_ct2` | nvarchar(12) | No |  (default: '') |
| `ptk` | nvarchar(20) | No |  (default: '141') |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '') |
| `pma_kh` | nvarchar(20) | No |  (default: 'TC001') |
| `pMa_lo` | nvarchar(8) | No |  (default: '') |
| `pma_bp` | nvarchar(20) | No |  (default: '') |
| `pma_phi` | nvarchar(20) | No |  (default: '') |
| `pma_hd` | nvarchar(20) | No |  (default: '') |
| `pma_ku` | nvarchar(20) | No |  (default: '') |
| `pma_spct` | nvarchar(20) | No |  (default: '') |
| `pma_ct` | nvarchar(50) | No |  (default: '') |
| `pdien_giai` | nvarchar(255) | No |  (default: '') |
| `pan_mk` | nvarchar(1)		
		) | Yes |  |

---

### asGLRptBctcTmVI211

- **Class:** AsGLRptBctcTmVI211
- **Description:** : Thuyết minh BCTC mục V.06
- **SQL File:** `asGLRptBctcTmVI211.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '999') |
| `pMau` | NVARCHAR(10) | No |  (default: N'15') |
| `pNgay1` | SMALLDATETIME | No |  (default: '2014-01-01 00:00:00') |
| `pNgay2` | SMALLDATETIME | No |  (default: '2014-01-31 00:00:00') |

---

### asGLRptCR01

- **Class:** AsGLRptCR01
- **Description:** Stored procedure asGLRptCR01
- **SQL File:** `asGLRptCR01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `Ngay_ct1` | smalldatetime | Yes |  |
| `Ngay_ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | No |  (default: '') |
| `pBac_tk` | INT | No |  (default: 9) |
| `pTk_sc` | BIT | No |  (default: 0) |
| `pList_Ma_cty` | nvarchar(1000) | Yes |  |

---

### asGLRptCTGS01

- **Class:** AsGLRptCTGS01
- **Description:** Stored procedure asGLRptCTGS01
- **SQL File:** `asGLRptCTGS01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay_ct1` | SMALLDATETIME | Yes |  |
| `pNgay_ct2` | SMALLDATETIME | Yes |  |

---

### asGLRptCTGS02

- **Class:** AsGLRptCTGS02
- **Description:** Stored procedure asGLRptCTGS02
- **SQL File:** `asGLRptCTGS02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay_ct1` | SMALLDATETIME | Yes |  |
| `pNgay_ct2` | SMALLDATETIME | Yes |  |
| `pCtu1` | NVARCHAR(12) | No |  (default: '') |
| `pMa_Nt` | nvarchar(3) | Yes |  |

---

### asGLRptCTGS03

- **Class:** AsGLRptCTGS03
- **Description:** Stored procedure asGLRptCTGS03
- **SQL File:** `asGLRptCTGS03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | No |  (default: 'A01') |
| `pTk` | nvarchar(20) | No |  (default: '131') |
| `pNgay_ct1` | smalldatetime | No |  (default: '20150101') |
| `pNgay_ct2` | smalldatetime | No |  (default: '20150331') |
| `pMa_Nt` | nvarchar(3) | No |  (default: '') |

---

### asGLRptCTGS05

- **Class:** AsGLRptCTGS05
- **Description:** Stored procedure asGLRptCTGS05
- **SQL File:** `asGLRptCTGS05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pngay_ct1` | SMALLDATETIME | Yes |  |
| `pngay_ct2` | SMALLDATETIME | Yes |  |
| `pngay_lo1` | SMALLDATETIME | Yes |  |
| `pngay_lo2` | SMALLDATETIME | Yes |  |
| `pma_ct` | NVARCHAR(3) | No |  (default: '') |
| `ptk` | NVARCHAR(20) | No |  (default: '') |
| `ptk_du` | NVARCHAR(20) | No |  (default: '') |
| `pnhom_kh` | NVARCHAR(8) | No |  (default: '') |
| `pma_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pma_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pma_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pma_kh` | NVARCHAR(20) | No |  (default: '') |
| `pso_ct1` | NVARCHAR(12) | No |  (default: '') |
| `pso_ct2` | NVARCHAR(12) | No |  (default: '') |
| `pso_lo1` | NVARCHAR(12) | No |  (default: '') |
| `pso_lo2` | NVARCHAR(12) | No |  (default: '') |
| `pma_nt` | NVARCHAR(3) | No |  (default: '') |
| `pma_hd` | NVARCHAR(20) | No |  (default: '') |
| `pma_phi` | NVARCHAR(20) | No |  (default: '') |
| `pdien_giai` | NVARCHAR(255) | No |  (default: '') |
| `pma_bp` | NVARCHAR(20) | No |  (default: '') |
| `pma_spct` | NVARCHAR(20) | No |  (default: '') |

---

### asGLRptCf1

- **Class:** AsGLRptCf1
- **Description:** Stored procedure asGLRptCf1
- **SQL File:** `asGLRptCf1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `Ma_Cty` | nvarchar(3) | Yes |  |
| `Mau` | char(30) | Yes |  |
| `ngay00` | smalldatetime | Yes |  |
| `ngay0` | smalldatetime | Yes |  |
| `ngay1` | smalldatetime | Yes |  |
| `ngay2` | smalldatetime | Yes |  |

---

### asGLRptCheckCashFlow

- **Class:** AsGLRptCheckCAshFlow
- **Description:** Stored procedure asGLRptCheckCashFlow
- **SQL File:** `asGLRptCheckCashFlow.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay_ct1` | smalldatetime | Yes |  |
| `pNgay_ct2` | smalldatetime | Yes |  |

---

### asGLRptCt1

- **Class:** AsGLRptCt1
- **Description:** Stored procedure asGLRptCt1
- **SQL File:** `asGLRptCt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asGLRptF5BCPT04CT

- **Class:** AsGLRptF5BCPT04CT
- **Description:** Stored procedure asGLRptF5BCPT04CT
- **SQL File:** `asGLRptF5BCPT04CT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNam` | INT | Yes |  |
| `pThang1` | INT | Yes |  |
| `pThang2` | INT | Yes |  |
| `pTk` | NVARCHAR(500) | Yes |  |
| `pTk_du` | NVARCHAR(500) | Yes |  |
| `pNo_co` | NVARCHAR(1) | No |  (default: ''	-- '1' - lay ps no) |

---

### asGLRptF5BCTC01

- **Class:** AsGLRptF5BCTC01
- **Description:** Stored procedure asGLRptF5BCTC01
- **SQL File:** `asGLRptF5BCTC01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nVarchar(3) | Yes |  |
| `pTk` | nVarchar(20) | Yes |  |
| `pNgay1` | smallDatetime | Yes |  |
| `pNgay2` | smallDatetime | Yes |  |
| `pMa_nt` | nvarchar(3)
	) | Yes |  |

---

### asGLRptF5BCTC02

- **Class:** AsGLRptF5BCTC02
- **Description:** Stored procedure asGLRptF5BCTC02
- **SQL File:** `asGLRptF5BCTC02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nVarchar(3) | No |  (default: '') |
| `pTk` | nVarchar(20) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '') |

---

### asGLRptF5BCTC02CT

- **Class:** AsGLRptF5BCTC02CT
- **Description:** Stored procedure asGLRptF5BCTC02CT
- **SQL File:** `asGLRptF5BCTC02CT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nVarchar(3) | No |  (default: '') |
| `pTk` | nVarchar(20) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '') |

---

### asGLRptF5BCTC03CT

- **Class:** AsGLRptF5BCTC03CT
- **Description:** Stored procedure asGLRptF5BCTC03CT
- **SQL File:** `asGLRptF5BCTC03CT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(500) | Yes |  |
| `pTk_du` | nvarchar(500) | Yes |  |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime
	
) | Yes |  |

---

### asGLRptF5BK

- **Class:** AsGLRptF5BK
- **Description:** Stored procedure asGLRptF5BK
- **SQL File:** `asGLRptF5BK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pma_ct` | nvarchar(3) | Yes |  |
| `pngay_ct1` | smalldatetime | Yes |  |
| `pngay_ct2` | smalldatetime | Yes |  |
| `pso_ct1` | nvarchar(12) | No |  (default: '') |
| `pso_ct2` | nvarchar(12) | No |  (default: '') |
| `ptk` | nvarchar(20) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '') |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `pma_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_Nhkh` | nvarchar(8) | No |  (default: '') |
| `pma_plkh1` | nvarchar(8) | No |  (default: '') |
| `pma_plkh2` | nvarchar(8) | No |  (default: '') |
| `pma_plkh3` | nvarchar(8) | No |  (default: '') |
| `pma_bp` | nvarchar(20) | No |  (default: '') |
| `pma_phi` | nvarchar(20) | No |  (default: '') |
| `pma_hd` | nvarchar(20) | No |  (default: '') |
| `pma_nhhd` | nvarchar(8) | No |  (default: '') |
| `pma_ku` | nvarchar(20) | No |  (default: '') |
| `pma_spct` | nvarchar(20) | No |  (default: '') |
| `pdien_giai` | nvarchar(255) | No |  (default: '') |
| `pma_nt` | nvarchar(3) | No |  (default: '') |
| `pGroup` | nvarchar(128) | No |  (default: 'MA_KH') |
| `pGroupValue` | nvarchar(20) | No |  (default: '') |

---

### asGLRptF5CTGS01

- **Class:** AsGLRptF5CTGS01
- **Description:** Stored procedure asGLRptF5CTGS01
- **SQL File:** `asGLRptF5CTGS01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay_lo` | SMALLDATETIME | Yes |  |
| `pSo_lo` | NVARCHAR(20) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTk_du` | NVARCHAR(20) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |

---

### asGLRptF5CTGS02

- **Class:** AsGLRptF5CTGS02
- **Description:** Stored procedure asGLRptF5CTGS02
- **SQL File:** `asGLRptF5CTGS02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pNgay_lo` | SMALLDATETIME | Yes |  |
| `pSo_lo` | NVARCHAR(20) | Yes |  |

---

### asGLRptF5CTGS03

- **Class:** AsGLRptF5CTGS03
- **Description:** Stored procedure asGLRptF5CTGS03
- **SQL File:** `asGLRptF5CTGS03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: 'A01') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150101') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150331') |
| `pNgay_lo` | SMALLDATETIME | No |  (default: '') |
| `pSo_lo` | NVARCHAR(20) | No |  (default: '') |
| `pTk` | NVARCHAR(20) | No |  (default: '131') |
| `pTk_du` | NVARCHAR(20) | No |  (default: '') |

---

### asGLRptF5TH01

- **Class:** AsGLRptF5TH01
- **Description:** Stored procedure asGLRptF5TH01
- **SQL File:** `asGLRptF5TH01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pngay_ct1` | smalldatetime | Yes |  |
| `pngay_ct2` | smalldatetime | Yes |  |
| `pma_ct` | nvarchar(3) | No |  (default: '') |
| `ptk` | nvarchar(20) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '') |
| `pma_kh` | nvarchar(20) | No |  (default: '') |
| `pma_plkh1` | nvarchar(8) | No |  (default: '') |
| `pma_plkh2` | nvarchar(8) | No |  (default: '') |
| `pma_plkh3` | nvarchar(8) | No |  (default: '') |
| `pso_ct1` | nvarchar(12) | No |  (default: '') |
| `pso_ct2` | nvarchar(12) | No |  (default: '') |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `pma_nt` | nvarchar(3) | No |  (default: '') |
| `pma_hd` | nvarchar(20) | No |  (default: '') |
| `pma_phi` | nvarchar(20) | No |  (default: '') |
| `pdien_giai` | nvarchar(255) | No |  (default: '') |
| `pma_bp` | nvarchar(20) | No |  (default: '') |
| `pma_spct` | nvarchar(20) | No |  (default: '') |

---

### asGLRptNKC01

- **Class:** AsGLRptNKC01
- **Description:** Stored procedure asGLRptNKC01
- **SQL File:** `asGLRptNKC01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay_Ct1` | SMALLDATETIME | Yes |  |
| `pNgay_Ct2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pStt_dong_nkc` | BIT | No |  (default: 1) |

---

### asGLRptNKC011

- **Class:** AsGLRptNKC011
- **Description:** Stored procedure asGLRptNKC011
- **SQL File:** `asGLRptNKC011.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay_Ct1` | SMALLDATETIME | Yes |  |
| `pNgay_Ct2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pStt_dong_nkc` | BIT | No |  (default: 0 -- Khach hang nao bat buoc yeu cau in STT_DONG_NKC thi bat len) |

---

### asGLRptNKC012

- **Class:** AsGLRptNKC012
- **Description:** Stored procedure asGLRptNKC012
- **SQL File:** `asGLRptNKC012.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay_Ct1` | SMALLDATETIME | Yes |  |
| `pNgay_Ct2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |
| `pStt_dong_nkc` | BIT | No |  (default: 0 -- Khach hang nao bat buoc yeu cau in STT_DONG_NKC thi bat len) |

---

### asGLRptNKC01All

- **Class:** AsGLRptNKC01All
- **Description:** Stored procedure asGLRptNKC01All
- **SQL File:** `asGLRptNKC01All.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `Ngay_ct1` | smalldatetime | Yes |  |
| `Ngay_ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | No |  (default: '') |
| `pBac_tk` | INT | No |  (default: 9) |
| `pTk_sc` | BIT | No |  (default: 0) |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |

---

### asGLRptNKC01AllCrys

- **Class:** AsGLRptNKC01AllCrys
- **Description:** Stored procedure asGLRptNKC01AllCrys
- **SQL File:** `asGLRptNKC01AllCrys.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay_Ct1` | SMALLDATETIME | Yes |  |
| `pNgay_Ct2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(MAX) | No |  (default: '') |
| `pMa_Nt` | NVARCHAR(3) | No |  (default: '') |

---

### asGLRptNKC02

- **Class:** AsGLRptNKC02
- **Description:** Stored procedure asGLRptNKC02
- **SQL File:** `asGLRptNKC02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay_ct1` | smalldatetime | Yes |  |
| `pNgay_ct2` | smalldatetime | Yes |  |
| `pMa_Nt` | nvarchar(3) | Yes |  |

---

### asGLRptNKC02_goc1

- **Class:** AsGLRptNKC02_goc1
- **Description:** Stored procedure asGLRptNKC02_goc1
- **SQL File:** `asGLRptNKC02_goc1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay_ct1` | smalldatetime | Yes |  |
| `pNgay_ct2` | smalldatetime | Yes |  |
| `pMa_Nt` | nvarchar(3) | Yes |  |

---

### asGLRptNKC031

- **Class:** AsGLRptNKC031
- **Description:** Stored procedure asGLRptNKC031
- **SQL File:** `asGLRptNKC031.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | NVARCHAR(3) | Yes |  |
| `pNgay_Ct1` | SMALLDATETIME | Yes |  |
| `pNgay_Ct2` | SMALLDATETIME | Yes |  |
| `pTk_List` | NVARCHAR(100) | No |  (default: '111) |
| `pTkdu_List` | NVARCHAR(100) | No |  (default: '') |
| `pMa_Bp` | NVARCHAR(20) | No |  (default: '') |

---

### asGLRptNKC04

- **Class:** AsGLRptNKC04
- **Description:** Stored procedure asGLRptNKC04
- **SQL File:** `asGLRptNKC04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNgay_Ct1` | smalldatetime | Yes |  |
| `pNgay_ct2` | smalldatetime | Yes |  |
| `pDs_Tk_Pt` | nvarchar(500) | Yes |  |
| `pDs_Tk_Dt_Hh` | nvarchar(500) | Yes |  |
| `pDs_Tk_Dt_Tp` | nvarchar(500) | Yes |  |
| `pDs_Tk_Dt_Dv` | nvarchar(500) | Yes |  |
| `pMa_Nt` | nvarchar(3) | Yes |  |

---

### asGLRptNKC05

- **Class:** AsGLRptNKC05
- **Description:** Stored procedure asGLRptNKC05
- **SQL File:** `asGLRptNKC05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNgay_Ct1` | smalldatetime | Yes |  |
| `pNgay_Ct2` | smalldatetime | Yes |  |
| `pDs_Tk_pt` | nvarchar(500) | Yes |  |
| `pDs_Tk_hh` | nvarchar(500) | Yes |  |
| `pDs_Tk_Nvl` | nvarchar(500) | Yes |  |
| `pDs_Tk_khac` | nvarchar(500) | Yes |  |
| `pMa_Nt` | nvarchar(3) | Yes |  |

---

### asGLRptNKC06

- **Class:** AsGLRptNKC06
- **Description:** Stored procedure asGLRptNKC06
- **SQL File:** `asGLRptNKC06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay_ct1` | smalldatetime | Yes |  |
| `pNgay_ct2` | smalldatetime | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_Nt` | nvarchar(3)
) | Yes |  |

---

### asGLRptNKC07

- **Class:** AsGLRptNKC07
- **Description:** Stored procedure asGLRptNKC07
- **SQL File:** `asGLRptNKC07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nVarchar(3) | Yes |  |
| `Ngay_ct1` | smallDatetime | Yes |  |
| `Ngay_ct2` | smallDatetime | Yes |  |
| `pTk` | nVarchar(20) | Yes |  |
| `pNhom_tk` | nvarchar(1) | Yes |  |
| `pMa_nt` | nvarchar(3)
	) | Yes |  |

---

### asGLRptSoKeToanNhieuTK

- **Class:** AsGLRptSoKeToanNhieuTK
- **Description:** Stored procedure asGLRptSoKeToanNhieuTK
- **SQL File:** `asGLRptSoKeToanNhieuTK.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `Ngay_ct1` | smalldatetime | Yes |  |
| `Ngay_ct2` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(30) | Yes |  |

---

### asGLRptTH01

- **Class:** AsGLRptTH01
- **Description:** Stored procedure asGLRptTH01
- **SQL File:** `asGLRptTH01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | No |  (default: 'GBB') |
| `pngay_ct1` | smalldatetime | No |  (default: '20130101') |
| `pngay_ct2` | smalldatetime | No |  (default: '20130331') |
| `pma_ct` | nvarchar(3) | No |  (default: '') |
| `ptk` | nvarchar(20) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '') |
| `pnhom_kh` | nvarchar(8) | No |  (default: '') |
| `pma_plkh1` | nvarchar(8) | No |  (default: '') |
| `pma_plkh2` | nvarchar(8) | No |  (default: '') |
| `pma_plkh3` | nvarchar(8) | No |  (default: '') |
| `pma_kh` | nvarchar(20) | No |  (default: '') |
| `pso_ct1` | nvarchar(12) | No |  (default: '') |
| `pso_ct2` | nvarchar(12) | No |  (default: '') |
| `pNo_co` | nvarchar(1) | No |  (default: '') |
| `pma_nt` | nvarchar(3) | No |  (default: '') |
| `pma_hd` | nvarchar(20) | No |  (default: '') |
| `pma_phi` | nvarchar(20) | No |  (default: '') |
| `pdien_giai` | nvarchar(255) | No |  (default: '') |
| `pma_bp` | nvarchar(20) | No |  (default: '') |
| `pma_spct` | nvarchar(20) | No |  (default: '') |
| `pma_nhhd` | nvarchar(8) | No |  (default: '') |
| `pma_lo` | nvarchar(20) | No |  (default: '') |
| `pGroup` | nvarchar(128) | No |  (default: 'TK_DU') |
| `pBcNt` | nvarchar(1) | No |  (default: '' --0: VND) |

---

## Other Procedures

### asGLCalSumCdTk

- **Class:** AsGLCalSumCdTk
- **Description:** Stored procedure asGLCalSumCdTk
- **SQL File:** `asGLCalSumCdTk.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLCopyMauBs

- **Class:** AsGLCopyMauBs
- **Description:** Stored procedure asGLCopyMauBs
- **SQL File:** `asGLCopyMauBs.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty1` | nvarchar(3) | Yes |  |
| `pMa_cty2` | nvarchar(3) | Yes |  |
| `pMau` | nvarchar(10) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLCrtDGTG

- **Class:** AsGLCrtDGTG
- **Description:** Stored procedure asGLCrtDGTG
- **SQL File:** `asGLCrtDGTG.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pma_ct` | nvarchar(3) | Yes |  |
| `pma_nt` | nvarchar(3) | Yes |  |
| `pstt` | int | Yes |  |
| `pngay1` | smalldatetime | Yes |  |
| `pngay2` | smalldatetime | Yes |  |
| `puser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asGLCrtDGTG1

- **Class:** AsGLCrtDGTG1
- **Description:** Stored procedure asGLCrtDGTG1
- **SQL File:** `asGLCrtDGTG1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pstt` | int | Yes |  |
| `pma_nt` | nvarchar(3) | No |  (default: 'USD') |
| `ptk_dgtg` | nvarchar(20) | No |  (default: '11221') |
| `ptk_lai_cltg` | nvarchar(20) | No |  (default: '515') |
| `ptk_lo_cltg` | nvarchar(20) | No |  (default: '635') |
| `ptk_cltg_cn` | nvarchar(20) | No |  (default: '4131') |
| `pten_bt` | nvarchar(100) | No |  (default: 'DGTGCK') |
| `pdg_kh` | nvarchar(1) | No |  (default: '0') |
| `pdg_bp` | nvarchar(1) | No |  (default: '0') |
| `pdg_hd` | nvarchar(1) | No |  (default: '0') |
| `pdg_spct` | nvarchar(1) | No |  (default: '0') |
| `pdg_phi` | nvarchar(1) | No |  (default: '0') |
| `ploai_dg` | nvarchar(1) | No |  (default: '1') |
| `pngay1` | smalldatetime | No |  (default: '3/1/2011') |
| `pngay2` | smalldatetime | No |  (default: '3/31/2011') |
| `pstt_rec` | nvarchar(20) | No |  (default: 'AAA') |
| `pma_ct` | nvarchar(3) | No |  (default: 'GL5') |
| `pso_ct` | nvarchar(12) | No |  (default: '') |
| `puser` | nvarchar(20) | No |  (default: '') |

---

### asGLCrtKC

- **Class:** AsGLCrtKC
- **Description:** Stored procedure asGLCrtKC
- **SQL File:** `asGLCrtKC.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '111') |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |
| `pNgay1` | SMALLDATETIME | No |  (default: '20150101') |
| `pNgay2` | SMALLDATETIME | No |  (default: '20150131') |
| `pTk` | NVARCHAR(20) | No |  (default: '') |
| `pTk_du` | NVARCHAR(20) | No |  (default: '') |
| `pUser` | NVARCHAR(20) | No |  (default: '') |
| `pRet` | INT (output) | Yes |  |

---

### asGLCrtKC1

- **Class:** AsGLCrtKC1
- **Description:** Stored procedure asGLCrtKC1
- **SQL File:** `asGLCrtKC1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | NVARCHAR(3) | Yes |  |
| `pstt` | INT | Yes |  |
| `ptk` | NVARCHAR(20) | Yes |  |
| `ptk_du` | NVARCHAR(20) | Yes |  |
| `pten_bt` | NVARCHAR(100) | Yes |  |
| `pkc_bp` | NVARCHAR(1) | Yes |  |
| `pkc_hd` | NVARCHAR(1) | Yes |  |
| `pkc_spct` | NVARCHAR(1) | Yes |  |
| `pkc_phi` | NVARCHAR(1) | Yes |  |
| `ploai_kc` | NVARCHAR(1) | Yes |  |
| `pkc_dt_ps` | NVARCHAR(1) | Yes |  |
| `pngay1` | SMALLDATETIME | Yes |  |
| `pngay2` | SMALLDATETIME | Yes |  |
| `pstt_rec` | NVARCHAR(20) | Yes |  |
| `pma_ct` | NVARCHAR(3) | Yes |  |
| `pso_ct` | NVARCHAR(12) | Yes |  |

---

### asGLDKCTGS

- **Class:** AsGLDKCTGS
- **Description:** Stored procedure asGLDKCTGS
- **SQL File:** `asGLDKCTGS.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pThang` | INT | Yes |  |
| `pNam` | INT | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pTen_ctgs` | NVARCHAR(50) | Yes |  |
| `pSo_hieu` | NVARCHAR(3) | Yes |  |
| `pNgay` | INT | Yes |  |
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
| [CA](../CA/) | Cash transactions posting |
| [AR](../AR/) | Receivable posting |
| [AP](../AP/) | Payable posting |
| [PO](../PO/) | Purchase posting |
| [SO](../SO/) | Sales posting |
| [IN](../IN/) | Inventory posting |
| [CO](../CO/) | Production cost posting |
| [SI](../SI/) | System configuration |

---

*End of GL Procedures Documentation*
