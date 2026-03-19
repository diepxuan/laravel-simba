<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdTDDeThi
{
    /**
     * Call stored procedure asHrUpdTDDeThi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDDeThi', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_yctd' => $paramObj->pMa_yctd ?? null,
            'pVong_so' => $paramObj->pVong_so ?? null,
            'pMa_mon_thi' => $paramObj->pMa_mon_thi ?? null,
            'pTen_mon_thi' => $paramObj->pTen_mon_thi ?? null,
            'pDe_so' => $paramObj->pDe_so ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDDeThi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Ma_mon_thi
     * @param string $Ten_mon_thi
     * @param string $De_so
     * @param string $Tai_lieu
     * @param string $Ghi_chu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Ma_mon_thi = null, string $Ten_mon_thi = null, string $De_so = null, string $Tai_lieu = null, string $Ghi_chu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pMa_mon_thi' => $Ma_mon_thi,
            'pTen_mon_thi' => $Ten_mon_thi,
            'pDe_so' => $De_so,
            'pTai_lieu' => $Tai_lieu,
            'pGhi_chu' => $Ghi_chu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
