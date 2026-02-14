<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlCtModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlCt';

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
        'thang',
        'nam',
        'stt_rec',
        'stt_rec0',
        'ma_ct',
        'ngay_ct',
        'ngay_lct',
        'so_ct',
        'ngay_lo',
        'so_lo',
        'nguoi_gd',
        'dien_giai',
        'tk',
        'tk_du',
        'ps_no_nt',
        'ps_co_nt',
        'ma_nt',
        'ty_gia',
        'ps_no',
        'ps_co',
        'nhom_dk',
        'ma_kh',
        'ma_bp',
        'ma_nvkd',
        'ma_hd',
        'ma_phi',
        'ma_spct',
        'ma_lo',
        'ma_ku',
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
        'ngay_ct' => 'datetime',
        'ngay_lct' => 'datetime',
        'ngay_lo' => 'datetime',
        'ps_no_nt' => 'float',
        'ps_co_nt' => 'float',
        'ty_gia' => 'float',
        'ps_no' => 'float',
        'ps_co' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
