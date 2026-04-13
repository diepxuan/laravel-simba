# GLRptBCT02

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Bảng kê thuế GTGT đầu ra (Output VAT Report)

## Forms

### frmGLRptBCT02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê thuế GTGT đầu ra

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
| sFilt | string | Filter expression |
| excelapp | Application | Excel Application |
| wBook | Workbook | Excel Workbook |
| wSheet | Worksheet | Excel Worksheet |
| colIndex | int | Column index |
| rowIndex | int | Row index |
| startIndex | int | Start row (18) |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| Ex2Excel_HTKK | - | void | Export sang Excel HTKK |
| WriteOneGroupData | sFilt, sNextGroupTitle | void | Ghi nhóm dữ liệu ra Excel |

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu thuế GTGT đầu ra | @pMa_cty, @pNgay1, @pNgay2, @pThue_suat, @pTk, @pTk_Du, @pMa_Bp, @pMau_bc | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User nhập thuế suất, tài khoản thuế, tài khoản đối ứng, mã bộ phận
3. User chọn mẫu báo cáo
4. Click OK để xem báo cáo

### Export Excel HTKK
- Sử dụng template `uTaOut.xls`
- Xuất file: `BangKeThueRa_Thang{X}_Nam_{Y}.xls`

### Các nhóm dữ liệu (theo mã thuế)
- `ma_thue='KT'`: Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 0%
- `ma_thue='00'`: Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 5%
- `ma_thue='05'`: Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 10%
- `ma_thue='10'`: Hàng hóa, dịch vụ chịu thuế suất thuế GTGT khác
- `kct=1 and tong_hop=0`: Hàng hóa, dịch vụ không phải tổng hợp

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| Ct | Chứng từ | R |
| Ctgt | Chi tiết giá thành/chứng từ | R |
| Dmthue | Danh mục thuế | R |

## Mapping sang PHP

### Controller
```php
class GLRptBCT02Controller extends ReportController {
    public function exportHTKK(Request $request) {
        $data = $n        $this->service->getVatOutputData($request->all());
        return Excel::download(new VATOutputExport($data), 'BangKeThueRa.xlsx');
    }
}
```

## Ghi chú
- Export Excel theo mẫu HTKK cho thuế GTGT đầu ra
- Có thể lọc theo thuế suất, tài khoản, bộ phận
- Phân loại theo các mã thuế GTGT khác nhau
