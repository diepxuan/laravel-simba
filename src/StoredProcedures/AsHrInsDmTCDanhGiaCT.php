<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrInsDmTCDanhGiaCT
{
    /**
     * Call stored procedure asHrInsDmTCDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmTCDanhGiaCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tcdg' => $paramObj->pMa_tcdg ?? null,
            'pId_diem' => $paramObj->pId_diem ?? null,
            'pDiem_dg' => $paramObj->pDiem_dg ?? null,
            'pKy_hieu' => $paramObj->pKy_hieu ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmTCDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @param string $Id_diem
     * @param float $Diem_dg
     * @param string $Ky_hieu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null, string $Id_diem = null, float $Diem_dg = null, string $Ky_hieu = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg,
            'pId_diem' => $Id_diem,
            'pDiem_dg' => $Diem_dg,
            'pKy_hieu' => $Ky_hieu,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
