<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPRptBK03
{
    /**
     * Call stored procedure asAPRptBK03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK03', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pSap_xep' => $params['pSap_xep'] ?? null,
            'pTat_toan' => $params['pTat_toan'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asAPRptBK03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_gd
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Sap_xep
     * @param string $Tat_toan
     * @param string $Ma_NT
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_gd = null, string $Soct1 = null, string $Soct2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Sap_xep = null, string $Tat_toan = null, string $Ma_NT = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_gd' => $Ma_gd,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pSap_xep' => $Sap_xep,
            'pTat_toan' => $Tat_toan,
            'pMa_NT' => $Ma_NT
        ];
        
        return self::call($params);
    }
}
