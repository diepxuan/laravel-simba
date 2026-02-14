<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class z_gldmtk_dchpModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'z_gldmtk_dchp';

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
        'tk',
        'ten_tk',
        'ma_nt',
        'chi_tiet',
        'tk_me',
        'bac_tk',
        'tk_sc',
        'tk_cn',
        'pp_tinh_tggs_no',
        'pp_tinh_tggs_co',
        'kieu_sd',
        'so_tk',
        'ma_ngh',
        'ten_ngh',
        'tinh_tp',
        'ksd',
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
        'chi_tiet' => 'boolean',
        'bac_tk' => 'integer',
        'tk_sc' => 'boolean',
        'tk_cn' => 'boolean',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
