<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlFinReportDataModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlFinReportData';

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
        'Id',
        'ma_cty',
        'Rep_id',
        'ngay',
        'stt',
        'ma_so',
        'tien0',
        'tien',
        'tien_nt0',
        'tien_nt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay' => 'datetime',
        'stt' => 'integer',
        'tien0' => 'float',
        'tien' => 'float',
        'tien_nt0' => 'float',
        'tien_nt' => 'float',
    ];
}
