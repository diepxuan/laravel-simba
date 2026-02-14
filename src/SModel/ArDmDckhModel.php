<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArDmDckhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArDmDckh';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_cty';

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
        'ma_kh',
        'ma_dckh',
        'ten_kh',
        'dia_chi',
        'tel',
        'fax',
        'nguoi_gd',
        'ksd',
        'cdate',
        'cuser',
        'ldate',
        'luser',
        'dc_md'
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
        'dc_md' => 'boolean',
    ];
}
