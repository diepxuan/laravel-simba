# CA Procedures (Cash)

## Insert Procedures

### asCAInsPH1

- **Class:** AsCAInsPH1
- **Description:** Thêm phiếu thu (CAPH1)
- **SQL File:** `asCAInsPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | Yes | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | Yes | Số chứng từ |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | Yes | Ngày lập chứng từ |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | Yes | Diễn giải |
| `pTk_no` | nvarchar(20) | No | Tài khoản nợ |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsPH2

- **Class:** AsCAInsPH2
- **Description:** Thêm phiếu chi (CAPH2)
- **SQL File:** `asCAInsPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | Yes | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | Yes | Số chứng từ |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | Yes | Ngày lập chứng từ |
| `pKht_tain` | bit | Yes | Kế hoạch tạm ứng |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | Yes | Diễn giải |
| `pTk_co` | nvarchar(20) | No | Tài khoản có |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pT_Thue` | decimal(19,4) | No | Tổng thuế |
| `pT_Tt_nt` | decimal(19,4) | No | Tổng thanh toán ngoại tệ |
| `pT_Tt` | decimal(19,4) | No | Tổng thanh toán |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsPH3

- **Class:** AsCAInsPH3
- **Description:** Thêm giấy đề nghị thanh toán (CAPH3)
- **SQL File:** `asCAInsPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | Yes | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | Yes | Số chứng từ |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | Yes | Ngày lập chứng từ |
| `pKht_tain` | bit | Yes | Kế hoạch tạm ứng |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | Yes | Diễn giải |
| `pTk_co` | nvarchar(20) | No | Tài khoản có |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pT_Thue` | decimal(19,4) | No | Tổng thuế |
| `pT_Tt_nt` | decimal(19,4) | No | Tổng thanh toán ngoại tệ |
| `pT_Tt` | decimal(19,4) | No | Tổng thanh toán |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsCT1

- **Class:** AsCAInsCT1
- **Description:** Thêm chi tiết phiếu thu (CACT1)
- **SQL File:** `asCAInsCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pStt_rec0` | nvarchar(3) | Yes | Số thứ tự dòng |
| `pTk` | nvarchar(20) | Yes | Tài khoản |
| `pPs_no` | decimal(19,4) | No | Phát sinh nợ |
| `pPs_co` | decimal(19,4) | No | Phát sinh có |
| `pPs_no_nt` | decimal(19,4) | No | Phát sinh nợ ngoại tệ |
| `pPs_co_nt` | decimal(19,4) | No | Phát sinh có ngoại tệ |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_bp` | nvarchar(20) | No | Mã bộ phận |
| `pMa_phi` | nvarchar(20) | No | Mã phí |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_spct` | nvarchar(20) | No | Mã sản phẩm/công trình |
| `pMa_lo` | nvarchar(20) | No | Mã lô |
| `pRet` | int output | Yes | Return code |

---

### asCAInsCT2

- **Class:** AsCAInsCT2
- **Description:** Thêm chi tiết phiếu chi (CACT2)
- **SQL File:** `asCAInsCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pStt_rec0` | nvarchar(3) | Yes | Số thứ tự dòng |
| `pTk` | nvarchar(20) | Yes | Tài khoản |
| `pPs_no` | decimal(19,4) | No | Phát sinh nợ |
| `pPs_co` | decimal(19,4) | No | Phát sinh có |
| `pPs_no_nt` | decimal(19,4) | No | Phát sinh nợ ngoại tệ |
| `pPs_co_nt` | decimal(19,4) | No | Phát sinh có ngoại tệ |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_lo` | nvarchar(20) | No | Mã lô |
| `pMa_bp` | nvarchar(20) | No | Mã bộ phận |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_phi` | nvarchar(20) | No | Mã phí |
| `pMa_spct` | nvarchar(20) | No | Mã sản phẩm/công trình |
| `pRet` | int output | Yes | Return code |

---

### asCAInsCT3

- **Class:** AsCAInsCT3
- **Description:** Thêm chi tiết giấy đề nghị thanh toán (CACT3)
- **SQL File:** `asCAInsCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pStt_rec0` | nvarchar(3) | Yes | Số thứ tự dòng |
| `pStt_rec_pc` | nvarchar(20) | No | Số thứ tự phiếu chi |
| `pStt_rec0_pc` | nvarchar(3) | No | Số thứ tự dòng phiếu chi |
| `pSo_pc` | nvarchar(12) | No | Số phiếu chi |
| `pTk` | nvarchar(20) | Yes | Tài khoản |
| `pPs_no` | decimal(19,4) | No | Phát sinh nợ |
| `pPs_co` | decimal(19,4) | No | Phát sinh có |
| `pPs_no_nt` | decimal(19,4) | No | Phát sinh nợ ngoại tệ |
| `pPs_co_nt` | decimal(19,4) | No | Phát sinh có ngoại tệ |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_lo` | nvarchar(20) | No | Mã lô |
| `pMa_bp` | nvarchar(20) | No | Mã bộ phận |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_phi` | nvarchar(20) | No | Mã phí |
| `pMa_spct` | nvarchar(20) | No | Mã sản phẩm/công trình |
| `pRet` | int output | Yes | Return code |

---

### asCAInsCDKU

- **Class:** AsCAInsCDKU
- **Description:** Thêm chi tiết khoản vay (CACDKU)
- **SQL File:** `asCAInsCDKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNam` | int | Yes | Năm |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pTk` | nvarchar(20) | Yes | Tài khoản |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pNgay_ku` | smalldatetime | Yes | Ngày ký khế ước |
| `pNgay_tt` | smalldatetime | No | Ngày thanh toán |
| `pDa_vay` | decimal(19,4) | Yes | Số tiền đã vay |
| `pDa_vay_nt` | decimal(19,4) | No | Số tiền đã vay (ngoại tệ) |
| `pDa_tt` | decimal(19,4) | No | Số tiền đã thanh toán |
| `pDa_tt_nt` | decimal(19,4) | No | Số tiền đã thanh toán (ngoại tệ) |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsDMKU

- **Class:** AsCAInsDMKU
- **Description:** Thêm danh mục khoản vay (CADMKU)
- **SQL File:** `asCAInsDMKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pTen_ku` | nvarchar(50) | Yes | Tên khế ước |
| `pSo_ku` | nvarchar(20) | Yes | Số khế ước |
| `pNgay_vay` | smalldatetime | Yes | Ngày vay |
| `pNgay_ky` | smalldatetime | Yes | Ngày ký |
| `pThoi_han` | int | Yes | Thời hạn |
| `pTinh_theo` | nvarchar(1) | No | Tính theo (1: tháng, 2: năm) |
| `pPhuong_phap` | nvarchar(1) | No | Phương pháp tính lãi |
| `pKy_tt_goc` | nvarchar(1) | No | Kỳ trả gốc |
| `pKy_tt_lai` | nvarchar(1) | No | Kỳ trả lãi |
| `pNgay_dh` | smalldatetime | No | Ngày đến hạn |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTien_nt` | decimal(19,4) | No | Số tiền ngoại tệ |
| `pTien` | decimal(19,4) | No | Số tiền |
| `pLai_suat` | decimal(19,4) | No | Lãi suất |
| `pLs_qh` | decimal(19,4) | No | Lãi suất quá hạn |
| `pTk_vay` | nvarchar(20) | No | Tài khoản vay |
| `pTk_cp` | nvarchar(20) | No | Tài khoản chi phí |
| `pTk_cp_pt` | nvarchar(20) | No | Tài khoản chi phí phân bổ |
| `pGhi_chu` | nvarchar(255) | No | Ghi chú |
| `pKsd` | bit | No | Khóa sử dụng |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsLaiKu

