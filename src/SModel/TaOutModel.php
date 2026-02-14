<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaOutModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaOut';

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
        'ma_ct',
        'ngay_ct',
        'thang',
        'nam',
        'ma_thue',
        'so_seri_mhd',
        'ngay_lct',
        'so_ct',
        'so_seri',
        'ma_kh',
        'ten_kh',
        'dia_chi',
        'ma_so_thue',
        'ma_vt',
        'ten_vt',
        'so_luong',
        'gia',
        'gia_nt',
        'ma_nt',
        'ty_gia',
        't_tien',
        't_tien_nt',
        'thue_suat',
        't_thue',
        't_thue_nt',
        'tk_thue',
        'tk_du',
        'ma_spct',
        'ma_lo',
        'ma_bp',
        'ma_hd',
        'ghi_chu',
        'tong_hop',
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
        'ngay_ct' => 'datetime',
        'thang' => 'integer',
        'nam' => 'integer',
        'ngay_lct' => 'datetime',
        'so_luong' => 'float',
        'gia' => 'float',
        'gia_nt' => 'float',
        'ty_gia' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        'thue_suat' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        'tong_hop' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
