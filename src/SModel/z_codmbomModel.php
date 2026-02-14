<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class z_codmbomModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'z_codmbom';

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
        'stt_rec_lenh',
        'ma_lenh',
        'ma_spct',
        'co_sp',
        'ma_vt',
        'co_vt',
        'he_so',
        'So_luong',
        'So_luong_lenh',
        'sl_xuat',
        'sl_nhap',
        'ghi_chu',
        'sl_hs'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'sl_xuat' => 'float',
        'sl_nhap' => 'float',
        'sl_hs' => 'float',
    ];
}
