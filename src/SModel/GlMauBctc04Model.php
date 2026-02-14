<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctc04Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctc04';

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
        'so_qd',
        'mau',
        'ma_so',
        'stt',
        'chi_tieu',
        'cach_tinh',
        'thang',
        'tk_no',
        'tk_co',
        'ky_truoc',
        'ky_nay',
        'ky_truoc_nt',
        'ky_nay_nt',
        'loai_ps',
        'bold',
        'in_ck',
        'dau',
        'tm'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'thang' => 'integer',
        'ky_truoc' => 'float',
        'ky_nay' => 'float',
        'ky_truoc_nt' => 'float',
        'ky_nay_nt' => 'float',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'dau' => 'boolean',
    ];
}
