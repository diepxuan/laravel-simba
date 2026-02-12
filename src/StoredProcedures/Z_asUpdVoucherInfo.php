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

class Z_asUpdVoucherInfo
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asUpdVoucherInfo', [
            'pvoucher_code'               => $params['pvoucher_code'] ?? null,
            'pph_table_name'              => $params['pph_table_name'] ?? null,
            'pct_table_name'              => $params['pct_table_name'] ?? null,
            'pcp_table_name'              => $params['pcp_table_name'] ?? null,
            'pmenuid'                     => $params['pmenuid'] ?? null,
            'pph_extra_edit_cotrol_list'  => $params['pph_extra_edit_cotrol_list'] ?? null,
            'psearch_class_name'          => $params['psearch_class_name'] ?? null,
            'pview_class_name'            => $params['pview_class_name'] ?? null,
            'pprint_class_name'           => $params['pprint_class_name'] ?? null,
            'pma_nt_default'              => $params['pma_nt_default'] ?? null,
            'pph_carry_field_list'        => $params['pph_carry_field_list'] ?? null,
            'pct_carry_field_list'        => $params['pct_carry_field_list'] ?? null,
            'pph_print_field_list'        => $params['pph_print_field_list'] ?? null,
            'prow_per_page'               => $params['prow_per_page'] ?? null,
            'pnumber_of_copy'             => $params['pnumber_of_copy'] ?? null,
            'phas_cp'                     => $params['phas_cp'] ?? null,
            'phas_tain'                   => $params['phas_tain'] ?? null,
            'phas_taout'                  => $params['phas_taout'] ?? null,
            'pcopy_enabled'               => $params['pcopy_enabled'] ?? null,
            'pnxt'                        => $params['pnxt'] ?? null,
            'pdescription'                => $params['pdescription'] ?? null,
            'pRet'                        => $params['pRet'] ?? null,
        ], $connection);
    }
}