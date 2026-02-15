<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPost2GL
{
    /**
     * Call stored procedure asPost2GL
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPost2GL', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pPostUnpost' => $params['pPostUnpost'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPost2GL with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $PostUnpost
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Stt_rec = null, string $Ma_ct = null, string $PostUnpost = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pPostUnpost' => $PostUnpost,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
