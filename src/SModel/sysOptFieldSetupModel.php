<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysOptFieldSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysOptFieldSetup';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Voucher_code';

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
        'Stt',
        'Voucher_code',
        'Field',
        'Master',
        'Detail'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Stt' => 'integer',
        'Master' => 'boolean',
        'Detail' => 'boolean',
    ];
}
