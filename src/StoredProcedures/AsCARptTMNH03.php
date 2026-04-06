<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCARptTMNH03.
 *
 * Stored procedure: asCARptTMNH03
 * Mục đích: Báo cáo lưu chuyển tiền tệ mẫu 03 (TMNH03).
 * Procedure thực hiện truy vấn và trả về báo cáo lưu chuyển tiền tệ theo ngày.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pNgay2 (smalldatetime): Đến ngày. Default NULL.
 *
 * Giá trị trả về:
 * - Procedure trả về result set chứa dữ liệu báo cáo lưu chuyển tiền tệ.
 * - Không có output parameter pRet (procedure SELECT, không INSERT/UPDATE).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCARptTMNH03::call([
 *     'pNgay2' => '2026-01-31',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ thực hiện SELECT, không thay đổi dữ liệu.
 */
class AsCARptTMNH03
{
    /**
     * Gọi stored procedure asCARptTMNH03.
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số.
     *                      Các parameters có thể thiếu, sẽ dùng giá trị default.
     *
     * @return Collection kết quả từ procedure (dữ liệu báo cáo)
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH03', [
            'pNgay2' => $paramObj->pNgay2 ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asCARptTMNH03 with named parameters (helper method).
     *
     * @param null|string $Ngay2 Đến ngày
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ngay2 = null,
    ): Collection {
        return self::call([
            'pNgay2' => $Ngay2,
        ]);
    }
}
