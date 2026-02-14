<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaLaiKuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaLaiKu';

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
        'ngay_tra',
        'ma_ku',
        'thang',
        'nam',
        'tien_lai_tk',
        'tien_lai_tk_nt',
        'tien_goc_tk',
        'tien_goc_tk_nt',
        'tien_lai_qh',
        'tien_lai_qh_nt',
        'tien_goc_qh',
        'tien_goc_qh_nt',
        'sua_lai',
        'sua_goc',
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
        'ngay_tra' => 'datetime',
        'thang' => 'integer',
        'nam' => 'integer',
        'tien_lai_tk' => 'float',
        'tien_lai_tk_nt' => 'float',
        'tien_goc_tk' => 'float',
        'tien_goc_tk_nt' => 'float',
        'tien_lai_qh' => 'float',
        'tien_lai_qh_nt' => 'float',
        'tien_goc_qh' => 'float',
        'tien_goc_qh_nt' => 'float',
        'sua_lai' => 'boolean',
        'sua_goc' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
