<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InCt';

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
        'stt_rec',
        'stt_rec0',
        'thang',
        'nam',
        'ma_ct',
        'ma_gd',
        'pn_gtb',
        'px_gdd',
        'ngay_ct',
        'so_ct',
        'ma_nt',
        'ty_gia',
        'nxt',
        'ct_dc',
        'dien_giai',
        'ma_kho',
        'ma_khon',
        'ma_vt',
        'ten_vt',
        'dvt',
        'sl_nhap',
        'sl_nhap_qd',
        'sl_xuat',
        'sl_xuat_qd',
        'ma_nx',
        'tk_du',
        'tk_vt',
        'gia_nt0',
        'gia0',
        'tien_nt0',
        'tien0',
        'thue_nk_nt',
        'thue_nk',
        'thue_ttdb_nt',
        'thue_ttdb',
        'cp_nt',
        'cp',
        'gia_nt',
        'gia',
        'tien_nhap_nt',
        'tien_nhap',
        'tien_xuat_nt',
        'tien_xuat',
        'gia_nt2',
        'gia2',
        'tien_nt2',
        'tien2',
        'ts_gtgt',
        'thue_gtgt',
        'thue_gtgt_nt',
        'ma_kh',
        'nguoi_gd',
        'ma_vitri',
        'ma_lo',
        'ma_hd',
        'ma_bp',
        'ma_nvkd',
        'ma_spct',
        'ma_phi',
        'gia_nt_qd',
        'gia_qd',
        'ma_bo',
        'stt_rec_pn',
        'stt_rec0_pn',
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
        'thang' => 'integer',
        'nam' => 'integer',
        'pn_gtb' => 'boolean',
        'px_gdd' => 'boolean',
        'ngay_ct' => 'datetime',
        'ty_gia' => 'float',
        'sl_nhap' => 'float',
        'sl_nhap_qd' => 'float',
        'sl_xuat' => 'float',
        'sl_xuat_qd' => 'float',
        'gia_nt0' => 'float',
        'gia0' => 'float',
        'tien_nt0' => 'float',
        'tien0' => 'float',
        'thue_nk_nt' => 'float',
        'thue_nk' => 'float',
        'thue_ttdb_nt' => 'float',
        'thue_ttdb' => 'float',
        'cp_nt' => 'float',
        'cp' => 'float',
        'gia_nt' => 'float',
        'gia' => 'float',
        'tien_nhap_nt' => 'float',
        'tien_nhap' => 'float',
        'tien_xuat_nt' => 'float',
        'tien_xuat' => 'float',
        'gia_nt2' => 'float',
        'gia2' => 'float',
        'tien_nt2' => 'float',
        'tien2' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'gia_nt_qd' => 'float',
        'gia_qd' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
