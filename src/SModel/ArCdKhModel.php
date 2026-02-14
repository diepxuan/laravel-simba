<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArCdKhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArCdKh';

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
        'nam',
        'tk',
        'ma_nt',
        'ma_kh',
        'ma_bp',
        'ma_spct',
        'ma_hd',
        'du_no',
        'du_co',
        'du_no_nt',
        'du_co_nt',
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
        'du_no' => 'float',
        'du_co' => 'float',
        'du_no_nt' => 'float',
        'du_co_nt' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
