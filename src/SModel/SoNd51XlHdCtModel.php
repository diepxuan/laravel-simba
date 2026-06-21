<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51XlHdCtModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'kieu_xl',
        'ma_tb',
        'ma_chung',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51XlHdCt';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = null;

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
        'kieu_xl',
        'ma_tb',
        'ma_chung',
        'ten_loai',
        'mau_so',
        'so_seri',
        'tu_so',
        'den_so',
        'so_luong',
        'lien_hd',
        'ghi_chu'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
