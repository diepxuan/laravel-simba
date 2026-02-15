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

class AsInCalGiaTB_UpdateGia
{
    /**
     * Call stored procedure asInCalGiaTB_UpdateGia
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInCalGiaTB_UpdateGia', [
            'pstt_l' => $params['pstt_l'] ?? null,
            'pma_l' => $params['pma_l'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInCalGiaTB_UpdateGia with named parameters
     *
     * @param mixed $stt_l
     * @param mixed $ma_l
     * @return Collection
     */
    public static function callWithParams(mixed $stt_l = null, mixed $ma_l = null): Collection
    {
        $params = [
            'pstt_l' => $stt_l,
            'pma_l' => $ma_l
        ];
        
        return self::call($params);
    }
}
