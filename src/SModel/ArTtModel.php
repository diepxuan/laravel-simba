<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArTtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArTt';

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
        'stt_rec_hd',
        'stt_rec_dh',
        'thang',
        'nam',
        'loai_tt',
        'ma_gd',
        'ma_ct',
        'ma_kh',
        'nguoi_gd',
        'ma_hd',
        'tk_pt',
        'ma_tt',
        'han_ck',
        'ngay_ck',
        'tl_ck',
        'han_tt',
        'ngay_tt',
        'ls_qh',
        'dien_giai',
        'so_ct',
        'ngay_ct',
        'ma_nt',
        'ty_gia',
        't_tien2',
        't_tien_nt2',
        't_ck',
        't_ck_nt',
        't_ck_ds',
        't_ck_ds_nt',
        't_thue',
        't_thue_nt',
        't_tt',
        't_tt_nt',
        'tien_tt',
        'tien_tt_nt',
        'tien_tt_qd',
        't_tien',
        't_tien_nt',
        'tien_pb',
        'tien_pb_nt',
        'du_hd',
        'du_hd_nt',
        'du_pt',
        'du_pt_nt',
        'du_tt',
        'du_tt_nt',
        'chenh_lech',
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
        'thang' => 'integer',
        'nam' => 'integer',
        'han_ck' => 'float',
        'ngay_ck' => 'datetime',
        'tl_ck' => 'float',
        'han_tt' => 'float',
        'ngay_tt' => 'datetime',
        'ls_qh' => 'float',
        'ngay_ct' => 'datetime',
        'ty_gia' => 'float',
        't_tien2' => 'float',
        't_tien_nt2' => 'float',
        't_ck' => 'float',
        't_ck_nt' => 'float',
        't_ck_ds' => 'float',
        't_ck_ds_nt' => 'float',
        't_thue' => 'float',
        't_thue_nt' => 'float',
        't_tt' => 'float',
        't_tt_nt' => 'float',
        'tien_tt' => 'float',
        'tien_tt_nt' => 'float',
        'tien_tt_qd' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        'tien_pb' => 'float',
        'tien_pb_nt' => 'float',
        'du_hd' => 'float',
        'du_hd_nt' => 'float',
        'du_pt' => 'float',
        'du_pt_nt' => 'float',
        'du_tt' => 'float',
        'du_tt_nt' => 'float',
        'chenh_lech' => 'float',
        'tat_toan' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
