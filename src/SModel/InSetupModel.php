<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InSetup';

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
        'tk_vt',
        'tk_dt',
        'tk_dtnb',
        'tk_gv',
        'tk_tl',
        'tk_ck',
        'tk_gb',
        'kieu_tinh_gia_tb',
        'tab_space',
        'canh_bao_xuat_am',
        'FIFO_method',
        'Gia_tb_nt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'tab_space' => 'integer',
        'Gia_tb_nt' => 'integer',
    ];
}
