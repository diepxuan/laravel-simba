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

class AsINRptF5CD05
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5CD05', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pMa_vt' => $paramObj->pMa_vt ?? '',
            'pMa_kho' => $paramObj->pMa_kho ?? '',
            'pMa_vitri' => $paramObj->pMa_vitri ?? '',
            'pTk_vt' => $paramObj->pTk_vt ?? '',
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? '',
            'pNgay' => $paramObj->pNgay ?? '',
            'pMa_nt' => $paramObj->pMa_nt ?? '',
            'pdvt' => $paramObj->pdvt ?? '',
            'pMa_lo' => $paramObj->pMa_lo ?? ''
        ], $connection);
    }
}
