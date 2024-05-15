<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-15 10:29:27
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\Models\Traits\HasCompositePrimaryKey;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Str;

class Category extends AbstractModel
{
    use HasCompositePrimaryKey;
    use HasFactory;

    public const CREATED_AT = 'cDate';
    public const UPDATED_AT = 'lDate';

    /**
     * Indicates if the IDs are auto-incrementing.
     *
     * @var bool
     */
    public $incrementing = false;

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = true;

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InDmNhvt';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = ['ma_cty', 'ma_nhvt'];

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
    ];

    /**
     * The attributes that aren't mass assignable.
     *
     * @var array
     */
    protected $guarded = [
    ];

    /**
     * The attributes that should be hidden for arrays.
     *
     * @var array
     */
    protected $hidden = [
    ];

    /**
     * Get the Simba Category Id.
     */
    protected function id(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => implode('_', [$attributes['ma_cty'], $attributes['ma_nhvt']]),
        );
    }

    /**
     * Get the Simba Category Sku.
     */
    protected function sku(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ma_nhvt'],
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
            get: static fn (mixed $value, array $attributes) => $attributes['ten_nhvt'],
        );
    }

    /**
     * Get the Simba Category url_key.
     */
    protected function urlKey(): Attribute
    {
        $self = $this;

        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => Str::of(vn_convert_encoding($self->name))->lower()->slug('-'),
        );
    }

    /**
     * The "booted" method of the model.
     */
    protected static function booted(): void
    {
        static::addGlobalScope('onlyFirstCompany', static function (Builder $builder): void {
            $builder->where('ma_cty', '001');
        });
    }
}
