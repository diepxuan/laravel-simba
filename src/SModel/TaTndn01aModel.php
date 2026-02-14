<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaTndn01aModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaTndn01a';

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
        'chi_tieu',
        'cach_tinh',
        'tk',
        'no_co',
        'tk_du',
        'bold',
        'in_ck',
        'tien',
        'modify',
        'user_sort'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'tien' => 'float',
        'modify' => 'boolean',
        'user_sort' => 'integer',
    ];
}
