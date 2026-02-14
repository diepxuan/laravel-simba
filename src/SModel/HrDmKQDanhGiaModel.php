<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmKQDanhGiaModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmKQDanhGia';

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
        'Ma_kqdg',
        'Ten_kqdg',
        'Diem_tu',
        'Diem_den',
        'Ket_luan',
        'Ghi_chu',
        'Ksd',
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
        'Diem_tu' => 'float',
        'Diem_den' => 'float',
        'Ksd' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