- **Class:** AsCAInsLaiKu
- **Description:** Thêm lãi khế ước (CALaiKu)
- **SQL File:** `asCAInsLaiKu.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNgay_tra` | smalldatetime | Yes | Ngày trả |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pNam` | int | Yes | Năm |
| `pThang` | int | Yes | Tháng |
| `pTien_lai_tk` | decimal(19,4) | No | Tiền lãi trong kỳ |
| `pTien_lai_tk_nt` | decimal(19,4) | No | Tiền lãi trong kỳ (ngoại tệ) |
| `pTien_goc_tk` | decimal(19,4) | No | Tiền gốc trong kỳ |
| `pTien_goc_tk_nt` | decimal(19,4) | No | Tiền gốc trong kỳ (ngoại tệ) |
| `pTien_lai_qh` | decimal(19,4) | No | Tiền lãi quá hạn |
| `pTien_lai_qh_nt` | decimal(19,4) | No | Tiền lãi quá hạn (ngoại tệ) |
| `pTien_goc_qh` | decimal(19,4) | No | Tiền gốc quá hạn |
| `pTien_goc_qh_nt` | decimal(19,4) | No | Tiền gốc quá hạn (ngoại tệ) |
| `pSua_lai` | bit | No | Sửa lãi |
| `pSua_goc` | bit | No | Sửa gốc |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

### asCAInsTTHU

- **Class:** AsCAInsTTHU
- **Description:** Thêm thanh toán tạm ứng (CATTHU)
- **SQL File:** `asCAInsTTHU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | Yes | Mã chứng từ |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |
| `pSo_ct` | nvarchar(12) | Yes | Số chứng từ |
| `pMa_ct_tt` | nvarchar(3) | Yes | Mã chứng từ thanh toán |
| `pStt_rec_tt` | nvarchar(20) | Yes | Số thứ tự thanh toán |
| `pNgay_ct_tt` | smalldatetime | Yes | Ngày thanh toán |
| `pSo_ct_tt` | nvarchar(12) | Yes | Số thanh toán |
| `pMa_KH` | nvarchar(20) | Yes | Mã khách hàng |
| `pTk_tu` | nvarchar(20) | Yes | Tài khoản tạm ứng |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pTien_pc` | decimal(19,4) | Yes | Tiền phiếu chi |
| `pTien_pc_nt` | decimal(19,4) | No | Tiền phiếu chi (ngoại tệ) |
| `pTien_da_tt` | decimal(19,4) | Yes | Tiền đã thanh toán |
| `pTien_da_tt_nt` | decimal(19,4) | No | Tiền đã thanh toán (ngoại tệ) |
| `pTat_toan` | bit | No | Tất toán |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pLUser` | nvarchar(20) | Yes | Người tạo |
| `pRet` | int output | Yes | Return code |

