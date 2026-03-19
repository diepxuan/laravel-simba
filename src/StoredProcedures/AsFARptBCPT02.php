<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsFARptBCPT02
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFARptBCPT02', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNgay_dk' => $paramObj->pNgay_dk ?? null,
            'pNgay_ck' => $paramObj->pNgay_ck ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_Nhts1' => $paramObj->pMa_Nhts1 ?? null,
            'pMa_Nhts2' => $paramObj->pMa_Nhts2 ?? null,
            'pMa_Nhts3' => $paramObj->pMa_Nhts3 ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
        ], $connection);
    }
}
