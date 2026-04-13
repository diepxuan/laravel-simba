# GLMAUBCTCTMI.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Danh mục - Financial Report Template
- **Chức năng**: Quản lý mẫu báo cáo tài chính - Bảng cân đối kế toán (Balance Sheet)

## Forms

### frmGLMAUBCTCTMI.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form xem danh sách mẫu báo cáo

### frmGLMAUBCTCTMIEdit.cs
- **Kế thừa**: frmDMComplexEdit
- **Chức năng**: Form thêm/sửa mẫu báo cáo

#### Controls
| Control | Type | Data Binding | Purpose |
|---------|------|--------------|---------|
| txtMauQD | AsTextBox | mau | Mẫu quyết định |
| txtMa_chtieu | AsTextBox | ma_so | Mã chỉ tiêu |
| txtChi_tieu | TextBox | chi_tieu | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | nd_chtieu | Nội dung chỉ tiêu |
| ChkIs_print | CheckBox | IsPrint | Có in |
| ChkIs_italic | CheckBox | IsItalic | In nghiêng |
| chkKsd | AsCheckBox | bold | In đậm |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitBeforeGetData | - | void | Set max length, focus |
| ValidData | - | bool | Validate dữ liệu |
| InsertToDB | - | bool | Thêm mới |
| DisableFields | - | void | Disable mã, mẫu QD khi edit |
| DataBinding | - | void | Bind controls |
| frmGLMAUBCTCTMIEdit_Load | sender, e | void | Set default IsPrint |
| ProcessKeyPreview | ref Message m | bool | Xử lý phím tắt |

## Business Logic

### Luồng xử lý chính
1. Mở form -> Hiển thị danh sách chỉ tiêu báo cáo
2. Thêm mới -> Nhập mã chỉ tiêu, tên chỉ tiêu, nội dung
3. Chọn thuộc tính hiển thị (in, in đậm, in nghiêng)
4. Lưu vào database

### Validation rules
- Mã chỉ tiêu bắt buộc
- Tên chỉ tiêu bắt buộc
- Mẫu QD mặc định lấy từ CompanyInformations.Qd_cdkt

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| glMauBCTCTMI | Mẫu báo cáo tài chính | C/R/U/D |

## Mapping sang PHP

### Controller
```php
class GLMauBCTCTMIController extends Controller {
    public function index() {
        $templates = $this->repository->getAll();
        return view('gl.mau_bctc_tmi.index', compact('templates'));
    }
    
    public function store(Request $request) {
        $validated = $request->validate([
            'ma_so' => 'required',
            'chi_tieu' => 'required',
        ]);
        
        $this->repository->create($request->all());
        return redirect()->route('gl.mau_bctc_tmi.index');
    }
}
```

### Model
```php
class GLMauBCTCTMI extends Model {
    protected $table = 'glMauBCTCTMI';
    protected $fillable = [
        'ma_cty', 'mau', 'ma_so', 'chi_tieu', 'nd_chtieu',
        'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chú
- Đây là mẫu báo cáo tài chính theo quyết định (Thông tư, QĐ)
- Các DLL khác (GLMAUBCTCTMIX, GLMAUBCTCTMV01-03, 08) có cấu trúc tương tự cho các mẫu báo cáo khác nhau
- Mỗi DLL tương ứng với một mẫu báo cáo tài chính cụ thể
