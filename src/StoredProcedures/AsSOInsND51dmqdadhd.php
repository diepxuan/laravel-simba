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

class AsSOInsND51dmqdadhd
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51dmqdadhd', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pMa_qd'  => $paramObj->pMa_qd ?? null,
            'pNgay_qd'  => $paramObj->pNgay_qd ?? null,
            'pNgay_ad'  => $paramObj->pNgay_ad ?? null,
            'pNgay_hl'  => $paramObj->pNgay_hl ?? null,
            'pTen_cty'  => $paramObj->pTen_cty ?? null,
            'pGiam_doc'  => $paramObj->pGiam_doc ?? null,
            'pDangky_kd'  => $paramObj->pDangky_kd ?? null,
            'pMa_bp'  => $paramObj->pMa_bp ?? null,
            'pCq_thue'  => $paramObj->pCq_thue ?? null,
            'pHt_tb'  => $paramObj->pHt_tb ?? null,
            'pNcc'  => $paramObj->pNcc ?? null,
            'pHdmd'  => $paramObj->pHdmd ?? null,
            'pTnbp'  => $paramObj->pTnbp ?? null,
            'pCdate'  => $paramObj->pCdate ?? null,
            'pCuser'  => $paramObj->pCuser ?? null,
            'pLdate'  => $paramObj->pLdate ?? null,
            'pLuser'  => $paramObj->pLuser ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
