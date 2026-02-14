<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaDmNguoiPhuThuocModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaDmNguoiPhuThuoc';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_cty';

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
        'Thang',
        'Nam',
        'Ma_nv',
        'So_npt',
        'Ghi_chu',
        'Cuser',
        'Cdate',
        'Luser',
        'Ldate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Thang' => 'integer',
        'Nam' => 'integer',
        'So_npt' => 'integer',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
