<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-16 00:28:23
 */

namespace Diepxuan\Simba\Traits;

use Illuminate\Database\Eloquent\Builder;

trait HasPoVoucherFilters
{
    public function scopeFilterBySearch(Builder $query, ?string $search): Builder
    {
        if (empty($search)) {
            return $query;
        }

        return $query->where(static function ($q) use ($search): void {
            $q->where('so_ct', 'like', "%{$search}%")
                ->orWhere('dien_giai', 'like', "%{$search}%")
            ;

            if (method_exists($q->getModel(), 'getFillable') && \in_array('so_hd', $q->getModel()->getFillable(), true)) {
                $q->orWhere('so_hd', 'like', "%{$search}%");
            }
        });
    }

    public function scopeFilterByMaKh(Builder $query, ?string $maKh): Builder
    {
        if (!empty($maKh)) {
            return $query->where('ma_kh', $maKh);
        }

        return $query;
    }

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
}
