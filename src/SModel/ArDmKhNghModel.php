<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArDmKhNghModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'stt',
        'ma_cty',
        'ma_kh',
        'ma_ngh',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArDmKhNgh';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = null;

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
        'stt',
        'ma_kh',
        'ma_ngh',
        'ten_ngh',
        'phong_gd',
        'so_tk',
        'tinh_tp',
        'dia_chi',
        'dien_thoai',
        'email',
        'fax',
        'ghi_chu',
        'ngam_dinh'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngam_dinh' => 'boolean',
    ];
}
