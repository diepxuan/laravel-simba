# INDMVT_.dll - Danh mục vật tư (có BOM)

## Tổng quan
- **Module**: IN (Inventory)
- **Loại**: Danh mục (Category)
- **Chức năng**: Quản lý danh mục vật tư/hàng hóa, hỗ trợ định nghĩa BOM (Bill of Materials) cho sản phẩm lắp ráp

## Forms

### frmINDMVT.cs
- **Kế thừa**: frmDMView
- **Chức năng**: Form xem danh sách vật tư

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| GetData | params object[] | void | Lấy dữ liệu danh mục vật tư |

### frmINDMVTEdit.cs
- **Kế thừa**: frmDMEdit
- **Chức năng**: Form thêm/sửa thông tin vật tư

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Vt | TextBox | Ma_Vt | - |
| txtTen_Vt | TextBox | Ten_Vt | - |
| cboDvt | ComboBox | Dvt | - |
| txtMa_Nhvt | AsTextBox | Ma_Nhvt | AfterCodeValidating |
| lblTen_NhVt | Label | Ten_NhVt | - |
| cboLoai | ComboBox | Loai (SelectedValue) | SelectedValueChanged |
| cboGia_ton | ComboBox | Gia_ton (SelectedValue) | - |
| chkTon_kho | AsCheckBox | ton_kho (Checked) | - |
| txtMa_kho | AsTextBox | Ma_kho | - |
| lblTen_Kho | Label | Ten_Kho | - |
| txtSl_min | AsTextNumeric | Sl_min (Value) | - |
| txtSl_max | AsTextNumeric | Sl_max (Value) | - |
| txtGia_nt0 | AsTextNumeric | Gia_nt0 (Value) | - |
| txtGia_nt2 | AsTextNumeric | Gia_nt2 (Value) | - |
| txtTk_Vt | AsTextBox | Tk_Vt | - |
| lblTen_Tk_Vt | Label | Ten_tk_vt | - |
| txtTk_Dt | AsTextBox | Tk_Dt | - |
| lblTen_Tk_Dt | Label | Ten_Tk_Dt | - |
| txtTk_DtNb | AsTextBox | Tk_DtNb | - |
| lblTen_Tk_Dtnb | Label | Ten_Tk_DtNb | - |
| txtTk_Gv | AsTextBox | Tk_Gv | - |
| lblTen_Tk_gv | Label | Ten_Tk_Gv | - |
| txtTk_Tl | AsTextBox | Tk_Tl | - |
| lblTen_Tk_tl | Label | Ten_Tk_tl | - |
| txtTk_Ck | AsTextBox | Tk_Ck | - |
| lblTen_Tk_Ck | Label | Ten_Tk_Ck | - |
| txtTs_Gtgt | AsTextNumeric | Ts_Gtgt (Value) | - |
| txtTs_Nk | AsTextNumeric | Ts_Nk (Value) | - |
| txtTs_Xk | AsTextNumeric | Ts_Xk (Value) | - |
| txtTs_ttdb | AsTextNumeric | Ts_ttdb (Value) | - |
| txtMa_Thue | AsTextBox | ma_thue | - |
| cboDvt_mua | AsComboBox | Dvt_mua | - |
| txtHs_dvtmua | AsTextNumeric | Hs_dvtmua (Value) | - |
| cboDvt_ban | AsComboBox | Dvt_ban | - |
| txtHs_dvtban | AsTextNumeric | Hs_dvtban (Value) | - |
| cmdBo | Button | - | Click (cmdBo_Click) |
| gbLinhKien | GroupBox | co_ct (Enabled) | - |
| txtMa_lk | AsTextBox | - | AfterCodeValidating |
| txtTen_lk | TextBox | - | - |
| txtDvtLk | TextBox | - | - |
| txtSo_luong | AsTextNumeric | - | - |
| txtHe_so | AsTextNumeric | - | - |
| cmdAddPart | Button | - | Click (cmdAddPart_Click) |
| cmdDeleteLk | Button | - | Click (cmdDeleteLk_Click) |
| adgvBoM | AsInputDGV | DataSource: f_oTblBoM | - |

