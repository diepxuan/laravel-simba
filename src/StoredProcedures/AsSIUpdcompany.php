<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIUpdcompany
{
    /**
     * Call stored procedure asSIUpdcompany
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdcompany', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTen_tcty' => $params['pTen_tcty'] ?? null,
            'pTen_cty' => $params['pTen_cty'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pGiam_doc' => $params['pGiam_doc'] ?? null,
            'pKtt' => $params['pKtt'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pTel' => $params['pTel'] ?? null,
            'pFax' => $params['pFax'] ?? null,
            'pEmail' => $params['pEmail'] ?? null,
            'pQd_cdkt' => $params['pQd_cdkt'] ?? null,
            'pTen_qd_cdkt' => $params['pTen_qd_cdkt'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpdcompany with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ten_tcty
     * @param string $Ten_cty
     * @param string $Dia_chi
     * @param string $Giam_doc
     * @param string $Ktt
     * @param string $Ma_thue
     * @param string $Tel
     * @param string $Fax
     * @param string $Email
     * @param string $Qd_cdkt
     * @param string $Ten_qd_cdkt
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ten_tcty = null, string $Ten_cty = null, string $Dia_chi = null, string $Giam_doc = null, string $Ktt = null, string $Ma_thue = null, string $Tel = null, string $Fax = null, string $Email = null, string $Qd_cdkt = null, string $Ten_qd_cdkt = null, string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTen_tcty' => $Ten_tcty,
            'pTen_cty' => $Ten_cty,
            'pDia_chi' => $Dia_chi,
            'pGiam_doc' => $Giam_doc,
            'pKtt' => $Ktt,
            'pMa_thue' => $Ma_thue,
            'pTel' => $Tel,
            'pFax' => $Fax,
            'pEmail' => $Email,
            'pQd_cdkt' => $Qd_cdkt,
            'pTen_qd_cdkt' => $Ten_qd_cdkt,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
