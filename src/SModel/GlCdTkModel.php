<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlCdTkModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlCdTk';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_cty';

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
        'tk',
        'nam',
        'ma_nt',
        'du_no_nt00',
        'du_co_nt00',
        'du_no00',
        'du_co00',
        'du_no_nt',
        'du_co_nt',
        'du_no',
        'du_co',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'du_no_nt00' => 'float',
        'du_co_nt00' => 'float',
        'du_no00' => 'float',
        'du_co00' => 'float',
        'du_no_nt' => 'float',
        'du_co_nt' => 'float',
        'du_no' => 'float',
        'du_co' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
