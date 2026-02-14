<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoPh2Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoPh2';

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
        'tk_ngh_kh',
        'ten_ngh_kh',
        'so_dh',
        'trang_thai',
        'ma_tt',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'dien_giai',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'so_hdcp',
        'so_sericp',
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
        't_tien',
        't_tien_nt',
        't_so_luong',
        'post2gl',
        'post2in',
        'gia_dd',
        'sua_tien',
        'tao_tu_dh',
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
        'ngay_lct' => 'datetime',
        'ty_gia' => 'float',
        'km' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        't_so_luong' => 'float',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'gia_dd' => 'boolean',
        'sua_tien' => 'boolean',
        'tao_tu_dh' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
