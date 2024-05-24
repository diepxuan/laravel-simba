<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-23 19:32:26
 */

namespace Diepxuan\Simba\Models;

use Carbon\Carbon;
use Diepxuan\Simba\SModel\InCT3;
use Diepxuan\Simba\SModel\InPH3;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Database\Eloquent\Relations\HasMany;

class PhieuXuatDieuChuyenKho extends InPH3
{
    public function scopeWhereNgayCt($query, $fromDate, $toDate)
    {
        return $this->scopeWhereDateBetween($query, 'ngay_ct', $fromDate, $toDate);
    }

    public function scopeWhereKhoXuat($query, $maKhoXuat)
    {
        return $query->whereHas('chungtu', static function (Builder $query) use ($maKhoXuat): void {
            $query->where('Ma_KhoX', 'like', "{$maKhoXuat}%");
        });
    }

    public function chungtu(): HasMany
    {
        return $this->hasMany(InCT3::class, 'stt_rec', 'stt_rec');
    }

    protected function ngayCt(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Carbon::parse($attributes['ngay_ct'])->format('d/m/Y'),
        );
    }

    protected function ngayLct(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Carbon::parse($attributes['ngay_lct'])->format('d/m/Y'),
        );
    }

    protected function soLuong(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => number_format((float) $attributes['t_so_luong'], 1),
        );
    }

    protected function soTien(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => number_format((float) $attributes['t_tien'], 0),
        );
    }
}
