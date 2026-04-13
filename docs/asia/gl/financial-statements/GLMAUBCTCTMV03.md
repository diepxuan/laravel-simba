# GLMAUBCTCTMV03.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Danh mục - Financial Report Template
- **Chức năng**: Quản lý mẫu báo cáo tài chính - Báo cáo thuyết minh báo cáo tài chính (Notes to Financial Statements)

## Forms

### frmGLMAUBCTCTMV03.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form xem danh sách mẫu báo cáo

### frmGLMAUBCTCTMV03Edit.cs
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
| glMauBCTCTMV03 | Mẫu báo cáo thuyết minh | C/R/U/D |

## Mapping sang PHP

### Model
```php
class GLMauBCTCTMV03 extends Model {
    protected $table = 'glMauBCTCTMV03';
    protected $fillable = [
        'ma_cty', 'mau', 'ma_so', 'chi_tieu', 'nd_chtieu',
        'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chú
- Báo cáo Thuyết minh báo cáo tài chính (Notes to Financial Statements)
- Theo Thông tư 200/QĐ 15
- Chứa các ghi chú giải thích chi tiết cho các chỉ tiêu trong BCTC
