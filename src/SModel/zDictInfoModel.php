<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class zDictInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'zDictInfo';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'id';

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
        'PK',
        'code_fname',
        'menuid',
        'code_length',
        'name_fname',
        'table_name',
        'lookup_when_invalid',
        'allow_merge_code',
        'dllname',
        'view_class_name',
        'edit_class_name',
        'description',
        'carry_field_list',
        'default_sort'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'code_length' => 'integer',
        'lookup_when_invalid' => 'boolean',
        'allow_merge_code' => 'boolean',
    ];
}
