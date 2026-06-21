<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysLangTranslationResxModel extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'dllFullName',
        'UserControlName',
        'controlName',
        'propertyName',
        'language',
    ];

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysLangTranslationResx';

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
        'dllFullName',
        'UserControlName',
        'controlName',
        'propertyName',
        'language',
        'defaultValue',
        'value',
        'formula'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
