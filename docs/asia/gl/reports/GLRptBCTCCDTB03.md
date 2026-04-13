# GLRptBCTCCDTB03

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo tình hình thực hiện CCDT - Biểu 03 (Theo dõi chi phí theo bậc)

## Forms

### frmGLRptBCTCCDTB03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo tình hình thực hiện CCDT Biểu 03

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | Lookup TK | - |
| txtBacTk | AsTextNumeric | - | - |
| lblTen_Tk | Label | - | - |
| lblTk | Label | - | - |
| lblBacTk | Label | - | - |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| InitOtherComponents | - | void | Khởi tạo components |
| GetFilterTitle | - | string | Lấy tiêu đề filter |

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu CCDT | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pBacTk | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User nhập tài khoản (txtTk) - lấy từ MyMenuInfo.par1
3. User nhập bậc tài khoản (txtBacTk) - lấy từ MyMenuInfo.par2
4. Click OK để xem báo cáo

### Tham số
- `txtTk`: Tài khoản theo dõi chi phí CCDT (par1)
- `txtBacTk`: Bậc tài khoản (par2)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bctccdtb03 | Dữ liệu báo cáo CCDT | R |

## Mapping sang PHP

```php
class GLRptBCTCCDTB03Controller extends ReportController {
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account_code ?? $this->getDefaultParam('par1'),
            'bac_tk' => $request->account_level ?? $this->getDefaultParam('par2')
        ];
        return $this->service->getCCDT