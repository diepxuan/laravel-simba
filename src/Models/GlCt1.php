<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-20 13:08:16
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\GlCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class GlCt1.
 *
 * This class represents the model for general ledger transaction details.
 */
class GlCt1 extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo tài khoản */
    public function scopeFilterByTk(Builder $query, ?string $tk): Builder
    {
        if (!empty($tk)) {
            return $query->where('tk', $tk);
        }

        return $query;
    }

    /** Filter theo danh sách tài khoản */
    public function scopeFilterByTkList(Builder $query, ?string $list): Builder
    {
        return $query->filterLikeList('tk', $list);
    }

    /** Filter theo mã khách hàng */
    public function scopeFilterByMaKh(Builder $query, ?string $maKh): Builder
    {
        if (!empty($maKh)) {
            return $query->where('ma_kh', $maKh);
        }

        return $query;
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

    /** Relationship với tài khoản */
    public function glDmTk()
    {
        return $this->belongsTo(GlDmTk::class, 'tk', 'tk');
    }

    /** Relationship với khách hàng */
    public function arDmKh()
    {
        return $this->belongsTo(ArDmKh::class, 'ma_kh', 'ma_kh');
    }

    /** Relationship với bộ phận */
    public function sysDepartment()
    {
        return $this->belongsTo(SysDepartment::class, 'ma_bp', 'ma_bp');
    }

    /** Relationship với phiếu tổng hợp */
    public function glCt()
    {
        return $this->belongsTo(GlCt::class, 'stt_rec', 'stt_rec');
    }

    /**
     * Tính tổng phát sinh nợ theo tài khoản
     */
    public static function getTotalDebitByAccount(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate) {
            $query->whereHas('glCt', function ($q) use ($fromDate) {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if ($toDate) {
            $query->whereHas('glCt', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }
        
        return $query->select('tk', DB::raw('SUM(ps_no) as tong_ps_no'), DB::raw('SUM(ps_no_nt) as tong_ps_no_nt'))
            ->groupBy('tk')
            ->get();
    }

    /**
     * Tính tổng phát sinh có theo tài khoản
     */
    public static function getTotalCreditByAccount(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate) {
            $query->whereHas('glCt', function ($q) use ($fromDate) {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if ($toDate) {
            $query->whereHas('glCt', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }
        
        return $query->select('tk', DB::raw('SUM(ps_co) as tong_ps_co'), DB::raw('SUM(ps_co_nt) as tong_ps_co_nt'))
            ->groupBy('tk')
            ->get();
    }

    /**
     * Tính số dư tài khoản
     */
    public static function getAccountBalance(string $maCty, string $tk, ?string $toDate = null): array
    {
        $query = self::where('ma_cty', $maCty)
            ->where('tk', $tk);
        
        if ($toDate) {
            $query->whereHas('glCt', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }
        
        $result = $query->select(
            DB::raw('SUM(ps_no) as tong_no'),
            DB::raw('SUM(ps_co) as tong_co'),
            DB::raw('SUM(ps_no_nt) as tong_no_nt'),
            DB::raw('SUM(ps_co_nt) as tong_co_nt')
        )->first();
        
        return [
            'du_no' => ($result->tong_no ?? 0) - ($result->tong_co ?? 0),
            'du_co' => ($result->tong_co ?? 0) - ($result->tong_no ?? 0),
            'du_no_nt' => ($result->tong_no_nt ?? 0) - ($result->tong_co_nt ?? 0),
            'du_co_nt' => ($result->tong_co_nt ?? 0) - ($result->tong_no_nt ?? 0),
        ];
    }

    /**
     * Gọi stored procedure asGLRptSCTK01 để lấy dữ liệu sổ chi tiết tài khoản
     */
    public static function getGLRptSCTK01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asGLRptSCTK01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk = :pTk,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pTk'       => $params['pTk'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asGLRptNK01 để lấy dữ liệu sổ nhật ký chung
     */
    public static function getGLRptNK01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asGLRptNK01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk_List = :pTk_List,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pTk_List'  => $params['pTk_List'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
