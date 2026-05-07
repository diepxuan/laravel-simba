# Task #001 - Danh mục Vật tư & BOM

## Header

| Trường | Giá trị |
|--------|---------|
| Task # | 001 |
| DLL name | INDMVT_.dll |
| Module | IN (Inventory) |
| Loại | Master |
| Namespace | AsiaErp.UserInterface |
| Assembly Title | Danh mục bộ phận |
| Base class | frmDMView / frmDMEdit |

---

## 1. Mô tả chức năng

Module quản lý danh mục vật tư (Material Master) và Bill of Materials (BOM). Đây là module Master thuộc phân hệ Kho (IN), cho phép:

- CRUD danh mục vật tư: mã, tên, nhóm, loại, đơn vị tính
- Quản lý tài khoản kế toán liên quan (TK vật tư, TK doanh thu, TK giá vốn, TK chiết khấu, TK trả lại)
- Quản lý thuế suất (GTGT, TTĐB, NK, XK)
- Quản lý giá mua/bán mặc định
- Theo dõi tồn kho (tối thiểu/tối đa)
- Quản lý BOM: định nghĩa cấu trúc lắp ráp, linh kiện thành phần

---

## 2. Form Classes

### 2.1 frmINDMVT (Danh sách)

**Kế thừa:** `frmDMView`

**Mục đích:** Form xem danh sách vật tư, gọi base `GetData()` để load dữ liệu.

**Constructor:**
```csharp
public frmINDMVT(string menuid)
```

**Events/Methods:**
| Method | Mô tả |
|--------|-------|
| `GetData(params object[] @params)` | Override, gọi `base.GetData(CompanyID, "", "0", CurrentCultureName)` |

**Controls:** Không có control riêng (dùng control kế thừa từ frmDMView - AsDataGridView)

---

### 2.2 frmINDMVTEdit (Thêm/Sửa)

**Kế thừa:** `frmDMEdit`

**Mục đích:** Form thêm/sửa thông tin vật tư và quản lý BOM.

**Fields:**
| Field | Type | Mô tả |
|-------|------|-------|
| `f_sCmdBoText` | string | Text nút BOM |
| `f_oTblBoM` | DataTable | Bảng dữ liệu BOM |
| `f_oBOMController` | DictionaryController | Controller cho BOM |

**Controls - Tab Thông tin chung:**
| Control | Type | Label | DataBinding |
|---------|------|-------|-------------|
| `txtMa_Vt` | TextBox | Mã vật tư | Ma_Vt |
| `txtTen_Vt` | TextBox | Tên vật tư | Ten_Vt |
| `txtMa_Nhvt` | AsTextBox | Mã nhóm vật tư | Ma_Nhvt (AutoLookup, NHVT) |
| `cboDvt` | ComboBox | Đơn vị tính | Dvt |
| `cboLoai` | ComboBox | Loại | Loai |
| `chkTon_kho` | AsCheckBox | Theo dõi tồn kho | Ton_kho |
| `cboGia_ton` | ComboBox | Phương pháp tính giá tồn | Gia_ton |
| `txtMa_nhvat` | AsTextBox | Mã nhóm VAT | Ma_Nhvat (AutoLookup, NHVAT) |
| `txtMa_Thue` | AsTextBox | Mã thuế | Ma_Thue (AutoLookup, MA_THUE) |
| `txtTs_Gtgt` | AsTextNumeric | Thuế suất GTGT | Ts_Gtgt |
| `txtTs_ttdb` | AsTextNumeric | Thuế suất TTĐB | Ts_Ttdb |
| `txtTs_Nk` | AsTextNumeric | Thuế suất NK | Ts_Nk |
| `txtTs_Xk` | AsTextNumeric | Thuế suất XK | Ts_Xk |
| `txtMa_kho` | AsTextBox | Mã kho mặc định | Ma_Kho (AutoLookup) |
| `txtSl_min` | AsTextNumeric | Tồn tối thiểu | Sl_min |
| `txtSl_max` | AsTextNumeric | Tồn tối đa | Sl_max |
| `txtTk_Vt` | AsTextBox | TK Vật tư | Tk_Vt (AutoLookup) |
| `txtTk_Dt` | AsTextBox | TK Doanh thu | Tk_Dt (AutoLookup) |
| `txtTk_DtNb` | AsTextBox | TK DT nội bộ | Tk_DtNb (AutoLookup) |
| `txtTk_Gv` | AsTextBox | TK Giá vốn | Tk_Gv (AutoLookup) |
| `txtTk_Tl` | AsTextBox | TK Trả lại | Tk_Tl (AutoLookup) |
| `txtTk_Ck` | AsTextBox | TK Chiết khấu | Tk_Ck (AutoLookup) |
| `txtGia_nt0` | AsTextNumeric | Giá mua mặc định | Gia_nt0 |
| `txtGia_nt2` | AsTextNumeric | Giá bán mặc định | Gia_nt2 |
| `txtHs_dvtmua` | AsTextNumeric | Hệ số ĐVT mua | Hs_Dvtmua |
| `txtHs_dvtban` | AsTextNumeric | Hệ số ĐVT bán | Hs_Dvtban |
| `cboDvt_mua` | AsComboBox | ĐVT mua | Dvt_Mua |
| `cboDvt_ban` | AsComboBox | ĐVT bán | Dvt_Ban |

