<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zCDT_ct00Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zCDT_ct00';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'stt_rec',
        'stt_rec0',
        'ma_ct',
        'ngay_ct',
        'so_ct',
        'so_lo',
        'ngay_lo',
        'ong_ba',
        'dien_giai',
        'nh_dk',
        'tk',
        'tk_du',
        'ps_no_nt',
        'ps_co_nt',
        'ma_nt',
        'ty_gia',
        'ps_no',
        'ps_co',
        'ma_bp',
        'ma_kh',
        'ma_vv',
        'ma_phi',
        'ma_spct',
        'status',
        'ngay_ct0',
        'so_ct0',
        'ma_ku',
        'ma_lo',
        'ma_hp'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_ct' => 'datetime',
        'ps_no_nt' => 'float',
        'ps_co_nt' => 'float',
        'ty_gia' => 'float',
        'ps_no' => 'float',
        'ps_co' => 'float',
    ];
}
