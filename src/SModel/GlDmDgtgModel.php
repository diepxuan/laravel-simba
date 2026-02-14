<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlDmDgtgModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlDmDgtg';

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
        'loai_dg',
        'tk_dgtg',
        'stt',
        'tk_lai_cltg',
        'tk_lo_cltg',
        'tk_cltg_cn',
        'ten_bt',
        'dg_kh',
        'dg_bp',
        'dg_hd',
        'dg_spct',
        'dg_phi',
        'so_ct',
        'ksd',
        'cdate',
        'ldate',
        'cuser',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'dg_kh' => 'boolean',
        'dg_bp' => 'boolean',
        'dg_hd' => 'boolean',
        'dg_spct' => 'boolean',
        'dg_phi' => 'boolean',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
