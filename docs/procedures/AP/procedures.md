# AP Procedures (Accounts Payable (Công nợ phải trả))

*Generated on 2026-03-19 14:55:39*

Tổng số procedures: **41**

## Tổng quan

| Nhóm | Số lượng |
|------|----------|
| Insert | 8 |
| Update | 9 |
| Delete | 5 |
| Get | 9 |
| Filter | 3 |
| Report | 3 |
| Process | 2 |
| Other | 2 |

## Insert Procedures

### asAPInsCT1

- **Class:** AsAPInsCT1
- **Description:** Stored procedure asAPInsCT1
- **SQL File:** `asAPInsCT1.sql`

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
| `pDu_hd` | DECIMAL(19 | Yes |  |
| `pDu_hd_nt` | DECIMAL(19 | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asAPInsCT3

- **Class:** AsAPInsCT3
- **Description:** Stored procedure asAPInsCT3
- **SQL File:** `asAPInsCT3.sql`

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

### asAPInsCT4

- **Class:** AsAPInsCT4
- **Description:** Stored procedure asAPInsCT4
- **SQL File:** `asAPInsCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pStt_rec0` | NVARCHAR(3) | Yes |  |
| `pTk` | NVARCHAR(20) | Yes |  |
| `pMa_kh` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTy_gia` | DECIMAL(19 | Yes |  |
| `pPs_co` | DECIMAL(19 | Yes |  |
| `pPs_co_nt` | DECIMAL(19 | Yes |  |
| `pPs_no` | DECIMAL(19 | Yes |  |
| `pPs_no_nt` | DECIMAL(19 | Yes |  |
| `pNh_dk` | NVARCHAR(4) | Yes |  |
| `pMa_lo` | NVARCHAR(20) | Yes |  |
| `pMa_bp` | NVARCHAR(20) | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pMa_phi` | NVARCHAR(20) | Yes |  |
| `pMa_spct` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asAPInsPH1

- **Class:** AsAPInsPH1
- **Description:** Stored procedure asAPInsPH1
- **SQL File:** `asAPInsPH1.sql`

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
| `pTk_co` | nvarchar(20) | Yes |  |
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

### asAPInsPH3

- **Class:** AsAPInsPH3
- **Description:** Stored procedure asAPInsPH3
- **SQL File:** `asAPInsPH3.sql`

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
| `pTk_co` | nvarchar(20) | Yes |  |
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

### asAPInsPH4

- **Class:** AsAPInsPH4
- **Description:** Stored procedure asAPInsPH4
- **SQL File:** `asAPInsPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asAPInsPost2TT_APTT

- **Class:** AsAPInsPost2TT_APTT
- **Description:** :	Thêm mới phân bổ chứng từ
- **SQL File:** `asAPInsPost2TT_APTT.sql`

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

### asAPInsTT

- **Class:** AsAPInsTT
- **Description:** Stored procedure asAPInsTT
- **SQL File:** `asAPInsTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pMa_KH` | NVARCHAR(20) | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTy_gia` | DECIMAL(19 | Yes |  |
| `pT_tien0` | DECIMAL(19 | Yes |  |
| `pT_tien_nt0` | DECIMAL(19 | Yes |  |
| `pT_thue` | DECIMAL(19 | Yes |  |
| `pT_thue_nt` | DECIMAL(19 | Yes |  |
| `pT_tt` | DECIMAL(19 | Yes |  |
| `pT_tt_nt` | DECIMAL(19 | Yes |  |
| `pNgay_tt` | SMALLDATETIME | Yes |  |
| `pMa_tt_po` | NVARCHAR(8) | Yes |  |
| `pHan_ck` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pHan_tt` | DECIMAL(19 | Yes |  |
| `pLs_qh` | DECIMAL(19 | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pStt_rec_tt` | NVARCHAR(20) | Yes |  |
| `pNgay_ct_tt` | SMALLDATETIME | Yes |  |
| `pMa_ct_tt` | NVARCHAR(3) | Yes |  |
| `pSo_ct_tt` | NVARCHAR(12) | Yes |  |
| `pTien_da_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_da_tt` | DECIMAL(19 | Yes |  |
| `pDu_hd` | DECIMAL(19 | Yes |  |
| `pDu_hd_nt` | DECIMAL(19 | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

## Update Procedures

### asAPUpdPH1

- **Class:** AsAPUpdPH1
- **Description:** Stored procedure asAPUpdPH1
- **SQL File:** `asAPUpdPH1.sql`

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
| `pTk_co` | nvarchar(20) | Yes |  |
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

### asAPUpdPH3

- **Class:** AsAPUpdPH3
- **Description:** Stored procedure asAPUpdPH3
- **SQL File:** `asAPUpdPH3.sql`

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
| `pTk_co` | nvarchar(20) | Yes |  |
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

### asAPUpdPH4

- **Class:** AsAPUpdPH4
- **Description:** Stored procedure asAPUpdPH4
- **SQL File:** `asAPUpdPH4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pSo_ct` | nvarchar(12) | Yes |  |
| `pNgay_ct` | smalldatetime | Yes |  |
| `pNgay_lct` | smalldatetime | Yes |  |
| `pMa_nt` | nvarchar(3) | Yes |  |
| `pTy_gia` | decimal(19 | Yes |  |
| `pT_tien` | decimal(19 | Yes |  |
| `pT_tien_nt` | decimal(19 | Yes |  |
| `pNt_ph` | bit | Yes |  |
| `pTrang_thai` | nvarchar(1) | Yes |  |
| `pPost2gl` | nvarchar(1) | Yes |  |
| `pLUser` | nvarchar(20) | Yes |  |
| `pRet` | int (output) | Yes |  |

---

### asAPUpdTT

- **Class:** AsAPUpdTT
- **Description:** Stored procedure asAPUpdTT
- **SQL File:** `asAPUpdTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | Yes |  |
| `pNgay_ct` | SMALLDATETIME | Yes |  |
| `pSo_ct` | NVARCHAR(12) | Yes |  |
| `pMa_KH` | NVARCHAR(20) | Yes |  |
| `pTk_pt` | NVARCHAR(20) | Yes |  |
| `pMa_nt` | NVARCHAR(3) | Yes |  |
| `pTy_gia` | DECIMAL(19 | Yes |  |
| `pT_tien0` | DECIMAL(19 | Yes |  |
| `pT_tien_nt0` | DECIMAL(19 | Yes |  |
| `pT_thue` | DECIMAL(19 | Yes |  |
| `pT_thue_nt` | DECIMAL(19 | Yes |  |
| `pT_tt` | DECIMAL(19 | Yes |  |
| `pT_tt_nt` | DECIMAL(19 | Yes |  |
| `pNgay_tt` | SMALLDATETIME | Yes |  |
| `pMa_tt_po` | NVARCHAR(8) | Yes |  |
| `pHan_ck` | DECIMAL(19 | Yes |  |
| `pTl_ck` | DECIMAL(19 | Yes |  |
| `pHan_tt` | DECIMAL(19 | Yes |  |
| `pLs_qh` | DECIMAL(19 | Yes |  |
| `pMa_hd` | NVARCHAR(20) | Yes |  |
| `pDien_giai` | NVARCHAR(255) | Yes |  |
| `pStt_rec_tt` | NVARCHAR(20) | Yes |  |
| `pNgay_ct_tt` | SMALLDATETIME | Yes |  |
| `pMa_ct_tt` | NVARCHAR(3) | Yes |  |
| `pSo_ct_tt` | NVARCHAR(12) | Yes |  |
| `pTien_da_tt_nt` | DECIMAL(19 | Yes |  |
| `pTien_da_tt` | DECIMAL(19 | Yes |  |
| `pDu_hd` | DECIMAL(19 | Yes |  |
| `pDu_hd_nt` | DECIMAL(19 | Yes |  |
| `pLUser` | NVARCHAR(20) | Yes |  |
| `pRet` | INT (output) | Yes |  |

---

### asAPUpdTt_SoDuPo1

- **Class:** AsAPUpdTt_SoDuPo1
- **Description:** Stored procedure asAPUpdTt_SoDuPo1
- **SQL File:** `asAPUpdTt_SoDuPo1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPUpdTt_SoDuPo2

- **Class:** AsAPUpdTt_SoDuPo2
- **Description:** Stored procedure asAPUpdTt_SoDuPo2
- **SQL File:** `asAPUpdTt_SoDuPo2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPUpdTt_SoDuPo3

- **Class:** AsAPUpdTt_SoDuPo3
- **Description:** Stored procedure asAPUpdTt_SoDuPo3
- **SQL File:** `asAPUpdTt_SoDuPo3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

### asAPUpdTt_SoDuPo4

- **Class:** AsAPUpdTt_SoDuPo4
- **Description:** Stored procedure asAPUpdTt_SoDuPo4
- **SQL File:** `asAPUpdTt_SoDuPo4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPUpdTt_SoDuPo6

- **Class:** AsAPUpdTt_SoDuPo6
- **Description:** Stored procedure asAPUpdTt_SoDuPo6
- **SQL File:** `asAPUpdTt_SoDuPo6.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec_hd` | nvarchar(20) | Yes |  |

---

## Delete Procedures

### asAPDelCT1

- **Class:** AsAPDelCT1
- **Description:** Stored procedure asAPDelCT1
- **SQL File:** `asAPDelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPDelCT3

- **Class:** AsAPDelCT3
- **Description:** Stored procedure asAPDelCT3
- **SQL File:** `asAPDelCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPDelCT4

- **Class:** AsAPDelCT4
- **Description:** Stored procedure asAPDelCT4
- **SQL File:** `asAPDelCT4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |

---

### asAPDelPost2TT_APTT

- **Class:** AsAPDelPost2TT_APTT
- **Description:** :	Xoá phân bổ chứng từ
- **SQL File:** `asAPDelPost2TT_APTT.sql`

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

### asAPDelTT

- **Class:** AsAPDelTT
- **Description:** Stored procedure asAPDelTT
- **SQL File:** `asAPDelTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pStt_rec` | nvarchar(20) | Yes |  |
| `pStt_rec_pt` | nvarchar(20) | Yes |  |

---

## Get Procedures

### asAPGetCT1

- **Class:** AsAPGetCT1
- **Description:** Stored procedure asAPGetCT1
- **SQL File:** `asAPGetCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asAPGetCT3

- **Class:** AsAPGetCT3
- **Description:** Stored procedure asAPGetCT3
- **SQL File:** `asAPGetCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | No |  (default: NULL) |
| `pStt_rec` | NVARCHAR(20) | No |  (default: NULL) |
| `pStruct` | NVARCHAR(1) | No |  (default: '0') |

---

### asAPGetMaCT

- **Class:** AsAPGetMaCT
- **Description:** :	Tìm kiếm mã loại chứng từ được phân bổ
- **SQL File:** `asAPGetMaCT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |

---

### asAPGetPO1AP1

- **Class:** AsAPGetPO1AP1
- **Description:** Stored procedure asAPGetPO1AP1
- **SQL File:** `asAPGetPO1AP1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKey` | nvarchar(1000) | Yes |  |

---

### asAPGetPO4AP1

- **Class:** AsAPGetPO4AP1
- **Description:** Stored procedure asAPGetPO4AP1
- **SQL File:** `asAPGetPO4AP1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKey` | nvarchar(1000) | Yes |  |

---

### asAPGetPO4AP3

- **Class:** AsAPGetPO4AP3
- **Description:** Stored procedure asAPGetPO4AP3
- **SQL File:** `asAPGetPO4AP3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKey` | nvarchar(1000) | Yes |  |

---

### asAPGetPost2TT

- **Class:** AsAPGetPost2TT
- **Description:** :	Tìm kiếm chứng từ cần phân bổ cho hoá đơn mua hàng
- **SQL File:** `asAPGetPost2TT.sql`

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

### asAPGetPost2TT_APTT

- **Class:** AsAPGetPost2TT_APTT
- **Description:** :	Tìm kiếm chứng từ phân bổ
- **SQL File:** `asAPGetPost2TT_APTT.sql`

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

### asAPGetTT

- **Class:** AsAPGetTT
- **Description:** Stored procedure asAPGetTT
- **SQL File:** `asAPGetTT.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pMa_ct` | NVARCHAR(3) | No |  (default: '') |

---

## Filter Procedures

### asAPFilt1

- **Class:** AsAPFilt1
- **Description:** Stored procedure asAPFilt1
- **SQL File:** `asAPFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asAPFilt3

- **Class:** AsAPFilt3
- **Description:** Stored procedure asAPFilt3
- **SQL File:** `asAPFilt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

### asAPFilt4

- **Class:** AsAPFilt4
- **Description:** Stored procedure asAPFilt4
- **SQL File:** `asAPFilt4.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes |  |
| `pKeyCt` | nvarchar(1000) | Yes |  |

---

## Report Procedures

### asAPRptBK01

- **Class:** AsAPRptBK01
- **Description:** Stored procedure asAPRptBK01
- **SQL File:** `asAPRptBK01.sql`

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
| `pMa_phi` | NVARCHAR(20) | No |  (default: '') |
| `pMa_spct` | NVARCHAR(20) | No |  (default: '') |
| `pMa_bp` | NVARCHAR(20) | No |  (default: '') |
| `pMa_nt` | NVARCHAR(3) | No |  (default: '') |
| `pMa_hd` | NVARCHAR(20) | No |  (default: '') |
| `pSo_PN` | NVARCHAR(12) | No |  (default: '') |
| `pSoct1` | NVARCHAR(12) | No |  (default: '') |
| `pSoct2` | NVARCHAR(12) | No |  (default: '') |
| `pMa_plkh1` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh2` | NVARCHAR(8) | No |  (default: '') |
| `pMa_plkh3` | NVARCHAR(8) | No |  (default: '') |

---

### asAPRptBK02

- **Class:** AsAPRptBK02
- **Description:** Stored procedure asAPRptBK02
- **SQL File:** `asAPRptBK02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | SMALLDATETIME | Yes |  |
| `pHan_Ky1` | decimal(20) | No |  (default: '') |
| `pHan_Ky2` | decimal(20) | No |  (default: '') |
| `pHan_Ky3` | decimal(20) | No |  (default: '') |
| `pMa_NCC` | nvarchar(20) | No |  (default: '') |
| `pMa_NhNCC` | nvarchar(20) | No |  (default: '') |
| `pSap_xep` | nvarchar(1) | No |  (default: '') |
| `pTat_toan` | nvarchar(1) | No |  (default: '') |
| `pMa_nt` | nvarchar(3) | No |  (default: '') |

---

### asAPRptBK03

- **Class:** AsAPRptBK03
- **Description:** Stored procedure asAPRptBK03
- **SQL File:** `asAPRptBK03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |
| `pNgay1` | smalldatetime | Yes |  |
| `pNgay2` | smalldatetime | Yes |  |
| `pMa_gd` | nvarchar(8) | No |  (default: '') |
| `pSoct1` | nvarchar(12) | No |  (default: '') |
| `pSoct2` | nvarchar(12) | No |  (default: '') |
| `pMa_kh` | nvarchar(20) | No |  (default: '') |
| `pMa_nhkh` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh1` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh2` | nvarchar(8) | No |  (default: '') |
| `pMa_plkh3` | nvarchar(8) | No |  (default: '') |
| `pSap_xep` | nvarchar(1) | No |  (default: '') |
| `pTat_toan` | nvarchar(1) | No |  (default: '') |
| `pMa_NT` | nvarchar(3) | No |  (default: '') |

---

## Process Procedures

### asAPPostPh1_aptt

- **Class:** AsAPPostPh1_aptt
- **Description:** Stored procedure asAPPostPh1_aptt
- **SQL File:** `asAPPostPh1_aptt.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |

---

### asAPPostPh1_glct

- **Class:** AsAPPostPh1_glct
- **Description:** Stored procedure asAPPostPh1_glct
- **SQL File:** `asAPPostPh1_glct.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | NVARCHAR(3) | Yes |  |
| `pStt_rec` | NVARCHAR(20) | Yes |  |

---

## Other Procedures

### asAPReCalAP14Relate

- **Class:** AsAPReCalAP14Relate
- **Description:** Stored procedure asAPReCalAP14Relate
- **SQL File:** `asAPReCalAP14Relate.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |

---

### asAPReCalAP34Relate

- **Class:** AsAPReCalAP34Relate
- **Description:** Stored procedure asAPReCalAP34Relate
- **SQL File:** `asAPReCalAP34Relate.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes |  |

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
| [CA](../CA/) | Cash/Bank payments |
| [PO](../PO/) | Purchase Order integration |
| [IN](../IN/) | Inventory receipts |
| [SI](../SI/) | Master data reference |

---

*End of AP Procedures Documentation*
