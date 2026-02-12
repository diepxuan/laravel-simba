<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelCDFIFO
 * 
 * Stored procedure: asINDelCDFIFO
 * Purpose: Xóa bản ghi trong bảng InCdFifo và gọi stored procedure asINPostCDFIFO2CDVT với chế độ DELETE.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec_nt (nvarchar(20)): Số chứng từ nhập xuất (stt_rec_nt). Bắt buộc.
 * - @pStt_rec0 (nvarchar(3)): Số thứ tự chi tiết (stt_rec0). Bắt buộc.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pStt_rec_nt' => 'SO20230001',
 *     'pStt_rec0' => '001',
 * ];
 * $result = AsInDelCDFIFO::call($params);
 * ```
 */
class AsInDelCDFIFO
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelCDFIFO', [
            'pMa_cty'      => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec_nt'  => $params['pStt_rec_nt'] ?? null,
            'pStt_rec0'    => $params['pStt_rec0'] ?? null,
        ], $connection);
    }
}
