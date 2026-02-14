<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrTDUngVienModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrTDUngVien';

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
        'Vong_so',
        'Id',
        'Ma_uv',
        'Ho_ten',
        'Ho_dem',
        'Ten',
        'Ngay_sinh',
        'Gioi_tinh',
        'So_cmnd',
        'Ma_dia_dem_lv',
        'Ten_dia_diem_lv',
        'Ma_bp',
        'Ma_cvcm',
        'Thoi_gian_lv',
        'Ma_htlv',
        'Luong_de_nghi',
        'Luong_chap_nhan',
        'Ngay_ctdl',
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
        'Ngay_sinh' => 'datetime',
        'Luong_de_nghi' => 'float',
        'Luong_chap_nhan' => 'float',
        'Ngay_ctdl' => 'datetime',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
