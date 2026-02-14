<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaQuyLuongModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaQuyLuong';

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
        'Thang',
        'Nam',
        'Ma_bp',
        'Ten_bp',
        'QL_T_DC',
        'QL_S_DC',
        'TyLe_DC',
        'GiaTri_DC',
        'QL_DP'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Thang' => 'integer',
        'Nam' => 'integer',
        'QL_T_DC' => 'float',
        'QL_S_DC' => 'float',
        'TyLe_DC' => 'float',
        'GiaTri_DC' => 'float',
        'QL_DP' => 'float',
    ];
}
