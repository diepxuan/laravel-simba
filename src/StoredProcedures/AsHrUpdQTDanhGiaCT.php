<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdQTDanhGiaCT
{
    /**
     * Call stored procedure asHrUpdQTDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTDanhGiaCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtdg' => $paramObj->pId_qtdg ?? null,
            'pMa_tcdg' => $paramObj->pMa_tcdg ?? null,
            'pDiem_dg' => $paramObj->pDiem_dg ?? null,
            'pDiem_toi_da' => $paramObj->pDiem_toi_da ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtdg
     * @param string $Ma_tcdg
     * @param float $Diem_dg
     * @param float $Diem_toi_da
     * @param string $Ghi_chu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtdg = null, string $Ma_tcdg = null, float $Diem_dg = null, float $Diem_toi_da = null, string $Ghi_chu = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtdg' => $Id_qtdg,
            'pMa_tcdg' => $Ma_tcdg,
            'pDiem_dg' => $Diem_dg,
            'pDiem_toi_da' => $Diem_toi_da,
            'pGhi_chu' => $Ghi_chu,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
