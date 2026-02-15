<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdOptFieldInfo
{
    /**
     * Call stored procedure asUpdOptFieldInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOptFieldInfo', [
            'pStt' => $params['pStt'] ?? null,
            'pCaption' => $params['pCaption'] ?? null,
            'pField' => $params['pField'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdOptFieldInfo with named parameters
     *
     * @param int $Stt
     * @param string $Caption
     * @param string $Field
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(int $Stt = null, string $Caption = null, string $Field = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pStt' => $Stt,
            'pCaption' => $Caption,
            'pField' => $Field,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
