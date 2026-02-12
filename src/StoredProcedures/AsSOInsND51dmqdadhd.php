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

class AsSOInsND51dmqdadhd
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51dmqdadhd', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_qd'  => $params['pMa_qd'] ?? null,
            'pNgay_qd'  => $params['pNgay_qd'] ?? null,
            'pNgay_ad'  => $params['pNgay_ad'] ?? null,
            'pNgay_hl'  => $params['pNgay_hl'] ?? null,
            'pTen_cty'  => $params['pTen_cty'] ?? null,
            'pGiam_doc'  => $params['pGiam_doc'] ?? null,
            'pDangky_kd'  => $params['pDangky_kd'] ?? null,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pCq_thue'  => $params['pCq_thue'] ?? null,
            'pHt_tb'  => $params['pHt_tb'] ?? null,
            'pNcc'  => $params['pNcc'] ?? null,
            'pHdmd'  => $params['pHdmd'] ?? null,
            'pTnbp'  => $params['pTnbp'] ?? null,
            'pCdate'  => $params['pCdate'] ?? null,
            'pCuser'  => $params['pCuser'] ?? null,
            'pLdate'  => $params['pLdate'] ?? null,
            'pLuser'  => $params['pLuser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
