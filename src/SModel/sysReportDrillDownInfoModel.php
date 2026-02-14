<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysReportDrillDownInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysReportDrillDownInfo';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'menuid';

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
        'menuid',
        'ma_mau',
        'press_key_name',
        'drilldown_menuid',
        'drilldown_menuid1',
        'drilldown_menuid2',
        'drilldown_menuid3',
        'drilldown_menuid4',
        'dllName',
        'command',
        'description',
        'par0',
        'par1',
        'par2',
        'par3',
        'par4',
        'par5',
        'par6',
        'par7',
        'par8',
        'par9'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
