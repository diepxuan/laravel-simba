<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsReCalPO2
{
    /**
     * Call stored procedure asReCalPO2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO2', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_pn' => $params['pStt_rec_pn'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pstt_rec_pn' => $params['pstt_rec_pn'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO2 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_pn
     * @param mixed $ma_cty
     * @param mixed $stt_rec_pn
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_pn = null, mixed $ma_cty = null, mixed $stt_rec_pn = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_pn' => $Stt_rec_pn,
            'pma_cty' => $ma_cty,
            'pstt_rec_pn' => $stt_rec_pn
        ];
        
        return self::call($params);
    }
}