---

## Update Procedures

### asCAUpdPH1

- **Class:** AsCAUpdPH1
- **Description:** Cập nhật phiếu thu (CAPH1)
- **SQL File:** `asCAUpdPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | No | Số chứng từ |
| `pNgay_ct` | smalldatetime | No | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | No | Ngày lập chứng từ |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pTk_no` | nvarchar(20) | No | Tài khoản nợ |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdPH2

- **Class:** AsCAUpdPH2
- **Description:** Cập nhật phiếu chi (CAPH2)
- **SQL File:** `asCAUpdPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | No | Số chứng từ |
| `pNgay_ct` | smalldatetime | No | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | No | Ngày lập chứng từ |
| `pKht_tain` | bit | No | Kế hoạch tạm ứng |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pTk_co` | nvarchar(20) | No | Tài khoản có |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pT_Thue` | decimal(19,4) | No | Tổng thuế |
| `pT_Tt_nt` | decimal(19,4) | No | Tổng thanh toán ngoại tệ |
| `pT_Tt` | decimal(19,4) | No | Tổng thanh toán |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdPH3

- **Class:** AsCAUpdPH3
- **Description:** Cập nhật giấy đề nghị thanh toán (CAPH3)
- **SQL File:** `asCAUpdPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pSo_ct` | nvarchar(12) | No | Số chứng từ |
| `pNgay_ct` | smalldatetime | No | Ngày chứng từ |
| `pNgay_lct` | smalldatetime | No | Ngày lập chứng từ |
| `pKht_tain` | bit | No | Kế hoạch tạm ứng |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pDia_chi` | nvarchar(255) | No | Địa chỉ |
| `pNguoi_gd` | nvarchar(30) | No | Người giao dịch |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pTk_co` | nvarchar(20) | No | Tài khoản có |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pT_tien_nt` | decimal(19,4) | No | Tổng tiền ngoại tệ |
| `pT_tien` | decimal(19,4) | No | Tổng tiền |
| `pT_Thue` | decimal(19,4) | No | Tổng thuế |
| `pT_Tt_nt` | decimal(19,4) | No | Tổng thanh toán ngoại tệ |
| `pT_Tt` | decimal(19,4) | No | Tổng thanh toán |
| `pTrang_thai` | nvarchar(1) | No | Trạng thái |
| `pPost2gl` | nvarchar(1) | No | Post to GL |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdCT3

- **Class:** AsCAUpdCT3
- **Description:** Cập nhật chi tiết giấy đề nghị thanh toán (CACT3)
- **SQL File:** `zasCAUpdCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pStt_rec0` | nvarchar(3) | Yes | Số thứ tự dòng |
| `pStt_rec_pc` | nvarchar(20) | No | Số thứ tự phiếu chi |
| `pStt_rec0_pc` | nvarchar(3) | No | Số thứ tự dòng phiếu chi |
| `pSo_pc` | nvarchar(12) | No | Số phiếu chi |
| `pTk` | nvarchar(20) | No | Tài khoản |
| `pPs_no` | decimal(19,4) | No | Phát sinh nợ |
| `pPs_co` | decimal(19,4) | No | Phát sinh có |
| `pPs_no_nt` | decimal(19,4) | No | Phát sinh nợ ngoại tệ |
| `pPs_co_nt` | decimal(19,4) | No | Phát sinh có ngoại tệ |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_bp` | nvarchar(20) | No | Mã bộ phận |
| `pMa_phi` | nvarchar(20) | No | Mã phí |
| `pMa_spct` | nvarchar(20) | No | Mã sản phẩm/công trình |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_lo` | nvarchar(20) | No | Mã lô |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdCDKU

