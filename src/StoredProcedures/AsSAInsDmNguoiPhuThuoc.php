<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAInsDmNguoiPhuThuoc
{
    /**
     * Call stored procedure asSAInsDmNguoiPhuThuoc
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmNguoiPhuThuoc', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmNguoiPhuThuoc with named parameters
     *
     * @param string $Ma_cty
     * @param string $Thang
     * @param string $Nam
     * @param string $Ma_nv
     * @param int $So_npt
     * @param string $Ghi_chu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Thang = null, string $Nam = null, string $Ma_nv = null, int $So_npt = null, string $Ghi_chu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_nv' => $Ma_nv,
            'pSo_npt' => $So_npt,
            'pGhi_chu' => $Ghi_chu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
