<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-08-02 21:46:08
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmKho as Model;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

class InDmKho extends Model
{
    /**
     * Gọi stored procedure asINGetDMKHO để lấy dữ liệu Danh sách kho.
     *
     * @return array
     */
    public static function getAsINGetDMKHO(array $params): Collection
    {
        // \Debugbar::info($params);

        return collect(DB::connection((new static())->getConnectionName())->select(
            <<<'EOF'
                EXECUTE asINGetDMKHO
                @pMa_Cty = :pMa_Cty,
                @pMa_kho = :pMa_kho,
                @pStruct = :pStruct
                EOF
            ,
            [
                'pMa_Cty' => $params['pMa_Cty'] ?? '',
                'pMa_kho' => $params['pMa_kho'] ?? null,
                'pStruct' => $params['pStruct'] ?? null,
            ]
        ));
    }

    protected function id(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => implode('_', [$attributes['ma_cty'], $attributes['ma_kho']]),
        );
    }

    protected function sku(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ma_kho'],
        );
    }

    protected function name(): Attribute
    {
        return Attribute::make(
            get: static fn (mixed $value, array $attributes) => $attributes['ten_kho'],
        );
    }
}
