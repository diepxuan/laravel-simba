<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQuanHeNVModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQuanHeNV';

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
        'Id_qtqh',
        'Ho_ten',
        'Ho_dem',
        'Ten',
        'Ngay_sinh',
        'Gioi_tinh',
        'Quan_he',
        'Noi_o',
        'Noi_o_dc',
        'Noi_o_xa',
        'Noi_o_huyen',
        'Noi_o_tinh',
        'Ma_ton_giao',
        'Ma_dan_toc',
        'Ma_quoc_tich',
        'Ma_to_chuc',
        'Ma_cvcm',
        'Phone_mobile',
        'Phone_home',
        'Phone_work',
        'Phone_work_ext',
        'Email_home',
        'Anh_dai_dien',
        'Tai_lieu',
        'Phu_thuoc',
        'Khan_cap',
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
        'Ngay_sinh' => 'datetime',
        'Phu_thuoc' => 'boolean',
        'Khan_cap' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
