# GLMAUBCTCTMVI25A - Mẫu báo cáo tài chính I25A

## Mô tả

Module quản lý mẫu báo cáo tài chính I25A trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý mẫu báo cáo tài chính I25A
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình cách tính cho từng chỉ tiêu
- Hỗ trợ đến 12 tài khoản kế toán (tk1-tk12) - nhiều nhất trong các mẫu

### 2. Tùy chỉnh hiển thị và phạm vi
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Cấu hình loại phát sinh (loai_ps)
- Cấu hình năm phát sinh (nam_ps)
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
| tk1-tk12 | Tài khoản 1-12 |
| loai_ps | Loại phát sinh |
| nam_ps | Năm phát sinh |
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

## Năm phát sinh

| Mã | Ý nghĩa |
|----|---------|
| Năm nay | Phát sinh năm hiện tại |
| Năm trước | Phát sinh năm trước |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Hỗ trợ nhiều tài khoản nhất (12 tài khoản)
- Có thêm trường năm phát sinh (nam_ps)

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính I25A
