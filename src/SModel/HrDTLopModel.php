<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDTLopModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDTLop';

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
        'Ten_ldt',
        'Ma_gv',
        'Ten_gv',
        'Chuc_danh',
        'Hoc_ham',
        'Lich_hoc',
        'Ghi_chu',
        'Trang_thai',
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
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
