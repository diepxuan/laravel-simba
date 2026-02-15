<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetCDVT
{
    /**
     * Call stored procedure asINGetCDVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetCDVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetCDVT with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Tk_vt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Tk_vt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pTk_vt' => $Tk_vt
        ];
        
        return self::call($params);
    }
}
