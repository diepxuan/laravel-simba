<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsProcessApPh1
{
    /**
     * Call stored procedure asProcessApPh1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asProcessApPh1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMode' => $params['pMode'] ?? null,
            'pStt_rec_dh' => $params['pStt_rec_dh'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asProcessApPh1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Mode
     * @param string $Stt_rec_dh
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Mode = null, string $Stt_rec_dh = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMode' => $Mode,
            'pStt_rec_dh' => $Stt_rec_dh
        ];
        
        return self::call($params);
    }
}
