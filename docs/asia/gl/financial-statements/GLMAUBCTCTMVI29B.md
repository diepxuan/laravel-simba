# GLMAUBCTCTMVI29B - Mẫu báo cáo tài chính I29B

## Mô tả

Module quản lý mẫu báo cáo tài chính I29B trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo I29B
- Xem danh sách các chỉ tiêu báo cáo
- Thêm mới chỉ tiêu
- Chỉnh sửa chỉ tiêu hiện có
- Xóa chỉ tiêu

### 2. Định nghĩa chỉ tiêu
- Mã chỉ tiêu (ma_so)
- Tên chỉ tiêu (chi_tieu)
- Nội dung chi tiết (nd_chtieu)
- Mẫu quyết định áp dụng (mau)

### 3. Tùy chọn định dạng
- Có in hay không (IsPrint)
- In nghiêng (IsItalic)
- In đậm (bold)

### 4. Validation
- Kiểm tra mã chỉ tiêu không được rỗng
- Kiểm tra tên chỉ tiêu không được rỗng
- Tự động gán mẫu quyết định mặc định nếu chưa có

## Các trường dữ liệu chính

| Field | Mô tả |
|-------|-------|
| ma_so | Mã số chỉ tiêu |
| chi_tieu | Tên chỉ tiêu |
| nd_chtieu | Nội dung chỉ tiêu |
| mau | Mẫu quyết định |
| IsPrint | Có in hay không |
| IsItalic | In nghiêng |
| bold | In đậm |
| Qd_cdkt | Quyết định chế độ kế toán |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit` - form danh mục chuẩn
- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với cấu hình công ty (CompanyInformations.Qd_cdkt)

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I29B
