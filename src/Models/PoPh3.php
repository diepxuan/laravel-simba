<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-16 00:28:19
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\PoPh3Model as Model;
use Diepxuan\Simba\Traits\HasPoVoucherFilters;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class PoPh3.
 *
 * Hóa đơn mua hàng - Header (PO3).
 */
class PoPh3 extends Model
{
    use HasPoVoucherFilters;

    /** Filter theo tìm kiếm (số hóa đơn, số chứng từ, diễn giải) */
    public function scopeFilterBySearch(Builder $query, ?string $search): Builder
    {
        if (!empty($search)) {
            return $query->where(static function ($q) use ($search): void {
                $q->where('so_hd', 'like', "%{$search}%")
                    ->orWhere('so_ct', 'like', "%{$search}%")
                    ->orWhere('dien_giai', 'like', "%{$search}%")
                ;
            });
        }

        return $query;
    }

    /** Filter theo mã khách hàng/NCC */
    public function scopeFilterByMaKh(Builder $query, ?string $maKh): Builder
    {
        if (!empty($maKh)) {
            return $query->where('ma_kh', $maKh);
        }

        return $query;
    }

    /** Filter theo ngày chứng từ */
    public function scopeFilterByNgayCt(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereDate('ngay_ct', '>=', $fromDate);
        }
        if (!empty($toDate)) {
            $query->whereDate('ngay_ct', '<=', $toDate);
        }

        return $query;
    }

    /** Relationship với chi tiết vật tư */
    public function chiTiets()
    {
        return $this->hasMany(PoCt3::class, 'stt_rec', 'stt_rec');
    }

    /** Relationship với chi phí */
    public function chiPhis()
    {
        return $this->hasMany(PoCp3::class, 'stt_rec', 'stt_rec');
    }

    /** Relationship với nhà cung cấp */
    public function nhaCungCap()
    {
        return $this->belongsTo(ArDmKh::class, 'ma_kh', 'ma_kh');
    }
}
