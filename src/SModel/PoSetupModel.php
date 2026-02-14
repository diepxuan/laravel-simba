<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoSetup';

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
        'ds_tk_kt',
        'tk_pt',
        'tk_thue_gtgt',
        'tk_thue_nk',
        'tk_gtgt_nk_no',
        'tk_gtgt_nk_co',
        'tk_thue_ttdb',
        'tk_ck',
        'ke_gtgt_mua_chi_tiet_theo_vt',
        'luu_gia_nhap',
        'lay_gia_nhap',
        'chiet_khau_mua_hang'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
