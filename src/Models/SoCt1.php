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

use Diepxuan\Simba\SModel\SoCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class SoCt1.
 *
 * This class represents the model for sales order details.
 */
class SoCt1 extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo mã vật tư */
    public function scopeFilterByMaVt(Builder $query, ?string $maVt): Builder
    {
        if (!empty($maVt)) {
            return $query->where('ma_vt', $maVt);
        }

        return $query;
    }

    /** Filter theo mã kho */
    public function scopeFilterByMaKho(Builder $query, ?string $maKho): Builder
    {
        if (!empty($maKho)) {
            return $query->where('ma_kho', $maKho);
        }

        return $query;
    }

    /** Filter theo mã khách hàng thông qua phiếu tổng hợp */
    public function scopeFilterByMaKh(Builder $query, ?string $maKh): Builder
    {
        if (!empty($maKh)) {
            return $query->whereHas('soPh3', function ($q) use ($maKh) {
                $q->where('ma_kh', $maKh);
            });
        }

        return $query;
    }

    /** Filter theo mã nhân viên kinh doanh */
    public function scopeFilterByMaNvkd(Builder $query, ?string $maNvkd): Builder
    {
        if (!empty($maNvkd)) {
            return $query->where('ma_nvkd', $maNvkd);
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

    /** Filter theo ngày chứng từ thông qua phiếu tổng hợp */
    public function scopeFilterByNgayCt(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereHas('soPh3', function ($q) use ($fromDate) {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if (!empty($toDate)) {
            $query->whereHas('soPh3', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }

        return $query;
    }

    /** Relationship với phiếu tổng hợp */
    public function soPh3()
    {
        return $this->belongsTo(SoPh3::class, 'stt_rec', 'stt_rec');
    }

    /** Relationship với vật tư */
    public function inDmVt()
    {
        return $this->belongsTo(InDmVt::class, 'ma_vt', 'ma_vt');
    }

    /** Relationship với kho */
    public function inDmKho()
    {
        return $this->belongsTo(InDmKho::class, 'ma_kho', 'ma_kho');
    }

    /** Relationship với vị trí */
    public function inDmViTri()
    {
        return $this->belongsTo(InDmViTri::class, 'ma_vitri', 'ma_vitri');
    }

    /** Relationship với lô hàng */
    public function inDmLo()
    {
        return $this->belongsTo(InDmLo::class, 'ma_lo', 'ma_lo');
    }

    /** Relationship với nhân viên kinh doanh */
    public function sysUserInfo()
    {
        return $this->belongsTo(SysUserInfo::class, 'ma_nvkd', 'username');
    }

    /** Relationship với bộ phận */
    public function sysDepartment()
    {
        return $this->belongsTo(SysDepartment::class, 'ma_bp', 'ma_bp');
    }

    /**
     * Tính tổng doanh thu theo vật tư
     */
    public static function getTotalRevenueByProduct(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('soPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_vt', DB::raw('SUM(tien2) as tong_doanh_thu'), DB::raw('SUM(tien_nt2) as tong_doanh_thu_nt'))
            ->groupBy('ma_vt')
            ->get();
    }

    /**
     * Tính tổng số lượng bán theo vật tư
     */
    public static function getTotalQuantityByProduct(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('soPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_vt', DB::raw('SUM(so_luong) as tong_so_luong'), DB::raw('SUM(so_luong_qd) as tong_so_luong_qd'))
            ->groupBy('ma_vt')
            ->get();
    }

    /**
     * Tính tổng doanh thu theo nhân viên kinh doanh
     */
    public static function getTotalRevenueBySalesperson(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty)
            ->whereNotNull('ma_nvkd');
        
        if ($fromDate || $toDate) {
            $query->whereHas('soPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_nvkd', DB::raw('SUM(tien2) as tong_doanh_thu'), DB::raw('SUM(tien_nt2) as tong_doanh_thu_nt'))
            ->groupBy('ma_nvkd')
            ->get();
    }

    /**
     * Gọi stored procedure asSORptBH01 để lấy báo cáo bán hàng
     */
    public static function getSORptBH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asSORptBH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Kh = :pMa_Kh,
            @pMa_Vt = :pMa_Vt,
            @pMa_Nvkd = :pMa_Nvkd,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Kh'    => $params['pMa_Kh'] ?? '',
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Nvkd'  => $params['pMa_Nvkd'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asSORptDT01 để lấy báo cáo doanh thu
     */
    public static function getSORptDT01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asSORptDT01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Vt = :pMa_Vt,
            @pMa_Nvkd = :pMa_Nvkd,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Nvkd'  => $params['pMa_Nvkd'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asSORptSL01 để lấy báo cáo số lượng
     */
    public static function getSORptSL01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asSORptSL01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Vt = :pMa_Vt,
            @pMa_Nvkd = :pMa_Nvkd,
            @pMa_Bp = :pMa_Bp
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Nvkd'  => $params['pMa_Nvkd'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
        ]));
    }
}