**Controls - Tab BOM (Linh kiện):**
| Control | Type | Label | DataBinding |
|---------|------|-------|-------------|
| `txtMa_lk` | AsTextBox | Mã linh kiện | Ma_Lk (AutoLookup) |
| `txtTen_lk` | TextBox | Tên linh kiện | Ten_Lk (readonly) |
| `txtDvtLk` | TextBox | ĐVT linh kiện | Dvt_Lk (readonly) |
| `txtSo_luong` | AsTextNumeric | Số lượng | So_luong |
| `txtHe_so` | AsTextNumeric | Hệ số | He_so |
| `cmdAddPart` | Button | Thêm linh kiện | - |
| `cmdDeleteLk` | Button | Xóa linh kiện | - |
| `cmdBo` | Button | Quản lý BOM | - |
| `adgvBoM` | AsInputDGV | Grid BOM | f_oTblBoM |
| `gbLinhKien` | GroupBox | Group box linh kiện | - |

**DataGridView BOM Columns:**
| Column | Type | DataField |
|--------|------|-----------|
| `dgvcMa_Lk` | DataGridViewTextBoxColumn | Ma_Lk |
| `dgvcTen_lk` | DataGridViewTextBoxColumn | Ten_Lk |
| `dgvcDvt` | DataGridViewTextBoxColumn | Dvt |
| `dgvcSo_luong` | DataGridViewAsTextNumericColumn | So_luong |
| `dgvcHe_so` | DataGridViewAsTextNumericColumn | He_so |

**Events:**
| Event Handler | Trigger | Mô tả |
|---------------|---------|-------|
| `frmINDMVTEdit_Load` | Form Load | Khởi tạo dữ liệu, load combobox |
| `cboLoai_SelectedValueChanged` | cboLoai change | Xử lý khi thay đổi loại |
| `txtMa_Nhvt_AfterCodeValidating` | txtMa_Nhvt validate | Lookup tên nhóm vật tư |
| `txtMa_lk_AfterCodeValidating` | txtMa_lk validate | Lookup tên linh kiện |
| `cmdAddPart_Click` | Button click | Thêm dòng linh kiện vào BOM |
| `cmdDeleteLk_Click` | Button click | Xóa dòng linh kiện khỏi BOM |
| `cmdBo_Click` | Button click | Mở form quản lý BOM |

**InitBeforeGetData():**
- Set `MyDictInfo` = DictionaryInformation cho "INDMVT"
- Initialize BOM DataTable structure

**InitAfterGetData():**
- Load dữ liệu BOM qua `BoMController.GetData(CompanyID, Ma_Vt)`
- Bind BOM data vào `adgvBoM`

---

## 3. Data Structures

### 3.1 Bảng INDVVT (Danh mục vật tư)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty (PK) |
| Ma_Vt | nvarchar(20) | NOT NULL | Mã vật tư (PK) |
| Ten_Vt | nvarchar(200) | NOT NULL | Tên vật tư |
| Ma_Nhvt | nvarchar(20) | NULL | Mã nhóm vật tư (FK) |
| Dvt | nvarchar(20) | NULL | Đơn vị tính |
| Loai | int | NULL | Loại vật tư |
| Ton_kho | bit | NULL | Theo dõi tồn kho |
| Gia_ton | int | NULL | Phương pháp tính giá tồn |
| Ma_Nhvat | nvarchar(20) | NULL | Mã nhóm VAT |
| Ma_Thue | nvarchar(20) | NULL | Mã thuế |
| Ts_Gtgt | decimal(19,4) | NULL | Thuế suất GTGT % |
| Ts_Ttdb | decimal(19,4) | NULL | Thuế suất TTĐB % |
| Ts_Nk | decimal(19,4) | NULL | Thuế suất NK % |
| Ts_Xk | decimal(19,4) | NULL | Thuế suất XK % |
| Ma_Kho | nvarchar(20) | NULL | Mã kho mặc định |
| Sl_min | decimal(19,4) | NULL | Tồn tối thiểu |
| Sl_max | decimal(19,4) | NULL | Tồn tối đa |
| Tk_Vt | nvarchar(20) | NULL | TK Vật tư |
| Tk_Dt | nvarchar(20) | NULL | TK Doanh thu |
| Tk_DtNb | nvarchar(20) | NULL | TK DT nội bộ |
| Tk_Gv | nvarchar(20) | NULL | TK Giá vốn |
| Tk_Tl | nvarchar(20) | NULL | TK Trả lại |
| Tk_Ck | nvarchar(20) | NULL | TK Chiết khấu |
| Gia_nt0 | decimal(19,4) | NULL | Giá mua mặc định |
| Gia_nt2 | decimal(19,4) | NULL | Giá bán mặc định |
| Hs_Dvtmua | decimal(19,4) | NULL | Hệ số ĐVT mua |
| Hs_Dvtban | decimal(19,4) | NULL | Hệ số ĐVT bán |
| Dvt_Mua | nvarchar(20) | NULL | ĐVT mua |
| Dvt_Ban | nvarchar(20) | NULL | ĐVT bán |
| luser | nvarchar(50) | NULL | User cập nhật cuối |
| ldate | datetime | NULL | Ngày cập nhật cuối |

**Primary Key:** (Ma_Cty, Ma_Vt)

### 3.2 Bảng MA_BOM (Bill of Materials)

| Column | SQL Type | Nullable | Mô tả |
|--------|----------|----------|-------|
| Ma_Cty | nvarchar(20) | NOT NULL | Mã công ty (PK) |
| Ma_Vt | nvarchar(20) | NOT NULL | Mã vật tư cha (PK) |
| Ma_Lk | nvarchar(20) | NOT NULL | Mã linh kiện (PK) |
| So_luong | decimal(19,4) | NOT NULL | Số lượng |
| He_so | decimal(19,4) | NULL | Hệ số quy đổi |

