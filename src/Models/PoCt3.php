<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:27
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\PoCt3Model as Model;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class PoCt3.
 *
 * Hóa đơn mua hàng - Chi tiết vật tư (PO3).
 */
class PoCt3 extends Model
{
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

    /** Relationship với header */
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
}
