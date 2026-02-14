<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysUserInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysUserInfo';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'username';

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
        'username',
        'fullname',
        'password',
        'isadmin',
        'disabled',
        'grand',
        'accesscompanies',
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
        'isadmin' => 'boolean',
        'disabled' => 'boolean',
        'grand' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
