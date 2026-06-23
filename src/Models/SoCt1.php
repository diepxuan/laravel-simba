<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-22
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\Models\Concerns\HasSimbaCompositeKey;
use Diepxuan\Simba\SModel\SoCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class SoCt1.
 *
 * This class represents the model for sales order details.
 *
 * Behavior nghiệp vụ (tổng doanh thu / số lượng theo vật tư / nhân viên,
 * các báo cáo bán hàng) đã được tách sang
 * `Diepxuan\Catalog\Models\Concerns\HasSoCt1SalesMetrics`
 * và gắn vào `Diepxuan\Catalog\Models\Simba\SoCt1`.
 *
 * Còn giữ ở đây:
 * - Scope filter theo field Simba.
 * - Quan hệ Simba-Simba: soPh3, inDmVt, inDmKho, inDmViTri, inDmLo, sysUserInfo, sysDepartment.
 */
class SoCt1 extends Model
{
    use HasSimbaCompositeKey;

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
            return $query->whereHas('soPh3', function ($q) use ($maKh): void {
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
            $query->whereHas('soPh3', function ($q) use ($fromDate): void {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if (!empty($toDate)) {
            $query->whereHas('soPh3', function ($q) use ($toDate): void {
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
}