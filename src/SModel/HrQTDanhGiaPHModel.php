<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTDanhGiaPHModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTDanhGiaPH';

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
        'Id_qtdg',
        'Ngay_dg',
        'Ngay_bd',
        'Ngay_kt',
        'Ma_nvdg',
        'Ma_nhdg',
        'Trang_thai',
        'Ket_luan',
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
        'Ngay_dg' => 'datetime',
        'Ngay_bd' => 'datetime',
        'Ngay_kt' => 'datetime',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
