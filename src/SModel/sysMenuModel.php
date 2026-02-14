<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysMenuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysMenu';

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
        'stt',
        'type',
        'moduleid',
        'bar',
        'short_name',
        'dllName',
        'command',
        'code_name',
        'report',
        'basicright',
        'form',
        'form_show_type',
        'opt',
        'par1',
        'par2',
        'par3',
        'par4',
        'par5',
        'par6',
        'par7',
        'par8',
        'picture1',
        'picture2',
        'rowid',
        'developer',
        'maintainer',
        'used',
        'active',
        'zmenuid'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'report' => 'boolean',
        'basicright' => 'boolean',
        'form' => 'boolean',
        'rowid' => 'integer',
        'used' => 'boolean',
    ];
}
