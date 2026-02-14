<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctcTmVI09Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctcTmVI09';

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
        'loai_ps',
        'tk_01',
        'tien_01',
        'tk_02',
        'tien_02',
        'tk_03',
        'tien_03',
        'tk_04',
        'tien_04',
        'tk_05',
        'tien_05',
        'tk_06',
        'tien_06',
        'tong',
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
        'tien_01' => 'float',
        'tien_02' => 'float',
        'tien_03' => 'float',
        'tien_04' => 'float',
        'tien_05' => 'float',
        'tien_06' => 'float',
        'tong' => 'float',
        'isPrint' => 'boolean',
        'isItalic' => 'boolean',
        'bold' => 'boolean',
        'modify' => 'boolean',
    ];
}
