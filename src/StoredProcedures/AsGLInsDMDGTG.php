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

class AsGLInsDMDGTG
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsDMDGTG', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pLoai_dg' => $params['pLoai_dg'] ?? '',
            'pTk_dgtg' => $params['pTk_dgtg'] ?? '',
            'pStt' => $params['pStt'] ?? '',
            'pTk_lai_cltg' => $params['pTk_lai_cltg'] ?? '',
            'pTk_lo_cltg' => $params['pTk_lo_cltg'] ?? '',
            'pTk_cltg_cn' => $params['pTk_cltg_cn'] ?? '',
            'pTen_bt' => $params['pTen_bt'] ?? '',
            'pDg_kh' => $params['pDg_kh'] ?? '',
            'pDg_bp' => $params['pDg_bp'] ?? '',
            'pDg_hd' => $params['pDg_hd'] ?? '',
            'pDg_spct' => $params['pDg_spct'] ?? '',
            'pDg_phi' => $params['pDg_phi'] ?? '',
            'pSo_ct' => $params['pSo_ct'] ?? '',
            'pKsd' => $params['pKsd'] ?? '',
            'pLUser' => $params['pLUser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
