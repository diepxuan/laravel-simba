<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOGetGiaNhap
{
    /**
     * Call stored procedure asPOGetGiaNhap
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetGiaNhap', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pKieu_lay_gia' => $paramObj->pKieu_lay_gia ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOGetGiaNhap with named parameters
     *
     * @param string $Ma_cty
     * @param string $Kieu_lay_gia
     * @param string $Ma_vt
     * @param string $Ngay_ct
     * @param string $Ma_nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Kieu_lay_gia = null, string $Ma_vt = null, string $Ngay_ct = null, string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKieu_lay_gia' => $Kieu_lay_gia,
            'pMa_vt' => $Ma_vt,
            'pNgay_ct' => $Ngay_ct,
            'pMa_nt' => $Ma_nt
        ];

        return self::call($params);
    }
}
