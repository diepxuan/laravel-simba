<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoDmPb1Model extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'id',
        'tk_nhan_pb',
        'moduleid',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoDmPb1';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = null;

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
        'ma_cty',
        'id',
        'tk_nhan_pb',
        'moduleid'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'id' => 'integer',
    ];
}
