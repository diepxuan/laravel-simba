<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoCt3Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoCt3';

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
        'stt_rec_px',
        'stt_rec0_px',
        'so_dh',
        'so_px',
        'ma_kho',
        'ma_vt',
        'ten_vt',
        'dvt',
        'so_luong',
        'so_luong_qd',
        'gia_nt2',
        'gia2',
        'tien_nt2',
        'tien2',
        'tl_ck',
        'tien_ck_nt',
        'tien_ck',
        'ck_ds',
        'ck_ds_nt',
        'ma_thue',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
        'gia',
        'gia_nt',
        'tien_nt',
        'tien',
        'khuyen_mai',
        'tra_ck',
        'sl_xuat',
        'sl_xuat_qd',
        'sl_pn',
        'sl_pn_qd',
        'ma_nvkd',
        'ma_bp',
        'ma_hd',
        'ma_phi',
        'ma_vitri',
        'ma_lo',
        'ma_spct',
        'tk_pt',
        'tk_thue',
        'tk_dt',
        'tk_gv',
        'tk_vt',
        'tk_ck',
        'tk_km',
        'tk_tl'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'gia_nt2' => 'float',
        'gia2' => 'float',
        'tien_nt2' => 'float',
        'tien2' => 'float',
        'tl_ck' => 'float',
        'tien_ck_nt' => 'float',
        'tien_ck' => 'float',
        'ck_ds' => 'float',
        'ck_ds_nt' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'tt_nt' => 'float',
        'tt' => 'float',
        'gia' => 'float',
        'gia_nt' => 'float',
        'tien_nt' => 'float',
        'tien' => 'float',
        'khuyen_mai' => 'boolean',
        'tra_ck' => 'boolean',
        'sl_xuat' => 'float',
        'sl_xuat_qd' => 'float',
        'sl_pn' => 'float',
        'sl_pn_qd' => 'float',
    ];
}
