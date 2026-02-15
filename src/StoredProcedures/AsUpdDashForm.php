<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdDashForm
{
    /**
     * Call stored procedure asUpdDashForm
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDashForm', [
            'pDashId' => $params['pDashId'] ?? null,
            'pUserName' => $params['pUserName'] ?? null,
            'pTitle' => $params['pTitle'] ?? null,
            'pFormat' => $params['pFormat'] ?? null,
            'pLocation' => $params['pLocation'] ?? null,
            'pX' => $params['pX'] ?? null,
            'pY' => $params['pY'] ?? null,
            'pH' => $params['pH'] ?? null,
            'pW' => $params['pW'] ?? null,
            'pIsMenu' => $params['pIsMenu'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDashForm with named parameters
     *
     * @param int $DashId
     * @param string $UserName
     * @param string $Title
     * @param string $Format
     * @param string $Location
     * @param int $X
     * @param int $Y
     * @param int $H
     * @param int $W
     * @param bool $IsMenu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(int $DashId = null, string $UserName = null, string $Title = null, string $Format = null, string $Location = null, int $X = null, int $Y = null, int $H = null, int $W = null, bool $IsMenu = null, int $Ret = null): Collection
    {
        $params = [
            'pDashId' => $DashId,
            'pUserName' => $UserName,
            'pTitle' => $Title,
            'pFormat' => $Format,
            'pLocation' => $Location,
            'pX' => $X,
            'pY' => $Y,
            'pH' => $H,
            'pW' => $W,
            'pIsMenu' => $IsMenu,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
