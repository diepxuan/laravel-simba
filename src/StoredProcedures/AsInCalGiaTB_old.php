<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInCalGiaTB_old
{
    /**
     * Call stored procedure asInCalGiaTB_old
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInCalGiaTB_old', [
            'pStt_L' => $params['pStt_L'] ?? null,
            'pMa_L' => $params['pMa_L'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInCalGiaTB_old with named parameters
     *
     * @param mixed $Stt_L
     * @param mixed $Ma_L
     * @return Collection
     */
    public static function callWithParams(mixed $Stt_L = null, mixed $Ma_L = null): Collection
    {
        $params = [
            'pStt_L' => $Stt_L,
            'pMa_L' => $Ma_L
        ];
        
        return self::call($params);
    }
}
