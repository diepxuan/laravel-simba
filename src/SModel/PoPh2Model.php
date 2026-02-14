<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh2Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh2';

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
        'ma_httt',
        'tk_pt',
        'dien_giai',
        'so_seri',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'ma_tt_po',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'ma_nt',
        'ty_gia',
        't_tien_nt0',
        't_tien0',
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
        'tao_tu_dh',
        'ghi_chu',
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
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ty_gia' => 'float',
        't_tien_nt0' => 'float',
        't_tien0' => 'float',
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
        't_so_luong' => 'float',
        'sua_tien' => 'boolean',
        'sua_thue' => 'boolean',
        'tao_tu_dh' => 'boolean',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
