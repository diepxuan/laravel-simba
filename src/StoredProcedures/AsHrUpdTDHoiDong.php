<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdTDHoiDong
{
    /**
     * Call stored procedure asHrUpdTDHoiDong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDHoiDong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pTen_cvcm' => $params['pTen_cvcm'] ?? null,
            'pVai_tro' => $params['pVai_tro'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDHoiDong with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Id
     * @param string $Ho_ten
     * @param string $Ma_cvcm
     * @param string $Ten_cvcm
     * @param string $Vai_tro
     * @param string $Ghi_chu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Id = null, string $Ho_ten = null, string $Ma_cvcm = null, string $Ten_cvcm = null, string $Vai_tro = null, string $Ghi_chu = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pId' => $Id,
            'pHo_ten' => $Ho_ten,
            'pMa_cvcm' => $Ma_cvcm,
            'pTen_cvcm' => $Ten_cvcm,
            'pVai_tro' => $Vai_tro,
            'pGhi_chu' => $Ghi_chu,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
