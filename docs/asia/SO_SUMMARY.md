# SO_SUMMARY - Tổng quan Module Sales Order

## Tổng quan

Module **Sales Order (SO)** quản lý toàn bộ quy trình bán hàng trong hệ thống Asia ERP, từ khâu tiếp nhận đơn hàng đến khi giao hàng, lập hóa đơn và xử lý trả hàng.

## Thống kê DLL

### Chứng từ chính (Vouchers)

| STT | DLL | Tên | Loại |
|-----|-----|-----|------|
| 1 | SOVchSO1.dll | Đơn hàng bán | Voucher |
| 2 | SOVchSO3.dll | Phiếu xuất kho / Hóa đơn | Voucher |
| 3 | SOVchSO3_.dll | Phiếu xuất kho (barcode) | Voucher |
| 4 | SOVchSO4.dll | Phiếu nhập trả hàng | Voucher |
| 5 | SOVchSO5.dll | Hóa đơn dịch vụ | Voucher |

### Danh mục (Categories)

| STT | DLL | Tên | Mô tả ngắn |
|-----|-----|-----|------------|
| 1 | SODMCK.dll | Chuyển khoản | TK thanh toán |
| 2 | SODMDGVT.dll | Đơn giá vật tư | Lịch sử giá |
| 3 | SODMDKTT.dll | Điều khoản thanh toán | Hạn CK, chiết khấu |
| 4 | SODMGIABAN.dll | Giá bán | Giá theo KH/VT |
| 5 | SODMHHKM.dll | Hàng khuyến mãi | CT khuyến mãi |
| 6 | SODMHTTT.dll | Hình thức thanh toán | TM/CK/Thẻ |
| 7 | SODMKM.dll | Khuyến mãi | Chương trình KM |
| 8 | SODMNVKD.dll | Nhân viên KD | NVKD & target |
| 9 | SODMPTVT.dll | Phương tiện vận tải | Thông số xe |
| 10 | SODMTD.dll | Tuyến đường | Khoảng cách |
| 11 | SODMTKM.dll | Trả khuyến mãi | Chính sách KM |
| 12 | SODMTS.dll | Thuế suất | Thuế GTGT |

### Quản lý hóa đơn (SOND51)

| STT | DLL | Tên | Nhóm |
|-----|-----|-----|------|
| 1 | SOND51adhd.dll | Quyết định áp dụng HD | Danh mục |
| 2 | SOND51dmmhd.dll | Danh mục mẫu hóa đơn | Danh mục |
| 3 | SOND51mhd.dll | Khổ in hóa đơn | Danh mục |
| 4 | SOND51mathd.dll | Mã hóa đơn | Danh mục |
| 5 | SOND51phhd.dll | Phát hành hóa đơn | Danh mục |
| 6 | SOND51bmhd.dll | Bảo mật hóa đơn | Tiện ích |
| 7 | SOND51HuyHD.dll | Hủy hóa đơn | Thông báo |
| 8 | SOND51bkhd.dll | Bảng kê hóa đơn | Thông báo |
| 9 | SOND51mchhd.dll | Mất cháy hỏng | Thông báo |
| 10 | SOND51xoahd.dll | Xóa hóa đơn | Thông báo |
| 11 | SOND51dmqdadhd.dll | DM quyết định áp dụng | Danh mục |

### Báo cáo (Reports)

