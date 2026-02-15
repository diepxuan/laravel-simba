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

class AsReCalSo1
{
    /**
     * Call stored procedure asReCalSo1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalSo1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_dh' => $params['pStt_rec_dh'] ?? null,
            'pstt_rec_dh' => $params['pstt_rec_dh'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asReCalSo1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_dh
     * @param mixed $stt_rec_dh
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_dh = null, mixed $stt_rec_dh = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_dh' => $Stt_rec_dh,
            'pstt_rec_dh' => $stt_rec_dh,
            'pma_cty' => $ma_cty
        ];
        
        return self::call($params);
    }
}
