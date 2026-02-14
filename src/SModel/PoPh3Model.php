<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh3Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh3';

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
        'mau_hd',
        'ma_kh',
        'dia_chi',
        'nguoi_gd',
        'ma_httt',
        'tk_pt',
        'tk_ck_ds',
        'dien_giai',
        'so_seri',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'kht_tain',
        'ngay_pn',
        'so_pn',
        'ngay_hd',
        'so_hd',
        'ma_tt_po',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'ma_nt',
        'ty_gia',
        't_tien_nt0',
        't_tien0',
        'ts_nk',
        't_thue_nk_nt',
        't_thue_nk',
        'ts_ttdb',
        't_thue_ttdb_nt',
        't_thue_ttdb',
        't_cp_nt',
        't_cp',
        't_tien_nt',
        't_tien',
        't_thue_nt',
        't_thue',
        'tl_ck_hd',
        't_ck',
        't_ck_nt',
        't_tt',
        't_tt_nt',
        't_so_luong',
        'ck_st',
        'sua_tien',
        'sua_thue',
        'sua_thue_nk',
        'sua_thue_ttdb',
        'sua_tt',
        'tao_tu_pn',
        'tao_tu_dh',
        'trang_thai',
        'ghi_chu',
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
        'kht_tain' => 'boolean',
        'ngay_pn' => 'datetime',
        'ngay_hd' => 'datetime',
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ty_gia' => 'float',
        't_tien_nt0' => 'float',
        't_tien0' => 'float',
        'ts_nk' => 'float',
        't_thue_nk_nt' => 'float',
        't_thue_nk' => 'float',
        'ts_ttdb' => 'float',
        't_thue_ttdb_nt' => 'float',
        't_thue_ttdb' => 'float',
        't_cp_nt' => 'float',
        't_cp' => 'float',
        't_tien_nt' => 'float',
        't_tien' => 'float',
        't_thue_nt' => 'float',
        't_thue' => 'float',
        'tl_ck_hd' => 'float',
        't_ck' => 'float',
        't_ck_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        't_so_luong' => 'float',
        'ck_st' => 'boolean',
        'sua_tien' => 'boolean',
        'sua_thue' => 'boolean',
        'sua_thue_nk' => 'boolean',
        'sua_thue_ttdb' => 'boolean',
        'sua_tt' => 'boolean',
        'tao_tu_pn' => 'boolean',
        'tao_tu_dh' => 'boolean',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
