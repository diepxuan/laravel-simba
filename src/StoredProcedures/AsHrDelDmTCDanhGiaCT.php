<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrDelDmTCDanhGiaCT
{
    /**
     * Call stored procedure asHrDelDmTCDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmTCDanhGiaCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tcdg' => $paramObj->pMa_tcdg ?? null,
            'pId_diem' => $paramObj->pId_diem ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDmTCDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @param string $Id_diem
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null, string $Id_diem = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg,
            'pId_diem' => $Id_diem,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
