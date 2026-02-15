<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsReCalPO0
{
    /**
     * Call stored procedure asReCalPO0
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO0', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pstt_rec_pdn' => $params['pstt_rec_pdn'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO0 with named parameters
     *
     * @param string $Ma_cty
     * @param string $stt_rec_pdn
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $stt_rec_pdn = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pstt_rec_pdn' => $stt_rec_pdn,
            'pma_cty' => $ma_cty
        ];
        
        return self::call($params);
    }
}
