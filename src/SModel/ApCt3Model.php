<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ApCt3Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ApCt3';

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
        'stt_rec0',
        'stt_rec_hd',
        'stt_rec_dh',
        'so_hd',
        'ngay_hd',
        'ma_nt',
        'tien_tt',
        'tien_tt_nt',
        'tien_tt_qd',
        'tt_hd',
        'tt_hd_nt',
        'tk',
        'dien_giai',
        'ma_bp',
        'ma_hd',
        'ma_phi',
        'ma_spct',
        'ma_lo'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_hd' => 'datetime',
        'tien_tt' => 'float',
        'tien_tt_nt' => 'float',
        'tien_tt_qd' => 'float',
        'tt_hd' => 'float',
        'tt_hd_nt' => 'float',
    ];
}
