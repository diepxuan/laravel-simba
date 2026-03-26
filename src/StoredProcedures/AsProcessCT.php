<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-26 15:57:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsProcessCT.
 *
 * Cung cấp phương thức tĩnh để gọi stored procedure asProcessCT của Simba SQL Server.
 * Sử dụng Laravel DB facade để thực thi câu lệnh SQL.
 */
class AsProcessCT
{
    /**
     * Call stored procedure asProcessCT.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asProcessCT', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct'   => $paramObj->pMa_ct ?? null,
            'pMode'    => $paramObj->pMode ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asProcessCT with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?string $Ma_ct = null, ?string $Mode = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct'   => $Ma_ct,
            'pMode'    => $Mode,
        ];

        return self::call($params);
    }
}
