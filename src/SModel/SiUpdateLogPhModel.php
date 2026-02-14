<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiUpdateLogPhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiUpdateLogPh';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ID';

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
        'ID',
        'Description',
        'Note',
        'ProductId',
        'FunctionMenuid',
        'FunctionName',
        'BugNumber',
        'BugLevel',
        'LinkNumber',
        'Connection',
        'cDate',
        'lDate',
        'cUser',
        'lUser',
        'cUserBuild',
        'lUserBuild'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ID' => 'integer',
        'cDate' => 'datetime',
        'lDate' => 'datetime',
    ];
}
