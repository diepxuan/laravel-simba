<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoCt0Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoCt0';

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
        'ma_vt',
        'ma_kho',
        'dvt',
        'so_luong',
        'so_luong_qd',
        'gia_nt2',
        'gia2',
        'tien_nt2',
        'tien2',
        'tl_ck',
        'tien_ck_nt',
        'tien_ck',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt',
        'khuyen_mai',
        'tra_ck',
        'ma_nvkd',
        'ma_bp',
        'ma_phi',
        'ma_hd',
        'ma_spct',
        'ma_lo',
        'tk_pt',
        'tk_dt',
        'tk_gv',
        'tk_vt',
        'tk_thue',
        'tk_ck',
        'sl_xuat',
        'sl_hd'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_luong' => 'float',
        'so_luong_qd' => 'float',
        'gia_nt2' => 'float',
        'gia2' => 'float',
        'tien_nt2' => 'float',
        'tien2' => 'float',
        'tl_ck' => 'float',
        'tien_ck_nt' => 'float',
        'tien_ck' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'tt_nt' => 'float',
        'tt' => 'float',
        'sl_xuat' => 'float',
        'sl_hd' => 'float',
    ];
}
