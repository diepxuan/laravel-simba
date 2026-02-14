<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51DmQdAdHdModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51DmQdAdHd';

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
        'ma_qd',
        'ngay_qd',
        'ngay_ad',
        'ngay_hl',
        'ten_cty',
        'giam_doc',
        'dangky_kd',
        'ma_bp',
        'cq_thue',
        'ht_tb',
        'ncc',
        'hdmd',
        'tnbp',
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
        'ngay_qd' => 'datetime',
        'ngay_ad' => 'datetime',
        'ngay_hl' => 'datetime',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
