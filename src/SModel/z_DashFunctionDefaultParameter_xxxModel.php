<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class z_DashFunctionDefaultParameter_xxxModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'z_DashFunctionDefaultParameter_xxx';

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
        'User_name',
        'DashFunctionId',
        'Description',
        'SP_Name',
        'Tk',
        'Tk_du',
        'Ma_kh',
        'Ma_hd',
        'Ma_bp',
        'Ma_spct',
        'Ma_phi',
        'Ma_kho',
        'Ma_vt',
        'Ma_nhvt',
        'Ma_plvt1',
        'Ma_plvt2',
        'Ma_plvt3'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
