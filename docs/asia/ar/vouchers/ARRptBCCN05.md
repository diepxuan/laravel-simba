# Phân tích DLL: ARRptBCCN05.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBCCN05.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBCCN05 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo đối chiếu công nợ |

## 2. Forms

### 2.1 frmARRptBCCN05 (Report Form)

**Mô tả:** Form báo cáo đối chiếu công nợ

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Tk | AsTextBox | Mã tài khoản |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| txtNgay_lp | AsMaskedTextBox | Ngày lập đối chiếu |

**Chức năng:**
- In giấy đối chiếu công nợ gửi khách hàng
- Hiển thị chi tiết phát sinh
- Có thông tin xác nhận của khách hàng

## 3. Cấu trúc báo cáo đối chiếu

### Thông tin chung
- Tên công ty
- Địa chỉ, điện thoại
- Tên khách hàng
- Địa chỉ khách hàng
- Ngày lập đối chiếu

### Chi tiết công nợ
| Cột | Mô tả |
|-----|-------|
| ngay_ct | Ngày chứng từ |
| so_ct | Số chứng từ |
| dien_giai | Diễn giải |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_cuoi | Số dư cuối |

### Phần xác nhận
- Chữ ký xác nhận của khách hàng
- Ngày xác nhận
- Ý kiến của khách hàng (nếu có)

## 4. Business Logic

### Đối chiếu
1. Lấy số dư đầu kỳ
2. Liệt kê tất cả chứng từ phát sinh
3. Tính số dư cuối kỳ
4. In giấy đối chiếu gửi khách hàng

### Xử lý chênh lệch
- Nếu khách hàng không xác nhận, cần kiểm tra lại
- So sánh với sổ sách của khách hàng
- Tìm nguyên nhân chênh lệch (nếu có)

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBCCN05 | Lấy dữ liệu báo cáo đối chiếu công nợ |

## 6. Dependencies

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`

## 7. Ghi chú

- Báo cáo quan trọng cho việc đối chiếu công nợ định kỳ
- Thường được gửi hàng tháng/quý cho khách hàng
- Cần lưu trữ giấy xác nhận của khách hàng
