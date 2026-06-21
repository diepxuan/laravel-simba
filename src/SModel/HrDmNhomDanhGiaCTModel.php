<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmNhomDanhGiaCTModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Ma_nhdg',
        'Ma_tcdg',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmNhomDanhGiaCT';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_nhdg';

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
        'Ma_nhdg',
        'Ma_tcdg',
        'Ten_tcdg',
        'Diem_toi_da'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Diem_toi_da' => 'float',
    ];
}
