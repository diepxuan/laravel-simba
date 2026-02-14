<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmCCTCModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmCCTC';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_cty';

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
        'Ma_cty',
        'Id_CCTC',
        'Ten_CCTC',
        'Id_parent',
        'Stt',
        'Stt_cay',
        'Bac',
        'Ma_bp',
        'Cuser',
        'Luser',
        'Cdate',
        'Ldate'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Stt' => 'integer',
        'Bac' => 'integer',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
