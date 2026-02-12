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

class AsHrInsChamCongKhac
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsChamCongKhac', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pNam'  => $params['pNam'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNgay'  => $params['pNgay'] ?? null,
            'pId'  => $params['pId'] ?? null,
            'pMa_cham_cong'  => $params['pMa_cham_cong'] ?? null,
            'pKh_cham_cong'  => $params['pKh_cham_cong'] ?? null,
            'pGio_vao'  => $params['pGio_vao'] ?? null,
            'pPhut_vao'  => $params['pPhut_vao'] ?? null,
            'pGio_ra'  => $params['pGio_ra'] ?? null,
            'pPhut_ra'  => $params['pPhut_ra'] ?? null,
            'pThem_gio'  => $params['pThem_gio'] ?? null,
            'pCuser'  => $params['pCuser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}