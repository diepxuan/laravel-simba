<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdChamCongKhac
{
    /**
     * Call stored procedure asHrUpdChamCongKhac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdChamCongKhac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pMa_cham_cong' => $params['pMa_cham_cong'] ?? null,
            'pKh_cham_cong' => $params['pKh_cham_cong'] ?? null,
            'pGio_vao' => $params['pGio_vao'] ?? null,
            'pPhut_vao' => $params['pPhut_vao'] ?? null,
            'pGio_ra' => $params['pGio_ra'] ?? null,
            'pPhut_ra' => $params['pPhut_ra'] ?? null,
            'pThem_gio' => $params['pThem_gio'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdChamCongKhac with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param int $Ngay
     * @param string $Id
     * @param string $Ma_cham_cong
     * @param string $Kh_cham_cong
     * @param int $Gio_vao
     * @param int $Phut_vao
     * @param int $Gio_ra
     * @param int $Phut_ra
     * @param bool $Them_gio
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, int $Ngay = null, string $Id = null, string $Ma_cham_cong = null, string $Kh_cham_cong = null, int $Gio_vao = null, int $Phut_vao = null, int $Gio_ra = null, int $Phut_ra = null, bool $Them_gio = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pNgay' => $Ngay,
            'pId' => $Id,
            'pMa_cham_cong' => $Ma_cham_cong,
            'pKh_cham_cong' => $Kh_cham_cong,
            'pGio_vao' => $Gio_vao,
            'pPhut_vao' => $Phut_vao,
            'pGio_ra' => $Gio_ra,
            'pPhut_ra' => $Phut_ra,
            'pThem_gio' => $Them_gio,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
