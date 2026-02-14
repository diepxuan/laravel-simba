<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoLkModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoLk';

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
        'thang',
        'nam',
        'ma_spct',
        'tk',
        'tk_du',
        'ps_no',
        'ps_no_nt',
        'ps_co',
        'ps_co_nt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'thang' => 'integer',
        'nam' => 'integer',
        'ps_no' => 'float',
        'ps_no_nt' => 'float',
        'ps_co' => 'float',
        'ps_co_nt' => 'float',
    ];
}
