# Nhóm asDel* (Delete) - Stored Procedures Xóa dữ liệu

Tổng hợp các stored procedures thực hiện xóa dữ liệu (DELETE) trong hệ thống Simba ERP.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asDelCOdd | AsDelCOdd | `@pMa_cty` (string), `@pNam` (int), `@pThang` (int), `@pMa_spct` (string), `@pTk` (string), `@pRet` (int, output) | Xóa bản ghi chi phí dở dang (codd) theo mã công ty, năm, tháng, mã sản phẩm công trình và tài khoản. |
| asDelDashForm | AsDelDashForm | `@pDashid` (int), `@pUserName` (string), `@pRet` (int, output) | Xóa form Dashlet của người dùng và cập nhật vị trí các Dashlet còn lại. |
| asDelDashFrequentlyFunction | AsDelDashFrequentlyFunction | `@pMenuID` (string), `@pUserName` (string), `@pDashID` (int), `@pRet` (int, output) | Xóa một chức năng thường dùng khỏi danh sách chức năng thường dùng của Dashlet. |
| asDelDashParameter | AsDelDashParameter | `@pDashID` (int), `@pUsername` (string), `@pRet` (int, output) | Xóa danh sách tham số của Dashlet theo dashid và username. |
| asDelDictionaryComplexInfo | AsDelDictionaryComplexInfo | `@pCode_name` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysDictionaryComplexInfo dựa trên mã code_name. |
| asDelDictionaryInfo | AsDelDictionaryInfo | `@pCode_name` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysDictionaryInfo dựa trên mã code_name. |
| asDelDictionaryResx | AsDelDictionaryResx | `@pCode_name` (string), `@pLanguage` (string), `@pRet` (int, output) | Xóa một bản dịch từ bảng sysDictionaryResx dựa trên mã code_name và ngôn ngữ. |
| asDelGroupInfo | AsDelGroupInfo | `@pGroupName` (string), `@pRet` (int, output) | Xóa một nhóm người dùng khỏi danh mục nhóm người dùng (sysGroupInfo) dựa trên tên nhóm. |
| asDelGroupRight | AsDelGroupRight | `@pGroupName` (string), `@pMenuID` (string), `@pRet` (int, output) | Xóa quyền của nhóm người dùng từ bảng sysGroupRight dựa trên tên nhóm và mã menu (có thể xóa theo prefix). |
| asDelOpeningBlanceInfo | AsDelOpeningBlanceInfo | `@pCode_name` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysOpeningBalanceInfo (số dư đầu kỳ) dựa trên mã code_name. |
| asDelOpeningBlanceResx | AsDelOpeningBlanceResx | `@pCode_name` (string), `@pLanguage` (string), `@pRet` (int, output) | Xóa một bản dịch từ bảng sysOpeningBalanceResx dựa trên mã code_name và ngôn ngữ, sau khi kiểm tra điều kiện tồn tại (hàm afExistMaeningBlanc). |
| asDelOptFieldSetup | AsDelOptFieldSetup | `@pVoucher_code` (string), `@pField` (string), `@pRet` (int, output) | Xóa một thiết lập trường tùy chọn từ bảng sysOptFieldSetup dựa trên mã chứng từ và tên trường. |
| asDelTAOUT | AsDelTAOUT | `@pMa_cty` (string), `@pStt_rec` (string), `@pRet` (int, output) | Xóa một bản ghi xuất kho (TAOUT) dựa trên mã công ty và số chứng từ. |
| asDelTain | AsDelTain | `@pMa_cty` (string), `@pStt_rec` (string), `@pRet` (int, output) | Xóa một bản ghi nhập kho (TAIN) dựa trên mã công ty và số chứng từ (có xử lý lỗi TRY CATCH). |
| asDelUserGroup | AsDelUserGroup | `@pUserName` (string), `@pRet` (int, output) | Xóa liên kết người dùng - nhóm từ bảng sysUsergroup dựa trên tên đăng nhập. |
| asDelUserInfo | AsDelUserInfo | `@pUserName` (string), `@pRet` (int, output) | Xóa người dùng khỏi danh mục người dùng và đồng thời xóa tất cả các quyền, liên kết nhóm liên quan. |
| asDelUserRight | AsDelUserRight | `@pUserName` (string), `@pMenuID` (string), `@pRet` (int, output) | Xóa một quyền cụ thể của người dùng từ bảng sysUserRight dựa trên tên đăng nhập và mã menu. |
| asDelVoucherInfo | AsDelVoucherInfo | `@pVoucher_code` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysVoucherInfo (thông tin chứng từ) dựa trên mã chứng từ. |
| asDelVoucherResx | AsDelVoucherResx | `@pVoucher_code` (string), `@pLanguage` (string), `@pRet` (int, output) | Xóa một bản dịch từ bảng sysVoucherResx dựa trên mã chứng từ và ngôn ngữ. |
| asDelardmkh_nh | AsDelardmkh_nh | `@pMa_cty` (string), `@pMa_kh` (string), `@pMa_ngh` (string), `@pStt` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng ardmkhngh (có thể là danh mục khách hàng - ngành hàng) dựa trên mã công ty, mã khách hàng, mã ngành và số thứ tự. |
| asDelcolk | AsDelcolk | `@pMa_cty` (string), `@pThang` (int), `@pNam` (int), `@pMa_spct` (string), `@pTk` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng colk (có thể là chi phí lũy kế) dựa trên mã công ty, tháng, năm, mã sản phẩm công trình và tài khoản. |
| asDeldaoinfo | AsDeldaoinfo | `@pTable_name` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysDAOInfo (thông tin Data Access Object) dựa trên tên bảng. |
| asDelreportDrilldownInfo | AsDelreportDrilldownInfo | `@pMenuid` (string), `@pMa_mau` (string), `@pPress_key_name` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysreportDrilldownInfo (thông tin drilldown báo cáo) dựa trên mã menu, mã mẫu và tên phím bấm. |
| asDelreportinfo | AsDelreportinfo | `@pMenuid` (string), `@pMa_mau` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysReportinfo (thông tin báo cáo) dựa trên mã menu và mã mẫu. |
| asDelreportresx | AsDelreportresx | `@pMenuid` (string), `@pMa_mau` (string), `@pRet` (int, output) | Xóa một bản ghi từ bảng sysReportresx (bản dịch báo cáo) dựa trên mã menu và mã mẫu. |
| asAPDelCT1 | AsAPDelCT1 | `@pMa_cty` (string), `@pStt_rec` (string), `@pRet` (int, output) | Xóa chi tiết 1 (APCT1) của một chứng từ Accounts Payable. |
| asAPDelCT3 | AsAPDelCT3 | `@pMa_cty` (string), `@pStt_rec` (string), `@pRet` (int, output) | Xóa chi tiết 3 (APCT3) của một chứng từ Accounts Payable. |
| asAPDelCT4 | AsAPDelCT4 | `@pMa_cty` (string), `@pStt_rec` (string), `@pRet` (int, output) | Xóa chi tiết 4 (APCT4) của một chứng từ Accounts Payable. |
| asAPDelTT | AsAPDelTT | `@pMa_cty` (string), `@pStt_rec` (string), `@pStt_rec_pt` (string), `@pRet` (int, output) | Xóa tổng hợp (APTT) của một chứng từ Accounts Payable và có thể xóa cả chứng từ thanh toán liên quan. |
| asAPDelPost2TT_APTT | AsAPDelPost2TT_APTT | `@pMa_cty` (string), `@pStt_rec` (string), `@pStt_rec_hd` (string), `@pTien_tt` (decimal), `@pTien_tt_nt` (decimal), `@pRet` (int, output) | Xóa phân bổ chứng từ Accounts Payable và cập nhật lại số tiền phân bổ trên hóa đơn. |

