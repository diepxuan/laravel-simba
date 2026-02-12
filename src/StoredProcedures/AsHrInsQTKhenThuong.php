<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsQTKhenThuong
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTKhenThuong', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pId' => $params['pId'] ?? '',
            'pId_qtktkl' => $params['pId_qtktkl'] ?? '',
            'pLoai_ktkl' => $params['pLoai_ktkl'] ?? '',
            'pMa_ktkl' => $params['pMa_ktkl'] ?? '',
            'pNoi_dung' => $params['pNoi_dung'] ?? '',
            'pGhi_chu' => $params['pGhi_chu'] ?? '',
            'pTai_lieu' => $params['pTai_lieu'] ?? '',
            'pCuser' => $params['pCuser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
