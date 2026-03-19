<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptCVT01
{
    /**
     * Call stored procedure asSORptCVT01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptCVT01', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pSoct1' => $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pSoct2 ?? null,
            'pMa_td' => $paramObj->pMa_td ?? null,
            'pMa_pt' => $paramObj->pMa_pt ?? null,
            'pMa_nvt' => $paramObj->pMa_nvt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptCVT01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_nt
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_td
     * @param string $Ma_pt
     * @param string $Ma_nvt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_nt = null, string $Soct1 = null, string $Soct2 = null, string $Ma_td = null, string $Ma_pt = null, string $Ma_nvt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_nt' => $Ma_nt,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_td' => $Ma_td,
            'pMa_pt' => $Ma_pt,
            'pMa_nvt' => $Ma_nvt
        ];

        return self::call($params);
    }
}
