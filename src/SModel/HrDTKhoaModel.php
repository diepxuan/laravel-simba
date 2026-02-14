<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDTKhoaModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDTKhoa';

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
        'Ma_kdt',
        'Ten_kdt',
        'Ngay_dk',
        'Ngay_bd',
        'Ngay_kt',
        'Nganh_dt',
        'Cap_dt',
        'Noi_dung',
        'Chung_chi',
        'Ma_doi_tuong',
        'Ten_doi_tuong',
        'Dia_diem_dt',
        'So_buoi',
        'Thoi_luong',
        'Tien_dt',
        'Tl_dt_cty',
        'Tien_dt_cty',
        'Tl_dt_nv',
        'Tien_dt_nv',
        'Ket_qua',
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
        'Ngay_dk' => 'datetime',
        'Ngay_bd' => 'datetime',
        'Ngay_kt' => 'datetime',
        'So_buoi' => 'integer',
        'Thoi_luong' => 'float',
        'Tien_dt' => 'float',
        'Tl_dt_cty' => 'float',
        'Tien_dt_cty' => 'float',
        'Tl_dt_nv' => 'float',
        'Tien_dt_nv' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
