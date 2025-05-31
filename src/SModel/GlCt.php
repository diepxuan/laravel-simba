<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-30 13:30:12
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;

class GlCt extends SModel
{
    public const CREATED_AT = 'cDate';
    public const UPDATED_AT = 'lDate';

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
    protected $table = 'GlCt';
}
