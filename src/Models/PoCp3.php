<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:26
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\PoCp3Model as Model;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class PoCp3.
 *
 * Hóa đơn mua hàng - Chi phí (PO3).
 */
class PoCp3 extends Model
{
    /** Filter theo mã chi phí */
    public function scopeFilterByMaCp(Builder $query, ?string $maCp): Builder
    {
        if (!empty($maCp)) {
            return $query->where('ma_cp', $maCp);
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

    /** Relationship với header */
    public function poPh3()
    {
        return $this->belongsTo(PoPh3::class, 'stt_rec', 'stt_rec');
    }
}
