# GLMAUBCTCTMVI15c - Mẫu báo cáo tài chính I15c

## Mô tả

Module quản lý mẫu báo cáo tài chính I15c trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo tài chính I15c
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình cách tính cho từng chỉ tiêu
- Hỗ trợ 1 tài khoản kế toán

### 2. Tùy chỉnh hiển thị
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Cấu hình loại phát sinh (loai_ps)
- Quản lý mẫu quyết định áp dụng

### 3. Tích hợp Framework
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- Sử dụng `AsTextBox`, `AsComboBox` từ Framework
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
| loai_ps | Loại phát sinh |
| is_print | Có in |
| is_italic | In nghiêng |

## Loại phát sinh

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCo | Phát sinh có |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I15c
