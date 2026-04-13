# GLRptTMBCTC

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo thuyết minh báo cáo tài chính (Thuyết minh BCTC)

## Forms

### frmGLRptTMBCTC.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo thuyết minh BCTC với khả năng tính toán, lưu số liệu và quản lý chỉ tiêu

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | Kỳ báo cáo | SelectedIndexChanged |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | ValueChanged |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | ValueChanged |
| cboMau_bc | ComboBox | Mẫu báo cáo | SelectedIndexChanged |
| cboFilter | ComboBox | Filter mẫu báo cáo | SelectedIndexChanged |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | TextChanged (hidden) |
| optVND | RadioButton | Loại tiền VND | CheckedChanged (hidden) |
| optNt | RadioButton | Loại tiền ngoại tệ | CheckedChanged (hidden) |
| txtTieu_De | TextBox | Tiêu đề báo cáo | TextChanged |
| cmdOk | Button | Thực thi báo cáo | Click |
| cmdCancel | Button | Hủy | Click |
| cmdExcel | Button | Xuất Excel | Click |
| cmdModifyReport | Button | Sửa mẫu báo cáo | Click |
| cmdDMCT | Button | Khai báo chỉ tiêu | Click |
| cmdLuu | Button | Lưu số liệu | Click |
| btnTinh_lai | Button | Tính lại | Click |
| splMain | SplitContainer | Container chia đôi | - |
| txtGhi_chu | TextBox | Ghi chú | TextChanged |
| dgvBC | AsDataGridView | Grid báo cáo | CellValueChanged |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| components | IContainer | Container cho components |
| sTabName | string | Tên tab/bảng báo cáo |
| sMenuID | string | Menu ID hiện tại |
| sMenuIDB | string | Menu ID trước đó |
| DataLoading | bool | Flag đang tải dữ liệu |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | none | void | Khởi tạo UI |
| InitOtherComponents | none | void | Khởi tạo thêm components, setup split container |
| LoadData | none | bool | Tải dữ liệu báo cáo |
| FormatGridView | none | void | Định dạng grid view, hiển thị ghi chú |
| ViewCrystalByConnection | none | void | View báo cáo Crystal qua connection |
| GetFilterTitle | none | string | Trả về chuỗi filter rỗng |
| cboMauBC_SelectedIndexChanged | sender, EventArgs | void | Xử lý khi đổi mẫu báo cáo |
| cmdDMCT_Click | sender, EventArgs | void | Mở form quản lý danh mục chỉ tiêu |
| cmdLuu_Click | sender, EventArgs | void | Lưu số liệu vào database |
| btnTinh_lai_Click | sender, EventArgs | void | Tính lại số liệu báo cáo |

### frmDMChiTieu.cs
- **Kế thừa**: frmDMComplexView
- **Chức năng**: Form quản lý danh mục chỉ tiêu thuyết minh

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | none | void | Khởi tạo UI |
| GetData | params | void | Lấy dữ liệu danh mục chỉ tiêu |

## Data Access

### COPBDAO.cs (Interface)
- **Interface**: COPBDAO
- **Implementation**: MsSqlCOPBDAO

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| Insert_BCTCTM | params object[] | int | Insert dữ liệu thuyết minh |
| Delete_BCTCTM | params object[] | int | Xóa dữ liệu thuyết minh |
| Cal_BCTCTM | params object[] | int | Tính toán lại dữ liệu |
| Get_BCTCTM | none | DataTable | Lấy thông tin báo cáo |

### MsSqlCOPBDAO.cs
- **Kế thừa**: MsSqlDAO
- **Implementation**: COPBDAO

#### Methods
| Method | SP Called | Input Params | Output |
|--------|-----------|--------------|--------|
| Insert_BCTCTM | Dynamic (from DAOInformation) | @pTab_Name, @pcol1, @pval1, ... | @pRet |
| Delete_BCTCTM | asGLRptBCTCTMDel | @pMa_cty, @pMau, @pNgay1, @pNgay2, @pTab_Name | @pRet |
| Cal_BCTCTM | asGLRptBCTCTMCal | @pMa_cty, @pMau, @pNgay1, @pNgay2, @pTab_Name | @pRet |
| Get_BCTCTM | asGetReportInfo | none | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Chọn mẫu báo cáo (cboMau_bc)
3. Click "Tính Lại" (btnTinh_lai) để tính toán số liệu:
   - Tính cho mẫu hiện tại (nếu chọn 1)
   - Tính cho tất cả các mẫu (nếu chọn 0)
