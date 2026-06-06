<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SModel;

class SysReportInfo extends SModel
{
    public $incrementing = false;
    public $timestamps = false;
    protected $table = 'sysReportInfo';
    protected $primaryKey = 'menuid';
    protected $keyType = 'string';

    protected $fillable = ['menuid','ma_mau','ctlclass','spname','rptname','isdefault','bang_chu','bang_chu0','hasNT','dynReportFields','par0','par1','par2','par3','par4','par5','par6','par7','par8','par9','description_colname'];

    protected $casts = [
        'isdefault' => 'boolean',
        'bang_chu' => 'boolean',
        'bang_chu0' => 'boolean',
        'hasNT' => 'boolean',
    ];
}
