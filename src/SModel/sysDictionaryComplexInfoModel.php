<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysDictionaryComplexInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysDictionaryComplexInfo';

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
        'PK',
        'code_fname',
        'return_fname',
        'menuid',
        'code_length',
        'name_fname',
        'table_name',
        'lookup_when_invalid',
        'allow_merge_code',
        'dllname',
        'view_class_name',
        'edit_class_name',
        'carry_field_list',
        'default_sort',
        'copy_vaora',
        'par0',
        'par1',
        'par2',
        'par3',
        'par4',
        'par5',
        'par6',
        'par7',
        'par8',
        'par9',
        'description'
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
        'copy_vaora' => 'boolean',
    ];
}
