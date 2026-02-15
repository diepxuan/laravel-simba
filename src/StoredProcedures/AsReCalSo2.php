<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:34:33
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsReCalSo2
{
    /**
     * Call stored procedure asReCalSo2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalSo2', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_px' => $params['pStt_rec_px'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pstt_rec_px' => $params['pstt_rec_px'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asReCalSo2 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_px
     * @param mixed $ma_cty
     * @param mixed $stt_rec_px
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_px = null, mixed $ma_cty = null, mixed $stt_rec_px = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_px' => $Stt_rec_px,
            'pma_cty' => $ma_cty,
            'pstt_rec_px' => $stt_rec_px
        ];
        
        return self::call($params);
    }
}