- **Class:** AsCAUpdCDKU
- **Description:** Cập nhật chi tiết khoản vay (CACDKU)
- **SQL File:** `asCAUpdCDKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNam` | int | Yes | Năm |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pTk` | nvarchar(20) | No | Tài khoản |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pNgay_ku` | smalldatetime | No | Ngày ký khế ước |
| `pNgay_tt` | smalldatetime | No | Ngày thanh toán |
| `pDa_vay` | decimal(19,4) | No | Số tiền đã vay |
| `pDa_vay_nt` | decimal(19,4) | No | Số tiền đã vay (ngoại tệ) |
| `pDa_tt` | decimal(19,4) | No | Số tiền đã thanh toán |
| `pDa_tt_nt` | decimal(19,4) | No | Số tiền đã thanh toán (ngoại tệ) |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdDMKU

- **Class:** AsCAUpdDMKU
- **Description:** Cập nhật danh mục khoản vay (CADMKU)
- **SQL File:** `asCAUpdDMKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pTen_ku` | nvarchar(50) | No | Tên khế ước |
| `pSo_ku` | nvarchar(20) | No | Số khế ước |
| `pNgay_vay` | smalldatetime | No | Ngày vay |
| `pNgay_ky` | smalldatetime | No | Ngày ký |
| `pThoi_han` | int | No | Thời hạn |
| `pTinh_theo` | nvarchar(1) | No | Tính theo (1: tháng, 2: năm) |
| `pPhuong_phap` | nvarchar(1) | No | Phương pháp tính lãi |
| `pKy_tt_goc` | nvarchar(1) | No | Kỳ trả gốc |
| `pKy_tt_lai` | nvarchar(1) | No | Kỳ trả lãi |
| `pNgay_dh` | smalldatetime | No | Ngày đến hạn |
| `pMa_hd` | nvarchar(20) | No | Mã hợp đồng |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTien_nt` | decimal(19,4) | No | Số tiền ngoại tệ |
| `pTien` | decimal(19,4) | No | Số tiền |
| `pLai_suat` | decimal(19,4) | No | Lãi suất |
| `pLs_qh` | decimal(19,4) | No | Lãi suất quá hạn |
| `pTk_vay` | nvarchar(20) | No | Tài khoản vay |
| `pTk_cp` | nvarchar(20) | No | Tài khoản chi phí |
| `pTk_cp_pt` | nvarchar(20) | No | Tài khoản chi phí phân bổ |
| `pGhi_chu` | nvarchar(255) | No | Ghi chú |
| `pKsd` | bit | No | Khóa sử dụng |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdLaiKu

- **Class:** AsCAUpdLaiKu
- **Description:** Cập nhật lãi khế ước (CALaiKu)
- **SQL File:** `asCAUpdLaiKu.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNgay_tra` | smalldatetime | Yes | Ngày trả |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pNam` | int | No | Năm |
| `pThang` | int | No | Tháng |
| `pTien_lai_tk` | decimal(19,4) | No | Tiền lãi trong kỳ |
| `pTien_lai_tk_nt` | decimal(19,4) | No | Tiền lãi trong kỳ (ngoại tệ) |
| `pTien_goc_tk` | decimal(19,4) | No | Tiền gốc trong kỳ |
| `pTien_goc_tk_nt` | decimal(19,4) | No | Tiền gốc trong kỳ (ngoại tệ) |
| `pTien_lai_qh` | decimal(19,4) | No | Tiền lãi quá hạn |
| `pTien_lai_qh_nt` | decimal(19,4) | No | Tiền lãi quá hạn (ngoại tệ) |
| `pTien_goc_qh` | decimal(19,4) | No | Tiền gốc quá hạn |
| `pTien_goc_qh_nt` | decimal(19,4) | No | Tiền gốc quá hạn (ngoại tệ) |
| `pSua_lai` | bit | No | Sửa lãi |
| `pSua_goc` | bit | No | Sửa gốc |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

### asCAUpdTTHU

