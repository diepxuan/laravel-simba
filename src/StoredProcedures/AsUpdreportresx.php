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
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdreportresx
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdreportresx', [
            'pKey_Menuid' => $paramObj->pKey_Menuid ?? null,
            'pKey_Ma_mau' => $paramObj->pKey_Ma_mau ?? null,
            'pKey_Language' => $paramObj->pKey_Language ?? null,
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null,
            'pTen_mau' => $paramObj->pTen_mau ?? null,
            'pTitle' => $paramObj->pTitle ?? null,
            'pFormated_col_list' => $paramObj->pFormated_col_list ?? null,
            'pCt_formated_col_list' => $paramObj->pCt_formated_col_list ?? null,
            'pFormated_col_list_nt' => $paramObj->pFormated_col_list_nt ?? null,
            'pCt_formated_col_list_nt' => $paramObj->pCt_formated_col_list_nt ?? null,
            'pDescription' => $paramObj->pDescription ?? null,
            'pMau_so_qd15' => $paramObj->pMau_so_qd15 ?? null,
            'pMau_so_qd48' => $paramObj->pMau_so_qd48 ?? null,
            'pAuto_format' => $paramObj->pAuto_format ?? null,
            'pHide_col_list' => $paramObj->pHide_col_list ?? null,
            'pHide_col_list_nt' => $paramObj->pHide_col_list_nt ?? null,
            'pRet' => $paramObj->pRet ?? null,
        ], $connection);
    }
}
