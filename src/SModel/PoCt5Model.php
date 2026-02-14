<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoCt5Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoCt5';

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
        'stt_rec_hd',
        'stt_rec0_hd',
        'stt_rec_pn',
        'stt_rec0_pn',
        'stt_rec_dh',
        'stt_rec0_dh',
        'stt_rec_pdn',
        'stt_rec0_pdn',
        'so_hd',
        'so_pn',
        'so_dh',
        'so_pdn',
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'ma_vt',
        'ten_vt',
        'tk_dt',
        'tk_gv',
        'tk_vt',
        'tk_tl',
        'tk_thue',
        'so_luong',
        'dvt',
        'so_luong_qd',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'ma_thue',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
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
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'tt_nt' => 'float',
        'tt' => 'float',
    ];
}
