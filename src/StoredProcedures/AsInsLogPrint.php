<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:34:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsLogPrint
{
    /**
     * Call stored procedure asInsLogPrint
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsLogPrint', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pusername' => $params['pusername'] ?? null,
            'pmenuid' => $params['pmenuid'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
            'pma_ct' => $params['pma_ct'] ?? null,
            'pso_ct' => $params['pso_ct'] ?? null,
            'pso_seri' => $params['pso_seri'] ?? null,
            'pngay_ct' => $params['pngay_ct'] ?? null,
            'pma_mau' => $params['pma_mau'] ?? null,
            'pdate' => $params['pdate'] ?? null,
            'pCountPrinted' => $params['pCountPrinted'] ?? null,
            'pIs_Frist' => $params['pIs_Frist'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pSo_seri' => $params['pSo_seri'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsLogPrint with named parameters
     *
     * @param string $ma_cty
     * @param string $username
     * @param string $menuid
     * @param string $stt_rec
     * @param string $ma_ct
     * @param string $so_ct
     * @param string $so_seri
     * @param string $ngay_ct
     * @param string $ma_mau
     * @param string $date
     * @param int $CountPrinted
     * @param bool $Is_Frist
     * @param mixed $So_ct
     * @param mixed $So_seri
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $username = null, string $menuid = null, string $stt_rec = null, string $ma_ct = null, string $so_ct = null, string $so_seri = null, string $ngay_ct = null, string $ma_mau = null, string $date = null, int $CountPrinted = null, bool $Is_Frist = null, mixed $So_ct = null, mixed $So_seri = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pusername' => $username,
            'pmenuid' => $menuid,
            'pstt_rec' => $stt_rec,
            'pma_ct' => $ma_ct,
            'pso_ct' => $so_ct,
            'pso_seri' => $so_seri,
            'pngay_ct' => $ngay_ct,
            'pma_mau' => $ma_mau,
            'pdate' => $date,
            'pCountPrinted' => $CountPrinted,
            'pIs_Frist' => $Is_Frist,
            'pSo_ct' => $So_ct,
            'pSo_seri' => $So_seri
        ];
        
        return self::call($params);
    }
}
