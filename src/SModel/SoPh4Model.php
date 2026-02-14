<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoPh4Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoPh4';

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
        'ma_ct',
        'ma_gd',
        'so_seri_mhd',
        'so_seri',
        'so_hd',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'ngay_hd',
        'ma_kh',
        'ten_kh_vat',
        'dia_chi_vat',
        'ma_so_thue',
        'nguoi_gd',
        'dien_giai',
        'ma_nt',
        'ty_gia',
        'ma_httt',
        'tk_pt',
        'tk_thue',
        'tk_ck_ds',
        'ma_tt',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'gia_tb',
        'sua_tien',
        'sua_ck',
        'sua_thue',
        'so_pn',
        'ngay_pn',
        'dia_chi_pn',
        'nguoi_gd_pn',
        'tel_pn',
        'dien_giai_pn',
        't_tien2',
        't_tien_nt2',
        't_thue',
        't_thue_nt',
        'kht_tain',
        't_ck',
        't_ck_nt',
        't_ck_ds',
        't_ck_ds_nt',
        't_tt',
        't_tt_nt',
        't_so_luong',
        't_tien',
        't_tien_nt',
        'tao_tu_hd',
        'trang_thai',
        'post2gl',
        'post2in',
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
        'ngay_ct' => 'datetime',
        'ngay_lct' => 'datetime',
        'ngay_hd' => 'datetime',
        'ty_gia' => 'float',
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'gia_tb' => 'boolean',
        'sua_tien' => 'boolean',
        'sua_ck' => 'boolean',
        'sua_thue' => 'boolean',
        'ngay_pn' => 'datetime',
        't_tien2' => 'float',
        't_tien_nt2' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        'kht_tain' => 'boolean',
        't_ck' => 'float',
        't_ck_nt' => 'float',
        't_ck_ds' => 'float',
        't_ck_ds_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        't_so_luong' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        'tao_tu_hd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
