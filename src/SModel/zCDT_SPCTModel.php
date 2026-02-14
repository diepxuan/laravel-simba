<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zCDT_SPCTModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zCDT_SPCT';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'ma_spct',
        'ten_spct',
        'san_pham',
        'dvt',
        'ma_nhom',
        'ngay_bd',
        'ngay_kt',
        'F8',
        'F9',
        'F10',
        'F11'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'san_pham' => 'float',
        'F8' => 'datetime',
        'F11' => 'datetime',
    ];
}
