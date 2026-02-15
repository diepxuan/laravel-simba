<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInPostCDVT2CDFIFO
{
    /**
     * Call stored procedure asInPostCDVT2CDFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInPostCDVT2CDFIFO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pTien_nt' => $params['pTien_nt'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pAcction' => $params['pAcction'] ?? null,
            'pma_vt' => $params['pma_vt'] ?? null,
            'pma_kho' => $params['pma_kho'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInPostCDVT2CDFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_nt
     * @param float $So_luong
     * @param float $Tien_nt
     * @param float $Tien
     * @param string $Acction
     * @param mixed $ma_vt
     * @param mixed $ma_kho
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_nt = null, float $So_luong = null, float $Tien_nt = null, float $Tien = null, string $Acction = null, mixed $ma_vt = null, mixed $ma_kho = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_nt' => $Ma_nt,
            'pSo_luong' => $So_luong,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pAcction' => $Acction,
            'pma_vt' => $ma_vt,
            'pma_kho' => $ma_kho
        ];
        
        return self::call($params);
    }
}
