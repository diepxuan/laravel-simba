# ARRptBK01.dll - Bảng kê chứng từ bán hàng

## Tổng quan

DLL bảng kê chứng từ bán hàng (Sales Documents Listing). Liệt kê các chứng từ bán hàng, hóa đơn phải thu theo nhiều tiêu chí lọc.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |
| Title | `Bảng kê hóa đơn phải thu` |

## Forms chính

### frmARRptBK01
- **Kế thừa**: `frmReport`
- **Mô tả**: Form bảng kê chứng từ bán hàng
- **Chức năng**:
  - Liệt kê tất cả hóa đơn bán hàng
  - Lọc theo nhiều tiêu chí (khách hàng, vật tư, kho...)
  - Tổng hợp doanh thu theo các tiêu chí

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtMa_vt | `AsTextBox` | Mã vật tư |
| txtMa_nhvt | `AsTextBox` | Nhóm vật tư |
| txtMa_kho | `AsTextBox` | Mã kho |
| txtMa_lo | `AsTextBox` | Mã lô |
| txtMa_Bp | `AsTextBox` | Mã bộ phận |
| txtMa_Hd | `AsTextBox` | Mã hợp đồng |
| txtMa_Nvkd | `AsTextBox` | Mã NVKD |
| txtMa_plkh1/2/3 | `AsTextBox` | Phân loại KH |
| txtSo_Ct1/txtSo_Ct2 | `TextBox` | Số chứng từ từ/đến |
| txtMa_phi | `AsTextBox` | Mã phí |
| txtMa_spct | `AsTextBox` | Mã SPCT |

## Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ngay_ct | Ngày chứng từ |
| so_ct | Số chứng từ |
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| ma_vt | Mã vật tư |
| ten_vt | Tên vật tư |
| so_luong | Số lượng |
| gia | Đơn giá |
| thanh_tien | Thành tiền |

## Business Logic

### Lọc dữ liệu
- Lọc theo khoảng thời gian
- Lọc theo khách hàng, nhóm khách hàng
- Lọc theo vật tư, nhóm vật tư
- Lọc theo kho, lô
- Lọc theo bộ phận, hợp đồng
- Lọc theo nhân viên kinh doanh

### Tổng hợp
- Tổng số lượng bán
- Tổng doanh thu
- Chi tiết theo từng mặt hàng

## Dependencies

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System.Data`

## Ghi chú

- Báo cáo chi tiết bán hàng
- Nhiều tiêu chí lọc linh hoạt
- Phù hợp cho việc phân tích doanh thu
