<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctc03Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctc03';

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
        'tk_no',
        'tk_co',
        'bold',
        'in_ck',
        'giam_tru',
        'ky_truoc',
        'ky_nay',
        'lk_kt',
        'lk_kn',
        'lk_kt_nt',
        'ky_truocnt',
        'ky_nay_nt',
        'lk_kn_nt',
        'tm'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'giam_tru' => 'boolean',
        'ky_truoc' => 'float',
        'ky_nay' => 'float',
        'lk_kt' => 'float',
        'lk_kn' => 'float',
        'lk_kt_nt' => 'float',
        'ky_truocnt' => 'float',
        'ky_nay_nt' => 'float',
        'lk_kn_nt' => 'float',
    ];
}
