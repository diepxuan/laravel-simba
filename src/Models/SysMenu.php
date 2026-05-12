<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-11 23:45:32
 */

namespace Diepxuan\Simba\Models;

use Illuminate\Database\Eloquent\Model;

/**
 * SimbaERP sysMenu table model.
 *
 * Maps the menu structure from SimbaERP's SQL Server database.
 * Menu ID format: XX.YY.ZZ (module.group.item)
 */
class SysMenu extends Model
{
    // Type constants
    public const TYPE_MODULE_ROOT = '5';
    public const TYPE_GROUP       = '';
    public const TYPE_VOUCHER     = '1';
    public const TYPE_MASTER      = '2';
    public const TYPE_REPORT      = '4';
    public const TYPE_UTILITY     = '3';
    public const TYPE_SETUP       = '6';
    public $incrementing          = false;
    public $timestamps            = false;
    protected $connection         = 'sqlsrv';
    protected $table              = 'sysMenu';
    protected $primaryKey         = 'menuid';

    protected $fillable = [
        'menuid', 'stt', 'type', 'moduleid', 'bar', 'short_name',
        'dllName', 'command', 'code_name', 'report', 'basicright',
        'form', 'form_show_type', 'opt',
        'par1', 'par2', 'par3', 'par4', 'par5', 'par6', 'par7', 'par8',
        'picture1', 'picture2', 'rowid', 'developer', 'maintainer',
        'used', 'active', 'zmenuid',
    ];

    /**
     * Get parent menu_id from hierarchical structure XX.YY.ZZ
     * 02.10.02 → 02.10.00
     * 02.10.00 → 02.00.00
     * 02.00.00 → null (root).
     */
    public function getParentMenuId(): ?string
    {
        $parts = explode('.', $this->menuid);
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
        return self::TYPE_MODULE_ROOT === $this->type;
    }

    public function isGroup(): bool
    {
        return self::TYPE_GROUP === $this->type || null === $this->type;
    }

    public function isVoucher(): bool
    {
        return self::TYPE_VOUCHER === $this->type;
    }

    public function isMasterData(): bool
    {
        return self::TYPE_MASTER === $this->type;
    }

    public function isReport(): bool
    {
        return self::TYPE_REPORT === $this->type;
    }

    public function isUtility(): bool
    {
        return self::TYPE_UTILITY === $this->type;
    }

    public function isSetup(): bool
    {
        return self::TYPE_SETUP === $this->type;
    }

    /**
     * Get filter params (par1-par8) as array.
     */
    public function getParams(): array
    {
        $params = [];
        for ($i = 1; $i <= 8; ++$i) {
            $key = "par{$i}";
            if ($this->{$key}) {
                $params[$key] = $this->{$key};
            }
        }

        return $params;
    }

    /**
     * Scope: active menus only.
     *
     * @param mixed $query
     */
    public function scopeActive($query)
    {
        return $query->where('active', 1);
    }

    /**
     * Scope: filter by module.
     *
     * @param mixed $query
     */
    public function scopeModule($query, string $moduleId)
    {
        return $query->where('moduleid', $moduleId);
    }

    /**
     * Scope: filter by type.
     *
     * @param mixed $query
     */
    public function scopeType($query, string $type)
    {
        return $query->where('type', $type);
    }

    /**
     * Get all menus ordered hierarchically.
     *
     * @param mixed $query
     */
    public function scopeOrdered($query)
    {
        return $query->orderBy('menuid');
    }

    /**
     * Get icon filename from picture1.
     */
    public function getIconName(): string
    {
        if ($this->picture1) {
            return pathinfo($this->picture1, PATHINFO_FILENAME);
        }

        return match ($this->type) {
            self::TYPE_MODULE_ROOT => 'cube',
            self::TYPE_VOUCHER     => 'document-text',
            self::TYPE_MASTER      => 'folder',
            self::TYPE_REPORT      => 'chart-bar',
            self::TYPE_UTILITY     => 'wrench',
            self::TYPE_SETUP       => 'cog',
            default                => 'folder',
        };
    }

    /**
     * Get display name (prefer bar over short_name).
     */
    public function getDisplayName(): string
    {
        return $this->bar ?: $this->short_name ?: $this->menuid;
    }
}
