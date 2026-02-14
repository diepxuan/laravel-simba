<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoPh1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoPh1';

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
        'ma_kh',
        'nguoi_gd',
        'ten_kh_vat',
        'dia_chi_vat',
        'ma_so_thue',
        'ma_httt',
        'ma_tt',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'dien_giai',
        'so_ct',
        'ngay_ct',
        'ngay_hh',
        'ma_nt',
        'ty_gia',
        'ma_dckh',
        'nguoi_nhan',
        'cty_nhan',
        'dc_nhan',
        'tel_nhan',
        'ma_nvt',
        'ma_pt',
        'bien_so',
        'nguoi_lai',
        'ma_td',
        'ten_td',
        'km',
        'tk_pt',
        'tk_thue',
        'tk_ck_ds',
        'ck_st',
        'gia_st',
        'sua_tt',
        'sua_tien',
        'sua_ck',
        'sua_thue',
        't_so_luong',
        't_tien2',
        't_tien_nt2',
        't_thue',
        't_thue_nt',
        't_ck',
        't_ck_nt',
        'tl_ck_ds',
        't_ck_ds',
        't_ck_ds_nt',
        't_tt',
        't_tt_nt',
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
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ngay_ct' => 'datetime',
        'ngay_hh' => 'datetime',
        'ty_gia' => 'float',
        'km' => 'float',
        'ck_st' => 'boolean',
        'gia_st' => 'boolean',
        'sua_tt' => 'boolean',
        'sua_tien' => 'boolean',
        'sua_ck' => 'boolean',
        'sua_thue' => 'boolean',
        't_so_luong' => 'float',
        't_tien2' => 'float',
        't_tien_nt2' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        't_ck' => 'float',
        't_ck_nt' => 'float',
        'tl_ck_ds' => 'float',
        't_ck_ds' => 'float',
        't_ck_ds_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
