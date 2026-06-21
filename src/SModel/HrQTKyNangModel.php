<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrQTKyNangModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'Ma_cty',
        'Id',
        'Id_qtkn',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrQTKyNang';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Id';

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
        'Id',
        'Id_qtkn',
        'Ma_loai_kn',
        'Ma_kn',
        'Ma_trinh_do',
        'Ghi_chu',
        'Tai_lieu',
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
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
