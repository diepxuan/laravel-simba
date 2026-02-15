<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsreportresx
{
    /**
     * Call stored procedure asInsreportresx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsreportresx', [
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
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsreportresx with named parameters
     *
     * @param string $Menuid
     * @param string $Ma_mau
     * @param string $Language
     * @param string $Ten_mau
     * @param string $Title
     * @param string $Formated_col_list
     * @param string $Ct_formated_col_list
     * @param string $Formated_col_list_nt
     * @param string $Ct_formated_col_list_nt
     * @param string $Description
     * @param string $Mau_so_qd15
     * @param string $Mau_so_qd48
     * @param bool $Auto_format
     * @param string $Hide_col_list
     * @param string $Hide_col_list_nt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Menuid = null, string $Ma_mau = null, string $Language = null, string $Ten_mau = null, string $Title = null, string $Formated_col_list = null, string $Ct_formated_col_list = null, string $Formated_col_list_nt = null, string $Ct_formated_col_list_nt = null, string $Description = null, string $Mau_so_qd15 = null, string $Mau_so_qd48 = null, bool $Auto_format = null, string $Hide_col_list = null, string $Hide_col_list_nt = null, int $Ret = null): Collection
    {
        $params = [
            'pMenuid' => $Menuid,
            'pMa_mau' => $Ma_mau,
            'pLanguage' => $Language,
            'pTen_mau' => $Ten_mau,
            'pTitle' => $Title,
            'pFormated_col_list' => $Formated_col_list,
            'pCt_formated_col_list' => $Ct_formated_col_list,
            'pFormated_col_list_nt' => $Formated_col_list_nt,
            'pCt_formated_col_list_nt' => $Ct_formated_col_list_nt,
            'pDescription' => $Description,
            'pMau_so_qd15' => $Mau_so_qd15,
            'pMau_so_qd48' => $Mau_so_qd48,
            'pAuto_format' => $Auto_format,
            'pHide_col_list' => $Hide_col_list,
            'pHide_col_list_nt' => $Hide_col_list_nt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