**Primary Key:** (Ma_Cty, Ma_Vt, Ma_Lk)
**Foreign Key:** Ma_Lk -> INDVVT(Ma_Vt)

---

## 4. Stored Procedures

### 4.1 INDVVT (Danh mục vật tư)

| SP | Type | Parameters | Mô tả |
|----|------|-----------|-------|
| `asGetINDMVT` | SELECT | @pMa_Cty, @pKeyword, @pFlag, @pLang | Lấy danh sách vật tư (paging) |
| `asGetINDMVTEdit` | SELECT | @pMa_Cty, @pMa_Vt | Lấy 1 vật tư để edit |
| `asInsINDMVT` | INSERT | @pMa_Cty, @pMa_Vt, @pTen_Vt, @pMa_Nhvt, @pDvt, @pLoai, @pTon_kho, @pGia_ton, @pMa_Nhvat, @pMa_Thue, @pTs_Gtgt, @pTs_Ttdb, @pTs_Nk, @pTs_Xk, @pMa_Kho, @pSl_min, @pSl_max, @pTk_Vt, @pTk_Dt, @pTk_DtNb, @pTk_Gv, @pTk_Tl, @pTk_Ck, @pGia_nt0, @pGia_nt2, @pHs_Dvtmua, @pHs_Dvtban, @pDvt_Mua, @pDvt_Ban, @pRet OUTPUT | Thêm vật tư mới |
| `asUpdINDMVT` | UPDATE | @pMa_Cty, @pMa_Vt, @pTen_Vt, @pMa_Nhvt, @pDvt, @pLoai, @pTon_kho, @pGia_ton, @pMa_Nhvat, @pMa_Thue, @pTs_Gtgt, @pTs_Ttdb, @pTs_Nk, @pTs_Xk, @pMa_Kho, @pSl_min, @pSl_max, @pTk_Vt, @pTk_Dt, @pTk_DtNb, @pTk_Gv, @pTk_Tl, @pTk_Ck, @pGia_nt0, @pGia_nt2, @pHs_Dvtmua, @pHs_Dvtban, @pDvt_Mua, @pDvt_Ban, @pRet OUTPUT | Cập nhật vật tư |
| `asDelINDMVT` | DELETE | @pMa_Cty, @pMa_Vt, @pRet OUTPUT | Xóa vật tư |

### 4.2 MA_BOM (Bill of Materials)

| SP | Type | Parameters | Mô tả |
|----|------|-----------|-------|
| `asGetBOM` | SELECT | @pMa_Cty, @pMa_Vt | Lấy danh sách linh kiện của 1 vật tư |
| `asInsBOM` | INSERT | @pMa_Cty, @pMa_Vt, @pMa_Lk, @pSo_luong, @pHe_so, @pRet OUTPUT | Thêm linh kiện BOM |
| `asUpdBOM` | UPDATE | @pMa_Cty, @pMa_Vt, @pMa_Lk, @pSo_luong, @pHe_so, @pRet OUTPUT | Cập nhật linh kiện BOM |
| `asDelBOM` | DELETE | @pMa_Cty, @pMa_Vt, @pMa_Lk, @pRet OUTPUT | Xóa linh kiện BOM |

---

## 5. Business Logic

### 5.1 Validation

| Rule | Mô tả |
|------|-------|
| Ma_Vt NOT NULL | Mã vật tư không được để trống |
| Ma_Vt UNIQUE | Mã vật tư không trùng trong cùng công ty |
| Ten_Vt NOT NULL | Tên vật tư không được để trống |
| Ma_Nhvt valid | Mã nhóm vật tư phải tồn tại (lookup NHVT) |
| Ma_Lk valid (BOM) | Mã linh kiện phải tồn tại (lookup vật tư) |
| So_luong > 0 (BOM) | Số lượng linh kiện phải > 0 |
| Không tự reference (BOM) | Ma_Lk != Ma_Vt |

### 5.2 BOM Management

- `BoMController` = `ControllerFactory.GetDictionaryControllerByCodeName("MA_BOM")`
- Khi thêm vật tư mới: Lưu INDVVT trước, sau đó lưu các dòng BOM
- Khi sửa vật tư: Update INDVVT, sync BOM (insert mới, update tồn, xóa removed)
- `f_oTblBoM` được load từ `BoMController.GetData(CompanyID, Ma_Vt)`

### 5.3 Lookup References

| Lookup Code | Target Table | Description |
|-------------|-------------|-------------|
| NHVT | DMNHVT | Nhóm vật tư |
| NHVAT | DMNHVAT | Nhóm VAT |
| MA_THUE | DMTHUE | Danh mục thuế |
| INDMVT | INDVVT | Vật tư (cho BOM lookup) |

---

## 6. Mapping PHP

### 6.1 Model: Indmvt.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Database\Eloquent\Relations\BelongsTo;

