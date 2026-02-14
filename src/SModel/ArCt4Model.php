<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArCt4Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArCt4';

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
        'tk',
        'ma_kh',
        'dien_giai',
        'ma_nt',
        'ty_gia',
        'ps_co',
        'ps_co_nt',
        'ps_no',
        'ps_no_nt',
        'nh_dk',
        'ma_bp',
        'ma_phi',
        'ma_hd',
        'ma_spct',
        'ma_lo',
        'ma_ku'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ty_gia' => 'float',
        'ps_co' => 'float',
        'ps_co_nt' => 'float',
        'ps_no' => 'float',
        'ps_no_nt' => 'float',
    ];
}
