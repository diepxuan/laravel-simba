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

use Diepxuan\Simba\SModel\MmCt3Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class MmCt3.
 *
 * This class represents the model for material management details (e.g., inventory adjustments).
 */
class MmCt3 extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo số đơn hàng */
    public function scopeFilterBySoDh(Builder $query, ?string $soDh): Builder
    {
        if (!empty($soDh)) {
            return $query->where('so_dh', 'like', "%{$soDh}%");
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

    /** Filter theo mã lô */
    public function scopeFilterByMaLo(Builder $query, ?string $maLo): Builder
    {
        if (!empty($maLo)) {
            return $query->where('ma_lo', $maLo);
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

    /** Relationship với phiếu tổng hợp */
    public function mmPh3()
    {
        return $this->belongsTo(MmPh3::class, 'stt_rec', 'stt_rec');
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

    /**
     * Tính tổng số lượng điều chỉnh theo vật tư
     */
    public static function getTotalAdjustmentByProduct(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('mmPh3', function ($q) use ($fromDate, $toDate) {
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
     * Gọi stored procedure asMMRptNK01 để lấy báo cáo nhập xuất tồn
     */
    public static function getMMRptNK01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asMMRptNK01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Vt = :pMa_Vt,
            @pMa_Kho = :pMa_Kho,
            @pMa_Lo = :pMa_Lo,
            @pMa_Bp = :pMa_Bp
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Vt'    => $params['pMa_Vt'] ?? '',
            'pMa_Kho'   => $params['pMa_Kho'] ?? '',
            'pMa_Lo'    => $params['pMa_Lo'] ?? '',
            'pMa_Bp'    => $params['pMa_Bp'] ?? '',
        ]));
    }
}
