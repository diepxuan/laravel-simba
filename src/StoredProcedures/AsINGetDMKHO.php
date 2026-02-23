<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Diepxuan\Simba\StoredProcedures\ProcedureCaller;
use Illuminate\Support\Collection;

class AsINGetDMKHO
{
    /**
     * Call stored procedure asINGetDMKHO
     * 
     * Note: Stored procedure gốc chỉ có 3 tham số (@pMa_cty, @pMa_kho, @pStruct)
     * nhưng ứng dụng có thể truyền 4 tham số (thêm @pLanguage).
     * Phương thức này sẽ filter chỉ lấy 3 tham số thực tế.
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Filter chỉ lấy 3 tham số thực tế, bỏ qua pLanguage
        $procedureParams = [];
        
        // Support cả pMa_cty và pMa_Cty (case insensitive)
        if (isset($params['pMa_cty'])) {
            $procedureParams['pMa_cty'] = $params['pMa_cty'];
        } elseif (isset($params['pMa_Cty'])) {
            $procedureParams['pMa_cty'] = $params['pMa_Cty'];
        } else {
            $procedureParams['pMa_cty'] = null;
        }
        
        if (isset($params['pMa_kho'])) {
            $procedureParams['pMa_kho'] = $params['pMa_kho'];
        } else {
            $procedureParams['pMa_kho'] = null;
        }
        
        if (isset($params['pStruct'])) {
            $procedureParams['pStruct'] = $params['pStruct'];
        } else {
            $procedureParams['pStruct'] = '0';
        }
        
        // KHÔNG thêm pLanguage vào procedureParams

        return ProcedureCaller::call('asINGetDMKHO', $procedureParams, $connection);
    }

    /**
     * Call stored procedure asINGetDMKHO with named parameters
     * 
     * Support cả 4 tham số để tương thích với ứng dụng hiện tại
     * nhưng chỉ truyền 3 tham số thực tế đến stored procedure
     *
     * @param string $Ma_cty
     * @param string $Ma_kho
     * @param string $Struct
     * @param string $Language (ignored - for backward compatibility)
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kho = null, string $Struct = '0', string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kho' => $Ma_kho,
            'pStruct' => $Struct,
            // pLanguage không được thêm vào
        ];

        return self::call($params);
    }
}
