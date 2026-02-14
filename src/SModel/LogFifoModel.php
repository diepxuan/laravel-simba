<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class LogFifoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'LogFifo';

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
        'ma_cty',
        'thang',
        'nam',
        'ma_vt',
        'ma_kho',
        'ngay_ct',
        'mo_ta',
        'so_luong',
        'gia',
        'tien',
        'stt_rec_px',
        'stt_rec_pn',
        'so_pn',
        'user',
        'date'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'thang' => 'integer',
        'nam' => 'integer',
        'ngay_ct' => 'datetime',
        'so_luong' => 'float',
        'gia' => 'float',
        'tien' => 'float',
        'date' => 'datetime',
    ];
}
