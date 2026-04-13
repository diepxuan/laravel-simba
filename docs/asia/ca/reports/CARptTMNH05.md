# Phân tích DLL: CARptTMNH05.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH05.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCARptTMNH05 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo tình hình vay nợ theo khế ước |

## 2. Forms chi tiết

### frmCARptTMNH05

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_ku | AsTextBox | Mã khế ước (bắt buộc) |
| lblTen_ku | Label | Tên khế ước (hiển thị) |
| lblMa_ku | Label | Nhãn "Khế ước" |

**Kế thừa từ frmReport:**

| Control | Mô tả |
|---------|-------|
| txtNgay1, txtNgay2 | Kỳ báo cáo |
| cboKyBc | Chọn kỳ |
| cboMau_bc | Chọn mẫu báo cáo |
| txtMa_Nt | Mã ngoại tệ (auto fill từ KU) |
| optVND, optNt | Chọn loại tiền |
| txtTieu_De | Tiêu đề báo cáo |

**Events:**

| Event | Mô tả |
|-------|-------|
| txtMa_ku_AfterCodeValidating | Load tên KU và mã NT từ danh mục KU |
| ValidData | Kiểm tra bắt buộc nhập mã KU và mã NT |
| LoadData | Load dữ liệu báo cáo |
| GetFilterTitle | Lấy tiêu đề filter cho báo cáo |

**Business Logic:**

- Bắt buộc nhập mã khế ước
- Tự động load mã ngoại tệ từ danh mục khế ước
- Hiển thị tình hình vay nợ chi tiết của một khế ước cụ thể

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH05 | Lấy dữ liệu tình hình vay nợ theo KU |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| Ngay1 | date | Ngày bắt đầu |
| Ngay2 | date | Ngày kết thúc |
| Ma_KU | varchar | Mã khế ước |
| Ma_NT | varchar | Mã ngoại tệ |

---

**Lưu ý:** 
- Báo cáo chi tiết tình hình vay nợ của một khế ước
- Theo dõi lịch sử vay, trả gốc, trả lãi
