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
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmKQDanhGia
{
    /**
     * Call stored procedure asHrUpdDmKQDanhGia
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmKQDanhGia', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kqdg' => $paramObj->pMa_kqdg ?? null,
            'pTen_kqdg' => $paramObj->pTen_kqdg ?? null,
            'pDiem_tu' => $paramObj->pDiem_tu ?? null,
            'pDiem_den' => $paramObj->pDiem_den ?? null,
            'pKet_luan' => $paramObj->pKet_luan ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmKQDanhGia with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kqdg
     * @param string $Ten_kqdg
     * @param float $Diem_tu
     * @param float $Diem_den
     * @param string $Ket_luan
     * @param string $Ghi_chu
     * @param bool $Ksd
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kqdg = null, string $Ten_kqdg = null, float $Diem_tu = null, float $Diem_den = null, string $Ket_luan = null, string $Ghi_chu = null, bool $Ksd = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kqdg' => $Ma_kqdg,
            'pTen_kqdg' => $Ten_kqdg,
            'pDiem_tu' => $Diem_tu,
            'pDiem_den' => $Diem_den,
            'pKet_luan' => $Ket_luan,
            'pGhi_chu' => $Ghi_chu,
            'pKsd' => $Ksd,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
