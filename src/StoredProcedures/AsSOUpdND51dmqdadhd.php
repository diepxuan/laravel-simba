<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdND51dmqdadhd
{
    /**
     * Call stored procedure asSOUpdND51dmqdadhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51dmqdadhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_qd' => $params['pMa_qd'] ?? null,
            'pNgay_qd' => $params['pNgay_qd'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null,
            'pNgay_hl' => $params['pNgay_hl'] ?? null,
            'pTen_cty' => $params['pTen_cty'] ?? null,
            'pGiam_doc' => $params['pGiam_doc'] ?? null,
            'pDangky_kd' => $params['pDangky_kd'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pCq_thue' => $params['pCq_thue'] ?? null,
            'pHt_tb' => $params['pHt_tb'] ?? null,
            'pNcc' => $params['pNcc'] ?? null,
            'pHdmd' => $params['pHdmd'] ?? null,
            'pTnbp' => $params['pTnbp'] ?? null,
            'pLdate' => $params['pLdate'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdND51dmqdadhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_qd
     * @param string $Ngay_qd
     * @param string $Ngay_ad
     * @param string $Ngay_hl
     * @param string $Ten_cty
     * @param string $Giam_doc
     * @param string $Dangky_kd
     * @param string $Ma_bp
     * @param string $Cq_thue
     * @param string $Ht_tb
     * @param string $Ncc
     * @param string $Hdmd
     * @param string $Tnbp
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_qd = null, string $Ngay_qd = null, string $Ngay_ad = null, string $Ngay_hl = null, string $Ten_cty = null, string $Giam_doc = null, string $Dangky_kd = null, string $Ma_bp = null, string $Cq_thue = null, string $Ht_tb = null, string $Ncc = null, string $Hdmd = null, string $Tnbp = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_qd' => $Ma_qd,
            'pNgay_qd' => $Ngay_qd,
            'pNgay_ad' => $Ngay_ad,
            'pNgay_hl' => $Ngay_hl,
            'pTen_cty' => $Ten_cty,
            'pGiam_doc' => $Giam_doc,
            'pDangky_kd' => $Dangky_kd,
            'pMa_bp' => $Ma_bp,
            'pCq_thue' => $Cq_thue,
            'pHt_tb' => $Ht_tb,
            'pNcc' => $Ncc,
            'pHdmd' => $Hdmd,
            'pTnbp' => $Tnbp,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
