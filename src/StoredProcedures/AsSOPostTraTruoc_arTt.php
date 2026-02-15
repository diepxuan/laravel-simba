<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOPostTraTruoc_arTt
{
    /**
     * Call stored procedure asSOPostTraTruoc_arTt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOPostTraTruoc_arTt', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_pt' => $params['pStt_rec_pt'] ?? null,
            'pStt_rec_dh' => $params['pStt_rec_dh'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
            'pTien_tra_truoc' => $params['pTien_tra_truoc'] ?? null,
            'pTien_tra_truoc_nt' => $params['pTien_tra_truoc_nt'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pstt_rec_dh' => $params['pstt_rec_dh'] ?? null,
            'pstt_rec_hd' => $params['pstt_rec_hd'] ?? null,
            'pstt_rec_pt' => $params['pstt_rec_pt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOPostTraTruoc_arTt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_pt
     * @param string $Stt_rec_dh
     * @param string $Stt_rec_hd
     * @param float $Tien_tra_truoc
     * @param float $Tien_tra_truoc_nt
     * @param int $ThangTC
     * @param int $NamTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param mixed $stt_rec_dh
     * @param mixed $stt_rec_hd
     * @param mixed $stt_rec_pt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_pt = null, string $Stt_rec_dh = null, string $Stt_rec_hd = null, float $Tien_tra_truoc = null, float $Tien_tra_truoc_nt = null, int $ThangTC = null, int $NamTC = null, string $Ngay_ct = null, string $Ngay_ks = null, mixed $stt_rec_dh = null, mixed $stt_rec_hd = null, mixed $stt_rec_pt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_pt' => $Stt_rec_pt,
            'pStt_rec_dh' => $Stt_rec_dh,
            'pStt_rec_hd' => $Stt_rec_hd,
            'pTien_tra_truoc' => $Tien_tra_truoc,
            'pTien_tra_truoc_nt' => $Tien_tra_truoc_nt,
            'pThangTC' => $ThangTC,
            'pNamTC' => $NamTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pstt_rec_dh' => $stt_rec_dh,
            'pstt_rec_hd' => $stt_rec_hd,
            'pstt_rec_pt' => $stt_rec_pt
        ];
        
        return self::call($params);
    }
}
