<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoPh0Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoPh0';

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
        'trang_thai',
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
        't_tien_hh',
        't_tien_hh_nt',
        't_thue_hh',
        't_thue_hh_nt',
        't_tt_hh',
        't_tt_hh_nt',
        't_tien_cp',
        't_tien_cp_nt',
        't_thue_cp',
        't_thue_cp_nt',
        't_tt_cp',
        't_tt_cp_nt',
        't_ck',
        't_ck_nt',
        't_tt',
        't_tt_nt',
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
        't_tien_hh' => 'float',
        't_tien_hh_nt' => 'float',
        't_thue_hh' => 'float',
        't_thue_hh_nt' => 'float',
        't_tt_hh' => 'float',
        't_tt_hh_nt' => 'float',
        't_tien_cp' => 'float',
        't_tien_cp_nt' => 'float',
        't_thue_cp' => 'float',
        't_thue_cp_nt' => 'float',
        't_tt_cp' => 'float',
        't_tt_cp_nt' => 'float',
        't_ck' => 'float',
        't_ck_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
