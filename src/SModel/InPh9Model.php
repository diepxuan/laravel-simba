<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class InPh9Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InPh9';

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
        'ma_ct',
        'ma_gd',
        'ngay_ct',
        'ngay_lct',
        'so_ct',
        'ma_nx',
        'ma_nt',
        'ty_gia',
        'ma_kh1',
        'ma_kh2',
        'ma_kh3',
        'chuc_vu1',
        'chuc_vu2',
        'chuc_vu3',
        'dai_dien1',
        'dai_dien2',
        'dai_dien3',
        'dien_giai',
        't_sl_ton',
        't_sl_kk',
        't_sl_cl',
        't_tien_ss',
        'trang_thai',
        'post2gl',
        'post2in',
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
        'ngay_lct' => 'datetime',
        'ty_gia' => 'float',
        't_sl_ton' => 'float',
        't_sl_kk' => 'float',
        't_sl_cl' => 'float',
        't_tien_ss' => 'float',
        'post2gl' => 'boolean',
        'post2in' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
