<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiUpdateLogBkModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiUpdateLogBk';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Changeset';

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
        'Changeset',
        'ID',
        'lDate',
        'lUser',
        'BugNumber',
        'LinkNumber',
        'ProductId',
        'FunctionMenuid',
        'FunctionName',
        'Description',
        'Note',
        'Name',
        'Type',
        'Last_Modify',
        'FullPath'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Changeset' => 'integer',
        'ID' => 'integer',
        'lDate' => 'datetime',
    ];
}
