# Nhóm stored procedures asRpt* (Reports)

Danh sách các stored procedure trong nhóm asRpt* (báo cáo) đã được chuyển đổi sang class PHP.

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| `asRptUpdTATNDN01A_DC` | `AsRptUpdTATNDN01A_DC` | `@pMa_Cty` (string), `@pNgay1` (datetime), `@pNgay2` (datetime), `@pMau` (string, default '01'), `@pMa_so` (string, default ''), `@pTien` (decimal), `@pStt` (string), `@pRet` (int, output) | Cập nhật trường tiền (tien) trong bảng TATNDN01A_DC (báo cáo thuế thu nhập doanh nghiệp - mẫu 01A điều chỉnh). |
| `asRptUpdTatndn03_dc` | `AsRptUpdTatndn03_dc` | `@pMa_Cty` (string), `@pNgay1` (datetime), `@pNgay2` (datetime), `@pMau` (string, default '01'), `@pMa_so` (string, default ''), `@pTien` (decimal), `@pStt` (string), `@pRet` (int, output) | Cập nhật trường tiền (tien) trong bảng tatndn03_dc (báo cáo thuế thu nhập doanh nghiệp - mẫu 03 điều chỉnh). |

## Chi tiết từng procedure

### asRptUpdTATNDN01A_DC

- **Mục đích**: Cập nhật giá trị tiền cho một bản ghi trong bảng điều chỉnh TATNDN01A_DC dựa trên các điều kiện: mã công ty, ngày bắt đầu, ngày kết thúc, mẫu số, mã số, số thứ tự.
- **Bảng tác động**: `TATNDN01A_DC`
- **Logic**: Thực hiện lệnh `UPDATE` với điều kiện khóa đầy đủ.
- **Output**: `@pRet` chứa mã lỗi SQL (`@@ERROR`). 0 thành công, khác 0 lỗi.

### asRptUpdTatndn03_dc

- **Mục đích**: Cập nhật giá trị tiền cho một bản ghi trong bảng điều chỉnh tatndn03_dc dựa trên các điều kiện tương tự.
- **Bảng tác động**: `tatndn03_dc`
- **Logic**: Thực hiện lệnh `UPDATE` với điều kiện khóa đầy đủ.
- **Output**: `@pRet` chứa mã lỗi SQL (`@@ERROR`). 0 thành công, khác 0 lỗi.

## Hướng dẫn sử dụng

Các class PHP được đặt trong namespace `Diepxuan\LaravelSimba\StoredProcedures`. Sử dụng phương thức tĩnh `::call()` để gọi stored procedure.

Ví dụ:

```php
use Diepxuan\LaravelSimba\StoredProcedures\AsRptUpdTATNDN01A_DC;

$result = AsRptUpdTATNDN01A_DC::call([
    'pMa_Cty' => '001',
    'pNgay1' => '2025-01-01',
    'pNgay2' => '2025-03-31',
    'pMau' => '01',
    'pMa_so' => '01A',
    'pTien' => 1000000.00,
    'pStt' => '1',
]);

$ret = $result['pRet'] ?? null;
if ($ret === 0) {
    // Thành công
} else {
    // Lỗi
}
```

## Lưu ý

- Cả hai procedure đều không trả về resultset, chỉ cập nhật dữ liệu.
- Nếu không có bản ghi nào khớp điều kiện, không có dòng nào được cập nhật nhưng `@pRet` vẫn là 0 (không có lỗi SQL).
- Procedure sử dụng `@@ERROR` để lấy mã lỗi sau lệnh UPDATE.