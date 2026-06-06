<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SModel;

class SysReportDrillDownInfo extends SModel
{
    public $incrementing = false;
    public $timestamps = false;
    protected $table = 'sysReportDrillDownInfo';
    protected $primaryKey = 'menuid';
    protected $keyType = 'string';

    protected $fillable = ['menuid','ma_mau','press_key_name','drilldown_menuid','drilldown_menuid1','drilldown_menuid2','drilldown_menuid3','drilldown_menuid4','dllName','command','description','par0','par1','par2','par3','par4','par5','par6','par7','par8','par9'];
}