| STT | DLL | Tên | Loại |
|-----|-----|-----|------|
| 1 | SORptBCPT03.dll | Phân tích bán hàng 03 | Phân tích |
| 2 | SORptBCPT04.dll | Phân tích bán hàng 04 | Phân tích |
| 3 | SORptBCPT06.dll | Phân tích bán hàng 06 | Phân tích 2 chiều |
| 4 | SORptTH01.dll | Tổng hợp bán hàng 01 | Tổng hợp |
| 5 | SORptTH02.dll | Tổng hợp bán hàng 02 | Theo kỳ |
| 6 | SORptBK01.dll | Bảng kê chứng từ | Bảng kê |
| 7 | SORptBK02.dll | Bảng kê nhóm | Bảng kê |
| 8 | SORptLaiLo.dll | Lãi lỗ | Tài chính |
| 9 | SORptF5BCPT03.dll | Drill-down BCPT03 | Drill-down |
| 10 | SORptF5BCPT04.dll | Drill-down BCPT04 | Drill-down |
| 11 | SORptF5BCPT06.dll | Drill-down BCPT06 | Drill-down |
| 12 | SORptF5TH0.dll | Drill-down tổng hợp | Drill-down |

### Tiện ích (Utilities)

| STT | DLL | Tên | Mô tả |
|-----|-----|-----|-------|
| 1 | SOUtilities.dll | Tiện ích bán hàng | Pricing, lookup, print |
| 2 | SOTaOut.dll | Thuế đầu ra | Quản lý hóa đơn đầu ra |

## Tổng số DLL

| Loại | Số lượng |
|------|----------|
| Vouchers | 5 |
| Danh mục | 12 |
| Quản lý hóa đơn | 11 |
| Báo cáo | 12 |
| Tiện ích | 2 |
| **Tổng** | **42** |

## Luồng nghiệp vụ chính

### 1. Bán hàng chuẩn
```
Khách đặt hàng → SO1 (Đơn hàng) → SO2 (Xuất kho) → SO3 (Hóa đơn) → CA (Thu tiền)
```

### 2. Bán hàng dịch vụ
```
Khách yêu cầu → SO5 (Hóa đơn dịch vụ) → CA (Thu tiền)
```

### 3. Trả hàng
```
SO3 (Hóa đơn gốc) → SO4 (Nhập trả hàng) → Điều chỉnh công nợ
```

### 4. Hóa đơn kiêm phiếu xuất
```
SO1 (Đơn hàng) → SO3 (Hóa đơn + Xuất kho)
```

## Các chức năng đặc biệt

### 1. Quản lý giá bán
- Giá bán chung cho tất cả khách hàng
- Giá bán riêng theo từng khách hàng
- Giá bán theo nhóm khách hàng
- Lịch sử giá theo thời gian
- Đa tiền tệ

### 2. Chiết khấu
- Chiết khấu mặt hàng (theo từng dòng)
- Chiết khấu doanh số (theo tổng đơn)
- Chiết khấu thanh toán sớm (theo điều khoản)

### 3. Khuyến mãi
- Chương trình khuyến mãi theo thời gian
- Tặng hàng khi mua đủ điều kiện
- Combo giá ưu đãi

### 4. Quản lý hóa đơn
- Phát hành hóa đơn với cơ quan thuế
- Thông báo hủy, mất, cháy, hỏng
- Bảng kê hóa đơn hết giá trị
- Bảo mật, xác thực hóa đơn

### 5. Báo cáo & Phân tích
- Phân tích bán hàng theo nhiều chiều
- Drill-down từ tổng quan đến chi tiết
- Báo cáo lãi lỗ theo hợp đồng
- Bảng kê chứng từ master-detail

## Tích hợp với module khác

| Module | Tích hợp |
|--------|----------|
| IN (Inventory) | Kiểm tra tồn kho, cập nhật xuất/nhập |
| AR (Account Receivable) | Công nợ khách hàng, thu tiền |
| GL (General Ledger) | Hạch toán kế toán tự động |
| CA (Cash Advance) | Thu tiền, báo có |

## Cấu trúc dữ liệu chính

### Bảng chứng từ

| Bảng | Mô tả |
|------|-------|
| SO1 | Đơn hàng bán (Header) |
| SO2 | Đơn hàng bán (Detail) |
| SO3 | Hóa đơn bán hàng (Header) |
| SO4 | Hóa đơn bán hàng (Detail) |
| SO5 | Phiếu nhập trả hàng |
| SO6 | Hóa đơn dịch vụ |

