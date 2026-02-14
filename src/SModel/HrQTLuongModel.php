<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTLuongModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTLuong';

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
        'Id_qtluong',
        'Ngay_ad',
        'Luong_nb',
        'Ma_tbl',
        'Ma_nb',
        'He_so_luong',
        'Tong_phu_cap',
        'Muc_luong',
        'Muc_luong_BHXH',
        'So_qd',
        'Ngay_qd',
        'Nguoi_ky_qd',
        'Ghi_chu',
        'Tai_lieu',
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
        'Luong_nb' => 'boolean',
        'He_so_luong' => 'float',
        'Tong_phu_cap' => 'float',
        'Muc_luong' => 'float',
        'Muc_luong_BHXH' => 'float',
        'Ngay_qd' => 'datetime',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
