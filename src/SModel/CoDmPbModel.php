<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoDmPbModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoDmPb';

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
        'id',
        'tk_pb',
        'moduleid',
        'loai_pb',
        'stt',
        'ten_bt',
        'so_ct',
        'tien_pb',
        'tien_pb_nt',
        'TheoSPCT',
        'TheoBP',
        'TheoTKDU',
        'TheoLO',
        'TheoHD',
        'ksd',
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
        'id' => 'integer',
        'stt' => 'integer',
        'tien_pb' => 'float',
        'tien_pb_nt' => 'float',
        'TheoSPCT' => 'boolean',
        'TheoBP' => 'boolean',
        'TheoTKDU' => 'boolean',
        'TheoLO' => 'boolean',
        'TheoHD' => 'boolean',
        'ksd' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
