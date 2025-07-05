<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-29 18:31:22
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;

class SoPh3 extends SModel
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
    protected $table = 'SoPh3';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = 'stt_rec';
}
