<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaPh1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaPh1';

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
        'ma_kh',
        'dia_chi',
        'nguoi_gd',
        'dien_giai',
        'tk_no',
        'ma_nt',
        'ty_gia',
        't_tien_nt',
        't_tien',
        'stt_rec_hd',
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
        'ty_gia' => 'float',
        't_tien_nt' => 'float',
        't_tien' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
