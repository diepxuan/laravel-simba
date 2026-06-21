<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrTDDeThiModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Ma_yctd',
        'Vong_so',
        'Ma_mon_thi',
        'De_so',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrTDDeThi';

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
        'Ma_cty',
        'Ma_yctd',
        'Vong_so',
        'Ma_mon_thi',
        'Ten_mon_thi',
        'De_so',
        'Tai_lieu',
        'Ghi_chu',
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
