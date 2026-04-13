# CARptTMNH03.dll - Báo cáo tiền mặt/ngân hàng 03

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH03.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Forms** | frmCARptTMNH03 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo sổ chi tiết vay theo khế ước |

## 2. Forms chi tiết

### frmCARptTMNH03

**Controls:**
| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản vay (bắt buộc) |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản vay" |
| txtMa_ku | AsTextBox | Mã khế ước |
| lblTen_ku | Label | Tên khế ước (hiển thị) |
| lblMa_ku | Label | Nhãn "Mã khế ước" |

**Kế thừa từ frmReport:**
- txtNgay1, txtNgay2: Kỳ báo cáo
- cboKyBc: Chọn kỳ
- cboMau_bc: Chọn mẫu báo cáo
- txtMa_Nt: Mã ngoại tệ
- optVND, optNt: Chọn loại tiền
- txtTieu_De: Tiêu đề báo cáo

**Events:**
- `LoadData()`: Load dữ liệu báo cáo
  - Parameters: CompanyID, Ngày1, Ngày2, TK, Mã KU, Mã NT
- `GetFilterTitle()`: Lấy tiêu đề filter cho báo cáo

**Business Logic:**
- Bắt buộc nhập tài khoản vay
- Có thể lọc theo khế ước cụ thể
- Hiển thị chi tiết phát sinh vay theo từng khế ước

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy dữ liệu chi tiết vay theo KU |

## 4. Mapping PHP

Không áp dụng (đây là form