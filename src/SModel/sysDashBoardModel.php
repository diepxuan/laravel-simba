<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysDashBoardModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysDashBoard';

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
        'dashid',
        'username',
        'title',
        'functionId',
        'format',
        'type',
        'location',
        'x',
        'y',
        'h',
        'w'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'dashid' => 'integer',
        'location' => 'integer',
        'x' => 'integer',
        'y' => 'integer',
        'h' => 'integer',
        'w' => 'integer',
    ];
}
