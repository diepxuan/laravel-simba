<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmKhacDsModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Code_name',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmKhacDs';

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
        'Name',
        'Stt',
        'Ksd',
        'Cdate',
        'Ldate',
        'Cuser',
        'Luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Ksd' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
