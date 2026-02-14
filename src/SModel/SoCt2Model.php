<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoCt2Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoCt2';

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
        'stt_rec_dh',
        'stt_rec0_dh',
        'so_dh',
        'ma_vt',
        'ten_vt',
        'ma_kho',
        'so_luong',
        'dvt',
        'so_luong_qd',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'gia_nt2',
        'gia2',
        'tien_nt2',
        'tien2',
        'tl_ck',
        'tien_ck_nt',
        'tien_ck',
        'ma_thue',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'khuyen_mai',
        'tra_ck',
        'ma_nvkd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'ma_hd',
        'tk_pt',
        'tk_dt',
        'tk_gv',
        'tk_vt',
        'tk_thue',
        'tk_ck',
        'tk_km',
        'tk_tl',
        'ma_vitri',
        'ma_lo',
        'sl_hd',
        'sl_hd_qd',
        'sl_pn',
        'sl_pn_qd'
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
        'gia_nt2' => 'float',
        'gia2' => 'float',
        'tien_nt2' => 'float',
        'tien2' => 'float',
        'tl_ck' => 'float',
        'tien_ck_nt' => 'float',
        'tien_ck' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'khuyen_mai' => 'boolean',
        'tra_ck' => 'boolean',
        'sl_hd' => 'float',
        'sl_hd_qd' => 'float',
        'sl_pn' => 'float',
        'sl_pn_qd' => 'float',
    ];
}
