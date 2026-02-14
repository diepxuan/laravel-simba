<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaDmThueTNCNModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaDmThueTNCN';

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
        'Bac_thue',
        'Dinh_muc_tu',
        'Dinh_muc_den',
        'Thue_suat',
        'Thue_toi_da'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Thue_suat' => 'float',
        'Thue_toi_da' => 'float',
    ];
}
