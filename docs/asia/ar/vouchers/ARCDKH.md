# Phân tích DLL: ARCDKH.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARCDKH.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Form chính** | frmARCDKH, frmARCDKHEdit, frmARCDKHFilter |
| **Kế thừa** | frmReport |
| **Chức năng** | Công nợ khách hàng (Accounts Receivable Customer Debt) |

## 2. Forms

### 2.1 frmARCDKH (Report Form)

**Mô tả:** Form báo cáo công nợ khách hàng

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_Tk | AsTextBox | Mã tài khoản công nợ |
| txtNgay1/txtNgay2 | AsMaskedTextBox | Từ ngày/Đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| crvReportViewer | CrystalReportViewer | Xem báo cáo Crystal |

**Chức năng:**
- Xem danh sách công nợ theo khách hàng
- Lọc theo kỳ báo cáo, mã khách hàng, tài khoản
- Hỗ trợ xuất Excel và in báo cáo Crystal Report

### 2.2 frmARCDKHEdit

**Mô tả:** Form chỉnh sửa thông tin công nợ

### 2.3 frmARCDKHFilter

**Mô tả:** Form lọc dữ liệu công nợ

## 3. Business Logic

### Lọc dữ liệu
- Lọc theo khoảng thời gian (từ ngày - đến ngày)
- Lọc theo mã khách hàng
- Lọc theo tài khoản công nợ (tk_cn=1)
- Lọc theo loại tiền tệ (VND/Ngoại tệ)

### Báo cáo
- Sử dụng Crystal Report để hiển thị báo cáo
- Hỗ trợ xuất Excel
- Drill-down để xem chi tiết

## 4. Dependencies

- `AsiaErp.Framework` - Framework lõi
- `CrystalDecisions.Windows.Forms` - Crystal Report
- `Microsoft.VisualBasic`

## 5. Ghi chú

- Form kế thừa từ `frmReport` nên có đầy đủ chức năng báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các trường mã (khách hàng, tài khoản)
- Hỗ trợ đa tiền tệ (VND và ngoại tệ)
