<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-07-12 15:43:29
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmVt as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

class InDmVt extends Model
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

    /**
     * Scope a query to include the quantity of products.
     *
     * @param Builder $query
     * @param bool    $flag
     *
     * @return Builder
     *
     * @deprecated use `withQuantity` instead
     */
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
     * Gọi stored procedure asINGetDMVT để lấy dữ Danh sách vật tư - hàng hóa.
     *
     * @return array
     */
    public static function getAsINGetDMVT(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asINGetDMVT
            @pMa_Cty = :pMa_Cty,
            @pMa_vt = :pMa_vt,
            @pStruct = :pStruct,
            @pLanguage = :pLanguage
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pMa_vt'    => $params['pMa_vt'] ?? null,
            'pStruct'   => $params['pStruct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? SysLanguage::DEFAULT,
        ]));
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
