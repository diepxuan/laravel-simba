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

use Diepxuan\Simba\SModel\PoCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class PoCt1.
 *
 * This class represents the model for purchase order details.
 */
class PoCt1 extends Model
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

    /** Filter theo mã nhà cung cấp thông qua phiếu tổng hợp */
    public function scopeFilterByMaNcc(Builder $query, ?string $maNcc): Builder
    {
        if (!empty($maNcc)) {
            return $query->whereHas('poPh3', function ($q) use ($maNcc) {
                $q->where('ma_ncc', $maNcc);
            });
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
            $query->whereHas('poPh3', function ($q) use ($fromDate) {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if (!empty($toDate)) {
            $query->whereHas('poPh3', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }

        return $query;
    }

    /** Relationship với phiếu tổng hợp */
    public function poPh3()
    {
        return $this->belongsTo(PoPh3::class, 'stt_rec', 'stt_rec');
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

    /** Relationship với bộ phận */
    public function sysDepartment()
    {
        return $this->belongsTo(SysDepartment::class, 'ma_bp', 'ma_bp');
    }

    /** Relationship với tài khoản vật tư */
    public function glDmTkVt()
    {
        return $this->belongsTo(GlDmTk::class, 'tk_vt', 'tk');
    }

    /** Relationship với tài khoản thuế */
    public function glDmTkThue()
    {
        return $this->belongsTo(GlDmTk::class, 'tk_thue', 'tk');
    }

    /**
     * Tính tổng giá trị mua hàng theo vật tư
     */
    public static function getTotalPurchaseByProduct(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('poPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_vt', DB::raw('SUM(tien0) as tong_gia_tri'), DB::raw('SUM(tien_nt0) as tong_gia_tri_nt'))
            ->groupBy('ma_vt')
            ->get();
    }

    /**
     * Tính tổng số lượng mua theo vật tư
     */
    public static function getTotalQuantityByProduct(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('poPh3', function ($q) use ($fromDate, $toDate) {
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
     * Tính tổng giá trị mua hàng theo nhà cung cấp
     */
    public static function getTotalPurchaseBySupplier(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('poPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('poPh3.ma_ncc', DB::raw('SUM(po_ct1.tien0) as tong_gia_tri'), DB::raw('SUM(po_ct1.tien_nt0) as tong_gia_tri_nt'))
            ->join('po_ph3', 'po_ct1.stt_rec', '=', 'po_ph3.stt_rec')
            ->groupBy('po_ph3.ma_ncc')
            ->get();
    }

    /**
     * Tính tỷ lệ nhập hàng (số lượng đã nhập / số lượng đặt hàng)
     */
    public function getReceiptRate(): float
    {
        if ($this->so_luong == 0) {
            return 0;
        }
        
        return ($this->sl_nhap / $this->so_luong) * 100;
    }

    /**
     * Gọi stored procedure asPORptMH01 để lấy báo cáo mua hàng
     */
    public static function getPORptMH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asPORptMH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Ncc = :pMa_Ncc,
            @pMa_Vt = :pMa_Vt,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Ncc'   => $params['pMa_Ncc'] ?? '',
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asPORptDH01 để lấy báo cáo đặt hàng
     */
    public static function getPORptDH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asPORptDH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Ncc = :pMa_Ncc,
            @pMa_Vt = :pMa_Vt,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Ncc'   => $params['pMa_Ncc'] ?? '',
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asPORptNH01 để lấy báo cáo nhập hàng
     */
    public static function getPORptNH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asPORptNH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Ncc = :pMa_Ncc,
            @pMa_Vt = :pMa_Vt,
            @pMa_Bp = :pMa_Bp,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Ncc'   => $params['pMa_Ncc'] ?? '',
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