class Indmvt extends Model
{
    protected $table = 'INDVVT';
    protected $primaryKey = ['Ma_Cty', 'Ma_Vt'];
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Ma_Vt', 'Ten_Vt', 'Ma_Nhvt', 'Dvt', 'Loai',
        'Ton_kho', 'Gia_ton', 'Ma_Nhvat', 'Ma_Thue',
        'Ts_Gtgt', 'Ts_Ttdb', 'Ts_Nk', 'Ts_Xk',
        'Ma_Kho', 'Sl_min', 'Sl_max',
        'Tk_Vt', 'Tk_Dt', 'Tk_DtNb', 'Tk_Gv', 'Tk_Tl', 'Tk_Ck',
        'Gia_nt0', 'Gia_nt2', 'Hs_Dvtmua', 'Hs_Dvtban',
        'Dvt_Mua', 'Dvt_Ban', 'luser', 'ldate',
    ];

    protected $casts = [
        'Ton_kho' => 'boolean',
        'Loai' => 'integer',
        'Gia_ton' => 'integer',
        'Ts_Gtgt' => 'decimal:4',
        'Ts_Ttdb' => 'decimal:4',
        'Ts_Nk' => 'decimal:4',
        'Ts_Xk' => 'decimal:4',
        'Sl_min' => 'decimal:4',
        'Sl_max' => 'decimal:4',
        'Gia_nt0' => 'decimal:4',
        'Gia_nt2' => 'decimal:4',
        'Hs_Dvtmua' => 'decimal:4',
        'Hs_Dvtban' => 'decimal:4',
        'ldate' => 'datetime',
    ];

    public function nhomVatTu(): BelongsTo
    {
        return $this->belongsTo(Dmnhvt::class, 'Ma_Nhvt', 'Ma_Nhvt');
    }

    public function bomComponents(): HasMany
    {
        return $this->hasMany(MaBom::class, 'Ma_Vt', 'Ma_Vt');
    }
}
```

### 6.2 Model: MaBom.php

```php
<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\BelongsTo;

class MaBom extends Model
{
    protected $table = 'MA_BOM';
    protected $primaryKey = ['Ma_Cty', 'Ma_Vt', 'Ma_Lk'];
    public $incrementing = false;
    protected $keyType = 'string';

    protected $fillable = [
        'Ma_Cty', 'Ma_Vt', 'Ma_Lk', 'So_luong', 'He_so',
    ];

    protected $casts = [
        'So_luong' => 'decimal:4',
        'He_so' => 'decimal:4',
    ];

    public function parentItem(): BelongsTo
    {
        return $this->belongsTo(Indmvt::class, 'Ma_Vt', 'Ma_Vt');
    }

    public function componentItem(): BelongsTo
    {
        return $this->belongsTo(Indmvt::class, 'Ma_Lk', 'Ma_Vt');
    }
}
```

### 6.3 Stored Procedure Classes

```php
<?php

namespace App\Services\StoredProcedure;

use Illuminate\Support\Facades\DB;

class IndmvtSp
{
    public static function getList(string $maCty, string $keyword = '', int $flag = 0, string $lang = 'vi-VN'): array
    {
        return DB::select('EXEC asGetINDMVT ?, ?, ?, ?', [
            $maCty, $keyword, $flag, $lang
        ]);
    }

    public static function getOne(string $maCty, string $maVt): ?object
    {
        $result = DB::select('EXEC asGetINDMVTEdit ?, ?', [
            $maCty, $maVt
        ]);
        return $result[0] ?? null;
    }

    public static function insert(array $data): int
    {
        $ret = 0;
        DB::statement('EXEC asInsINDMVT 
            @pMa_Cty=?, @pMa_Vt=?, @pTen_Vt=?, @pMa_Nhvt=?, @pDvt=?, 
            @pLoai=?, @pTon_kho=?, @pGia_ton=?, @pMa_Nhvat=?, @pMa_Thue=?,
            @pTs_Gtgt=?, @pTs_Ttdb=?, @pTs_Nk=?, @pTs_Xk=?,
            @pMa_Kho=?, @pSl_min=?, @pSl_max=?,
            @pTk_Vt=?, @pTk_Dt=?, @pTk_DtNb=?, @pTk_Gv=?, @pTk_Tl=?, @pTk_Ck=?,
            @pGia_nt0=?, @pGia_nt2=?, @pHs_Dvtmua=?, @pHs_Dvtban=?,
            @pDvt_Mua=?, @pDvt_Ban=?, @pRet=? OUTPUT',
            array_merge(array_values($data), [&$ret])
        );
        return $ret;
    }

    public static function update(array $data): int
    {
        $ret = 0;
        DB::statement('EXEC asUpdINDMVT 
            @pMa_Cty=?, @pMa_Vt=?, @pTen_Vt=?, @pMa_Nhvt=?, @pDvt=?, 
            @pLoai=?, @pTon_kho=?, @pGia_ton=?, @pMa_Nhvat=?, @pMa_Thue=?,
            @pTs_Gtgt=?, @pTs_Ttdb=?, @pTs_Nk=?, @pTs_Xk=?,
            @pMa_Kho=?, @pSl_min=?, @pSl_max=?,
            @pTk_Vt=?, @pTk_Dt=?, @pTk_DtNb=?, @pTk_Gv=?, @pTk_Tl=?, @pTk_Ck=?,
            @pGia_nt0=?, @pGia_nt2=?, @pHs_Dvtmua=?, @pHs_Dvtban=?,
            @pDvt_Mua=?, @pDvt_Ban=?, @pRet=? OUTPUT',
            array_merge(array_values($data), [&$ret])
        );
        return $ret;
    }

    public static function delete(string $maCty, string $maVt): int
    {
        $ret = 0;
        DB::statement('EXEC asDelINDMVT @pMa_Cty=?, @pMa_Vt=?, @pRet=? OUTPUT', [
            $maCty, $maVt, &$ret
        ]);
        return $ret;
    }
}

class MaBomSp
{
    public static function getList(string $maCty, string $maVt): array
    {
        return DB::select('EXEC asGetBOM ?, ?', [$maCty, $maVt]);
    }

