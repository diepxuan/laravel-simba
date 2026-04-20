# Nhóm asFilt* (Filter) - Procedures lọc dữ liệu

Nhóm stored procedures bắt đầu bằng `asFilt` (hoặc chứa `Filt`) thực hiện lọc dữ liệu từ các bảng theo điều kiện động, thường trả về danh sách header và detail cho các module khác nhau.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asAPFilt1 | AsAPFilt1 | `@pKeyPh` (string): điều kiện lọc bảng APPH1 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng APCT1 (detail) | Lọc danh sách chứng từ công nợ phải trả (AP) - trả về hai resultset: header và detail. |
| asAPFilt3 | AsAPFilt3 | `@pKeyPh` (string): điều kiện lọc bảng APPH3 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng APCT3 (detail) | Lọc danh sách chứng từ công nợ phải trả loại 3 (AP) - trả về hai resultset: header và detail. |
| asAPFilt4 | AsAPFilt4 | `@pKeyPh` (string): điều kiện lọc bảng APPH4 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng APCT4 (detail) | Lọc danh sách chứng từ công nợ phải trả loại 4 (AP) - trả về hai resultset: header và detail. |
| asARFilt1 | AsARFilt1 | `@pKeyPh` (string): điều kiện lọc bảng ARPH1 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng ARCT1 (detail) | Lọc danh sách chứng từ công nợ phải thu (AR) - trả về hai resultset: header và detail. |
| asARFilt3 | AsARFilt3 | `@pKeyPh` (string): điều kiện lọc bảng ARPH3 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng ARCT3 (detail) | Lọc danh sách chứng từ công nợ phải thu loại 3 (AR) - trả về hai resultset: header và detail. |
| asARFilt4 | AsARFilt4 | `@pKeyPh` (string): điều kiện lọc bảng ARPH4 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng ARCT4 (detail) | Lọc danh sách chứng từ công nợ phải thu loại 4 (AR) - trả về hai resultset: header và detail. |
| asCAFilt1 | AsCAFilt1 | `@pKeyPh` (string, mặc định '1=1'): điều kiện lọc bảng CaPh1 (header)<br>`@pKeyCt` (string, mặc định '1=1'): điều kiện lọc bảng CaCt1 (detail) | Lọc danh sách chứng từ kế toán chi phí loại 1 (CA) - trả về hai resultset: header và detail. |
| asCAFilt2 | AsCAFilt2 | `@pKeyPh` (string): điều kiện lọc bảng CaPh2 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng CaCt2 (detail) | Lọc danh sách chứng từ kế toán chi phí loại 2 (CA) - trả về hai resultset: header và detail. |
| asCAFilt3 | AsCAFilt3 | `@pKeyPh` (string): điều kiện lọc bảng CaPh3 (header)<br>`@pKeyCt` (string): điều kiện lọc bảng CaCt3 (detail) | Lọc danh sách chứng từ kế toán chi phí loại 3 (CA) - trả về hai resultset: header và detail. |

## Chi tiết từng procedure

### asAPFilt1
- **Module**: Accounts Payable (AP)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải trả (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APPH1 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APCT1 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (APPH1).
  2. Detail: chứa các dòng chi tiết (APCT1).
- **Class**: `AsAPFilt1`
- **Ví dụ**:
```php
$result = AsAPFilt1::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asAPFilt3
- **Module**: Accounts Payable (AP)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải trả loại 3 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APPH3 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APCT3 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (APPH3).
  2. Detail: chứa các dòng chi tiết (APCT3).
- **Class**: `AsAPFilt3`
- **Ví dụ**:
```php
$result = AsAPFilt3::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asAPFilt4
- **Module**: Accounts Payable (AP)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải trả loại 4 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APPH4 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng APCT4 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (APPH4).
  2. Detail: chứa các dòng chi tiết (APCT4).
- **Class**: `AsAPFilt4`
- **Ví dụ**:
```php
$result = AsAPFilt4::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asARFilt1
- **Module**: Accounts Receivable (AR)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải thu (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARPH1 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARCT1 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (ARPH1).
  2. Detail: chứa các dòng chi tiết (ARCT1).
- **Class**: `AsARFilt1`
- **Ví dụ**:
```php
$result = AsARFilt1::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asARFilt3
- **Module**: Accounts Receivable (AR)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải thu loại 3 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARPH3 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARCT3 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (ARPH3).
  2. Detail: chứa các dòng chi tiết (ARCT3).
- **Class**: `AsARFilt3`
- **Ví dụ**:
```php
$result = AsARFilt3::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asARFilt4
- **Module**: Accounts Receivable (AR)
- **Mục đích**: Lọc danh sách chứng từ công nợ phải thu loại 4 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARPH4 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng ARCT4 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (ARPH4).
  2. Detail: chứa các dòng chi tiết (ARCT4).
- **Class**: `AsARFilt4`
- **Ví dụ**:
```php
$result = AsARFilt4::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asCAFilt1
- **Module**: Cost Accounting (CA)
- **Mục đích**: Lọc danh sách chứng từ kế toán chi phí loại 1 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaPh1 (header), không bao gồm từ khóa WHERE. Giá trị mặc định: '1=1'.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaCt1 (detail), không bao gồm từ khóa WHERE. Giá trị mặc định: '1=1'.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (CaPh1).
  2. Detail: chứa các dòng chi tiết (CaCt1).
- **Class**: `AsCAFilt1`
- **Ví dụ**:
```php
$result = AsCAFilt1::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asCAFilt2
- **Module**: Cost Accounting (CA)
- **Mục đích**: Lọc danh sách chứng từ kế toán chi phí loại 2 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaPh2 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaCt2 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (CaPh2).
  2. Detail: chứa các dòng chi tiết (CaCt2).
- **Class**: `AsCAFilt2`
- **Ví dụ**:
```php
$result = AsCAFilt2::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

### asCAFilt3
- **Module**: Cost Accounting (CA)
- **Mục đích**: Lọc danh sách chứng từ kế toán chi phí loại 3 (header và detail) theo điều kiện động.
- **Tham số**:
  - `@pKeyPh` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaPh3 (header), không bao gồm từ khóa WHERE.
  - `@pKeyCt` (NVARCHAR(1000)): Chuỗi điều kiện WHERE cho bảng CaCt3 (detail), không bao gồm từ khóa WHERE.
- **Kết quả**: Hai resultset:
  1. Header: chứa các thông tin chung của chứng từ (CaPh3).
  2. Detail: chứa các dòng chi tiết (CaCt3).
- **Class**: `AsCAFilt3`
- **Ví dụ**:
```php
$result = AsCAFilt3::call([
    'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
    'pKeyCt' => "ma_lo = 'LO01'",
]);
```

## Tổng số procedures đã chuyển đổi: 9

## Cấu trúc chung

Các procedures trong nhóm này thường:
- Có từ 1 đến 3 tham số kiểu chuỗi (NVARCHAR) đại diện cho điều kiện lọc.
- Xây dựng câu lệnh SQL động bằng cách nối chuỗi.
- Sử dụng `sp_executesql` để thực thi.
- Trả về một hoặc nhiều resultset.

## Lưu ý khi sử dụng
- Tham số truyền vào là chuỗi SQL điều kiện, cần đảm bảo an toàn trước SQL injection (nên validate đầu vào).
- Một số procedure có thể trả về nhiều resultset, cần xử lý đúng thứ tự.
- Cần kiểm tra kết nối database và quyền thực thi stored procedure.