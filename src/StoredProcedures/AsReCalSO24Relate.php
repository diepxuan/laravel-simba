<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsReCalSO24Relate
{
    /**
     * Call stored procedure asReCalSO24Relate
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalSO24Relate', $params, $connection);
    }

    /**
     * Call stored procedure asReCalSO24Relate with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param mixed $ma_cty
     * @param mixed $stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, mixed $ma_cty = null, mixed $stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pma_cty' => $ma_cty,
            'pstt_rec' => $stt_rec
        ];
        
        return self::call($params);
    }
}