    public static function insert(array $data): int
    {
        $ret = 0;
        DB::statement('EXEC asInsBOM @pMa_Cty=?, @pMa_Vt=?, @pMa_Lk=?, @pSo_luong=?, @pHe_so=?, @pRet=? OUTPUT',
            [$data['Ma_Cty'], $data['Ma_Vt'], $data['Ma_Lk'], $data['So_luong'], $data['He_so'] ?? 1, &$ret]
        );
        return $ret;
    }

    public static function update(array $data): int
    {
        $ret = 0;
        DB::statement('EXEC asUpdBOM @pMa_Cty=?, @pMa_Vt=?, @pMa_Lk=?, @pSo_luong=?, @pHe_so=?, @pRet=? OUTPUT',
            [$data['Ma_Cty'], $data['Ma_Vt'], $data['Ma_Lk'], $data['So_luong'], $data['He_so'] ?? 1, &$ret]
        );
        return $ret;
    }

    public static function delete(string $maCty, string $maVt, string $maLk): int
    {
        $ret = 0;
        DB::statement('EXEC asDelBOM @pMa_Cty=?, @pMa_Vt=?, @pMa_Lk=?, @pRet=? OUTPUT', [
            $maCty, $maVt, $maLk, &$ret
        ]);
        return $ret;
    }
}
```

### 6.4 Livewire Component

```php
<?php

namespace App\Livewire\Inventory;

use Livewire\Component;
use Livewire\WithPagination;
use App\Models\Indmvt;
use App\Models\MaBom;
use App\Services\StoredProcedure\IndmvtSp;
use App\Services\StoredProcedure\MaBomSp;

class IndmvtManager extends Component
{
    use WithPagination;

    public string $search = '';
    public ?string $editingId = null;
    public bool $showForm = false;
    public bool $showBomForm = false;

    // Form fields
    public string $Ma_Cty = '';
    public string $Ma_Vt = '';
    public string $Ten_Vt = '';
    public ?string $Ma_Nhvt = null;
    public ?string $Dvt = null;
    public ?int $Loai = null;
    public bool $Ton_kho = false;
    public ?int $Gia_ton = null;
    public ?string $Ma_Nhvat = null;
    public ?string $Ma_Thue = null;
    public ?float $Ts_Gtgt = 0;
    public ?float $Ts_Ttdb = 0;
    public ?float $Ts_Nk = 0;
    public ?float $Ts_Xk = 0;
    public ?string $Ma_Kho = null;
    public ?float $Sl_min = 0;
    public ?float $Sl_max = 0;
    public ?string $Tk_Vt = null;
    public ?string $Tk_Dt = null;
    public ?string $Tk_DtNb = null;
    public ?string $Tk_Gv = null;
    public ?string $Tk_Tl = null;
    public ?string $Tk_Ck = null;
    public ?float $Gia_nt0 = 0;
    public ?float $Gia_nt2 = 0;
    public ?float $Hs_Dvtmua = 1;
    public ?float $Hs_Dvtban = 1;
    public ?string $Dvt_Mua = null;
    public ?string $Dvt_Ban = null;

    // BOM fields
    public array $bomComponents = [];
    public string $bomMaLk = '';
    public string $bomTenLk = '';
    public string $bomDvtLk = '';
    public float $bomSoLuong = 1;
    public float $bomHeSo = 1;

    protected $rules = [
        'Ma_Vt' => 'required|max:20',
        'Ten_Vt' => 'required|max:200',
        'Ts_Gtgt' => 'nullable|numeric|min:0|max:100',
        'Sl_min' => 'nullable|numeric|min:0',
        'Sl_max' => 'nullable|numeric|min:0',
        'Gia_nt0' => 'nullable|numeric|min:0',
        'Gia_nt2' => 'nullable|numeric|min:0',
    ];

    public function mount(): void
    {
        $this->Ma_Cty = session('company_id', '');
    }

    public function render()
    {
        $items = IndmvtSp::getList($this->Ma_Cty, $this->search);
        return view('livewire.inventory.indmvt-manager', [
            'items' => $items,
        ]);
    }

    public function create(): void
    {
        $this->resetForm();
        $this->showForm = true;
        $this->editingId = null;
    }

    public function edit(string $maVt): void
    {
        $item = IndmvtSp::getOne($this->Ma_Cty, $maVt);
        if ($item) {
            $this->fillForm((array) $item);
            $this->editingId = $maVt;
            $this->showForm = true;
            $this->loadBom($maVt);
        }
    }

    public function save(): void
    {
        $this->validate();

        $data = $this->getFormData();

        if ($this->editingId) {
            $ret = IndmvtSp::update($data);
        } else {
            $ret = IndmvtSp::insert($data);
        }

        if ($ret === 0) {
            $this->dispatch('saved');
            $this->showForm = false;
            $this->resetForm();
        } else {
            $this->dispatch('error', message: "Lỗi lưu dữ liệu (code: $ret)");
        }
    }

    public function delete(string $maVt): void
    {
        $ret = IndmvtSp::delete($this->Ma_Cty, $maVt);
        if ($ret === 0) {
            $this->dispatch('deleted');
        } else {
            $this->dispatch('error', message: "Lỗi xóa dữ liệu (code: $ret)");
        }
    }

    // BOM methods
    public function loadBom(string $maVt): void
    {
        $this->bomComponents = MaBomSp::getList($this->Ma_Cty, $maVt);
    }

