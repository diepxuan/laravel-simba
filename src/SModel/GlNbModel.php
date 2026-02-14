<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlNbModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlNb';

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
        'ma_ct',
        'stt_rec',
        'so_ct',
        'ngay_ct',
        'ma_nt',
        'ty_gia',
        'tk',
        'dien_giai',
        'ps_co',
        'ps_co_nt',
        'ps_no',
        'ps_no_nt',
        'luser',
        'ldate',
        'cuser',
        'cdate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_ct' => 'datetime',
        'ty_gia' => 'float',
        'ps_co' => 'float',
        'ps_co_nt' => 'float',
        'ps_no' => 'float',
        'ps_no_nt' => 'float',
        'ldate' => 'datetime',
        'cdate' => 'datetime',
    ];
}
