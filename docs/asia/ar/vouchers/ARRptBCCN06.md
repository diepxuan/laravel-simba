# Phân tích DLL: ARRptBCCN06.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBCCN06.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBCCN06 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo so sánh công nợ theo hạn kỳ (Aging Report) |

## 2. Forms

### 2.1 frmARRptBCCN06 (Report Form)

**Mô tả:** Form báo cáo so sánh công nợ theo hạn kỳ

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtNgay_Ss | AsMaskedTextBox | Ngày so sánh |
| txtHan_ky1 | AsTextNumeric | Hạn kỳ 1 (ngày) |
| txtHan_ky2 | AsTextNumeric | Hạn kỳ 2 (ngày) |
| txtHan_ky3 | AsTextNumeric | Hạn kỳ 3 (ngày) |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_NhKh | AsTextBox | Mã nhóm KH |
| txtMaTT | AsTextBox | Mã điều khoản TT |

**Chức năng:**
- Phân tích công nợ theo độ tuổi (aging)
- So sánh giữa các kỳ
- Đánh giá chất lượng công nợ

## 3. Cấu trúc báo cáo

### Phân kỳ công nợ
| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| chua_den_han | Công nợ chưa đến hạn |
| han_ky_1 | Công nợ hạn kỳ 1 |
| han_ky_2 | Công nợ hạn kỳ 2 |
| han_ky_3 | Công nợ hạn kỳ 3 |
| qua_han | Công nợ quá hạn |
| tong_cong | Tổng cộng |

## 4. Business Logic

### Tính hạn kỳ
- Hạn kỳ 1: Số ngày từ 1 đến han_ky1
- Hạn kỳ 2: Số ngày từ han_ky1+1 đến han_ky2
- Hạn kỳ 3: Số ngày từ han_ky2+1 đến han_ky3
- Quá hạn: Trên han_ky3

### Cấu hình mặc định
```csharp
txtHan_ky1.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss1;
txtHan_ky2.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss2;
txtHan_ky3.Value = AsiaErp.Framework.Environment.GetSOConfiguration().han_tt_ss3;
```

## 5. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBCCN06 | Lấy dữ liệu báo cáo so sánh công nợ theo hạn kỳ |

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `Microsoft.VisualBasic`

## 7. Ghi chú

- Báo cáo quan trọng cho việc quản lý công nợ phải thu
- Giúp đánh giá khả năng thu hồi công nợ
- Thường dùng để lập dự phòng nợ phải thu khó đòi
