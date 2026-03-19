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
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptCTVT02_crys
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCTVT02_crys', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pNgay1'  => $paramObj->pNgay1 ?? null,
            'pNgay2'  => $paramObj->pNgay2 ?? null,
            'pXml'  => $paramObj->pXml ?? null,
            'pMa_vt'  => $paramObj->pMa_vt ?? null,
            'pMa_kho'  => $paramObj->pMa_kho ?? null,
            'pMa_vitri'  => $paramObj->pMa_vitri ?? null,
            'pMau_bc'  => $paramObj->pMau_bc ?? null,
            'pMa_nt'  => $paramObj->pMa_nt ?? null,
            'pSysMsg1'  => $paramObj->pSysMsg1 ?? null,
            'pSysMsg2'  => $paramObj->pSysMsg2 ?? null,
            'pSysMsg3'  => $paramObj->pSysMsg3 ?? null,
            'pma_vt'  => $paramObj->pma_vt ?? null,
        ], $connection);
    }
}