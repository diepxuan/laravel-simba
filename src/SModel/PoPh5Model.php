<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh5Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh5';

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
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'ma_kh',
        'dia_chi_vat',
        'ma_so_thue',
        'ten_kh_vat',
        'nguoi_gd',
        'ma_httt',
        'tk_pt',
        'tk_thue',
        'dien_giai',
        'ma_nt',
        'ty_gia',
        't_tien',
        't_tien_nt',
        't_thue',
        't_thue_nt',
        't_tt',
        't_tt_nt',
        'tao_tu_pn',
        't_so_luong',
        'gia_dd',
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
        'ty_gia' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'tao_tu_pn' => 'boolean',
        't_so_luong' => 'float',
        'gia_dd' => 'boolean',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
