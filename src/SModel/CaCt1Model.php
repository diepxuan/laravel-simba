<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaCt1Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaCt1';

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
        'ps_no',
        'ps_co',
        'ps_no_nt',
        'ps_co_nt',
        'ty_gia_gs',
        'dien_giai',
        'ma_kh',
        'ma_hd',
        'ma_bp',
        'ma_phi',
        'ma_ku',
        'ma_lo',
        'ma_spct'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ps_no' => 'float',
        'ps_co' => 'float',
        'ps_no_nt' => 'float',
        'ps_co_nt' => 'float',
        'ty_gia_gs' => 'float',
    ];
}
