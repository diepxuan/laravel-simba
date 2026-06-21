<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmKhacDsResxModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Code_name',
        'Language',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmKhacDsResx';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Code_name';

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
        'Ma_cty',
        'Code_name',
        'Language',
        'Name'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
