<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiUpdateLogCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiUpdateLogCt';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Item_ID';

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
        'Item_ID',
        'ID',
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
        'ID' => 'integer',
        'Type' => 'integer',
        'Last_Modify' => 'datetime',
    ];
}
