<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPGetPost2TT_APTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPGetPost2TT_APTT', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pTk_pt'    => $params['pTk_pt'] ?? '131',
            'pMa_kh'    => $params['pMa_kh'] ?? null,
            'pNgay_ct'  => $params['pNgay_ct'] ?? null,
            'pLoai'     => $params['pLoai'] ?? null,
        ], $connection);
    }
}
