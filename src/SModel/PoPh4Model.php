<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh4Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh4';

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
        'dia_chi',
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
        't_thue_nt',
        't_thue',
        'kht_tain',
        't_tt',
        't_tt_nt',
        't_so_luong',
        'sua_tt',
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
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ty_gia' => 'float',
        't_tien_nt0' => 'float',
        't_tien0' => 'float',
        't_cp_nt' => 'float',
        't_cp' => 'float',
        't_thue_nt' => 'float',
        't_thue' => 'float',
        'kht_tain' => 'boolean',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        't_so_luong' => 'float',
        'sua_tt' => 'boolean',
        'post2gl' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
