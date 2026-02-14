<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zInPh8Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zInPh8';

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
        'ma_kh',
        'ten_kh',
        'dia_chi',
        'nguoi_gd',
        'dien_giai',
        'ma_hd',
        'ma_bp',
        'ma_nx',
        'ma_phi',
        'ma_nt',
        'ty_gia',
        't_tien_nt',
        't_tien',
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
        't_tien_nt' => 'float',
        't_tien' => 'float',
        'gia_dd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
