# CADelLaiKu.dll - Xóa lãi khế ước

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
- `Execute()`: Thực thi xóa lãi khế ước
  - Parameters: CompanyID, Tháng, Năm tài chính, Mã KU
  - Nếu Mã KU để trống: xóa lãi của tất cả các KU trong tháng
  - Nếu có Mã KU: chỉ xóa lãi của KU đó
- `ValidData()`: Kiểm tra tháng hợp lệ (1-12)
- `InitComponents()`: Khởi tạo giá trị mặc định (tháng hiện tại)

**Business Logic:**
- Gọi stored procedure để xóa lãi khế ước
- Kiểm tra tháng hợp lệ (1-12)
- Có thể xóa lãi của một KU cụ thể hoặc tất cả các KU
- Hiển thị thông báo kết quả sau khi thực thi

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Xóa lãi khế ước |

## 4. Mapping PHP

Không áp dụng (đây là form tính toán, không phải voucher).

---

**Lưu ý:** 
- Form này kế thừa từ `frmCalc` - form tính toán chung của framework
- Thường dùng khi cần tính lại lãi sau khi đã tính lãi trước đó
- Cẩn thận khi xóa vì sẽ mất dữ liệu lãi đã tính
