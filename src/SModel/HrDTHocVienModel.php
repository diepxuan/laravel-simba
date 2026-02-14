<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDTHocVienModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDTHocVien';

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
        'Ma_ldt',
        'Id',
        'Ma_nvns',
        'Ho_ten',
        'Ho_dem',
        'Ten',
        'Ngay_sinh',
        'Gioi_tinh',
        'So_cmnd',
        'Ma_cvcm',
        'IsCbl',
        'Chuc_vu_cbl',
        'Sb_nghi_hoc',
        'Sb_di_muon',
        'Sb_ve_som',
        'Ket_qua',
        'Xep_loai',
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
        'Ngay_sinh' => 'datetime',
        'IsCbl' => 'boolean',
        'Sb_nghi_hoc' => 'float',
        'Sb_di_muon' => 'float',
        'Sb_ve_som' => 'float',
        'Ket_qua' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
