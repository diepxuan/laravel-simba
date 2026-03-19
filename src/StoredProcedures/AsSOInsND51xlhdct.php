<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOInsND51xlhdct
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51xlhdct', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pKieu_xl'  => $paramObj->pKieu_xl ?? null,
            'pMa_tb'  => $paramObj->pMa_tb ?? null,
            'pMa_chung'  => $paramObj->pMa_chung ?? null,
            'pTen_loai'  => $paramObj->pTen_loai ?? null,
            'pMau_so'  => $paramObj->pMau_so ?? null,
            'pSo_seri'  => $paramObj->pSo_seri ?? null,
            'pTu_so'  => $paramObj->pTu_so ?? null,
            'pDen_so'  => $paramObj->pDen_so ?? null,
            'pSo_luong'  => $paramObj->pSo_luong ?? null,
            'pLien_hd'  => $paramObj->pLien_hd ?? null,
            'pGhi_chu'  => $paramObj->pGhi_chu ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
