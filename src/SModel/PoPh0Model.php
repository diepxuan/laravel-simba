<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoPh0Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoPh0';

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
        'ma_bp',
        'nguoi_dn',
        'dien_giai',
        'ngay_ct',
        'so_ct',
        'ngay_lct',
        'han_giao',
        't_so_luong',
        'post2gl',
        'trang_thai',
        'tao_tu_dhb',
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
        'han_giao' => 'datetime',
        't_so_luong' => 'float',
        'post2gl' => 'boolean',
        'tao_tu_dhb' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
