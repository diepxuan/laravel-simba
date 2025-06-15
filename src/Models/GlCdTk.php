<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-05 13:22:50
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\GlCdTk as Model;
use Illuminate\Database\Eloquent\Builder;

/**
 * Class GlCdTk.
 *
 * This class represents the model for the general ledger transactions.
 * It provides methods to interact with the stored procedure for generating reports.
 */
class GlCdTk extends Model
{
    /** Filter theo danh sách tài khoản */
    public function scopeFilterByTkList(Builder $query, ?string $list): Builder
    {
        return $query->filterLikeList('tk', $list);
    }

    /** Filter theo mã tiền tệ */
    public function scopeFilterByMaNt(Builder $query, ?string $maNt): Builder
    {
        if (!empty($maNt)) {
            return $query->where('ma_nt', $maNt);
        }

        return $query;
    }
}
