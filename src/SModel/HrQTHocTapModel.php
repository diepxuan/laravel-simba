<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTHocTapModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTHocTap';

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
        'Id_qtht',
        'Ma_tddt',
        'Ma_htdt',
        'Ma_bang_cap',
        'Ma_nganh',
        'Gpa',
        'Tong_ket',
        'Xep_loai',
        'Ngay_bd',
        'Ngay_kt',
        'Trang_thai',
        'Ma_tcdt',
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
        'Gpa' => 'float',
        'Tong_ket' => 'float',
        'Ngay_bd' => 'datetime',
        'Ngay_kt' => 'datetime',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
