<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CaTtHuModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CaTtHu';

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
        'stt_rec',
        'stt_rec0',
        'stt_rec_pc',
        'stt_rec0_pc',
        'loai_tt',
        'ma_gd',
        'ma_ct',
        'ma_kh',
        'nguoi_gd',
        'tk_tu',
        'ngay_tt',
        'dien_giai',
        'so_ct',
        'ngay_ct',
        'thang',
        'nam',
        'ma_nt',
        'ty_gia',
        'tien_pc',
        'tien_pc_nt',
        'tien_tt',
        'tien_tt_nt',
        'du_pc',
        'du_pc_nt',
        'tat_toan',
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
        'ngay_tt' => 'datetime',
        'ngay_ct' => 'datetime',
        'thang' => 'integer',
        'nam' => 'integer',
        'ty_gia' => 'float',
        'tien_pc' => 'float',
        'tien_pc_nt' => 'float',
        'tien_tt' => 'float',
        'tien_tt_nt' => 'float',
        'du_pc' => 'float',
        'du_pc_nt' => 'float',
        'tat_toan' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
