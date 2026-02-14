<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaDonGiaSpModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaDonGiaSp';

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
        'Thang',
        'Nam',
        'Ma_sanpham',
        'Don_gia',
        'cdate',
        'ldate',
        'cuser',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Thang' => 'integer',
        'Nam' => 'integer',
        'Don_gia' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
