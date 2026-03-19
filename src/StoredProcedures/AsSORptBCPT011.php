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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptBCPT011
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT011', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pNgay1' => $paramObj->pNgay1 ?? '',
            'pNgay2' => $paramObj->pNgay2 ?? '',
            'pSoct1' => $paramObj->pSoct1 ?? '',
            'pSoct2' => $paramObj->pSoct2 ?? '',
            'pMa_kh' => $paramObj->pMa_kh ?? '',
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? '',
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? '',
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? '',
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? '',
            'pMa_hd' => $paramObj->pMa_hd ?? '',
            'pMa_nhhd' => $paramObj->pMa_nhhd ?? '',
            'pMa_NT' => $paramObj->pMa_NT ?? '',
            'pMa_vt' => $paramObj->pMa_vt ?? '',
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? '',
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? '',
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? '',
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? '',
            'pMa_bp' => $paramObj->pMa_bp ?? '',
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? '',
            'pMa_TT' => $paramObj->pMa_TT ?? '',
            'pStatus' => $paramObj->pStatus ?? ''
        ], $connection);
    }
}
