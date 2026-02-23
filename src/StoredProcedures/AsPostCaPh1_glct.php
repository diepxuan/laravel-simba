<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostCaPh1_glct
{
    /**
     * Call stored procedure asPostCaPh1_glct
     * 
     * Note: Stored procedure chỉ có 2 tham số (@pMa_cty, @pStt_rec)
     * Các tham số khác được tính toán bên trong stored procedure
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostCaPh1_glct', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asPostCaPh1_glct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
        ];
        
        return self::call($params);
    }
}
