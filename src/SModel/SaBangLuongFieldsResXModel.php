<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaBangLuongFieldsResXModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaBangLuongFieldsResX';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ten';

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
        'Ten',
        'language',
        'Mo_ta',
        'Tieu_de',
        'Do_rong',
        'Format'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Do_rong' => 'integer',
    ];
}
