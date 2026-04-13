# CARptTMNH04.dll - Báo cáo tiền mặt/ngân hàng 04

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH04.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Forms** | frmCARptTMNH04 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo tổng hợp tiền mặt/ngân hàng theo nhân viên/nhóm KH |

## 2. Forms chi tiết

### frmCARptTMNH04

**Controls:**
| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản" |
| txtNV | AsTextBox | Nhân viên |
| lblTen_nv | Label | Tên nhân viên (hiển thị) |
| lblMa_nv | Label | Nhãn "Nhân viên" |
| txtNh_kh | AsTextBox | Nhóm khách hàng |
| lblTen_nh_kh | Label | Tên nhóm KH (hiển thị) |
| lblMa_Nh_kh | Label | Nhãn "Nhóm khách hàng" |

**Kế thừa từ frmReport:**
- txtNgay1, txtNgay2: Kỳ báo cáo
- cboKyBc: Chọn kỳ
- cboMau_bc: Chọn mẫu báo cáo
- txtMa_Nt: Mã ngoại tệ
- optVND, optNt: Chọn loại tiền
- txtTieu_De: Tiêu đề báo cáo

**Events:**
- `InitOtherComponents()`: Set giá trị mặc định cho txtTk từ par1
- `LoadData()`: Load dữ liệu báo cáo
  - Parameters: CompanyID, TK, Ngày1, Ngày2, NV, Nhóm KH, Mã NT
- `GetFilterTitle()`: Lấy tiêu đề filter cho báo cáo

**Business Logic:**
- Lọc theo tài khoản, nhân viên, nhóm khách hàng
- Hiển thị báo cáo tổng hợp theo các tiêu chí lọc
- Thích hợp cho việc theo dõi công nợ theo nhân viên phụ trách

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy dữ liệu báo cáo tổng hợp TM/NH |

## 4. Mapping PHP

Không áp dụng (đây là form báo cáo, không phải voucher).

---

**Lưu ý:** 
- Báo cáo tổng hợp theo nhân viên và nhóm khách hàng
- Hỗ trợ quản lý và đánh giá hiệu quả thu/chi theo nhân viên
