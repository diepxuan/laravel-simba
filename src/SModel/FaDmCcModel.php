<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class FaDmCcModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'FaDmCc';

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
        'ma_cc',
        'stt_rec',
        'stt_rec0',
        'moduleid',
        'tg',
        'id',
        'stt_rec_glct',
        'so_ct',
        'ngay_ct',
        'ten_cc',
        'dvt',
        'so_luong',
        'don_gia',
        'ng_gia',
        'gt_da_kh',
        'gt_cl',
        'ky_pb',
        'so_ky',
        'kh_ky',
        'ngay_bdkh',
        'ngay_gt_cl',
        'ngay_giam',
        'tk_cc',
        'tk_cp',
        'ma_bpsd',
        'ma_spct',
        'ma_phi',
        'cong_suat',
        'tinh_kh',
        'sua_kh',
        'is_giam',
        'is_het_kh',
        'cdate',
        'cuser',
        'ldate',
        'luser',
        'ksd'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'tg' => 'boolean',
        'id' => 'integer',
        'ngay_ct' => 'datetime',
        'don_gia' => 'float',
        'ng_gia' => 'float',
        'gt_da_kh' => 'float',
        'gt_cl' => 'float',
        'ky_pb' => 'integer',
        'so_ky' => 'integer',
        'kh_ky' => 'float',
        'ngay_bdkh' => 'datetime',
        'ngay_gt_cl' => 'datetime',
        'ngay_giam' => 'datetime',
        'tinh_kh' => 'boolean',
        'sua_kh' => 'boolean',
        'is_giam' => 'boolean',
        'is_het_kh' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
        'ksd' => 'boolean',
    ];
}
