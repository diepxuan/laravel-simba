<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoCt1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoCt1';

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
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'so_luong',
        'dvt',
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
        'sl_xuat',
        'sl_xuat_qd',
        'sl_hd',
        'sl_hd_qd',
        'sl_lenh',
        'sl_lenh_qd',
        'so_luong1',
        'so_luong2',
        'so_luong3'
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
        'khuyen_mai' => 'boolean',
        'tra_ck' => 'boolean',
        'sl_xuat' => 'float',
        'sl_xuat_qd' => 'float',
        'sl_hd' => 'float',
        'sl_hd_qd' => 'float',
        'sl_lenh' => 'float',
        'sl_lenh_qd' => 'float',
        'so_luong1' => 'float',
        'so_luong2' => 'float',
        'so_luong3' => 'float',
    ];
}
