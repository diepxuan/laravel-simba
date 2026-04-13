# AR Procedures (Accounts Receivable (Công nợ phải thu))

*Generated on 2026-03-19 14:55:39*

Tổng số procedures: **87**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 14 |
| Update | 14 |
| Delete | 14 |
| Get | 20 |
| Filter | 3 |
| Report | 16 |
| Process | 3 |
| Other | 3 |

## Insert Procedures

### asARInsCT1

- **Class:** AsARInsCT1
- **Description:** Stored procedure asARInsCT1
- **SQL File:** `asARInsCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pSo_hd` | NVARCHAR(12) | Yes |  |
| `pNgay_hd` | SMALLDATETIME | Yes |  |
| `pSo_dh` | NVARCHAR(12) | Yes |  |
| `pNgay_dh` | SMALLDATETIME | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTien_tt` | DECIMAL(19 | Yes |  |
| `pTien_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_tt_qd` | DECIMAL(19 | Yes |  |
| `pTt_hd` | DECIMAL(19 | Yes |  |
| `pTt_hd_nt` | DECIMAL(19 | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asARInsCT3

- **Class:** AsARInsCT3
- **Description:** Stored procedure asARInsCT3
- **SQL File:** `asARInsCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pStt_rec_dh` | NVARCHAR(20) | Yes |  |
| `pSo_hd` | NVARCHAR(12) | Yes |  |
| `pNgay_hd` | SMALLDATETIME | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTien_tt` | DECIMAL(19 | Yes |  |
| `pTien_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_tt_qd` | DECIMAL(19 | Yes |  |
| `pTt_hd` | DECIMAL(19 | Yes |  |
| `pTt_hd_nt` | DECIMAL(19 | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asARInsCT4

- **Class:** AsARInsCT4
- **Description:** Stored procedure asARInsCT4
- **SQL File:** `asARInsCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec0` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
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
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsCdKH

- **Class:** AsARInsCdKH
- **Description:** Stored procedure asARInsCdKH
- **SQL File:** `asARInsCdKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |
| `pDu_no` | decimal(19 | Yes |  |
| `pDu_co` | decimal(19 | Yes |  |
| `pDu_no_nt` | decimal(19 | Yes |  |
| `pDu_co_nt` | decimal(19 | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsDMDCKH

- **Class:** AsARInsDMDCKH
- **Description:** Stored procedure asARInsDMDCKH
- **SQL File:** `asARInsDMDCKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_dckh` | nvarchar(1) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pDc_md` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsDMKH

- **Class:** AsARInsDMKH
- **Description:** Stored procedure asARInsDMKH
- **SQL File:** `asARInsDMKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pEmail` | nvarchar(30) | Yes |  |
| `pHome_page` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_ngh` | nvarchar(20) | Yes |  |
| `pTen_nh` | nvarchar(50) | Yes |  |
| `pCn_nh` | nvarchar(50) | Yes |  |
| `pSo_tk_nh` | nvarchar(20) | Yes |  |
| `pTinh_tp_nh` | nvarchar(50) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_plkh1` | nvarchar(8) | Yes |  |
| `pMa_plkh2` | nvarchar(8) | Yes |  |
| `pMa_plkh3` | nvarchar(8) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pMa_httt_po` | nvarchar(20) | Yes |  |
| `pGh_no` | decimal(19 | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pTinh_dt_nb` | bit | Yes |  |
| `pIskh` | bit | Yes |  |
| `pIsncc` | bit | Yes |  |
| `pIsnv` | bit | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsDMNHKH

- **Class:** AsARInsDMNHKH
- **Description:** Stored procedure asARInsDMNHKH
- **SQL File:** `asARInsDMNHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |
| `pTen_nhkh` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsDMPLKH

- **Class:** AsARInsDMPLKH
- **Description:** Stored procedure asARInsDMPLKH
- **SQL File:** `asARInsDMPLKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plkh` | nvarchar(8) | Yes |  |
| `pTen_plkh` | nvarchar(50) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsNgHKh

- **Class:** AsARInsNgHKh
- **Description:** Stored procedure asARInsNgHKh
- **SQL File:** `asARInsNgHKh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_nh` | nvarchar(20) | Yes |  |
| `pSo_tk` | nvarchar(20) | Yes |  |
| `pTen_nh` | nvarchar(50) | Yes |  |
| `pChi_nhanh` | NVARCHAR(50) | Yes |  |
| `pTinh_tp` | nvarchar(50) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pEmail` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pKSd` | BIT | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsPH1

- **Class:** AsARInsPH1
- **Description:** Stored procedure asARInsPH1
- **SQL File:** `asARInsPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pStt_rec_dh` | nvarchar(20) | Yes |  |
| `pSo_dh` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pDu` | decimal(19 | Yes |  |
| `pDu_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsPH3

- **Class:** AsARInsPH3
- **Description:** Stored procedure asARInsPH3
- **SQL File:** `asARInsPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pDu` | decimal(19 | Yes |  |
| `pDu_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsPh4

- **Class:** AsARInsPh4
- **Description:** Stored procedure asARInsPh4
- **SQL File:** `asARInsPh4.sql`

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
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARInsPost2TT_ARTT

- **Class:** AsARInsPost2TT_ARTT
- **Description:** :	Thêm mới phân bổ chứng từ
- **SQL File:** `asARInsPost2TT_ARTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pNguoi_gd` | NVARCHAR(30) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pMa_kh` | NVARCHAR(20) | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |
| `pMa_nt` | VARCHAR(3) | Yes |  |
| `pTy_gia` | DECIMAL(19 | Yes |  |
| `pT_tt` | DECIMAL(19 | Yes |  |
| `pT_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_tt` | DECIMAL(19 | Yes |  |
| `pTien_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_tt_qd` | DECIMAL(19 | Yes |  |
| `pT_tien` | DECIMAL(19 | Yes |  |
| `pT_tien_nt` | DECIMAL(19 | Yes |  |
| `pUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asARInsTT

- **Class:** AsARInsTT
- **Description:** Stored procedure asARInsTT
- **SQL File:** `asARInsTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_KH` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien2` | decimal(19 | Yes |  |
| `pT_tien_nt2` | decimal(19 | Yes |  |
| `pT_thue` | decimal(19 | Yes |  |
| `pT_thue_nt` | decimal(19 | Yes |  |
| `pT_tt` | decimal(19 | Yes |  |
| `pT_tt_nt` | decimal(19 | Yes |  |
| `pTien_tt` | decimal(19 | Yes |  |
| `pTien_tt_nt` | decimal(19 | Yes |  |
| `pNgay_tt` | smalldatetime | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pStt_rec_tt` | nvarchar(20) | Yes |  |
| `pNgay_ct_tt` | smalldatetime | Yes |  |
| `pMa_ct_tt` | nvarchar(3) | Yes |  |
| `pSo_ct_tt` | nvarchar(12) | Yes |  |
| `pTien_da_tt_nt` | decimal(19 | Yes |  |
| `pTien_da_tt` | decimal(19 | Yes |  |
| `pDu_hd` | DECIMAL(19 | Yes |  |
| `pDu_hd_nt` | DECIMAL(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

## Update Procedures

### asARUpdCDKH

- **Class:** AsARUpdCDKH
- **Description:** Stored procedure asARUpdCDKH
- **SQL File:** `asARUpdCDKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |
| `pMa_Kh` | nvarchar(20) | Yes |  |
| `pMa_SpCt` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_Bp` | nvarchar(20) | Yes |  |
| `pDu_No_Nt` | money | Yes |  |
| `pDu_Co_Nt` | money | Yes |  |
| `pDu_No` | money | Yes |  |
| `pDu_Co` | money | Yes |  |
| `pUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdDMDCKH

- **Class:** AsARUpdDMDCKH
- **Description:** Stored procedure asARUpdDMDCKH
- **SQL File:** `asARUpdDMDCKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_dckh` | nvarchar(1) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pDc_md` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdDMKH

- **Class:** AsARUpdDMKH
- **Description:** Stored procedure asARUpdDMKH
- **SQL File:** `asARUpdDMKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pTen_kh` | nvarchar(100) | Yes |  |
| `pMa_so_thue` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pEmail` | nvarchar(30) | Yes |  |
| `pHome_page` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pMa_ngh` | nvarchar(20) | Yes |  |
| `pTen_nh` | nvarchar(50) | Yes |  |
| `pCn_nh` | nvarchar(50) | Yes |  |
| `pSo_tk_nh` | nvarchar(20) | Yes |  |
| `pTinh_tp_nh` | nvarchar(50) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_plkh1` | nvarchar(8) | Yes |  |
| `pMa_plkh2` | nvarchar(8) | Yes |  |
| `pMa_plkh3` | nvarchar(8) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pMa_httt` | nvarchar(20) | Yes |  |
| `pMa_httt_po` | nvarchar(20) | Yes |  |
| `pGh_no` | decimal(19 | Yes |  |
| `pHan_ck` | decimal(19 | Yes |  |
| `pTl_ck` | decimal(19 | Yes |  |
| `pHan_tt` | decimal(19 | Yes |  |
| `pLs_qh` | decimal(19 | Yes |  |
| `pGhi_chu` | nvarchar(255) | Yes |  |
| `pTinh_dt_nb` | bit | Yes |  |
| `pIskh` | bit | Yes |  |
| `pIsncc` | bit | Yes |  |
| `pIsnv` | bit | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdDMNHKH

- **Class:** AsARUpdDMNHKH
- **Description:** Stored procedure asARUpdDMNHKH
- **SQL File:** `asARUpdDMNHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |
| `pTen_nhkh` | nvarchar(50) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdDMPLKH

- **Class:** AsARUpdDMPLKH
- **Description:** Stored procedure asARUpdDMPLKH
- **SQL File:** `asARUpdDMPLKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plkh` | nvarchar(8) | Yes |  |
| `pTen_plkh` | nvarchar(50) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |
| `pKsd` | bit | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdNgHKH

- **Class:** AsARUpdNgHKH
- **Description:** Stored procedure asARUpdNgHKH
- **SQL File:** `asARUpdNgHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pId_cn` | INT | Yes |  |
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_nh` | nvarchar(20) | Yes |  |
| `pSo_tk` | nvarchar(20) | Yes |  |
| `pTen_nh` | nvarchar(50) | Yes |  |
| `pChi_nhanh` | NVARCHAR(50) | Yes |  |
| `pTinh_tp` | nvarchar(50) | Yes |  |
| `pTel` | nvarchar(30) | Yes |  |
| `pFax` | nvarchar(30) | Yes |  |
| `pEmail` | nvarchar(30) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pKSd` | BIT | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdPH1

- **Class:** AsARUpdPH1
- **Description:** Stored procedure asARUpdPH1
- **SQL File:** `asARUpdPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pStt_rec_dh` | nvarchar(20) | Yes |  |
| `pSo_dh` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pDu` | decimal(19 | Yes |  |
| `pDu_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdPH3

- **Class:** AsARUpdPH3
- **Description:** Stored procedure asARUpdPH3
- **SQL File:** `asARUpdPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pDia_chi` | nvarchar(255) | Yes |  |
| `pNguoi_gd` | nvarchar(30) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pTk_no` | nvarchar(20) | Yes |  |
| `pMa_gd` | nvarchar(1) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pDu` | decimal(19 | Yes |  |
| `pDu_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdPh4

- **Class:** AsARUpdPh4
- **Description:** Stored procedure asARUpdPh4
- **SQL File:** `asARUpdPh4.sql`

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
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdTT

- **Class:** AsARUpdTT
- **Description:** Stored procedure asARUpdTT
- **SQL File:** `asARUpdTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pMa_KH` | nvarchar(20) | Yes |  |
| `pTk_pt` | nvarchar(20) | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal (19 | Yes |  |
| `pT_tien2` | decimal (19 | Yes |  |
| `pT_tien_nt2` | decimal (19 | Yes |  |
| `pT_thue` | decimal (19 | Yes |  |
| `pT_thue_nt` | decimal (19 | Yes |  |
| `pT_tt` | decimal (19 | Yes |  |
| `pT_tt_nt` | decimal (19 | Yes |  |
| `pTien_tt` | decimal (19 | Yes |  |
| `pTien_tt_nt` | decimal (19 | Yes |  |
| `pNgay_tt` | smalldatetime | Yes |  |
| `pMa_tt` | nvarchar(8) | Yes |  |
| `pHan_ck` | decimal (19 | Yes |  |
| `pTl_ck` | decimal (19 | Yes |  |
| `pHan_tt` | decimal (19 | Yes |  |
| `pLs_qh` | decimal (19 | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pDien_giai` | nvarchar(255) | Yes |  |
| `pStt_rec_tt` | nvarchar(20) | Yes |  |
| `pNgay_ct_tt` | smalldatetime | Yes |  |
| `pMa_ct_tt` | nvarchar(3) | Yes |  |
| `pSo_ct_tt` | nvarchar(12) | Yes |  |
| `pTien_da_tt_nt` | decimal (19 | Yes |  |
| `pTien_da_tt` | decimal (19 | Yes |  |
| `pDu_hd` | DECIMAL(19 | Yes |  |
| `pDu_hd_nt` | DECIMAL(19 | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARUpdTT_SoDuAr1

- **Class:** AsARUpdTT_SoDuAr1
- **Description:** Stored procedure asARUpdTT_SoDuAr1
- **SQL File:** `asARUpdTT_SoDuAr1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asARUpdTT_SoDuSo1

- **Class:** AsARUpdTT_SoDuSo1
- **Description:** Stored procedure asARUpdTT_SoDuSo1
- **SQL File:** `asARUpdTT_SoDuSo1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec_dh` | nvarchar(20) | Yes |  |

---

### asARUpdTT_SoDuSo3

- **Class:** AsARUpdTT_SoDuSo3
- **Description:** Stored procedure asARUpdTT_SoDuSo3
- **SQL File:** `asARUpdTT_SoDuSo3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

### asARUpdTT_SoDuSo5

- **Class:** AsARUpdTT_SoDuSo5
- **Description:** Stored procedure asARUpdTT_SoDuSo5
- **SQL File:** `asARUpdTT_SoDuSo5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

## Delete Procedures

### asARDelCDKH

- **Class:** AsARDelCDKH
- **Description:** Stored procedure asARDelCDKH
- **SQL File:** `asARDelCDKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_Nt` | nvarchar(3) | Yes |  |
| `pMa_SpCt` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_Bp` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asARDelCT1

- **Class:** AsARDelCT1
- **Description:** Stored procedure asARDelCT1
- **SQL File:** `asARDelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asARDelCT3

- **Class:** AsARDelCT3
- **Description:** Stored procedure asARDelCT3
- **SQL File:** `asARDelCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asARDelCT4

- **Class:** AsARDelCT4
- **Description:** Stored procedure asARDelCT4
- **SQL File:** `asARDelCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asARDelDMDCKH

- **Class:** AsARDelDMDCKH
- **Description:** Stored procedure asARDelDMDCKH
- **SQL File:** `asARDelDMDCKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_dckh` | nvarchar(1) | Yes |  |

---

### asARDelDMKH

- **Class:** AsARDelDMKH
- **Description:** Stored procedure asARDelDMKH
- **SQL File:** `asARDelDMKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |

---

### asARDelDMNHKH

- **Class:** AsARDelDMNHKH
- **Description:** Stored procedure asARDelDMNHKH
- **SQL File:** `asARDelDMNHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_nhkh` | nvarchar(8) | Yes |  |

---

### asARDelDMPLKH

- **Class:** AsARDelDMPLKH
- **Description:** Stored procedure asARDelDMPLKH
- **SQL File:** `asARDelDMPLKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_plkh` | nvarchar(8) | Yes |  |
| `pLoai` | nvarchar(1) | Yes |  |

---

### asARDelNgHKH

- **Class:** AsARDelNgHKH
- **Description:** Stored procedure asARDelNgHKH
- **SQL File:** `asARDelNgHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pId_cn` | INT | Yes |  |

---

### asARDelPH1

- **Class:** AsARDelPH1
- **Description:** Stored procedure asARDelPH1
- **SQL File:** `asARDelPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asARDelPH3

- **Class:** AsARDelPH3
- **Description:** Stored procedure asARDelPH3
- **SQL File:** `asARDelPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asARDelPH4

- **Class:** AsARDelPH4
- **Description:** Stored procedure asARDelPH4
- **SQL File:** `asARDelPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |

---

### asARDelPost2TT_ARTT

- **Class:** AsARDelPost2TT_ARTT
- **Description:** :	Xoá phân bổ chứng từ
- **SQL File:** `asARDelPost2TT_ARTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec_hd` | NVARCHAR(20) | Yes |  |
| `pTien_tt` | DECIMAL | Yes |  |
| `pTien_tt_nt` | DECIMAL | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asARDelTT

- **Class:** AsARDelTT
- **Description:** Stored procedure asARDelTT
- **SQL File:** `asARDelTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec_pt` | nvarchar(20) | Yes |  |

---

## Get Procedures

### asARGetCDKH

- **Class:** AsARGetCDKH
- **Description:** Stored procedure asARGetCDKH
- **SQL File:** `asARGetCDKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes |  |
| `pNam` | int | Yes |  |
| `pTk` | nvarchar(20) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pMa_hd` | nvarchar(20) | Yes |  |
| `pMa_bp` | nvarchar(20) | Yes |  |
| `pMa_spct` | nvarchar(20) | Yes |  |

---

### asARGetCT1

- **Class:** AsARGetCT1
- **Description:** Stored procedure asARGetCT1
- **SQL File:** `asARGetCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asARGetCT3

- **Class:** AsARGetCT3
- **Description:** Stored procedure asARGetCT3
- **SQL File:** `asARGetCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asARGetCt4

- **Class:** AsARGetCt4
- **Description:** Stored procedure asARGetCt4
- **SQL File:** `asARGetCt4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asARGetCty

- **Class:** AsARGetCty
- **Description:** Stored procedure asARGetCty
- **SQL File:** `asARGetCty.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty1` | nvarchar(30) | No |  (default: null) |
| `pMa_cty2` | nvarchar(30) | No |  (default: null) |

---

### asARGetDMDCKH

- **Class:** AsARGetDMDCKH
- **Description:** Stored procedure asARGetDMDCKH
- **SQL File:** `asARGetDMDCKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_kh` | nvarchar(20) | No |  (default: null) |
| `pMa_dckh` | nvarchar(1) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetDMDCKH_dmkh

- **Class:** AsARGetDMDCKH_dmkh
- **Description:** Stored procedure asARGetDMDCKH_dmkh
- **SQL File:** `asARGetDMDCKH_dmkh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_kh` | nvarchar(20) | No |  (default: null) |
| `pMa_dckh` | nvarchar(1) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetDMKH

- **Class:** AsARGetDMKH
- **Description:** Stored procedure asARGetDMKH
- **SQL File:** `asARGetDMKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pMa_kh` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |
| `pModuleId` | NVARCHAR(2) | No |  (default: '') |

---

### asARGetDMNHKH

- **Class:** AsARGetDMNHKH
- **Description:** Stored procedure asARGetDMNHKH
- **SQL File:** `asARGetDMNHKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_nhkh` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetDMPLKH

- **Class:** AsARGetDMPLKH
- **Description:** Stored procedure asARGetDMPLKH
- **SQL File:** `asARGetDMPLKH.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pMa_plkh` | nvarchar(8) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |
| `pLoai` | nvarchar(1) | No |  (default: null) |

---

### asARGetMaCT

- **Class:** AsARGetMaCT
- **Description:** :	Tìm kiếm mã loại chứng từ được phân bổ
- **SQL File:** `asARGetMaCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

### asARGetNgHKh

- **Class:** AsARGetNgHKh
- **Description:** Stored procedure asARGetNgHKh
- **SQL File:** `asARGetNgHKh.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |

---

### asARGetPH1

- **Class:** AsARGetPH1
- **Description:** Stored procedure asARGetPH1
- **SQL File:** `asARGetPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetPH3

- **Class:** AsARGetPH3
- **Description:** Stored procedure asARGetPH3
- **SQL File:** `asARGetPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: null) |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetPH4

- **Class:** AsARGetPH4
- **Description:** Stored procedure asARGetPH4
- **SQL File:** `asARGetPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: null) |
| `pStt_rec` | nvarchar(20) | No |  (default: '') |
| `pMa_ct` | nvarchar(3) | No |  (default: null) |
| `pStruct` | nvarchar(1) | No |  (default: '0') |

---

### asARGetPost2TT

- **Class:** AsARGetPost2TT
- **Description:** :	Tìm kiếm chứng từ cần phân bổ cho hoá đơn bán hàng
- **SQL File:** `asARGetPost2TT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pLoai_ct` | NVARCHAR(3) | Yes |  |
| `pSo1` | NVARCHAR(12) | Yes |  |
| `pSo2` | NVARCHAR(12) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pTk` | NVARCHAR(20) | No |  (default: '') |
| `pDien_giai` | NVARCHAR(255) | No |  (default: '') |

---

### asARGetPost2TT_ARTT

- **Class:** AsARGetPost2TT_ARTT
- **Description:** :	Tìm kiếm chứng từ phân bổ
- **SQL File:** `asARGetPost2TT_ARTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pTk_pt` | NVARCHAR(20) | No |  (default: '131') |
| `pMa_kh` | NVARCHAR(20) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |
| `pLoai` | NVARCHAR(1) | Yes |  |

---

### asARGetSO14AR1

- **Class:** AsARGetSO14AR1
- **Description:** Stored procedure asARGetSO14AR1
- **SQL File:** `asARGetSO14AR1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKey` | nvarchar(1000) | Yes |  |

---

### asARGetSO34AR1

- **Class:** AsARGetSO34AR1
- **Description:** Stored procedure asARGetSO34AR1
- **SQL File:** `asARGetSO34AR1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKey` | nvarchar(1000) | Yes |  |

---

### asARGetTT

- **Class:** AsARGetTT
- **Description:** Stored procedure asARGetTT
- **SQL File:** `asARGetTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No |  (default: '') |
| `pMa_ct` | nvarchar (3) | No |  (default: '') |

---

## Filter Procedures

### asARFilt1

- **Class:** AsARFilt1
- **Description:** Stored procedure asARFilt1
- **SQL File:** `asARFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asARFilt3

- **Class:** AsARFilt3
- **Description:** Stored procedure asARFilt3
- **SQL File:** `asARFilt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asARFilt4

- **Class:** AsARFilt4
- **Description:** Stored procedure asARFilt4
- **SQL File:** `asARFilt4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

## Report Procedures

### asARRptBCCN01

- **Class:** AsARRptBCCN01
- **Description:** Stored procedure asARRptBCCN01
- **SQL File:** `asARRptBCCN01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | nvarchar(3) | No |  (default: 'GBB') |
| `Ngay1` | smalldatetime | No |  (default: '2013-01-01') |
| `Ngay2` | smalldatetime | No |  (default: '2013-01-01') |
| `Tk` | nvarchar(20) | No |  (default: '1368') |
| `ma_kh` | nvarchar(20) | No |  (default: '00000177') |
| `ma_nt` | nvarchar(3) | No |  (default: '') |

---

### asARRptBCCN011

- **Class:** AsARRptBCCN011
- **Description:** Stored procedure asARRptBCCN011
- **SQL File:** `asARRptBCCN011.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | nvarchar(3) | Yes |  |
| `Ngay1` | smalldatetime | Yes |  |
| `Ngay2` | smalldatetime | Yes |  |
| `Tk` | nvarchar(20) | Yes |  |
| `ma_kh` | nvarchar(20) | Yes |  |
| `ma_nt` | nvarchar(3) | Yes |  |

---

### asARRptBCCN01a

- **Class:** AsARRptBCCN01a
- **Description:** Stored procedure asARRptBCCN01a
- **SQL File:** `asARRptBCCN01a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | NVARCHAR(3) | Yes |  |
| `Ngay1` | SMALLDATETIME | Yes |  |
| `Ngay2` | SMALLDATETIME | Yes |  |
| `Tk` | NVARCHAR(20) | Yes |  |
| `ma_kh` | NVARCHAR(200) | No |  (default: '') |
| `ma_nt` | NVARCHAR(3) | No |  (default: 'VND') |

---

### asARRptBCCN01a_Crys

- **Class:** AsARRptBCCN01a_Crys
- **Description:** Stored procedure asARRptBCCN01a_Crys
- **SQL File:** `asARRptBCCN01a_Crys.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | NVARCHAR(3) | Yes |  |
| `Ngay1` | SMALLDATETIME | Yes |  |
| `Ngay2` | SMALLDATETIME | Yes |  |
| `Tk` | NVARCHAR(20) | No |  (default: '') |
| `ma_kh` | NVARCHAR(max) | No |  (default: '') |
| `ma_nt` | NVARCHAR(3) | No |  (default: '') |

---

### asARRptBCCN02

- **Class:** AsARRptBCCN02
- **Description:** Stored procedure asARRptBCCN02
- **SQL File:** `asARRptBCCN02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(20) | No |  (default: '131') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: 'VND') |
| `pGroup1` | NVARCHAR(1) | No |  (default: '0') |
| `pGroup2` | NVARCHAR(1) | No |  (default: '0') |
| `pGroup3` | NVARCHAR(1) | No |  (default: '0') |

---

### asARRptBCCN03

- **Class:** AsARRptBCCN03
- **Description:** Stored procedure asARRptBCCN03
- **SQL File:** `asARRptBCCN03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | nvarchar(3) | No |  (default: '111') |
| `Ngay1` | SMALLDATETIME | No |  (default: '20150101') |
| `Ngay2` | SMALLDATETIME | No |  (default: '20150131') |
| `Tk` | nvarchar(20) | No |  (default: '') |
| `ma_kh` | nvarchar(20) | No |  (default: '') |
| `ma_plkh1` | nvarchar(8) | No |  (default: '') |
| `ma_plkh2` | nvarchar(8) | No |  (default: '') |
| `ma_plkh3` | nvarchar(8) | No |  (default: '') |
| `ma_nt` | nvarchar(3) | No |  (default: 'VND') |

---

### asARRptBCCN04

- **Class:** AsARRptBCCN04
- **Description:** Stored procedure asARRptBCCN04
- **SQL File:** `asARRptBCCN04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | nvarchar(3) | Yes |  |
| `Ngay1` | smalldatetime | Yes |  |
| `Ngay2` | smalldatetime | Yes |  |
| `Tk` | nvarchar(20) | No |  (default: '131') |
| `pGroup` | nvarchar(20) | No |  (default: 'MA_KH') |
| `pDetail` | nvarchar(20) | No |  (default: 'MA_SPCT') |
| `ma_hd` | NVARCHAR(20) | No |  (default: '') |
| `ma_kh` | nvarchar(20) | No |  (default: '') |
| `ma_plkh1` | nvarchar(8) | No |  (default: '') |
| `ma_plkh2` | nvarchar(8) | No |  (default: '') |
| `ma_plkh3` | nvarchar(8) | No |  (default: '') |
| `pMa_BP` | NVARCHAR(20) | No |  (default: '') |
| `pMa_NVKD` | NVARCHAR(20) | No |  (default: '') |
| `pMa_SPCT` | NVARCHAR(20) | No |  (default: '') |
| `ma_nt` | nvarchar(3) | No |  (default: 'VND') |

---

### asARRptBCCN05

- **Class:** AsARRptBCCN05
- **Description:** Stored procedure asARRptBCCN05
- **SQL File:** `asARRptBCCN05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_kh` | NVARCHAR(200) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: 'VND') |

---

### asARRptBCCN05_Crys

- **Class:** AsARRptBCCN05_Crys
- **Description:** Stored procedure asARRptBCCN05_Crys
- **SQL File:** `asARRptBCCN05_Crys.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | NVARCHAR(3) | Yes |  |
| `Ngay1` | SMALLDATETIME | Yes |  |
| `Ngay2` | SMALLDATETIME | Yes |  |
| `Tk` | NVARCHAR(20) | No |  (default: '') |
| `ma_kh` | NVARCHAR(2000) | No |  (default: '') |
| `ma_nt` | NVARCHAR(3) | No |  (default: '') |

---

### asARRptBCCN06

- **Class:** AsARRptBCCN06
- **Description:** Stored procedure asARRptBCCN06
- **SQL File:** `asARRptBCCN06.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pHan_Ky1` | int | Yes |  |
| `pHan_Ky2` | int | Yes |  |
| `pHan_Ky3` | int | Yes |  |
| `pMa_NCC` | nvarchar(20) | No |  (default: '') |
| `pMa_NhNCC` | nvarchar(20) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_TT` | nvarchar(20) | No |  (default: '') |

---

### asARRptBK01

- **Class:** AsARRptBK01
- **Description:** Stored procedure asARRptBK01
- **SQL File:** `asARRptBK01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_vt` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhvt` | NVARCHAR(8) | No |  (default: '') |
| `pMa_kho` | NVARCHAR(8) | No |  (default: '') |
| `pMa_lo` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nvkd` | NVARCHAR(8) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |

---

### asARRptBK02

- **Class:** AsARRptBK02
- **Description:** Stored procedure asARRptBK02
- **SQL File:** `asARRptBK02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pHan_Ky1` | nvarchar(20) | No |  (default: '') |
| `pHan_Ky2` | nvarchar(20) | No |  (default: '') |
| `pHan_Ky3` | nvarchar(20) | No |  (default: '') |
| `pMa_NCC` | nvarchar(20) | No |  (default: '') |
| `pMa_NhNCC` | nvarchar(20) | No |  (default: '') |
| `pSap_xep` | nvarchar(1) | No |  (default: '') |
| `pTat_toan` | nvarchar(1) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_TT` | nvarchar(20) | No |  (default: '') |

---

### asARRptBK03

- **Class:** AsARRptBK03
- **Description:** Stored procedure asARRptBK03
- **SQL File:** `asARRptBK03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pNgay2` | SMALLDATETIME | Yes |  |
| `pMa_gd` | NVARCHAR(8) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nhkh` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |
| `pSap_xep` | NVARCHAR(1) | No |  (default: '') |
| `pTat_toan` | NVARCHAR(1) | No |  (default: '') |
| `pMa_NT` | NVARCHAR(3) | No |  (default: '') |

---

### asARRptBccnHd01

- **Class:** AsARRptBccnHd01
- **Description:** Stored procedure asARRptBccnHd01
- **SQL File:** `asARRptBccnHd01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pHan_Ky1` | nvarchar(20) | No |  (default: '30') |
| `pHan_Ky2` | nvarchar(20) | No |  (default: '60') |
| `pHan_Ky3` | nvarchar(20) | No |  (default: '90') |
| `pMa_NCC` | nvarchar(20) | No |  (default: '') |
| `pMa_NhNCC` | nvarchar(20) | No |  (default: '') |
| `pSap_xep` | nvarchar(1) | No |  (default: '') |
| `pTat_toan` | nvarchar(1) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |
| `pMa_TT` | nvarchar(20) | No |  (default: '') |

---

### asARRptF5BCCN

- **Class:** AsARRptF5BCCN
- **Description:** Stored procedure asARRptF5BCCN
- **SQL File:** `asARRptF5BCCN.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `ma_cty` | nvarchar(3) | Yes |  |
| `Tk` | nvarchar(20) | Yes |  |
| `ma_kh` | nvarchar(20) | Yes |  |
| `Ngay1` | smalldatetime | Yes |  |
| `Ngay2` | smalldatetime | Yes |  |
| `ma_nt` | nvarchar(3) | Yes |  |

---

### asARRptF5BCCN04

- **Class:** AsARRptF5BCCN04
- **Description:** Stored procedure asARRptF5BCCN04
- **SQL File:** `asARRptF5BCCN04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `Ma_cty` | NVARCHAR(3) | Yes |  |
| `Tk` | NVARCHAR(20) | Yes |  |
| `Ma_kh` | NVARCHAR(20) | Yes |  |
| `Ma_loai` | NVARCHAR(20) | Yes |  |
| `Ma` | NVARCHAR(20) | Yes |  |
| `Ngay1` | SMALLDATETIME | Yes |  |
| `Ngay2` | SMALLDATETIME | Yes |  |
| `Ma_nt` | NVARCHAR(3) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |

---

## Process Procedures

### asARPostPh1_artt

- **Class:** AsARPostPh1_artt
- **Description:** Stored procedure asARPostPh1_artt
- **SQL File:** `asARPostPh1_artt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |

---

### asARPostPh1_glct

- **Class:** AsARPostPh1_glct
- **Description:** Stored procedure asARPostPh1_glct
- **SQL File:** `asARPostPh1_glct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |

---

### asARRecalCustBalance

- **Class:** AsARRecalCustBalance
- **Description:** :	Tính số dư công nợ tức thời.
- **SQL File:** `asARRecalCustBalance.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_kh` | nvarchar(20) | Yes |  |
| `pNam` | int | Yes |  |

---

## Other Procedures

### asARPhanBoThanhToan

- **Class:** AsARPhanBoThanhToan
- **Description:** Stored procedure asARPhanBoThanhToan
- **SQL File:** `asARPhanBoThanhToan.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: '001') |
| `pTk_pt` | NVARCHAR(20) | No |  (default: '131') |
| `pMa_kh` | NVARCHAR(20) | No |  (default: '') |
| `pNgay_ct1` | SMALLDATETIME | No |  (default: '20150401') |
| `pNgay_ct2` | SMALLDATETIME | No |  (default: '20150630') |

---

### asARReCalAR14Relate

- **Class:** AsARReCalAR14Relate
- **Description:** Stored procedure asARReCalAR14Relate
- **SQL File:** `asARReCalAR14Relate.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asARReCalAR34Relate

- **Class:** AsARReCalAR34Relate
- **Description:** Stored procedure asARReCalAR34Relate
- **SQL File:** `asARReCalAR34Relate.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

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
| [CA](../CA/) | Cash/Bank receipts |
| [SO](../SO/) | Sales Order integration |
| [SI](../SI/) | Master data reference |

---

*End of AR Procedures Documentation*