    public function addBomLine(): void
    {
        $this->validate([
            'bomMaLk' => 'required|max:20',
            'bomSoLuong' => 'required|numeric|min:0.0001',
        ]);

        $data = [
            'Ma_Cty' => $this->Ma_Cty,
            'Ma_Vt' => $this->editingId ?? $this->Ma_Vt,
            'Ma_Lk' => $this->bomMaLk,
            'So_luong' => $this->bomSoLuong,
            'He_so' => $this->bomHeSo,
        ];

        $ret = MaBomSp::insert($data);
        if ($ret === 0) {
            $this->loadBom($this->editingId ?? $this->Ma_Vt);
            $this->resetBomForm();
        }
    }

    public function deleteBomLine(string $maLk): void
    {
        $ret = MaBomSp::delete($this->Ma_Cty, $this->editingId, $maLk);
        if ($ret === 0) {
            $this->loadBom($this->editingId);
        }
    }

    private function resetForm(): void
    {
        $this->reset([
            'Ma_Vt', 'Ten_Vt', 'Ma_Nhvt', 'Dvt', 'Loai', 'Ton_kho', 'Gia_ton',
            'Ma_Nhvat', 'Ma_Thue', 'Ts_Gtgt', 'Ts_Ttdb', 'Ts_Nk', 'Ts_Xk',
            'Ma_Kho', 'Sl_min', 'Sl_max', 'Tk_Vt', 'Tk_Dt', 'Tk_DtNb',
            'Tk_Gv', 'Tk_Tl', 'Tk_Ck', 'Gia_nt0', 'Gia_nt2',
            'Hs_Dvtmua', 'Hs_Dvtban', 'Dvt_Mua', 'Dvt_Ban',
        ]);
        $this->Ton_kho = false;
        $this->Ts_Gtgt = 0;
        $this->Ts_Ttdb = 0;
        $this->Ts_Nk = 0;
        $this->Ts_Xk = 0;
        $this->Sl_min = 0;
        $this->Sl_max = 0;
        $this->Gia_nt0 = 0;
        $this->Gia_nt2 = 0;
        $this->Hs_Dvtmua = 1;
        $this->Hs_Dvtban = 1;
    }

    private function fillForm(array $item): void
    {
        $this->Ma_Vt = $item['Ma_Vt'] ?? '';
        $this->Ten_Vt = $item['Ten_Vt'] ?? '';
        $this->Ma_Nhvt = $item['Ma_Nhvt'] ?? null;
        $this->Dvt = $item['Dvt'] ?? null;
        $this->Loai = $item['Loai'] ?? null;
        $this->Ton_kho = (bool) ($item['Ton_kho'] ?? false);
        $this->Gia_ton = $item['Gia_ton'] ?? null;
        $this->Ma_Nhvat = $item['Ma_Nhvat'] ?? null;
        $this->Ma_Thue = $item['Ma_Thue'] ?? null;
        $this->Ts_Gtgt = $item['Ts_Gtgt'] ?? 0;
        $this->Ts_Ttdb = $item['Ts_Ttdb'] ?? 0;
        $this->Ts_Nk = $item['Ts_Nk'] ?? 0;
        $this->Ts_Xk = $item['Ts_Xk'] ?? 0;
        $this->Ma_Kho = $item['Ma_Kho'] ?? null;
        $this->Sl_min = $item['Sl_min'] ?? 0;
        $this->Sl_max = $item['Sl_max'] ?? 0;
        $this->Tk_Vt = $item['Tk_Vt'] ?? null;
        $this->Tk_Dt = $item['Tk_Dt'] ?? null;
        $this->Tk_DtNb = $item['Tk_DtNb'] ?? null;
        $this->Tk_Gv = $item['Tk_Gv'] ?? null;
        $this->Tk_Tl = $item['Tk_Tl'] ?? null;
        $this->Tk_Ck = $item['Tk_Ck'] ?? null;
        $this->Gia_nt0 = $item['Gia_nt0'] ?? 0;
        $this->Gia_nt2 = $item['Gia_nt2'] ?? 0;
        $this->Hs_Dvtmua = $item['Hs_Dvtmua'] ?? 1;
        $this->Hs_Dvtban = $item['Hs_Dvtban'] ?? 1;
        $this->Dvt_Mua = $item['Dvt_Mua'] ?? null;
        $this->Dvt_Ban = $item['Dvt_Ban'] ?? null;
    }

    private function getFormData(): array
    {
        return [
            'Ma_Cty' => $this->Ma_Cty,
            'Ma_Vt' => $this->Ma_Vt,
            'Ten_Vt' => $this->Ten_Vt,
            'Ma_Nhvt' => $this->Ma_Nhvt,
            'Dvt' => $this->Dvt,
            'Loai' => $this->Loai,
            'Ton_kho' => $this->Ton_kho,
            'Gia_ton' => $this->Gia_ton,
            'Ma_Nhvat' => $this->Ma_Nhvat,
            'Ma_Thue' => $this->Ma_Thue,
            'Ts_Gtgt' => $this->Ts_Gtgt,
            'Ts_Ttdb' => $this->Ts_Ttdb,
            'Ts_Nk' => $this->Ts_Nk,
            'Ts_Xk' => $this->Ts_Xk,
            'Ma_Kho' => $this->Ma_Kho,
            'Sl_min' => $this->Sl_min,
            'Sl_max' => $this->Sl_max,
            'Tk_Vt' => $this->Tk_Vt,
            'Tk_Dt' => $this->Tk_Dt,
            'Tk_DtNb' => $this->Tk_DtNb,
            'Tk_Gv' => $this->Tk_Gv,
            'Tk_Tl' => $this->Tk_Tl,
            'Tk_Ck' => $this->Tk_Ck,
            'Gia_nt0' => $this->Gia_nt0,
            'Gia_nt2' => $this->Gia_nt2,
            'Hs_Dvtmua' => $this->Hs_Dvtmua,
            'Hs_Dvtban' => $this->Hs_Dvtban,
            'Dvt_Mua' => $this->Dvt_Mua,
            'Dvt_Ban' => $this->Dvt_Ban,
        ];
    }

