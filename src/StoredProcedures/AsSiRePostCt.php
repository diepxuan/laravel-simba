<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiRePostCt
{
    /**
     * Call stored procedure asSiRePostCt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiRePostCt', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pTable' => $params['pTable'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pProc' => $params['pProc'] ?? null,
            'pQuerry' => $params['pQuerry'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiRePostCt with named parameters
     *
     * @param mixed $Ma_cty
     * @param mixed $Ngay1
     * @param mixed $Ngay2
     * @param mixed $Ma_ct
     * @param string $Table
     * @param string $Stt_rec
     * @param string $Proc
     * @param mixed $Querry
     * @param mixed $STT_rec
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(mixed $Ma_cty = null, mixed $Ngay1 = null, mixed $Ngay2 = null, mixed $Ma_ct = null, string $Table = null, string $Stt_rec = null, string $Proc = null, mixed $Querry = null, mixed $STT_rec = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_ct' => $Ma_ct,
            'pTable' => $Table,
            'pStt_rec' => $Stt_rec,
            'pProc' => $Proc,
            'pQuerry' => $Querry,
            'pSTT_rec' => $STT_rec,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
