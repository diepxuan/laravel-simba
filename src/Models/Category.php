<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-04 18:42:34
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmNhvt;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Database\Eloquent\Relations\BelongsTo;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Support\Str;

class Category extends InDmNhvt
{
    public const ROOT = 'PRODUCT';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    // protected $primaryKey = 'id';

    /**
     * Get the children Categories.
     */
    public function catChildrens(): HasMany
    {
        return $this->hasMany(self::class, 'nhom_me', 'ma_nhvt');
    }

    /**
     * Get the parent Category.
     */
    public function catParent(): BelongsTo
    {
        return $this->belongsTo(self::class, 'nhom_me', 'ma_nhvt');
    }

    /**
     * Parent scope.
     *
     * @param mixed $query
     */
    public function scopeIsRoot($query)
    {
        return $this->scopeHasParent($query, '');
    }

    /**
     * Parent scope.
     *
     * @param mixed $query
     * @param mixed $parent
     */
    public function scopeHasParent($query, $parent = '')
    {
        if ($parent instanceof self) {
            return $query->where('nhom_me', $parent->sku);
        }
        if (\is_string($parent)) {
            return $query->where('nhom_me', $parent);
        }

        return $query;
    }

    /**
     * Get the Simba Category Id.
     */
    protected function id(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => implode('_', [$this->ma_cty, $this->ma_nhvt]),
        );
    }

    /**
     * Get the Simba Category Sku.
     */
    protected function sku(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => $this->ma_nhvt,
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
     * Get the Simba Category parent.
     */
    protected function parent(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['nhom_me'] ?: '',
        );
    }

    /**
     * Get the Simba Category name.
     */
    protected function name(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => $this->ten_nhvt,
        );
    }

    protected function Products(): HasMany
    {
        return $this->hasMany(Product::class, 'category', 'sku');
    }

    protected function urlPath(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => $this->catParent ? ($this->catParent->isRoot ? "{$this->urlKey}" : "{$this->catParent->urlPath}/{$this->urlKey}") : '',
        );
    }

    protected function urlKey(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => $value ?: ($this->isRoot ? '' : Str::of(vn_convert_encoding($this->name))->slug('-')),
            set: static fn (string $value, array $attributes) => strtolower($value),
        );
    }
}
