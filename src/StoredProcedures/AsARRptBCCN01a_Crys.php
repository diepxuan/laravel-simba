<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARRptBCCN01a_Crys
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN01a_Crys', [
            'ma_cty' => $paramObj->pMa_cty ?? $paramObj->ma_cty ?? null,
            'Ngay1' => $paramObj->pNgay1 ?? $paramObj->Ngay1 ?? null,
            'Ngay2' => $paramObj->pNgay2 ?? $paramObj->Ngay2 ?? null,
            'Tk' => $paramObj->pTk ?? $paramObj->Tk ?? null,
            'ma_kh' => $paramObj->pMa_kh ?? $paramObj->ma_kh ?? null,
            'ma_nt' => $paramObj->pMa_nt ?? $paramObj->ma_nt ?? null,
        ], $connection);
    }
}
