# GLMAUBCTCTMIX.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Danh mục - Financial Report Template
- **Chức năng**: Quản lý mẫu báo cáo tài chính - Bảng cân đối kế toán mở rộng (Extended Balance Sheet)

## Forms

### frmGLMAUBCTCTMIX.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form xem danh sách mẫu báo cáo

### frmGLMAUBCTCTMIXEdit.cs
- **Kế thừa**: frmDMComplexEdit
- **Chức năng**: Form thêm/sửa mẫu báo cáo

#### Controls
Tương tự GLMAUBCTCTMI:
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
| glMauBCTCTMIX | Mẫu báo cáo tài chính mở rộng | C/R/U/D |

## Mapping sang PHP

### Controller
```php
class GLMauBCTCTMIXController extends Controller {
    public function index() {
        $templates = $this->repository->getAll();
        return view('gl.mau_bctc_tmix.index', compact('templates'));
    }
}
```

### Model
```php
class GLMauBCTCTMIX extends Model {
    protected $table = 'glMauBCTCTMIX';
    protected $fillable = [
        'ma_cty', 'mau', 'ma_so', 'chi_tieu', 'nd_chtieu',
        'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chú
- Phiên bản mở rộng của Bảng cân đối kế toán
- Có thể có thêm các chỉ tiêu phân tích chi tiết hơn
