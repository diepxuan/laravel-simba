<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-07-01 17:01:11
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SoPh3 as Model;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class SoPh3.
 *
 * This class represents the model for the general ledger transactions.
 * It provides methods to interact with the stored procedure for generating reports.
 */
class SoPh3 extends Model
{
    /**
     * Gọi stored procedure asSoFilt3 để lấy dữ liệu danh sách bán hàng.
     */
    public static function getAsSoFilt3(array $params): array|Collection
    {
        $connect = DB::connection((new static())->getConnectionName());
        $pdo     = $connect->getPdo();

        $pKeyPh_conditions = [];

        if (!empty($params['ma_cty'])) {
            $pKeyPh_conditions[] = "ma_cty=N'" . $params['ma_cty'] . "'";
        }
        if (!empty($params['ma_ct'])) {
            $pKeyPh_conditions[] = "ma_ct='" . $params['ma_ct'] . "'";
        }
        if (!empty($params['ngay_ct1']) && !empty($params['ngay_ct2'])) {
            $pKeyPh_conditions[] = "ngay_ct between '" . $params['ngay_ct1'] . "' and '" . $params['ngay_ct2'] . "'";
        }
        if (!empty($params['ma_kh'])) {
            $pKeyPh_conditions[] = "ma_kh like N'" . $params['ma_kh'] . "%'";
        }

        $pKeyPh_string = implode(' and ', $pKeyPh_conditions);

        $pKeyCt_string = '';
        if (!empty($params['ma_cty'])) {
            $pKeyCt_string = "ma_cty=N'" . $params['ma_cty'] . "'";
        }

        // \Debugbar::info($pKeyPh_string, $pKeyCt_string);

        $stmt = $pdo->prepare('EXECUTE [dbo].[asSoFilt3]
            @pKeyPh = :pKeyPh,
            @pKeyCt = :pKeyCt
        ');
        // $stmt->bindParam(':pKeyPh', $pKeyPh_string, \PDO::PARAM_STR);
        // $stmt->bindParam(':pKeyCt', $pKeyCt_string, \PDO::PARAM_STR);
        // $stmt->execute();
        $stmt->execute([
            'pKeyPh' => $pKeyPh_string,
            'pKeyCt' => $pKeyCt_string,
        ]);

        $results        = [];
        $phs            = $stmt->fetchAll(\PDO::FETCH_ASSOC);
        $results['phs'] = $phs;
        if ($stmt->nextRowset()) {
            $cts            = $stmt->fetchAll(\PDO::FETCH_ASSOC) ?? [];
            $results['cts'] = $cts;
            \Debugbar::info($cts);
        }

        try {
            $stmt->closeCursor();
        } catch (\Exception $e) {
            Debugbar::info($e);
        }

        return $results;
    }
}
