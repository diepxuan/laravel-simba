# GLMAUBCTCTMVI09

## Tong quan
- **Module**: GL (General Ledger)
- **Loai**: Danh muc - Mau bao cao tai chinh
- **Chuc nang**: Quan ly mau bao cao tai chinh
- **Loai bao cao**: Bao cao tai chinh - Mau I (Theo thong tu 200/2014/TT-BTC)
- **Dac diem**: nhieu tai khoan (7 tk), loai phat sinh

## Forms

### frmGLMAUBCTCTMVI09.cs
- **Ke thua**: frmDMComplexView
- **Chuc nang**: Hien thi danh sach cac chi tieu bao cao

### frmGLMAUBCTCTMVI09Edit.cs
- **Ke thua**: frmDMComplexEdit
- **Chuc nang**: Them/Sua/Xoa chi tieu bao cao

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMauQD | AsTextBox | mau | - |
| txtMa_chtieu | AsTextBox | ma_so | - |
| txtChi_tieu | TextBox | chi_tieu | - |
| txtNd_chtieu | TextBox | nd_chtieu | - |
| txtCach_tinh | TextBox | cach_tinh | - |
| ChkIs_print | CheckBox | IsPrint | - |
| ChkIs_italic | CheckBox | IsItalic | - |
| chkKsd | AsCheckBox | bold | - |
| txtTk1 | AsTextBox | tk_01 | - |
| lblTK1 | Label | - | - |
| txtTk2 | AsTextBox | tk_02 | - |
| lblTK2 | Label | - | - |
| txtTk3 | AsTextBox | tk_03 | - |
| lblTK3 | Label | - | - |
| txtTk4 | AsTextBox | tk_04 | - |
| lblTK4 | Label | - | - |
| txtTk5 | AsTextBox | tk_05 | - |
| lblTK5 | Label | - | - |
| txtTk6 | AsTextBox | tk_06 | - |
| lblTK6 | Label | - | - |
| txtTk7 | AsTextBox | tk_07 | - |
| lblTK7 | Label | - | - |
| cboLoai_ps | AsComboBox | loai_ps | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitBeforeGetData | - | void | Khoi tao du lieu truoc khi load |
| ValidData | - | bool | Kiem tra tinh hop le cua du lieu |
| InsertToDB | - | bool | Them moi vao database |
| DisableFields | - | void | Vo hieu hoa cac truong khi edit |
| DataBinding | - | void | Binding du lieu vao controls |

## Data Access

### DanhMucDAO
- **Interface**: IDanhMucDAO
- **Implementation**: MssqlDanhMucDAO

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GetDanhMuc | ma_dm, mau | DataTable | Lay danh sach chi tieu |
| SaveData | sp_SaveDanhMuc | data XML | bool | Luu chi tieu |
| DeleteData | sp_DeleteDanhMuc | ma_so, mau | bool | Xoa chi tieu |

## Stored Procedures duoc goi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GetDanhMuc | Lay danh sach chi tieu | ma_dm, mau | DataTable |
| sp_SaveDanhMuc | Luu chi tieu | data XML | bool |
| sp_DeleteDanhMuc | Xoa chi tieu | ma_so, mau | bool |

## Business Logic

### Luong xu ly chinh
1. Load form: Goi InitBeforeGetData de khoi tao
2. Nhap du lieu: Nhap ma chi tieu, chi tieu, noi dung
3. Chon tai khoan: Nhap ma tai khoan (co lookup)
4. Chon loai phat sinh (neu co): Chon tu dropdown
5. Validation: Kiem tra du lieu hop le
6. Save: Luu vao database

### Validation rules
- Ma chi tieu khong duoc de trong
- Chi tieu khong duoc de trong
- Mau mac dinh lay tu CompanyInformations.Qd_cdkt

### Loai phat sinh (neu co)
| Key | Value |
|-----|-------|
| NODK | Du no dau ky |
| CODK | Du co dau ky |
| NOCK | Du no cuoi ky |
| COCK | Du co cuoi ky |
| PSNO | Phat sinh no |
| PSCo | Phat sinh co |

## Tables lien quan

| Table | Purpose | CRUD |
|-------|---------|------|
| dm_bctc | Danh muc bao cao tai chinh | R/U/D |
| dm_tk | Danh muc tai khoan | R |
| dm_spct | Danh muc san pham/cong trinh | R |

## Mapping sang PHP

### Controller
```php
class GLMAUBCTCTMVI09Controller extends Controller
{
    public function index()
    {
        // Hien thi danh sach
    }
    
    public function create()
    {
        // Form them moi
    }
    
    public function store(Request $request)
    {
        // Luu du lieu
    }
    
    public function edit($id)
    {
        // Form sua
    }
    
    public function update(Request $request, $id)
    {
        // Cap nhat
    }
    
    public function destroy($id)
    {
        // Xoa
    }
}
```

### Repository
```php
class GLMAUBCTCTMVI09Repository
{
    public function getData($maDm, $mau)
    {
        return DB::select('EXEC sp_GetDanhMuc ?, ?', [$maDm, $mau]);
    }
    
    public function saveData($data)
    {
        $xml = $this->convertToXml($data);
        return DB::statement('EXEC sp_SaveDanhMuc ?', [$xml]);
    }
    
    public function deleteData($maSo, $mau)
    {
        return DB::statement('EXEC sp_DeleteDanhMuc ?, ?', [$maSo, $mau]);
    }
}
```

### Model
```php
class GLMAUBCTCTMVI09 extends Model
{
    protected $table = 'dm_bctc';
    protected $fillable = [
        'mau', 'ma_so', 'chi_tieu', 'nd_chtieu', 
        'cach_tinh', 'tk_01', 'tk_02', 'tk_03',
        'tk_04', 'tk_05', 'tk_06', 'tk_07',
        'loai_ps', 'ma_spct', 'IsPrint', 'IsItalic', 'bold'
    ];
}
```

## Ghi chu
- Day la form danh muc dung de quan ly mau bao cao tai chinh
- Ho tro nhieu tai khoan (toi da 7 tai khoan)
- Co the chon loai phat sinh de tinh toan so lieu
- Ho tro lookup tai khoan va cong trinh
- Format in: in dam, in nghieng, co in/khong in
