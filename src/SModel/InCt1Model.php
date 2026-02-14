<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCt1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCt1';

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
        'stt_rec_lsx',
        'stt_rec0_lsx',
        'so_lsx',
        'ma_kho',
        'ma_vt',
        'ten_vt',
        'dvt',
        'tk_vt',
        'tk_co',
        'ma_nx',
        'so_luong',
        'so_luong_qd',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'ma_vitri',
        'ma_lo',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_spct'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'gia_nt' => 'float',
        'gia' => 'float',
        'tien_nt' => 'float',
        'tien' => 'float',
    ];
}
