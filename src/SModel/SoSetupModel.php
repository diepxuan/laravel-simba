<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoSetup';

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
        'tk_pt',
        'tk_thue_gtgt',
        'tk_thue_gtgt_tl',
        'tk_thue_xk',
        'tk_thue_gtgt_xk',
        'tk_thue_ttdb',
        'tk_ck',
        'ds_tk_kt',
        'post2inct',
        'han_tt_ss1',
        'han_tt_ss2',
        'han_tt_ss3',
        'ke_gtgt_ban_chi_tiet_theo_vt',
        'dmkh_filter',
        'lay_gia_ban',
        'ds_httt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'han_tt_ss1' => 'integer',
        'han_tt_ss2' => 'integer',
        'han_tt_ss3' => 'integer',
    ];
}
