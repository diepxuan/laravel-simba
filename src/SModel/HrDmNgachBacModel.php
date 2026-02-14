<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrDmNgachBacModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrDmNgachBac';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_cty';

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
        'Ma_tbl',
        'Ma_nb',
        'Ten_nb',
        'Dien_giai',
        'So_bac',
        'Nien_han01',
        'He_so01',
        'Nien_han02',
        'He_so02',
        'Nien_han03',
        'He_so03',
        'Nien_han04',
        'He_so04',
        'Nien_han05',
        'He_so05',
        'Nien_han06',
        'He_so06',
        'Nien_han07',
        'He_so07',
        'Nien_han08',
        'He_so08',
        'Nien_han09',
        'He_so09',
        'Nien_han10',
        'He_so10',
        'Nien_han11',
        'He_so11',
        'Nien_han12',
        'He_so12',
        'Nien_han13',
        'He_so13',
        'Nien_han14',
        'He_so14',
        'Nien_han15',
        'He_so15',
        'Nien_han16',
        'He_so16',
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
        'So_bac' => 'integer',
        'Nien_han01' => 'integer',
        'He_so01' => 'float',
        'Nien_han02' => 'integer',
        'He_so02' => 'float',
        'Nien_han03' => 'integer',
        'He_so03' => 'float',
        'Nien_han04' => 'integer',
        'He_so04' => 'float',
        'Nien_han05' => 'integer',
        'He_so05' => 'float',
        'Nien_han06' => 'integer',
        'He_so06' => 'float',
        'Nien_han07' => 'integer',
        'He_so07' => 'float',
        'Nien_han08' => 'integer',
        'He_so08' => 'float',
        'Nien_han09' => 'integer',
        'He_so09' => 'float',
        'Nien_han10' => 'integer',
        'He_so10' => 'float',
        'Nien_han11' => 'integer',
        'He_so11' => 'float',
        'Nien_han12' => 'integer',
        'He_so12' => 'float',
        'Nien_han13' => 'integer',
        'He_so13' => 'float',
        'Nien_han14' => 'integer',
        'He_so14' => 'float',
        'Nien_han15' => 'integer',
        'He_so15' => 'float',
        'Nien_han16' => 'integer',
        'He_so16' => 'float',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
