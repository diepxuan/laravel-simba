<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLInsMAUBCTCTmVI15c
 * 
 * Stored procedure: asGLInsMAUBCTCTmVI15c
 * Purpose: =============================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR): Tham số đầu vào.
 * - @pMau (NVARCHAR): Tham số đầu vào.
 * - @pMa_so (NVARCHAR): Tham số đầu vào.
 * - @pChi_tieu (NVARCHAR): Tham số đầu vào.
 * - @pNd_chtieu (NVARCHAR): Tham số đầu vào.
 * - @pCach_tinh (NVARCHAR): Tham số đầu vào.
 * - @pLoai_ps (NVARCHAR): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR): Tham số đầu vào.
 * - @pTk_02 (NVARCHAR): Tham số đầu vào.
 * - @pIsPrint (NVARCHAR): Tham số đầu vào.
 * - @pIsItalic (NVARCHAR): Tham số đầu vào.
 * - @pBold (NVARCHAR): Tham số đầu vào.
 * - @pModify (NVARCHAR): Tham số đầu vào.
 * - @pTien_01 (NVARCHAR): Tham số đầu vào.
 * - @pTien_02 (NVARCHAR): Tham số đầu vào.
 * - @pTien_03 (NVARCHAR): Tham số đầu vào.
 * - @pTien_04 (NVARCHAR): Tham số đầu vào.
 * - @pTien_05 (NVARCHAR): Tham số đầu vào.
 * - @pTien_06 (NVARCHAR): Tham số đầu vào.
 * - @pUserData (NVARCHAR): Tham số đầu vào.
 * - @pGhi_chu (NVARCHAR): Tham số đầu vào.
 * - @pNgay1 (NVARCHAR): Tham số đầu vào.
 * - @pNgay2 (NVARCHAR): Tham số đầu vào.
 * - @pRet (NVARCHAR OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * - @pcach_tinh (NVARCHAR): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR): Tham số đầu vào.
 * - @pTk_02 (NVARCHAR): Tham số đầu vào.
 * - @pModify (NVARCHAR): Tham số đầu vào.
 * - @pModify (NVARCHAR): Tham số đầu vào.
 * - @pUserData (NVARCHAR): Tham số đầu vào.
 * - @pMa_cty (NVARCHAR): Tham số đầu vào.
 * - @pMau (NVARCHAR): Tham số đầu vào.
 * - @pMa_so (NVARCHAR): Tham số đầu vào.
 * - @pChi_tieu (NVARCHAR): Tham số đầu vào.
 * - @pNd_chtieu (NVARCHAR): Tham số đầu vào.
 * - @pCach_tinh (NVARCHAR): Tham số đầu vào.
 * - @pLoai_ps (NVARCHAR): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR): Tham số đầu vào.
 * - @pTk_02 (NVARCHAR): Tham số đầu vào.
 * - @pIsPrint (NVARCHAR): Tham số đầu vào.
 * - @pIsItalic (NVARCHAR): Tham số đầu vào.
 * - @pBold (NVARCHAR): Tham số đầu vào.
 * - @pModify (NVARCHAR): Tham số đầu vào.
 * - @pMa_cty (NVARCHAR): Tham số đầu vào.
 * - @pMau (NVARCHAR): Tham số đầu vào.
 * - @pNgay1 (NVARCHAR): Tham số đầu vào.
 * - @pNgay2 (NVARCHAR): Tham số đầu vào.
 * - @pMa_so (NVARCHAR): Tham số đầu vào.
 * - @pChi_tieu (NVARCHAR): Tham số đầu vào.
 * - @pNd_chtieu (NVARCHAR): Tham số đầu vào.
 * - @pCach_tinh (NVARCHAR): Tham số đầu vào.
 * - @pLoai_ps (NVARCHAR): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR): Tham số đầu vào.
 * - @pTk_02 (NVARCHAR): Tham số đầu vào.
 * - @pGhi_chu (NVARCHAR): Tham số đầu vào.
 * - @pIsPrint (NVARCHAR): Tham số đầu vào.
 * - @pIsItalic (NVARCHAR): Tham số đầu vào.
 * - @pBold (NVARCHAR): Tham số đầu vào.
 * - @pModify (NVARCHAR): Tham số đầu vào.
 * - @pTien_01 (NVARCHAR): Tham số đầu vào.
 * - @pTien_02 (NVARCHAR): Tham số đầu vào.
 * - @pTien_03 (NVARCHAR): Tham số đầu vào.
 * - @pTien_04 (NVARCHAR): Tham số đầu vào.
 * - @pTien_05 (NVARCHAR): Tham số đầu vào.
 * - @pTien_06 (NVARCHAR): Tham số đầu vào.
 * - @pRet (NVARCHAR OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMau' => '',
            'pMa_so' => '',
            'pChi_tieu' => '',
            'pNd_chtieu' => '',
            'pCach_tinh' => '',
            'pLoai_ps' => '',
            'pTk_01' => '',
            'pTk_02' => '',
            'pIsPrint' => '',
            'pIsItalic' => '',
            'pBold' => '',
            'pModify' => '',
            'pTien_01' => '',
            'pTien_02' => '',
            'pTien_03' => '',
            'pTien_04' => '',
            'pTien_05' => '',
            'pTien_06' => '',
            'pUserData' => '',
            'pGhi_chu' => '',
            'pNgay1' => '',
            'pNgay2' => '',
            'pcach_tinh' => '',
            'pTk_01' => '',
            'pTk_02' => '',
            'pModify' => '',
            'pModify' => '',
            'pUserData' => '',
            'pMa_cty' => '',
            'pMau' => '',
            'pMa_so' => '',
            'pChi_tieu' => '',
            'pNd_chtieu' => '',
            'pCach_tinh' => '',
            'pLoai_ps' => '',
            'pTk_01' => '',
            'pTk_02' => '',
            'pIsPrint' => '',
            'pIsItalic' => '',
            'pBold' => '',
            'pModify' => '',
            'pMa_cty' => '',
            'pMau' => '',
            'pNgay1' => '',
            'pNgay2' => '',
            'pMa_so' => '',
            'pChi_tieu' => '',
            'pNd_chtieu' => '',
            'pCach_tinh' => '',
            'pLoai_ps' => '',
            'pTk_01' => '',
            'pTk_02' => '',
            'pGhi_chu' => '',
            'pIsPrint' => '',
            'pIsItalic' => '',
            'pBold' => '',
            'pModify' => '',
            'pTien_01' => '',
            'pTien_02' => '',
            'pTien_03' => '',
            'pTien_04' => '',
            'pTien_05' => '',
            'pTien_06' => '',
 * ];
 * $result = AsGLInsMAUBCTCTmVI15c::call($params);
 * ```
 */
class AsGLInsMAUBCTCTmVI15c
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTmVI15c', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pTk_02' => $params['pTk_02'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pTien_01' => $params['pTien_01'] ?? null,
            'pTien_02' => $params['pTien_02'] ?? null,
            'pTien_03' => $params['pTien_03'] ?? null,
            'pTien_04' => $params['pTien_04'] ?? null,
            'pTien_05' => $params['pTien_05'] ?? null,
            'pTien_06' => $params['pTien_06'] ?? null,
            'pUserData' => $params['pUserData'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pcach_tinh' => $params['pcach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pTk_02' => $params['pTk_02'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pUserData' => $params['pUserData'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pTk_02' => $params['pTk_02'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pTk_02' => $params['pTk_02'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pTien_01' => $params['pTien_01'] ?? null,
            'pTien_02' => $params['pTien_02'] ?? null,
            'pTien_03' => $params['pTien_03'] ?? null,
            'pTien_04' => $params['pTien_04'] ?? null,
            'pTien_05' => $params['pTien_05'] ?? null,
            'pTien_06' => $params['pTien_06'] ?? null,
        ], $connection);
    }
}
