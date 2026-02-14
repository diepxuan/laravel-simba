<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlBctcTMVI212Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlBctcTMVI212';

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
        'isPrint' => 'boolean',
        'isItalic' => 'boolean',
        'bold' => 'boolean',
        'modify' => 'boolean',
    ];
}
