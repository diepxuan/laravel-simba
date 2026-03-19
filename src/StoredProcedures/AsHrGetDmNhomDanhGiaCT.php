<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrGetDmNhomDanhGiaCT
{
    /**
     * Call stored procedure asHrGetDmNhomDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmNhomDanhGiaCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_nhdg' => $paramObj->pMa_nhdg ?? null,
            'pMa_tcdg' => $paramObj->pMa_tcdg ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmNhomDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhdg
     * @param string $Ma_tcdg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhdg = null, string $Ma_tcdg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhdg' => $Ma_nhdg,
            'pMa_tcdg' => $Ma_tcdg
        ];

        return self::call($params);
    }
}