### Bảng danh mục

| Bảng | Mô tả |
|------|-------|
| dmck | Chuyển khoản |
| dmdgvt | Đơn giá vật tư |
| dmtt | Điều khoản thanh toán |
| dmgiaban | Giá bán |
| dmhhkm | Hàng khuyến mãi |
| dmhttt | Hình thức thanh toán |
| dmkm | Khuyến mãi |
| dmnvkd | Nhân viên KD |
| dmptvt | Phương tiện vận tải |
| dmtd | Tuyến đường |
| dmtkm | Trả khuyến mãi |
| dmts | Thuế suất |

## Cấu trúc Voucher SO

### Forms chính
1. **frmSoVchSO[X].cs** - Form nhập liệu chính
2. **frmSoVchSO[X]Find.cs** - Form tìm kiếm
3. **frmSoVchSO[X]FindSO[Y].cs** - Form tìm kiếm đơn hàng
4. **frmSoVchSO[X]SeachSO[Y].cs** - Form xem danh sách đơn hàng
5. **frmSoVchSO[X]ViewCrystal.cs** - Form xem báo cáo

### Các control chuẩn
- **AsTextBox**: Textbox có chức năng lookup
- **AsTextNumeric**: Textbox nhập số
- **AsMaskedTextBox**: Textbox có mask (ngày tháng)
- **AsComboBoxNT**: Combobox ngoại tệ
- **AsCheckBox**: Checkbox
- **AsInputDGV**: DataGridView nhập liệu

### Grid chi tiết chuẩn

| Field | Mô tả |
|-------|-------|
| ma_vt | Mã vật tư |
| ten_vt | Tên vật tư |
| dvt | Đơn vị tính |
| ma_kho | Mã kho |
| so_luong | Số lượng |
| gia_nt2 | Giá bán ngoại tệ |
| tien_nt2 | Tiền bán ngoại tệ |
| tl_ck | Tỷ lệ chiết khấu |
| tien_ck_nt | Tiền chiết khấu NT |
| ts_gtgt | Thuế suất GTGT |
| thue_gtgt_nt | Thuế GTGT NT |
| gia2 | Giá bán |
| tien2 | Tiền bán |
| tien_ck | Tiền chiết khấu |
| thue_gtgt | Thuế GTGT |

## Business Logic

### Tính toán tiền
```
Tiền bán = Số lượng × Giá bán
Tiền CK = Tiền bán × Tỷ lệ CK / 100
Tiền sau CK = Tiền bán - Tiền CK
Thuế GTGT = Tiền sau CK × Thuế suất / 100
Thành tiền = Tiền sau CK + Thuế GTGT
```

### Quy đổi ngoại tệ
```
Tiền VND = Tiền ngoại tệ × Tỷ giá
Giá VND = Giá ngoại tệ × Tỷ giá
```

### Tính giá vốn
- Lấy từ phương pháp tính giá vốn (FIFO, LIFO, BQGQ...)
- Hoặc nhập tay nếu cho phép

## Tables liên quan chi tiết

### Header tables
- SoPh1: Phiếu bán hàng header
- SoPh2: Phiếu bán hàng header (bổ sung)
- SoPh3: Phiếu bán hàng header (thuế)

### Detail tables
- SoCt1: Chi tiết bán hàng
- SoCt2: Chi tiết bán hàng (bổ sung)
- SoCt3: Chi tiết bán hàng (thuế)

### Danh mục liên quan
- DmKh: Danh mục khách hàng
- DmVt: Danh mục vật tư
- DmKho: Danh mục kho
- DmBp: Danh mục bộ phận
- DmNvkd: Danh mục NVKD
- DmHttt: Danh mục HTTT

## Mapping sang PHP

