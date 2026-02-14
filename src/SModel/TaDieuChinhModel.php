<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class TaDieuChinhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'TaDieuChinh';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'thang1',
        'thang2',
        'nam',
        'stt_rec',
        'doanh_so',
        'thue',
        'ma_so'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'thang1' => 'integer',
        'thang2' => 'integer',
        'nam' => 'integer',
        'doanh_so' => 'float',
        'thue' => 'float',
    ];
}
