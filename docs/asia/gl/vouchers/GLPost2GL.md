# GLPost2GL.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Utility - Posting
- **Chức năng**: Chuyển số liệu chứng từ từ các module khác (AP, AR, CA, IN, PO, SO) vào sổ cái (GL)

## Forms

### frmGLPost2GL.cs
- **Kế thừa**: frmAsiaRoot
- **Chức năng**: Form chính hiển thị danh sách chứng từ cần chuyển vào sổ cái

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboCT | AsComboBox | VoucherInfoDatasource | SelectedValueChanged |
| lblCT | Label | - | - |
| lblFrom_To | Label | - | - |
| cmdOK | Button | - | Click |
| cmdCancel | Button | - | Click |
| chkSelectAll | AsCheckBox | - | CheckedChanged |
| bgWork | BackgroundWorker | - | DoWork, ProgressChanged, RunWorkerCompleted |
| prbExecute | ProgressBar | - | - |
| dgvCT | AsDataGridView | f_tblCT.DefaultView | - |

#### DataGridView Columns
| Column | Type | DataPropertyName | Purpose |
|--------|------|------------------|---------|
| colChuyen | DataGridViewCheckBoxColumn | post2gl | Checkbox chọn chuyển |
| colMa_ct | DataGridViewTextBoxColumn | ma_ct | Mã chứng từ |
| colSo_ct | DataGridViewTextBoxColumn | so_ct | Số chứng từ |
| colNgay_ct | DataGridViewAsMaskedTextBoxColumn | ngay_ct | Ngày chứng từ |
| colMa_kh | DataGridViewTextBoxColumn | ma_kh | Mã khách hàng |
| colTen_kh | DataGridViewTextBoxColumn | ten_kh | Tên khách hàng |
| colMa_nt | DataGridViewTextBoxColumn | ma_nt | Mã ngoại tệ |
| colSum_money | DataGridViewAsTextNumericColumn | t_tien | Tổng tiền |
| colSum_money_nt | DataGridViewAsTextNumericColumn | t_tien_nt | Tổng tiền ngoại tệ |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| f_tblCT | DataTable | Bảng chứa dữ liệu chứng từ |
| dtmNgay1 | DateTime | Ngày bắt đầu filter |
| dtmNgay2 | DateTime | Ngày kết thúc filter |
| strSo_ct1 | string | Số chứng từ từ |
| strSo_ct2 | string | Số chứng từ đến |
| strPost | string | Trạng thái post (0: chưa, 1: đã) |
| strMa_ct | string | Mã chứng từ filter |
| f_voucherList | List<VoucherInfoDatasource> | Danh sách loại chứng từ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| frmGLPost2GL_Load | sender, e | void | Load form, hiển thị filter dialog, lấy dữ liệu |
| frmGLPost2GL_Shown | sender, e | void | Kiểm tra và đóng form nếu không có dữ liệu |
| cmdOK_Click | sender, e | void | Xử lý chuyển số liệu được chọn |
| cmdCancel_Click | sender, e | void | Đóng form |
| chkSelectAll_CheckedChanged | sender, e | void | Chọn/bỏ chọn tất cả |
| cboCT_SelectedValueChanged | sender, e | void | Filter theo loại chứng từ |
| bgWork_DoWork | sender, DoWorkEventArgs | void | Xử lý post trong background |
| bgWork_ProgressChanged | sender, ProgressChangedEventArgs | void | Cập nhật progress bar |
| bgWork_RunWorkerCompleted | sender, RunWorkerCompletedEventArgs | void | Hoàn thành xử lý |
| Post2Gl | object oDrw | int | Gọi SP post cho từng chứng từ |
| GetPercent | int i | int | Tính phần trăm tiến độ |
| SetPrbVisible | - | void | Ẩn/hiện progress bar |
| SetPrbValue | int intVal | void | Set giá trị progress bar |
| disableButtons | - | void | Enable/disable buttons |

### frmGLPost2GLFilter.cs
- **Kế thừa**: frmDMFilter
- **Chức năng**: Form filter điều kiện lọc chứng từ

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtSo_ct1 | TextBox | - | - |
| txtSo_ct2 | TextBox | - | - |
| cboMa_ct | AsComboBox | f_voucherList | - |
| cboStatus | AsComboBox | - | - |
| cboKyBc | ComboBox | KyBaoCao | SelectedValueChanged |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| f_strMa_ph | string | Mã phân hệ |
| f_strMa_ct | string | Mã chứng từ |
| f_strNhan_in | string | Nhãn in khoảng thời gian |
| f_voucherList | List<VoucherInfoDatasource> | Danh sách chứng từ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| frmGLPost2GLFilter_Load | sender, e | void | Init kỳ báo cáo, combobox |
| initCbo | - | void | Load danh sách chứng từ |
| cboKyBc_SelectedValueChanged | sender, e | void | Cập nhật ngày theo kỳ |
| InitKyBaoCao | - | void | Khởi tạo kỳ báo cáo |
| SaveKyBaoCao | - | void | Lưu kỳ báo cáo vào public variables |
| ValidData | - | bool | Validate dữ liệu (kiểm tra ngày khóa sổ) |

