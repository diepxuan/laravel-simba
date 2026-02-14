<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class FaKhTsModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'FaKhTs';

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
        'nam',
        'thang',
        'ma_ts',
        'ngay',
        'ma_ts_tgng',
        'ma_bpsd',
        'ma_phi',
        'ma_spct',
        'tk_kh',
        'tk_cp',
        'kh_n1',
        'kh_n2',
        'kh_n3',
        'kh_n4',
        'tang_giam',
        'sua_kh'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'thang' => 'integer',
        'ngay' => 'datetime',
        'kh_n1' => 'float',
        'kh_n2' => 'float',
        'kh_n3' => 'float',
        'kh_n4' => 'float',
        'tang_giam' => 'boolean',
        'sua_kh' => 'boolean',
    ];
}
