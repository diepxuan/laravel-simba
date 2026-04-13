# GLRptBCT01

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Bảng kê thuế GTGT đầu vào (Input VAT Report)

## Forms

### frmGLRptBCT01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê thuế GTGT đầu vào

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtThue_suat | AsTextNumeric | - | - |
| txtTk | AsTextBox | Lookup TK | - |
| txtTk_Du | AsTextBox | Lookup TK | - |
| txtMa_Bp | AsTextBox | Lookup MA_BP | - |
| lblTen_Tk | Label | - | - |
| lblTen_Tk_Du | Label | - | - |
| lblTen_Bp | Label | - | - |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| excelapp | Application | Đối tượng Excel cho export |
| wBook | Workbook | Workbook Excel |
| wSheet | Worksheet | Worksheet Excel |
| colIndex | int | Vị trí cột Excel |
| rowIndex | int | Vị trí dòng Excel |
| startIndex | int | Dòng bắt đầu (18) |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| Ex2Excel_HTKK | - | void | Export sang Excel HTKK |
| WriteOneGroupData | sMau_bc, sNextGroupTitle | void | Ghi nhóm dữ liệu ra Excel |
| InitOtherComponents | - | void | Khởi tạo components |

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu thuế GTGT đầu vào | @pMa_cty, @pNgay1, @pNgay2, @pThue_suat, @pTk, @pTk_Du, @pMa_Bp, @pMau_bc | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User nhập thuế suất (txtThue_suat)
3. User nhập tài khoản thuế (txtTk) và tài khoản đối ứng (txtTk_Du)
4. User nhập mã bộ phận (txtMa_Bp) - optional
5. User chọn mẫu báo cáo
6. Click OK để xem báo cáo

### Export Excel HTKK
- Sử dụng template `uTaIn.xls`
- Xuất file: `BangKeThueVao_Thang{X}_Nam_{Y}.xls`
- Format theo chuẩn HTKK của Tổng cục Thuế

### Các nhóm dữ liệu
1. Hàng hóa, dịch vụ không đủ điều kiện khấu trừ
2. Hàng hóa, dịch vụ dùng chung cho SXKD chịu thuế và không chịu thuế đủ điều kiện khấu trừ
3. Hàng hóa, dịch vụ dùng cho dự án đầu tư đủ điều kiện khấu trừ
4. Hàng hóa, dịch vụ không phải tổng hợp trên tờ khai 01/GTGT

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| Ct | Chứng từ | R |
| Ctgt | Chi tiết giá thành/chứng từ | R |
| Dmthue | Danh mục thuế | R |

## Mapping sang PHP

### Controller
```php
class GLRptBCT01Controller extends ReportController {
    public function exportHTKK(Request $request) {
        $data = $this->service->getVatInputData($request->all());
        return Excel::download(new VATInputExport($data), 'BangKeThueVao.xlsx');
    }
}
```

### Service
```php
class GLRptBCT01Service {
    public function getVatInputData($params) {
        return DB::select('EXEC sp_GetVATInput ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['date_from'],
            $params['date_to'],
            $params['tax_rate'],
            $params['tax_account'],
            $params['contra_account'],
            $params['dept_code'],
            $params['report_template']
        ]);
    }
}
```

## Ghi chú
- Export Excel theo mẫu HTKK (phần mềm hỗ trợ kê khai thuế)
- Có thể lọc theo thuế suất, tài khoản, bộ phận
- Hỗ trợ nhiều mẫu báo cáo khác nhau
