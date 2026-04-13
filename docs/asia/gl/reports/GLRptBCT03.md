# GLRptBCT03

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo thuế GTGT - Tờ khai 01/GTGT

## Forms

### frmGLRptBCT03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form tờ khai thuế GTGT 01/GTGT

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| dgvBC | AsDataGridView | DataSource | CellEnter, CellEndEdit |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu tờ khai |
| FormatGridView | - | void | Format DataGridView |
| dgvBC_CellEnter | sender, e | void | Xử lý khi enter cell |
| dgvBC_CellEndEdit | sender, e | void | Xử lý khi kết thúc edit |
| MyCalc | oDr | void | Tính toán công thức |
| ValidCongThuc | strCong_thuc, strChitieu, dSum | bool | Validate công thức |

## Data Access

### GLRptBCT03DAO.cs
- **Interface**: IGLRptBCT03DAO
- **Implementation**: MsSqlGLRptBCT03DAO

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| DieuChinhBCT03 | asGLRptBCT03_dieuchinh | @pMa_cty, @pThang1, @pThang2, @pNam, @pStt_rec, @pDoanh_so, @pThue | @pRet (int) | Điều chỉnh dữ liệu BCT03 |

### MsSqlGLRptBCT03DAO.cs
```csharp
public int DieuChinhBCT03(params object[] para) {
    _command.CommandText = "asGLRptBCT03_dieuchinh";
    _command.CommandType = CommandType.StoredProcedure;
    _command.Parameters.AddWithValue("@pMa_cty", para[0]);
    _command.Parameters.AddWithValue("@pThang1", para[1]);
    _command.Parameters.AddWithValue("@pThang2", para[2]);
    _command.Parameters.AddWithValue("@pNam", para[3]);
    _command.Parameters.AddWithValue("@pStt_rec", para[4]);
    _command.Parameters.AddWithValue("@pDoanh_so", para[5]);
    _command.Parameters.AddWithValue("@pThue", para[6]);
    // Output param @pRet
}
```

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asGLRptBCT03_dieuchinh | Điều chỉnh dữ liệu BCT03 | @pMa_cty, @pThang1, @pThang2, @pNam, @pStt_rec, @pDoanh_so, @pThue | @pRet |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. Load dữ liệu tờ khai từ database
3. Hiển thị dữ liệu trên grid với các chỉ tiêu thuế
4. User có thể điều chỉnh các chỉ tiêu có thể edit
5. Tự động tính toán công thức khi edit

### Tính toán công thức
- Các chỉ tiêu có công thức tính toán được định nghĩa trong `cong_thuc`
- Công thức có thể chứa: +, -, *, /, >, <
- Ví dụ: `[01]+[02]-[03]`
- Khi edit một chỉ tiêu, hệ thống tự động tính lại các chỉ tiêu liên quan

### Validation công thức
- Kiểm tra mã chỉ tiêu trong công thức có tồn tại không
- Validate các phép toán: +, -, *, /, >, <
- Tính tổng các chỉ tiêu theo công thức

### Edit cell
- Chỉ cho phép edit các cell có `usertype = true` và cột `thue`
- Sau khi edit, gọi SP `asGLRptBCT03_dieuchinh` để lưu điều chỉnh

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bct03 | Dữ liệu tờ khai BCT03 | R/U |
| GL_bct03ct | Chi tiết tờ khai | R/U |
| Ct | Chứng từ | R |

## Mapping sang PHP

### Controller
```php
class GLRptBCT03Controller extends ReportController {
    public function index() {
        return view('reports.bct03');
    }
    
    public function getData(Request $request) {
        $data = $this->service->getBCT03Data($request->all());
        return response()->json($data);
    }
    
    public function adjust(Request $request) {
        $result = $this->service->adjustBCT03($request->all());
        return response()->json(['success' => $result]);
    }
}
```

### Repository
```php
class GLRptBCT03Repository {
    public function getData($params) {
        return DB::select('EXEC sp_GetBCT03 ?, ?, ?', [
            $params['company_id'],
            $params['date_from'],
            $params['date_to']
        ]);
    }
    
    public function adjust($params) {
        return DB::select('EXEC asGLRptBCT03_dieuchinh ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['month_from'],
            $params['month_to'],
            $params['year'],
            $params['stt_rec'],
            $params['doanh_so'],
            $params['thue']
        ]);
    }
}
```

### Model
```php
class BCT03Item extends Model {
    protected $table = 'GL_bct03';
    protected $fillable = ['ma_so', 'chi_tieu', 'thue', 'doanh_so', 'cong_thuc'];
}
```

## Ghi chú
- Tờ khai thuế GTGT 01/GTGT theo quy định của Tổng cục Thuế
- Có thể điều chỉnh số liệu trực tiếp trên grid
- Tự động tính toán công thức theo các chỉ tiêu liên quan
- Lưu lịch sử điều chỉnh vào database
