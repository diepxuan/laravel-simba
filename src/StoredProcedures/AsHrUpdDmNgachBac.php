<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmNgachBac
{
    /**
     * Call stored procedure asHrUpdDmNgachBac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmNgachBac', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tbl' => $paramObj->pMa_tbl ?? null,
            'pMa_nb' => $paramObj->pMa_nb ?? null,
            'pTen_nb' => $paramObj->pTen_nb ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pSo_bac' => $paramObj->pSo_bac ?? null,
            'pNien_han01' => $paramObj->pNien_han01 ?? null,
            'pHe_so01' => $paramObj->pHe_so01 ?? null,
            'pNien_han02' => $paramObj->pNien_han02 ?? null,
            'pHe_so02' => $paramObj->pHe_so02 ?? null,
            'pNien_han03' => $paramObj->pNien_han03 ?? null,
            'pHe_so03' => $paramObj->pHe_so03 ?? null,
            'pNien_han04' => $paramObj->pNien_han04 ?? null,
            'pHe_so04' => $paramObj->pHe_so04 ?? null,
            'pNien_han05' => $paramObj->pNien_han05 ?? null,
            'pHe_so05' => $paramObj->pHe_so05 ?? null,
            'pNien_han06' => $paramObj->pNien_han06 ?? null,
            'pHe_so06' => $paramObj->pHe_so06 ?? null,
            'pNien_han07' => $paramObj->pNien_han07 ?? null,
            'pHe_so07' => $paramObj->pHe_so07 ?? null,
            'pNien_han08' => $paramObj->pNien_han08 ?? null,
            'pHe_so08' => $paramObj->pHe_so08 ?? null,
            'pNien_han09' => $paramObj->pNien_han09 ?? null,
            'pHe_so09' => $paramObj->pHe_so09 ?? null,
            'pNien_han10' => $paramObj->pNien_han10 ?? null,
            'pHe_so10' => $paramObj->pHe_so10 ?? null,
            'pNien_han11' => $paramObj->pNien_han11 ?? null,
            'pHe_so11' => $paramObj->pHe_so11 ?? null,
            'pNien_han12' => $paramObj->pNien_han12 ?? null,
            'pHe_so12' => $paramObj->pHe_so12 ?? null,
            'pNien_han13' => $paramObj->pNien_han13 ?? null,
            'pHe_so13' => $paramObj->pHe_so13 ?? null,
            'pNien_han14' => $paramObj->pNien_han14 ?? null,
            'pHe_so14' => $paramObj->pHe_so14 ?? null,
            'pNien_han15' => $paramObj->pNien_han15 ?? null,
            'pHe_so15' => $paramObj->pHe_so15 ?? null,
            'pNien_han16' => $paramObj->pNien_han16 ?? null,
            'pHe_so16' => $paramObj->pHe_so16 ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmNgachBac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tbl
     * @param string $Ma_nb
     * @param string $Ten_nb
     * @param string $Dien_giai
     * @param int $So_bac
     * @param int $Nien_han01
     * @param float $He_so01
     * @param int $Nien_han02
     * @param float $He_so02
     * @param int $Nien_han03
     * @param float $He_so03
     * @param int $Nien_han04
     * @param float $He_so04
     * @param int $Nien_han05
     * @param float $He_so05
     * @param int $Nien_han06
     * @param float $He_so06
     * @param int $Nien_han07
     * @param float $He_so07
     * @param int $Nien_han08
     * @param float $He_so08
     * @param int $Nien_han09
     * @param float $He_so09
     * @param int $Nien_han10
     * @param float $He_so10
     * @param int $Nien_han11
     * @param float $He_so11
     * @param int $Nien_han12
     * @param float $He_so12
     * @param int $Nien_han13
     * @param float $He_so13
     * @param int $Nien_han14
     * @param float $He_so14
     * @param int $Nien_han15
     * @param float $He_so15
     * @param int $Nien_han16
     * @param float $He_so16
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tbl = null, string $Ma_nb = null, string $Ten_nb = null, string $Dien_giai = null, int $So_bac = null, int $Nien_han01 = null, float $He_so01 = null, int $Nien_han02 = null, float $He_so02 = null, int $Nien_han03 = null, float $He_so03 = null, int $Nien_han04 = null, float $He_so04 = null, int $Nien_han05 = null, float $He_so05 = null, int $Nien_han06 = null, float $He_so06 = null, int $Nien_han07 = null, float $He_so07 = null, int $Nien_han08 = null, float $He_so08 = null, int $Nien_han09 = null, float $He_so09 = null, int $Nien_han10 = null, float $He_so10 = null, int $Nien_han11 = null, float $He_so11 = null, int $Nien_han12 = null, float $He_so12 = null, int $Nien_han13 = null, float $He_so13 = null, int $Nien_han14 = null, float $He_so14 = null, int $Nien_han15 = null, float $He_so15 = null, int $Nien_han16 = null, float $He_so16 = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tbl' => $Ma_tbl,
            'pMa_nb' => $Ma_nb,
            'pTen_nb' => $Ten_nb,
            'pDien_giai' => $Dien_giai,
            'pSo_bac' => $So_bac,
            'pNien_han01' => $Nien_han01,
            'pHe_so01' => $He_so01,
            'pNien_han02' => $Nien_han02,
            'pHe_so02' => $He_so02,
            'pNien_han03' => $Nien_han03,
            'pHe_so03' => $He_so03,
            'pNien_han04' => $Nien_han04,
            'pHe_so04' => $He_so04,
            'pNien_han05' => $Nien_han05,
            'pHe_so05' => $He_so05,
            'pNien_han06' => $Nien_han06,
            'pHe_so06' => $He_so06,
            'pNien_han07' => $Nien_han07,
            'pHe_so07' => $He_so07,
            'pNien_han08' => $Nien_han08,
            'pHe_so08' => $He_so08,
            'pNien_han09' => $Nien_han09,
            'pHe_so09' => $He_so09,
            'pNien_han10' => $Nien_han10,
            'pHe_so10' => $He_so10,
            'pNien_han11' => $Nien_han11,
            'pHe_so11' => $He_so11,
            'pNien_han12' => $Nien_han12,
            'pHe_so12' => $He_so12,
            'pNien_han13' => $Nien_han13,
            'pHe_so13' => $He_so13,
            'pNien_han14' => $Nien_han14,
            'pHe_so14' => $He_so14,
            'pNien_han15' => $Nien_han15,
            'pHe_so15' => $He_so15,
            'pNien_han16' => $Nien_han16,
            'pHe_so16' => $He_so16,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
