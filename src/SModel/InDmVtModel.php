<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InDmVtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InDmVt';

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
        'ma_vt',
        'loai',
        'ten_vt',
        'part_no',
        'dvt',
        'dvt_ban',
        'hs_dvtban',
        'dvt_mua',
        'hs_dvtmua',
        'ton_kho',
        'gia_ton',
        'tk_vt',
        'tk_dt',
        'tk_dtnb',
        'tk_gv',
        'tk_tl',
        'tk_ck',
        'tk_km',
        'tk_dd',
        'tk_cpnvl',
        'ma_thue',
        'tinh_gt',
        'ma_nhvt',
        'ma_plvt1',
        'ma_plvt2',
        'ma_plvt3',
        'ma_nhvat',
        'sl_min',
        'sl_max',
        'ts_nk',
        'ts_gtgt',
        'ts_xk',
        'ts_ttdb',
        'ma_kho',
        'ma_vitri',
        'co_ct',
        'ghi_chu',
        'gia_nt0',
        'gia_nt2',
        'Anh',
        'nha_sx',
        'nha_pp',
        'Nuoc_sx',
        'ksd',
        'cUser',
        'cDate',
        'lUser',
        'lDate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'hs_dvtban' => 'float',
        'hs_dvtmua' => 'float',
        'ton_kho' => 'boolean',
        'tinh_gt' => 'boolean',
        'sl_min' => 'float',
        'sl_max' => 'float',
        'ts_nk' => 'integer',
        'ts_gtgt' => 'integer',
        'ts_xk' => 'integer',
        'ts_ttdb' => 'integer',
        'co_ct' => 'boolean',
        'gia_nt0' => 'float',
        'gia_nt2' => 'float',
        'ksd' => 'boolean',
        'cDate' => 'datetime',
        'lDate' => 'datetime',
    ];
}
