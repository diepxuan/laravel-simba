<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysCompanyResxModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysCompanyResx';

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
        'language',
        'ten_tcty',
        'ten_cty',
        'dia_chi',
        'giam_doc',
        'ktt',
        'ma_thue',
        'Tel',
        'fax',
        'email',
        'ten_nh',
        'so_tk_nh',
        'tinh_tp_nh',
        'ten_qd_cdkt',
        'qd_cdkt'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
