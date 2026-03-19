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
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asCOInsDMBOM
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCOInsDMBOM', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pMa_lenh'  => $paramObj->pMa_lenh ?? null,
            'pMa_spct'  => $paramObj->pMa_spct ?? null,
            'pCo_sp'    => $paramObj->pCo_sp ?? null,
            'pMa_vt'    => $paramObj->pMa_vt ?? null,
            'pCo_vt'    => $paramObj->pCo_vt ?? null,
            'pTen_vt'   => $paramObj->pTen_vt ?? null,
            'pDvt'      => $paramObj->pDvt ?? null,
            'pHe_so'    => $paramObj->pHe_so ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pGhi_chu'  => $paramObj->pGhi_chu ?? null,
            'pSl_hs'    => $paramObj->pSl_hs ?? null,
            'pRet'      => $paramObj->pRet ?? null,
        ], $connection);
    }
}