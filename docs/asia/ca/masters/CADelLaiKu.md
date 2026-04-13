# Phân tích DLL: CADelLaiKu.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CADelLaiKu.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCADelLaiKu |
| **Kế thừa** | frmCalc |
| **Chức năng** | Xóa lãi khế ước đã tính |

## 2. Forms chi tiết

### frmCADelLaiKu

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtThang | AsTextNumeric | Tháng cần xóa lãi |
| txtMa_ku | AsTextBox | Mã khế ước (có thể để trống để xóa tất cả) |
| lblTen_TS | Label | Tên khế ước (hiển thị) |
| lblTk | Label | Nhãn "Mã khế ước" |
| Label1 | Label | Nhãn "Tháng" |

**Events:**

| Event | Mô tả |
|-------|-------|
| Execute | Thực thi xóa lãi khế ước |
| ValidData | Kiểm tra tháng hợp lệ (1-12) |
| InitComponents | Khởi tạo giá trị mặc định (tháng hiện tại) |

**Business Logic:**

- Gọi stored procedure để xóa lãi khế ước
- Parameters: CompanyID, Tháng, Năm tài chính, Mã KU
- Nếu Mã KU để trống: xóa lãi của tất cả các KU trong tháng
- Nếu có Mã KU: chỉ xóa lãi của KU đó
- Kiểm tra tháng hợp lệ (1-12)
- Hiển thị thông báo kết quả sau khi thực thi

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CADELLAIKU | Xóa lãi khế ước |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| Thang | int | Tháng xóa lãi (1-12) |
| Nam | int | Năm tài chính |
| Ma_KU | varchar | Mã khế ước (có thể null để xóa tất cả) |

---

**Lưu ý:** 
- Form này kế thừa từ frmCalc - form tính toán chung của framework
- Thường dùng khi cần tính lại lãi sau khi đã tính lãi trước đó
- Cẩn thận khi xóa vì sẽ mất dữ liệu lãi đã tính
- Không áp dụng mapping PHP (đây là form tính toán, không phải voucher)
