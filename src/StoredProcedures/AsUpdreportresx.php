<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdreportresx
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdreportresx', [
            'pKey_Menuid' => $params['pKey_Menuid'] ?? null,
            'pKey_Ma_mau' => $params['pKey_Ma_mau'] ?? null,
            'pKey_Language' => $params['pKey_Language'] ?? null,
            'pMenuid' => $params['pMenuid'] ?? null,
            'pMa_mau' => $params['pMa_mau'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null,
            'pTen_mau' => $params['pTen_mau'] ?? null,
            'pTitle' => $params['pTitle'] ?? null,
            'pFormated_col_list' => $params['pFormated_col_list'] ?? null,
            'pCt_formated_col_list' => $params['pCt_formated_col_list'] ?? null,
            'pFormated_col_list_nt' => $params['pFormated_col_list_nt'] ?? null,
            'pCt_formated_col_list_nt' => $params['pCt_formated_col_list_nt'] ?? null,
            'pDescription' => $params['pDescription'] ?? null,
            'pMau_so_qd15' => $params['pMau_so_qd15'] ?? null,
            'pMau_so_qd48' => $params['pMau_so_qd48'] ?? null,
            'pAuto_format' => $params['pAuto_format'] ?? null,
            'pHide_col_list' => $params['pHide_col_list'] ?? null,
            'pHide_col_list_nt' => $params['pHide_col_list_nt'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
