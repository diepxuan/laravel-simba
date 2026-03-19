<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:52:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARPhanBoThanhToan
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARPhanBoThanhToan', [
            'pMa_cty'   => $paramObj->pMa_cty ?? '001',
            'pTk_pt'    => $paramObj->pTk_pt ?? '131',
            'pMa_kh'    => $paramObj->pMa_kh ?? '',
            'pNgay_ct1' => $paramObj->pNgay_ct1 ?? '20150401',
            'pNgay_ct2' => $paramObj->pNgay_ct2 ?? '20150630',
        ], $connection);
    }
}
