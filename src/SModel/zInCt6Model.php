<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zInCt6Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zInCt6';

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
        'ma_cty',
        'stt_rec',
        'stt_rec0',
        'ma_vt',
        'ten_vt',
        'dvt',
        'tk_vt',
        'so_luong',
        'so_luong_qd',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'nhap_gia_tb',
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'ma_spct',
        'ma_bp',
        'ma_phi'
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
