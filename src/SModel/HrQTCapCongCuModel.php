<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTCapCongCuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTCapCongCu';

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
        'Id',
        'Id_qtccc',
        'Ma_nhcc',
        'Ma_cc',
        'Ten_cc',
        'Ngay_cap',
        'Ngay_tra',
        'So_luong',
        'Gia_tri',
        'Tong_gia_tri',
        'Ghi_chu',
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
        'Ngay_cap' => 'datetime',
        'Ngay_tra' => 'datetime',
        'So_luong' => 'float',
        'Gia_tri' => 'float',
        'Tong_gia_tri' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
