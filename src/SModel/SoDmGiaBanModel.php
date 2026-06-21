<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoDmGiaBanModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ma_vt',
        'ngay_ad',
        'ma_nt',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoDmGiaBan';

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
        'ma_vt',
        'ngay_ad',
        'ma_nt',
        'gia_nt2',
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
        'ngay_ad' => 'datetime',
        'gia_nt2' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
