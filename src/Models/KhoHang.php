<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-22 19:26:04
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmKho;
use Illuminate\Database\Eloquent\Casts\Attribute;

class KhoHang extends InDmKho
{
    protected function id(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => implode('_', [$attributes['ma_cty'], $attributes['ma_kho']]),
        );
    }

    protected function sku(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ma_kho'],
        );
    }

    protected function name(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ten_kho'],
        );
    }
}
