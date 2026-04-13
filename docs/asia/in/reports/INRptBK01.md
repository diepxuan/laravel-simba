# INRptBK01.dll - Báo cáo bảng kê nhập xuất tồn kho

## Tổng quan
- **Module**: IN (Inventory)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng kê nhập xuất tồn kho theo tháng/năm

## Forms

### frmINRptBK01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê nhập xuất tồn kho

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMonth | AsTextNumeric | Tháng báo cáo | - |
| txtYear | AsTextNumeric | Năm báo cáo | - |
| txtMa_vt | AsTextBox | Mã vật tư (lookup MA_VT) | - |
| lblTen_vt | Label | Tên vật tư | - |
| txtMa_kho | AsTextBox | Mã kho (lookup MA_KHO) | - |
| lblTen_kho | Label | Tên kho | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | - |
| optVND | RadioButton | Hiển thị VND | - |
| optNt | RadioButton | Hiển thị ngoại tệ | - |
| cmdOk | Button | Thực hiện báo cáo | Click |
| cmdExcel | Button | Xuất Excel | Click |
| cmdCancel | Button | Hủy | Click |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo tháng/năm mặc định là hiện tại |
| ValidData | - | bool | Validate tháng (1-12), năm > 0 |
| LoadData | - | bool | Gọi SP lấy dữ liệu báo cáo |
| GetFilterTitle | - | string | Trả về chuỗi điều kiện lọc cho report |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_INRptBK01 | Lấy dữ liệu báo cáo | @ma_cty, @nam, @thang, @ma_vt, @ma_kho | DataTable |

## Business Logic

### Luồng xử lý chính
1. **Nhập điều kiện**: Tháng, Năm, Mã vật tư (tùy chọn), Mã kho (tùy chọn)
2. **Validate**: Tháng phải 1-12, Năm > 0
3. **Gọi SP**: sp_INRptBK01 với các tham số
4. **Hiển thị**: Kết quả trên DataGridView

### Cấu trúc dữ liệu báo cáo
Bảng kê nhập xuất tồn kho hiển thị:
- Mã vật tư, Tên vật tư, ĐVT
- Tồn đầu kỳ (số lượng, giá trị)
- Nhập trong kỳ (số lượng, giá trị)
- Xuất trong kỳ (số lượng, giá trị)
- Tồn cuối kỳ (số lượng, giá trị)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| inctvt | Chi tiết vật tư (nhập/xuất) | R |
| inthvt | Tổng hợp vật tư | R |
| dmvt | Danh mục vật tư | R |
| dmkho | Danh mục kho | R |

## Mapping sang PHP

### Controller
```php
// app/Http/Controllers/Inventory/Reports/BangKeController.php
namespace App\Http\Controllers\Inventory\Reports;

class BangKeController extends Controller
{
    public function index()
    {
        return view('inventory.reports.bang-ke.index');
    }
    
    public function generate(BangKeRequest $request)
    {
        $data = DB::select('EXEC sp_INRptBK01 ?, ?, ?, ?, ?', [
            $request->company_id,
            $request->year,
            $request->month,
            $request->ma_vt ?? '',
            $request->ma_kho ?? ''
        ]);
        
        return view('inventory.reports.bang-ke.result', compact('data'));
    }
    
    public function exportExcel(BangKeRequest $request)
    {
        $data = DB::select('EXEC sp_INRptBK01 ?, ?, ?, ?, ?', [
            $request->company_id,
            $request->year,
            $request->month,
            $request->ma_vt ?? '',
            $request->ma_kho ?? ''
        ]);
        
        return Excel::download(new BangKeExport($data), 'bang-ke-nhap-xuat-ton.xlsx');
    }
}
```

### Form Request
```php
// app/Http/Requests/Inventory/Reports/BangKeRequest.php
class BangKeRequest extends FormRequest
{
    public function rules()
    {
        return [
            'month' => 'required|integer|between:1,12',
            'year' => 'required|integer|min:0',
            'ma_vt' => 'nullable|string|max:20',
            'ma_kho' => 'nullable|string|max:20',
        ];
    }
}
```

## Ghi chú
- Báo cáo có thể lọc theo vật tư và kho cụ thể
- Hỗ trợ xuất Excel
- Có thể chọn hiển thị VND hoặc ngoại tệ
