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

class AsCAUpdLaiKu
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdLaiKu', [
            'pMa_cty'           => $params['pMa_cty'] ?? null,
            'pNgay_tra'         => $params['pNgay_tra'] ?? null,
            'pMa_ku'            => $params['pMa_ku'] ?? null,
            'pNam'              => $params['pNam'] ?? null,
            'pThang'            => $params['pThang'] ?? null,
            'pTien_lai_tk'      => $params['pTien_lai_tk'] ?? null,
            'pTien_lai_tk_nt'   => $params['pTien_lai_tk_nt'] ?? null,
            'pTien_goc_tk'      => $params['pTien_goc_tk'] ?? null,
            'pTien_goc_tk_nt'   => $params['pTien_goc_tk_nt'] ?? null,
            'pTien_lai_qh'      => $params['pTien_lai_qh'] ?? null,
            'pTien_lai_qh_nt'   => $params['pTien_lai_qh_nt'] ?? null,
            'pTien_goc_qh'      => $params['pTien_goc_qh'] ?? null,
            'pTien_goc_qh_nt'   => $params['pTien_goc_qh_nt'] ?? null,
            'pSua_lai'          => $params['pSua_lai'] ?? null,
            'pSua_goc'          => $params['pSua_goc'] ?? null,
            'pLUser'            => $params['pLUser'] ?? null,
        ], $connection);
    }
}
