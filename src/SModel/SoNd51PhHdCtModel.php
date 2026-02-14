<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51PhHdCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51PhHdCt';

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
        'ma_tb',
        'mau_so',
        'ten_loai',
        'ma_loai',
        'so_seri',
        'so_hd',
        'tu_so',
        'den_so',
        'so_luong',
        'ngay_sd',
        'donvi_in',
        'ma_thuedvi',
        'ngay_in',
        'so_hdin',
        'isclose'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_sd' => 'datetime',
        'ngay_in' => 'datetime',
        'isclose' => 'boolean',
    ];
}
