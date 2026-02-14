<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiDmCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiDmCt';

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
        'ma_ct',
        'phan_he',
        'ma_ct_me',
        'ten_ct',
        'tk_no',
        'tk_co',
        'ma_nt',
        'so_lien',
        'stt_nkc',
        'stt_ntxt',
        'ct_dc',
        'loc_nsd',
        'vv',
        'spct',
        'phi',
        'bp',
        'lo',
        'sp_post',
        'sp_process',
        'ph',
        'ct',
        'sd',
        'nxt',
        'menuid',
        'vn_prefix',
        'vn_postfix',
        'vn_sequence',
        'vn_pattern',
        'vn_width',
        'PhFieldlist2IN',
        'CtFieldlist2IN',
        'kieu_trung_so_ct',
        'VoucherGetWhenOpenForm'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_lien' => 'integer',
        'stt_nkc' => 'integer',
        'stt_ntxt' => 'integer',
        'ct_dc' => 'boolean',
        'loc_nsd' => 'boolean',
        'vv' => 'boolean',
        'spct' => 'boolean',
        'phi' => 'boolean',
        'bp' => 'boolean',
        'lo' => 'boolean',
        'sd' => 'boolean',
        'vn_sequence' => 'integer',
        'vn_width' => 'integer',
        'kieu_trung_so_ct' => 'integer',
        'VoucherGetWhenOpenForm' => 'integer',
    ];
}
