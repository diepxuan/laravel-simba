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

class Z_asARInsDMNgHKH
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asARInsDMNgHKH', [
            'pId_cn'  => $params['pId_cn'] ?? null,
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? null,
            'pMa_nh'  => $params['pMa_nh'] ?? null,
            'pSo_tk'  => $params['pSo_tk'] ?? null,
            'pTen_nh'  => $params['pTen_nh'] ?? null,
            'pChi_nhanh'  => $params['pChi_nhanh'] ?? null,
            'pTinh_tp'  => $params['pTinh_tp'] ?? null,
            'pTel'  => $params['pTel'] ?? null,
            'pFax'  => $params['pFax'] ?? null,
            'pEmail'  => $params['pEmail'] ?? null,
            'pNguoi_gd'  => $params['pNguoi_gd'] ?? null,
            'pKsd'  => $params['pKsd'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
