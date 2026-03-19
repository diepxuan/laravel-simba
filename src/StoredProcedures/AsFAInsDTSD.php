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

class AsFAInsDTSD
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAInsDTSD', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pNgay' => $paramObj->pNgay ?? null,
            'pLoai_dt' => $paramObj->pLoai_dt ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pTk_ts' => $paramObj->pTk_ts ?? null,
            'pTk_kh' => $paramObj->pTk_kh ?? null,
            'pTk_cp' => $paramObj->pTk_cp ?? null,
            'pCdate' => $paramObj->pCdate ?? null,
            'pCuser' => $paramObj->pCuser ?? null,
            'pLdate' => $paramObj->pLdate ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
        ], $connection);
    }
}
