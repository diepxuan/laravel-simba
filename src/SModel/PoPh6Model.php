<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh6Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh6';

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
        'kht_tain',
        'dia_chi',
        'nguoi_gd',
        'ma_httt',
        'tk_pt',
        'tk_thue',
        'ma_tt_po',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'dien_giai',
        'so_seri',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'ngay_hd',
        'so_hd',
        'ma_nt',
        'ty_gia',
        't_tien',
        't_tien_nt',
        't_thue',
        't_thue_nt',
        't_tt',
        't_tt_nt',
        'post2gl',
        'post2in',
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
        'kht_tain' => 'boolean',
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'ngay_ct' => 'datetime',
        'ngay_lct' => 'datetime',
        'ngay_hd' => 'datetime',
        'ty_gia' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
