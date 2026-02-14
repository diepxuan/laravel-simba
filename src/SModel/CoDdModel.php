<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoDdModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoDd';

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
        'nam',
        'thang',
        'tk',
        'ma_spct',
        'sl_kk_ck',
        'ty_le_ht',
        'sl_dd_ck',
        'gt_dd_ck'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'thang' => 'integer',
        'sl_kk_ck' => 'float',
        'ty_le_ht' => 'float',
        'sl_dd_ck' => 'float',
        'gt_dd_ck' => 'float',
    ];
}
