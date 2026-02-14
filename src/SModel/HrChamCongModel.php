<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrChamCongModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrChamCong';

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
        'Id',
        'Ma_cham_cong',
        'Ma_cvcm',
        'He_so_luong',
        'Tong_phu_cap',
        'Muc_luong',
        'Tong_luong',
        'Ngay01',
        'Ngay02',
        'Ngay03',
        'Ngay04',
        'Ngay05',
        'Ngay06',
        'Ngay07',
        'Ngay08',
        'Ngay09',
        'Ngay10',
        'Ngay11',
        'Ngay12',
        'Ngay13',
        'Ngay14',
        'Ngay15',
        'Ngay16',
        'Ngay17',
        'Ngay18',
        'Ngay19',
        'Ngay20',
        'Ngay21',
        'Ngay22',
        'Ngay23',
        'Ngay24',
        'Ngay25',
        'Ngay26',
        'Ngay27',
        'Ngay28',
        'Ngay29',
        'Ngay30',
        'Ngay31',
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
        'He_so_luong' => 'float',
        'Tong_phu_cap' => 'float',
        'Muc_luong' => 'float',
        'Tong_luong' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
