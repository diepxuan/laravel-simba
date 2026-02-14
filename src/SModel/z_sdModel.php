<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class z_sdModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'z_sd';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'ma_ts',
        'ngay',
        'loai_dt',
        'ma_bpsd',
        'ma_phi',
        'ma_spct',
        'tk_ts',
        'tk_kh',
        'tk_cp',
        'ma_dt',
        'gd_nd',
        'is_dmts',
        'stt',
        'ngay_sd',
        'ngay_trong_thang'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay' => 'datetime',
        'gd_nd' => 'boolean',
        'is_dmts' => 'boolean',
        'stt' => 'integer',
        'ngay_sd' => 'integer',
        'ngay_trong_thang' => 'integer',
    ];
}
