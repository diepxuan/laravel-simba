<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArDmNhKhModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ma_nhkh',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArDmNhKh';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_nhkh';

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
        'ma_nhkh',
        'ten_nhkh',
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
