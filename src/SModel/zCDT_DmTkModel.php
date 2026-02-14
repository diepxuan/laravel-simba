<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zCDT_DmTkModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zCDT_DmTk';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'tk',
        'ten_tk',
        'ten_tk2',
        'ten_ngan',
        'ten_ngan2',
        'ma_nt',
        'loai_tk',
        'tk_me',
        'bac_tk',
        'tk_sc',
        'tk_cn'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'loai_tk' => 'float',
        'bac_tk' => 'float',
        'tk_sc' => 'float',
        'tk_cn' => 'float',
    ];
}
