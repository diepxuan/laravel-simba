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

class AsGLUpdMauBs
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMauBs', [
            'pma_cty'  => $paramObj->pma_cty ?? null,
            'pQd_cdkt'  => $paramObj->pQd_cdkt ?? null,
            'pmau'  => $paramObj->pmau ?? null,
            'pma_so'  => $paramObj->pma_so ?? null,
            'pchi_tieu'  => $paramObj->pchi_tieu ?? null,
            'pcach_tinh'  => $paramObj->pcach_tinh ?? null,
            'ptk'  => $paramObj->ptk ?? null,
            'ptien0'  => $paramObj->ptien0 ?? null,
            'ptien'  => $paramObj->ptien ?? null,
            'ptien_nt0'  => $paramObj->ptien_nt0 ?? null,
            'ptien_nt'  => $paramObj->ptien_nt ?? null,
            'pstt'  => $paramObj->pstt ?? null,
            'pbold'  => $paramObj->pbold ?? null,
            'pin_ck'  => $paramObj->pin_ck ?? null,
            'pts_nv'  => $paramObj->pts_nv ?? null,
            'pcong_no'  => $paramObj->pcong_no ?? null,
            'pngoai_bang'  => $paramObj->pngoai_bang ?? null,
            'psodu_duong'  => $paramObj->psodu_duong ?? null,
            'pxtag'  => $paramObj->pxtag ?? null,
            'pxstt'  => $paramObj->pxstt ?? null,
            'ptm'  => $paramObj->ptm ?? null,
        ], $connection);
    }
}