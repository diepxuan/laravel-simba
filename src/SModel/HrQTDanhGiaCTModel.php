<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTDanhGiaCTModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Id',
        'Id_qtdg',
        'Ma_tcdg',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTDanhGiaCT';

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
        'Id',
        'Id_qtdg',
        'Ma_tcdg',
        'Diem_dg',
        'Diem_toi_da',
        'Ghi_chu'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Diem_dg' => 'float',
        'Diem_toi_da' => 'float',
    ];
}
