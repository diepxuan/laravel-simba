# GLMAUBCTCTMVI12 - Mẫu báo cáo tài chính I12

## Mô tả

Module quản lý mẫu báo cáo tài chính I12 trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo tài chính I12
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình cách tính cho từng chỉ tiêu
- Hỗ trợ 1 tài khoản kế toán (đơn giản hơn I10/I11)

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
| cach_tinh | Cách tính chỉ tiêu |
| mau_QD | Mẫu quyết định |
| taikhoan | Tài khoản |
| is_print | Có in |
| is_italic | In nghiêng |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Cấu trúc đơn giản hơn I10/I11 (chỉ 1 tài khoản)

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I12
