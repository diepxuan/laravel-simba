<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoDmNvkdModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ma_nvkd',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoDmNvkd';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_nvkd';

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
        'ma_nvkd',
        'ten_nvkd',
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
