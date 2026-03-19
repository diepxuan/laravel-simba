<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrInsChamCongKhac
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsChamCongKhac', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pNam'  => $paramObj->pNam ?? null,
            'pThang'  => $paramObj->pThang ?? null,
            'pNgay'  => $paramObj->pNgay ?? null,
            'pId'  => $paramObj->pId ?? null,
            'pMa_cham_cong'  => $paramObj->pMa_cham_cong ?? null,
            'pKh_cham_cong'  => $paramObj->pKh_cham_cong ?? null,
            'pGio_vao'  => $paramObj->pGio_vao ?? null,
            'pPhut_vao'  => $paramObj->pPhut_vao ?? null,
            'pGio_ra'  => $paramObj->pGio_ra ?? null,
            'pPhut_ra'  => $paramObj->pPhut_ra ?? null,
            'pThem_gio'  => $paramObj->pThem_gio ?? null,
            'pCuser'  => $paramObj->pCuser ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}