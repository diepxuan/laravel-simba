<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsTATNDN01A
{
    /**
     * Call stored procedure asInsTATNDN01A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTATNDN01A', $params, $connection);
    }

    /**
     * Call stored procedure asInsTATNDN01A with named parameters
     *
     * @param string $Mau
     * @param string $Ma_so
     * @param int $Stt
     * @param string $Chi_tieu
     * @param string $Cach_tinh
     * @param string $Tk
     * @param string $No_co
     * @param string $Tk_du
     * @param bool $Bold
     * @param bool $In_ck
     * @param float $Tien
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Mau = null, string $Ma_so = null, int $Stt = null, string $Chi_tieu = null, string $Cach_tinh = null, string $Tk = null, string $No_co = null, string $Tk_du = null, bool $Bold = null, bool $In_ck = null, float $Tien = null, int $Ret = null): Collection
    {
        $params = [
            'pMau' => $Mau,
            'pMa_so' => $Ma_so,
            'pStt' => $Stt,
            'pChi_tieu' => $Chi_tieu,
            'pCach_tinh' => $Cach_tinh,
            'pTk' => $Tk,
            'pNo_co' => $No_co,
            'pTk_du' => $Tk_du,
            'pBold' => $Bold,
            'pIn_ck' => $In_ck,
            'pTien' => $Tien,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
