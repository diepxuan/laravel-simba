<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysKyBaoCaoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysKyBaoCao';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma';

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
        'code',
        'ma',
        'ten_ky',
        'nhan_in',
        'ngay1',
        'ngay2',
        'thang1',
        'thang2'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'stt' => 'integer',
        'thang1' => 'integer',
        'thang2' => 'integer',
    ];
}
