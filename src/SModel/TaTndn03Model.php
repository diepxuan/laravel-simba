<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaTndn03Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaTndn03';

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
        'ma_so',
        'stt',
        'user_sort',
        'chi_tieu',
        'cach_tinh',
        'tk',
        'no_co',
        'tk_du',
        'bold',
        'in_ck',
        'tien',
        'modify'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'user_sort' => 'integer',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'tien' => 'float',
        'modify' => 'boolean',
    ];
}
