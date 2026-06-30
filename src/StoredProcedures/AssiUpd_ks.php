<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Stored procedure assiUpd_ks.
 *
 * SMKS.dll uses this procedure to update the data lock date for one Simba
 * company. The output parameter @pRet returns 0 on success.
 */
class AssiUpd_ks
{
    /**
     * Call stored procedure assiUpd_ks
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assiUpd_ks', [
            'pMa_cty'  => $paramObj->pMa_cty ?? SModel::CTY,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pRet'     => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure assiUpd_ks with named parameters
     *
     * @return Collection
     */
    public static function callWithParams(?string $Ma_cty = null, \DateTimeInterface|string|null $Ngay_ks = null): Collection
    {
        return self::call([
            'pMa_cty' => $Ma_cty,
            'pNgay_ks' => $Ngay_ks,
        ]);
    }
}
