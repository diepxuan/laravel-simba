<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdateReportResX_Export2excel_col_list
{
    /**
     * Call stored procedure asUpdateReportResX_Export2excel_col_list
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdateReportResX_Export2excel_col_list', [
            'pmenuid' => $paramObj->pmenuid ?? null,
            'pma_mau' => $paramObj->pma_mau ?? null,
            'plang_id' => $paramObj->plang_id ?? null,
            'pExport2excel_col_list' => $paramObj->pExport2excel_col_list ?? null,
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdateReportResX_Export2excel_col_list with named parameters
     *
     * @param string $menuid
     * @param string $ma_mau
     * @param string $lang_id
     * @param string $Export2excel_col_list
     * @param mixed $Menuid
     * @param mixed $Ma_mau
     * @return Collection
     */
    public static function callWithParams(string $menuid = null, string $ma_mau = null, string $lang_id = null, string $Export2excel_col_list = null, mixed $Menuid = null, mixed $Ma_mau = null): Collection
    {
        $params = [
            'pmenuid' => $menuid,
            'pma_mau' => $ma_mau,
            'plang_id' => $lang_id,
            'pExport2excel_col_list' => $Export2excel_col_list,
            'pMenuid' => $Menuid,
            'pMa_mau' => $Ma_mau
        ];

        return self::call($params);
    }
}
