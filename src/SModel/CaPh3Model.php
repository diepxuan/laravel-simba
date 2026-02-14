<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaPh3Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaPh3';

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
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'kht_tain',
        'ma_kh',
        'dia_chi',
        'nguoi_gd',
        'dien_giai',
        'tk_co',
        'ma_nt',
        'ty_gia',
        't_tien_nt',
        't_tien',
        't_thue',
        't_tt',
        't_thue_nt',
        't_tt_nt',
        'trang_thai',
        'post2gl',
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
        'ty_gia' => 'float',
        't_tien_nt' => 'float',
        't_tien' => 'float',
        't_thue' => 'float',
        't_tt' => 'float',
        't_thue_nt' => 'float',
        't_tt_nt' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
