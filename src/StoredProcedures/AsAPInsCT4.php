<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:28
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsCT4
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsCT4', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pStt_rec'   => $paramObj->pStt_rec ?? null,
            'pStt_rec0'  => $paramObj->pStt_rec0 ?? null,
            'pTk'        => $paramObj->pTk ?? null,
            'pMa_kh'     => $paramObj->pMa_kh ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? '',
            'pMa_nt'     => $paramObj->pMa_nt ?? null,
            'pTy_gia'    => $paramObj->pTy_gia ?? 0.0,
            'pPs_co'     => $paramObj->pPs_co ?? 0.0,
            'pPs_co_nt'  => $paramObj->pPs_co_nt ?? 0.0,
            'pPs_no'     => $paramObj->pPs_no ?? 0.0,
            'pPs_no_nt'  => $paramObj->pPs_no_nt ?? 0.0,
            'pNh_dk'     => $paramObj->pNh_dk ?? '',
            'pMa_lo'     => $paramObj->pMa_lo ?? '',
            'pMa_bp'     => $paramObj->pMa_bp ?? '',
            'pMa_hd'     => $paramObj->pMa_hd ?? '',
            'pMa_phi'    => $paramObj->pMa_phi ?? '',
            'pMa_spct'   => $paramObj->pMa_spct ?? '',
        ], $connection);
    }
}
