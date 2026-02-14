<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlDmKcModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlDmKc';

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
        'moduleid',
        'tk',
        'tk_du',
        'id',
        'stt',
        'tag',
        'ten_bt',
        'kc_bp',
        'kc_hd',
        'kc_spct',
        'kc_phi',
        'kc_lo',
        'loai_kc',
        'kc_dt_ps',
        'so_ct',
        'stt_seq',
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
        'id' => 'integer',
        'kc_bp' => 'boolean',
        'kc_hd' => 'boolean',
        'kc_spct' => 'boolean',
        'kc_phi' => 'boolean',
        'kc_lo' => 'boolean',
        'kc_dt_ps' => 'boolean',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
