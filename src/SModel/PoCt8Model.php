<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoCt8Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoCt8';

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
        'tk_du',
        'tk_thue',
        'tk_thue_nk',
        'tk_thue_ttdb',
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
        'ts_nk',
        'thue_nk_nt',
        'thue_nk',
        'ts_ttdb',
        'thue_ttdb_nt',
        'thue_ttdb',
        'cp_nt',
        'cp',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'stt_rec_pn',
        'stt_rec0_pn',
        'stt_rec_dh',
        'stt_rec0_dh',
        'stt_rec_pdn',
        'stt_rec0_pdn',
        'so_pn',
        'so_dh',
        'so_pdn'
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
        'ts_nk' => 'float',
        'thue_nk_nt' => 'float',
        'thue_nk' => 'float',
        'ts_ttdb' => 'float',
        'thue_ttdb_nt' => 'float',
        'thue_ttdb' => 'float',
        'cp_nt' => 'float',
        'cp' => 'float',
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
