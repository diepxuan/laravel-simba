# GLMAUBCTCTMVI212 - Mẫu báo cáo tài chính I212

## Mô tả

Module quản lý mẫu báo cáo tài chính I212 trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo tài chính I212
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình mẫu quyết định
- Không có trường tài khoản (đơn giản nhất)

### 2. Tùy chỉnh hiển thị
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Quản lý mẫu quyết định áp dụng

### 3. Tích hợp Framework
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- Sử dụng `AsTextBox` từ Framework
- Binding dữ liệu với DataTable qua BindingSource

## Các trường dữ liệu chính

| Field | Mô tả |
|-------|-------|
| ma_chtieu | Mã chỉ tiêu báo cáo |
| chi_tieu | Tên chỉ tiêu |
| nd_chtieu | Nội dung chỉ tiêu |
| mau_QD | Mẫu quyết định |
| is_print | Có in |
| is_italic | In nghiêng |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với BindingSource
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Cấu trúc đơn giản nhất (không có trường tài khoản hay cách tính)

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I212
