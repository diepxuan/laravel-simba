<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asUpdVoucherInfo
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asUpdVoucherInfo', [
            'pvoucher_code'               => $paramObj->pvoucher_code ?? null,
            'pph_table_name'              => $paramObj->pph_table_name ?? null,
            'pct_table_name'              => $paramObj->pct_table_name ?? null,
            'pcp_table_name'              => $paramObj->pcp_table_name ?? null,
            'pmenuid'                     => $paramObj->pmenuid ?? null,
            'pph_extra_edit_cotrol_list'  => $paramObj->pph_extra_edit_cotrol_list ?? null,
            'psearch_class_name'          => $paramObj->psearch_class_name ?? null,
            'pview_class_name'            => $paramObj->pview_class_name ?? null,
            'pprint_class_name'           => $paramObj->pprint_class_name ?? null,
            'pma_nt_default'              => $paramObj->pma_nt_default ?? null,
            'pph_carry_field_list'        => $paramObj->pph_carry_field_list ?? null,
            'pct_carry_field_list'        => $paramObj->pct_carry_field_list ?? null,
            'pph_print_field_list'        => $paramObj->pph_print_field_list ?? null,
            'prow_per_page'               => $paramObj->prow_per_page ?? null,
            'pnumber_of_copy'             => $paramObj->pnumber_of_copy ?? null,
            'phas_cp'                     => $paramObj->phas_cp ?? null,
            'phas_tain'                   => $paramObj->phas_tain ?? null,
            'phas_taout'                  => $paramObj->phas_taout ?? null,
            'pcopy_enabled'               => $paramObj->pcopy_enabled ?? null,
            'pnxt'                        => $paramObj->pnxt ?? null,
            'pdescription'                => $paramObj->pdescription ?? null,
            'pRet'                        => $paramObj->pRet ?? null,
        ], $connection);
    }
}