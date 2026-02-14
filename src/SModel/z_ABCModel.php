<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class z_ABCModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'z_ABC';

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
        'Stt',
        'Số CT',
        'Ngày CT',
        'Diễn giải',
        'Nợ_112',
        'Nợ_133',
        'Nợ_141',
        'Nợ_211',
        'Nợ_333',
        'Nợ_334',
        'Nợ_623',
        'Nợ_627',
        'Nợ_641',
        'Nợ_642',
        'Cộng có',
        'Bold'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Stt' => 'integer',
        'Ngày CT' => 'datetime',
        'Cộng có' => 'float',
        'Bold' => 'boolean',
    ];
}
