<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdQTKyNang
{
    /**
     * Call stored procedure asHrUpdQTKyNang
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTKyNang', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtkn' => $paramObj->pId_qtkn ?? null,
            'pMa_loai_kn' => $paramObj->pMa_loai_kn ?? null,
            'pMa_kn' => $paramObj->pMa_kn ?? null,
            'pMa_trinh_do' => $paramObj->pMa_trinh_do ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTKyNang with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtkn
     * @param string $Ma_loai_kn
     * @param string $Ma_kn
     * @param string $Ma_trinh_do
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtkn = null, string $Ma_loai_kn = null, string $Ma_kn = null, string $Ma_trinh_do = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtkn' => $Id_qtkn,
            'pMa_loai_kn' => $Ma_loai_kn,
            'pMa_kn' => $Ma_kn,
            'pMa_trinh_do' => $Ma_trinh_do,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
