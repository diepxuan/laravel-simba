<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_TestDyn
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_TestDyn', [
            'pMa_cty'   => $paramObj->pMa_cty ?? '',
            'pNgay1'    => $paramObj->pNgay1 ?? '',
            'pNgay2'    => $paramObj->pNgay2 ?? '',
            'pDien_giai' => $paramObj->pDien_giai ?? '',
            'pMa_ts'    => $paramObj->pMa_ts ?? '',
            'pMa_vt'    => $paramObj->pMa_vt ?? '',
            'pMa_phi'   => $paramObj->pMa_phi ?? '',
            'pMa_spct'  => $paramObj->pMa_spct ?? '',
            'pTk'       => $paramObj->pTk ?? '',
        ], $connection);
    }
}