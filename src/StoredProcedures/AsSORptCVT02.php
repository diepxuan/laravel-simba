<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptCVT02
{
    /**
     * Call stored procedure asSORptCVT02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptCVT02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_td' => $params['pMa_td'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pMa_nvt' => $params['pMa_nvt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptCVT02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_nt
     * @param string $Ma_td
     * @param string $Ma_pt
     * @param string $Ma_nvt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_nt = null, string $Ma_td = null, string $Ma_pt = null, string $Ma_nvt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_nt' => $Ma_nt,
            'pMa_td' => $Ma_td,
            'pMa_pt' => $Ma_pt,
            'pMa_nvt' => $Ma_nvt
        ];
        
        return self::call($params);
    }
}