- **Class:** AsCAUpdTTHU
- **Description:** Cập nhật thanh toán tạm ứng (CATTHU)
- **SQL File:** `asCAUpdTTHU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pNgay_ct` | smalldatetime | No | Ngày chứng từ |
| `pSo_ct` | nvarchar(12) | No | Số chứng từ |
| `pMa_ct_tt` | nvarchar(3) | No | Mã chứng từ thanh toán |
| `pStt_rec_tt` | nvarchar(20) | No | Số thứ tự thanh toán |
| `pNgay_ct_tt` | smalldatetime | No | Ngày thanh toán |
| `pSo_ct_tt` | nvarchar(12) | No | Số thanh toán |
| `pMa_KH` | nvarchar(20) | No | Mã khách hàng |
| `pTk_tu` | nvarchar(20) | No | Tài khoản tạm ứng |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |
| `pTy_gia` | decimal(19,4) | No | Tỷ giá |
| `pTien_pc` | decimal(19,4) | No | Tiền phiếu chi |
| `pTien_pc_nt` | decimal(19,4) | No | Tiền phiếu chi (ngoại tệ) |
| `pTien_da_tt` | decimal(19,4) | No | Tiền đã thanh toán |
| `pTien_da_tt_nt` | decimal(19,4) | No | Tiền đã thanh toán (ngoại tệ) |
| `pTat_toan` | bit | No | Tất toán |
| `pDien_giai` | nvarchar(255) | No | Diễn giải |
| `pLUser` | nvarchar(20) | Yes | Người cập nhật |
| `pRet` | int output | Yes | Return code |

---

## Delete Procedures

### asCADelPH1

- **Class:** AsCADelPH1
- **Description:** Xóa phiếu thu (CAPH1) và các bảng liên quan (GLCT, ARTT, CACT1)
- **SQL File:** `asCADelPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pLUser` | nvarchar(20) | Yes | Người xóa |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelPH2

- **Class:** AsCADelPH2
- **Description:** Xóa phiếu chi (CAPH2) và các bảng liên quan (GLCT, TAIN, ARTT, CATTHU, CACT2)
- **SQL File:** `asCADelPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pLUser` | nvarchar(20) | Yes | Người xóa |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelPH3

- **Class:** AsCADelPH3
- **Description:** Xóa giấy đề nghị thanh toán (CAPH3) và các bảng liên quan
- **SQL File:** `asCADelPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pLUser` | nvarchar(20) | Yes | Người xóa |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelCT1

- **Class:** AsCADelCT1
- **Description:** Xóa chi tiết phiếu thu (CACT1)
- **SQL File:** `asCADelCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelCT2

- **Class:** AsCADelCT2
- **Description:** Xóa chi tiết phiếu chi (CACT2)
- **SQL File:** `asCADelCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelCT3

- **Class:** AsCADelCT3
- **Description:** Xóa chi tiết giấy đề nghị thanh toán (CACT3)
- **SQL File:** `asCADelCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelCDKU

- **Class:** AsCADelCDKU
- **Description:** Xóa chi tiết khoản vay (CACDKU)
- **SQL File:** `asCADelCDKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNam` | int | Yes | Năm |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pRet` | int output | Yes | Return code (0: thành công) |

---

### asCADelDMKU

- **Class:** AsCADelDMKU
- **Description:** Xóa danh mục khoản vay (CADMKU)
- **SQL File:** `asCADelDMKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước |
| `pRet` | int output | Yes | Return code (0: thành công, 50004: đã sử dụng) |

---

### asCADelLaiKU

- **Class:** AsCADelLaiKU
- **Description:** Xóa lãi khế ước (CALaiKu) theo tháng/năm
- **SQL File:** `asCADelLaiKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pThang` | int | Yes | Tháng |
| `pNam` | int | Yes | Năm |
| `pMa_ku` | nvarchar(20) | Yes | Mã khế ước (có thể dùng wildcard) |
| `pRet` | int output | Yes | Return code |

---

### asCADelTTHU

- **Class:** AsCADelTTHU
- **Description:** Xóa thanh toán tạm ứng (CATTHU) - xóa cả phiếu chi và phiếu thanh toán
- **SQL File:** `asCADelTTHU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pRet` | int output | Yes | Return code |

---

### asCADelPostLaiKU

- **Class:** AsCADelPostLaiKU
- **Description:** Xóa bút toán lãi khế ước đã post vào sổ cái (GLCT)
- **SQL File:** `asCADelPostLaiKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(20) | Yes | Mã công ty |
| `pThang` | int | Yes | Tháng |
| `pNam` | int | Yes | Năm |
| `pMa_ct` | nvarchar(3) | Yes | Mã chứng từ (thường là CA6) |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước (có thể dùng wildcard) |

---

## Get Procedures

### asCAGetPH1

- **Class:** AsCAGetPH1
- **Description:** Lấy thông tin phiếu thu (CAPH1) - lấy record mới nhất
- **SQL File:** `asCAGetPH1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record (default: '%') |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Thông tin phiếu thu kèm tên khách hàng, tên tài khoản

---

### asCAGetPH2

- **Class:** AsCAGetPH2
- **Description:** Lấy thông tin phiếu chi (CAPH2) - lấy record mới nhất
- **SQL File:** `asCAGetPH2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record (default: '%') |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Thông tin phiếu chi kèm tên khách hàng, tên tài khoản

