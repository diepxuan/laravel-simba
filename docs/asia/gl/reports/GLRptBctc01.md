# GlRptBctc01

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Bảng cân đối phát sinh các tài khoản (Trial Balance)
- **Assembly**: GlRptBctc01.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5
- **Company**: Asia Software Development JSC

## Forms

### frmGlRptBctc01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng cân đối phát sinh các tài khoản

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | Lookup TK | - |
| txtBac | AsTextNumeric | - | - |
| chkTK_sc | CheckBox | - | - |
| lblTk | Label | - | - |
| lblbac | Label | - | - |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |
| optVND | RadioButton | - | - |
| optNt | RadioButton | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| InitOtherComponents | - | void | Khởi tạo components |
| AsTabControl_SelectedIndexChanged | sender, e | void | Xử lý tab change |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Xử lý drill-down |

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu cân đối phát sinh | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pBac, @pTK_sc, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User nhập tài khoản (txtTk) - optional
3. User nhập bậc tài khoản (txtBac) - mặc định 9
4. User chọn "Lên cho tk sổ cái" (chkTK_sc)
5. User chọn loại tiền (VND/Ngoại tệ)
6. Click OK để xem báo cáo

### LoadData
Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Ngày bắt đầu (txtNgay1)
   - Ngày kết thúc (txtNgay2)
   - Tài khoản (txtTk)
   - Bậc tài khoản (txtBac)
   - Checkbox TK_sc
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập Parameters4DrillDown cho drill-down

### Drill-down
Hỗ trợ drill-down với các phím:
- **F5**: Drill-down đến sổ chữ T của tài khoản
- **Ctrl+F5**: Drill-down đến sổ chi tiết
- **Shift+F5**: Drill-down đến cân đối phát sinh công nợ (nếu tk_cn = 1)

### Tham số
- `txtBac`: In đến bậc tài khoản (mặc định 9)
- `chkTK_sc`: Lên cho tài khoản sổ cái
- `txtTk`: Lọc theo tài khoản cụ thể

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_cdkt | Dữ liệu cân đối phát sinh | R |
| Dmtk | Danh mục tài khoản | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `bac` | Bậc tài khoản |
| `ma_nt` | Mã ngoại tệ |
| `ngay_ct1`, `ngay_ct2` | Ngày chứng từ từ/đến |
| `TK_sc` | Tài khoản sổ cái |

## Phím tắt

| Phím | Chức năng |
|------|------------|
| F5 | Sổ chữ T |
| Ctrl+F5 | Sổ chi tiết |
| Shift+F5 | Cân đối phát sinh công nợ |
| F7 | Xem báo cáo |
| F9 | In báo cáo |

## Mapping sang PHP

### Controller
```php
class GlRptBctc01Controller extends ReportController {
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account_code,
            'bac' => $request->account_level ?? 9,
            'tk_sc' => $request->ledger_account ?? false,
            'ma_nt' => $request->currency_code
        ];
        return $this->service->getTrialBalanceData($params);
    }
}
```

### Repository
```php
class GlRptBctc01Repository {
    public function getTrialBalanceData($params) {
        return DB::select('EXEC sp_GetTrialBalance ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['bac'],
            $params['tk_sc'],
            $params['ma_nt']
        ]);
    }
}
```

## Ghi chú
- Báo cáo bảng cân đối phát sinh các tài khoản theo kỳ
- Hỗ trợ lọc theo bậc tài khoản
- Có thể xem chi tiết bằng drill-down
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng `AsTabControl` để chuyển đổi giữa filter và grid
