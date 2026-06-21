<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCdVtModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'nam',
        'ma_vt',
        'ma_kho',
        'ma_vitri',
        'ma_lo',
        'tk_vt',
        'ma_nt',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCdVt';

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
        'ma_cty',
        'nam',
        'ma_kho',
        'ma_vt',
        'ma_vitri',
        'ma_lo',
        'tk_vt',
        'ma_nt',
        'so_luong',
        'tien_nt',
        'tien',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'so_luong' => 'float',
        'tien_nt' => 'float',
        'tien' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
