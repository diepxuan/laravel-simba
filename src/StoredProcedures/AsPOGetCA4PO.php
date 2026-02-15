<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOGetCA4PO
{
    /**
     * Call stored procedure asPOGetCA4PO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetCA4PO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOGetCA4PO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Stt_rec_hd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Stt_rec_hd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pStt_rec_hd' => $Stt_rec_hd
        ];
        
        return self::call($params);
    }
}
