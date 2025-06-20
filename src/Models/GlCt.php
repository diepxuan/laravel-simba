<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-20 11:08:40
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\GlCt as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class GlCt.
 *
 * This class represents the model for the general ledger transactions.
 * It provides methods to interact with the stored procedure for generating reports.
 */
class GlCt extends Model
{
    /** Filter theo danh sách tài khoản */
    public function scopeFilterByTkList(Builder $query, ?string $list): Builder
    {
        return $query->filterLikeList('tk', $list);
    }

    /** Filter theo danh sách tài khoản đối ứng */
    public function scopeFilterByTkduList(Builder $query, ?string $list): Builder
    {
        return $query->filterLikeList('tk_du', $list);
    }

    /** Filter theo mã bộ phận */
    public function scopeFilterByMaBp(Builder $query, ?string $maBp): Builder
    {
        if (!empty($maBp)) {
            return $query->where('ma_bp', $maBp);
        }

        return $query;
    }

    /** Filter theo mã tiền tệ */
    public function scopeFilterByMaNt(Builder $query, ?string $maNt): Builder
    {
        if (!empty($maNt)) {
            return $query->where('ma_nt', $maNt);
        }

        return $query;
    }

    public function arDmKh()
    {
        return $this->belongsTo(ArDmKh::class, 'ma_kh', 'ma_kh');
    }

    /**
     * Gọi stored procedure asCARptTMNH01 để lấy dữ liệu báo cáo tiền mặt ngân hàng.
     *
     * @return array
     */
    public static function getCARptTMNH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asCARptTMNH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk = :pTk,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['ma_Cty'] ?? '111',
            'pTk'       => $params['tk'] ?? '111',
            'pNgay_Ct1' => $params['ngay_Ct1'],
            'pNgay_Ct2' => $params['ngay_Ct2'],
            'pMa_Nt'    => $params['ma_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asGLRptNKC03 để lấy dữ liệu sổ nhật ký thu/chi.
     */
    public static function getGLRptNKC03(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asGLRptNKC03
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk_List = :pTk_List,
            @pTkdu_List = :pTkdu_List,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'    => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1'  => $params['pNgay_Ct1'] ?? '2025-05-01',
            'pNgay_Ct2'  => $params['pNgay_Ct2'] ?? now(),
            'pTk_List'   => $params['pTk_List'] ?? '',
            'pTkdu_List' => $params['pTkdu_List'] ?? '',
            'pMa_Bp'     => $params['pMa_Bp'] ?? '',
            'pMa_Nt'     => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
