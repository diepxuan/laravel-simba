<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:36:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCARptTMNH07.
 *
 * Stored procedure: asCARptTMNH07
 * Mục đích: Báo cáo lưu chuyển tiền tệ mẫu 07 (TMNH07).
 * Procedure thực hiện truy vấn và trả về báo cáo lưu chuyển tiền tệ theo tài khoản, khu vực và khoảng thời gian.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản. Default NULL.
 * - @pMa_ku (nvarchar(20)): Mã khu vực. Default NULL.
 * - @pNgay_ctk (smalldatetime): Ngày đầu kỳ. Default NULL.
 * - @pNgay_cdk (smalldatetime): Ngày cuối kỳ. Default NULL.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 *
 * Giá trị trả về:
 * - Procedure trả về result set chứa dữ liệu báo cáo lưu chuyển tiền tệ.
 * - Không có output parameter pRet (procedure SELECT, không INSERT/UPDATE).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCARptTMNH07::call([
 *     'pMa_cty' => '001',
 *     'pTk' => '111',
 *     'pMa_ku' => 'KU001',
 *     'pNgay_ctk' => '2026-01-01',
 *     'pNgay_cdk' => '2026-01-31',
 *     'pMa_nt' => 'VND',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ thực hiện SELECT, không thay đổi dữ liệu.
 */
class AsCARptTMNH07
{
    /**
     * Gọi stored procedure asCARptTMNH07.
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

        return ProcedureCaller::call('asCARptTMNH07', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pTk'       => $paramObj->pTk ?? null,
            'pMa_ku'    => $paramObj->pMa_ku ?? null,
            'pNgay_ctk' => $paramObj->pNgay_ctk ?? null,
            'pNgay_cdk' => $paramObj->pNgay_cdk ?? null,
            'pMa_nt'    => $paramObj->pMa_nt ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asCARptTMNH07 with named parameters (helper method).
     *
     * @param null|string $Ma_cty   Mã công ty
     * @param null|string $Tk       Tài khoản
     * @param null|string $Ma_ku    Mã khu vực
     * @param null|string $Ngay_ctk Ngày đầu kỳ
     * @param null|string $Ngay_cdk Ngày cuối kỳ
     * @param null|string $Ma_nt    Mã ngoại tệ
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Tk = null,
        ?string $Ma_ku = null,
        ?string $Ngay_ctk = null,
        ?string $Ngay_cdk = null,
        ?string $Ma_nt = null,
    ): Collection {
        return self::call([
            'pMa_cty'   => $Ma_cty,
            'pTk'       => $Tk,
            'pMa_ku'    => $Ma_ku,
            'pNgay_ctk' => $Ngay_ctk,
            'pNgay_cdk' => $Ngay_cdk,
            'pMa_nt'    => $Ma_nt,
        ]);
    }
}
