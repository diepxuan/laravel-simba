<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zpmct2Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zpmct2';

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
        'stt_rec',
        'stt_rec0',
        'ma_vt',
        'ten_vt',
        'dvt',
        'so_luong',
        'so_luong_qd',
        'dvdg',
        'tong_lo',
        'ma_lo',
        'qc_dg',
        'ngay_sx',
        'ngay_ht',
        'noi_sx'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'dvdg' => 'float',
        'tong_lo' => 'float',
        'ngay_sx' => 'datetime',
        'ngay_ht' => 'datetime',
    ];
}
