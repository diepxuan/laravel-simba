<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCdFifoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCdFifo';

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
        'nam',
        'thang',
        'stt_rec_nt',
        'stt_rec0',
        'ma_ct',
        'stt_ntxt',
        'ngay_ct',
        'so_ct',
        'ma_kho',
        'ma_vt',
        'dvt',
        'so_luong',
        'so_luong_qd',
        'ma_nt',
        'tien',
        'tien_nt',
        'tien_cp',
        'tien_cp_nt',
        'ton_kho',
        'so_du',
        'so_du_nt',
        'tat_toan',
        'status'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam' => 'integer',
        'thang' => 'integer',
        'stt_ntxt' => 'integer',
        'ngay_ct' => 'datetime',
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'tien' => 'float',
        'tien_nt' => 'float',
        'tien_cp' => 'float',
        'tien_cp_nt' => 'float',
        'ton_kho' => 'float',
        'so_du' => 'float',
        'so_du_nt' => 'float',
    ];
}
