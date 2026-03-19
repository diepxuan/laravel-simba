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

class AsARRptF5BCCN04
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptF5BCCN04', [
            'Ma_cty' => $paramObj->pMa_cty ?? $paramObj->Ma_cty ?? null,
            'Tk' => $paramObj->pTk ?? $paramObj->Tk ?? null,
            'Ma_kh' => $paramObj->pMa_kh ?? $paramObj->Ma_kh ?? null,
            'Ma_loai' => $paramObj->pMa_loai ?? $paramObj->Ma_loai ?? null,
            'Ma' => $paramObj->pMa ?? $paramObj->Ma ?? null,
            'Ngay1' => $paramObj->pNgay1 ?? $paramObj->Ngay1 ?? null,
            'Ngay2' => $paramObj->pNgay2 ?? $paramObj->Ngay2 ?? null,
            'Ma_nt' => $paramObj->pMa_nt ?? $paramObj->Ma_nt ?? null,
            'pMa_hd' => $paramObj->pPMa_hd ?? $paramObj->pMa_hd ?? null,
            'pMa_bp' => $paramObj->pPMa_bp ?? $paramObj->pMa_bp ?? null,
        ], $connection);
    }
}
