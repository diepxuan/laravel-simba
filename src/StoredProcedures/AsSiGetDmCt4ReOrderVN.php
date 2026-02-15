<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiGetDmCt4ReOrderVN
{
    /**
     * Call stored procedure asSiGetDmCt4ReOrderVN
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetDmCt4ReOrderVN', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetDmCt4ReOrderVN with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
