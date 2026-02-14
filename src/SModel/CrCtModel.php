<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CrCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CrCt';

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
        'ma_cty',
        'stt_rec',
        'stt_rec0',
        'nam',
        'thang',
        'ngay_ct',
        'ma_dv',
        'ma_bang',
        'ma_so',
        'tk',
        'tk_du',
        'ma_kh',
        'dien_giai',
        'ps_no',
        'ps_co',
        'nh_dk'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'thang' => 'integer',
        'ngay_ct' => 'datetime',
        'ps_no' => 'float',
        'ps_co' => 'float',
    ];
}
