<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrTDKetQuaModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrTDKetQua';

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
        'Ma_mon_thi',
        'De_so',
        'Id',
        'Ma_uv',
        'Ho_ten',
        'Ho_dem',
        'Ten',
        'Ngay_sinh',
        'Gioi_tinh',
        'So_cmnd',
        'Ngay_hen',
        'Gio_hen',
        'Phut_hen',
        'Ket_qua',
        'Xep_loai',
        'Nhan_xet',
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
        'Ngay_sinh' => 'datetime',
        'Ngay_hen' => 'datetime',
        'Gio_hen' => 'integer',
        'Phut_hen' => 'integer',
        'Ket_qua' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
