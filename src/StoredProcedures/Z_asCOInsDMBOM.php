<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asCOInsDMBOM
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCOInsDMBOM', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_lenh'  => $params['pMa_lenh'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pCo_sp'    => $params['pCo_sp'] ?? null,
            'pMa_vt'    => $params['pMa_vt'] ?? null,
            'pCo_vt'    => $params['pCo_vt'] ?? null,
            'pTen_vt'   => $params['pTen_vt'] ?? null,
            'pDvt'      => $params['pDvt'] ?? null,
            'pHe_so'    => $params['pHe_so'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pGhi_chu'  => $params['pGhi_chu'] ?? null,
            'pSl_hs'    => $params['pSl_hs'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }
}