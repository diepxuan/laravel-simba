<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:55:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdOptFieldSetup.
 *
 * Stored procedure: asUpdOptFieldSetup
 * Mục đích: Cập nhật thiết lập trường tùy chọn (Optional Field) cho một loại chứng từ.
 * Procedure cập nhật cờ Master (dùng ở master) và Detail (dùng ở detail) của một trường tùy chọn trong bảng sysOptFieldSetup.
 *
 * Tham số:
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ (NVARCHAR(3)).
 * - @pField (string, bắt buộc): Mã trường tùy chọn (NVARCHAR(10)).
 * - @pMaster (bool, bắt buộc): Cờ sử dụng ở phần master (BIT). 1 = có, 0 = không.
 * - @pDetail (bool, bắt buộc): Cờ sử dụng ở phần detail (BIT). 1 = có, 0 = không.
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - UPDATE bảng sysOptFieldSetup: cập nhật cột Master = @pMaster, Detail = @pDetail với điều kiện Voucher_code = @pVoucher_code AND Field = @pField.
 * - Bắt lỗi: SET @pRet = @@error.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdOptFieldSetup::call([
 *     'pVoucher_code' => 'AR1',
 *     'pField' => 'OPT1',
 *     'pMaster' => true,
 *     'pDetail' => false,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Tham số @pVoucher_code và @pField kết hợp tạo thành khóa điều kiện duy nhất (có thể là khóa chính phức hợp).
 * - Các cờ Master và Detail xác định trường tùy chọn sẽ xuất hiện ở phần master hay detail của chứng từ.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi (trừ ràng buộc khác).
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Trường tùy chọn thường được dùng để mở rộng tính năng của chứng từ mà không cần sửa cấu trúc bảng.
 */
class AsUpdOptFieldSetup
{
    /**
     * Gọi stored procedure asUpdOptFieldSetup.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOptFieldSetup', [
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
            'pField'        => $params['pField'] ?? null,
            'pMaster'       => $params['pMaster'] ?? null,
            'pDetail'       => $params['pDetail'] ?? null,
            'pRet'          => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdOptFieldSetup with named parameters.
     */
    public static function callWithParams(?string $Voucher_code = null, ?string $Field = null, ?bool $Master = null, ?bool $Detail = null, ?int $Ret = null): Collection
    {
        $params = [
            'pVoucher_code' => $Voucher_code,
            'pField'        => $Field,
            'pMaster'       => $Master,
            'pDetail'       => $Detail,
            'pRet'          => $Ret,
        ];

        return self::call($params);
    }
}
