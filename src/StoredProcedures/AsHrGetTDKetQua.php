<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetTDKetQua
{
    /**
     * Call stored procedure asHrGetTDKetQua
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetTDKetQua', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pMa_mon_thi' => $params['pMa_mon_thi'] ?? null,
            'pDe_so' => $params['pDe_so'] ?? null,
            'pId' => $params['pId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetTDKetQua with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Ma_mon_thi
     * @param string $De_so
     * @param string $Id
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Ma_mon_thi = null, string $De_so = null, string $Id = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pMa_mon_thi' => $Ma_mon_thi,
            'pDe_so' => $De_so,
            'pId' => $Id
        ];
        
        return self::call($params);
    }
}
