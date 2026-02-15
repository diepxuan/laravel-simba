<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIUpdDMCT
{
    /**
     * Call stored procedure asSIUpdDMCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdDMCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pPhan_he' => $params['pPhan_he'] ?? null,
            'pMa_ct_me' => $params['pMa_ct_me'] ?? null,
            'pTen_ct' => $params['pTen_ct'] ?? null,
            'pTk_no' => $params['pTk_no'] ?? null,
            'pTk_co' => $params['pTk_co'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pSo_lien' => $params['pSo_lien'] ?? null,
            'pStt_nkc' => $params['pStt_nkc'] ?? null,
            'pStt_ntxt' => $params['pStt_ntxt'] ?? null,
            'pCt_dc' => $params['pCt_dc'] ?? null,
            'pLoc_nsd' => $params['pLoc_nsd'] ?? null,
            'pVv' => $params['pVv'] ?? null,
            'pSpct' => $params['pSpct'] ?? null,
            'pPhi' => $params['pPhi'] ?? null,
            'pBp' => $params['pBp'] ?? null,
            'pLo' => $params['pLo'] ?? null,
            'pSp_post' => $params['pSp_post'] ?? null,
            'pSp_process' => $params['pSp_process'] ?? null,
            'pPh' => $params['pPh'] ?? null,
            'pSd' => $params['pSd'] ?? null,
            'pNxt' => $params['pNxt'] ?? null,
            'pMenuid' => $params['pMenuid'] ?? null,
            'pVn_prefix' => $params['pVn_prefix'] ?? null,
            'pVn_sequence' => $params['pVn_sequence'] ?? null,
            'pVn_postfix' => $params['pVn_postfix'] ?? null,
            'pVn_pattern' => $params['pVn_pattern'] ?? null,
            'pVn_width' => $params['pVn_width'] ?? null,
            'pKieu_trung_so_ct' => $params['pKieu_trung_so_ct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpdDMCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Phan_he
     * @param string $Ma_ct_me
     * @param string $Ten_ct
     * @param string $Tk_no
     * @param string $Tk_co
     * @param string $Ma_nt
     * @param int $So_lien
     * @param int $Stt_nkc
     * @param int $Stt_ntxt
     * @param bool $Ct_dc
     * @param bool $Loc_nsd
     * @param bool $Vv
     * @param bool $Spct
     * @param bool $Phi
     * @param bool $Bp
     * @param bool $Lo
     * @param string $Sp_post
     * @param string $Sp_process
     * @param string $Ph
     * @param bool $Sd
     * @param string $Nxt
     * @param string $Menuid
     * @param string $Vn_prefix
     * @param int $Vn_sequence
     * @param string $Vn_postfix
     * @param string $Vn_pattern
     * @param int $Vn_width
     * @param int $Kieu_trung_so_ct
     * @param string $Language
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Phan_he = null, string $Ma_ct_me = null, string $Ten_ct = null, string $Tk_no = null, string $Tk_co = null, string $Ma_nt = null, int $So_lien = null, int $Stt_nkc = null, int $Stt_ntxt = null, bool $Ct_dc = null, bool $Loc_nsd = null, bool $Vv = null, bool $Spct = null, bool $Phi = null, bool $Bp = null, bool $Lo = null, string $Sp_post = null, string $Sp_process = null, string $Ph = null, bool $Sd = null, string $Nxt = null, string $Menuid = null, string $Vn_prefix = null, int $Vn_sequence = null, string $Vn_postfix = null, string $Vn_pattern = null, int $Vn_width = null, int $Kieu_trung_so_ct = null, string $Language = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pPhan_he' => $Phan_he,
            'pMa_ct_me' => $Ma_ct_me,
            'pTen_ct' => $Ten_ct,
            'pTk_no' => $Tk_no,
            'pTk_co' => $Tk_co,
            'pMa_nt' => $Ma_nt,
            'pSo_lien' => $So_lien,
            'pStt_nkc' => $Stt_nkc,
            'pStt_ntxt' => $Stt_ntxt,
            'pCt_dc' => $Ct_dc,
            'pLoc_nsd' => $Loc_nsd,
            'pVv' => $Vv,
            'pSpct' => $Spct,
            'pPhi' => $Phi,
            'pBp' => $Bp,
            'pLo' => $Lo,
            'pSp_post' => $Sp_post,
            'pSp_process' => $Sp_process,
            'pPh' => $Ph,
            'pSd' => $Sd,
            'pNxt' => $Nxt,
            'pMenuid' => $Menuid,
            'pVn_prefix' => $Vn_prefix,
            'pVn_sequence' => $Vn_sequence,
            'pVn_postfix' => $Vn_postfix,
            'pVn_pattern' => $Vn_pattern,
            'pVn_width' => $Vn_width,
            'pKieu_trung_so_ct' => $Kieu_trung_so_ct,
            'pLanguage' => $Language,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