    private function resetBomForm(): void
    {
        $this->bomMaLk = '';
        $this->bomTenLk = '';
        $this->bomDvtLk = '';
        $this->bomSoLuong = 1;
        $this->bomHeSo = 1;
    }
}
```

### 6.5 View: indmvt-manager.blade.php

```blade
<div>
    {{-- Header --}}
    <div class="flex justify-between items-center mb-4">
        <h2 class="text-xl font-bold">Danh mục Vật tư</h2>
        <button wire:click="create" class="btn btn-primary">
            Thêm mới
        </button>
    </div>

    {{-- Search --}}
    <div class="mb-4">
        <input type="text" wire:model.live="search" placeholder="Tìm kiếm vật tư..."
               class="w-full border rounded px-3 py-2">
    </div>

    {{-- List Table --}}
    <table class="min-w-full border">
        <thead>
            <tr class="bg-gray-100">
                <th class="border px-3 py-2">Mã VT</th>
                <th class="border px-3 py-2">Tên vật tư</th>
                <th class="border px-3 py-2">Nhóm VT</th>
                <th class="border px-3 py-2">ĐVT</th>
                <th class="border px-3 py-2">Loại</th>
                <th class="border px-3 py-2">TK VT</th>
                <th class="border px-3 py-2">Actions</th>
            </tr>
        </thead>
        <tbody>
            @foreach($items as $item)
            <tr>
                <td class="border px-3 py-2">{{ $item->Ma_Vt }}</td>
                <td class="border px-3 py-2">{{ $item->Ten_Vt }}</td>
                <td class="border px-3 py-2">{{ $item->Ma_Nhvt }}</td>
                <td class="border px-3 py-2">{{ $item->Dvt }}</td>
                <td class="border px-3 py-2">{{ $item->Loai }}</td>
                <td class="border px-3 py-2">{{ $item->Tk_Vt }}</td>
                <td class="border px-3 py-2">
                    <button wire:click="edit('{{ $item->Ma_Vt }}')" class="btn btn-sm btn-info">Sửa</button>
                    <button wire:click="delete('{{ $item->Ma_Vt }}')"
                            onclick="confirm('Xác nhận xóa?') || event.stopImmediatePropagation()"
                            class="btn btn-sm btn-danger">Xóa</button>
                </td>
            </tr>
            @endforeach
        </tbody>
    </table>

    {{-- Detail Form Modal --}}
    @if($showForm)
    <div class="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
        <div class="bg-white rounded-lg p-6 w-full max-w-4xl max-h-[90vh] overflow-y-auto">
            <h3 class="text-lg font-bold mb-4">
                {{ $editingId ? 'Sửa vật tư: ' . $Ma_Vt : 'Thêm vật tư mới' }}
            </h3>

            <form wire:submit="save">
                <div class="grid grid-cols-2 gap-4">
                    {{-- Thông tin chung --}}
                    <div>
                        <label class="block text-sm font-medium">Mã vật tư *</label>
                        <input type="text" wire:model="Ma_Vt" {{ $editingId ? 'readonly' : '' }}
                               class="w-full border rounded px-3 py-1 {{ $editingId ? 'bg-gray-100' : '' }}">
                        @error('Ma_Vt') <span class="text-red-500 text-xs">{{ $message }}</span> @enderror
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Tên vật tư *</label>
                        <input type="text" wire:model="Ten_Vt" class="w-full border rounded px-3 py-1">
                        @error('Ten_Vt') <span class="text-red-500 text-xs">{{ $message }}</span> @enderror
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Mã nhóm VT</label>
                        <input type="text" wire:model="Ma_Nhvt" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">ĐVT</label>
                        <input type="text" wire:model="Dvt" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Loại</label>
                        <select wire:model="Loai" class="w-full border rounded px-3 py-1">
                            <option value="">-- Chọn --</option>
                            <option value="1">Thành phẩm</option>
                            <option value="2">Nguyên vật liệu</option>
                            <option value="3">Công cụ dụng cụ</option>
                            <option value="4">Hàng hóa</option>
                        </select>
                    </div>
                    <div>
                        <label class="flex items-center gap-2">
                            <input type="checkbox" wire:model="Ton_kho"> Theo dõi tồn kho
                        </label>
                    </div>

                    {{-- Thuế --}}
                    <div>
                        <label class="block text-sm font-medium">Thuế suất GTGT (%)</label>
                        <input type="number" step="0.01" wire:model="Ts_Gtgt" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Thuế suất TTĐB (%)</label>
                        <input type="number" step="0.01" wire:model="Ts_Ttdb" class="w-full border rounded px-3 py-1">
                    </div>

                    {{-- Giá --}}
                    <div>
                        <label class="block text-sm font-medium">Giá mua</label>
                        <input type="number" step="0.01" wire:model="Gia_nt0" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Giá bán</label>
                        <input type="number" step="0.01" wire:model="Gia_nt2" class="w-full border rounded px-3 py-1">
                    </div>

                    {{-- TK kế toán --}}
                    <div>
                        <label class="block text-sm font-medium">TK Vật tư</label>
                        <input type="text" wire:model="Tk_Vt" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">TK Doanh thu</label>
                        <input type="text" wire:model="Tk_Dt" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">TK Giá vốn</label>
                        <input type="text" wire:model="Tk_Gv" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">TK Chiết khấu</label>
                        <input type="text" wire:model="Tk_Ck" class="w-full border rounded px-3 py-1">
                    </div>

                    {{-- Tồn kho --}}
                    <div>
                        <label class="block text-sm font-medium">Tồn tối thiểu</label>
                        <input type="number" step="0.0001" wire:model="Sl_min" class="w-full border rounded px-3 py-1">
                    </div>
                    <div>
                        <label class="block text-sm font-medium">Tồn tối đa</label>
                        <input type="number" step="0.0001" wire:model="Sl_max" class="w-full border rounded px-3 py-1">
                    </div>
                </div>

                {{-- BOM Section --}}
                @if($editingId)
                <div class="mt-6 border-t pt-4">
                    <h4 class="font-bold mb-2">Bill of Materials (BOM)</h4>

                    <div class="grid grid-cols-5 gap-2 mb-2">
                        <input type="text" wire:model="bomMaLk" placeholder="Mã linh kiện"
                               class="border rounded px-2 py-1">
                        <input type="text" wire:model="bomTenLk" placeholder="Tên linh kiện" readonly
                               class="border rounded px-2 py-1 bg-gray-100">
                        <input type="text" wire:model="bomDvtLk" placeholder="ĐVT" readonly
                               class="border rounded px-2 py-1 bg-gray-100">
                        <input type="number" step="0.0001" wire:model="bomSoLuong" placeholder="Số lượng"
                               class="border rounded px-2 py-1">
                        <input type="number" step="0.0001" wire:model="bomHeSo" placeholder="Hệ số"
                               class="border rounded px-2 py-1">
                    </div>
                    <button type="button" wire:click="addBomLine" class="btn btn-sm btn-primary mb-2">
                        Thêm linh kiện
                    </button>

                    <table class="min-w-full border text-sm">
                        <thead>
                            <tr class="bg-gray-50">
                                <th class="border px-2 py-1">Mã LK</th>
                                <th class="border px-2 py-1">Tên LK</th>
                                <th class="border px-2 py-1">ĐVT</th>
                                <th class="border px-2 py-1">Số lượng</th>
                                <th class="border px-2 py-1">Hệ số</th>
                                <th class="border px-2 py-1"></th>
                            </tr>
                        </thead>
                        <tbody>
                            @foreach($bomComponents as $bom)
                            <tr>
                                <td class="border px-2 py-1">{{ $bom->Ma_Lk }}</td>
                                <td class="border px-2 py-1">{{ $bom->Ten_Lk }}</td>
                                <td class="border px-2 py-1">{{ $bom->Dvt }}</td>
                                <td class="border px-2 py-1 text-right">{{ number_format($bom->So_luong, 4) }}</td>
                                <td class="border px-2 py-1 text-right">{{ number_format($bom->He_so, 4) }}</td>
                                <td class="border px-2 py-1">
                                    <button type="button" wire:click="deleteBomLine('{{ $bom->Ma_Lk }}')"
                                            class="text-red-500">X</button>
                                </td>
                            </tr>
                            @endforeach
                        </tbody>
                    </table>
                </div>
                @endif

                <div class="mt-4 flex gap-2">
                    <button type="submit" class="btn btn-primary">Lưu</button>
                    <button type="button" wire:click="$set('showForm', false)" class="btn btn-secondary">Hủy</button>
                </div>
            </form>
        </div>
    </div>
    @endif
