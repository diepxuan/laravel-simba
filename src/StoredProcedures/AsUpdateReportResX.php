<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdateReportResX
{
    /**
     * Call stored procedure asUpdateReportResX
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdateReportResX', [
            'pmenuid' => $paramObj->pmenuid ?? null,
            'pma_mau' => $paramObj->pma_mau ?? null,
            'plang_id' => $paramObj->plang_id ?? null,
            'pformated_col_list' => $paramObj->pformated_col_list ?? null,
            'pvnd_nt' => $paramObj->pvnd_nt ?? null,
            'pPh_Ct' => $paramObj->pPh_Ct ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdateReportResX with named parameters
     *
     * @param string $menuid
     * @param string $ma_mau
     * @param string $lang_id
     * @param string $formated_col_list
     * @param string $vnd_nt
     * @param string $Ph_Ct
     * @param string $User
     * @param mixed $Menuid
     * @param mixed $Ma_mau
     * @return Collection
     */
    public static function callWithParams(string $menuid = null, string $ma_mau = null, string $lang_id = null, string $formated_col_list = null, string $vnd_nt = null, string $Ph_Ct = null, string $User = null, mixed $Menuid = null, mixed $Ma_mau = null): Collection
    {
        $params = [
            'pmenuid' => $menuid,
            'pma_mau' => $ma_mau,
            'plang_id' => $lang_id,
            'pformated_col_list' => $formated_col_list,
            'pvnd_nt' => $vnd_nt,
            'pPh_Ct' => $Ph_Ct,
            'pUser' => $User,
            'pMenuid' => $Menuid,
            'pMa_mau' => $Ma_mau
        ];

        return self::call($params);
    }
}