#### BOM Grid Columns
| Column | Type | DataPropertyName |
|--------|------|------------------|
| dgvcMa_Lk | DataGridViewTextBoxColumn | ma_lk |
| dgvcTen_lk | DataGridViewTextBoxColumn | ten_lk |
| dgvcDvt | DataGridViewTextBoxColumn | dvt |
| dgvcSo_luong | DataGridViewAsTextNumericColumn | so_luong |
| dgvcHe_so | DataGridViewAsTextNumericColumn | he_so |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitBeforeGetData | - | void | Khởi tạo combo box Loại vật tư, Giá tồn |
| InitAfterGetData | - | void | Load BOM data, format numeric |
| DisableFields | - | void | Disable mã vật tư khi edit |
| DataBinding | - | void | Bind controls to DataRow |
| SetToRow | - | bool | Set data từ control vào row |
| ValidData | - | bool | Validate dữ liệu trước khi save |
| InsertToDB | - | bool | Insert vật tư và BOM vào DB |
| UpdateDB | - | bool | Update vật tư và BOM vào DB |
| RefreshTabBOM | bool isLoading | void | Hiển thị/ẩn tab BOM |
| ValidLinhKien | - | bool | Validate linh kiện BOM |
| cmdAddPart_Click | sender, e | void | Thêm linh kiện vào BOM |
| cmdDeleteLk_Click | sender, e | void | Xóa linh kiện khỏi BOM |
| txtMa_Nhvt_AfterCodeValidating | sender, e | void | Auto-fill TK từ nhóm VT |
| txtMa_lk_AfterCodeValidating | sender, e | void | Validate và fill tên linh kiện |
| cboLoai_SelectedValueChanged | sender, e | void | Auto-check tồn kho theo loại |
| FormatNumericTextBox | - | void | Format số lượng theo config |

## Data Access

### DictionaryController (MA_VT)
- **Interface**: IDictionaryController
- **Implementation**: DictionaryController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GetDmVt | CompanyID, filter | DataTable | Lấy danh sách vật tư |
| Insert | sp_InsertDmVt | DataRow | bool | Thêm vật tư mới |
| Update | sp_UpdateDmVt | DataRow | bool | Cập nhật vật tư |

### DictionaryController (MA_BOM)
- **Interface**: IDictionaryController
- **Implementation**: DictionaryController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GetDmBom | CompanyID, ma_vt | DataTable | Lấy BOM của vật tư |
| Insert | sp_InsertDmBom | DataRow | bool | Thêm linh kiện BOM |
| DeleteDeletedRow | sp_DeleteDmBom | DataRow | bool | Xóa linh kiện BOM |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GetDmVt | Lấy danh sách vật tư | @ma_cty, @filter | DataTable |
| sp_InsertDmVt | Thêm vật tư | @ma_cty, @ma_vt, @ten_vt, ... | int |
| sp_UpdateDmVt | Update vật tư | @ma_cty, @ma_vt, @ten_vt, ... | int |
| sp_GetDmBom | Lấy BOM | @ma_cty, @ma_vt | DataTable |
| sp_InsertDmBom | Thêm BOM | @ma_cty, @ma_vt, @ma_lk, @so_luong, ... | int |
| sp_DeleteDmBom | Xóa BOM | @ma_cty, @ma_vt, @ma_lk | int |

## Business Logic

### Luồng xử lý chính
1. **Load Form**: 
   - InitBeforeGetData: Load combo Loại VT, Giá tồn
   - InitAfterGetData: Load BOM data nếu edit mode
   
2. **Thêm mới vật tư**:
   - Nhập mã, tên, đơn vị tính
   - Chọn nhóm vật tư → Auto-fill các TK kế toán
   - Chọn loại vật tư → Auto-check "Theo dõi tồn kho"
   - Nhập các thông số tồn kho, giá, thuế suất
   - Nếu là sản phẩm lắp ráp: Click "Thông tin lắp ráp" → Thêm linh kiện BOM
   - Save → Transaction: Insert BOM trước, sau đó Insert VT

3. **Sửa vật tư**:
   - Không cho sửa mã vật tư
   - Update BOM: Xóa deleted rows, Insert added rows
   - Transaction: Update BOM trước, sau đó Update VT

### Validation rules
- Mã vật tư, Tên vật tư: Bắt buộc
- Nếu "Theo dõi tồn kho" = true: ĐVT và TK vật tư bắt buộc
- BOM: Không được trùng mã linh kiện
- BOM: Mã linh kiện không được trùng mã vật tư cha (tránh circular reference)

### Lookup/Auto-complete
- txtMa_Nhvt: Lookup MA_NHVT, trả về TK_VT, TK_DT, TK_DTNB, TK_GV, TK_TL, TK_CK
- txtMa_kho: Lookup MA_KHO
- txtMa_Thue: Lookup MA_THUE
- txtMa_lk: Lookup MA_VT (cho BOM), trả về TEN_VT, DVT
- txtTk_*: Lookup TK (chi_tiet=1)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| dmvt | Danh mục vật tư | CRUD |
| dm_bom | BOM - định mức vật tư | CRUD |
| dm_nhvt | Danh mục nhóm vật tư | R |
| dm_kho | Danh mục kho | R |
| dm_thue | Danh mục thuế | R |
| dmtk | Danh mục tài khoản | R |

