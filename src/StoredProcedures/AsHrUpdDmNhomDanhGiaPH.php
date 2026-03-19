<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmNhomDanhGiaPH
{
    /**
     * Call stored procedure asHrUpdDmNhomDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmNhomDanhGiaPH', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_nhdg' => $paramObj->pMa_nhdg ?? null,
            'pTen_nhdg' => $paramObj->pTen_nhdg ?? null,
            'pSo_tcdg' => $paramObj->pSo_tcdg ?? null,
            'pTong_diem' => $paramObj->pTong_diem ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmNhomDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhdg
     * @param string $Ten_nhdg
     * @param float $So_tcdg
     * @param float $Tong_diem
     * @param string $Ghi_chu
     * @param bool $Ksd
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhdg = null, string $Ten_nhdg = null, float $So_tcdg = null, float $Tong_diem = null, string $Ghi_chu = null, bool $Ksd = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhdg' => $Ma_nhdg,
            'pTen_nhdg' => $Ten_nhdg,
            'pSo_tcdg' => $So_tcdg,
            'pTong_diem' => $Tong_diem,
            'pGhi_chu' => $Ghi_chu,
            'pKsd' => $Ksd,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