### Controller Pattern
```php
class SOVchSO3Controller extends VoucherController
{
    protected $voucherCode = 'SO3';
    
    public function index()
    {
        // List view
    }
    
    public function create()
    {
        // Create form
    }
    
    public function store(Request $request)
    {
        // Save voucher
    }
    
    public function edit($id)
    {
        // Edit form
    }
    
    public function update(Request $request, $id)
    {
        // Update voucher
    }
    
    public function destroy($id)
    {
        // Delete voucher
    }
}
```

### Repository Pattern
```php
class SOVchSO3Repository extends VoucherRepository
{
    protected $headerTable = 'SoPh1';
    protected $detailTable = 'SoCt1';
    
    public function getById($id)
    {
        // Get voucher by ID
    }
    
    public function save($data)
    {
        // Save with validation
    }
    
    public function delete($id)
    {
        // Delete with constraints
    }
    
    public function search($filters)
    {
        // Search vouchers
    }
}
```

### Model Pattern
```php
class SoPh1 extends Model
{
    protected $table = 'SoPh1';
    protected $primaryKey = 'stt_rec';
    
    public function details()
    {
        return $this->hasMany(SoCt1::class, 'stt_rec', 'stt_rec');
    }
    
    public function customer()
    {
        return $this->belongsTo(DmKh::class, 'ma_kh', 'ma_kh');
    }
}
```

## Stored Procedures

### Voucher SP
- asSOGetSoPh: Lấy thông tin phiếu
- asSOGetSoCt: Lấy chi tiết phiếu
- asSOSaveSoPh: Lưu phiếu
- asSODeleteSoPh: Xóa phiếu
- asSOGetSo4SO: Lấy phiếu liên quan

### Report SP
- asSORptBCPT03: Báo cáo chi phí VT+KH
- asSORptBCPT04: Báo cáo chi phí BP+VT
- asSORptBCPT06: Báo cáo chi phí NVKD
- asSORptBK01: Sổ chi tiết BH
- asSORptBK02: Sổ chi tiết theo CT
- asSORptTH01: Tổng hợp BH
- asSORptTH02: Tổng hợp BH theo KH

## Ghi chú phát triển

### Validation Rules
1. Ngày chứng từ phải trong kỳ làm việc
2. Khách hàng phải tồn tại
3. Vật tư phải tồn tại
4. Kho phải tồn tại
5. Số lượng phải > 0
6. Giá bán phải >= 0
7. TK phải thu phải là TK công nợ
8. TK thuế phải là TK thuế

### Calculation Rules
1. Tính tiền trước, thuế sau
2. Chiết khấu trên từng dòng
3. Thuế GTGT sau chiết khấu
4. Làm tròn theo cấu hình đồng tiền
5. Quy đổi ngoại tệ theo tỷ giá

### Security
1. Kiểm tra quyền truy cập
2. Kiểm tra quyền thêm/sửa/xóa
3. Kiểm tra kỳ khóa sổ
4. Kiểm tra dữ liệu đã duyệt

## Version & Framework

| Thông tin | Giá trị |
|-----------|---------|
| Framework | .NET Framework 3.5 / .NET 9.1 |
| UI | Windows Forms |
| Database | SQL Server |
| Reporting | Crystal Reports |
| Pattern | DAO, MVC |

## Kết luận

Module Sales Order là module phức tạp và quan trọng nhất trong hệ thống Asia ERP, với:
- **42 DLL** xử lý toàn bộ nghiệp vụ bán hàng
- **6 chứng từ** chính (SO1, SO2, SO3, SO3_, SO4, SO5)
- **12 danh mục** hỗ trợ
- **11 chức năng** quản lý hóa đơn
- **12 báo cáo** phân tích và tổng hợp
- **2 tiện ích** dùng chung

Module tích hợp chặt chẽ với tồn kho, công nợ và kế toán tổng hợp, đảm bảo luồng dữ liệu xuyên suốt từ đơn hàng đến báo cáo tài chính.