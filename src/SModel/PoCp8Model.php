<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class PoCp8Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'PoCp8';

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
        'stt_rec',
        'stt_rec0',
        'ma_cp',
        'ten_cp',
        'tt_pb',
        'tien_cp_nt',
        'tien_cp',
        'ts_gtgt',
        'thue_gtgt_nt',
        'thue_gtgt',
        'tt_nt',
        'tt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'tien_cp_nt' => 'float',
        'tien_cp' => 'float',
        'ts_gtgt' => 'float',
        'thue_gtgt_nt' => 'float',
        'thue_gtgt' => 'float',
        'tt_nt' => 'float',
        'tt' => 'float',
    ];
}
