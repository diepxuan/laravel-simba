<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINPostCDFIFO2CDVT
{
    /**
     * Call stored procedure asINPostCDFIFO2CDVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINPostCDFIFO2CDVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pAction' => $params['pAction'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINPostCDFIFO2CDVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Action
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Action = null, int $Nam = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pAction' => $Action,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_nt' => $Ma_nt
        ];
        
        return self::call($params);
    }
}
