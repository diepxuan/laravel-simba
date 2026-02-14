<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh8Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh8';

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
        'nguoi_gd',
        'ma_httt',
        'tk_pt',
        'dien_giai',
        'so_seri',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
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
        't_thue_nk_nt',
        't_thue_nk',
        't_thue_ttdb_nt',
        't_thue_ttdb',
        't_cp_nt',
        't_cp',
        't_tien_nt',
        't_tien',
        't_thue_nt',
        't_thue',
        't_gg',
        't_gg_nt',
        't_tt',
        't_tt_nt',
        't_so_luong',
        'sua_tien',
        'sua_thue',
        'sua_thue_nk',
        'sua_thue_ttdb',
        'sua_tt',
        'tao_tu_pn',
        'post2gl',
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
        'ngay_ct' => 'datetime',
        'ngay_lct' => 'datetime',
        'ngay_pn' => 'datetime',
        'ngay_hd' => 'datetime',
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ty_gia' => 'float',
        't_tien_nt0' => 'float',
        't_tien0' => 'float',
        't_thue_nk_nt' => 'float',
        't_thue_nk' => 'float',
        't_thue_ttdb_nt' => 'float',
        't_thue_ttdb' => 'float',
        't_cp_nt' => 'float',
        't_cp' => 'float',
        't_tien_nt' => 'float',
        't_tien' => 'float',
        't_thue_nt' => 'float',
        't_thue' => 'float',
        't_gg' => 'float',
        't_gg_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'sua_tien' => 'boolean',
        'sua_thue' => 'boolean',
        'sua_thue_nk' => 'boolean',
        'sua_thue_ttdb' => 'boolean',
        'sua_tt' => 'boolean',
        'tao_tu_pn' => 'boolean',
        'post2gl' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
