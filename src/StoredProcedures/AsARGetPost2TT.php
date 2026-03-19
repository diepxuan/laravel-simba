<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARGetPost2TT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetPost2TT', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pLoai_ct'    => $paramObj->pLoai_ct ?? null,
            'pSo1'        => $paramObj->pSo1 ?? null,
            'pSo2'        => $paramObj->pSo2 ?? null,
            'pNgay1'      => $paramObj->pNgay1 ?? null,
            'pNgay2'      => $paramObj->pNgay2 ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? null,
            'pTk'         => $paramObj->pTk ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
        ], $connection);
    }
}