<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsPH6
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsPH6', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pSo_ct'  => $params['pSo_ct'] ?? null,
            'pNgay_ct'  => $params['pNgay_ct'] ?? null,
            'pCa'  => $params['pCa'] ?? null,
            'pT_tien2'  => $params['pT_tien2'] ?? null,
            'pT_ck'  => $params['pT_ck'] ?? null,
            'pT_thue'  => $params['pT_thue'] ?? null,
            'pT_tt'  => $params['pT_tt'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
