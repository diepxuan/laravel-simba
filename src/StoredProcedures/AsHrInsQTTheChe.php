<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrInsQTTheChe
{
    /**
     * Call stored procedure asHrInsQTTheChe
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTTheChe', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qttc' => $paramObj->pId_qttc ?? null,
            'pMa_the_che' => $paramObj->pMa_the_che ?? null,
            'pNgay_vao' => $paramObj->pNgay_vao ?? null,
            'pNgay_chinh_thuc' => $paramObj->pNgay_chinh_thuc ?? null,
            'pNgay_ra' => $paramObj->pNgay_ra ?? null,
            'pNoi_ket_nap' => $paramObj->pNoi_ket_nap ?? null,
            'pChuc_vu' => $paramObj->pChuc_vu ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pCuser' => $paramObj->pCuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsQTTheChe with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qttc
     * @param string $Ma_the_che
     * @param string $Ngay_vao
     * @param string $Ngay_chinh_thuc
     * @param string $Ngay_ra
     * @param string $Noi_ket_nap
     * @param string $Chuc_vu
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qttc = null, string $Ma_the_che = null, string $Ngay_vao = null, string $Ngay_chinh_thuc = null, string $Ngay_ra = null, string $Noi_ket_nap = null, string $Chuc_vu = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qttc' => $Id_qttc,
            'pMa_the_che' => $Ma_the_che,
            'pNgay_vao' => $Ngay_vao,
            'pNgay_chinh_thuc' => $Ngay_chinh_thuc,
            'pNgay_ra' => $Ngay_ra,
            'pNoi_ket_nap' => $Noi_ket_nap,
            'pChuc_vu' => $Chuc_vu,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
