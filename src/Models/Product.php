<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-04 17:58:29
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmVt;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Schema;

class Product extends InDmVt
{
    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'quantity' => 'decimal:1',
        'gia_nt2'  => 'float',
        'price'    => 'float',
    ];

    public function scopeWithQuantityOld($query, $flag = true)
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

    public function scopeWithQuantity($query, $flag = true)
    {
        if (!$flag) {
            return $query;
        }
        // Lấy danh sách cột từ bảng InDmVt, tránh cột tính toán và kiểu dữ liệu không hỗ trợ GROUP BY
        $columns        = Schema::connection($this->connection)->getColumnListing($this->table);
        $groupByColumns = array_diff($columns, ['quantity', 'Anh']); // Bỏ cột TEXT, NTEXT, IMAGE
        $groupByColumns = array_map(fn ($col) => "{$this->table}.{$col}", $groupByColumns);

        // Danh sách cột SELECT
        $selectColumns = array_merge(
            ["{$this->table}.ma_vt", "{$this->table}.ten_vt"],
            $groupByColumns,
            [
                DB::raw('COALESCE(SUM(incdvt.so_luong), 0) + COALESCE(SUM(inct.sl_nhap_qd - inct.sl_xuat_qd), 0) AS quantity'),
            ]
        );

        return $query->leftJoin('incdvt', function ($join): void {
            $join->on("{$this->table}.ma_vt", '=', 'incdvt.ma_vt')
                ->where('incdvt.nam', '=', DB::raw('YEAR(GETDATE())'))
            ;
        })
            ->leftJoin('inct', function ($join): void {
                $join->on("{$this->table}.ma_vt", '=', 'inct.ma_vt')
                    ->where('inct.ngay_ct', '>=', DB::raw('DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0)'))
                ;
            })
            ->where("{$this->table}.ma_cty", '001') // Chỉ lấy dữ liệu của công ty 001
            ->select($selectColumns)
            ->groupBy($groupByColumns)
        ;
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

    protected function urlKey(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Str::of(vn_convert_encoding($this->name))->slug('-'),
        );
    }

    /**
     * Get the Category.
     */
    protected function cat(): BelongsTo
    {
        return $this->belongsTo(Category::class, 'ma_nhvt', 'ma_nhvt');
    }

    /**
     * Get the attributes that should be cast.
     *
     * @return array<string, string>
     */
    protected function casts(): array
    {
        // return $this->casts;
        return array_merge(parent::casts(), $this->casts);
    }
}
