<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiDmCtResxModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_ct',
        'language',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiDmCtResx';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_ct';

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
        'ma_ct',
        'language',
        'ten_ct'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
