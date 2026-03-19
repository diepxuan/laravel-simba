<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:03:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLInsNB
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsNB', [
            'pMa_cty'     => $paramObj->pMa_cty ?? SModel::CTY,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? null,
            'pTk'         => $paramObj->pTk ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pPs_co'      => $paramObj->pPs_co ?? null,
            'pPs_co_nt'   => $paramObj->pPs_co_nt ?? null,
            'pPs_no'      => $paramObj->pPs_no ?? null,
            'pPs_no_nt'   => $paramObj->pPs_no_nt ?? null,
            'pLUser'      => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