4. Hoặc click cmdOk để xem báo cáo
5. Nếu mẫu != "X", cho phép chỉnh sửa và lưu số liệu
6. Click "Lưu số liệu" (cmdLuu) để lưu thay đổi

### Các loại mẫu báo cáo
- "X": Mẫu tổng hợp (không cho phép chỉnh sửa)
- Các mẫu khác: Cho phép chỉnh sửa và lưu số liệu

### Parameters cho tính toán/lưu
1. CompanyID - Mã công ty
2. Qd_cdkt - Quyết định CDKT
3. Ngày bắt đầu
4. Ngày kết thúc
5. Tab_Name - Tên bảng/mẫu báo cáo

### Xử lý lưu số liệu (cmdLuu_Click)
1. Xác nhận với người dùng (MessageBox)
2. Xóa dữ liệu cũ: Delete_BCTCTM()
3. Duyệt qua từng row trong DataGridView:
   - Insert_BCTCTM() cho mỗi row
   - Lưu giá trị từng cột
   - Cột "ghi_chu" lấy từ txtGhi_chu.Text
4. Hiển thị thông báo thành công

### Xử lý tính lại (btnTinh_lai_Click)
1. Hiển thị dialog chọn tùy chọn:
   - "0": Tính cho tất cả các mẫu
   - "1": Tính cho mẫu hiện tại
   - "2": Hủy
2. Gọi Cal_BCTCTM() với tham số tương ứng
3. Nếu mẫu = "X", hiển thị cảnh báo

### View báo cáo
- Nếu mẫu = 0 (mẫu đầu tiên): Dùng Crystal Report qua connection
- Các mẫu khác: Dùng DataGridView cho phép chỉnh sửa

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| CoPb | Chỉ tiêu thuyết minh | R/I/U/D |
| DmMauBc | Danh mục mẫu báo cáo | R |

## Mapping sang PHP

### Controller
```php
class GLRptTMBCTCController extends ReportController {
    protected $copbDao;
    
    public function __construct(COPBDAO $copbDao) {
        $this->copbDao = $copbDao;
    }
    
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GLRptTMBCTC');
        return view('gl.rpt_tm_bctc', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'qd_cdkt' => session('qd_cdkt'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'ky_bc' => $request->ky_bc
        ];
        
        if ($request->mau_bc == 0) {
            // Mẫu đầu tiên - dùng Crystal Report
            return $this->viewCrystalReport('GLRptTMBCTC', $params);
        } else {
            // Các mẫu khác - trả về data cho grid
            $data = $this->reportService->getTmbctcData($params);
            return response()->json(['data' => $data, 'editable' => true]);
        }
    }
    
    public function calculate(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'qd_cdkt' => session('qd_cdkt'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tab_name' => $request->tab_name
        ];
        
        if ($request->action == 'all') {
            // Tính cho tất cả các mẫu
            $templates = $this->getReportTemplates('GLRptTMBCTC');
            foreach ($templates as $template) {
                if ($template->ma_mau != 'X') {
                    $params['tab_name'] = $template->ma_mau;
                    $this->copbDao->Cal_BCTCTM($params);
                }
            }
        } else {
            // Tính cho mẫu hiện tại
            $this->copbDao->Cal_BCTCTM($params);
        }
        
        return response()->json(['success' => true]);
    }
    
    public function save(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'qd_cdkt' => session('qd_cdkt'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tab_name' => $request->tab_name
        ];
        
        // Xóa dữ liệu cũ
        $this->copbDao->Delete_BCTCTM($params);
        
        // Insert dữ liệu mới
        foreach ($request->rows as $row) {
            $insertParams = array_merge($params, $row);
            if (isset($insertParams['ghi_chu'])) {
                $insertParams['ghi_chu'] = $request->ghi_chu;
            }
            $this->copbDao->Insert_BCTCTM($insertParams);
        }
        
        return response()->json(['success' => true]);
    }
    
    public function openDMChiTieu(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'qd_cdkt' => session('qd_cdkt')
        ];
        $data = $this->copbDao->Get_BCTCTM($params);
        return view('gl.dm_chi_tieu', compact('data'));
    }
}
```

