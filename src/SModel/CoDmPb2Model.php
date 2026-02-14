<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class CoDmPb2Model extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'CoDmPb2';

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
        'nam',
        'thang',
        'tk_nhan_pb',
        'ma_spct',
        'ma_bp',
        'ma_hd',
        'ma_lo',
        'ma_phi',
        'he_so',
        'tien_nhan'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'id' => 'integer',
        'nam' => 'integer',
        'thang' => 'integer',
        'he_so' => 'float',
        'tien_nhan' => 'float',
    ];
}