---

### asCAGetPH3

- **Class:** AsCAGetPH3
- **Description:** Lấy thông tin giấy đề nghị thanh toán (CAPH3) - lấy record mới nhất
- **SQL File:** `asCAGetPH3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record (default: '%') |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Thông tin giấy đề nghị thanh toán kèm tên khách hàng, tên tài khoản

---

### asCAGetCT1

- **Class:** AsCAGetCT1
- **Description:** Lấy chi tiết phiếu thu (CACT1)
- **SQL File:** `asCAGetCT1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Chi tiết phiếu thu kèm tên tài khoản, khách hàng, khế ước, lô, bộ phận, hợp đồng, phí, sản phẩm

---

### asCAGetCT2

- **Class:** AsCAGetCT2
- **Description:** Lấy chi tiết phiếu chi (CACT2)
- **SQL File:** `asCAGetCT2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Chi tiết phiếu chi kèm tên tài khoản, khách hàng, khế ước, lô, bộ phận, hợp đồng, phí, sản phẩm

---

### asCAGetCT3

- **Class:** AsCAGetCT3
- **Description:** Lấy chi tiết giấy đề nghị thanh toán (CACT3)
- **SQL File:** `asCAGetCT3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pStt_rec` | nvarchar(20) | No | Số thứ tự record |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Chi tiết giấy đề nghị thanh toán kèm thông tin phiếu chi, tài khoản, khách hàng, khế ước

---

### asCAGetCDKU

- **Class:** AsCAGetCDKU
- **Description:** Lấy chi tiết khoản vay (CACDKU)
- **SQL File:** `asCAGetCDKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '') |
| `pNam` | int | No | Năm |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước (default: '') |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Chi tiết khoản vay kèm tên khế ước, tên tài khoản

---

### asCAGetDMKU

- **Class:** AsCAGetDMKU
- **Description:** Lấy danh mục khoản vay (CADMKU)
- **SQL File:** `asCAGetDMKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '%') |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước (default: '%') |
| `pStruct` | nvarchar(1) | No | Cấu trúc (default: '0') |

**Returns:** Danh mục khoản vay kèm tên tài khoản vay, chi phí, chi phí phân bổ

---

### asCAGetLaiKu

- **Class:** AsCAGetLaiKu
- **Description:** Lấy lãi khế ước (CALaiKu)
- **SQL File:** `asCAGetLaiKu.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '') |

**Returns:** Thông tin lãi khế ước đầy đủ

---

### asCAGetTTHU

- **Class:** AsCAGetTTHU
- **Description:** Lấy thanh toán tạm ứng (CATTHU) - kết hợp phiếu chi và thanh toán
- **SQL File:** `asCAGetTTHU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '') |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ (default: '') |

**Returns:** Thông tin thanh toán tạm ứng kèm số dư, thông tin thanh toán

---

## Filter Procedures

### asCAFilt1

- **Class:** AsCAFilt1
- **Description:** Lọc phiếu thu (CAPH1) theo điều kiện - trả về cả header và chi tiết
- **SQL File:** `asCAFilt1.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | No | Điều kiện lọc header (default: '1=1') |
| `pKeyCt` | nvarchar(1000) | No | Điều kiện lọc chi tiết (default: '1=1') |

**Returns:** 2 result sets: Header (CAPH1) và Chi tiết (CACT1)

---

### asCAFilt2

- **Class:** AsCAFilt2
- **Description:** Lọc phiếu chi (CAPH2) theo điều kiện - trả về header, chi tiết và TAIN
- **SQL File:** `asCAFilt2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes | Điều kiện lọc header |
| `pKeyCt` | nvarchar(1000) | Yes | Điều kiện lọc chi tiết |

**Returns:** 3 result sets: Header (CAPH2), Chi tiết (CACT2), TAIN

---

### asCAFilt3

- **Class:** AsCAFilt3
- **Description:** Lọc giấy đề nghị thanh toán (CAPH3) theo điều kiện - trả về header, chi tiết và TAIN
- **SQL File:** `asCAFilt3.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pKeyPh` | nvarchar(1000) | Yes | Điều kiện lọc header |
| `pKeyCt` | nvarchar(1000) | Yes | Điều kiện lọc chi tiết |

**Returns:** 3 result sets: Header (CAPH3), Chi tiết (CACT3), TAIN

---

## Report Procedures

### asCARptTMNH01

- **Class:** AsCARptTMNH01
- **Description:** Sổ quỹ - Báo cáo phát sinh theo tài khoản tiền mặt/ngân hàng
- **SQL File:** `asCARptTMNH01.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | No | Mã công ty (default: '001') |
| `pTk` | nvarchar(20) | No | Tài khoản (default: '111') |
| `pNgay_Ct1` | smalldatetime | No | Ngày bắt đầu (default: '20151001') |
| `pNgay_ct2` | smalldatetime | No | Ngày kết thúc (default: '20151031') |
| `pMa_Nt` | nvarchar(3) | No | Mã ngoại tệ (default: '') |

