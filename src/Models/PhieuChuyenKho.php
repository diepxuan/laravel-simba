<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-30 09:32:17
 */

namespace Diepxuan\Simba\Models;

use Carbon\Carbon;
use Diepxuan\Simba\SModel\InPH3;
use Illuminate\Database\Eloquent\Casts\Attribute;

class PhieuChuyenKho extends InPH3
{
    protected function ngayCt(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Carbon::parse($attributes['ngay_ct']),
        );
    }

    protected function ngayLct(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Carbon::parse($attributes['ngay_lct']),
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
