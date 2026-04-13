# GLMAUBCTCTMVI211 - Mẫu báo cáo tài chính I211

## Mô tả

Module quản lý mẫu báo cáo tài chính I211 trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo tài chính I211
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình công thức tính cho từng chỉ tiêu (khác với cách tính)
- Hỗ trợ 1 tài khoản kế toán

### 2. Tùy chỉnh hiển thị
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Quản lý mẫu quyết định áp dụng

### 3. Tích hợp Framework
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- Sử dụng `AsTextBox` từ Framework
- Binding dữ liệu với DataTable

## Các trường dữ liệu chính

| Field | Mô tả |
|-------|-------|
| ma_chtieu | Mã chỉ tiêu báo cáo |
| chi_tieu | Tên chỉ tiêu |
| nd_chtieu | Nội dung chỉ tiêu |
| cong_thuc | Công thức tính (thay vì cách tính) |
| mau_QD | Mẫu quyết định |
| taikhoan | Tài khoản |
| is_print | Có in |
| is_italic | In nghiêng |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Sử dụng trường `cong_thuc` thay vì `cach_tinh`

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I211
