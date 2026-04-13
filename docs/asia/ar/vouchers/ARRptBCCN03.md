# Phân tích DLL: ARRptBCCN03.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBCCN03.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBCCN03 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo công nợ tổng hợp theo phân loại |

## 2. Forms

### 2.1 frmARRptBCCN03 (Report Form)

**Mô tả:** Form báo cáo công nợ tổng hợp phân loại

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_plkh1 | AsTextBox | Phân loại KH 1 |
| txtMa_plkh2 | AsTextBox | Phân loại KH 2 |
| txtMa_plkh3 | AsTextBox | Phân loại KH 3 |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |

**Chức năng:**
- Báo cáo tổng hợp công nợ theo phân loại
- Không hiển thị chi tiết từng khách hàng
- Chỉ hiển thị tổng số theo nhóm phân loại

## 3. Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_plkh | Mã phân loại |
| ten_plkh | Tên phân loại |
| so_luong_kh | Số lượng khách hàng |
| tong_du_dk | Tổng số dư đầu kỳ |
| tong_ps_no | Tổng phát sinh nợ |
| tong_ps_co | Tổng phát sinh có |
| tong_du_ck | Tổng số dư cuối kỳ |

## 4. Business Logic

### Tổng hợp
- Nhóm tất cả khách hàng theo phân loại
- Tính tổng các chỉ tiêu công nợ
- Đếm số lượng khách hàng trong nhóm

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBCCN03 | Lấy dữ liệu báo cáo công nợ tổng hợp phân loại |

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Data`

## 7. Ghi chú

- Dạng báo cáo tổng hợp, không có chi tiết
- Phù hợp cho báo cáo quản trị cấp cao
- So sánh nhanh giữa các nhóm phân loại
