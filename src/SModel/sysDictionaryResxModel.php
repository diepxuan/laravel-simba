<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysDictionaryResxModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'code_name',
        'language',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysDictionaryResx';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'code_name';

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
        'code_name',
        'language',
        'formated_col_list',
        'viewform_size'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