**Returns:** Sổ quỹ với dư đầu, phát sinh, dư cuối

---

### asCARptTMNH01a

- **Class:** AsCARptTMNH01a
- **Description:** Sổ quỹ (biến thể) - có thêm thông tin chi tiết
- **SQL File:** `asCARptTMNH01a.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes | Mã công ty |
| `pTk` | nvarchar(20) | Yes | Tài khoản |
| `pNgay_Ct1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay_ct2` | smalldatetime | Yes | Ngày kết thúc |
| `pMa_Nt` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Sổ quỹ chi tiết với thông tin khách hàng, bộ phận, khế ước

---

### asCARptTMNH02

- **Class:** AsCARptTMNH02
- **Description:** Sổ tiền gửi ngân hàng - theo dõi phát sinh theo tháng
- **SQL File:** `asCARptTMNH02.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes | Mã công ty |
| `pTk` | nvarchar(20) | No | Tài khoản (default: '111') |
| `pNgay1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay2` | smalldatetime | Yes | Ngày kết thúc |
| `pMaNt` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Sổ tiền gửi với tổng hợp theo tháng, quý

---

### asCARptTMNH03

- **Class:** AsCARptTMNH03
- **Description:** Báo cáo khế ước - tổng hợp
- **SQL File:** `asCARptTMNH03.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNgay1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay2` | smalldatetime | Yes | Ngày kết thúc |
| `pTk` | nvarchar(20) | No | Tài khoản |
| `pMa_Ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_NT` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Báo cáo khế ước với số tiền vay, đã trả, còn phải trả

---

### asCARptTMNH032

- **Class:** AsCARptTMNH032
- **Description:** Báo cáo khế ước - chi tiết
- **SQL File:** `asCARptTMNH032.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNgay1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay2` | smalldatetime | Yes | Ngày kết thúc |
| `pTk` | nvarchar(20) | No | Tài khoản |
| `pMa_Ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_NT` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Báo cáo khế ước chi tiết với tiền lãi, trả gốc

---

### asCARptTMNH04

- **Class:** AsCARptTMNH04
- **Description:** Bảng theo dõi tạm ứng
- **SQL File:** `asCARptTMNH04.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes | Mã công ty |
| `pTk` | nvarchar(20) | No | Tài khoản tạm ứng (default: '141') |
| `pNgay1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay2` | smalldatetime | Yes | Ngày kết thúc |
| `pMa_kh` | nvarchar(20) | No | Mã khách hàng |
| `pNhom_kh` | nvarchar(8) | No | Nhóm khách hàng |
| `pMa_Nt` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Bảng theo dõi tạm ứng với số dư đầu kỳ, phát sinh, cuối kỳ

---

### asCARptTMNH05

- **Class:** AsCARptTMNH05
- **Description:** Bảng tính lãi vay
- **SQL File:** `asCARptTMNH05.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pNgay1` | smalldatetime | Yes | Ngày bắt đầu |
| `pNgay2` | smalldatetime | Yes | Ngày kết thúc |
| `pMa_Ku` | nvarchar(20) | No | Mã khế ước |
| `pMa_NT` | nvarchar(3) | No | Mã ngoại tệ (default: 'VND') |

**Returns:** Bảng tính lãi vay theo kỳ với 4 phương pháp tính lãi

---

### asCARptTMNH07

- **Class:** AsCARptTMNH07
- **Description:** Bảng cân đối phát sinh các khế ước
- **SQL File:** `asCARptTMNH07.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pTk` | nvarchar(20) | No | Tài khoản |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pNgay_ctk` | smalldatetime | Yes | Ngày bắt đầu kỳ |
| `pNgay_cdk` | smalldatetime | Yes | Ngày kết thúc kỳ |
| `pMa_nt` | nvarchar(3) | No | Mã ngoại tệ |

**Returns:** Cân đối phát sinh khế ước (Nợ/Có đầu kỳ, phát sinh, cuối kỳ)

---

## Process Procedures

### asCACalLaiKU

