<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrChamCongKhacModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrChamCongKhac';

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
        'Nam',
        'Thang',
        'Ngay',
        'Id',
        'Ma_cham_cong',
        'Kh_cham_cong',
        'Gio_vao',
        'Phut_vao',
        'Gio_ra',
        'Phut_ra',
        'Them_gio',
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
        'Nam' => 'integer',
        'Thang' => 'integer',
        'Ngay' => 'integer',
        'Gio_vao' => 'integer',
        'Phut_vao' => 'integer',
        'Gio_ra' => 'integer',
        'Phut_ra' => 'integer',
        'Them_gio' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
