<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCAUpdLaiKu
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdLaiKu', [
            'pMa_cty'           => $paramObj->pMa_cty ?? null,
            'pNgay_tra'         => $paramObj->pNgay_tra ?? null,
            'pMa_ku'            => $paramObj->pMa_ku ?? null,
            'pNam'              => $paramObj->pNam ?? null,
            'pThang'            => $paramObj->pThang ?? null,
            'pTien_lai_tk'      => $paramObj->pTien_lai_tk ?? null,
            'pTien_lai_tk_nt'   => $paramObj->pTien_lai_tk_nt ?? null,
            'pTien_goc_tk'      => $paramObj->pTien_goc_tk ?? null,
            'pTien_goc_tk_nt'   => $paramObj->pTien_goc_tk_nt ?? null,
            'pTien_lai_qh'      => $paramObj->pTien_lai_qh ?? null,
            'pTien_lai_qh_nt'   => $paramObj->pTien_lai_qh_nt ?? null,
            'pTien_goc_qh'      => $paramObj->pTien_goc_qh ?? null,
            'pTien_goc_qh_nt'   => $paramObj->pTien_goc_qh_nt ?? null,
            'pSua_lai'          => $paramObj->pSua_lai ?? null,
            'pSua_goc'          => $paramObj->pSua_goc ?? null,
            'pLUser'            => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
