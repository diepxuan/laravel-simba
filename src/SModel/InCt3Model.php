<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCt3Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCt3';

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
        'ma_khon',
        'ma_khox',
        'ma_vitri',
        'ma_vitrin',
        'ma_vitrix',
        'ma_vt',
        'ten_vt',
        'dvt',
        'so_luong',
        'so_luong_qd',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'ma_nx',
        'tk_vt',
        'tk_no',
        'ma_hd',
        'ma_spct',
        'ma_bp',
        'ma_phi',
        'ma_lo'
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
