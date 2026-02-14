<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoCt1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoCt1';

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
        'stt_rec_pdn',
        'stt_rec0_pdn',
        'so_pdn',
        'ma_vt',
        'ten_vt',
        'tk_vt',
        'tk_thue',
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'so_luong',
        'dvt',
        'so_luong_qd',
        'gia_nt0',
        'gia0',
        'tien_nt0',
        'tien0',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'sl_nhap',
        'sl_nhap_qd',
        'sl_hd',
        'sl_hd_qd'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'gia_nt0' => 'float',
        'gia0' => 'float',
        'tien_nt0' => 'float',
        'tien0' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'tt_nt' => 'float',
        'tt' => 'float',
        'sl_nhap' => 'float',
        'sl_nhap_qd' => 'float',
        'sl_hd' => 'float',
        'sl_hd_qd' => 'float',
    ];
}