## Mapping sang PHP

### Controller
```php
// app/Http/Controllers/Inventory/DmVtController.php
namespace App\Http\Controllers\Inventory;

class DmVtController extends Controller
{
    protected $dmVtRepo;
    protected $dmBomRepo;
    
    public function index(Request $request)
    {
        $data = $this->dmVtRepo->getList(
            $request->company_id,
            $request->filter
        );
        return view('inventory.dmvt.index', compact('data'));
    }
    
    public function store(DmVtRequest $request)
    {
        DB::transaction(function() use ($request) {
            // Insert BOM trước
            foreach ($request->bom_items as $item) {
                $this->dmBomRepo->create($item);
            }
            // Insert vật tư
            $this->dmVtRepo->create($request->validated());
        });
    }
    
    public function update(DmVtRequest $request, $ma_vt)
    {
        DB::transaction(function() use ($request, $ma_vt) {
            // Xử lý BOM
            $this->dmBomRepo->sync($ma_vt, $request->bom_items);
            // Update vật tư
            $this->dmVtRepo->update($ma_vt, $request->validated());
        });
    }
}
```

### Repository
```php
// app/Repositories/Inventory/DmVtRepository.php
namespace App\Repositories\Inventory;

class DmVtRepository
{
    public function getList($companyId, $filter = '')
    {
        return DB::select('EXEC sp_GetDmVt ?, ?', [$companyId, $filter]);
    }
    
    public function create(array $data)
    {
        return DB::statement('EXEC sp_InsertDmVt ?, ?, ?, ...', [
            $data['ma_cty'],
            $data['ma_vt'],
            $data['ten_vt'],
            // ...
        ]);
    }
}

// app/Repositories/Inventory/DmBomRepository.php
class DmBomRepository
{
    public function getByVt($companyId, $maVt)
    {
        return DB::select('EXEC sp_GetDmBom ?, ?', [$companyId, $maVt]);
    }
    
    public function sync($maVt, array $items)
    {
        // Delete old
        DB::table('dm_bom')->where('ma_vt', $maVt)->delete();
        // Insert new
        foreach ($items as $item) {
            DB::table('dm_bom')->insert($item);
        }
    }
}
```

### Model
```php
// app/Models/Inventory/DmVt.php
namespace App\Models\Inventory;

class DmVt extends Model
{
    protected $table = 'dmvt';
    protected $primaryKey = ['ma_cty', 'ma_vt'];
    public $incrementing = false;
    
    protected $fillable = [
        'ma_cty', 'ma_vt', 'ten_vt', 'dvt', 'ma_nhvt',
        'loai', 'gia_ton', 'ton_kho', 'ma_kho',
        'sl_min', 'sl_max', 'gia_nt0', 'gia_nt2',
        'tk_vt', 'tk_dt', 'tk_dtnb', 'tk_gv', 'tk_tl', 'tk_ck',
        'ts_gtgt', 'ts_nk', 'ts_xk', 'ts_ttdb', 'ma_thue',
        'dvt_mua', 'hs_dvtmua', 'dvt_ban', 'hs_dvtban',
        'co_ct', 'ksd'
    ];
    
    public function bom()
    {
        return $this->hasMany(DmBom::class, 'ma_vt', 'ma_vt');
    }
    
    public function nhvt()
    {
        return $this->belongsTo(DmNhvt::class, 'ma_nhvt', 'ma_nhvt');
    }
}

// app/Models/Inventory/DmBom.php
class DmBom extends Model
{
    protected $table = 'dm_bom';
    protected $fillable = [
        'ma_cty', 'ma_vt', 'ma_lk', 'ten_lk', 
        'dvt', 'so_luong', 'he_so'
    ];
}
```

### Form Request (Validation)
```php
// app/Http/Requests/Inventory/DmVtRequest.php
class DmVtRequest extends FormRequest
{
    public function rules()
    {
        return [
            'ma_vt' => 'required|max:20',
            'ten_vt' => 'required|max:128',
            'dvt' => 'required_if:ton_kho,1',
            'tk_vt' => 'required_if:ton_kho,1',
            'bom_items.*.ma_lk' => 'distinct|different:ma_vt',
        ];
    }
}
```

## Ghi chú
- BOM chỉ hiển thị khi click nút "Thông tin lắp ráp"
- Có transaction khi insert/update để đảm bảo tính toàn vẹn dữ liệu giữa dmvt và dm_bom
- Lookup MA_NHVT sẽ auto-fill các tài khoản kế toán mặc định
- Loại vật tư quyết định có theo dõi tồn kho hay không
- Có 3 loại thuế suất: GTGT, NK (nhập khẩu), XK (xuất khẩu), TTĐB (tiêu thụ đặc biệt)
