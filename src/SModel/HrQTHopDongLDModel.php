<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTHopDongLDModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTHopDongLD';

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
        'Id_qthdld',
        'Ma_loai_hd',
        'So_hd',
        'Ngay_bd',
        'Ngay_kt',
        'Ma_bp',
        'Ma_dia_diem_lv',
        'Ma_cvcm',
        'Chuc_vu',
        'Mo_ta_cv',
        'Thoi_gian_lv',
        'Phuong_tien',
        'Ht_tra_luong',
        'Ngay_tra_luong',
        'Tien_luong',
        'Tong_phu_cap',
        'Ten_phu_cap',
        'Tien_thuong',
        'Cd_nang_luong',
        'Cd_bao_ho_ld',
        'Cd_nghi_ngoi',
        'Cd_bhxh',
        'Cd_dao_tao',
        'Thoa_thuan',
        'Cd_boi_thuong',
        'Nguoi_ky',
        'Cvu_nguoi_ky',
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
        'Tien_luong' => 'float',
        'Tong_phu_cap' => 'float',
        'Tien_thuong' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
