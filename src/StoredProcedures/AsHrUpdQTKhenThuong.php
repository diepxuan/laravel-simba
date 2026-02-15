<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdQTKhenThuong
{
    /**
     * Call stored procedure asHrUpdQTKhenThuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTKhenThuong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtktkl' => $params['pId_qtktkl'] ?? null,
            'pLoai_ktkl' => $params['pLoai_ktkl'] ?? null,
            'pMa_ktkl' => $params['pMa_ktkl'] ?? null,
            'pNoi_dung' => $params['pNoi_dung'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTKhenThuong with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtktkl
     * @param bool $Loai_ktkl
     * @param string $Ma_ktkl
     * @param string $Noi_dung
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtktkl = null, bool $Loai_ktkl = null, string $Ma_ktkl = null, string $Noi_dung = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtktkl' => $Id_qtktkl,
            'pLoai_ktkl' => $Loai_ktkl,
            'pMa_ktkl' => $Ma_ktkl,
            'pNoi_dung' => $Noi_dung,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
