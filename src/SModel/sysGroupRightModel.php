<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysGroupRightModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysGroupRight';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'groupname';

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
        'groupname',
        'menuid',
        'viewright',
        'deleteright',
        'updateright',
        'insertright',
        'limitedprint',
        'cuser',
        'luser',
        'cdate',
        'ldate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'viewright' => 'boolean',
        'deleteright' => 'boolean',
        'updateright' => 'boolean',
        'insertright' => 'boolean',
        'limitedprint' => 'integer',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
