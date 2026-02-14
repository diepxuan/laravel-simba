<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlBctcTmVI02aModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlBctcTmVI02a';

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
        'mau',
        'ngay1',
        'ngay2',
        'ma_so',
        'chi_tieu',
        'nd_chtieu',
        'cach_tinh',
        'tk_01',
        'gia_goc_dk',
        'gia_hl_dk',
        'gia_dp_dk',
        'gia_goc_ck',
        'gia_hl_ck',
        'gia_dp_ck',
        'ghi_chu',
        'isPrint',
        'isItalic',
        'bold',
        'modify'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay1' => 'datetime',
        'ngay2' => 'datetime',
        'gia_goc_dk' => 'float',
        'gia_hl_dk' => 'float',
        'gia_dp_dk' => 'float',
        'gia_goc_ck' => 'float',
        'gia_hl_ck' => 'float',
        'gia_dp_ck' => 'float',
        'isPrint' => 'boolean',
        'isItalic' => 'boolean',
        'bold' => 'boolean',
        'modify' => 'boolean',
    ];
}
