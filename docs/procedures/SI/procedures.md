# SI Procedures (Sales Invoice (Bán hàng))

*Generated on 2026-03-19 14:55:40*

Tổng số procedures: **47**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 9 |
| Update | 10 |
| Delete | 9 |
| Get | 12 |
| Other | 7 |

## Insert Procedures

### asSIInsDMBP

- **Class:** AsSIInsDMBP
- **Description:** Stored procedure asSIInsDMBP
- **SQL File:** `asSIInsDMBP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pTen_bp` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMCT

- **Class:** AsSIInsDMCT
- **Description:** Stored procedure asSIInsDMCT
- **SQL File:** `asSIInsDMCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pPhan_he` | nvarchar(3) | Yes |  |
| `pMa_ct_me` | nvarchar(3) | Yes |  |
| `pTen_ct` | nvarchar(30) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pTk_co` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pSo_lien` | int | Yes |  |
| `pStt_nkc` | int | Yes |  |
| `pStt_ntxt` | int | Yes |  |
| `pCt_dc` | bit | Yes |  |
| `pLoc_nsd` | bit | Yes |  |
| `pVv` | bit | Yes |  |
| `pSpct` | bit | Yes |  |
| `pPhi` | bit | Yes |  |
| `pBp` | bit | Yes |  |
| `pLo` | bit | Yes |  |
| `pSp_post` | nvarchar(50) | Yes |  |
| `pSp_process` | nvarchar(50) | Yes |  |
| `pPh` | nvarchar(10) | Yes |  |
| `pSd` | bit | Yes |  |
| `pNxt` | nvarchar(1) | Yes |  |
| `pMenuid` | nvarchar(16) | Yes |  |
| `pVn_prefix` | nvarchar(12) | Yes |  |
| `pVn_sequence` | bigint | Yes |  |
| `pVn_pattern` | nvarchar(1) | Yes |  |
| `pVn_width` | INT | Yes |  |
| `pKieu_trung_so_ct` | int | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMHD

- **Class:** AsSIInsDMHD
- **Description:** Stored procedure asSIInsDMHD
- **SQL File:** `asSIInsDMHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_nhhd` | nvarchar(8) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pNgay_hh` | smalldatetime | Yes |  |
| `pTen_hd` | nvarchar(150) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNoi_dung` | nvarchar(1000) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMHTTT

