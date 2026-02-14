<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctcTmVI25aModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctcTmVI25a';

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
        'nam_ps',
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
        'tk_07',
        'tien_07',
        'tk_08',
        'tien_08',
        'tk_09',
        'tien_09',
        'tk_10',
        'tien_10',
        'tk_11',
        'tien_11',
        'tk_12',
        'tien_12',
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
        'tien_07' => 'float',
        'tien_08' => 'float',
        'tien_09' => 'float',
        'tien_10' => 'float',
        'tien_11' => 'float',
        'tien_12' => 'float',
        'tong' => 'float',
        'isPrint' => 'boolean',
        'isItalic' => 'boolean',
        'bold' => 'boolean',
        'modify' => 'boolean',
    ];
}