### VoucherInfoDatasource.cs
- **Chức năng**: Data class chứa thông tin chứng từ
- **Properties**: ma_ct, ten_ct

## Data Access

### IGLPost2GLDAO.cs
- **Interface**: DAO
- **Methods**:
  - `GetSiCt4PostGl(string pMa_cty, string pMa_ph, string pMa_ct, string pLang)`: Lấy danh sách chứng từ
  - `GetVoucher2Post(...)`: Lấy danh sách chứng từ cần post
  - `Post2GL(string pMa_cty, string pStt_rec, string pMa_ct, string pPost)`: Thực hiện post/unpost

### MssqlGLPost2GLDAO.cs
- **Implementation**: MsSqlDAO, IGLPost2GLDAO

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetVoucher2Post | asGetVoucher2Post | @pMa_cty, @pNgay1, @pNgay2, @pSo_ct1, @pSo_ct2, @pMa_CtLst, @pPost2gl | DataSet | Lấy chứng từ cần post |
| Post2GL | asPost2Gl | @pMa_cty, @pStt_rec, @pMa_ct, @pPostUnpost | int | Post/unpost chứng từ |
| GetSiCt4PostGl | asSiGetCt4PostGL | @pMa_cty, @pMa_ph, @pMa_ct, @pLanguageId | List<VoucherInfoDatasource> | Lấy danh sách loại CT |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asGetVoucher2Post | Lấy danh sách chứng từ theo điều kiện | pMa_cty, pNgay1, pNgay2, pSo_ct1, pSo_ct2, pMa_CtLst, pPost2gl | DataTable |
| asPost2Gl | Post/Unpost chứng từ vào GL | pMa_cty, pStt_rec, pMa_ct, pPostUnpost | int (return code) |
| asSiGetCt4PostGL | Lấy danh sách loại chứng từ | pMa_cty, pMa_ph, pMa_ct, pLanguageId | DataTable |

## Business Logic

### Luồng xử lý chính
1. User mở form -> Hiển thị filter dialog
2. User chọn điều kiện lọc (kỳ, ngày, số CT, trạng thái, loại CT)
3. Hệ thống gọi `asGetVoucher2Post` lấy danh sách chứng từ
4. Hiển thị danh sách trên DataGridView
5. User chọn chứng từ cần post (checkbox)
6. Click "Thực hiện" -> BackgroundWorker xử lý post từng chứng từ
7. Gọi `asPost2Gl` cho mỗi chứng từ được chọn
8. Hiển thị progress bar và thông báo kết quả

### Validation rules
- Ngày chứng từ phải >= ngày khóa sổ
- Phải chọn ít nhất 1 chứng từ để post

### Multi-threading
- Sử dụng BackgroundWorker để post không block UI
- Sử dụng ThreadPool.QueueUserWorkItem để xử lý song song
- ManualResetEvent để đợi tất cả threads hoàn thành

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| glPost2GL (view) | Danh sách chứng từ cần post | R |
| glCt | Chứng từ GL | R/U |
| glCtgt | Chi tiết chứng từ GL | R/U |
| apCt | Chứng từ AP | R/U |
| arCt | Chứng từ AR | R/U |
| caCt | Chứng từ CA | R/U |
| inCt | Chứng từ IN | R/U |
| poCt | Chứng từ PO | R/U |
| soCt | Chứng từ SO | R/U |

## Mapping sang PHP

### Controller
```php
class GLPost2GLController extends Controller {
    public function index() {
        return view('gl.post2gl.filter');
    }
    
    public function list(Request $request) {
        $vouchers = $this->repository->getVoucher2Post(
            $request->ngay1,
            $request->ngay2,
            $request->so_ct1,
            $request->so_ct2,
            $request->ma_ct,
            $request->post_status
        );
        return view('gl.post2gl.list', compact('vouchers'));
    }
    
    public function post(Request $request) {
        $results = $this->repository->post2GL($request->selected_vouchers);
        return response()->json(['results' => $results]);
    }
}
```

### Repository
```php
class GLPost2GLRepository {
    public function getVoucher2Post($ngay1, $ngay2, $so_ct1,