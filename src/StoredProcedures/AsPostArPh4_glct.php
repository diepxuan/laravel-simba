<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostArPh4_glct
{
    /**
     * Call stored procedure asPostArPh4_glct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostArPh4_glct', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostArPh4_glct with named parameters
     *
     * @param string $ma_cty
     * @param string $stt_rec
     * @param mixed $Stt_rec
     * @param mixed $STT_rec
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $stt_rec = null, mixed $Stt_rec = null, mixed $STT_rec = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pstt_rec' => $stt_rec,
            'pStt_rec' => $Stt_rec,
            'pSTT_rec' => $STT_rec
        ];
        
        return self::call($params);
    }
}
