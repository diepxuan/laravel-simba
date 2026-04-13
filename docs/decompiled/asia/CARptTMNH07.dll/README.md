# CARptTMNH07.dll - Báo cáo tiền mặt/ngân hàng 07

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH07.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCARptTMNH07 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo tổng hợp vay nợ theo tài khoản và khế ước |

## 2. Forms chi tiết

### frmCARptTMNH07

**Controls:**
| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản (bắt buộc) |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản" |
| txtMa_ku | AsTextBox | Mã khế ước |
| lblTen_ku | Label | Tên khế ước (hiển thị) |
| Label2 | Label | Nhãn "Mã khế ước" |

**Kế thừa từ frmReport:**
- txtNgay1, txtNgay2: Kỳ báo cáo
- cboKyBc: Chọn kỳ
- cboMau_bc: Chọn mẫu báo cáo
- txtMa_Nt: Mã ngoại tệ
- optVND, optNt: Chọn loại tiền
- txtTieu_De: Tiêu đề báo cáo

**Events:**
- `ValidData()`: Kiểm tra bắt buộc nhập tài khoản
- `LoadData()`: Load dữ liệu báo cáo
  - Parameters: CompanyID, TK, Mã KU, Ngày1, Ngày2, Mã NT
- `GetFilterTitle()`: Lấy tiêu đề filter cho báo cáo

**Business Logic:**
- Bắt buộc nhập tài khoản
- Có thể lọc theo khế ước
- Hiển thị báo cáo tổng hợp vay nợ

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy dữ liệu tổng hợp vay nợ |

## 4. Mapping PHP

Không áp dụng (đây là form báo cáo, không phải voucher).

---

**Lưu ý:** 
- Báo cáo tổng hợp vay nợ
- Có thể xem theo tài khoản tổng hợp hoặc chi tiết theo khế ước
