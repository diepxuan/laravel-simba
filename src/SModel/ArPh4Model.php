<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class ArPh4Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArPh4';

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
        'stt_rec',
        'so_ct',
        'ngay_ct',
        'ngay_lct',
        'nt_ph',
        'kht_thue_vao',
        'kht_thue_ra',
        'ma_nt',
        'ty_gia',
        't_tien',
        't_tien_nt',
        't_thue_vao',
        't_thue_ra',
        'trang_thai',
        'post2gl',
        'luser',
        'ldate',
        'cuser',
        'cdate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_ct' => 'datetime',
        'ngay_lct' => 'datetime',
        'nt_ph' => 'boolean',
        'kht_thue_vao' => 'boolean',
        'kht_thue_ra' => 'boolean',
        'ty_gia' => 'float',
        't_tien' => 'float',
        't_tien_nt' => 'float',
        't_thue_vao' => 'float',
        't_thue_ra' => 'float',
        'ldate' => 'datetime',
        'cdate' => 'datetime',
    ];
}
