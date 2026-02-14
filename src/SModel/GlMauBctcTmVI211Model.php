<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctcTmVI211Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctcTmVI211';

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
        'ma_so',
        'chi_tieu',
        'nd_chtieu',
        'cach_tinh',
        'tk_01',
        'gia_tri_dk',
        'lai_suat_dk',
        'ky_han_dk',
        'gia_tri_ck',
        'lai_suat_ck',
        'ky_han_ck',
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
        'gia_tri_dk' => 'float',
        'gia_tri_ck' => 'float',
        'isPrint' => 'boolean',
        'isItalic' => 'boolean',
        'bold' => 'boolean',
        'modify' => 'boolean',
    ];
}
