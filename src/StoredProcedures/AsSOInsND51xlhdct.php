<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsND51xlhdct
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51xlhdct', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pKieu_xl'  => $params['pKieu_xl'] ?? null,
            'pMa_tb'  => $params['pMa_tb'] ?? null,
            'pMa_chung'  => $params['pMa_chung'] ?? null,
            'pTen_loai'  => $params['pTen_loai'] ?? null,
            'pMau_so'  => $params['pMau_so'] ?? null,
            'pSo_seri'  => $params['pSo_seri'] ?? null,
            'pTu_so'  => $params['pTu_so'] ?? null,
            'pDen_so'  => $params['pDen_so'] ?? null,
            'pSo_luong'  => $params['pSo_luong'] ?? null,
            'pLien_hd'  => $params['pLien_hd'] ?? null,
            'pGhi_chu'  => $params['pGhi_chu'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