- **Class:** AsSIInsDMHTTT
- **Description:** Stored procedure asSIInsDMHTTT
- **SQL File:** `asSIInsDMHTTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pModuleid` | nvarchar(2) | Yes |  |
| `pTen_httt` | nvarchar(50) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_mua` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_ban` | nvarchar(20) | Yes |  |
| `pTk_thue_nk` | nvarchar(20) | Yes |  |
| `pTk_thue_xk` | nvarchar(20) | Yes |  |
| `pTk_gtgt_nk_no` | nvarchar(20) | Yes |  |
| `pTk_gtgt_nk_co` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_xk` | nvarchar(20) | Yes |  |
| `pTK_thue_ttdb` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMNHHD

- **Class:** AsSIInsDMNHHD
- **Description:** Stored procedure asSIInsDMNHHD
- **SQL File:** `asSIInsDMNHHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhhd` | nvarchar(8) | Yes |  |
| `pTen_nhhd` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMNT

- **Class:** AsSIInsDMNT
- **Description:** Stored procedure asSIInsDMNT
- **SQL File:** `asSIInsDMNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTen_nt` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMPHI

- **Class:** AsSIInsDMPHI
- **Description:** Stored procedure asSIInsDMPHI
- **SQL File:** `asSIInsDMPHI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pTen_phi` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsDMTGNT

- **Class:** AsSIInsDMTGNT
- **Description:** Stored procedure asSIInsDMTGNT
- **SQL File:** `asSIInsDMTGNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pNgay_tg` | smalldatetime | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIInsdmngh

- **Class:** AsSIInsdmngh
- **Description:** Stored procedure asSIInsdmngh
- **SQL File:** `asSIInsdmngh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ngh` | nvarchar(20) | Yes |  |
| `pTen_ngh` | nvarchar(100) | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Update Procedures

### asSIUpdDMBP

- **Class:** AsSIUpdDMBP
- **Description:** Stored procedure asSIUpdDMBP
- **SQL File:** `asSIUpdDMBP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pTen_bp` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMCT

- **Class:** AsSIUpdDMCT
- **Description:** Stored procedure asSIUpdDMCT
- **SQL File:** `asSIUpdDMCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pPhan_he` | nvarchar(3) | Yes |  |
| `pMa_ct_me` | nvarchar(3) | Yes |  |
| `pTen_ct` | nvarchar(30) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pTk_co` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pSo_lien` | int | Yes |  |
| `pStt_nkc` | int | Yes |  |
| `pStt_ntxt` | int | Yes |  |
| `pCt_dc` | bit | Yes |  |
| `pLoc_nsd` | bit | Yes |  |
| `pVv` | bit | Yes |  |
| `pSpct` | bit | Yes |  |
| `pPhi` | bit | Yes |  |
| `pBp` | bit | Yes |  |
| `pLo` | bit | Yes |  |
| `pSp_post` | nvarchar(50) | Yes |  |
| `pSp_process` | nvarchar(50) | Yes |  |
| `pPh` | nvarchar(10) | Yes |  |
| `pSd` | bit | Yes |  |
| `pNxt` | nvarchar(1) | Yes |  |
| `pMenuid` | nvarchar(16) | Yes |  |
| `pVn_prefix` | nvarchar(12) | Yes |  |
| `pVn_sequence` | bigint | Yes |  |
| `pVn_postfix` | nvarchar(12) | Yes |  |
| `pVn_pattern` | nvarchar(1) | Yes |  |
| `pVn_width` | INT | Yes |  |
| `pKieu_trung_so_ct` | int | Yes |  |
| `pLanguage` | nvarchar(5) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMHD

- **Class:** AsSIUpdDMHD
- **Description:** Stored procedure asSIUpdDMHD
- **SQL File:** `asSIUpdDMHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pSo_hd` | nvarchar(12) | Yes |  |
| `pMa_nhhd` | nvarchar(8) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pNgay_hd` | smalldatetime | Yes |  |
| `pNgay_hh` | smalldatetime | Yes |  |
| `pTen_hd` | nvarchar(150) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNoi_dung` | nvarchar(1000) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTien` | decimal(19 | Yes |  |
| `pTien_nt` | decimal(19 | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMHTTT

- **Class:** AsSIUpdDMHTTT
- **Description:** Stored procedure asSIUpdDMHTTT
- **SQL File:** `asSIUpdDMHTTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pModuleid` | nvarchar(2) | Yes |  |
| `pTen_httt` | nvarchar(50) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_mua` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_ban` | nvarchar(20) | Yes |  |
| `pTk_thue_nk` | nvarchar(20) | Yes |  |
| `pTk_thue_xk` | nvarchar(20) | Yes |  |
| `pTk_gtgt_nk_no` | nvarchar(20) | Yes |  |
| `pTk_gtgt_nk_co` | nvarchar(20) | Yes |  |
| `pTk_thue_gtgt_xk` | nvarchar(20) | Yes |  |
| `pTK_thue_ttdb` | nvarchar(20) | Yes |  |
| `pTk_ck` | nvarchar(20) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMNHHD

- **Class:** AsSIUpdDMNHHD
- **Description:** Stored procedure asSIUpdDMNHHD
- **SQL File:** `asSIUpdDMNHHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhhd` | nvarchar(8) | Yes |  |
| `pTen_nhhd` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMNT

- **Class:** AsSIUpdDMNT
- **Description:** Stored procedure asSIUpdDMNT
- **SQL File:** `asSIUpdDMNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTen_nt` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMPHI

- **Class:** AsSIUpdDMPHI
- **Description:** Stored procedure asSIUpdDMPHI
- **SQL File:** `asSIUpdDMPHI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |
| `pTen_phi` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdDMTGNT

- **Class:** AsSIUpdDMTGNT
- **Description:** Stored procedure asSIUpdDMTGNT
- **SQL File:** `asSIUpdDMTGNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pNgay_tg` | smalldatetime | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asSIUpdcompany

- **Class:** AsSIUpdcompany
- **Description:** Stored procedure asSIUpdcompany
- **SQL File:** `asSIUpdcompany.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pTen_tcty` | NVARCHAR(50) | Yes |  |
| `pTen_cty` | NVARCHAR(50) | Yes |  |
| `pDia_chi` | NVARCHAR(128) | Yes |  |
| `pGiam_doc` | NVARCHAR(40) | Yes |  |
| `pKtt` | NVARCHAR(40) | Yes |  |
| `pMa_thue` | NVARCHAR(20) | Yes |  |
| `pTel` | VARCHAR | Yes |  |
| `pFax` | VARCHAR | Yes |  |
| `pEmail` | NVARCHAR(50) | Yes |  |
| `pQd_cdkt` | NVARCHAR(10) | Yes |  |
| `pTen_qd_cdkt` | NVARCHAR(100) | Yes |  |
| `pLanguage` | nvarchar(5) | No |  (default: 'vi-VN') |

---

### asSIUpddmngh

- **Class:** AsSIUpddmngh
- **Description:** Stored procedure asSIUpddmngh
- **SQL File:** `asSIUpddmngh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ngh` | nvarchar(20) | Yes |  |
| `pTen_ngh` | nvarchar(100) | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pkSd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Delete Procedures

### asSIDelDMBP

- **Class:** AsSIDelDMBP
- **Description:** Stored procedure asSIDelDMBP
- **SQL File:** `asSIDelDMBP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |

---

### asSIDelDMCT

- **Class:** AsSIDelDMCT
- **Description:** Stored procedure asSIDelDMCT
- **SQL File:** `asSIDelDMCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |

---

### asSIDelDMHD

- **Class:** AsSIDelDMHD
- **Description:** Stored procedure asSIDelDMHD
- **SQL File:** `asSIDelDMHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |

---

### asSIDelDMHTTT

- **Class:** AsSIDelDMHTTT
- **Description:** Stored procedure asSIDelDMHTTT
- **SQL File:** `asSIDelDMHTTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pModuleid` | nvarchar(2) | Yes |  |

---

### asSIDelDMNHHD

- **Class:** AsSIDelDMNHHD
- **Description:** Stored procedure asSIDelDMNHHD
- **SQL File:** `asSIDelDMNHHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhhd` | nvarchar(8) | Yes |  |

---

### asSIDelDMNT

- **Class:** AsSIDelDMNT
- **Description:** Stored procedure asSIDelDMNT
- **SQL File:** `asSIDelDMNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |

---

### asSIDelDMPHI

- **Class:** AsSIDelDMPHI
- **Description:** Stored procedure asSIDelDMPHI
- **SQL File:** `asSIDelDMPHI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_phi` | nvarchar(20) | Yes |  |

---

### asSIDelDMTGNT

- **Class:** AsSIDelDMTGNT
- **Description:** Stored procedure asSIDelDMTGNT
- **SQL File:** `asSIDelDMTGNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pNgay_tg` | smalldatetime | Yes |  |

---

### asSIDelGroupRight

- **Class:** AsSIDelGroupRight
- **Description:** Stored procedure asSIDelGroupRight
- **SQL File:** `asSIDelGroupRight.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pGroupName` | NVARCHAR(20) | Yes |  |
| `pMenuID` | NVARCHAR(8) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

## Get Procedures

### asSIGetDMBP

- **Class:** AsSIGetDMBP
- **Description:** Stored procedure asSIGetDMBP
- **SQL File:** `asSIGetDMBP.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_bp` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMCT

- **Class:** AsSIGetDMCT
- **Description:** Stored procedure asSIGetDMCT
- **SQL File:** `asSIGetDMCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pPhan_he` | NVARCHAR(2) | No |  (default: NULL) |
| `pLanguage` | nvarchar(5) | No |  (default: 'vi-VN') |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMCTByMa_Ct

- **Class:** AsSIGetDMCTByMa_Ct
- **Description:** Stored procedure asSIGetDMCTByMa_Ct
- **SQL File:** `asSIGetDMCTByMa_Ct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pLanguage` | nvarchar(5) | No |  (default: 'vi-VN') |

---

### asSIGetDMHD

- **Class:** AsSIGetDMHD
- **Description:** Stored procedure asSIGetDMHD
- **SQL File:** `asSIGetDMHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_hd` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMHTTT

- **Class:** AsSIGetDMHTTT
- **Description:** Stored procedure asSIGetDMHTTT
- **SQL File:** `asSIGetDMHTTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_httt` | nvarchar(20) | No |  (default: null) |
| `pModuleid` | nvarchar(2) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMNGH

- **Class:** AsSIGetDMNGH
- **Description:** Stored procedure asSIGetDMNGH
- **SQL File:** `asSIGetDMNGH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_ngh` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMNHHD

- **Class:** AsSIGetDMNHHD
- **Description:** Stored procedure asSIGetDMNHHD
- **SQL File:** `asSIGetDMNHHD.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '') |
| `pMa_nhhd` | nvarchar(20) | No |  (default: '') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asSIGetDMNT

- **Class:** AsSIGetDMNT
- **Description:** Stored procedure asSIGetDMNT
- **SQL File:** `asSIGetDMNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_nt` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMPHI

- **Class:** AsSIGetDMPHI
- **Description:** Stored procedure asSIGetDMPHI
- **SQL File:** `asSIGetDMPHI.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_phi` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asSIGetDMTGNT

- **Class:** AsSIGetDMTGNT
- **Description:** Stored procedure asSIGetDMTGNT
- **SQL File:** `asSIGetDMTGNT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |

---

### asSIGetDmSo_ct

- **Class:** AsSIGetDmSo_ct
- **Description:** Stored procedure asSIGetDmSo_ct
- **SQL File:** `asSIGetDmSo_ct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pPhan_he` | NVARCHAR(2) | No |  (default: 'SO') |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pLanguageId` | nvarchar(5) | Yes |  |

---

### asSIGetModuleID

- **Class:** AsSIGetModuleID
- **Description:** Stored procedure asSIGetModuleID
- **SQL File:** `asSIGetModuleID.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pmenuid` | nvarchar(20) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

## Other Procedures

### asSIMaintain01

- **Class:** AsSIMaintain01
- **Description:** Stored procedure asSIMaintain01
- **SQL File:** `asSIMaintain01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asSIMaintain01_ReIndex

- **Class:** AsSIMaintain01_ReIndex
- **Description:** Stored procedure asSIMaintain01_ReIndex
- **SQL File:** `asSIMaintain01_ReIndex.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asSIMaintain021

- **Class:** AsSIMaintain021
- **Description:** Stored procedure asSIMaintain021
- **SQL File:** `asSIMaintain021.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| *Không có* | - | - | - |

---

### asSIMaintain022

- **Class:** AsSIMaintain022
- **Description:** Stored procedure asSIMaintain022
- **SQL File:** `asSIMaintain022.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pstr_ma` | nvarchar(1000) | Yes |  |

---

### asSIMaintain03

- **Class:** AsSIMaintain03
- **Description:** Stored procedure asSIMaintain03
- **SQL File:** `asSIMaintain03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pngay_ct1` | smalldatetime | Yes |  |
| `pngay_ct2` | smalldatetime | Yes |  |
| `ptk` | nvarchar(20) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '')) |

---

### asSIMaintain04

- **Class:** AsSIMaintain04
- **Description:** Stored procedure asSIMaintain04
- **SQL File:** `asSIMaintain04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pma_cty` | nvarchar(3) | Yes |  |
| `pngay_ct1` | smalldatetime | Yes |  |
| `pngay_ct2` | smalldatetime | Yes |  |
| `ptk` | nvarchar(20) | No |  (default: '') |
| `ptk_du` | nvarchar(20) | No |  (default: '')) |

---

### asSIMaintain05

- **Class:** AsSIMaintain05
- **Description:** Stored procedure asSIMaintain05
- **SQL File:** `asSIMaintain05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pPath` | nvarchar(1000) | Yes |  |
| `pDBData` | nvarchar(200) | Yes |  |
| `pDBSys` | nvarchar(200) | Yes |  |

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
| [GL](../GL/) | General Ledger - Sổ cái |
| [AR](../AR/) | Accounts Receivable - Công nợ phải thu |
| [AP](../AP/) | Accounts Payable - Công nợ phải trả |
| [CA](../CA/) | Cash - Tiền mặt/Ngân hàng |
| [PO](../PO/) | Purchase Order - Đơn mua hàng |
| [SO](../SO/) | Sales Order - Đơn bán hàng |
| [IN](../IN/) | Inventory - Kho hàng |
| [CO](../CO/) | Manufacturing - Sản xuất |

---

*End of SI Procedures Documentation*
