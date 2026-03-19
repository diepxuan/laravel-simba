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

class AsGLUpdDMDGTG
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdDMDGTG', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pLoai_dg'  => $paramObj->pLoai_dg ?? null,
            'pTk_dgtg'  => $paramObj->pTk_dgtg ?? null,
            'pStt'  => $paramObj->pStt ?? null,
            'pTk_lai_cltg'  => $paramObj->pTk_lai_cltg ?? null,
            'pTk_lo_cltg'  => $paramObj->pTk_lo_cltg ?? null,
            'pTk_cltg_cn'  => $paramObj->pTk_cltg_cn ?? null,
            'pTen_bt'  => $paramObj->pTen_bt ?? null,
            'pDg_kh'  => $paramObj->pDg_kh ?? null,
            'pDg_bp'  => $paramObj->pDg_bp ?? null,
            'pDg_hd'  => $paramObj->pDg_hd ?? null,
            'pDg_spct'  => $paramObj->pDg_spct ?? null,
            'pDg_phi'  => $paramObj->pDg_phi ?? null,
            'pSo_ct'  => $paramObj->pSo_ct ?? null,
            'pKsd'  => $paramObj->pKsd ?? null,
            'pLUser'  => $paramObj->pLUser ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}