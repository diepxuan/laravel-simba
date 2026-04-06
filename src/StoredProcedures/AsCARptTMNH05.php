<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:36:39
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCARptTMNH05.
 *
 * Stored procedure: asCARptTMNH05
 * Mục đích: Báo cáo lưu chuyển tiền tệ mẫu 05 (TMNH05).
 * Procedure thực hiện truy vấn và trả về báo cáo lưu chuyển tiền tệ theo tài khoản và khoảng thời gian.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_Cty (nvarchar(3)): Mã công ty. Default 'A01'.
 * - @pTk (nvarchar(20)): Tài khoản. Default ''.
 * - @pNgay_Ct1 (smalldatetime): Từ ngày. Default '2015-10-01'.
 * - @pNgay_ct2 (smalldatetime): Đến ngày. Default '2015-10-31'.
 * - @pMa_Nt (nvarchar(3)): Mã ngoại tệ. Default ''.
 *
 * Giá trị trả về:
 * - Procedure trả về result set chứa dữ liệu báo cáo lưu chuyển tiền tệ.
 * - Không có output parameter pRet (procedure SELECT, không INSERT/UPDATE).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCARptTMNH05::call([
 *     'pMa_Cty' => '001',
 *     'pTk' => '',
 *     'pNgay_Ct1' => '2026-01-01',
 *     'pNgay_ct2' => '2026-01-31',
 *     'pMa_Nt' => 'VND',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ thực hiện SELECT, không thay đổi dữ liệu.
 */
class AsCARptTMNH05
{
    /**
     * Gọi stored procedure asCARptTMNH05.
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

        return ProcedureCaller::call('asCARptTMNH05', [
            'pMa_Cty'   => $paramObj->pMa_Cty ?? SModel::CTY,
            'pTk'       => $paramObj->pTk ?? '',
            'pNgay_Ct1' => $paramObj->pNgay_Ct1 ?? '2015-10-01',
            'pNgay_ct2' => $paramObj->pNgay_ct2 ?? '2015-10-31',
            'pMa_Nt'    => $paramObj->pMa_Nt ?? '',
        ], $connection);
    }

    /**
     * Call stored procedure asCARptTMNH05 with named parameters (helper method).
     *
     * @param null|string $Ma_Cty   Mã công ty
     * @param null|string $Tk       Tài khoản
     * @param null|string $Ngay_Ct1 Từ ngày
     * @param null|string $Ngay_ct2 Đến ngày
     * @param null|string $Ma_Nt    Mã ngoại tệ
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_Cty = null,
        ?string $Tk = null,
        ?string $Ngay_Ct1 = null,
        ?string $Ngay_ct2 = null,
        ?string $Ma_Nt = null,
    ): Collection {
        return self::call([
            'pMa_Cty'   => $Ma_Cty,
            'pTk'       => $Tk,
            'pNgay_Ct1' => $Ngay_Ct1,
            'pNgay_ct2' => $Ngay_ct2,
            'pMa_Nt'    => $Ma_Nt,
        ]);
    }
}
