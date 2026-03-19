<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptBK052
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBK052', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pNgay1'  => $paramObj->pNgay1 ?? null,
            'pNgay2'  => $paramObj->pNgay2 ?? null,
            'pMa_kh'  => $paramObj->pMa_kh ?? null,
            'pMa_nhkh'  => $paramObj->pMa_nhkh ?? null,
            'pMa_vt'  => $paramObj->pMa_vt ?? null,
            'pMa_nhvt'  => $paramObj->pMa_nhvt ?? null,
            'pTK_VT'  => $paramObj->pTK_VT ?? null,
            'pMa_kho'  => $paramObj->pMa_kho ?? null,
            'pMa_bp'  => $paramObj->pMa_bp ?? null,
            'pMa_nvkd'  => $paramObj->pMa_nvkd ?? null,
            'pMa_nt'  => $paramObj->pMa_nt ?? null,
            'pMa_hd'  => $paramObj->pMa_hd ?? null,
            'pMa_Nhhd'  => $paramObj->pMa_Nhhd ?? null,
            'pSo_DH'  => $paramObj->pSo_DH ?? null,
            'pSoct1'  => $paramObj->pSoct1 ?? null,
            'pSoct2'  => $paramObj->pSoct2 ?? null,
            'pMa_plkh1'  => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2'  => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3'  => $paramObj->pMa_plkh3 ?? null,
            'pMa_plvt1'  => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2'  => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3'  => $paramObj->pMa_plvt3 ?? null,
        ], $connection);
    }
}
