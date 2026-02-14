<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class FaDmTsModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'FaDmTs';

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
        'ma_ts',
        'ten_ts',
        'dvt',
        'so_luong',
        'nha_cc',
        'nuoc_sx',
        'nam_sx',
        'ngay_dvsd',
        'cong_suat',
        'ma_bpsd',
        'ma_spct',
        'ma_phi',
        'tk_ts',
        'tk_kh',
        'tk_cp',
        'ma_nhts1',
        'ma_nhts2',
        'ma_nhts3',
        'ma_tg_ts',
        'ngay_tang',
        'so_ct',
        'ngay_ct',
        'ma_giam_ts',
        'so_ct_giam',
        'ngay_ct_giam',
        'ngay_giam',
        'ngay_gt_cl',
        'ngay_bdkh',
        'ngay_tkh',
        'ngay_dc',
        'ld_dc',
        'tinh_kh',
        'st_kh',
        'tl_kh',
        'ng_gia_n1',
        'ng_gia_n2',
        'ng_gia_n3',
        'ng_gia_n4',
        't_ng_gia',
        'gt_kh_n1',
        'gt_kh_n2',
        'gt_kh_n3',
        'gt_kh_n4',
        't_gt_kh',
        'gt_cl_n1',
        'gt_cl_n2',
        'gt_cl_n3',
        'gt_cl_n4',
        't_gt_cl',
        'kh_th_n1',
        'kh_th_n2',
        'kh_th_n3',
        'kh_th_n4',
        't_kh_th',
        'sua_kh',
        'is_giam',
        'is_tkh',
        'cdate',
        'cuser',
        'ldate',
        'luser',
        'ksd',
        'ng_gia_n10',
        'ng_gia_n20',
        'ng_gia_n30',
        'ng_gia_n40',
        't_ng_gia0',
        'gt_kh_n10',
        'gt_kh_n20',
        'gt_kh_n30',
        'gt_kh_n40',
        't_gt_kh0',
        'gt_cl_n10',
        'gt_cl_n20',
        'gt_cl_n30',
        'gt_cl_n40',
        't_gt_cl0',
        'kh_th_n10',
        'kh_th_n20',
        'kh_th_n30',
        'kh_th_n40',
        't_kh_th0'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'nam_sx' => 'integer',
        'ngay_dvsd' => 'datetime',
        'ngay_tang' => 'datetime',
        'ngay_ct' => 'datetime',
        'ngay_ct_giam' => 'datetime',
        'ngay_giam' => 'datetime',
        'ngay_gt_cl' => 'datetime',
        'ngay_bdkh' => 'datetime',
        'ngay_tkh' => 'datetime',
        'ngay_dc' => 'datetime',
        'tinh_kh' => 'boolean',
        'st_kh' => 'integer',
        'tl_kh' => 'float',
        'ng_gia_n1' => 'float',
        'ng_gia_n2' => 'float',
        'ng_gia_n3' => 'float',
        'ng_gia_n4' => 'float',
        't_ng_gia' => 'float',
        'gt_kh_n1' => 'float',
        'gt_kh_n2' => 'float',
        'gt_kh_n3' => 'float',
        'gt_kh_n4' => 'float',
        't_gt_kh' => 'float',
        'gt_cl_n1' => 'float',
        'gt_cl_n2' => 'float',
        'gt_cl_n3' => 'float',
        'gt_cl_n4' => 'float',
        't_gt_cl' => 'float',
        'kh_th_n1' => 'float',
        'kh_th_n2' => 'float',
        'kh_th_n3' => 'float',
        'kh_th_n4' => 'float',
        't_kh_th' => 'float',
        'sua_kh' => 'boolean',
        'is_giam' => 'boolean',
        'is_tkh' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
        'ksd' => 'boolean',
        'ng_gia_n10' => 'float',
        'ng_gia_n20' => 'float',
        'ng_gia_n30' => 'float',
        'ng_gia_n40' => 'float',
        't_ng_gia0' => 'float',
        'gt_kh_n10' => 'float',
        'gt_kh_n20' => 'float',
        'gt_kh_n30' => 'float',
        'gt_kh_n40' => 'float',
        't_gt_kh0' => 'float',
        'gt_cl_n10' => 'float',
        'gt_cl_n20' => 'float',
        'gt_cl_n30' => 'float',
        'gt_cl_n40' => 'float',
        't_gt_cl0' => 'float',
        'kh_th_n10' => 'float',
        'kh_th_n20' => 'float',
        'kh_th_n30' => 'float',
        'kh_th_n40' => 'float',
        't_kh_th0' => 'float',
    ];
}
