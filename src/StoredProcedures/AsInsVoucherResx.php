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

class AsInsVoucherResx
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsVoucherResx', [
            'pVoucher_code' => $paramObj->pVoucher_code ?? '',
            'pLanguage' => $paramObj->pLanguage ?? '',
            'pPh_formated_col_list' => $paramObj->pPh_formated_col_list ?? '',
            'pCt_formated_col_list' => $paramObj->pCt_formated_col_list ?? '',
            'pDescription' => $paramObj->pDescription ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
