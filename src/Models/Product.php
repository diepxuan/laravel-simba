<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-07-02 15:21:29
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmVt;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Support\Facades\DB;

class Product extends InDmVt
{
    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'quantity' => 'decimal:1',
    ];

    public function scopeWithQuantity($query, $flag = true)
    {
        if (!$flag) {
            return $query;
        }
        $sql = <<<'EOF'
            (SELECT SUM(so_luong) AS so_luong
            FROM(
                SELECT ma_vt ,
                    SUM(so_luong) AS so_luong
                FROM incdvt
                WHERE ma_cty = ma_cty
                    AND ma_vt = ma_vt
                    AND nam = YEAR(GETDATE())
                GROUP BY ma_vt
            UNION ALL
                SELECT ma_vt ,
                    SUM(sl_nhap_qd - sl_xuat_qd) AS so_luong
                FROM inct
                WHERE ma_cty = ma_cty
                    AND ma_vt = ma_vt
                    AND ngay_ct >= DATEADD(YEAR, YEAR(GETDATE()) - 1900, '19000101')
                GROUP BY ma_vt
            ) gr
            WHERE gr.ma_vt = InDmVt.ma_vt
            GROUP BY gr.ma_vt) AS quantity
            EOF;

        return $query->addSelect('*')->addSelect(DB::raw($sql));
    }

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

    /**
     * Get the attributes that should be cast.
     *
     * @return array<string, string>
     */
    protected function casts(): array
    {
        return $this->casts;
    }
}
