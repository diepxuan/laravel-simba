# CACalLaiKu.dll - Tính lãi khế ước

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
- `Execute()`: Thực thi tính lãi khế ước
- `ValidData()`: Kiểm tra dữ liệu hợp lệ (tháng 1-12)
- `InitComponents()`: Khởi tạo giá trị mặc định (tháng hiện tại)

**Business Logic:**
- Gọi stored procedure để tính lãi khế ước
- Input: CompanyID, Tháng, Năm tài chính, Mã khế ước
- Kiểm tra tháng hợp lệ (1-12)
- Hiển thị thông báo kết quả sau khi thực thi

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Tính lãi khế ước theo tháng |

## 4. Mapping PHP

Không áp dụng (đây là form tính toán, không phải voucher).

---

**Lưu ý:** Form này kế thừa từ `frmCalc` - form tính toán chung của framework.
