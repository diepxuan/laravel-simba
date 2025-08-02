<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-08-02 18:42:15
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;

class InDmNhvt extends SModel
{
    public const CREATED_AT = 'cdate';
    public const UPDATED_AT = 'ldate';

    /**
     * Indicates if the IDs are auto-incrementing.
     *
     * @var bool
     */
    public $incrementing = false;

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InDmNhvt';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = 'ma_nhvt';

    /**
     * The "type" of the primary key ID.
     *
     * @var string
     */
    protected $keyType = 'string';
}
