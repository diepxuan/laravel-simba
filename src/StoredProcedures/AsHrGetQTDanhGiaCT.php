<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetQTDanhGiaCT
{
    /**
     * Call stored procedure asHrGetQTDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetQTDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtdg' => $params['pId_qtdg'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetQTDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtdg
     * @param string $Ma_tcdg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtdg = null, string $Ma_tcdg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtdg' => $Id_qtdg,
            'pMa_tcdg' => $Ma_tcdg
        ];
        
        return self::call($params);
    }
}
