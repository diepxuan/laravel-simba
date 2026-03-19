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

class AsGLInsDMDGTG
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsDMDGTG', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pLoai_dg' => $paramObj->pLoai_dg ?? '',
            'pTk_dgtg' => $paramObj->pTk_dgtg ?? '',
            'pStt' => $paramObj->pStt ?? '',
            'pTk_lai_cltg' => $paramObj->pTk_lai_cltg ?? '',
            'pTk_lo_cltg' => $paramObj->pTk_lo_cltg ?? '',
            'pTk_cltg_cn' => $paramObj->pTk_cltg_cn ?? '',
            'pTen_bt' => $paramObj->pTen_bt ?? '',
            'pDg_kh' => $paramObj->pDg_kh ?? '',
            'pDg_bp' => $paramObj->pDg_bp ?? '',
            'pDg_hd' => $paramObj->pDg_hd ?? '',
            'pDg_spct' => $paramObj->pDg_spct ?? '',
            'pDg_phi' => $paramObj->pDg_phi ?? '',
            'pSo_ct' => $paramObj->pSo_ct ?? '',
            'pKsd' => $paramObj->pKsd ?? '',
            'pLUser' => $paramObj->pLUser ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
