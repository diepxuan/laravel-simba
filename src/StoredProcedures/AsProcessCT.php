<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:54
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsProcessCT
{
    /**
     * Call stored procedure asProcessCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asProcessCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMode' => $params['pMode'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'prefix' => $params['prefix'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asProcessCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Mode
     * @param string $ParamDefines
     * @param mixed $refix
     * @param mixed $ma_cty
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Mode = null, string $ParamDefines = null, mixed $refix = null, mixed $ma_cty = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMode' => $Mode,
            'ParamDefines' => $ParamDefines,
            'prefix' => $refix,
            'pma_cty' => $ma_cty,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
