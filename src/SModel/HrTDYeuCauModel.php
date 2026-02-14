<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrTDYeuCauModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrTDYeuCau';

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
        'Ma_yctd',
        'Ten_yctd',
        'Nguoi_yc',
        'Ngay_bd',
        'Ngay_kt',
        'Ht_nop_hs',
        'Ma_dia_diem_lv',
        'Ten_dia_diem_lv',
        'Ma_bp',
        'Ma_cvcm',
        'Mo_ta',
        'So_luong_tuyen',
        'Thoi_gian_lv',
        'Ma_htlv',
        'Gioi_tinh',
        'Tuoi_tu',
        'Tuoi_den',
        'Muc_chuyen_mon',
        'Ma_chuyen_mon',
        'Ten_chuyen_mon',
        'Bx_chuyen_mon',
        'Muc_ky_nang',
        'Ma_ky_nang',
        'Ten_ky_nang',
        'Bx_ky_nang',
        'Muc_trinh_do',
        'Ma_trinh_do',
        'Ten_trinh_do',
        'Bx_trinh_do',
        'Muc_luong',
        'Quyen_loi',
        'Ds_ho_so',
        'Ghi_chu',
        'Trang_thai',
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
        'So_luong_tuyen' => 'float',
        'Tuoi_tu' => 'float',
        'Tuoi_den' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
