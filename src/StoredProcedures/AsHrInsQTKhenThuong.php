<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrInsQTKhenThuong
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTKhenThuong', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pId' => $paramObj->pId ?? '',
            'pId_qtktkl' => $paramObj->pId_qtktkl ?? '',
            'pLoai_ktkl' => $paramObj->pLoai_ktkl ?? '',
            'pMa_ktkl' => $paramObj->pMa_ktkl ?? '',
            'pNoi_dung' => $paramObj->pNoi_dung ?? '',
            'pGhi_chu' => $paramObj->pGhi_chu ?? '',
            'pTai_lieu' => $paramObj->pTai_lieu ?? '',
            'pCuser' => $paramObj->pCuser ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
