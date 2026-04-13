# GLMAUBCTCTMVIII - Mẫu báo cáo tài chính III

## Mô tả

Module quản lý mẫu báo cáo tài chính III trong hệ thống ERP Asia.

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính III
- Quản lý mã chỉ tiêu (ma_so) theo mẫu quyết định
- Quản lý tên chỉ tiêu và nội dung chi tiết
- Hỗ trợ công thức tính toán (cach_tinh)
- Liên kết với một tài khoản kế toán

### 2. Cấu hình loại phát sinh
- Hỗ trợ 6 loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Tích hợp dropdown chọn loại phát sinh

### 3. Tùy chọn in ấn
- Chọn có in hay không (IsPrint)
- Tùy chọn in nghiêng (IsItalic)
- Tùy chọn in đậm (bold)

### 4. Validation dữ liệu
- Kiểm tra mã chỉ tiêu không được rỗng
- Kiểm tra tên chỉ tiêu không được rỗng
- Tự động gán mẫu quyết định mặc định nếu chưa có

## Các trường dữ liệu chính

| Field | Mô tả |
|-------|-------|
| ma_so | Mã chỉ tiêu |
| chi_tieu | Chỉ tiêu |
| nd_chtieu | Nội dung chỉ tiêu |
| cach_tinh | Cách tính/công thức |
| tk_01 | Tài khoản |
| loai_ps | Loại phát sinh |
| mau | Mẫu quyết định |
| IsPrint | Có in không |
| IsItalic | In nghiêng |
| bold | In đậm |

## Loại phát sinh

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCO | Phát sinh có |

## Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kế thừa từ frmDMComplexView/frmDMComplexEdit của Framework
- Sử dụng AsTextBox với AutoLookup cho tài khoản
- ComboBox binding với ArrayList DictionaryEntry
- Kiểm tra validation dữ liệu đầu vào

## Tham khảo

- Thông tư kế toán Việt Nam
- Mẫu báo cáo tài chính III
