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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdcompany', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTen_tcty' => $paramObj->pTen_tcty ?? null,
            'pTen_cty' => $paramObj->pTen_cty ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pGiam_doc' => $paramObj->pGiam_doc ?? null,
            'pKtt' => $paramObj->pKtt ?? null,
            'pMa_thue' => $paramObj->pMa_thue ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pEmail' => $paramObj->pEmail ?? null,
            'pQd_cdkt' => $paramObj->pQd_cdkt ?? null,
            'pTen_qd_cdkt' => $paramObj->pTen_qd_cdkt ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null
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
