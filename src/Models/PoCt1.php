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
use Diepxuan\Simba\SModel\PoCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class PoCt1.
 *
 * This class represents the model for purchase order details.
 *
 * Behavior nghiệp vụ (tổng giá trị / số lượng theo vật tư / nhà cung cấp,
 * tỷ lệ nhập, các báo cáo mua hàng) đã được tách sang
 * `Diepxuan\Catalog\Models\Concerns\HasPoCt1PurchaseMetrics`
 * và gắn vào `Diepxuan\Catalog\Models\Simba\PoCt1` (nếu có).
 *
 * Còn giữ ở đây:
 * - Scope filter theo field Simba.
 * - Quan hệ Simba-Simba: poPh3, inDmVt, inDmKho, inDmViTri, inDmLo, sysDepartment, glDmTkVt, glDmTkThue.
 */
class PoCt1 extends Model
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

    /** Filter theo mã nhà cung cấp thông qua phiếu tổng hợp */
    public function scopeFilterByMaNcc(Builder $query, ?string $maNcc): Builder
    {
        if (!empty($maNcc)) {
            $query->whereHas('poPh3', function ($q) use ($maNcc): void {
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
            $query->whereHas('poPh3', function ($q) use ($fromDate): void {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if (!empty($toDate)) {
            $query->whereHas('poPh3', function ($q) use ($toDate): void {
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
}