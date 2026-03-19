<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:25
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPGetPost2TT
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPGetPost2TT', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pLoai_ct'   => $paramObj->pLoai_ct ?? '',
            'pSo1'       => $paramObj->pSo1 ?? '',
            'pSo2'       => $paramObj->pSo2 ?? '',
            'pNgay1'     => $paramObj->pNgay1 ?? null,
            'pNgay2'     => $paramObj->pNgay2 ?? null,
            'pMa_kh'     => $paramObj->pMa_kh ?? '',
            'pTk'        => $paramObj->pTk ?? '',
            'pDien_giai' => $paramObj->pDien_giai ?? '',
        ], $connection);
    }
}
