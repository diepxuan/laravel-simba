<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asARInsDMNgHKH
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asARInsDMNgHKH', [
            'pId_cn'  => $paramObj->pId_cn ?? null,
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pMa_kh'  => $paramObj->pMa_kh ?? null,
            'pMa_nh'  => $paramObj->pMa_nh ?? null,
            'pSo_tk'  => $paramObj->pSo_tk ?? null,
            'pTen_nh'  => $paramObj->pTen_nh ?? null,
            'pChi_nhanh'  => $paramObj->pChi_nhanh ?? null,
            'pTinh_tp'  => $paramObj->pTinh_tp ?? null,
            'pTel'  => $paramObj->pTel ?? null,
            'pFax'  => $paramObj->pFax ?? null,
            'pEmail'  => $paramObj->pEmail ?? null,
            'pNguoi_gd'  => $paramObj->pNguoi_gd ?? null,
            'pKsd'  => $paramObj->pKsd ?? null,
            'pLUser'  => $paramObj->pLUser ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
