<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiInsMenu
{
    /**
     * Call stored procedure asSiInsMenu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsMenu', [
            'pStt' => $params['pStt'] ?? null,
            'pModuleid' => $params['pModuleid'] ?? null,
            'pBar' => $params['pBar'] ?? null,
            'pBaren_us' => $params['pBaren_us'] ?? null,
            'pShort_name' => $params['pShort_name'] ?? null,
            'pMenuid' => $params['pMenuid'] ?? null,
            'pDllname' => $params['pDllname'] ?? null,
            'pCommand' => $params['pCommand'] ?? null,
            'pCode_name' => $params['pCode_name'] ?? null,
            'pReport' => $params['pReport'] ?? null,
            'pBasicright' => $params['pBasicright'] ?? null,
            'pForm' => $params['pForm'] ?? null,
            'pOpt' => $params['pOpt'] ?? null,
            'pPar1' => $params['pPar1'] ?? null,
            'pPar2' => $params['pPar2'] ?? null,
            'pPar3' => $params['pPar3'] ?? null,
            'pPar4' => $params['pPar4'] ?? null,
            'pPar5' => $params['pPar5'] ?? null,
            'pPar6' => $params['pPar6'] ?? null,
            'pPar7' => $params['pPar7'] ?? null,
            'pPar8' => $params['pPar8'] ?? null,
            'pPicture1' => $params['pPicture1'] ?? null,
            'pPicture2' => $params['pPicture2'] ?? null,
            'pDeveloper' => $params['pDeveloper'] ?? null,
            'pMaintainer' => $params['pMaintainer'] ?? null,
            'pUsed' => $params['pUsed'] ?? null,
            'pActive' => $params['pActive'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsMenu with named parameters
     *
     * @param string $Stt
     * @param string $Moduleid
     * @param string $Bar
     * @param string $Baren_us
     * @param string $Short_name
     * @param string $Menuid
     * @param string $Dllname
     * @param string $Command
     * @param string $Code_name
     * @param bool $Report
     * @param bool $Basicright
     * @param bool $Form
     * @param string $Opt
     * @param string $Par1
     * @param string $Par2
     * @param string $Par3
     * @param string $Par4
     * @param string $Par5
     * @param string $Par6
     * @param string $Par7
     * @param string $Par8
     * @param string $Picture1
     * @param string $Picture2
     * @param string $Developer
     * @param string $Maintainer
     * @param bool $Used
     * @param string $Active
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Stt = null, string $Moduleid = null, string $Bar = null, string $Baren_us = null, string $Short_name = null, string $Menuid = null, string $Dllname = null, string $Command = null, string $Code_name = null, bool $Report = null, bool $Basicright = null, bool $Form = null, string $Opt = null, string $Par1 = null, string $Par2 = null, string $Par3 = null, string $Par4 = null, string $Par5 = null, string $Par6 = null, string $Par7 = null, string $Par8 = null, string $Picture1 = null, string $Picture2 = null, string $Developer = null, string $Maintainer = null, bool $Used = null, string $Active = null, int $Ret = null): Collection
    {
        $params = [
            'pStt' => $Stt,
            'pModuleid' => $Moduleid,
            'pBar' => $Bar,
            'pBaren_us' => $Baren_us,
            'pShort_name' => $Short_name,
            'pMenuid' => $Menuid,
            'pDllname' => $Dllname,
            'pCommand' => $Command,
            'pCode_name' => $Code_name,
            'pReport' => $Report,
            'pBasicright' => $Basicright,
            'pForm' => $Form,
            'pOpt' => $Opt,
            'pPar1' => $Par1,
            'pPar2' => $Par2,
            'pPar3' => $Par3,
            'pPar4' => $Par4,
            'pPar5' => $Par5,
            'pPar6' => $Par6,
            'pPar7' => $Par7,
            'pPar8' => $Par8,
            'pPicture1' => $Picture1,
            'pPicture2' => $Picture2,
            'pDeveloper' => $Developer,
            'pMaintainer' => $Maintainer,
            'pUsed' => $Used,
            'pActive' => $Active,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
