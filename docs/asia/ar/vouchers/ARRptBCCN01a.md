# Phân tích DLL: ARRptBCCN01a.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRptBCCN01a.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARRptBCCN01a |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo công nợ Excel nâng cao |

## 2. Forms

### 2.1 frmARRptBCCN01a (Report Form)

**Mô tả:** Form báo cáo công nợ Excel nâng cao

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Tk | AsTextBox | Mã tài khoản |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| cboMau_bc | ComboBox | Mẫu báo cáo Excel |
| cmdExcel | Button | Xuất Excel |

**Chức năng:**
- Báo cáo công nợ định dạng Excel
- Nhiều mẫu báo cáo tùy chọn
- Tùy chỉnh cột hiển thị
- Định dạng theo yêu cầu

## 3. Tính năng Excel

### Định dạng
- Header tùy chỉnh
- Màu sắc, font chữ theo mẫu
- Căn chỉnh, độ rộng cột tự động
- Công thức tính toán trong Excel

### Dữ liệu
- Số dư đầu kỳ
- Chi tiết phát sinh
- Số dư cuối kỳ
- Thông tin khách hàng đầy đủ

## 4. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARRptBCCN01a_Crys | Lấy dữ liệu Excel nâng cao |

## 5. Dependencies

- `AsiaErp.Framework`
- `Microsoft.Office.Interop.Excel` (hoặc tương tự)
- `System.Data`

## 6. Ghi chú

- Yêu cầu cài đặt Office để xuất Excel
- Phù hợp cho báo cáo quản trị cần định dạng đẹp
