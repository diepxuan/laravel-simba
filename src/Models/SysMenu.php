<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-06 08:25:00
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SModel;

/**
 * Model sysMenu - SimbaERP menu metadata.
 *
 * Source: simba-docs/data/sysMenu.md.
 */
class SysMenu extends SModel
{
    public const TYPE_MODULE_ROOT = '5';
    public const TYPE_GROUP       = '';
    public const TYPE_VOUCHER     = '1';
    public const TYPE_MASTER      = '2';
    public const TYPE_REPORT      = '4';
    public const TYPE_UTILITY     = '3';
    public const TYPE_SETUP       = '6';

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

    public function getDisplayName(): string
    {
        return $this->bar ?: $this->short_name ?: $this->menuid ?: '';
    }

    public function getParentMenuId(): ?string
    {
        $parts = explode('.', (string) $this->menuid);
        if (3 !== \count($parts)) {
            return null;
        }

        if ('00' !== $parts[2]) {
            return "{$parts[0]}.{$parts[1]}.00";
        }

        if ('00' !== $parts[1]) {
            return "{$parts[0]}.00.00";
        }

        return null;
    }

    public function isRoot(): bool
    {
        return self::TYPE_MODULE_ROOT === (string) $this->type;
    }

    public function isGroup(): bool
    {
        return self::TYPE_GROUP === (string) $this->type;
    }

    public function isVoucher(): bool
    {
        return self::TYPE_VOUCHER === (string) $this->type;
    }

    public function isMasterData(): bool
    {
        return self::TYPE_MASTER === (string) $this->type;
    }

    public function isReport(): bool
    {
        return self::TYPE_REPORT === (string) $this->type;
    }

    public function isSetup(): bool
    {
        return self::TYPE_SETUP === (string) $this->type;
    }
}