## Tổng số procedures đã chuyển đổi: 30

## Cấu trúc class

Tất cả class đều tuân theo mẫu chung:

```php
<?php
namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

class AsDelXxx
{
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDelXxx', $params);
    }
}
```

Mỗi class đều có comment chi tiết về mục đích, tham số, giá trị trả về và ví dụ sử dụng.

## Hướng dẫn sử dụng

Ví dụ gọi procedure xóa:

```php
use Diepxuan\LaravelSimba\StoredProcedures\AsDelCOdd;

$result = AsDelCOdd::call([
    'pMa_cty' => '001',
    'pNam' => 2025,
    'pThang' => 2,
    'pMa_spct' => 'SPCT001',
    'pTk' => '154',
]);
$ret = $result['pRet'] ?? null;
if ($ret === 0) {
    // Xóa thành công
} else {
    // Xóa thất bại, có lỗi SQL
}
```

## Ghi chú

- Hầu hết các procedure đều có output parameter `@pRet` trả về 0 nếu thành công, giá trị lỗi SQL nếu có lỗi.
- Một số procedure luôn trả về `@pRet = 0` (không kiểm tra lỗi).
- Các procedure xóa dữ liệu trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
- Tên procedure có một số lỗi chính tả (ví dụ: "Blance" thay vì "Balance") nhưng phải giữ nguyên để tương thích.

## Liên kết

- [Simba SQL Source](../../../SimbaSql/dbo/StoredProcedures/)
- [Stored Procedures Classes](../src/StoredProcedures/)
- [Tài liệu tổng hợp](../PROCEDURES.md)