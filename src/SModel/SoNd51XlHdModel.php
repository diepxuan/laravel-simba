<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51XlHdModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51XlHd';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_cty';

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
        'ma_cty',
        'kieu_xl',
        'ma_tb',
        'ngay_tb',
        'noi_nhan',
        'ten_tc',
        'dai_dien',
        'dia_chi',
        'ma_thue',
        'ghi_chu',
        'gio_xl',
        'phut_xl',
        'ngay_xl',
        'gui_cqt',
        'ngay_guicqt',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_tb' => 'datetime',
        'ngay_xl' => 'datetime',
        'gui_cqt' => 'boolean',
        'ngay_guicqt' => 'datetime',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
