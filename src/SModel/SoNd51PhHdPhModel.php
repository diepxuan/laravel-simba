<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51PhHdPhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51PhHdPh';

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
        'ma_tb',
        'ngay_tb',
        'donvi_ph',
        'ma_thue',
        'dia_chi',
        'tel',
        'donvi_cq',
        'ma_thuedvcq',
        'cq_thue',
        'dai_dien',
        'ngay_duyet',
        'chap_nhan',
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
        'ngay_tb' => 'datetime',
        'ngay_duyet' => 'datetime',
        'chap_nhan' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
