<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51OptModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ma_opt',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51Opt';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_opt';

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        'ma_cty',
        'ma_opt',
        'gia_tri',
        'ksd',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
