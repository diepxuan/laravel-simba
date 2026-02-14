<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class MmDmLoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'MmDmLo';

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
        'ma_lo_tp',
        'ten_lo',
        'ksd',
        'cdate',
        'cuser',
        'ldate',
        'luser',
        'ten_vt',
        'so_luong',
        'thang',
        'nam',
        'ma_vt',
        'han_dung',
        'trang_thai'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
        'so_luong' => 'float',
        'thang' => 'integer',
        'nam' => 'integer',
        'han_dung' => 'datetime',
    ];
}
