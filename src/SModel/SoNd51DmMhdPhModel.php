<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SoNd51DmMhdPhModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SoNd51DmMhdPh';

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
        'mau_so',
        'ten_loai',
        'ma_loai',
        'so_lien',
        'so_hd',
        'ten_mau',
        'loai_in',
        'kh_hd',
        'kh_nam',
        'so_seri',
        'so_dong',
        'ghi_chu',
        'mau_goc',
        'cdate',
        'cuser',
        'ldate',
        'luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'so_lien' => 'integer',
        'loai_in' => 'boolean',
        'so_dong' => 'integer',
        'mau_goc' => 'boolean',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
