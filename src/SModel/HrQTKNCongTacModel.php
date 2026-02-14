<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTKNCongTacModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTKNCongTac';

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
        'Id_qtknct',
        'Ma_to_chuc',
        'Ten_to_chuc',
        'Ma_cvcm',
        'Ngay_bd',
        'Ngay_kt',
        'Mo_ta_cv',
        'Thu_nhap_bd',
        'Thu_nhap_kt',
        'Ten_nql',
        'Chuc_danh_nql',
        'Thanh_tich',
        'So_nv_ql',
        'Ma_thoi_viec',
        'Ghi_chu',
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
        'Thu_nhap_bd' => 'float',
        'Thu_nhap_kt' => 'float',
        'So_nv_ql' => 'integer',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
