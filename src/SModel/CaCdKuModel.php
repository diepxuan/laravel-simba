<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaCdKuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaCdKu';

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
        'ma_ku',
        'tk',
        'ma_nt',
        'ngay_ku',
        'ngay_tt',
        'da_vay',
        'da_vay_nt',
        'da_tt',
        'da_tt_nt',
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
        'ngay_ku' => 'datetime',
        'ngay_tt' => 'datetime',
        'da_vay' => 'float',
        'da_vay_nt' => 'float',
        'da_tt' => 'float',
        'da_tt_nt' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
