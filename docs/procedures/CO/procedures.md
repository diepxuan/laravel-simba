# CO Procedures - Danh muc thu tuc Cost/Construction

Danh muc cac stored procedure lien quan den module Cost/Construction (CO) trong he thong SimbaSql.

---

## Muc luc

1. [Insert Procedures](#1-insert-procedures)
2. [Update Procedures](#2-update-procedures)
3. [Delete Procedures](#3-delete-procedures)
4. [Get Procedures](#4-get-procedures)
5. [Report Procedures](#5-report-procedures)
6. [Process Procedures](#6-process-procedures)

---

## 1. Insert Procedures

### asCOInsDMCoBomCT

- **Class:** AsCOInsDMCoBomCT
- **Description:** Them moi dinh muc nguyen vat lieu - thong tin chi tiet
- **SQL File:** `asCOInsDMCoBomCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | VARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pMa_vt | NVARCHAR(20) | Ma vat tu |
| pvt_chinh | BIT | Vat tu chinh |
| pSo_luong | DECIMAL(19,7) | So luong |
| pUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOInsDMCoBomPH

- **Class:** AsCOInsDMCoBomPH
- **Description:** Them moi dinh muc nguyen vat lieu - thong tin chung
- **SQL File:** `asCOInsDMCoBomPH.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | VARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pDon_gia_luong | DECIMAL(19,4) | Don gia luong |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOInsDMNHSPCT

- **Class:** AsCOInsDMNHSPCT
- **Description:** Them moi nhom san pham cong trinh
- **SQL File:** `asCOInsDMNHSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pma_nhspct | NVARCHAR(8) | Ma nhom san pham cong trinh |
| pten_nhspct | NVARCHAR(50) | Ten nhom san pham cong trinh |
| pCap | INT | Cap do |
| pStt_nhom | NVARCHAR(18) | So thu tu nhom |
| pNhom_me | NVARCHAR(8) | Nhom me |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pCong_sl | BIT | Cong so luong |
| pKsd | BIT | Khong su dung |
| pLUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOInsDMPB

- **Class:** AsCOInsDMPB
- **Description:** Them moi phan bo
- **SQL File:** `asCOInsDMPB.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pStt | INT | So thu tu |
| pTen_bt | NVARCHAR(50) | Ten but toan |
| pTk_pb | NVARCHAR(20) | Tai khoan phan bo |
| pSo_ct | NVARCHAR(12) | So chung tu |
| pKsd | NVARCHAR(1) | Khong su dung |
| pUser | NVARCHAR(20) | Nguoi dung |
| pTheoSPCT | BIT | Theo san pham cong trinh |
| pTheoBP | BIT | Theo bo phan |
| pTheoTKDU | BIT | Theo tai khoan doi ung |
| pModuleId | NVARCHAR(5) | Ma module |
| pRet | INT OUTPUT | Ket qua tra ve (0: Da co, >0: Them moi thanh cong) |

---

### asCOInsDMPB1

- **Class:** AsCOInsDMPB1
- **Description:** Them moi chi tiet phan bo
- **SQL File:** `asCOInsDMPB1.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pId | INT | ID phan bo |
| pTk_nhan_pb | NVARCHAR(20) | Tai khoan nhan phan bo |
| pModuleId | NVARCHAR(5) | Ma module |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOInsDMSPCT

- **Class:** AsCOInsDMSPCT
- **Description:** Them moi san pham cong trinh
- **SQL File:** `asCOInsDMSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pTen_spct | NVARCHAR(100) | Ten san pham cong trinh |
| pNgay_kc | SMALLDATETIME | Ngay khoi cong |
| pNgay_kt | SMALLDATETIME | Ngay ket thuc |
| pDu_toan | DECIMAL(19,4) | Du toan |
| pDu_toan_NT | DECIMAL(19,4) | Du toan ngoai te |
| pDv_tc | NVARCHAR(100) | Don vi thi cong |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pDvt | NVARCHAR(8) | Don vi tinh |
| pMa_nhspct | NVARCHAR(20) | Ma nhom san pham cong trinh |
| pSan_pham | NVARCHAR(1) | San pham |
| pKsd | BIT | Khong su dung |
| pLUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

## 2. Update Procedures

### asCOUpdDMCoBomCT

- **Class:** AsCOUpdDMCoBomCT
- **Description:** Cap nhat dinh muc nguyen vat lieu - thong tin chi tiet
- **SQL File:** `asCOUpdDMCoBomCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | VARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pMa_vt | NVARCHAR(20) | Ma vat tu |
| pvt_chinh | NVARCHAR(1) | Vat tu chinh |
| pso_luong | DECIMAL(19,4) | So luong |
| pUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOUpdDMCoBomPH

- **Class:** AsCOUpdDMCoBomPH
- **Description:** Cap nhat dinh muc nguyen vat lieu - thong tin chung
- **SQL File:** `asCOUpdDMCoBomPH.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | VARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pDon_gia_luong | DECIMAL(19,4) | Don gia luong |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOUpdDMNHSPCT

- **Class:** AsCOUpdDMNHSPCT
- **Description:** Cap nhat nhom san pham cong trinh
- **SQL File:** `asCOUpdDMNHSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pma_nhspct | NVARCHAR(8) | Ma nhom san pham cong trinh |
| pten_nhspct | NVARCHAR(50) | Ten nhom san pham cong trinh |
| pCap | INT | Cap do |
| pStt_nhom | NVARCHAR(18) | So thu tu nhom |
| pNhom_me | NVARCHAR(8) | Nhom me |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pCong_sl | BIT | Cong so luong |
| pKsd | BIT | Khong su dung |
| pLUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOUpdDMPB

- **Class:** AsCOUpdDMPB
- **Description:** Cap nhat phan bo
- **SQL File:** `asCOUpdDMPB.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pID | INT | ID phan bo |
| pStt | INT | So thu tu |
| pModuleId | NVARCHAR(5) | Ma module |
| pTen_bt | NVARCHAR(50) | Ten but toan |
| pTk_pb | NVARCHAR(20) | Tai khoan phan bo |
| pSo_ct | NVARCHAR(12) | So chung tu |
| pKsd | BIT | Khong su dung |
| pUser | NVARCHAR(20) | Nguoi dung |
| pTheoSPCT | BIT | Theo san pham cong trinh |
| pTheoBP | BIT | Theo bo phan |
| pTheoTKDU | BIT | Theo tai khoan doi ung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOUpdDMSPCT

- **Class:** AsCOUpdDMSPCT
- **Description:** Cap nhat san pham cong trinh
- **SQL File:** `asCOUpdDMSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pTen_spct | NVARCHAR(100) | Ten san pham cong trinh |
| pNgay_kc | SMALLDATETIME | Ngay khoi cong |
| pNgay_kt | SMALLDATETIME | Ngay ket thuc |
| pDu_toan | DECIMAL(19,4) | Du toan |
| pDu_toan_NT | DECIMAL(19,4) | Du toan ngoai te |
| pDv_tc | NVARCHAR(100) | Don vi thi cong |
| pGhi_chu | NVARCHAR(255) | Ghi chu |
| pDvt | NVARCHAR(8) | Don vi tinh |
| pMa_nhspct | NVARCHAR(20) | Ma nhom san pham cong trinh |
| pSan_pham | NVARCHAR(1) | San pham |
| pKsd | BIT | Khong su dung |
| pLUser | NVARCHAR(20) | Nguoi dung |
| pRet | INT OUTPUT | Ket qua tra ve |

---

### asCOUpdHsPb

- **Class:** AsCOUpdHsPb
- **Description:** Cap nhat he so phan bo
- **SQL File:** `asCOUpdHsPb.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pId | INT | ID phan bo |
| pNam | INT | Nam |
| pTHang | INT | Thang |
| pTk | NVARCHAR(20) | Tai khoan |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pMa_bp | NVARCHAR(20) | Ma bo phan |
| pTk_DU | NVARCHAR(20) | Tai khoan doi ung |
| pHs | DECIMAL(19,4) | He so |
| pTien_nhan | DECIMAL(19,4) | Tien nhan |
| pRet | INT OUTPUT | Ket qua tra ve |

---

## 3. Delete Procedures

### asCODelCalcPb

- **Class:** AsCODelCalcPb
- **Description:** Xoa phan bo da tinh toan
- **SQL File:** `asCODelCalcPb.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pId | INT | ID phan bo |
| pMa_ct | NVARCHAR(3) | Ma chung tu |
| pUser | NVARCHAR(20) | Nguoi dung |

---

### asCODelDMCoBomCT

- **Class:** AsCODelDMCoBomCT
- **Description:** Xoa dinh muc nguyen vat lieu - thong tin chi tiet
- **SQL File:** `asCODelDMCoBomCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pMa_vt | NVARCHAR(20) | Ma vat tu |

---

### asCODelDMCoBomPH

- **Class:** AsCODelDMCoBomPH
- **Description:** Xoa dinh muc nguyen vat lieu - thong tin chung
- **SQL File:** `asCODelDMCoBomPH.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pRet | INT OUTPUT | Ket qua tra ve (0: duoc xoa, 1: khong xoa) |

---

### asCODelDMNHSPCT

- **Class:** AsCODelDMNHSPCT
- **Description:** Xoa nhom san pham cong trinh
- **SQL File:** `asCODelDMNHSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_nhspct | NVARCHAR(8) | Ma nhom san pham cong trinh |

---

### asCODelDMPB

- **Class:** AsCODelDMPB
- **Description:** Xoa phan bo
- **SQL File:** `asCODelDMPB.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pId | INT | ID phan bo |
| pTk_pb | NVARCHAR(20) | Tai khoan phan bo |
| pMa_ct | NVARCHAR(3) | Ma chung tu |

---

### asCODelDMPB1

- **Class:** AsCODelDMPB1
- **Description:** Xoa chi tiet phan bo
- **SQL File:** `asCODelDMPB1.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pId | INT | ID phan bo |
| pTk_nhan_pb | NVARCHAR(20) | Tai khoan nhan phan bo |
| pMa_ct | NVARCHAR(3) | Ma chung tu |

---

### asCODelDMSPCT

- **Class:** AsCODelDMSPCT
- **Description:** Xoa san pham cong trinh
- **SQL File:** `asCODelDMSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |

---

### asCODelPostCp2GlCt

- **Class:** AsCODelPostCp2GlCt
- **Description:** Xoa phan bo chi phi tra truoc trong so cai
- **SQL File:** `asCODelPostCp2GlCt.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_ct | NVARCHAR(3) | Ma chung tu |
| pNam | INT | Nam |
| pThang | INT | Thang |

---

### asCODelUpdateCost

- **Class:** AsCODelUpdateCost
- **Description:** Xoa cap nhat gia thanh phieu nhap thanh pham
- **SQL File:** `asCODelUpdateCost.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pTk154 | NVARCHAR(20) | Tai khoan 154 |

---

## 4. Get Procedures

### asCOGetDMCoBomCT

- **Class:** AsCOGetDMCoBomCT
- **Description:** Lay thong tin dinh muc nguyen vat lieu - thong tin chi tiet
- **SQL File:** `asCOGetDMCoBomCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(20) | Ma cong ty |
| pma_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pMa_vt | NVARCHAR(20) | Ma vat tu |

---

### asCOGetDMCoBomPH

- **Class:** AsCOGetDMCoBomPH
- **Description:** Lay thong tin dinh muc nguyen vat lieu - thong tin chung
- **SQL File:** `asCOGetDMCoBomPH.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(20) | Ma cong ty |
| pma_spct | NVARCHAR(20) | Ma san pham cong trinh |

---

### asCOGetDMNHSPCT

- **Class:** AsCOGetDMNHSPCT
- **Description:** Lay thong tin nhom san pham cong trinh
- **SQL File:** `asCOGetDMNHSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pma_nhspct | NVARCHAR(8) | Ma nhom san pham cong trinh |
| pStruct | NVARCHAR(1) | Cau truc (0: khong, 1: co) |

---

### asCOGetDMPB

- **Class:** AsCOGetDMPB
- **Description:** Lay thong tin phan bo
- **SQL File:** `asCOGetDMPB.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pModuleId | NVARCHAR(5) | Ma module |

---

### asCOGetDMPB1

- **Class:** AsCOGetDMPB1
- **Description:** Lay thong tin chi tiet phan bo (tai khoan nhan phan bo)
- **SQL File:** `asCOGetDMPB1.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pModuleId | NVARCHAR(5) | Ma module |

---

### asCOGetDMPB12

- **Class:** AsCOGetDMPB12
- **Description:** Lay thong tin chi tiet phan bo (bao cao)
- **SQL File:** `asCOGetDMPB12.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNam | INT | Nam |
| pModuleId | NVARCHAR(8) | Ma module |

---

### asCOGetDMSPCT

- **Class:** AsCOGetDMSPCT
- **Description:** Lay thong tin san pham cong trinh
- **SQL File:** `asCOGetDMSPCT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pStruct | NVARCHAR(1) | Cau truc |
| pIsSP | NVARCHAR(1) | La san pham |

---

## 5. Report Procedures

### asCORptGt01

- **Class:** AsCORptGt01
- **Description:** The gia thanh san pham chi tiet
- **SQL File:** `asCORptGt01.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pTk154 | NVARCHAR(20) | Tai khoan 154 |
| pCt_vt | BIT | Chi tiet theo vat tu xuat dung |

---

### asCORptGt02

- **Class:** AsCORptGt02
- **Description:** Bang tinh gia thanh san pham
- **SQL File:** `asCORptGt02.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pTk154 | NVARCHAR(20) | Tai khoan 154 |

---

### asCORptGt03

- **Class:** AsCORptGt03
- **Description:** Bang tinh gia thanh cong trinh
- **SQL File:** `asCORptGt03.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |
| pTk154 | NVARCHAR(20) | Tai khoan 154 |

---

## 6. Process Procedures

### asCOCalcHsPb

- **Class:** AsCOCalcHsPb
- **Description:** Tinh cac doi tuong nhan phan bo trong thang va he so phan bo
- **SQL File:** `asCOCalcHsPb.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pId | INT | ID but toan phan bo |
| pPb_theo | NVARCHAR(20) | Phan bo theo (MA_SPCT, Ma_lo, Ma_hd, Ma_bp, Ma_phi) |
| pHs_theo | NVARCHAR(1) | He so theo (1-8) |

**Chi tiet pHs_theo:**
- 1: Dinh muc NVL - Gia tri
- 2: Don gia tien luong
- 3: Dinh muc NVL - So luong
- 4: Theo TK 621
- 5: Theo TK 622
- 6: Theo TK 622
- 7: Theo TK 511
- 8: Phan bo theo so ke hoach

---

### asCOCalcPb

- **Class:** AsCOCalcPb
- **Description:** Thuc hien phan bo va tao ra cac but toan phan bo trong GLCT
- **SQL File:** `asCOCalcPb.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pId | INT | ID but toan phan bo |
| pMa_ct | NVARCHAR(3) | Ma chung tu |
| pUser | NVARCHAR(20) | Nguoi dung |

---

### asCOGDBGT

- **Class:** AsCOGDBGT
- **Description:** Bang tinh gia thanh san pham - Phuong phap gian don
- **SQL File:** `asCOGDBGT.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pTk154 | NVARCHAR(20) | Tai khoan 154 (tai khoan san pham do dang) |

---

### asCOPostCp2GlCt

- **Class:** AsCOPostCp2GlCt
- **Description:** Post khau hao chi phi tra truoc len so cai
- **SQL File:** `asCOPostCp2GlCt.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pMa_cptt | NVARCHAR(20) | Ma chi phi tra truoc |
| pTen_cptt | NVARCHAR(50) | Ten chi phi tra truoc |
| pMa_ct | NVARCHAR(3) | Ma chung tu |
| pNgay_ct | SMALLDATETIME | Ngay chung tu |
| pTk_cp | NVARCHAR(20) | Tai khoan chi phi |
| pTk_cptt | NVARCHAR(20) | Tai khoan chi phi tra truoc |
| pKhau_Hao | DECIMAL(19,4) | Khau hao |
| pMa_phi | NVARCHAR(20) | Ma phi |
| pMa_spct | NVARCHAR(20) | Ma san pham cong trinh |

---

### asCOUpdateCost

- **Class:** AsCOUpdateCost
- **Description:** Cap nhat gia thanh cho phieu nhap thanh pham
- **SQL File:** `asCOUpdateCost.sql`

| Parameter | Type | Mo ta |
|-----------|------|-------|
| pMa_cty | NVARCHAR(3) | Ma cong ty |
| pNgay1 | SMALLDATETIME | Ngay bat dau |
| pNgay2 | SMALLDATETIME | Ngay ket thuc |
| pTk154 | NVARCHAR(20) | Tai khoan 154 |

---

## Tom tat

| Nhom | So luong | Danh sach |
|------|----------|-----------|
| Insert | 6 | asCOInsDMCoBomCT, asCOInsDMCoBomPH, asCOInsDMNHSPCT, asCOInsDMPB, asCOInsDMPB1, asCOInsDMSPCT |
| Update | 6 | asCOUpdDMCoBomCT, asCOUpdDMCoBomPH, asCOUpdDMNHSPCT, asCOUpdDMPB, asCOUpdDMSPCT, asCOUpdHsPb |
| Delete | 9 | asCODelCalcPb, asCODelDMCoBomCT, asCODelDMCoBomPH, asCODelDMNHSPCT, asCODelDMPB, asCODelDMPB1, asCODelDMSPCT, asCODelPostCp2GlCt, asCODelUpdateCost |
| Get | 7 | asCOGetDMCoBomCT, asCOGetDMCoBomPH, asCOGetDMNHSPCT, asCOGetDMPB, asCOGetDMPB1, asCOGetDMPB12, asCOGetDMSPCT |
| Report | 3 | asCORptGt01, asCORptGt02, asCORptGt03 |
| Process | 4 | asCOCalcHsPb, asCOCalcPb, asCOGDBGT, asCOPostCp2GlCt, asCOUpdateCost |

**Tong cong: 35 procedures**


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
| [IN](../IN/) | Material issuance/FG receipt |
| [PO](../PO/) | Purchase Order integration |
| [SI](../SI/) | Master data reference |

---

*End of CO Procedures Documentation*
