<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmLuongToiThieuModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Ngay_ad',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmLuongToiThieu';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ngay_ad';

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
        'Ma_cty',
        'Ngay_ad',
        'Muc_luong',
        'Ksd',
        'Cdate',
        'Ldate',
        'Cuser',
        'Luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Ngay_ad' => 'datetime',
        'Muc_luong' => 'float',
        'Ksd' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
