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

class AsInsVoucherResx
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsVoucherResx', [
            'pVoucher_code' => $params['pVoucher_code'] ?? '',
            'pLanguage' => $params['pLanguage'] ?? '',
            'pPh_formated_col_list' => $params['pPh_formated_col_list'] ?? '',
            'pCt_formated_col_list' => $params['pCt_formated_col_list'] ?? '',
            'pDescription' => $params['pDescription'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
