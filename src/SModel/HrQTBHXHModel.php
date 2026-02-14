<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTBHXHModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTBHXH';

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
        'Id_qtbhxh',
        'Ngay_bd',
        'Ngay_kt',
        'So_thang',
        'So_nam',
        'Tong_so_thang',
        'Ma_cvcm',
        'He_so_luong',
        'Tong_phu_cap',
        'Luong_toi_thieu',
        'Luong_co_ban',
        'Tong_luong',
        'Tl_BHXH_cty',
        'Tien_BHXH_cty',
        'Tl_BHYT_cty',
        'Tien_BHYT_cty',
        'Tl_BHTN_cty',
        'Tien_BHTN_cty',
        'Tl_BHXH_nv',
        'Tien_BHXH_nv',
        'Tl_BHYT_nv',
        'Tien_BHYT_nv',
        'Tl_BHTN_nv',
        'Tien_BHTN_nv',
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
        'Ngay_bd' => 'datetime',
        'Ngay_kt' => 'datetime',
        'So_thang' => 'integer',
        'So_nam' => 'integer',
        'Tong_so_thang' => 'integer',
        'He_so_luong' => 'float',
        'Tong_phu_cap' => 'float',
        'Luong_toi_thieu' => 'float',
        'Luong_co_ban' => 'float',
        'Tong_luong' => 'float',
        'Tl_BHXH_cty' => 'float',
        'Tien_BHXH_cty' => 'float',
        'Tl_BHYT_cty' => 'float',
        'Tien_BHYT_cty' => 'float',
        'Tl_BHTN_cty' => 'float',
        'Tien_BHTN_cty' => 'float',
        'Tl_BHXH_nv' => 'float',
        'Tien_BHXH_nv' => 'float',
        'Tl_BHYT_nv' => 'float',
        'Tien_BHYT_nv' => 'float',
        'Tl_BHTN_nv' => 'float',
        'Tien_BHTN_nv' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
