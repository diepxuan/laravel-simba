<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-27 17:49:16
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

abstract class SModel extends Model
{
    use HasFactory;

    public const CTY = '001';

    /**
     * Indicates if the IDs are auto-incrementing.
     *
     * @var bool
     */
    public $incrementing = true;

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
    protected $table;

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey;

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
     * The connection name for the model.
     *
     * @var string
     */
    protected $connection;

    /**
     * Create a new Eloquent model instance.
     */
    public function __construct(array $attributes = [])
    {
        parent::__construct($attributes);
        $this->connection = config('simba.connection');
    }

    /**
     * The scope check this model is enable.
     *
     * @param mixed $query
     *
     * @return mixed
     */
    public function scopeIsEnable($query)
    {
        return $query;

        return $query->where('ksd', 0);
    }

    /**
     * Scope a query to only include the last n days records.
     *
     * @param Builder $query
     * @param mixed   $fieldName
     * @param mixed   $fromDate
     * @param mixed   $toDate
     *
     * @return Builder
     */
    public function scopeWhereDateBetween($query, $fieldName, $fromDate, $toDate)
    {
        return $query->whereDate($fieldName, '>=', $fromDate)->whereDate($fieldName, '<=', $toDate);
    }

    /**
     * The "booted" method of the model.
     */
    protected static function booted(): void
    {
        static::addGlobalScope('onlyFirstCompany', static function (Builder $builder): void {
            $builder->where('ma_cty', static::CTY);
        });
    }
}
