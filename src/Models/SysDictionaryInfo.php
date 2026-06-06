<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-05 20:58:00
 */

namespace Diepxuan\Simba\Models;

use Illuminate\Database\Eloquent\Model;

/**
 * SimbaERP sysDictionaryInfo table model.
 *
 * Source: simba-docs/tables/sysDictionaryInfo.md.
 */
class SysDictionaryInfo extends Model
{
    public $incrementing  = false;
    public $timestamps    = false;
    protected $connection = 'sqlsrv';
    protected $table      = 'sysDictionaryInfo';
    protected $primaryKey = 'code_name';
    protected $keyType    = 'string';

    protected $fillable = [
        'code_name',
        'PK',
        'code_fname',
        'code_length',
        'name_fname',
        'table_name',
        'menuid',
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
        'description',
    ];

    protected $casts = [
        'code_length'         => 'integer',
        'lookup_when_invalid' => 'boolean',
        'allow_merge_code'    => 'boolean',
        'copy_vaora'          => 'boolean',
    ];

    /**
     * @return list<string>
     */
    public function primaryKeyFields(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->PK))));
    }

    /**
     * @return list<string>
     */
    public function carryFields(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->carry_field_list))));
    }

    /**
     * Scope: find dictionary metadata by Simba code_name.
     *
     * @param mixed $query
     */
    public function scopeCodeName($query, string $codeName)
    {
        return $query->where('code_name', $codeName);
    }

    /**
     * Scope: find dictionary metadata by Simba menuid.
     *
     * @param mixed $query
     */
    public function scopeMenuId($query, string $menuId)
    {
        return $query->where('menuid', $menuId);
    }
}