### Repository
```php
interface COPBDAO {
    public function Insert_BCTCTM(array $params): int;
    public function Delete_BCTCTM(array $params): int;
    public function Cal_BCTCTM(array $params): int;
    public function Get_BCTCTM(): array;
}

class MsSqlCOPBDAO implements COPBDAO {
    public function Insert_BCTCTM(array $params): int {
        $daoInfo = $this->getDAOInformation('glmaubctctm' . $params['tab_name']);
        $sql = $daoInfo['ins_sp'];
        // Build parameters dynamically
        $result = DB::select($sql, $params);
        return $result[0]->pRet ?? 0;
    }
    
    public function Delete_BCTCTM(array $params): int {
        $sql = "EXEC asGLRptBCTCTMDel ?, ?, ?, ?, ?";
        $result = DB::select($sql, [
            $params['ma_cty'],
            $params['qd_cdkt'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tab_name']
        ]);
        return $result[0]->pRet ?? 0;
    }
    
    public function Cal_BCTCTM(array $params): int {
        $sql = "EXEC asGLRptBCTCTMCal ?, ?, ?, ?, ?";
        $result = DB::select($sql, [
            $params['ma_cty'],
            $params['qd_cdkt'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tab_name']
        ]);
        return $result[0]->pRet ?? 0;
    }
    
    public function Get_BCTCTM(): array {
        $sql = "EXEC asGetReportInfo";
        return DB::select($sql);
    }
}
```

### View (Blade)
```php
<div id="tmBctcContainer">
    <div class="filter-section">
        <select name="ky_bc" id="cboKyBc">
            @foreach($kyBaoCaoOptions as $option)
                <option value="{{ $option->ma }}">{{ $option->ten_ky }}</option>
            @endforeach
        </select>
        
        <input type="date" name="ngay1" id="txtNgay1">
        <input type="date" name="ngay2" id="txtNgay2">
        
        <select name="mau_bc" id="cboMauBc">
            @foreach($mauBaoCaoOptions as $mau)
                <option value="{{ $mau->ma_mau }}">{{ $mau->ten_mau }}</option>
            @endforeach
        </select>
        
        <button id="btnTinhLai">Tính Lại</button>
        <button id="btnXem">Xem báo cáo</button>
    </div>
    
    <div class="toolbar">
        <button id="btnDMCT">Khai báo CT</button>
        <button id="btnLuu">Lưu số liệu</button>
    </div>
    
    <div class="split-container">
        <div class="grid-section">
            <table id="dgvBC" class="editable-grid">
                <!-- Dynamic columns -->
            </table>
        </div>
        <div class="note-section">
            <textarea id="txtGhiChu" placeholder="Ghi chú..."></textarea>
        </div>
    </div>
</div>

<script>
// Xử lý tính lại
document.getElementById('btnTinhLai').addEventListener('click', function() {
    const action = confirm('Tính cho tất cả các mẫu?') ? 'all' : 'current';
    fetch('/gl/rpt-tm-bctc/calculate', {
        method: 'POST',
        body: JSON.stringify({ action, ...getFormData() })
    });
});

// Xử lý lưu
document.getElementById('btnLuu').addEventListener('click', function() {
    const rows = getGridData();
    fetch('/gl/rpt-tm-bctc/save', {
        method: 'POST',
        body: JSON.stringify({ rows, ghi_chu: document.getElementById('txtGhiChu').value, ...getFormData() })
    });
});
</script>
```

## Ghi chú
- Đây là báo cáo thuyết minh BCTC phức tạp nhất trong module GL
- Có khả năng tính toán, lưu số liệu và quản lý chỉ tiêu
- Sử dụng SplitContainer để chia màn hình: grid trên, ghi chú dưới
- Có 2 form: frmGLRptTMBCTC (báo cáo) và frmDMChiTieu (quản lý chỉ tiêu)
- Mẫu "X" là mẫu tổng hợp, không cho phép chỉnh sửa
- Các SP sử dụng: asGLRptBCTCTMDel, asGLRptBCTCTMCal, asGetReportInfo
- Insert_BCTCTM sử dụng SP động từ DAOInformation
