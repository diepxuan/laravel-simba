<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaSetup';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_cty';

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
        'Ma_cty',
        'G_ML_TT',
        'G_ML_BHXH',
        'G_TL_BHXH_NV',
        'G_TL_BHYT_NV',
        'G_TL_BHTN_NV',
        'G_TL_BHXH_CTY',
        'G_TL_BHYT_CTY',
        'G_TL_BHTN_CTY',
        'G_TL_BHXH',
        'G_TL_BHYT',
        'G_TL_BHTN',
        'G_DG_CD',
        'G_DG_BP',
        'G_DT_KD',
        'G_SP_VT',
        'G_NC_CB',
        'G_TL_DPCD',
        'G_TL_DP',
        'G_DG_AC',
        'G_GT_BT',
        'G_GT_NPT'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'G_ML_BHXH' => 'float',
        'G_TL_BHXH_NV' => 'float',
        'G_TL_BHYT_NV' => 'float',
        'G_TL_BHTN_NV' => 'float',
        'G_TL_BHXH_CTY' => 'float',
        'G_TL_BHYT_CTY' => 'float',
        'G_TL_BHTN_CTY' => 'float',
        'G_TL_BHXH' => 'float',
        'G_TL_BHYT' => 'float',
        'G_TL_BHTN' => 'float',
        'G_TL_DPCD' => 'float',
        'G_TL_DP' => 'float',
    ];
}
