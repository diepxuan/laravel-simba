# GLMAUBCTCTMV01.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Danh mục - Financial Report Template
- **Chức năng**: Quản lý mẫu báo cáo tài chính - Báo cáo kết quả hoạt động kinh doanh (Income Statement)

## Forms

### frmGLMAUBCTCTMV01.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form xem danh sách mẫu báo cáo

### frmGLMAUBCTCTMV01Edit.cs
- **Kế thừa**: frmDMComplexEdit
- **Chức năng**: Form thêm/sửa mẫu báo cáo

#### Controls
- txtMauQD: Mẫu quyết định
- txtMa_chtieu: Mã chỉ tiêu
- txtChi_tieu: Tên chỉ tiêu
- txtNd_chtieu: Nội dung chỉ tiêu
- ChkIs_print: Có in
- ChkIs_italic: In nghiêng
- chkKsd: In đậm

## Business Logic

### Luồng xử lý chính
1. Mở form -> Hiển thị danh sách chỉ tiêu báo cáo
2. Thêm mới -> Nhập mã chỉ tiêu, tên chỉ tiêu, nội dung
3. Chọn thuộc tính hiển thị
4. Lưu vào database

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| glMauBCTCTMV01 | Mẫu báo cáo KQHĐKD | C/R/U/D |

## Mapping sang PHP

### Model
```php
class GLMauBCTCTMV01 extends Model {
    protected $table = 'glMauBCTCTMV01';
    protected $fillable = [
        'ma_cty', 'mau', 'ma_so', 'chi_tieu', 'nd_chtieu',
        'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chú
- Báo cáo Kết quả hoạt động kinh doanh (Income Statement)
- Theo Thông tư 200/QĐ 15