</div>
```

### 6.6 Routes

```php
// routes/web.php
use App\Livewire\Inventory\IndmvtManager;

Route::middleware(['auth'])->group(function () {
    Route::get('/inventory/materials', IndmvtManager::class)->name('inventory.materials.index');
});
```

---

## 7. Dependencies

| Dependency | Type | Mô tả |
|-----------|------|-------|
| Framework.dll | External | AsiaErp.Framework (frmDMView, frmDMEdit, DictionaryController) |
| Helper.dll | External | AsiaErp.Helper |
| NHVT | Master | Nhóm vật tư (DMNHVT) |
| NHVAT | Master | Nhóm VAT (DMNHVAT) |
| MA_THUE | Master | Danh mục thuế (DMTHUE) |
| INDMVT | Self-reference | Vật tư (cho BOM lookup) |
| INDVVT | Table | Bảng dữ liệu vật tư |
| MA_BOM | Table | Bảng dữ liệu BOM |

---

## 8. Progress Checklist

### C# Decompiled
- [x] frmINDMVT.cs (List form)
- [x] frmINDMVTEdit.cs (Edit form with BOM)
- [x] README.md phân tích

### PHP Implementation
- [ ] Model Indmvt.php
- [ ] Model MaBom.php
- [ ] Stored Procedure classes (IndmvtSp, MaBomSp)
- [ ] Livewire component (IndmvtManager)
- [ ] View (indmvt-manager.blade.php)
- [ ] Routes

### Database
- [ ] Kiểm tra/đảm bảo bảng INDVVT tồn tại
- [ ] Kiểm tra/đảm bảo bảng MA_BOM tồn tại
- [ ] Kiểm tra Stored Procedures

### Testing
- [ ] Test CRUD vật tư
- [ ] Test BOM management
- [ ] Test validation
- [ ] Test lookup references
