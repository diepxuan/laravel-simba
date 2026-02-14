<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaInModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaIn';

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
        'stt_rec_pn',
        'ma_ct',
        'ngay_ct',
        'so_ct',
        'so_seri_mhd',
        'ngay_ct0',
        'so_ct0',
        'so_seri0',
        'mau_bc',
        'ma_kh',
        'ten_kh',
        'dia_chi',
        'ma_so_thue',
        'ma_vt',
        'ten_vt',
        'so_luong',
        'gia_nt',
        'tien_hang_nt',
        'thue_nk_nt',
        'thue_ttdb_nt',
        't_tien_nt',
        't_thue_nt',
        'thue_suat',
        'gia',
        'tien_hang',
        'thue_nk',
        'thue_ttdb',
        't_tien',
        't_thue',
        'ma_nt',
        'ty_gia',
        'tk_thue_no',
        'tk_du',
        'ma_bp',
        'ma_spct',
        'ma_lo',
        'ghi_chu',
        'VAT_NK',
        'stt_rec_pc',
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
        'ngay_ct0' => 'datetime',
        'so_luong' => 'float',
        'gia_nt' => 'float',
        'tien_hang_nt' => 'float',
        'thue_nk_nt' => 'float',
        'thue_ttdb_nt' => 'float',
        't_tien_nt' => 'float',
        't_thue_nt' => 'float',
        'thue_suat' => 'float',
        'gia' => 'float',
        'tien_hang' => 'float',
        'thue_nk' => 'float',
        'thue_ttdb' => 'float',
        't_tien' => 'float',
        't_thue' => 'float',
        'ty_gia' => 'float',
        'VAT_NK' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
