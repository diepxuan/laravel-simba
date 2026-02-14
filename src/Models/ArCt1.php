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

use Diepxuan\Simba\SModel\ArCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class ArCt1.
 *
 * This class represents the model for accounts receivable transactions.
 */
class ArCt1 extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo số hóa đơn */
    public function scopeFilterBySoHd(Builder $query, ?string $soHd): Builder
    {
        if (!empty($soHd)) {
            return $query->where('so_hd', 'like', "%{$soHd}%");
        }

        return $query;
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

    /** Filter theo ngày hóa đơn */
    public function scopeFilterByNgayHd(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereDate('ngay_hd', '>=', $fromDate);
        }
        if (!empty($toDate)) {
            $query->whereDate('ngay_hd', '<=', $toDate);
        }

        return $query;
    }

    /** Filter theo ngày đặt hàng */
    public function scopeFilterByNgayDh(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereDate('ngay_dh', '>=', $fromDate);
        }
        if (!empty($toDate)) {
            $query->whereDate('ngay_dh', '<=', $toDate);
        }

        return $query;
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

    /** Relationship với tài khoản */
    public function glDmTk()
    {
        return $this->belongsTo(GlDmTk::class, 'tk', 'tk');
    }

    /**
     * Tính tổng tiền thanh toán theo khách hàng
     */
    public static function getTotalPaymentByCustomer(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate) {
            $query->whereDate('ngay_hd', '>=', $fromDate);
        }
        if ($toDate) {
            $query->whereDate('ngay_hd', '<=', $toDate);
        }
        
        return $query->select('ma_kh', DB::raw('SUM(tien_tt) as tong_tien_tt'), DB::raw('SUM(tien_tt_nt) as tong_tien_tt_nt'))
            ->groupBy('ma_kh')
            ->get();
    }

    /**
     * Tính tổng công nợ phải thu theo khách hàng
     */
    public static function getTotalReceivableByCustomer(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate) {
            $query->whereDate('ngay_hd', '>=', $fromDate);
        }
        if ($toDate) {
            $query->whereDate('ngay_hd', '<=', $toDate);
        }
        
        return $query->select('ma_kh', DB::raw('SUM(du_hd) as tong_du_hd'), DB::raw('SUM(du_hd_nt) as tong_du_hd_nt'))
            ->groupBy('ma_kh')
            ->get();
    }

    /**
     * Gọi stored procedure asARRptCN01 để lấy dữ liệu báo cáo công nợ phải thu
     */
    public static function getARRptCN01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asARRptCN01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Kh = :pMa_Kh,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Kh'    => $params['pMa_Kh'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asARRptTM01 để lấy dữ liệu báo cáo thanh toán
     */
    public static function getARRptTM01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asARRptTM01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Kh = :pMa_Kh,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Kh'    => $params['pMa_Kh'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asARRptHD01 để lấy dữ liệu báo cáo hóa đơn
     */
    public static function getARRptHD01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asARRptHD01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Kh = :pMa_Kh,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Kh'    => $params['pMa_Kh'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
