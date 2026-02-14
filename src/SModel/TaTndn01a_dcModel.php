<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaTndn01a_dcModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaTndn01a_dc';

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
        'mau',
        'ngay1',
        'ngay2',
        'Id',
        'stt',
        'bold',
        'in_ck',
        'ma_so',
        'chi_tieu',
        'cach_tinh',
        'tk',
        'no_co',
        'tk_du',
        'tien',
        'user_sort'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay1' => 'datetime',
        'ngay2' => 'datetime',
        'Id' => 'integer',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'tien' => 'float',
        'user_sort' => 'integer',
    ];
}
