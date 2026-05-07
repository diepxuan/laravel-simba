<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-07 12:16:25
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Stored Procedure: asARGetDMKH.
 *
 * Lấy danh mục khách hàng/nhà cung cấp/nhân viên.
 * Uses static SQL với OPTION (RECOMPILE) cho optimal execution plan.
 *
 * @param null|string $pMa_cty   Mã công ty (default: current company)
 * @param null|string $pMa_kh    Mã khách hàng prefix search (null/empty = all)
 * @param string      $pModuleId 'AR'=khách hàng, 'AP'=nhà cung cấp, 'CA'=nhân viên
 */
class AsARGetDMKH
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetDMKH', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pMa_kh'    => $paramObj->pMa_kh ?? null,
            'pStruct'   => $paramObj->pStruct ?? '0',
            'pModuleId' => $paramObj->pModuleId ?? '',
        ], $connection);
    }

    /**
     * Lấy danh sách khách hàng (module AR).
     *
     * @param null|string $maCty  Mã công ty
     * @param null|string $search Prefix search theo mã khách hàng
     */
    public static function getCustomers(?string $maCty = null, ?string $search = null): Collection
    {
        return self::call([
            'pMa_cty'   => $maCty ?? SModel::CTY,
            'pMa_kh'    => $search,
            'pStruct'   => '0',
            'pModuleId' => 'AR',
        ]);
    }
}
