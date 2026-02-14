<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoCt';

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
        'stt_rec_hd',
        'stt_rec0_hd',
        'thang',
        'nam',
        'ma_ct',
        'ngay_ct',
        'so_ct',
        'so_hd',
        'so_px',
        'so_dh',
        'ma_nt',
        'ty_gia',
        'dien_giai',
        'ma_kho',
        'ma_vitri',
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
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
        'gia_nt',
        'gia',
        'tien_nt',
        'tien',
        'ma_tt',
        'han_ck',
        'ngay_ck',
        'tl_cktt',
        'han_tt',
        'ngay_tt',
        'ls_qh',
        'ma_kh',
        'ten_kh',
        'nguoi_gd',
        'ma_lo',
        'ma_httt',
        'ma_nvkd',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        'ma_nvt',
        'ma_pt',
        'bien_so',
        'nguoi_lai',
        'ma_hd',
        'ma_td',
        'ten_td',
        'km',
        'khuyen_mai',
        'tra_lai',
        'tra_ck',
        'ma_nx',
        'tk_pt',
        'tk_dt',
        'tk_gv',
        'tk_vt',
        'tk_thue',
        'tk_ck',
        'trang_thai',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'thang' => 'integer',
        'nam' => 'integer',
        'ngay_ct' => 'datetime',
        'ty_gia' => 'float',
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
        'gia_nt' => 'float',
        'gia' => 'float',
        'tien_nt' => 'float',
        'tien' => 'float',
        'han_ck' => 'float',
        'ngay_ck' => 'datetime',
        'tl_cktt' => 'float',
        'han_tt' => 'float',
        'ngay_tt' => 'datetime',
        'ls_qh' => 'float',
        'km' => 'float',
        'khuyen_mai' => 'boolean',
        'tra_lai' => 'boolean',
        'tra_ck' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
