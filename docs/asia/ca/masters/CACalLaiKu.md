# Phân tích DLL: CACalLaiKu.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CACalLaiKu.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCACalLaiKu |
| **Kế thừa** | frmCalc |
| **Chức năng** | Tính lãi khế ước vay theo tháng/năm |

## 2. Forms chi tiết

### frmCACalLaiKu

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtThang | AsTextNumeric | Tháng tính lãi |
| txtMa_ku | AsTextBox | Mã khế ước |
| lblTen_TS | Label | Tên khế ước (hiển thị) |
| lblTk | Label | Nhãn "Mã khế ước" |

**Events:**

| Event | Mô tả |
|-------|-------|
| Execute | Thực thi tính lãi khế ước |
| ValidData | Kiểm tra dữ liệu hợp lệ (tháng 1-12) |
| InitComponents | Khởi tạo giá trị mặc định (tháng hiện tại) |

**Business Logic:**

- Gọi stored procedure để tính lãi khế ước
- Input: CompanyID, Tháng, Năm tài chính, Mã khế ước
- Kiểm tra tháng hợp lệ (1-12)
- Hiển thị thông báo kết quả sau khi thực thi

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CACALKU | Tính lãi khế ước theo tháng |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| Thang | int | Tháng tính lãi (1-12) |
| Nam | int | Năm tài chính |
| Ma_KU | varchar | Mã khế ước |

---

**Lưu ý:** 
- Form này kế thừa từ frmCalc - form tính toán chung của framework
- Không áp dụng mapping PHP (đây là form tính toán, không phải voucher)
