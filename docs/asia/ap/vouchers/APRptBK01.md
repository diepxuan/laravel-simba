# Phân tích DLL: APRptBK01.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | APRptBK01.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmAPRptBK01 |
| **Kế thừa** | frmReport |
| **Chức năng** | Bảng kê chứng từ mua hàng |

## 2. Forms

### 2.1 frmAPRptBK01 (Report Form)

**Mô tả:** Form báo cáo bảng kê chứng từ mua hàng

**Controls - Phần lọc:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Kh | AsTextBox | MA_KH | Mã nhà cung cấp |
| txtMa_vt | AsTextBox | DMVT | Mã vật tư |
| txtMa_nhvt | AsTextBox | DMNHVT | Nhóm vật tư |
| txtMa_kho | AsTextBox | DMKHO | Mã kho |
| txtMa_Bp | AsTextBox | DMBP | Mã bộ phận |
| txtMa_Hd | AsTextBox | DMHD | Mã hợp đồng |
| txtMa_plkh1 | AsTextBox | DMPLKH | Phân loại KH 1 |
| txtMa_plkh2 | AsTextBox | DMPLKH | Phân loại KH 2 |
| txtMa_plkh3 | AsTextBox | DMPLKH | Phân loại KH 3 |
| txtSo_PX | TextBox | - | Số phiếu nhập |
| txtSo_Ct1 | TextBox | - | Chứng từ từ số |
| txtSo_Ct2 | TextBox | - | Chứng từ đến số |
| txtMa_lo | AsTextBox | DMLO | Mã lô |
| txtMa_phi | AsTextBox | DMPHI | Mã phí |
| txtma_spct | AsTextBox | DMSPCT | Mã SPCT |

**Tiêu đề UI:**

- "Bảng kê hóa đơn phải trả" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng"
- "Mã vật tư", "Tên vật tư", "Nhóm vật tư"
- "Mã kho", "Mã bộ phận"
- "Mã hợp đồng", "Tên hợp đồng"
- "P.Loại KH1", "P.Loại KH2", "P.Loại KH3" (Phân loại khách hàng)
- "Số phiếu nhập"
- "Chứng từ số", "đến số"
- "Mã lô", "Mã phí", "Mã SPCT"

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPRptBK01 | Bảng kê chứng từ mua hàng |

## 4. Báo cáo

### 4.1 Thông tin báo cáo

| Thuộc tính | Giá trị |
|------------|---------|
| **Tiêu đề** | Bảng kê hóa đơn phải trả |
| **Loại** | Bảng kê chi tiết |
| **Công cụ** | Crystal Reports |

### 4.2 Cột báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng/NCC |
| ten_kh | Tên khách hàng |
| ma_vt | Mã vật tư |
| ten_vt | Tên vật tư |
| ma_nhvt | Nhóm vật tư |
| ma_kho | Mã kho |
| ma_bp | Mã bộ phận |
| ma_hd | Mã hợp đồng |
| so_px | Số phiếu nhập |
| so_ct | Số chứng từ |
| ngay_ct | Ngày chứng từ |
| ma_lo | Mã lô |
| ma_phi | Mã phí |
| ma_spct | Mã SPCT |

## 5. Lọc dữ liệu

### 5.1 Các tiêu chí lọc

- **Khách hàng/NCC:** Lọc theo mã KH
- **Vật tư:** Lọc theo mã VT, nhóm VT
- **Kho:** Lọc theo mã kho
- **Bộ phận:** Lọc theo mã bộ phận
- **Hợp đồng:** Lọc theo mã hợp đồng
- **Phân loại:** Lọc theo 3 cấp phân loại KH
- **Số phiếu nhập:** Lọc theo số PX
- **Số chứng từ:** Lọc theo khoảng số CT
- **Lô, phí, SPCT:** Lọc theo mã lô, phí, SPCT

## 6. Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |
| System.Data | Data access |

## 7. Tables liên quan

| Table | Mô tả |
|-------|-------|
| MACT | Chứng từ mua hàng |
| MACTCT | Chi tiết chứng từ mua hàng |
| DMKH | Danh mục khách hàng/NCC |
| DMVT | Danh mục vật tư |
| DMNHVT | Danh mục nhóm VT |
| DMKHO | Danh mục kho |
| DMBP | Danh mục bộ phận |
| DMHD | Danh mục hợp đồng |
| DMPLKH | Danh mục phân loại KH |
| DMLO | Danh mục lô |
| DMPHI | Danh mục phí |
| DMSPCT | Danh mục SPCT |