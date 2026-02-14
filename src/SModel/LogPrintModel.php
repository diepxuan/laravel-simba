<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class LogPrintModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'LogPrint';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'stt';

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
        'stt',
        'ma_cty',
        'username',
        'menuid',
        'stt_rec',
        'ma_ct',
        'so_ct',
        'so_seri',
        'ngay_ct',
        'ma_mau',
        'date',
        'is_Frist'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'ngay_ct' => 'datetime',
        'date' => 'datetime',
        'is_Frist' => 'boolean',
    ];
}
