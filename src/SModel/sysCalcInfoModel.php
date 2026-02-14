<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysCalcInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysCalcInfo';

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
        'spname',
        'rettype',
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
        'rettype' => 'integer',
    ];
}
