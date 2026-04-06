<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCARptTMNH06.
 *
 * Stored procedure: asCARptTMNH06
 * Mục đích: Báo cáo lưu chuyển tiền tệ mẫu 06 (TMNH06).
 * Procedure thực hiện truy vấn và trả về báo cáo lưu chuyển tiền tệ theo tài khoản, khu vực và khoảng thời gian.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNgay_ct1 (smalldatetime): Từ ngày. Default NULL.
 * - @pNgay_ct2 (smalldatetime): Đến ngày. Default NULL.
 * - @pTk (nvarchar(20)): Tài khoản. Default NULL.
 * - @pMa_Ku (nvarchar(20)): Mã khu vực. Default NULL.
 * - @pMa_Nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 *
 * Giá trị trả về:
 * - Procedure trả về result set chứa dữ liệu báo cáo lưu chuyển tiền tệ.
 * - Không có output parameter pRet (procedure SELECT, không INSERT/UPDATE).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCARptTMNH06::call([
 *     'pMa_cty' => '001',
 *     'pNgay_ct1' => '2026-01-01',
 *     'pNgay_ct2' => '2026-01-31',
 *     'pTk' => '111',
 *     'pMa_Ku' => 'KU001',
 *     'pMa_Nt' => 'VND',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ thực hiện SELECT, không thay đổi dữ liệu.
 */
class AsCARptTMNH06
{
    /**
     * Gọi stored procedure asCARptTMNH06.
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

        return ProcedureCaller::call('asCARptTMNH06', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pNgay_ct1' => $paramObj->pNgay_ct1 ?? null,
            'pNgay_ct2' => $paramObj->pNgay_ct2 ?? null,
            'pTk'       => $paramObj->pTk ?? null,
            'pMa_Ku'    => $paramObj->pMa_Ku ?? null,
            'pMa_Nt'    => $paramObj->pMa_Nt ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asCARptTMNH06 with named parameters (helper method).
     *
     * @param null|string $Ma_cty   Mã công ty
     * @param null|string $Ngay_ct1 Từ ngày
     * @param null|string $Ngay_ct2 Đến ngày
     * @param null|string $Tk       Tài khoản
     * @param null|string $Ma_Ku    Mã khu vực
     * @param null|string $Ma_Nt    Mã ngoại tệ
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ngay_ct1 = null,
        ?string $Ngay_ct2 = null,
        ?string $Tk = null,
        ?string $Ma_Ku = null,
        ?string $Ma_Nt = null,
    ): Collection {
        return self::call([
            'pMa_cty'   => $Ma_cty,
            'pNgay_ct1' => $Ngay_ct1,
            'pNgay_ct2' => $Ngay_ct2,
            'pTk'       => $Tk,
            'pMa_Ku'    => $Ma_Ku,
            'pMa_Nt'    => $Ma_Nt,
        ]);
    }
}
