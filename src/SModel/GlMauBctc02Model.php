<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlMauBctc02Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlMauBctc02';

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
        'tk',
        'tien0',
        'tien',
        'tien_nt0',
        'tien_nt',
        'bold',
        'in_ck',
        'ts_nv',
        'cong_no',
        'ngoai_bang',
        'sodu_duong',
        'xtag',
        'xstt',
        'tm',
        'stt_tinh'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'tien0' => 'float',
        'tien' => 'float',
        'tien_nt0' => 'float',
        'tien_nt' => 'float',
        'bold' => 'boolean',
        'in_ck' => 'boolean',
        'ts_nv' => 'boolean',
        'cong_no' => 'boolean',
        'ngoai_bang' => 'boolean',
        'sodu_duong' => 'boolean',
        'xtag' => 'integer',
        'xstt' => 'integer',
        'stt_tinh' => 'integer',
    ];
}
