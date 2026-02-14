<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlBudgetModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlBudget';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'stt_rec';

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
        'stt_rec',
        'nam',
        'tk',
        'ttps_no_co',
        'ma_bp',
        'ma_phi',
        'ma_spct',
        't1',
        't2',
        't3',
        't4',
        't5',
        't6',
        't7',
        't8',
        't9',
        't10',
        't11',
        't12',
        'cdate',
        'ldate',
        'cuser',
        'luser',
        'tk_du'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        't1' => 'float',
        't2' => 'float',
        't3' => 'float',
        't4' => 'float',
        't5' => 'float',
        't6' => 'float',
        't7' => 'float',
        't8' => 'float',
        't9' => 'float',
        't10' => 'float',
        't11' => 'float',
        't12' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
