<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-26 20:50:04
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmVt;
use Illuminate\Database\Eloquent\Casts\Attribute;

class Product extends InDmVt
{
    /**
     * Get the Simba Product Id.
     */
    protected function id(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => implode('_', [$attributes['ma_cty'], $attributes['ma_vt']]),
        );
    }

    /**
     * Get the Simba  Sku.
     */
    protected function sku(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ma_vt'],
        );
    }

    /**
     * Get the Simba name.
     */
    protected function name(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ten_vt'],
        );
    }

    /**
     * Get the Simba name.
     */
    protected function price(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['gia_nt2'],
        );
    }

    /**
     * Get the Simba Category.
     */
    protected function category(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ma_nhvt'],
        );
    }

    /**
     * Get the Simba status.
     */
    protected function status(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => !$attributes['ksd'],
        );
    }
}
