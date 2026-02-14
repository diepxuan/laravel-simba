<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoDmCkModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoDmCk';

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
        'Ma_kyck',
        'ma_vt',
        'ma_nhvt',
        'ma_kh',
        'ma_nhkh',
        'sl_ds',
        'tl_sl_ds',
        'tl_gt',
        'vt_nhomvt',
        'kh_nhomkh',
        'gt0',
        'gt1',
        'ck1',
        'gt2',
        'ck2',
        'gt3',
        'ck3',
        'gt4',
        'ck4',
        'gt5',
        'ck5',
        'gt6',
        'ck6',
        'gt7',
        'ck7',
        'gt8',
        'ck8',
        'gt9',
        'ck9',
        'gt10',
        'ck10',
        'gt11',
        'ck11',
        'gt12',
        'ck12',
        'gt13',
        'ck13',
        'gt14',
        'ck14',
        'gt15',
        'ck15',
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
        'gt0' => 'float',
        'gt1' => 'float',
        'ck1' => 'float',
        'gt2' => 'float',
        'ck2' => 'float',
        'gt3' => 'float',
        'ck3' => 'float',
        'gt4' => 'float',
        'ck4' => 'float',
        'gt5' => 'float',
        'ck5' => 'float',
        'gt6' => 'float',
        'ck6' => 'float',
        'gt7' => 'float',
        'ck7' => 'float',
        'gt8' => 'float',
        'ck8' => 'float',
        'gt9' => 'float',
        'ck9' => 'float',
        'gt10' => 'float',
        'ck10' => 'float',
        'gt11' => 'float',
        'ck11' => 'float',
        'gt12' => 'float',
        'ck12' => 'float',
        'gt13' => 'float',
        'ck13' => 'float',
        'gt14' => 'float',
        'ck14' => 'float',
        'gt15' => 'float',
        'ck15' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
