<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class GlDmCtgsModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'ma_ct',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'GlDmCtgs';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_ct';

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
        'ma_ct',
        'tk',
        'ten_ctgs',
        'so_hieu',
        'ngay',
        'stt',
        'ksd',
        'cuser',
        'cdate',
        'luser',
        'ldate',
        'tk_du'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay' => 'integer',
        'stt' => 'integer',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
