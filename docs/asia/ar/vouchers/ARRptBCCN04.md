# Phân tích DLL: ARRptBCCN04.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBCCN04.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBCCN04 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo công nợ theo nhóm và chi tiết |

## 2. Forms

### 2.1 frmARRptBCCN04 (Report Form)

**Mô tả:** Form báo cáo công nợ nhóm và chi tiết

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_NhKh | AsTextBox | Mã nhóm khách hàng |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |

**Chức năng:**
- Hiển thị tổng hợp theo nhóm khách hàng
- Chi tiết từng khách hàng trong nhóm
- Drill-down từ nhóm xuống chi tiết

## 3. Cấu trúc báo cáo

### Tổng hợp nhóm
| Cột | Mô tả |
|-----|-------|
| ma_nhkh | Mã nhóm KH |
| ten_nhkh | Tên nhóm |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

### Chi tiết khách hàng
| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

## 4. Business Logic

### Cấu trúc báo cáo
1. Hiển thị tổng hợp theo nhóm
2. Dưới mỗi nhóm liệt kê chi tiết khách hàng
3. Có dòng tổng cộng cho mỗi nhóm
4. Dòng tổng cộng chung ở cuối báo cáo

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBCCN04 | Lấy dữ liệu báo cáo công nợ nhóm và chi tiết |

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `CrystalDecisions.Windows.Forms`

## 7. Ghi chú

- Kết hợp ưu điểm của báo cáo tổng hợp và chi tiết
- Phù hợp cho việc quản lý công nợ theo nhóm
- Dễ dàng theo dõi công nợ từng khách trong nhóm
