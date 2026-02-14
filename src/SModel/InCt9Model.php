<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCt9Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCt9';

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
        'ma_kho',
        'ma_vt',
        'ten_vt',
        'dvt',
        'tk_vt',
        'tk_co',
        'ma_nx',
        'sl_ton',
        'sl_kk',
        'sl_cl',
        'tien_ss',
        'ma_vitri',
        'ma_lo',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'con_tot',
        'kem_pc',
        'mat_pc',
        'ghi_chu'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'sl_ton' => 'float',
        'sl_kk' => 'float',
        'sl_cl' => 'float',
        'tien_ss' => 'float',
        'con_tot' => 'integer',
        'kem_pc' => 'integer',
        'mat_pc' => 'integer',
    ];
}
