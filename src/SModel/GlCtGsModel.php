<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlCtGsModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlCtGs';

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
        'ma_cty',
        'ma_ct',
        'so_hieu',
        'ngay_lo',
        'so_lo',
        'dien_giai',
        'tk',
        'no_co',
        'tien',
        'tien_nt',
        'ngay_ct1',
        'ngay_ct2'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_lo' => 'datetime',
        'tien' => 'float',
        'tien_nt' => 'float',
        'ngay_ct1' => 'datetime',
        'ngay_ct2' => 'datetime',
    ];
}
