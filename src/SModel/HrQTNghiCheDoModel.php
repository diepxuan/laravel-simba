<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTNghiCheDoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTNghiCheDo';

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
        'Id_qtncd',
        'So_qd',
        'Ngay_qd',
        'Nguoi_ky_qd',
        'Loai_ncd',
        'Ma_ncd',
        'Dieu_kien_lv',
        'Ma_benh',
        'Tuoi_con',
        'Ngay_bd',
        'Ngay_kt',
        'Tinh_ngay_kl',
        'So_ngay_nghi',
        'Ma_huong_dt',
        'Ma_noi_dt',
        'Cty_tt',
        'Nv_tt',
        'Bhxh_tt',
        'Nd_tai_gia',
        'Nd_tap_trung',
        'Nd_tu_ngay',
        'Nd_den_ngay',
        'Nd_dia_chi',
        'Nd_bhxh_tt',
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
        'Ngay_qd' => 'datetime',
        'Tuoi_con' => 'integer',
        'Ngay_bd' => 'datetime',
        'Ngay_kt' => 'datetime',
        'Tinh_ngay_kl' => 'boolean',
        'So_ngay_nghi' => 'float',
        'Cty_tt' => 'float',
        'Nv_tt' => 'float',
        'Bhxh_tt' => 'float',
        'Nd_tai_gia' => 'float',
        'Nd_tap_trung' => 'float',
        'Nd_tu_ngay' => 'datetime',
        'Nd_den_ngay' => 'datetime',
        'Nd_bhxh_tt' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
