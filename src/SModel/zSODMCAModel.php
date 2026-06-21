<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zSODMCAModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ca',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zSODMCA';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ca';

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
        'ca',
        'dien_giai',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
