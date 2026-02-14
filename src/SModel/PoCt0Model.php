<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoCt0Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoCt0';

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
        'tk_vt',
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'so_luong',
        'dvt',
        'so_luong_qd',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'stt_rec_dhb',
        'stt_rec0_dhb',
        'so_dhb',
        'sl_dh',
        'sl_dh_qd'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'sl_dh' => 'float',
        'sl_dh_qd' => 'float',
    ];
}
