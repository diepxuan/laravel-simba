<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArDmKhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArDmKh';

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
        'ma_kh',
        'loai',
        'ten_kh',
        'ma_so_thue',
        'dia_chi',
        'tel',
        'fax',
        'email',
        'home_page',
        'nguoi_gd',
        'ma_ngh',
        'ten_nh',
        'cn_nh',
        'so_tk_nh',
        'tinh_tp_nh',
        'tk',
        'ma_plkh1',
        'ma_plkh2',
        'ma_plkh3',
        'ma_nhkh',
        'ma_tt',
        'ma_httt',
        'ma_httt_po',
        'gh_no',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'ghi_chu',
        'tinh_dt_nb',
        'isKh',
        'isNcc',
        'isNv',
        'ksd',
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
        'gh_no' => 'float',
        'han_ck' => 'float',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ls_qh' => 'float',
        'tinh_dt_nb' => 'boolean',
        'isKh' => 'boolean',
        'isNcc' => 'boolean',
        'isNv' => 'boolean',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
