<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostinPh6_inct
{
    /**
     * Call stored procedure asPostinPh6_inct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostinPh6_inct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostinPh6_inct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec
        ];
        
        return self::call($params);
    }
}
