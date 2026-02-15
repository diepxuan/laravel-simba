<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDTLop
{
    /**
     * Call stored procedure asHrInsDTLop
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDTLop', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
            'pTen_ldt' => $params['pTen_ldt'] ?? null,
            'pMa_gv' => $params['pMa_gv'] ?? null,
            'pTen_gv' => $params['pTen_gv'] ?? null,
            'pChuc_danh' => $params['pChuc_danh'] ?? null,
            'pHoc_ham' => $params['pHoc_ham'] ?? null,
            'pLich_hoc' => $params['pLich_hoc'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDTLop with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kdt
     * @param string $Ma_ldt
     * @param string $Ten_ldt
     * @param string $Ma_gv
     * @param string $Ten_gv
     * @param string $Chuc_danh
     * @param string $Hoc_ham
     * @param string $Lich_hoc
     * @param string $Ghi_chu
     * @param string $Trang_thai
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kdt = null, string $Ma_ldt = null, string $Ten_ldt = null, string $Ma_gv = null, string $Ten_gv = null, string $Chuc_danh = null, string $Hoc_ham = null, string $Lich_hoc = null, string $Ghi_chu = null, string $Trang_thai = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
            'pTen_ldt' => $Ten_ldt,
            'pMa_gv' => $Ma_gv,
            'pTen_gv' => $Ten_gv,
            'pChuc_danh' => $Chuc_danh,
            'pHoc_ham' => $Hoc_ham,
            'pLich_hoc' => $Lich_hoc,
            'pGhi_chu' => $Ghi_chu,
            'pTrang_thai' => $Trang_thai,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
