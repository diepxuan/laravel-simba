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

class AsHrUpdQuanHeNV
{
    /**
     * Call stored procedure asHrUpdQuanHeNV
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQuanHeNV', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtqh' => $params['pId_qtqh'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pHo_dem' => $params['pHo_dem'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pNgay_sinh' => $params['pNgay_sinh'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pQuan_he' => $params['pQuan_he'] ?? null,
            'pNoi_o' => $params['pNoi_o'] ?? null,
            'pNoi_o_dc' => $params['pNoi_o_dc'] ?? null,
            'pNoi_o_xa' => $params['pNoi_o_xa'] ?? null,
            'pNoi_o_huyen' => $params['pNoi_o_huyen'] ?? null,
            'pNoi_o_tinh' => $params['pNoi_o_tinh'] ?? null,
            'pMa_ton_giao' => $params['pMa_ton_giao'] ?? null,
            'pMa_dan_toc' => $params['pMa_dan_toc'] ?? null,
            'pMa_quoc_tich' => $params['pMa_quoc_tich'] ?? null,
            'pMa_to_chuc' => $params['pMa_to_chuc'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pPhone_mobile' => $params['pPhone_mobile'] ?? null,
            'pPhone_home' => $params['pPhone_home'] ?? null,
            'pPhone_work' => $params['pPhone_work'] ?? null,
            'pPhone_work_ext' => $params['pPhone_work_ext'] ?? null,
            'pEmail_home' => $params['pEmail_home'] ?? null,
            'pAnh_dai_dien' => $params['pAnh_dai_dien'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pPhu_thuoc' => $params['pPhu_thuoc'] ?? null,
            'pKhan_cap' => $params['pKhan_cap'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQuanHeNV with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtqh
     * @param string $Ho_ten
     * @param string $Ho_dem
     * @param string $Ten
     * @param string $Ngay_sinh
     * @param string $Gioi_tinh
     * @param string $Quan_he
     * @param string $Noi_o
     * @param string $Noi_o_dc
     * @param string $Noi_o_xa
     * @param string $Noi_o_huyen
     * @param string $Noi_o_tinh
     * @param string $Ma_ton_giao
     * @param string $Ma_dan_toc
     * @param string $Ma_quoc_tich
     * @param string $Ma_to_chuc
     * @param string $Ma_cvcm
     * @param string $Phone_mobile
     * @param string $Phone_home
     * @param string $Phone_work
     * @param string $Phone_work_ext
     * @param string $Email_home
     * @param string $Anh_dai_dien
     * @param string $Tai_lieu
     * @param bool $Phu_thuoc
     * @param bool $Khan_cap
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtqh = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $Quan_he = null, string $Noi_o = null, string $Noi_o_dc = null, string $Noi_o_xa = null, string $Noi_o_huyen = null, string $Noi_o_tinh = null, string $Ma_ton_giao = null, string $Ma_dan_toc = null, string $Ma_quoc_tich = null, string $Ma_to_chuc = null, string $Ma_cvcm = null, string $Phone_mobile = null, string $Phone_home = null, string $Phone_work = null, string $Phone_work_ext = null, string $Email_home = null, string $Anh_dai_dien = null, string $Tai_lieu = null, bool $Phu_thuoc = null, bool $Khan_cap = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtqh' => $Id_qtqh,
            'pHo_ten' => $Ho_ten,
            'pHo_dem' => $Ho_dem,
            'pTen' => $Ten,
            'pNgay_sinh' => $Ngay_sinh,
            'pGioi_tinh' => $Gioi_tinh,
            'pQuan_he' => $Quan_he,
            'pNoi_o' => $Noi_o,
            'pNoi_o_dc' => $Noi_o_dc,
            'pNoi_o_xa' => $Noi_o_xa,
            'pNoi_o_huyen' => $Noi_o_huyen,
            'pNoi_o_tinh' => $Noi_o_tinh,
            'pMa_ton_giao' => $Ma_ton_giao,
            'pMa_dan_toc' => $Ma_dan_toc,
            'pMa_quoc_tich' => $Ma_quoc_tich,
            'pMa_to_chuc' => $Ma_to_chuc,
            'pMa_cvcm' => $Ma_cvcm,
            'pPhone_mobile' => $Phone_mobile,
            'pPhone_home' => $Phone_home,
            'pPhone_work' => $Phone_work,
            'pPhone_work_ext' => $Phone_work_ext,
            'pEmail_home' => $Email_home,
            'pAnh_dai_dien' => $Anh_dai_dien,
            'pTai_lieu' => $Tai_lieu,
            'pPhu_thuoc' => $Phu_thuoc,
            'pKhan_cap' => $Khan_cap,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