- **Class:** AsCACalLaiKU
- **Description:** Tính lãi khế ước trong kỳ - hỗ trợ 4 phương pháp tính lãi
- **SQL File:** `asCACalLaiKU.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pThang` | int | Yes | Tháng |
| `pNam` | int | Yes | Năm |
| `pMa_ct` | nvarchar(3) | No | Mã chứng từ (default: 'CA6') |
| `pMa_ku` | nvarchar(20) | No | Mã khế ước |
| `pUser` | nvarchar(50) | No | Người thực hiện |
| `pRet` | int output | Yes | Return code |

**Phương pháp tính lãi:**
- 1: Trả gốc và lãi theo dư nợ giảm dần
- 2: Trả góp đều hàng tháng theo lãi suất kép
- 3: Trả góp đều theo lãi suất đơn
- 4: Trả góp đều, lãi tính trên dư nợ giảm dần

---

### asCARecalCA2

- **Class:** AsCARecalCA2
- **Description:** Tính lại số dư cho các phiếu chi - cập nhật du_pc, tien_tt, tat_toan
- **SQL File:** `asCARecalCA2.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |

---

### asCaGetCA24CA5

- **Class:** AsCaGetCA24CA5
- **Description:** Lấy danh sách phiếu chi chưa tất toán và đã tất toán cho báo cáo
- **SQL File:** `asCaGetCA24CA5.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes | Mã công ty |
| `pMa_Kh` | nvarchar(20) | Yes | Mã khách hàng |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |

**Returns:** 2 result sets: Phiếu chi chưa tất toán, Phiếu chi đã tất toán

---

### asCaGetCA5ToPrint

- **Class:** AsCaGetCA5ToPrint
- **Description:** Lấy thông tin phiếu tất toán để in
- **SQL File:** `asCaGetCA5ToPrint.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_Cty` | nvarchar(3) | Yes | Mã công ty |
| `pStt_rec_pc` | nvarchar(20) | Yes | Số thứ tự phiếu chi |
| `pNgay_ct` | smalldatetime | Yes | Ngày chứng từ |

**Returns:** Thông tin phiếu tất toán kèm số phiếu chi, ngày chi

---

### asCaVchCA2GetVATNK_TAIN

- **Class:** AsCaVchCA2GetVATNK_TAIN
- **Description:** Lấy danh sách chứng từ chưa thanh toán thuế NK (TAIN)
- **SQL File:** `asCaVchCA2GetVATNK_TAIN.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(20) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |

**Returns:** Danh sách TAIN chưa thanh toán thuế NK

---

### asCaVchCA2UpdateTAIN

- **Class:** AsCaVchCA2UpdateTAIN
- **Description:** Cập nhật thanh toán thuế NK cho hóa đơn mua hàng
- **SQL File:** `asCaVchCA2UpdateTAIN.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(20) | Yes | Mã công ty |
| `pStt_rec` | nvarchar(20) | Yes | Số thứ tự record |
| `pStt_rec0` | nvarchar(3) | Yes | Số thứ tự dòng |
| `pNgay_pc` | smalldatetime | Yes | Ngày phiếu chi |
| `pStt_rec_pc` | nvarchar(20) | Yes | Số thứ tự phiếu chi |
| `pVAT_NK` | bit | Yes | Trạng thái VAT NK |

---

### asCalcCost

- **Class:** AsCalcCost
- **Description:** Tính giá thành sản phẩm/công trình - lưu vào COBGT
- **SQL File:** `asCalcCost.sql`

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | No | Mã công ty (default: '111') |
| `pNgay1` | smalldatetime | No | Ngày bắt đầu (default: '20150101') |
| `pNgay2` | smalldatetime | No | Ngày kết thúc (default: '20150131') |
| `pTk154` | nvarchar(20) | No | Tài khoản sản phẩm dở dang (default: '') |

**Returns:** 2 result sets: Master (tổng hợp), Detail (chi tiết giá thành)

---

## Related Tables

| Table | Description |
|-------|-------------|
| CAPH1 | Phiếu thu header |
| CAPH2 | Phiếu chi header |
| CAPH3 | Giấy đề nghị thanh toán header |
| CACT1 | Chi tiết phiếu thu |
| CACT2 | Chi tiết phiếu chi |
| CACT3 | Chi tiết giấy đề nghị thanh toán |
| CADMKU | Danh mục khế ước |
| CACDKU | Chi tiết khoản vay |
| CALaiKu | Lãi khế ước |
| CATTHU | Thanh toán tạm ứng |
| GLCT | Sổ cái chi tiết |
| ARTT | Theo dõi công nợ |
| TAIN | Thuế nhập khẩu |



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
| [AR](../AR/) | Customer receipts |
| [AP](../AP/) | Vendor payments |
| [SI](../SI/) | Master data reference |

---

*End of CA Procedures Documentation*
