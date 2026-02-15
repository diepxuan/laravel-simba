<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsReCalPO3
{
    /**
     * Call stored procedure asReCalPO3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO3', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pstt_rec_hd' => $params['pstt_rec_hd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_hd
     * @param mixed $ma_cty
     * @param mixed $stt_rec_hd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_hd = null, mixed $ma_cty = null, mixed $stt_rec_hd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_hd' => $Stt_rec_hd,
            'pma_cty' => $ma_cty,
            'pstt_rec_hd' => $stt_rec_hd
        ];
        
        return self::call($params);
    }
}
