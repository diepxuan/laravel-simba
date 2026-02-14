<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaDmKuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaDmKu';

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
        'ma_ku',
        'ten_ku',
        'so_ku',
        'ngay_vay',
        'ngay_ky',
        'thoi_han',
        'tinh_theo',
        'phuong_phap',
        'ky_tt_goc',
        'ky_tt_lai',
        'ngay_dh',
        'ma_hd',
        'ma_nt',
        'tien_nt',
        'tien',
        'lai_suat',
        'ls_qh',
        'tk_vay',
        'tk_cp',
        'tk_cp_pt',
        'ghi_chu',
        'ksd',
        'cuser',
        'cdate',
        'luser',
        'ldate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_vay' => 'datetime',
        'ngay_ky' => 'datetime',
        'thoi_han' => 'integer',
        'ngay_dh' => 'datetime',
        'tien_nt' => 'float',
        'tien' => 'float',
        'lai_suat' => 'float',
        'ls_qh' => 'float',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
