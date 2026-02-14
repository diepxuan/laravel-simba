<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTTheCheModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTTheChe';

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
        'Id_qttc',
        'Ma_the_che',
        'Ngay_vao',
        'Ngay_chinh_thuc',
        'Ngay_ra',
        'Noi_ket_nap',
        'Chuc_vu',
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
        'Ngay_vao' => 'datetime',
        'Ngay_chinh_thuc' => 'datetime',
        'Ngay_ra' => 'datetime',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
