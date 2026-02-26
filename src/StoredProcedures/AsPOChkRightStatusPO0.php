<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:38:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPoChkRightStatusPo0.
 *
 * Stored procedure: asPOChkRightStatusPO0
 * Mục đích: Kiểm tra trạng thái chứng từ trước khi sửa/xóa đơn đặt hàng (Purchase Order).
 * Procedure kiểm tra xem chứng từ có tồn tại và trả về thông tin định dạng: mã chứng từ | ngày chứng từ | số chứng từ.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số tham chiếu (stt_rec) của chứng từ cần kiểm tra.
 * - @pLanguage (string, tùy chọn, mặc định 'vi-VN'): Ngôn ngữ định dạng ngày tháng. Hỗ trợ 'vi-VN' (định dạng 103) hoặc khác (định dạng 101).
 *
 * Giá trị trả về:
 * - Một dòng chứa chuỗi thông báo định dạng: "ma_ct | ngay_ct | so_ct"
 * - Nếu không tìm thấy, trả về null.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsPoChkRightStatusPo0::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure này thường được gọi trước khi thực hiện sửa/xóa chứng để đảm bảo chứng từ ở trạng thái hợp lệ.
 * - Ngày tháng được định dạng theo quy tắc của SQL Server (101 hoặc 103) tùy ngôn ngữ.
 */
class AsPOChkRightStatusPO0 extends StoredProcedure
{
    public const NAME = 'asPOChkRightStatusPO0';

    /**
     * Gọi stored procedure asPOChkRightStatusPO0.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (thường là một chuỗi hoặc null)
     */
    public static function call(array $params): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPOChkRightStatusPO0 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?string $Language = null): Collection
    {
        $params = [
            'pMa_cty'   => $Ma_cty,
            'pStt_rec'  => $Stt_rec,
            'pLanguage' => $Language,
        ];

        return self::call($params);
    }
}
