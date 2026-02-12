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

class AsGLUpdDMDGTG
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdDMDGTG', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pLoai_dg'  => $params['pLoai_dg'] ?? null,
            'pTk_dgtg'  => $params['pTk_dgtg'] ?? null,
            'pStt'  => $params['pStt'] ?? null,
            'pTk_lai_cltg'  => $params['pTk_lai_cltg'] ?? null,
            'pTk_lo_cltg'  => $params['pTk_lo_cltg'] ?? null,
            'pTk_cltg_cn'  => $params['pTk_cltg_cn'] ?? null,
            'pTen_bt'  => $params['pTen_bt'] ?? null,
            'pDg_kh'  => $params['pDg_kh'] ?? null,
            'pDg_bp'  => $params['pDg_bp'] ?? null,
            'pDg_hd'  => $params['pDg_hd'] ?? null,
            'pDg_spct'  => $params['pDg_spct'] ?? null,
            'pDg_phi'  => $params['pDg_phi'] ?? null,
            'pSo_ct'  => $params['pSo_ct'] ?? null,
            'pKsd'  => $params['pKsd'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}