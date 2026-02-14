<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctc05Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctc05';

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
        'stt',
        'chi_tieu',
        'ma_so_ctu',
        'cach_tinh',
        'tk_no',
        'tk_co',
        'bold',
        'in_ck',
        'ky_truoc',
        'ky_nay',
        'ky_truoc_nt',
        'ky_nay_nt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'ma_so_ctu' => 'boolean',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'ky_truoc' => 'float',
        'ky_nay' => 'float',
        'ky_truoc_nt' => 'float',
        'ky_nay_nt' => 'float',
    ];
}
