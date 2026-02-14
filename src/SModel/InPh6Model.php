<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InPh6Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InPh6';

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
        'ngay_ct',
        'ngay_lct',
        'so_ct',
        'ngay_ctn',
        'so_ctn',
        'ma_kh',
        'nguoi_gd',
        'dien_giai',
        'pn_gtb',
        'px_gdd',
        'tk_vt_lrtd',
        'tk_lrtd',
        't_so_luong',
        'ma_nt',
        'ty_gia',
        't_tien_nt',
        't_tien',
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
        'ngay_ctn' => 'datetime',
        'pn_gtb' => 'boolean',
        'px_gdd' => 'boolean',
        't_so_luong' => 'float',
        'ty_gia' => 'float',
        't_tien_nt' => 'float',
        't_tien' => 'float',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
