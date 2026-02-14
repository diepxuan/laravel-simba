<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ApTtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ApTt';

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
        'ma_tt_po',
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
        't_tien0',
        't_tien_nt0',
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
        'du_pc',
        'du_pc_nt',
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
        'han_ck' => 'integer',
        'ngay_ck' => 'datetime',
        'tl_ck' => 'float',
        'han_tt' => 'integer',
        'ngay_tt' => 'datetime',
        'ls_qh' => 'float',
        'ngay_ct' => 'datetime',
        'ty_gia' => 'float',
        't_tien0' => 'float',
        't_tien_nt0' => 'float',
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
        'du_pc' => 'float',
        'du_pc_nt' => 'float',
        'du_tt' => 'float',
        'du_tt_nt' => 'float',
        'chenh_lech' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
