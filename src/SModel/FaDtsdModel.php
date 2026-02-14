<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class FaDtsdModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'FaDtsd';

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
        'ma_ts',
        'ngay',
        'loai_dt',
        'is_dmts',
        'ma_bpsd',
        'ma_spct',
        'ma_phi',
        'tk_ts',
        'tk_kh',
        'tk_cp',
        'ma_dt',
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
        'ngay' => 'datetime',
        'is_dmts' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
