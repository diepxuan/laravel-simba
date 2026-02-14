<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoDmBomPhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoDmBomPh';

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
        'ma_spct',
        'ngay1',
        'ngay2',
        'don_gia_luong',
        'ghi_chu',
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
        'ngay1' => 'datetime',
        'ngay2' => 'datetime',
        'don_gia_luong' => 'float',
    ];
}
