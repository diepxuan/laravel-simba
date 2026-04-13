# GLMAUBCTCTMV08.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Danh mục - Financial Report Template
- **Chức năng**: Quản lý mẫu báo cáo tài chính - Báo cáo tình hình tài chính (Financial Position Report)

## Forms

### frmGLMAUBCTCTMV08.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form xem danh sách mẫu báo cáo

### frmGLMAUBCTCTMV08Edit.cs
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

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| glMauBCTCTMV08 | Mẫu báo cáo tình hình tài chính | C/R/U/D |

## Mapping sang PHP

### Model
```php
class GLMauBCTCTMV08 extends Model {
    protected $table = 'glMauBCTCTMV08';
    protected $fillable = [
        'ma_cty', 'mau', 'ma_so', 'chi_tieu', 'nd_chtieu',
        'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chú
- Báo cáo Tình hình tài chính
- Theo Thông tư 200/QĐ 15
- Các DLL mẫu báo cáo (GLMAUBCTCTMV*) có cấu trúc tương tự nhau
- Chỉ khác nhau về bảng dữ liệu và mục đích báo cáo
