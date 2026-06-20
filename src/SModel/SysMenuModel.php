<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-20 13:02:00
 */

namespace Diepxuan\Simba\SModel;

/**
 * Model sysMenu - SimbaERP menu metadata.
 *
 * Source: simba-docs/data/sysMenu.md.
 */
class SysMenuModel extends SModel
{
    public $incrementing  = false;
    public $timestamps    = false;
    protected $table      = 'sysMenu';
    protected $primaryKey = 'menuid';
    protected $keyType    = 'string';

    protected $fillable = [
        'menuid',
        'stt',
        'type',
        'moduleid',
        'bar',
        'short_name',
        'dllName',
        'command',
        'code_name',
        'report',
        'basicright',
        'form',
        'form_show_type',
        'opt',
        'par1',
        'par2',
        'par3',
        'par4',
        'par5',
        'par6',
        'par7',
        'par8',
        'picture1',
        'picture2',
        'rowid',
        'developer',
        'maintainer',
        'used',
        'active',
        'zmenuid',
    ];

    protected $casts = [
        'report'         => 'boolean',
        'basicright'     => 'boolean',
        'form'           => 'boolean',
        'form_show_type' => 'integer',
        'rowid'          => 'integer',
        'used'           => 'boolean',
        'active'         => 'boolean',
    ];
}
