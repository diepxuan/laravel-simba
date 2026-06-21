<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51DmMhdCtModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'mau_so',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51DmMhdCt';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'mau_so';

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
        'mau_so',
        'mota1',
        'mota2',
        'mota3',
        'mota4',
        'mota5',
        'mota6',
        'mota7',
        'mota8',
        'mota9',
        'mau_goc'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'mau_goc' => 'boolean',
    ];
}
